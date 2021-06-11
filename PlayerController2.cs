using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController2 : MonoBehaviour
{
    GameObject hp;

    //스피드 조정 변수
    [SerializeField]
    private float walkSpeed;
    [SerializeField]
    private float runSpeed;
    [SerializeField]
    private float crouchSpeed;

    private float applySpeed;

    [SerializeField]
    private float jumpForce;

    //상태변수
    private bool isRun = false;
    private bool isCrouch = false;
    private bool isGround = true;

    //얼마나 앉을지 결정
    [SerializeField]
    private float crouchPosY;
    private float originPosY;
    private float applyCrouchPosY;

    //착지 여부
    private CapsuleCollider capsuleCollider;

    //민감도
    [SerializeField]
    private float lookSensitivity;

    //카메라 한계
    [SerializeField]
    private float cameraRotationLimit;
    private float currentCameraRotationX = 0;

    //필요한 컴퍼넌트
    [SerializeField]
    private Camera theCamera;
    private Rigidbody rigid;
    private StatusController theStatusController;

    //플레이어 생명
    private int _lives = 3;
    public int PlayerLives
    {
        get { return _lives; }
        set
        {
            _lives = value;
            if (_lives <= 0)
            {
                Debug.Log("Game Over");
            }
        }
    }

    //public GameObject bullet;
    //public float bulletspeed = 100.0f;

    void Start()
    {
        hp = GameObject.Find("HP");
        capsuleCollider = GetComponent<CapsuleCollider>();
        rigid = GetComponent<Rigidbody>();
        applySpeed = walkSpeed;
        theStatusController = FindObjectOfType<StatusController>();

        //초기화
        originPosY = theCamera.transform.localPosition.y;
        applyCrouchPosY = originPosY;
    }

    void Update()
    {
        IsGround();
        TryJump();
        TryRun();
        TryCrouch();
        Move();
        CharacterRotation();
        CameraRotation();

        /*if (Input.GetMouseButton(0))
        {
            GameObject newBullet = Instantiate(bullet, transform.position + transform.forward, transform.rotation) as GameObject;
            Rigidbody rbBullet = newBullet.GetComponent<Rigidbody>();
            rbBullet.velocity = transform.forward * bulletspeed;
   
        }*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ZOMBIE")
        {
            PlayerLives -= 1;
            PlayerHpControl();
        }
    }

    private void PlayerHpControl()
    {
        hp.GetComponent<Image>().fillAmount -= 0.3f;
        if (hp.GetComponent<Image>().fillAmount <= 0)
        {
            SceneManager.LoadScene("OverScene");
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "MART")
        {
            SceneManager.LoadScene("Market");
        }
        if (other.gameObject.tag == "PHAR")
        {
            SceneManager.LoadScene("Pharmacy");
        }
    }


    /*void OnTriggerEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ZOMBIE")
        {
            PlayerLives -= 1;
        }
    }*/

    //앉기 시도
    private void TryCrouch()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Crouch();
        }
    }
    private void Crouch()
    {
        isCrouch = !isCrouch;
        if (isCrouch)
        {
            applySpeed = crouchSpeed;
            applyCrouchPosY = crouchPosY;
        }
        else
        {
            applySpeed = walkSpeed;
            applyCrouchPosY = originPosY;
        }

        StartCoroutine(CrouchCoroutine());

        //theCamera.transform.localPosition = new Vector3(theCamera.transform.localPosition.x, applyCrouchPosY, theCamera.transform.localPosition.z);
    }

    //부드러운 동작
    IEnumerator CrouchCoroutine()
    {
        float _posY = theCamera.transform.localPosition.y;
        int count = 0;
        while (_posY != applyCrouchPosY)
        {
            count++;
            _posY = Mathf.Lerp(_posY, applyCrouchPosY, 0.3f);
            theCamera.transform.localPosition = new Vector3(0, _posY, 0);
            if (count > 15)
                break;
            yield return null;
        }
        theCamera.transform.localPosition = new Vector3(0, applyCrouchPosY, 0f);
    }

    //지면 체크
    private void IsGround()
    {
        isGround = Physics.Raycast(transform.position, Vector3.down, capsuleCollider.bounds.extents.y + 0.1f);
    }

    //점프 시도
    private void TryJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround && theStatusController.GetCurrentSP()>0)
        {
            Jump();
        }
    }

    //점프
    private void Jump()
    {
        //점프 시 앉은 상태 해제
        if (isCrouch)
        {
            Crouch();
        }
        theStatusController.DecreaseStamina(100);
        rigid.velocity = transform.up * jumpForce;
    }

    //달리기 시도
    private void TryRun()
    {
        if (Input.GetKey(KeyCode.LeftShift) && theStatusController.GetCurrentSP() > 0)
        {
            Running();
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) || theStatusController.GetCurrentSP() <= 0)
        {
            RunningCancel();
        }
    }

    //달리기
    private void Running()
    {
        //앉은 상태에서 달리기
        if (isCrouch)
        {
            Crouch();
        }
        isRun = true;
        applySpeed = runSpeed;
    }

    //달리기 취소
    private void RunningCancel()
    {
        isRun = false;
        applySpeed = walkSpeed;
    }

    //움직임 실행
    private void Move()
    {
        float _moveDirX = Input.GetAxisRaw("Horizontal");
        float _moveDirZ = Input.GetAxisRaw("Vertical");

        Vector3 _moveHorizontal = transform.right * _moveDirX;
        Vector3 _moveVertical = transform.forward * _moveDirZ;

        Vector3 _velocity = (_moveHorizontal + _moveVertical).normalized * applySpeed;

        rigid.MovePosition(transform.position + _velocity * Time.deltaTime);

    }
    //좌우 캐릭터 회전
    private void CharacterRotation()
    {
        float _yRotation = Input.GetAxisRaw("Mouse X");
        Vector3 _characterRotationY = new Vector3(0f, _yRotation, 0f) * lookSensitivity;
        rigid.MoveRotation(rigid.rotation * Quaternion.Euler(_characterRotationY)); 
        //Debug.Log(rigid.rotation);
    }

    //상하 카메라 회전
    private void CameraRotation()
    {
        float _xRotation = Input.GetAxisRaw("Mouse Y");
        float _cameraRotationX = _xRotation * lookSensitivity;
        currentCameraRotationX -= _cameraRotationX;
        currentCameraRotationX = Mathf.Clamp(currentCameraRotationX, -cameraRotationLimit, cameraRotationLimit);

        theCamera.transform.localEulerAngles = new Vector3(currentCameraRotationX, 0f, 0f);
    }

}

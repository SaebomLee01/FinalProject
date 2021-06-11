using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class River : MonoBehaviour
{
    GameObject hp;

    public static bool isWater = false;

    [SerializeField] private float waterDrag; // 물속 중력
    private float originDrag;

    [SerializeField] private Color waterColor; //물속 색깔
    [SerializeField] private float waterFogDensity; //물 탁함 정도

    private Color originColor;
    private float originFogDensity;

    // Start is called before the first frame update
    void Start()
    {
        hp = GameObject.Find("HP");

        originColor = RenderSettings.fogColor;
        originFogDensity = RenderSettings.fogDensity;

        originDrag = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            GetWater(other);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            PlayerHpControl();
            //GetWater(other);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            GetOutWater(other);
        }
    }

    private void PlayerHpControl()
    {
        hp.GetComponent<Image>().fillAmount -= 0.001f;
        if (hp.GetComponent<Image>().fillAmount <= 0)
        {
            SceneManager.LoadScene("OverScene");
        }
    }

    private void GetWater(Collider _player)
    {
        isWater = true;
        _player.transform.GetComponent<Rigidbody>().drag = waterDrag;

        RenderSettings.fogColor = waterColor;
        RenderSettings.fogDensity = waterFogDensity;
    }

    private void GetOutWater(Collider _player)
    {
        if(isWater)
        {
            isWater = false;
            _player.transform.GetComponent<Rigidbody>().drag = originDrag;

            RenderSettings.fogColor = originColor;
            RenderSettings.fogDensity = originFogDensity;
        }
    }
}

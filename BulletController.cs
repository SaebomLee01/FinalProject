using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float bulletTime = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, bulletTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*public Rigidbody prefabBullet;
    public Transform fireTransform;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Fire();
        }
    }

    void Fire()
    {
        Rigidbody shellInstance = Instantiate(prefabBullet, fireTransform.position, fireTransform.rotation) as Rigidbody;
        shellInstance.velocity = 30.0f * fireTransform.forward;
        
        Destroy(gameObject, 2f);
    }*/
}

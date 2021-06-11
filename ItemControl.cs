using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemControl : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GameObject hp = GameObject.Find("hungry_Image");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        GameObject hp = GameObject.Find("hungry_Image");
        if (other.gameObject.tag == "Player")
        {
            hp.GetComponent<HPControl>().HpControl();
            Destroy(gameObject);
        }
    }
}

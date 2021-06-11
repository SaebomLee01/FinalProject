using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterUI : MonoBehaviour
{
    GameObject hp2;
    // Start is called before the first frame update
    void Start()
    {
        hp2 = GameObject.Find("Thirsty");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            HpControl2();
            Destroy(gameObject);
        }
    }

    private void HpControl2()
    {
        hp2.GetComponent<Image>().fillAmount += 0.1f;
    }
}


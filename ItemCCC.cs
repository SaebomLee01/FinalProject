using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCCC : MonoBehaviour
{
    GameObject hp;
    // Start is called before the first frame update
    void Start()
    {
        hp = GameObject.Find("Hungry");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            HpControl();
            Destroy(gameObject);
        }
    }

    private void HpControl()
    {
        Debug.Log("Ate");
        hp.GetComponent<Image>().fillAmount += 0.1f;
    }
}

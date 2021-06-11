using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieManager : MonoBehaviour
{
    float currentTime;
    public float createTime = 1.0f;
    public GameObject zombie;
    public float minTime = 1.0f;
    public float maxTime = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0.0f;
        createTime = UnityEngine.Random.Range(minTime, maxTime);
        Debug.LogFormat("Create Time:{0}", createTime);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > createTime)
        {
            GameObject newZombie = Instantiate(zombie);
            newZombie.transform.position = transform.position;
            currentTime = 0.0f;
            createTime = UnityEngine.Random.Range(minTime, maxTime);
            Debug.LogFormat("Create Time:{0}", createTime);
        }
    }
}

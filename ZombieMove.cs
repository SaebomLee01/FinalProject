using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieMove : MonoBehaviour
{
    public List<Transform> locations;
    public Transform patrolRoute;
    public Transform player;

    private int locationIndex = 0;
    private NavMeshAgent agent;

    private int _lives = 2;
    public int ZombieLives
    {
        get { return _lives; }
        set
        {
            _lives = value;
            if (_lives <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //player = GameObject.Find("Player").transform;
        patrolRoute = GameObject.Find("PatrolRoute").transform;
        InitializePatrolRoute();
        MoveToNextPatrolPoint();
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance < 0.2f && !agent.pathPending)
        {
            MoveToNextPatrolPoint();
        }
    }

    void InitializePatrolRoute()
    {
        foreach (Transform child in patrolRoute)
        {
            locations.Add(child);
        }
    }

    void MoveToNextPatrolPoint()
    {
        agent.destination = locations[locationIndex].position;
        locationIndex = (locationIndex + 1) % locations.Count;
    }
    
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "BULLET")
        {
            ZombieLives -= 1;
            Debug.Log("Enemy Hit!");
        }
        else if(collider.gameObject.tag == "RIVER")
        {
            ZombieLives -= 2;
        }
    }
}

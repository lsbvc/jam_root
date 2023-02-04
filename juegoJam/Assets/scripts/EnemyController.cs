using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    //public Transform[] patrolPoints;
    //public int currentPatrolPoint;
    public NavMeshAgent agent;

    private float counter;
    private float secondsType;
    private bool wall = false;

    void Start()
    {

    }

    void Update()
    {
        //  float distanceToPlayer = Vector3.Distance(transform.position, PlayerController.instance.transform.position); //distancia esqueleto - jugador
        if (Vector3.Distance(CameraLook.instance.transform.position, transform.position) > 1)
            agent.SetDestination(CameraLook.instance.transform.position);
        else
            Destroy(gameObject);

        if(wall == true)
        {
            counter -= Time.deltaTime;
            agent.velocity = Vector3.zero; //que se pare
            agent.isStopped = true; //Que no se deslice
            if (counter <= 0)
            {
                wall = false;
                agent.isStopped = false;
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("wall1"))
        {
            wall = true;
            if (gameObject.tag.Equals("Fire"))
                counter = 2.0f;
            else if (gameObject.tag.Equals("other"))
                counter = 1.0f;
            else if (gameObject.tag.Equals("Stone"))
                counter = 0.0f;
            Debug.Log("Muro");
        }
    }
}
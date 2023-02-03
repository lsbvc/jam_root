using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    //public Transform[] patrolPoints;
    //public int currentPatrolPoint;
    public NavMeshAgent agent;

    //Para que pare a veces y no este siempre andando
    public float waitAtPoint = 2f;
    private float waitCounter;

    void Start()
    {
        waitCounter = waitAtPoint;
    }

    void Update()
    {
        //  float distanceToPlayer = Vector3.Distance(transform.position, PlayerController.instance.transform.position); //distancia esqueleto - jugador
        agent.SetDestination(CameraLook.instance.transform.position);
      // agent.SetDestination(patrolPoints[currentPatrolPoint].position); //dice cuál es el destino
        //currentPatrolPoint++;
        ////Reinicia si acaba
        //if (currentPatrolPoint >= patrolPoints.Length)
        //{
        //    currentPatrolPoint = 0;
        //}         
        //agent.velocity = Vector3.zero; //que se pare
     //   agent.isStopped = true; //Que no se deslice

    }
}
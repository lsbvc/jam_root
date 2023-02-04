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
   // public AudioSource audio1;

    void Start()
    {
      //  audio1.Play();
    }

    void Update()
    {
        //Virus is in root you lose 
        if (Vector3.Distance(CameraLook.instance.transform.position, transform.position) > 1)
            agent.SetDestination(CameraLook.instance.transform.position);
        else
        {
            GameManager.instance.GameOver();
           // audio1.Stop();
            //AudioManager.instance.StopTraslation();
            Destroy(gameObject);
            Debug.Log("Delete");
        }

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
        if(other.tag.Equals("wall2"))
        {
            wall = true;
            if (gameObject.tag.Equals("Fire"))
                counter = 2.0f;
            else if (gameObject.tag.Equals("Fence"))
                counter = 1.0f;
            else if (gameObject.tag.Equals("Stone"))
                counter = 0.0f;
            Debug.Log("Muro");
        }
        if (other.tag.Equals("wall1"))
        {
            wall = true;
            if (gameObject.tag.Equals("Fire"))
                counter = 1.0f;
            else if (gameObject.tag.Equals("Fence"))
                counter = 0.0f;
            else if (gameObject.tag.Equals("Stone"))
                counter = 2.0f;
            Debug.Log("Muro");
        }
    }

    public void KillEnemy()
    {
        if (Vector3.Distance(CameraLook.instance.transform.position, transform.position) > 5)
            GameManager.instance.UpdatePoints(5);
        else if (Vector3.Distance(CameraLook.instance.transform.position, transform.position) > 3)
            GameManager.instance.UpdatePoints(3);
        else if (Vector3.Distance(CameraLook.instance.transform.position, transform.position) > 1)
            GameManager.instance.UpdatePoints(1);
        
        Destroy(gameObject);    
    }
}
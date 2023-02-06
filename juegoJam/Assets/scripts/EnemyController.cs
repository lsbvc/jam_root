using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class EnemyController : MonoBehaviour
{
    //public Transform[] patrolPoints;
    //public int currentPatrolPoint;
    public NavMeshAgent agent;

	// Generate enemy's name:
	public string name = "";
	public TMP_Text TextField;

    private float counter;
    private float secondsType;
    private bool wall = false;
    public AudioSource audio1;

    void Start()
    {
		name = newName();
		if (name == "")
		{
			Destroy(gameObject);
			return;
		}
		TextField.text = name;
        audio1.Play();
    }

    void Update()
    {
        //Virus is in root you lose 
        if (Vector3.Distance(CameraLook.instance.transform.position, transform.position) > 3)
        	agent.SetDestination(CameraLook.instance.transform.position);
        else
        {
            GameManager.instance.GameOver();
            //audio1.Stop();
            //AudioManager.instance.StopTraslation();
            Destroy(gameObject);  
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
        if(other.tag.Equals("wallStone"))
        {
            wall = true;
            if (gameObject.tag.Equals("Fire"))
                counter = 2.0f;
            else if (gameObject.tag.Equals("Metal"))
                counter = 1.0f;
            else if (gameObject.tag.Equals("Stone"))
                counter = 0.0f;
            Debug.Log("MuroStone");
        }
        if (other.tag.Equals("wallMetal"))
        {
            wall = true;
            if (gameObject.tag.Equals("Fire"))
                counter = 1.0f;
            else if (gameObject.tag.Equals("Metal"))
                counter = 0.0f;
            else if (gameObject.tag.Equals("Stone"))
                counter = 2.0f;
            Debug.Log("MuroMetal");
        }
        if (other.tag.Equals("wallFire"))
        {
            wall = true;
            if (gameObject.tag.Equals("Fire"))
                counter = 0.0f;
            else if (gameObject.tag.Equals("Metal"))
                counter = 2.0f;
            else if (gameObject.tag.Equals("Stone"))
                counter = 1.0f;
            Debug.Log("MuroFuego");
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
		currentEnemies.Remove(name);
        
        Destroy(gameObject);    
    }


	// Enemy name generation
	static string[] pathList = {
		"/usr/",
		"/bin/",
		"/etc/"
	};

	static string[] nameList = {
		"virus.vir",
		"trojan.vir",
		"covid.vir",
		"spy.vir"
	};

	static public List<string> currentEnemies = new List<string>();

	public string newName()
	{
		string ret = pathList[Random.Range(0, pathList.Length)] + nameList[Random.Range(0, nameList.Length)];

		if (currentEnemies.Contains(ret))
		{
			Debug.Log("Enemy: " + ret + " already exists!");
			return "";
		}
		currentEnemies.Add(ret);

		return ret;
	}
}

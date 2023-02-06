using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int totalPoints = 0;
    
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        Debug.Log("FIN");
        UIManager.instance.end.gameObject.SetActive(true);
        //Change scene to main menu
    }
    public void GameWin()
    {
        Debug.Log("win");
        UIManager.instance.win.gameObject.SetActive(true);
        //Change scene to main menu
    }

    public void UpdatePoints(int points)
    {
        totalPoints += points;  
    }

}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public TMP_Text timer;
    public Canvas end;
    public Canvas win;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        end.gameObject.SetActive(false);
        win.gameObject.SetActive(false);
    }
    void Update()
    {
        
    }
}

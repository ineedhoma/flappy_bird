using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
   
    private void Awake()
    {
        
    }
    public void de()
    {
        
        SceneManager.LoadScene(2);

    }

    public void kho()
    {
        
        SceneManager.LoadScene(1);
    }

    private void Update()
    {
        
    }
}

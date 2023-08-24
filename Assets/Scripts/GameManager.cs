using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public int enemyCount;
    public int enemiesKilled = 0;

    private void Awake() {
        if (instance != null && instance != this) 
    { 
        Destroy(this); 
    } 
    else 
    { 
        instance = this; 
    } 
    }

    // Start is called before the first frame update
    void Start()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        Debug.Log(enemyCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddEnemyKillCount()
    {
        enemiesKilled++;
        Debug.Log(enemiesKilled);
    }
}

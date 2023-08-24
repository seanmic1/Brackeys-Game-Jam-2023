using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KillCountScript : MonoBehaviour
{
    
    private TextMeshProUGUI tmp;

    // Start is called before the first frame update
    void Start()
    {
        tmp = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        tmp.text = "Enemies killed: "+GameManager.instance.enemiesKilled+"/"+GameManager.instance.enemyCount;
    }
}

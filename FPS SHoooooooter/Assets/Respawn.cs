using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Respawn : MonoBehaviour
{
    public GameObject theEnemy;
    public float xpos;
    public float ypos;
    public float zpos;
    public int enemyCount;
    

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }
    IEnumerator EnemyDrop()
    {
        while(enemyCount <= 6)
        {
            xpos = Random.Range(-14.12f, 4.08f);
            ypos = Random.Range(-0.43f, 0.52f);
            zpos = Random.Range(-0.89f, -19.35f);
            Instantiate(theEnemy, new Vector3(xpos, ypos, zpos), Quaternion.identity);
            yield return new WaitForSeconds(5f);
            enemyCount++;

        }
    }
    
}
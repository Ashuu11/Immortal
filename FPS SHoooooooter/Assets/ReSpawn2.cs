using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReSpawn2 : MonoBehaviour
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
        while (enemyCount <= 10)
        {
            xpos = Random.Range(-22.9f, -119.02f);
            ypos = Random.Range(-35f, -35f);
            zpos = Random.Range(-57f, 27.7f);
            Instantiate(theEnemy, new Vector3(xpos, ypos, zpos), Quaternion.identity);
            yield return new WaitForSeconds(3.5f);
            enemyCount++;

        }
    }

}
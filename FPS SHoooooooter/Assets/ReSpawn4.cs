using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReSpawn4 : MonoBehaviour
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
        while (enemyCount <= 30)
        {
            xpos = Random.Range(-131.6f, 136.1f);
            ypos = Random.Range(2.32f, 2.32f);
            zpos = Random.Range(-295.2f, 250.7f);
            Instantiate(theEnemy, new Vector3(xpos, ypos, zpos), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            enemyCount++;

        }
    }

}
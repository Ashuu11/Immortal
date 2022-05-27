using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReSpawn3 : MonoBehaviour
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
            xpos = Random.Range(-122.2f, -1.5f);
            ypos = Random.Range(1.436f, 3.116f);
            zpos = Random.Range(-26.87f, 92.2f);
            Instantiate(theEnemy, new Vector3(xpos, ypos, zpos), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            enemyCount++;

        }
    }

}
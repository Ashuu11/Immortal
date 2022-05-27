using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class Enemy : TargetScript
{
    public Animator animator;
    public float heath = 100;
    public NavMeshAgent navMeshAgent;
    bool isDead;
    float coolDown = 0.5f;
    Transform target;
    public GameObject deadEffect;
    public GameManager gm;
   
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (navMeshAgent.remainingDistance < 1 && !isDead)
        {
            animator.SetTrigger("Attack");
        }

        if (isHit && coolDown <= 0 && !isDead)
        {
            Debug.Log("Hit");
            animator.SetTrigger("Hurt");
            heath -= 30;
            coolDown = 0.5f;

            if (heath <= 0)
            {
                gm.UpdateScore(10);
                animator.SetTrigger("Dead");
                navMeshAgent.isStopped = true;
                isDead = true;
                StartCoroutine(Dead());
            }
            else
            {
                animator.SetTrigger("Hurt");
                navMeshAgent.isStopped = true;
            }

            isHit = false;
            
        }
        else if (coolDown <= 0)
        {
            if (!isDead)
            {
                navMeshAgent.isStopped = false;
                navMeshAgent.SetDestination(target.position);
            }
        }
        if (coolDown > 0)
        {
            coolDown -= Time.deltaTime;
        }
    }
    IEnumerator Dead()
    {
        yield return new WaitForSeconds(1.5f);
        GameObject _effect = Instantiate(deadEffect, transform.position, Quaternion.identity);
        Destroy(_effect, 3f);
        Destroy(gameObject);
    }
}

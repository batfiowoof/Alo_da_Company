﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleEnemy : Enemyy
{
    public float stopdDistance;

    private float attackTime;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask PlayerLayer;

   /*private void Update()
    {
        if (player != null)
        {
            if (Vector2.Distance(transform.position, player.position) > stopdDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            }
            else
            {
                if (Time.time >= attackTime)
                {
                    StartCoroutine(Attack());
                    attackTime = Time.time + timeBtwAttacks;
                }
            }
        }
    }


    IEnumerator Attack()
    {
        player.GetComponent<Player_Movement>().TakeDamage(dmg);

        yield return null;
    }

  /*  public void AttackMotion()
    {
        anim.SetTrigger("attack");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, PlayerLayer);


        foreach (Collider2D player in hitEnemies)
        {
            player.GetComponent<Enemyy>().TakeDamage(dmg);
        }
    }

    public void OnDrawGizmosSelected()//draw stuff in the editor that are usually unseeable
    {
        if (attackPoint == null)
        {
            return;
        }
        Gizmos.DrawSphere(attackPoint.position, attackRange);
    }
    */
}

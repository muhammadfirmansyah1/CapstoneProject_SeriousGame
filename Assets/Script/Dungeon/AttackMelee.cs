using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackMelee : MonoBehaviour
{
    public static AttackMelee instance;
    private float timeBtwAttack;
    public float startTimeBtwAttack;

    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRange;
    public int damage;

    public Animator Sword;

    EnemyController healthEnemy;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        Sword = GetComponent<Animator>();
        healthEnemy = FindObjectOfType<EnemyController>();
    }

    void Update()
    {
       // GameObject.Find("Attack").GetComponent<Button>().onClick.AddListener(AttackMele);
    }

    void OnDrawGizmosSelected() 
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
    public void Attack()
    {
        Sword.SetTrigger("Attack");
        Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
        for(int i=0; i< enemiesToDamage.Length; i++)
        {
                    enemiesToDamage[i].GetComponent<EnemyController>().TakeDamage(damage);
        }
    }

    public void NotAttack()
    {
        //Sword.SetTrigger("Attack");
    }
}

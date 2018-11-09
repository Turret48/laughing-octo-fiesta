using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed;
    private Transform playerPos;
    private Player player;
    public int enemyHealth= 3;

    public GameObject bulletHitEnemy;
    public GameObject spaceGem;

    

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;

        
    }


    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed *Time.deltaTime);

        if(enemyHealth <= 0)
        {
            EnemyKilled();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.health--;
            //Debug.Log(player.health);
            EnemyCollision();
        }

        if (other.CompareTag("Projectile"))
        {
            enemyHealth--;
            
        }
    }

   

   
    void EnemyCollision()
    {
        Destroy(gameObject);
        Instantiate(bulletHitEnemy, gameObject.transform.position, gameObject.transform.rotation);
      
    }

    void EnemyKilled()
    {
        Destroy(gameObject);
        Instantiate(bulletHitEnemy, gameObject.transform.position, gameObject.transform.rotation);
        Instantiate(spaceGem, gameObject.transform.position, gameObject.transform.rotation);
       
    }
 




}

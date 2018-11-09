using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceGems : MonoBehaviour {

    public float speed;
    private Transform playerPos;
    private Player player;

   
    

    // Use this for initialization
    void Start () {

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;

    }
	
	// Update is called once per frame
	void Update () {

        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
        


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.gemsNumber++;
            Destroy(gameObject);
            Debug.Log("Gems: " + player.gemsNumber);

        }
    }

}

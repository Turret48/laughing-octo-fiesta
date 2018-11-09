using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    private Vector2 target;
    public float speed;
    public float lifeTime;

    public GameObject bulletHit;

    private void Start()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Invoke("DestroyProjectile", lifeTime);
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, target) < 0.2f)
        {
            DestroyProjectile();
        }
     
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            DestroyProjectile();
        }

    }

    void DestroyProjectile()
    {
        Instantiate(bulletHit, gameObject.transform.position, gameObject.transform.rotation);
        Destroy(gameObject);
    }
}

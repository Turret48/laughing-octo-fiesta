using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public GameObject shot;
    private float timeBtwShots;
    public float startTimeBtwShots;
    public Transform shotPoint;

    public float offset;


    private void Start()
    {
        //playerPos = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update ()
    {

        if (timeBtwShots <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(shot, shotPoint.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }

      
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {

        //GameObject boom = Instantiate(explosion, transform.position, transform.rotation);
        //trail.GetComponent<ParticleSystem>().Stop();

        Destroy(gameObject);

        Debug.Log("Occured");

    }
}

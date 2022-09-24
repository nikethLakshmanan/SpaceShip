using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleBehavior : MonoBehaviour
{
    public GameObject trail;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        trail.GetComponent<ParticleSystem>().Play();
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(60f * Vector3.forward);
    }

    // Update is called once per frame
    void Update()
    {


        trail.transform.position = transform.position;
        if (transform.position.z > 70)
        {
            Destroy(gameObject);
            
        }
    }
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.name == "StarSparrow6(Clone)")
        {
            Destroy(trail);
            Destroy(gameObject);
        }

    }
}

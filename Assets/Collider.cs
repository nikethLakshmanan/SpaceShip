using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    public GameObject explosion;
    public GameObject trail;

    public GameObject Spawn1;
    public GameObject Spawn2;

    public GameObject Pos1;
    public GameObject Pos2;
    public GameObject Pos3;
    public GameObject Pos4;
    public GameObject Pos5;
    public GameObject Pos6;

    int integer = 0;

    bool reached = false;

    public bool doStuff = true;


    Vector3 path;
    Vector3[] array;
    int count = 0;
     

    // Start is called before the first frame update
    void Start()
    {
        
        array = new Vector3[] { Pos1.transform.position, Pos2.transform.position, Pos3.transform.position, Pos4.transform.position, Pos5.transform.position, Pos6.transform.position };
        path = array[0];

    }

    // Update is called once per frame
    void Update()
    {
        if (doStuff)
        {
            if (transform.position == path)
            {
                if (path == null)
                {
                    Debug.Log("isnull");
                }
                if (false)
                {

                    reached = true;
                }
                path = array[count++];
            }
            if (integer == 2)
            {
                count = 3;
            }
            if (!reached)
            {
                transform.position = Vector3.MoveTowards(transform.position, path, Time.deltaTime * 20);
            }

            if (reached)
            {
                transform.Translate(Vector3.forward);
            }

            
        }

    }
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.name != "StarSparrow6(Clone)")
        {
            GameObject boom = Instantiate(explosion, transform.position, transform.rotation);


            Object.Destroy(boom, 2.0f);



            trail.GetComponent<ParticleSystem>().Stop();

            Destroy(gameObject);

            Destroy(trail);
            

            Debug.Log("Occured");
        }

    }


    public void setMoves(int var)
    {
        integer = var;
    }

    

    
}

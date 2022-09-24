using System.Collections;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject missiles;
    public Transform gunEnd;

    public GameObject trail;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start() 
    {

    }

    // Update is called once per frame
    void Update()
    {

        
        if (Input.GetKeyDown(KeyCode.Space))
        {

            GameObject trailInstance = Instantiate(trail, gunEnd.position, gunEnd.rotation);

            GameObject missileInstance = Instantiate(missiles, gunEnd.position, gunEnd.rotation);

            missileInstance.AddComponent<MissleBehavior>();


            missileInstance.GetComponent<MissleBehavior>().trail = trailInstance;
            missileInstance.GetComponent<MissleBehavior>().explosion = explosion;




        }
    }
}

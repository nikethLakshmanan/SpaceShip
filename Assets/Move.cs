using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Quaternion tilt, noTilt, left, right;

    // Start is called before the first frame update
    void Start()
    {
        noTilt = transform.rotation;
        left = Quaternion.Euler(noTilt.eulerAngles.x, noTilt.eulerAngles.y, noTilt.eulerAngles.z + 45.0f);
        right = Quaternion.Euler(noTilt.eulerAngles.x, noTilt.eulerAngles.y, noTilt.eulerAngles.z - 45.0f);


    }

    // Update is called once per frame


    // Update is called once per frame
    void Update()
        {  
                if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 55)
                {
                    transform.Translate(new Vector3(0.2f, 0, 0), Space.World);
                }
                if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -55)
                {
                    transform.Translate(new Vector3(-0.2f, 0, 0), Space.World);
        }


        if (Input.GetAxis("Horizontal") < 0)
            tilt = left;
        else if (Input.GetAxis("Horizontal") > 0)
            tilt = right;
        else
        {
            tilt = noTilt;
        }

        transform.rotation = Quaternion.Slerp(transform.rotation, tilt, Time.deltaTime* 2.0f);
        


        }
    

}


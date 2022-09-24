using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject enemy;
    public Transform loc;

    public GameObject spawn1;
    public GameObject spawn2;


    public GameObject enemyInstance;

    public float timer = 6f;

    private bool stop = true;



    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (stop)
        {
            GameObject.Find("StarSparrow6").SetActive(false);
            stop = false;
        }
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            System.Random rnd = new System.Random();

            int random = rnd.Next(1, 3);

            if(random == 1)
            {
                

                enemyInstance = Instantiate(enemy, spawn1.transform.position, spawn1.transform.rotation);
                enemyInstance.SetActive(true);
                enemyInstance.SendMessage("setMoves", 1, SendMessageOptions.DontRequireReceiver);


            }

            if (random == 2)
            {


                enemyInstance = Instantiate(enemy, spawn2.transform.position, spawn2.transform.rotation);
                enemyInstance.SetActive(true);
                enemyInstance.SendMessage("setMoves", 1);
            }



            



            







            timer = 6f;
        }




    }

}

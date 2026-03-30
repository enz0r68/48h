using Unity.VisualScripting;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    //TIMER
    public float time;


    public bool obj1IS = true;
    public int score = 0;

    public GameObject obj1;
    public GameObject obj2;
    /*public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    public GameObject obj6;
    public GameObject obj7;
    public GameObject obj8;
    public GameObject obj9;*/

    int number;
    int Object;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   /*RANDOM NUMBER
         number = Random.Range(1, 6);
         Debug.Log("Nombre is: " + number);
        */
        Object = 0;
        time = 7;
    }

    // Update is called once per frame
    void Update()
    {

        if (time > 0)
        {
            Timer();
        }
        
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            Destroy(obj1);
            
            if (obj1IS)
            {
                Object += 1;
                score += 100;
                obj1IS = false;
            }  
        }

        Debug.Log("nb : " + Object + " score" + score + " Time Left: " + time);
    }


    public void Timer()
    {
        time -= Time.deltaTime;
       if (time <= 0)
        {
            Destroy(obj2);
        }
    }
    
    
}

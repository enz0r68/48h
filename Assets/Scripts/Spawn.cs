using JetBrains.Annotations;
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

    public GameObject porte1;
    public GameObject porte2;  
    public GameObject porte3;
    public GameObject porte4;
    public int number;
    int Object;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   // RANDOM NUMBER
        // number = Random.Range(0, 3);
        number = 2;
        porte1.SetActive(false);
        porte2.SetActive(false);
        porte3.SetActive(false);
        porte4.SetActive(false);
        
        Object = 0;
        time = 7;
        switch (number)
        {
            case 0:
                porte1.SetActive(true);
                break;
            case 1:
                porte2.SetActive(true);
                break;
            case 2:
                porte3.SetActive(true);
                break;
            case 3:
                porte4.SetActive(true);
                break;
            case 4:
                default:
                break;
        }
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
        // Debug.Log("Nombre is: " + number);
        //Debug.Log("nb : " + Object + " score" + score + " Time Left: " + time);
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

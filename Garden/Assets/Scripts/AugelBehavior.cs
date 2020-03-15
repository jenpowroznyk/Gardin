using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AugelBehavior : MonoBehaviour
{
    // Start is called before the first frame update

    // determines what condition the flower is in. ex: 1 = seedling, 2 = grown, 3 = in danger, 
    //public int lifeStage;


    public int health;
    public bool col;
    public bool dead;
    
    void Start()
    {
        //lifeStage = 2;
        health = 4;
        col = false;
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void loadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        health = data.healthSave;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Limette")
        {
            RemoveOneHealth();
          //  Debug.Log("collided");
           
        }
    }

    void RemoveOneHealth()
    {
      
         health = health - 1;
       
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

        void Update()
    {
        
    }



}

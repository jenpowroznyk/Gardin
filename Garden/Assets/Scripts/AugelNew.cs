using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AugelNew : MonoBehaviour
{
    private Vector3 thisFlowerPos;
    public ArrayList limettePos;
    GameObject[] limettes;
    public float maxFlowerDistance;
    public int numberOfCloseLimettes;
    
    // Start is called before the first frame update
    void Start()
    {
        thisFlowerPos = gameObject.GetComponent<Transform>().position;
        limettes = GameObject.FindGameObjectsWithTag("Limette");
        limettePos = new ArrayList();

   
        numberOfCloseLimettes = 0;
        GetTransformOfOtherFlowers();

    }

    void GetTransformOfOtherFlowers()
    {
        GameObject currentLim;
        Vector3 currentLimPos;
        float flowerDistance;

        for (int i = 0; i < limettes.Length; i++)
        {
           currentLim = limettes[i];
           currentLimPos = currentLim.transform.position;

           flowerDistance = Vector3.Distance(thisFlowerPos, currentLimPos);
           //limettePos.Add(currentLimPos);

           if (flowerDistance < maxFlowerDistance)
           {
                numberOfCloseLimettes = numberOfCloseLimettes + 1;
           }
        }
    }

      

    // Update is called once per frame 
    void Update()
    {
       
        // Vector3.Distance(plant.transform.pos, plant2.tranform.position) < distanceToLoseHealth) { kill plant}




    }
}

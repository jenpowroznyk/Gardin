using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateTracker : MonoBehaviour
{
    public bool refreshed;
    private string date;

    // Start is called before the first frame update
    void Start()
    {
        date = System.DateTime.Now.ToString();
        refreshed = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            refreshed = true;

        }
        else 
        {
            refreshed = false;
        }

     
    }
}

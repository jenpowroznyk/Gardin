using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData{

    public int healthSave;

    public PlayerData (AugelBehavior augel)
    {
        healthSave = augel.health;

    }

}

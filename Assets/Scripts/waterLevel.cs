using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// Percentage water that goes down
/// decrease water takes in integer percent
/// 
/// Average - 100 gallons/day
/// 
/// Bath - 36 gallons
/// Shower - 5 gal/min
/// Hand wash - 1 gallon
/// Dishwasher - 10 gallons
/// Cloths washer - 25 gallons
/// Toilet - 3 gallons
/// 
/// </summary>
public class waterLevel : MonoBehaviour {


    [Tooltip("Water level in percentage")]
    public static int water;


	// Use this for initialization
	void Start () {
        water = 100;
	}
	
    // Takes in water level intake to decrease gal
    public void decreaseWater(int intake){
        water = water - intake;
        Debug.Log("Water level:" + water);
    }

    // Resets water level to max
    public void ResetWater(){
        water = 100;
        Debug.Log("Water level reset: " + water);
    }



    public static int GetWaterLevel(){
        return water;
    }
}

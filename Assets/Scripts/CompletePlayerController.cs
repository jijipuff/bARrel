using UnityEngine;
using System.Collections;

//Adding this allows us to access members of the UI namespace including Text.
using UnityEngine.UI;

public class CompletePlayerController : MonoBehaviour
{
    private int count;              //Integer to store the number of pickups collected so far.
    public Text countText;          //Store a reference to the UI Text component which will display the number of pickups collected.


    // Use this for initialization
    void Start()
    {
        //Initialize count to zero.
        count = 0;

        //Call our SetCountText function which will update the text with the current value for count.
        SetCountText();
    }



    //OnTriggerEnter2D is called whenever this object overlaps with a trigger collider.
    void Update()
    {



        //Update the currently displayed count by calling the SetCountText function.
        SetCountText();
    }

    //This function updates the text displaying the number of objects we've collected and displays our victory message if we've collected all of them.
    void SetCountText()
    {
        //Set the text property of our our countText object to "Count: " followed by the number stored in our count variable.
        if (waterLevel.GetWaterLevel() > 0)
        {
            countText.text = "Count: " + waterLevel.GetWaterLevel() + "gal below!";
        } else{
            countText.text = "Count: " + -1 * waterLevel.GetWaterLevel() + "gal above!";
        }

    }
}
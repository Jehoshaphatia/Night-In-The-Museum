using UnityEngine;
using System.Collections;

public class StartPoint : MonoBehaviour
{
    public GameObject player;
    public GameObject playPoint;

    public bool playerWon = false;

    // Use this for initialization
    void Start()
    {
      //player.transform.position = startPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enterGalary()
    { //Begin the puzzle sequence
        iTween.MoveTo(player,
            iTween.Hash(
                "position", playPoint.transform.position,
                "time", 2,
                "easetype", "linear"
            )
        );

    }

}
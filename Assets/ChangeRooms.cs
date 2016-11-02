using UnityEngine;
using System.Collections;

public class ChangeRooms : MonoBehaviour {

    public Location destination;
    public enum Location { lobby, kitchen, desk, corner, lab};

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // On "gaze ender / click method, move to next frame
    // TODO: Add Teleport Function
    public void OnClick()
    {
        Debug.Log("Teleporting to " + destination.ToString());
        switch (destination)
        {
            case Location.lobby:
                Camera.main.transform.position = new Vector3(0, 0, 0);
                break;
            case Location.kitchen:
                Camera.main.transform.position = new Vector3(10, 0, -4);
                break;
            case Location.desk:
                Camera.main.transform.position = new Vector3(20, 0, -4);
                break;
            case Location.corner:
                Camera.main.transform.position = new Vector3(20, 0, -15);
                break;
            case Location.lab:
                Camera.main.transform.position = new Vector3(10, 0, -15);
                break;
        }
    }
}

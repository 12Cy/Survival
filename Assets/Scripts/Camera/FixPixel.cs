using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixPixel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public static Vector2 RoundToNearestPixel(Vector2 pos, Camera viewingCamera)

    {

        Vector2 valueInPixels = (Screen.height / (viewingCamera.orthographicSize * 2.0f)) * pos;

        valueInPixels.x = Mathf.Round(valueInPixels.x);

        valueInPixels.y = Mathf.Round(valueInPixels.y);


        Vector2 adjustedUnityUnits = valueInPixels / (Screen.height / (viewingCamera.orthographicSize * 2.0f));

        return adjustedUnityUnits;

    }
}

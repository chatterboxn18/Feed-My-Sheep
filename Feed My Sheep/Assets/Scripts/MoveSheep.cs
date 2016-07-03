using UnityEngine;
using System.Collections;

public class MoveSheep : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            float x = -3.5f + 7 * touch.position.x / Screen.width;
            float y = -5.0f + 10 * touch.position.y / Screen.height;
            transform.position = new Vector3(x, y, 0);
            string message = "X: " + touch.position.x + " Y:" + touch.position.y;
            GUI.Label(new Rect(0, 0, 120, 100), message);
            
        }

	}
}

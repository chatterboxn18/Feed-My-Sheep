using UnityEngine;
using System.Collections;

public class MoveSheep : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            float x = -4.5f + 9 * touch.position.x / Screen.width;
            float y = -7.5f + 15 * touch.position.y / Screen.height;

            transform.position = new Vector3(x, y, 0);
        }
	}
}

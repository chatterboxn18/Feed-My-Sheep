using UnityEngine;
using System.Collections;

public class TouchScreen : MonoBehaviour {

	void Update () {
//Touch is a struct, not a class
        Touch myTouch = Input.GetTouch(0);
	}
}

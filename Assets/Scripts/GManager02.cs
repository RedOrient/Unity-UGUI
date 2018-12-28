using UnityEngine;
using System.Collections;

public class GManager02 : MonoBehaviour {

    public Transform GameCube;
    public float GameCube_speed = 10;
    public void OnSliderRotation(float value)
    {
        Debug.Log("heihei");
        GameCube_speed = value;
    }
	
	// Update is called once per frame
	void Update () {
        GameCube.Rotate(Vector3.up * Time.timeScale * GameCube_speed);
    }
}

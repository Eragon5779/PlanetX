using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbiter : MonoBehaviour {
    public GameObject parent;
    public float speed;
    internal float rot;
    internal float distance;
    internal float yoff;

    // Use this for initialization
    void Start () {
        //Time.timeScale = 0.1f;
        var dif = this.transform.position - parent.transform.position;
        distance = this.transform.localPosition.magnitude;
        yoff = this.transform.localPosition.y;

        rot = Mathf.Atan2(dif.z, dif.x);
	}
	
	// Update is called once per frame
	void Update () {
        rot += speed * Time.deltaTime;

        this.transform.localPosition = new Vector3(Mathf.Cos(rot), 0, Mathf.Sin(rot)) * distance;
	}
}

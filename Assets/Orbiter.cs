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
        var dif = this.transform.position - parent.transform.position;
        distance = this.transform.localPosition.magnitude;
        yoff = this.transform.localPosition.y;

        rot = Mathf.Atan2(dif.z, dif.x);
	}
	
	// Update is called once per frame
	void Update () {
        rot += speed * Time.deltaTime;

        this.transform.localPosition = new Vector3(Mathf.Cos(rot), yoff, Mathf.Sin(rot)) * distance;
	}
}

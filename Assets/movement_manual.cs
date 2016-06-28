using UnityEngine;
using System.Collections;

public class movement_manual : MonoBehaviour {

    public float speed;
    public GameObject pet;

	void Start () {
        speed = 0.1f;
        transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
    }
	    
	void FixedUpdate () {
        if (Input.GetKey("w")){
            this.transform.position += new Vector3(0,speed,0);
        }
        if (Input.GetKey("s"))
        {
            this.transform.position += new Vector3(0, -speed, 0);
        }
        if (Input.GetKey("a"))
        {
            this.transform.position += new Vector3(-speed, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            this.transform.position += new Vector3(speed, 0, 0);
        }

    }
}

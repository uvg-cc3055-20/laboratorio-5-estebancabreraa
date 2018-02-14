using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {

    public float time = 0;
    public bool active = true;
    public GameObject child;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if ((time >= 2))
        {
            active = !active;
            child.SetActive(active);
            time = 0;
            
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    private string property;

    public string Property
    {
        get
        {
            return property;
        }

        protected set
        {
            property = value;
        }
    }

    private new string name;

    public string Name
    {
        get
        {
            return name;
        }

        protected set
        {
            name = value;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

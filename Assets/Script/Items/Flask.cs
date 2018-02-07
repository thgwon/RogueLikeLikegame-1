using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flask : Item {

    int hpChange;
    int mpChange;
    int hungerChange;


    public int HPChange
    {
        get
        {
            return property;
        }

        private set
        {
            property = value;
        }
    }
    //set은 private
    public int MPChange
    {
        get
        {
            return property;
        }

        private set
        {
            property = value;
        }
    }
    //set은 private
    public int HungerChange
    {
        get
        {
            return name;
        }

        private set
        {
            name = value;
        }
    }
    //set은 private

    public Flask( string itemName, string itemProperty = "Null", int HPchange = 0, int MPchange = 0) : base(itemName, itemProperty) {
        this.HPchange = HPchange;
        this.MPchange = MPchange;
        this.HungerChange = hungerChange;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

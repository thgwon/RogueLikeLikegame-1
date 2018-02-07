using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : Item {

    int defensivePower;

    public int DefensivePower
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

    public Armor( string itemName, int defensivePower) : base(itemName) {
        this.defensivePower = defensivePowerInput;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item {

    int attackPower;

    public int AttackPower
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

    public Weapon( string itemName, int attackPower ) : base(itemName) {
        this.attackPower = attackPower;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

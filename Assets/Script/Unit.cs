using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour {
    private int attack;
    private int defense;
    private int hp;
    private List<Status> statusList;

    public int Attack
    {
        get
        {
            return attack;
        }

        set
        {
            attack = value;
        }
    }
    public int Defense
    {
        get
        {
            return defense;
        }

        set
        {
            defense = value;
        }
    }
    public int Hp
    {
        get
        {
            return hp;
        }

        set
        {
            hp = value;
        }
    }
    

    public abstract void changeAttack(int delta);
    public abstract void changeHp(int delta);
    public abstract void changeDefense(int delta);
}




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public int bladderCapacity;
    public int strenk;
    public int brain;

    public Stats(int bladderCapacity, int strenk, int brain)
    {
        this.bladderCapacity = bladderCapacity;
        this.strenk = strenk;
        this.brain = brain;
    }
}
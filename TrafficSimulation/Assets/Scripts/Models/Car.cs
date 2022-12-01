using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Root
{
    public Car[] Car;
}

public class Car 
{
    public int id;
    public int initial_lane;
    public int lane;
    public int track_completion;
    public int speed;
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Data
{   
    public List<GridData> DataSet;
}

[System.Serializable]
public class GridData
{   
    public List<CarData> FrameData;
}

[System.Serializable]
public class CarData
{
    public int id;
    public int initial_lane;
    public int lane;
    public int speed;
    public int track_completion;
}
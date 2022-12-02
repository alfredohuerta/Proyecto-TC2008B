using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public int id;
    public int initial_lane;
    public int lane;
    public int track_completion;
    public int speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*speed*Spawner.movementSpeed*Time.deltaTime);
        lane = Spawner.d.DataSet[Spawner.frame].FrameData[id].lane;
        track_completion = Spawner.d.DataSet[Spawner.frame].FrameData[id].track_completion;
        speed = Spawner.d.DataSet[Spawner.frame].FrameData[id].speed;
        if (transform.position.z > 500 || track_completion >= 198 || !(Spawner.d.DataSet[Spawner.frame].FrameData[id].Contains(id))
        {
            Destroy(this.gameObject);
        }
        if(lane != Spawner.d.DataSet[Spawner.frame+1].FrameData[id].lane)
        {
            StartCoroutine(Turn());
        }
    }

    IEnumerator Turn()
    {
        float initialPos;
        if(lane > Spawner.d.DataSet[Spawner.frame+1].FrameData[id].lane)
        {
            while(transform.position.x > initialPos-2.25f)
            {
                transform.Rotate(Vector3.up*Time.deltaTime*speed);
            }
        }
    }
}

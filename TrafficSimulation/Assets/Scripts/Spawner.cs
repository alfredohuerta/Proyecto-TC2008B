using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    bool spawnCooldown = false;
    public static int frame = 0;
    int carID = 0;
    public float time = 300f;
    public static float movementSpeed = 10f;
    public GameObject[] vehicle;
    public Transform[] spawnpoint;
    public static Data d;


    // Start is called before the first frame update
    void Start()
    {
        d = WebClient.GetTraffic();
        Debug.Log(d);
    }

    // Update is called once per frame
    void Update()
    {
        if (!spawnCooldown){
            spawnCooldown = true;
            StartCoroutine(SpawnVehicle());
        }
    }

    IEnumerator SpawnVehicle()
    {
        GameObject spawn;
        int x = Random.Range(0,4);
        spawn = Instantiate(vehicle[x],spawnpoint[d.DataSet[frame].FrameData[carID].initial_lane].position,Quaternion.identity);
        spawn.GetComponent<CarMovement>().id = carID;
        carID += 1;
        frame += 1;
        yield return new WaitForSeconds(1f);
        spawnCooldown = false;
    }
}

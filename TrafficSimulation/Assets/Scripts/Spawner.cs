using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    bool spawnCooldown = false;
    int carID = 0;
    public float time = 300f;
    public float movementSpeed = 100f;
    public GameObject[] vehicle;
    public Transform[] spawnpoint;
    Car c;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale=10;
    }

    // Update is called once per frame
    void Update()
    {
        if (!spawnCooldown){
            spawnCooldown = true;
            c = WebClient.GetTraffic(carID);
            StartCoroutine(SpawnVehicle(c));
            carID++;
        }
    }

    IEnumerator SpawnVehicle(Car c)
    {
        GameObject spawn;
        switch(c.initial_lane)
        {
            case 0:
                spawn = Instantiate(vehicle[0],spawnpoint[0].position,Quaternion.identity);
                spawn.SetActive(true);
                spawn.transform.Translate(Vector3.forward*c.speed*Time.deltaTime);
                Destroy(spawn,time);
                break;
            case 1:
                spawn = Instantiate(vehicle[1],spawnpoint[1].position,Quaternion.identity);
                spawn.SetActive(true);
                spawn.transform.Translate(Vector3.forward*c.speed*Time.deltaTime);
                Destroy(spawn,time);
                break;
            case 2:
                spawn = Instantiate(vehicle[2],spawnpoint[2].position,Quaternion.identity);
                spawn.SetActive(true);
                spawn.transform.Translate(Vector3.forward*c.speed*Time.deltaTime);
                Destroy(spawn,time);
                break;
        }
        yield return new WaitForSeconds(10f);
        spawnCooldown = false;
    }
}

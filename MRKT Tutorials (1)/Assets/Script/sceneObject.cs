using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneObject : MonoBehaviour
{

    public GameObject model;

    // Start is called before the first frame update
    void Start()
    {
        model.SetActive(false);
    }
    
    public void showModel()
    {
        Vector3 playerPos = Camera.main.transform.position;
        Vector3 spawnPos = model.transform.position;
        Debug.Log(Camera.main.transform.forward);
        spawnPos.x = playerPos.x + Camera.main.transform.forward.x*1;
        spawnPos.z = playerPos.z + Camera.main.transform.forward.z*1;
        spawnPos.y -= 0.179f;
        model.transform.position = spawnPos;
        model.SetActive(true);
    }
}

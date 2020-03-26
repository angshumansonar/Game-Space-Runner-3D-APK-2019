using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelmanager : MonoBehaviour {
    public GameObject[] levels;
    private Transform playerTransform;
    private float spawnz = 20.0f;
    private float levellength = 93f;
    private float safezone = 100.0f;
    private int lavalno = 2;
    private List<GameObject> activelevels;
    private int lastprifabindex = 2;
	// Use this for initialization
	void Start () {
        activelevels = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("camcom").transform;
        for(int i=0;i<lavalno;i++)
        {
            spawnlevels();

        }
	}
	
	// Update is called once per frame
	void Update () {
        if(playerTransform.position.z-safezone>(spawnz-lavalno*levellength))
        {
            spawnlevels();
            Deletelevels();
        }
		
	}
    private void spawnlevels(int prefabIndex=-1)
    {
        GameObject go;
        go = Instantiate(levels[randomprefabindex()]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnz;
        spawnz += levellength;
        activelevels.Add(go);

    }
    private void Deletelevels()
    {
        Destroy(activelevels[0]);
        activelevels.RemoveAt(0);
    }
    private int randomprefabindex()
    {
        if (levels.Length <= 1)
            return 0;
        int randomindex = lastprifabindex;
        while(randomindex==lastprifabindex)
        {
            randomindex = Random.Range(0, levels.Length);
        }
        lastprifabindex = randomindex;
        return randomindex;
    }
}

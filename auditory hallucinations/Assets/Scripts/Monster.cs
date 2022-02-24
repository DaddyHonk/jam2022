using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private int p_SpawningLocation;

    public Vector2 _SpawnLoc1, _SpawnLoc2, _SpawnLoc3, _SpawnLoc4;

    private void Start()
    {
        p_SpawningLocation = Random.Range(1,4);
        Spawn();
        Debug.Log(p_SpawningLocation);
    }

    void Spawn()
    {
        if (p_SpawningLocation == 1)
            gameObject.transform.position = new Vector3(_SpawnLoc1.x, _SpawnLoc1.y, 0);
        if (p_SpawningLocation == 2)
            gameObject.transform.position = new Vector3(_SpawnLoc2.x, _SpawnLoc2.y, 0);
        if (p_SpawningLocation == 3)
            gameObject.transform.position = new Vector3(_SpawnLoc3.x, _SpawnLoc3.y, 0);
        if (p_SpawningLocation == 4)
            gameObject.transform.position = new Vector3(_SpawnLoc4.x, _SpawnLoc4.y, 0);
    }

}

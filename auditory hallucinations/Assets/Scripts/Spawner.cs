using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public bool p_MonsterSpawned;
    public GameObject _Monster1, _Monster2, _Monster3, _Monster4;

    public static Spawner instance;
    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
            instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (p_MonsterSpawned == false)
        {
            Spawn();
        }
    }

    void Spawn()
    {
        if (PlayerPrefs.GetInt("Pictures" + 0) < 1)
        {
            Instantiate(_Monster1, new Vector3(0, 0, 0), Quaternion.identity);
            AudioManager.instance.Play("Watcher");
        }
        else if (PlayerPrefs.GetInt("Pictures" + 1) < 1)
        {
            Instantiate(_Monster2, new Vector3(0, 0, 0), Quaternion.identity);
            AudioManager.instance.Play("Scuttler");
        }

        else if (PlayerPrefs.GetInt("Pictures" + 2) < 1)
        {
            Instantiate(_Monster3, new Vector3(0, 0, 0), Quaternion.identity);
            AudioManager.instance.Play("Carnivore");

        }
        else if (PlayerPrefs.GetInt("Pictures" + 3) < 1)
        {
            Instantiate(_Monster4, new Vector3(0, 0, 0), Quaternion.identity);
            AudioManager.instance.Play("Amalgamation");

        }
        p_MonsterSpawned = true;
    }
}

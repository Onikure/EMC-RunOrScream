using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawner : MonoBehaviour
{
    private GameObject KeyPrefab;
    private Vector3 SpawnPosition;

    public KeySpawner(GameObject KeyPrefab, Vector3 SpawnPosition)
    {
        this.KeyPrefab = KeyPrefab;
        this.SpawnPosition = SpawnPosition;
    }

    public GameObject SpawnKey()
    {
        return GameObject.Instantiate(KeyPrefab, SpawnPosition, transform.rotation);
    }

}

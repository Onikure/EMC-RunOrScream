using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    private GameObject KeyPrefab;
    private Vector3 respawnPosition;

    public KeyManager(GameObject KeyPrefab, Vector3 respawnPosition)
    {
        this.KeyPrefab = KeyPrefab;
        this.respawnPosition = respawnPosition;
    }

    public void RespawnItem(GameObject destroyedItem)
    {
        GameObject newSpawnedItem = GameObject.Instantiate(KeyPrefab, respawnPosition, transform.rotation);
        Destroy(destroyedItem);
    }
}

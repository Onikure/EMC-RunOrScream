using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject itemPrefab;
    public Vector3 initialSpawnPosition;
    public Vector3 respawnPosition;

    private KeySpawner KeySpawner;
    private KeyManager KeyManager;

    private void Start()
    {
        KeySpawner = new KeySpawner(itemPrefab, initialSpawnPosition);
        KeyManager = new KeyManager(itemPrefab, respawnPosition);

        SpawnInitialItem();
    }

    private void SpawnInitialItem()
    {
        GameObject initialItem = KeySpawner.SpawnKey();
        // Add your additional logic here
    }

    private void HandleItemDestroyed(GameObject destroyedItem)
    {
        KeyManager.RespawnItem(destroyedItem);
        // Add your additional logic here
    }
}

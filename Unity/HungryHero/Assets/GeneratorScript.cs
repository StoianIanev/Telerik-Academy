using System.Collections.Generic;
using UnityEngine;

public class GeneratorScript : MonoBehaviour
{
    public GameObject[] availableObjects;
    private float screenWidthInPoints;
    public List<GameObject> objects;

    public float objectsMinDistance = 25.0f;
    public float objectsMaxDistance = 30.0f;

    public float objectsMinY = -1f;
    public float objectsMaxY = 3f;

    public bool gameStarted;

    public void Start()
    {
        float height = 2.0f * Camera.main.orthographicSize;
        this.screenWidthInPoints = height * Camera.main.aspect;
    }

    public void Update()
    {
        if (Input.GetButtonDown("Fire1") || Input.touchCount == 1)
        {
            this.gameStarted = true;
        }

    }
    public void FixedUpdate()
    {
        if (this.gameStarted == true)
        {
            GenerateObjectsIfRequired();
        }

    }
    public void AddObject(float lastObjectX)
    {
        int randomIndex = Random.Range(0, availableObjects.Length);

        GameObject obj = (GameObject)Instantiate(availableObjects[randomIndex]);

        float objectPositionX = lastObjectX + Random.Range(this.objectsMinDistance, this.objectsMaxDistance);
        float randomY = Random.Range(this.objectsMinY, this.objectsMaxY);
        obj.transform.position = new Vector3(objectPositionX + 8, randomY, 0);

        this.objects.Add(obj);
    }

    public void GenerateObjectsIfRequired()
    {
        float playerX = transform.position.x;
        float removeObjectsX = playerX - screenWidthInPoints;
        float addObjectX = playerX + screenWidthInPoints;
        float farthestObjectX = 0;

        List<GameObject> objectsToRemove = new List<GameObject>();

        foreach (var obj in objects)
        {
            float objX = obj.transform.position.x;

            farthestObjectX = Mathf.Max(farthestObjectX, objX);

            if (objX < removeObjectsX)
                objectsToRemove.Add(obj);
        }

        foreach (var obj in objectsToRemove)
        {
            objects.Remove(obj);
            Destroy(obj);
        }

        if (farthestObjectX < addObjectX)
            AddObject(farthestObjectX);
    }
}

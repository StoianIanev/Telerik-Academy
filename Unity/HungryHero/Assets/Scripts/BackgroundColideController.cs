using UnityEngine;

public class BackgroundColideController : MonoBehaviour
{
    private int numberOfBlueBackgrounds;
    private float distanceBetweenBlueBg;

    private int numberOfBlackBackgrounds;
    private float distanceBetweenBlackBg;

    private int numberOfGreenBackgrounds;
    private float distanceBetweenGreenBg;

    private int numberOfFloors;
    private float distanceBetweenFloors;

    private int numberOfOrangePlanes;
    private float distanceBetweenOrangePlanes;

    private int numberOfBluePlanes;
    private float distanceBetweenBluePlanes;

    private int numberOfGreenPlanes;
    private float distanceBetweenGreenPlanes;

    public void Start()
    {
        var blueBg = GameObject.FindGameObjectsWithTag("BlueBackground");
        var blackBg = GameObject.FindGameObjectsWithTag("BlackBackground");
        var greenBg = GameObject.FindGameObjectsWithTag("GreenBackground");
        var floors = GameObject.FindGameObjectsWithTag("Floor");
        var orangePlanes = GameObject.FindGameObjectsWithTag("OrangePlane");
        var bluePlanes = GameObject.FindGameObjectsWithTag("BluePlane");
        var greenPlanes = GameObject.FindGameObjectsWithTag("GreenPlane");

        RandomizePlanes(orangePlanes);
        RandomizePlanes(bluePlanes);
        RandomizePlanes(greenPlanes);

        this.numberOfBlueBackgrounds = blueBg.Length;
        this.numberOfBlackBackgrounds = blackBg.Length;
        this.numberOfGreenBackgrounds = greenBg.Length;
        this.numberOfFloors = floors.Length;
        this.numberOfOrangePlanes = orangePlanes.Length;
        this.numberOfBluePlanes = bluePlanes.Length;
        this.numberOfGreenPlanes = greenPlanes.Length;

        if (this.numberOfBlueBackgrounds < 2
            || this.numberOfBlackBackgrounds < 2
            || this.numberOfGreenBackgrounds < 2
            || this.numberOfFloors < 2)
        {
            throw new System.InvalidOperationException("You must have at least two blue, black, green backgrounds or floor in your scene!");
        }
        this.distanceBetweenBlueBg = DistanceBetweenObjects(blueBg);
        this.distanceBetweenBlackBg = DistanceBetweenObjects(blackBg);
        this.distanceBetweenGreenBg = DistanceBetweenObjects(greenBg);
        this.distanceBetweenFloors = DistanceBetweenObjects(floors);
        this.distanceBetweenOrangePlanes = DistanceBetweenObjects(orangePlanes);
        this.distanceBetweenBluePlanes = DistanceBetweenObjects(bluePlanes);
        this.distanceBetweenGreenPlanes = DistanceBetweenObjects(greenPlanes);
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("BlueBackground")
            || collider.CompareTag("BlackBackground")
            || collider.CompareTag("GreenBackground")
            || collider.CompareTag("Floor")
            || collider.CompareTag("OrangePlane")
            || collider.CompareTag("BluePlane")
            || collider.CompareTag("GreenPlane"))
        {
            var go = collider.gameObject;
            var originalPosition = go.transform.position;

            if (collider.CompareTag("BlueBackground"))
            {
                originalPosition.x += this.numberOfBlueBackgrounds * this.distanceBetweenBlueBg;
            }
            else if (collider.CompareTag("BlackBackground"))
            {
                originalPosition.x += this.numberOfBlackBackgrounds * this.distanceBetweenBlackBg;
            }
            else if (collider.CompareTag("GreenBackground"))
            {
                originalPosition.x += this.numberOfGreenBackgrounds * this.distanceBetweenGreenBg;
            }
            else if (collider.CompareTag("Floor"))
            {
                originalPosition.x += this.numberOfFloors * this.distanceBetweenFloors;
            }
            else if (collider.CompareTag("OrangePlane"))
            {
                originalPosition.x += this.numberOfOrangePlanes * this.distanceBetweenOrangePlanes;

            }
            else if (collider.CompareTag("BluePlane"))
            {
                originalPosition.x += this.numberOfBluePlanes * this.distanceBetweenBluePlanes;
            }
            else
            {
                originalPosition.x += this.distanceBetweenGreenPlanes * this.distanceBetweenGreenPlanes;
            }

            go.transform.position = originalPosition;
        }

    }
    private float DistanceBetweenObjects(GameObject[] gameObject)
    {
        float minDistance = float.MaxValue;

        for (int i = 1; i < gameObject.Length; i++)
        {
            var currentDistance = Mathf.Abs(gameObject[i - 1].transform.position.x - gameObject[i].transform.position.x);

            if (currentDistance < minDistance)
            {
                minDistance = currentDistance;
            }
        }
        return minDistance;
    }
    private void RandomizePlanes(GameObject[] planes)
    {
        for (int i = 1; i < planes.Length; i++)
        {
            var currentPlane = planes[i];
            var randomY = Random.Range(-0.5f, 3);
            var planePosition = currentPlane.transform.position;
            planePosition.y = randomY;
            currentPlane.transform.position = planePosition;
        }
    }
}
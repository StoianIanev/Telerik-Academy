using UnityEngine;

public class LookOutController : MonoBehaviour
{
    public GameObject[] planes;
    public GameObject lookOut;
    private SpriteRenderer renderer;

    public void Start()
    {
        this.renderer = this.lookOut.GetComponent<SpriteRenderer>();
        this.renderer.enabled = true;
    }

    public void Update()
    {

    }

    public void FixedUpdate()
    {
        PutCaptionLookOut();

        if (this.lookOut.transform.position.x > this.transform.position.x + 3.5f)
        {
            this.renderer.enabled = true;
        }
        else
        {
            this.renderer.enabled = false;
        }
    }

    public void PutCaptionLookOut()
    {
        for (int i = 0; i < planes.Length; i++)
        {
            var dis = Vector3.Distance(this.transform.position, this.planes[i].transform.position);
            if (dis < 40)
            {
                this.lookOut.transform.position = new Vector3(this.transform.position.x + 4, this.planes[i].transform.position.y);
                this.renderer.enabled = true;
            }
        }
    }
}

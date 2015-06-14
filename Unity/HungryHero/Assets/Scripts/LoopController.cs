using UnityEngine;

public class LoopController : MonoBehaviour
{
    public GameObject hero;

    private float offsetOfX;

    public void Start()
    {
        this.offsetOfX = this.transform.position.x - this.hero.transform.position.x;
    }

    public void Update()
    {
        var position = this.transform.position;
        position.x = this.hero.transform.position.x + offsetOfX;
        this.transform.position = position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroController : MonoBehaviour
{
    public float speedVer = 30;
    public float speedHor = 15;
    private float moveSpeed;
    public bool gameStarted;
    private int score;
    private int distance;
    private int lives = 4;
    public bool isDeadHero;
    private float maxY = 3;
    private float minY = -1;
    private float distanceBetweenOrangePlane;
    private float distanceBetweenBluePlane;
    private float distanceBetweenGreenPlane;
    private float distanceBetweenObjects;

    private Rigidbody2D rb;
    private Animator animator;

    private Vector2 originalPosition;
    private GameObject startButton;
    private GameObject playAgain;
    private GameObject mainButton;
    private GameObject darkBackground;
    private GameObject deadHeroCaption;
    private GameObject orangePlane;
    private GameObject bluePlane;
    private GameObject greenPlane;
    private GameObject lookOut;

    private GameObject[] apple;
    private GameObject[] frenchFries;
    private GameObject[] hamburger;
    private GameObject[] banana;
    private GameObject[] juice;

    private GUIText txt;

    Color color;

    public AudioClip backgroundMusic;
    public AudioClip deadHero;
    private AudioSource audioSorce;

    public void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.richText = true;
        style.fontStyle = FontStyle.Bold;
        style.normal.textColor = Color.white;
        style.fontSize = 20;

        GUILayout.Label("Score: " + score, style);

        GUILayout.BeginArea(new Rect((Screen.width / 2) - 90, 0, 180, 100));
        GUILayout.Label("Lives: " + lives, style);
        GUILayout.EndArea();

        GUILayout.BeginArea(new Rect((Screen.width / 2) + 50, 0, 180, 100));
        GUILayout.Label("Distance: " + distance, style);
        GUILayout.EndArea();

        if (lives < 1)
        {
            GUILayout.BeginArea(new Rect((Screen.width / 2) - 90, (Screen.height / 2) - 90, 180, 100));
            GUILayout.Label("Your Score: " + score, style);
            GUILayout.Label("Your Distance: " + distance, style);
            GUILayout.EndArea();
        }
    }
    public void Start()
    {
        this.score = 0;

        this.audioSorce = GetComponent<AudioSource>();
        this.audioSorce.PlayOneShot(this.backgroundMusic);

        this.rb = this.GetComponent<Rigidbody2D>();
        this.animator = this.GetComponent<Animator>();
        this.originalPosition = new Vector2(this.transform.position.x, this.transform.position.y);
        this.startButton = GameObject.Find("StartButton");
        this.playAgain = GameObject.Find("PlayAgain");
        this.mainButton = GameObject.Find("Main");
        this.darkBackground = GameObject.Find("DarkGreyBackground");
        this.deadHeroCaption = GameObject.Find("DeadHero");
        this.orangePlane = GameObject.FindGameObjectWithTag("OrangePlane");
        this.bluePlane = GameObject.FindGameObjectWithTag("BluePlane");
        this.greenPlane = GameObject.FindGameObjectWithTag("GreenPlane");
        this.lookOut = GameObject.FindGameObjectWithTag("LookOut");
        this.rb.gravityScale = 0;
        speedHor = 0;
        moveSpeed = 0;
        this.animator.enabled = false;

        var renderer = playAgain.GetComponent<SpriteRenderer>();
        var renderer1 = darkBackground.GetComponent<SpriteRenderer>();
        var renderer2 = deadHeroCaption.GetComponent<SpriteRenderer>();
        var renderer3 = mainButton.GetComponent<SpriteRenderer>();
        renderer.enabled = false;
        renderer1.enabled = false;
        renderer2.enabled = false;
        renderer3.enabled = false;

        apple = GameObject.FindGameObjectsWithTag("apple");
        frenchFries = GameObject.FindGameObjectsWithTag("frenchFries");
        hamburger = GameObject.FindGameObjectsWithTag("hamburger");
        banana = GameObject.FindGameObjectsWithTag("banana");
        juice = GameObject.FindGameObjectsWithTag("juice");

    }
    public void Update()
    {
        if (Input.GetButtonDown("Fire1") || Input.touchSupported)
        {
            if (!this.isDeadHero)
            {
                if (!this.gameStarted)
                {
                    var renderer = startButton.GetComponent<SpriteRenderer>();
                    renderer.enabled = false;
                    this.animator.enabled = true;
                    speedHor = 15;
                    moveSpeed = 10;
                }

            }
            else
            {
                Application.LoadLevel("Game");
            }

        }

        if (this.isDeadHero == false && this.gameStarted == false)
        {
            var ver = Input.GetAxis("Vertical") * speedVer;
            this.transform.Translate(new Vector3(0, ver, 0) * Time.deltaTime);
            this.distance = (int)this.transform.position.x;
        }
        else
        {
            this.speedHor = 0;
            this.gameStarted = true;
        }
    }
    public void FixedUpdate()
    {
        var velocity = this.rb.velocity;
        velocity.x = this.speedHor;
        velocity.y = 0;
        this.rb.velocity = velocity;
        if (this.isDeadHero == false && this.gameStarted == false)
        {
            var ver = Input.GetAxis("Vertical") * speedVer;
            this.transform.Translate(new Vector3(0, ver, 0) * Time.deltaTime);
        }

    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("apple")
            || collider.CompareTag("frenchFries")
            || collider.CompareTag("hamburger")
            || collider.CompareTag("banana")
            || collider.CompareTag("juice"))
        {
            collider.gameObject.SetActive(false);
            if (this.isDeadHero == false)
            {
                this.score += 5;
            }

        }
        if (collider.gameObject.CompareTag("OrangePlane")
            || collider.gameObject.CompareTag("BluePlane")
            || collider.gameObject.CompareTag("GreenPlane"))
        {
            if (this.isDeadHero == false)
            {
                this.lives = lives - 1;
                this.speedHor = 3;

                if (lives < 1)
                {
                    this.audioSorce.Stop();
                    this.audioSorce.PlayOneShot(this.deadHero);
                    isDeadHero = true;

                    var renderer = playAgain.GetComponent<SpriteRenderer>();
                    var renderer1 = darkBackground.GetComponent<SpriteRenderer>();
                    var renderer2 = deadHeroCaption.GetComponent<SpriteRenderer>();
                    var renderer3 = mainButton.GetComponent<SpriteRenderer>();
                    renderer.enabled = true;
                    renderer1.enabled = true;
                    renderer2.enabled = true;
                    renderer3.enabled = true;

                    var playAgainButtonX = Camera.main.transform.position.x;
                    var playAgainButtonY = Camera.main.transform.position.y;

                    var playAgainButtonPosition = this.startButton.transform.position;
                    playAgainButtonPosition.x = playAgainButtonX;
                    playAgainButtonPosition.y = playAgainButtonY;

                    var positionCaption = this.startButton.transform.position;
                    positionCaption.x = playAgainButtonX;
                    positionCaption.y = playAgainButtonY + 2;

                    var positionMainButton = this.startButton.transform.position;
                    positionMainButton.x = playAgainButtonX;
                    positionMainButton.y = playAgainButtonY - 2.2f;

                    this.playAgain.transform.position = playAgainButtonPosition;
                    this.darkBackground.transform.position = playAgainButtonPosition;
                    this.deadHeroCaption.transform.position = positionCaption;
                    this.mainButton.transform.position = positionMainButton;

                    this.animator.enabled = false;

                }
            }
            else
            {
                speedHor = 0;
            }
        }
    }
    public void OnTriggerExit2D()
    {
        // TODO: BlockWait
        this.speedHor = 15;
        Object(apple);
        Object(frenchFries);
        Object(hamburger);
        Object(banana);
        Object(juice);
    }
    public void Object(GameObject[] obj)
    {
        for (int i = 0; i < obj.Length; i++)
        {
            if (obj[i].activeInHierarchy == false)
            {
                obj[i].SetActive(true);

            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Timers;
using System.Threading;

public class HeroController : MonoBehaviour
{
    public float speedVer = 10;
    public float speedHor = 12;
    private bool gameStarted;
    private int score;
    private int distance;
    public int lives = 5;
    private bool isDeadHero;
    private float maxY = 3;
    private float minY = -1;
    private bool isCollideWithPlanes;
    private bool isRotationHero;

    private Rigidbody2D rb;

    private Animator animator;

    private Vector2 touchDeltaPosition;
    private Vector3 touchPosition;

    private GameObject startButton;
    private GameObject playAgain;
    private GameObject mainButton;
    private GameObject darkBackground;
    private GameObject deadHeroCaption;
    private GameObject orangePlane;
    private GameObject bluePlane;
    private GameObject greenPlane;
    private GameObject canvas;

    private GUIText txt;
    public Texture2D pauseGameTexture;
    public Texture2D stopMusicTexture;

    private Color color;

    public AudioClip backgroundMusic;
    public AudioClip deadHero;
    public AudioClip getFood;
    public AudioClip hitByPlane;
    public AudioClip ouch;
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
        GUILayout.Label("Lives: " + this.lives, style);
        GUILayout.EndArea();

        GUILayout.BeginArea(new Rect((Screen.width / 2) + 50, 0, 180, 100));
        GUILayout.Label("Distance: " + this.distance, style);
        GUILayout.EndArea();

        if (this.lives < 1)
        {
            GUILayout.BeginArea(new Rect((Screen.width / 2) - 90, (Screen.height / 2) - 90, 220, 100));
            GUILayout.Label("Score: " + score, style);
            GUILayout.Label("Distance travelled: " + this.distance, style);
            GUILayout.EndArea();

            var playAgainButton = playAgain.GetComponent<Button>();
            var main = mainButton.GetComponent<Button>();
            var darkBackgroundRenderer = darkBackground.GetComponent<SpriteRenderer>();
            var deadHeroCaptionRenderer = deadHeroCaption.GetComponent<SpriteRenderer>();
            var canv = canvas.GetComponent<Canvas>();

            playAgainButton.enabled = true;
            main.enabled = true;
            darkBackgroundRenderer.enabled = true;
            deadHeroCaptionRenderer.enabled = true;
            canv.enabled = true;

            var positionX = Camera.main.transform.position.x;
            var positionY = Camera.main.transform.position.y;

            var playAgainButtonPosition = this.startButton.transform.position;
            playAgainButtonPosition.x = Screen.width / 2;
            playAgainButtonPosition.y = Screen.height / 2.2f;

            var positionCaption = deadHeroCaptionRenderer.transform.position;
            positionCaption.x = positionX +  0.5f;
            positionCaption.y = positionY + 2;

           var positionMainButton = this.startButton.transform.position;
            positionMainButton.x = Screen.width / 2;
            positionMainButton.y = playAgainButtonPosition.y / 2;

            var positionDarkBackground = darkBackgroundRenderer.transform.position;
            positionDarkBackground.x = positionX;
            positionDarkBackground.y = positionY;

            this.playAgain.transform.position = playAgainButtonPosition;
            this.darkBackground.transform.position = positionDarkBackground;
            this.deadHeroCaption.transform.position = positionCaption;
            this.mainButton.transform.position = positionMainButton;
        }
    }

    public void Start()
    {
        this.score = 0;

        this.audioSorce = GetComponent<AudioSource>();
        this.audioSorce.PlayOneShot(this.backgroundMusic);

        this.rb = this.GetComponent<Rigidbody2D>();

        this.animator = this.GetComponent<Animator>();
        this.startButton = GameObject.Find("StartButton");
        this.playAgain = GameObject.FindGameObjectWithTag("PlayAgain");
        this.mainButton = GameObject.FindGameObjectWithTag("Main");
        this.darkBackground = GameObject.Find("DarkGreyBackground");
        this.deadHeroCaption = GameObject.Find("DeadHero");
        this.canvas = GameObject.Find("Canvas");

        this.rb.gravityScale = 0;
        this.speedHor = 0;
        this.animator.enabled = false;

        var playAgainButton = playAgain.GetComponent<Button>();
        var main = mainButton.GetComponent<Button>();
        var darkBackgroundRenderer = darkBackground.GetComponent<SpriteRenderer>();
        var deadHeroCaptionRenderer = deadHeroCaption.GetComponent<SpriteRenderer>();
        var canv = canvas.GetComponent<Canvas>();

        playAgainButton.enabled = false;
        main.enabled = false;
        darkBackgroundRenderer.enabled = false;
        deadHeroCaptionRenderer.enabled = false;
        canv.enabled = false;

    }

    public void Update()
    {
        if (Input.GetButtonDown("Fire1") || Input.touchCount == 1)
        {
            if (!this.isDeadHero)
            {
                if (!this.gameStarted)
                {
                    Time.timeScale = 1;
                    var startButtonRenderer = startButton.GetComponent<SpriteRenderer>();
                    startButtonRenderer.enabled = false;
                    this.animator.enabled = true;
                    this.speedHor = 12;
                }
            }
        }
        if (Input.GetButtonDown("Pause"))
        {
            Time.timeScale = 0;
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
            #if UNITY_ANDROID
                        var targetPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                        targetPos.x = this.transform.position.x;
                        transform.position = Vector2.MoveTowards(this.transform.position, targetPos, this.speedHor * Time.deltaTime);
                        this.distance = (int)this.transform.position.x;
                        if (Input.touchCount == 2)
                        {
                            Time.timeScale = 0;
                        }
                       
            #else
            var targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPos.x = this.transform.position.x;
            this.transform.position = Vector2.MoveTowards(this.transform.position, targetPos, this.speedHor * Time.deltaTime);
            this.distance = (int)this.transform.position.x;
          #endif
        }
        else
        {
            this.gameStarted = true;
        }
        
        if (this.isCollideWithPlanes == true && this.lives >= 1)
        {
            if (this.transform.position.y > this.minY && this.transform.position.y + 1 < this.maxY)
            {
                this.transform.position = new Vector3(this.transform.position.x + 5, 1f);
                speedHor = 0;
            }
            else
            {
                this.transform.position = new Vector3(this.transform.position.x + 5, -1f);
                speedHor = 0;
            }
        }

        if (this.isRotationHero == true && this.isDeadHero == false)
        {
            this.animator.SetBool("RotationHero", false);
            Time.timeScale = 1f;
        }
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("apple")
            || collider.gameObject.CompareTag("frenchFries")
            || collider.gameObject.CompareTag("hamburger")
            || collider.gameObject.CompareTag("banana")
            || collider.gameObject.CompareTag("juice"))
        {
            Destroy(collider.gameObject);

            this.audioSorce.PlayOneShot(this.getFood);

            if (this.isDeadHero == false)
            {
                this.score += 5;
            }

        }
        if (collider.gameObject.CompareTag("OrangePlane")
            || collider.gameObject.CompareTag("BluePlane")
            || collider.gameObject.CompareTag("GreenPlane"))
        {
            this.animator.SetBool("RotationHero", true);
            this.isRotationHero = true;
            this.audioSorce.PlayOneShot(this.hitByPlane);
            this.audioSorce.PlayOneShot(this.ouch);
            Time.timeScale = 0.2f;

            if (this.isDeadHero == false)
            {
                this.lives = lives - 1;
                this.isCollideWithPlanes = true;
                if (lives < 1)
                {
                    this.audioSorce.Stop();
                    this.audioSorce.PlayOneShot(this.deadHero);
                    this.isDeadHero = true;

                    this.animator.enabled = false;
                    Time.timeScale = 0;
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
        this.isCollideWithPlanes = false;
        this.speedHor = 12;
    }
}
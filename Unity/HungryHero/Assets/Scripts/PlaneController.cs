﻿using UnityEngine;
using System.Collections;

public class PlaneController : MonoBehaviour
{
    public float speedHor = -10;
    private GameObject hero;
    private Animator animator;
    public bool gameStarted;

    public void Start()
    {
        this.animator = this.GetComponent<Animator>();
        this.hero = GameObject.FindGameObjectWithTag("hero");
    }
    public void Update()
    {
        if (Input.GetButtonDown("Fire1") || Input.touchCount == 1)
        {
            var startButton = GameObject.Find("StartButton");
            var renderer = startButton.GetComponent<SpriteRenderer>();
            renderer.enabled = false;
            this.animator.enabled = true;
            this.speedHor = -10;
            this.gameStarted = true;
        }
        if (this.gameStarted == true)
        {
            this.transform.Translate(new Vector3(this.speedHor, 0, 0) * Time.deltaTime);
            this.speedHor = -10;
        }
        else
        {
            this.animator.enabled = false;
            this.speedHor = 0;
        }
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("hero"))
        {
            this.animator.SetBool("OrangePlaneDead", true);
            this.speedHor = 0;
        }
        if (collider.gameObject.CompareTag("hero"))
        {
            this.animator.SetBool("BluePlaneDead", true);
            this.speedHor = 0;
        }
        if (collider.gameObject.CompareTag("hero"))
        {
            this.animator.SetBool("GreenPlaneDead", true);
            this.speedHor = 0;
        }
    }
    public void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("hero"))
        {
            this.animator.SetBool("OrangePlaneDead", false);
        }
        if (collider.gameObject.CompareTag("hero"))
        {
            this.animator.SetBool("BluePlaneDead", false);
        }
        if (collider.gameObject.CompareTag("hero"))
        {
            this.animator.SetBool("GreenPlaneDead", false);
        }
    }
}
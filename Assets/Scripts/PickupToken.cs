﻿using UnityEngine;
using System.Collections;

public class PickupToken : MonoBehaviour
{
    public int value = 1;
    private GameMaster gm;

    private Rigidbody2D rb2d;

    private AudioSource audio;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() { }

    public int GetValue() { return value; }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.CompareTag("Player"))
        {
            gm.AddToken(value);
            //audio.PlayOneShot(audio.clip, 0.7f);
            AudioSource.PlayClipAtPoint(audio.clip, transform.position);
            Destroy(gameObject);
        }
    }
}

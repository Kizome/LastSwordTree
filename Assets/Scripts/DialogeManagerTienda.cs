﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogeManagerTienda : MonoBehaviour
{
    public Npc_Dialogue Dialoge;

    Queue<string> sentences;

    public GameObject dialogePanel;
    public static int puntos;
    public static int hpPlayer;

    //public TextMeshProUGUI textDialogue;
    public static Text frase;

    string activeSentence;
    public float typingSpeed;

    AudioSource myAudio;
    public AudioClip speackSound;

    void Start()
    {
        sentences = new Queue<string>();
        myAudio = GetComponent<AudioSource>();

    }

    void StartDialogue()
    {
       
        sentences.Clear();

        foreach (string sentence in Dialoge.sentenceList)
        {
            sentences.Enqueue(sentence);
        }


        DisplayNextSentence();

    }

    void DisplayNextSentence()
    {
        frase = GameObject.Find("Text_Npc").GetComponent<Text>();
        if (sentences.Count <= 0)
        {

            frase.text = activeSentence;

            return;
        }
        activeSentence = sentences.Dequeue();

        Debug.Log(activeSentence);
        try
        {
          
            MasDaño();
            frase.text = activeSentence;
        }
        catch (System.NullReferenceException ex)
        {

        }


    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            dialogePanel.SetActive(true);
            StartDialogue();
        }
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                DisplayNextSentence();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            dialogePanel.SetActive(false);
        }
    }


   

   private void MasDaño()
    {
        puntos = Area.contador;
        if(puntos >= 1)
        {
            Enemy.Daño = Enemy.Daño + 1;

            Area.contador = Area.contador - 1;
        }
        else
        {
            activeSentence = "No tienes puntos para comprar daño";
        }

    }
}

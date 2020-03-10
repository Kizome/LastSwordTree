using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Area : MonoBehaviour {

    Animator anim;
    public static int contador;
    public static Text puntos;
   

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        puntos = GameObject.Find("Puntos").GetComponent<Text>();
    }
	
    public IEnumerator ShowArea(string name) {
        anim.Play("Area_Show");
        transform.GetChild(0).GetComponent<Text>().text = name;
        transform.GetChild(1).GetComponent<Text>().text = name;
        yield return new WaitForSeconds(1f);
        anim.Play("Area_FadeOut");
    }

    void Update()
    {
        puntos.text = "Puntos: " + contador;
    }

        public static void Points()
    {
        contador = contador + 1;
        
        puntos.text = "Puntos: " + contador;

    }

}

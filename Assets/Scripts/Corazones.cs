using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Corazones : MonoBehaviour
{
    public  Image[] Corazon;
    public  Sprite Cor;
    public static int  contenedor;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        InitCorazon();
    }

    // Update is called once per frame
    void Update()
    {
        InitCorazon();
    }

     void InitCorazon()
    {
       
      
        for(int i = 0; i < contenedor; i++)
        {
            Corazon[i].gameObject.SetActive(true);
            Corazon[i].sprite = Cor;
            if (contenedor <= 7)
            {
                Corazon[7].gameObject.SetActive(false);
            }
            if (contenedor <= 6)
            {
                Corazon[6].gameObject.SetActive(false);
            }
            if (contenedor <= 5)
            {
                Corazon[5].gameObject.SetActive(false);
            }
            if (contenedor <= 4)
            {
                Corazon[4].gameObject.SetActive(false);
            }
            if (contenedor<= 3)
            {
                Corazon[3].gameObject.SetActive(false);
            }
            if (contenedor <= 2)
            {
                Corazon[2].gameObject.SetActive(false);
            }
            if (contenedor <= 1)
            {
                Corazon[1].gameObject.SetActive(false);
            }
            if (contenedor <= 0)
            {
                Corazon[0].gameObject.SetActive(false);
            }
           
        }
    }
   
}

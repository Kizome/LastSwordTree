using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public class Npc_Dialogue : MonoBehaviour
{
    public string name;
    public static Text Dialogo;

    [TextArea(3, 10)]
    public string[] sentenceList;
   

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "DialogueData", menuName = "ScriptableObjects/DialogueDataScriptableObject", order = 1)]
public class DialogueData : ScriptableObject
{
    public string[] Dialogue;
    public float WordSpeed;
    public string CharacterName;
    public Sprite CharacterImage;
}

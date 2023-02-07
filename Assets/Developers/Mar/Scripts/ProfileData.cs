using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileData
{
    public int ID;
    public string Name;
    public string Password;
    //public PersonalityType PersonalityType;
    public GameObject PlayerPrefab;
    public Dictionary<int, bool> QuestCompletionList;
}
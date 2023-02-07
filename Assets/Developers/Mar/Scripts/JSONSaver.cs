using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json.Bson;

public class JSONSaver : MonoBehaviour
{
    private static JSONSaver _instance;
    public static JSONSaver Instance => _instance;

    private ProfileData _userData;
    public ProfileData UserData => _userData;

    private string _dataPath;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
        _instance = this;

        SetPaths();
    }

    private void SetPaths()
    {
#if UNITY_EDITOR
        _dataPath = Application.dataPath + Path.AltDirectorySeparatorChar + "UserProfiles.json";
#else
        _dataPath = Application.persistentDataPath + Path.AltDirectorySeparatorChar + "UserProfiles.json";
#endif
    }

    private void LoadData()
    {
        if (!File.Exists(_dataPath))
        {
            CreateNewSaveData();
        }
    }

    private void SaveData()
    {
        
    }

    private void CreateNewSaveData()
    {

    }
}
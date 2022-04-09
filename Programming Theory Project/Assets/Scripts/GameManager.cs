using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.IO;
using UnityEditor;

[System.Serializable]
class SaveData

{
    public string playerName;

}
public class GameManager : MonoBehaviour
{
    [SerializeField] private  TMP_InputField inputname;
    private string playerName;
    public string PlayerName
    {
        get{return playerName;}
    }
    public static GameManager instance;
    private void Awake() {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        inputname = GameObject.Find("InputName").GetComponent<TMP_InputField>();
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        playerName = inputname.text;
        Save();
    }
    public void LoadScene()
    {
        NextScene();
    }
   
    private void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    private void Save()
    {
        SaveData data = new SaveData();
        data.playerName = playerName;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/saveFile.json", json);
    }
    public void Load()
    {
        string path = Application.persistentDataPath + "/saveFile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            playerName = data.playerName;
        }
    }
   
     public void ExitGame()
    {
        #if (UNITY_EDITOR)
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}

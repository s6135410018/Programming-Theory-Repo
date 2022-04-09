using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MainUI : MonoBehaviour
{
    [SerializeField] GameObject profile;
    private TextMeshProUGUI playerShowText;
    private string playerName;
    private void Awake()
    {
        instance = this;
        playerShowText = GameObject.Find("playerName Text").GetComponent<TextMeshProUGUI>();
    }
    private void Start()
    {
        if (GameManager.instance != null)
        {
            GameManager.instance.Load();
            playerName = GameManager.instance.PlayerName;
            playerShowText.text = $"Hello {playerName}";
        }
    }
    [SerializeField] List<TextMeshProUGUI> text;
    public static MainUI instance;

    public void OpenUI() //abstact
    {
        bool isActive = profile.activeSelf;
        profile.SetActive(!isActive);
    }
    public void InfoAnimal(BaseAnimal animal)
    {
        text[0].text = $"Name:  {animal.AnimalName}";
        text[1].text = $"Age: {animal.Age} ";
        text[2].text = $"Color: {animal.Color}";
        text[3].text = $"Speed: {animal.Speed}";
        text[4].text = $"Jump Force: {animal.JumpForce}";
        text[5].text = $"Favorite Food: {animal.AnimalFavoriteFood()}";
    }
    public void BackToMenuScene()
    {
        BackToMenu();
    }
    private void BackToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
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

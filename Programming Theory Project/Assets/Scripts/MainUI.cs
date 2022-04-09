using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MainUI : MonoBehaviour 
{
    [SerializeField] GameObject profile;
    [SerializeField] List<TextMeshProUGUI> text;
    public static MainUI instance;
    private void Awake()
    {
        instance = this;
    }
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
    
}

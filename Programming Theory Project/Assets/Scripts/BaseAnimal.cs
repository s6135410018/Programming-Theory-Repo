using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BaseAnimal : MonoBehaviour
{
    [SerializeField] private GameObject soundAnimal;
    [SerializeField] private TextMeshProUGUI soundText;
    public TextMeshProUGUI SoundText //encapsulation
    {
        get{return soundText;}
        set{soundText = value;}
    }
    [SerializeField] private string animalName;
    public string AnimalName //encapsulation
    {
        get { return animalName; }
    }
    [SerializeField] private int age;
    public int Age //encapsulation
    {
        get { return age; }
    }
    [SerializeField] private string color;
    public string Color //encapsulation
    {
        get { return color; }
    }
    [SerializeField] private float speed;
    public float Speed  //encapsulation
    {
        get{ return speed;}
    }
    [SerializeField] private float jumpForce;
    public float JumpForce//encapsulation
    {
        get { return jumpForce; }
    }
    private Animator animator;
    public Animator Animator //encapsulation
    {
        get { return animator; }
        set { animator = value; }
    }
    private string favoriteFood;
    public string FavoriteFood //encapsulation
    {
        set{favoriteFood = value;}
    }
    private string animalTalk;
    public string AnimalTalk
    {
        set {animalTalk = value;}
    }
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public virtual string Talk()
    {
       return  animalTalk;
    }
    public virtual string AnimalFavoriteFood()//Polymorphism
    {
        return  favoriteFood;
    }
    public virtual void OnMouseDown()//Polymorphism
    {
        MainUI.instance.OpenUI();
        MainUI.instance.InfoAnimal(this);
        Sound(); //abstact
    }
    public virtual void Sound()//Polymorphism
    {
        bool isActive = soundAnimal.activeSelf;
        soundAnimal.SetActive(!isActive);
        soundText.text = "";
    }
    public virtual void AnimatorAnimal()
    {

    }
}

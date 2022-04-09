using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : BaseAnimal//inherit From BaseAnimal
{
    private string food = "Grass";
    private string talk = "Baa";

    public override string Talk()//Polymorphism
    {
        return AnimalTalk = talk;
    }
    public override string AnimalFavoriteFood()//Polymorphism
    {
        return FavoriteFood = food;
    }
    public override void OnMouseDown()//Polymorphism
    {
        base.OnMouseDown();
        AnimatorAnimal();
    }
    public override void Sound()//Polymorphism
    {
        base.Sound();
        SoundText.text = Talk();
    }
    public override void AnimatorAnimal()
    {
        Animator.SetTrigger("jump");
    }
}

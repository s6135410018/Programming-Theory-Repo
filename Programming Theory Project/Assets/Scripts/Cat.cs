using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : BaseAnimal //inherit From BaseAnimal
{
    private string food = "Fish";
    private string talk = "Meow";

    public override string Talk()//Polymorphism
    {
        return AnimalTalk = talk;
    }
    public override string AnimalFavoriteFood() //Polymorphism
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
        Animator.SetTrigger("stun");
    }
}

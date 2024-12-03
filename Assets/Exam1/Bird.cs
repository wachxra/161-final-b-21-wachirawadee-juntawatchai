using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    private float dailyFoodConsumption = 3;
    private float weight = 8;
    private float foodRequirement;

    public override float CalculateFoodRequirement()
    {
        return foodRequirement = dailyFoodConsumption * weight * 7;
    }

    public override void MakeSound()
    {
        base.MakeSound();
        Debug.Log("Jib Jib !!!");
    }

    private void Start()
    {
        Init("Birdy Angry");

        DisplayName();
        MakeSound();
        Debug.Log($"{animalName} eats {dailyFoodConsumption} kg of food daily with activity level {weight} !");
        Debug.Log($"{animalName}'s weekly food requirement: {CalculateFoodRequirement()} kg **");
    }
}

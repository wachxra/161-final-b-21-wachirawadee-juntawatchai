using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private float dailyFoodConsumption = 5;
    private int activityLevel = 10;
    private float foodRequirement;

    public override float CalculateFoodRequirement()
    {
        return foodRequirement = dailyFoodConsumption * activityLevel * 7;
    }

    public override void MakeSound()
    {
        base.MakeSound();
        Debug.Log("Hong Hong !!!");
    }

    private void Start()
    {
        Init("Doggy Shininchi");

        DisplayName();
        MakeSound();
        Debug.Log($"{animalName} eats {dailyFoodConsumption} kg of food daily with activity level {activityLevel} !");
        Debug.Log($"{animalName}'s weekly food requirement: {CalculateFoodRequirement()} kg **");
    }
}

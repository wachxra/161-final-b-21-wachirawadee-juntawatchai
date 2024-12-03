using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindSpell : Spell
{
    private void Start()
    {
        Cast("Wind burn!! Splash them all");
        Cast("Wind burn", "Gorgon", 7);

        Cast("Windy!! Fewwww them all");
        Cast("Windy burn", "Gorgon", 8);
    }
}

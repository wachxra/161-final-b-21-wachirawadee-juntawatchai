using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    private void Start()
    {
        Cast("Firey Explosion !! Burn them all");
        Cast("Firey Explosion", "Slime", 3);
    }
}

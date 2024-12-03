using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    private void Start()
    {
        Cast("Ice burn!! Freeze them all");
        Cast("Ice burn", "Knight", 5);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public virtual void Cast()
    {
        Debug.Log("Spell-Casting Started !!!");
    }

    public void Cast(string spell)
    {
        Debug.Log($"Casting a {spell}");
    }

    public void Cast(string spell, string target, int cost)
    {
        Debug.Log($"Casting a {spell} on target [{target}] with level {cost}");
    }

    private void Start()
    {
        Cast();
    }
}

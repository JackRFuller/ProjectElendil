using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "ScriptableObject/Character", order = 1)]
public class Character : ScriptableObject
{
    public string characterName;
    public float movement;
    public float fighting;
    public float shooting;
    public float strength;
    public float defence;
    public float attacks;
    public float wounds;
    public float courage;	
}

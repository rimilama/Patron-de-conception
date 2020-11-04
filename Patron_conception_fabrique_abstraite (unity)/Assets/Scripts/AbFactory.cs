using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class abFactory : MonoBehaviour
{
    protected GameObject Animal;
    protected GameObject Humain;
    public Sprite AnimalSprite;
    public Sprite HumainSprite;
    public abstract void CreateAnimal();
    public abstract void CreateHumain();

    private void Start()
    {
        Animal = GameObject.FindGameObjectWithTag("Anim");
        Humain = GameObject.FindGameObjectWithTag("Hum");
    }
}

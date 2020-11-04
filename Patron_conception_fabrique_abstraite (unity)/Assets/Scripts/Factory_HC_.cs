using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory_HC_ : abFactory
{
    public override void CreateAnimal()
    {
        GameObject Chien = new GameObject();
        Chien.name = "chien";
        Chien.tag = "HC";
        Chien.transform.position = Animal.transform.position;
        Chien.AddComponent<SpriteRenderer>();
        Chien.GetComponent<SpriteRenderer>().sprite = AnimalSprite;
    }

    public override void CreateHumain()
    {
        GameObject Homme = new GameObject();
        Homme.name = "homme";
        Homme.tag = "HC";
        Homme.transform.position = Humain.transform.position;
        Homme.AddComponent<SpriteRenderer>();
        Homme.GetComponent<SpriteRenderer>().sprite = HumainSprite;
    }

    public void HC_Choose()
    {
        GameObject[] FC = GameObject.FindGameObjectsWithTag("FC");
        for (int i = 0; i < FC.Length; i++)
        {
            Destroy(FC[i]);
        }
    }
}

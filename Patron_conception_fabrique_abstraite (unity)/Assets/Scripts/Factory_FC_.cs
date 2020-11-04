using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory_FC_ : abFactory
{
    public override void CreateAnimal()
    {
        GameObject Chat = new GameObject();
        Chat.name = "chat";
        Chat.tag = "FC";
        Chat.transform.position = Animal.transform.position;
        Chat.AddComponent<SpriteRenderer>();
        Chat.GetComponent<SpriteRenderer>().sprite = AnimalSprite;
    }

    public override void CreateHumain()
    {
        GameObject Femme = new GameObject();
        Femme.name = "femme";
        Femme.tag = "FC";
        Femme.transform.position = Humain.transform.position;
        Femme.AddComponent<SpriteRenderer>();
        Femme.GetComponent<SpriteRenderer>().sprite = HumainSprite;
    }

    public void FC_Choose()
    {
        GameObject[] HC = GameObject.FindGameObjectsWithTag("HC");
        for (int i = 0; i < HC.Length; i++)
        {
            Destroy(HC[i]);
        }
    }
}

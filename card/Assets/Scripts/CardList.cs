using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class CardList : MonoBehaviour {

    string[] m = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "j", "q" ,"k"};

	// Use this for initialization
	void Start () {
        SetCardList();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SetCardList()
    {
        for(int i = 0; i < 5; i++)
        {
            string objName = "lord_card_club_" + i.ToString();
            GameObject obj = GameObject.Find(objName);

            string resName = "Sprites/lord_card_club_" + GetRandom(1, 2).ToString();

            obj.GetComponent<SpriteRenderer>().sprite = Resources.Load(resName, typeof(Sprite)) as Sprite;
        }
    }

    string GetRandom(int total, int count)
    {
        int index = UnityEngine.Random.Range(0, 5);
        return m[index];
    }

    public void HitTest()
    {
        Debug.Log("hello");
        SetCardList();
    }
}

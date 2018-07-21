using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMain : MonoBehaviour {

    public Button btn_restart;
    public Button btn_calc;
    public Button btn_again;

    public Text txt;

    public Transform panelStart;
    public Transform panelCard;
    public Transform panelEnd;
    Sprite[] sps;
    List<Sprite> currentCard = new List<Sprite>();

    private int cardNum = 5;

	// Use this for initialization
	void Start () {
        LoadCard();
        btn_restart.onClick.AddListener(() =>{
            panelStart.gameObject.SetActive(false);
            panelCard.gameObject.SetActive(true);
            RandomCardList();
        });

        btn_calc.onClick.AddListener(() =>
        {
            txt.gameObject.SetActive(true);
            Transform contentRoot = panelCard.Find("Panel");

            int result = 0;
            string t = "牛 ";
            
            for(int i = 0; i < cardNum; i++)
            {
                GameObject item = contentRoot.GetChild(i).gameObject;
                int num = item.GetComponent<CardItem>().GetCardNum();
                result += num;
            }
            result = result % 10;
            if(result == 0)
            {
                t += "牛";
            }
            else
            {
                t += result.ToString();
            }
            txt.text = t;
            btn_again.gameObject.SetActive(true);
        });

        btn_again.onClick.AddListener(() =>
        {
            RandomCardList();
        });
	}

    void LoadCard()
    {
        sps = Resources.LoadAll<Sprite>("Cards");
    }

    void RandomCardList()
    {
        btn_again.gameObject.SetActive(false);
        txt.gameObject.SetActive(false);

        List<Sprite> RandomList = new List<Sprite>();
        currentCard.Clear();
        for(int i = 0; i < sps.Length; i++)
        {
            RandomList.Add(sps[i]);
        }

        for(int i = 0; i < cardNum; i++)
        {
            int index = UnityEngine.Random.Range(0, RandomList.Count);
            currentCard.Add(RandomList[index]);
            RandomList.Remove(RandomList[index]);
        }
        Transform contentRoot = panelCard.Find("Panel");

        GameObject itemPrefab = contentRoot.GetChild(0).gameObject;

        if(itemPrefab)
        {
            //Debug.LogError("itemPrefab " +  currentCard.Count.ToString());
        }

        for(int i = 0; i < currentCard.Count; i++)
        {
            GameObject itemObj = null;

            if(i < contentRoot.childCount)
            {
                itemObj = contentRoot.GetChild(i).gameObject;
                //Debug.LogError("have" + i);
            }
            else
            {
                itemObj = GameObject.Instantiate<GameObject>(itemPrefab);
                itemObj.transform.SetParent(contentRoot, false);
                //Debug.LogError("create" + i);
            }
            itemObj.GetComponent<Image>().sprite = currentCard[i];
            itemObj.GetComponent<CardItem>().SetCardItem(currentCard[i].name);
        }
    }
}

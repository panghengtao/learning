using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardItem : MonoBehaviour {

    public int carNum = 0;

    public void SetCardItem(string str)
    {
        string[] target = str.Split('_');
        carNum = int.Parse(target[3]);
    }

    public int GetCardNum()
    {
        return carNum;
    }

}

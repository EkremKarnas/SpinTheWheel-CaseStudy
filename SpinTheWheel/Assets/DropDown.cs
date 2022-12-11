using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDown : MonoBehaviour
{

    [HideInInspector]
    public int listIdx = 0;
    [HideInInspector]
    public List<string> MyList1 = new List<string>(new string[] { "ui_card_icon_death", "ui_icon_aviator_glasses_easter", "ui_icon_baseball_cap_easter", "UI_icon_cash", "UI_icon_chest_big_nolight", "UI_icon_chest_Bronze_nolight", "UI_icon_chest_gold_nolight", "UI_icon_chest_silver_nolight" });

    [HideInInspector]
    public int listIdx2 = 0;
    [HideInInspector]
    public List<string> MyList2 = new List<string>(new string[] { "ui_card_icon_death", "ui_icon_aviator_glasses_easter", "ui_icon_baseball_cap_easter", "UI_icon_cash", "UI_icon_chest_big_nolight", "UI_icon_chest_Bronze_nolight", "UI_icon_chest_gold_nolight", "UI_icon_chest_silver_nolight" });

    [HideInInspector]
    public int listIdx3 = 0;
    [HideInInspector]
    public List<string> MyList3 = new List<string>(new string[] { "ui_card_icon_death", "ui_icon_aviator_glasses_easter", "ui_icon_baseball_cap_easter", "UI_icon_cash", "UI_icon_chest_big_nolight", "UI_icon_chest_Bronze_nolight", "UI_icon_chest_gold_nolight", "UI_icon_chest_silver_nolight" });

    [HideInInspector]
    public int listIdx4 = 0;
    [HideInInspector]
    public List<string> MyList4 = new List<string>(new string[] { "ui_card_icon_death", "ui_icon_aviator_glasses_easter", "ui_icon_baseball_cap_easter", "UI_icon_cash", "UI_icon_chest_big_nolight", "UI_icon_chest_Bronze_nolight", "UI_icon_chest_gold_nolight", "UI_icon_chest_silver_nolight" });

    [HideInInspector]
    public int listIdx5 = 0;
    [HideInInspector]
    public List<string> MyList5 = new List<string>(new string[] { "ui_card_icon_death", "ui_icon_aviator_glasses_easter", "ui_icon_baseball_cap_easter", "UI_icon_cash", "UI_icon_chest_big_nolight", "UI_icon_chest_Bronze_nolight", "UI_icon_chest_gold_nolight", "UI_icon_chest_silver_nolight" });

    [HideInInspector]
    public int listIdx6 = 0;
    [HideInInspector]
    public List<string> MyList6 = new List<string>(new string[] { "ui_card_icon_death", "ui_icon_aviator_glasses_easter", "ui_icon_baseball_cap_easter", "UI_icon_cash", "UI_icon_chest_big_nolight", "UI_icon_chest_Bronze_nolight", "UI_icon_chest_gold_nolight", "UI_icon_chest_silver_nolight" });

    [HideInInspector]
    public int listIdx7 = 0;
    [HideInInspector]
    public List<string> MyList7 = new List<string>(new string[] { "ui_card_icon_death", "ui_icon_aviator_glasses_easter", "ui_icon_baseball_cap_easter", "UI_icon_cash", "UI_icon_chest_big_nolight", "UI_icon_chest_Bronze_nolight", "UI_icon_chest_gold_nolight", "UI_icon_chest_silver_nolight" });

    [HideInInspector]
    public int listIdx8 = 0;
    [HideInInspector]
    public List<string> MyList8 = new List<string>(new string[] { "ui_card_icon_death", "ui_icon_aviator_glasses_easter", "ui_icon_baseball_cap_easter", "UI_icon_cash", "UI_icon_chest_big_nolight", "UI_icon_chest_Bronze_nolight", "UI_icon_chest_gold_nolight", "UI_icon_chest_silver_nolight" });
    public List<GameObject> ObjList;
    public List<Transform> transformList;
    private List<int> intList = new List<int>();
    private GameObject newObj4;

    void Awake() 
    {
        intList.Add(listIdx);
        intList.Add(listIdx2);
        intList.Add(listIdx3);
        intList.Add(listIdx4);
        intList.Add(listIdx5);
        intList.Add(listIdx6);
        intList.Add(listIdx7);
        intList.Add(listIdx8);
    }

    void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            newObj4 = Instantiate(ObjList[intList[i]], transformList[i].transform.position, transformList[i].transform.rotation);
            newObj4.transform.SetParent(transformList[i]);
        }
    }
}
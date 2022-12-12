using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDown : MonoBehaviour
{
    public float slot1DropProbablity;
    public float slot2DropProbablity;
    public float slot3DropProbablity;
    public float slot4DropProbablity;
    public float slot5DropProbablity;
    public float slot6DropProbablity;
    public float slot7DropProbablity;
    public float slot8DropProbablity;
    [HideInInspector]
    public int listIdx = 0;
    [HideInInspector]
    public List<string> Slot1 = new List<string>(new string[] { "ui_card_icon_death", "ui_icon_aviator_glasses_easter", "ui_icon_baseball_cap_easter", "UI_icon_cash", "UI_icon_chest_big_nolight", "UI_icon_chest_Bronze_nolight", "UI_icon_chest_gold_nolight", "UI_icon_chest_silver_nolight", "UI_icon_chest_small_noligt", "UI_icon_chest_small_noligt", "UI_icon_chest_super_nolight", "UI_icon_gold", "ui_icon_helmet_pumpkin", "ui_icon_mle_bayonet_easter_time", "ui_icon_mle_bayonet_summer_vice", "ui_icon_render_cons_grenade_m26", "ui_icon_render_cons_grenade_m67", "ui_icon_render_cons_healthshot_2_neurostim", "ui_icon_render_cons_healthshot_2_regenerator", "ui_icon_render_t_cons_molotov", "UI_Icon_Renders_tier1_shotgun", "UI_Icon_Renders_tier2_mle", "UI_Icon_Renders_tier2_rifle", "UI_Icon_Renders_tier3_shotgun", "UI_Icon_Renders_tier3_smg", "UI_Icon_Renders_tier3_sniper", "UI_Icons_Armor_Points", "UI_Icons_Knife_Points", "UI_Icons_Pistol_Points", "UI_Icons_Pistol_Points_", "UI_Icons_Rifle_Points", "UI_Icons_Shotgun_Points", "UI_Icons_SMG_Points", "UI_Icons_Sniper_Points", "UI_Icons_Submachine_Points", "UI_Icons_Vest_Points" });


    [HideInInspector]
    public int listIdx2 = 0;
    [HideInInspector]
    public List<string> MyList2 = new List<string>(new string[] { "ui_card_icon_death", "ui_icon_aviator_glasses_easter", "ui_icon_baseball_cap_easter", "UI_icon_cash", "UI_icon_chest_big_nolight", "UI_icon_chest_Bronze_nolight", "UI_icon_chest_gold_nolight", "UI_icon_chest_silver_nolight", "UI_icon_chest_small_noligt", "UI_icon_chest_small_noligt", "UI_icon_chest_super_nolight", "UI_icon_gold", "ui_icon_helmet_pumpkin", "ui_icon_mle_bayonet_easter_time", "ui_icon_mle_bayonet_summer_vice", "ui_icon_render_cons_grenade_m26", "ui_icon_render_cons_grenade_m67", "ui_icon_render_cons_healthshot_2_neurostim", "ui_icon_render_cons_healthshot_2_regenerator", "ui_icon_render_t_cons_molotov", "UI_Icon_Renders_tier1_shotgun", "UI_Icon_Renders_tier2_mle", "UI_Icon_Renders_tier2_rifle", "UI_Icon_Renders_tier3_shotgun", "UI_Icon_Renders_tier3_smg", "UI_Icon_Renders_tier3_sniper", "UI_Icons_Armor_Points", "UI_Icons_Knife_Points", "UI_Icons_Pistol_Points", "UI_Icons_Pistol_Points_", "UI_Icons_Rifle_Points", "UI_Icons_Shotgun_Points", "UI_Icons_SMG_Points", "UI_Icons_Sniper_Points", "UI_Icons_Submachine_Points", "UI_Icons_Vest_Points" });

    [HideInInspector]
    public int listIdx3 = 0;
    [HideInInspector]
    public List<string> MyList3 = new List<string>(new string[] { "ui_card_icon_death", "ui_icon_aviator_glasses_easter", "ui_icon_baseball_cap_easter", "UI_icon_cash", "UI_icon_chest_big_nolight", "UI_icon_chest_Bronze_nolight", "UI_icon_chest_gold_nolight", "UI_icon_chest_silver_nolight", "UI_icon_chest_small_noligt", "UI_icon_chest_small_noligt", "UI_icon_chest_super_nolight", "UI_icon_gold", "ui_icon_helmet_pumpkin", "ui_icon_mle_bayonet_easter_time", "ui_icon_mle_bayonet_summer_vice", "ui_icon_render_cons_grenade_m26", "ui_icon_render_cons_grenade_m67", "ui_icon_render_cons_healthshot_2_neurostim", "ui_icon_render_cons_healthshot_2_regenerator", "ui_icon_render_t_cons_molotov", "UI_Icon_Renders_tier1_shotgun", "UI_Icon_Renders_tier2_mle", "UI_Icon_Renders_tier2_rifle", "UI_Icon_Renders_tier3_shotgun", "UI_Icon_Renders_tier3_smg", "UI_Icon_Renders_tier3_sniper", "UI_Icons_Armor_Points", "UI_Icons_Knife_Points", "UI_Icons_Pistol_Points", "UI_Icons_Pistol_Points_", "UI_Icons_Rifle_Points", "UI_Icons_Shotgun_Points", "UI_Icons_SMG_Points", "UI_Icons_Sniper_Points", "UI_Icons_Submachine_Points", "UI_Icons_Vest_Points" });

    [HideInInspector]
    public int listIdx4 = 0;
    [HideInInspector]
    public List<string> MyList4 = new List<string>(new string[] { "ui_card_icon_death", "ui_icon_aviator_glasses_easter", "ui_icon_baseball_cap_easter", "UI_icon_cash", "UI_icon_chest_big_nolight", "UI_icon_chest_Bronze_nolight", "UI_icon_chest_gold_nolight", "UI_icon_chest_silver_nolight", "UI_icon_chest_small_noligt", "UI_icon_chest_small_noligt", "UI_icon_chest_super_nolight", "UI_icon_gold", "ui_icon_helmet_pumpkin", "ui_icon_mle_bayonet_easter_time", "ui_icon_mle_bayonet_summer_vice", "ui_icon_render_cons_grenade_m26", "ui_icon_render_cons_grenade_m67", "ui_icon_render_cons_healthshot_2_neurostim", "ui_icon_render_cons_healthshot_2_regenerator", "ui_icon_render_t_cons_molotov", "UI_Icon_Renders_tier1_shotgun", "UI_Icon_Renders_tier2_mle", "UI_Icon_Renders_tier2_rifle", "UI_Icon_Renders_tier3_shotgun", "UI_Icon_Renders_tier3_smg", "UI_Icon_Renders_tier3_sniper", "UI_Icons_Armor_Points", "UI_Icons_Knife_Points", "UI_Icons_Pistol_Points", "UI_Icons_Pistol_Points_", "UI_Icons_Rifle_Points", "UI_Icons_Shotgun_Points", "UI_Icons_SMG_Points", "UI_Icons_Sniper_Points", "UI_Icons_Submachine_Points", "UI_Icons_Vest_Points" });

    [HideInInspector]
    public int listIdx5 = 0;
    [HideInInspector]
    public List<string> MyList5 = new List<string>(new string[] { "ui_card_icon_death", "ui_icon_aviator_glasses_easter", "ui_icon_baseball_cap_easter", "UI_icon_cash", "UI_icon_chest_big_nolight", "UI_icon_chest_Bronze_nolight", "UI_icon_chest_gold_nolight", "UI_icon_chest_silver_nolight", "UI_icon_chest_small_noligt", "UI_icon_chest_small_noligt", "UI_icon_chest_super_nolight", "UI_icon_gold", "ui_icon_helmet_pumpkin", "ui_icon_mle_bayonet_easter_time", "ui_icon_mle_bayonet_summer_vice", "ui_icon_render_cons_grenade_m26", "ui_icon_render_cons_grenade_m67", "ui_icon_render_cons_healthshot_2_neurostim", "ui_icon_render_cons_healthshot_2_regenerator", "ui_icon_render_t_cons_molotov", "UI_Icon_Renders_tier1_shotgun", "UI_Icon_Renders_tier2_mle", "UI_Icon_Renders_tier2_rifle", "UI_Icon_Renders_tier3_shotgun", "UI_Icon_Renders_tier3_smg", "UI_Icon_Renders_tier3_sniper", "UI_Icons_Armor_Points", "UI_Icons_Knife_Points", "UI_Icons_Pistol_Points", "UI_Icons_Pistol_Points_", "UI_Icons_Rifle_Points", "UI_Icons_Shotgun_Points", "UI_Icons_SMG_Points", "UI_Icons_Sniper_Points", "UI_Icons_Submachine_Points", "UI_Icons_Vest_Points" });

    [HideInInspector]
    public int listIdx6 = 0;
    [HideInInspector]
    public List<string> MyList6 = new List<string>(new string[] { "ui_card_icon_death", "ui_icon_aviator_glasses_easter", "ui_icon_baseball_cap_easter", "UI_icon_cash", "UI_icon_chest_big_nolight", "UI_icon_chest_Bronze_nolight", "UI_icon_chest_gold_nolight", "UI_icon_chest_silver_nolight", "UI_icon_chest_small_noligt", "UI_icon_chest_small_noligt", "UI_icon_chest_super_nolight", "UI_icon_gold", "ui_icon_helmet_pumpkin", "ui_icon_mle_bayonet_easter_time", "ui_icon_mle_bayonet_summer_vice", "ui_icon_render_cons_grenade_m26", "ui_icon_render_cons_grenade_m67", "ui_icon_render_cons_healthshot_2_neurostim", "ui_icon_render_cons_healthshot_2_regenerator", "ui_icon_render_t_cons_molotov", "UI_Icon_Renders_tier1_shotgun", "UI_Icon_Renders_tier2_mle", "UI_Icon_Renders_tier2_rifle", "UI_Icon_Renders_tier3_shotgun", "UI_Icon_Renders_tier3_smg", "UI_Icon_Renders_tier3_sniper", "UI_Icons_Armor_Points", "UI_Icons_Knife_Points", "UI_Icons_Pistol_Points", "UI_Icons_Pistol_Points_", "UI_Icons_Rifle_Points", "UI_Icons_Shotgun_Points", "UI_Icons_SMG_Points", "UI_Icons_Sniper_Points", "UI_Icons_Submachine_Points", "UI_Icons_Vest_Points" });

    [HideInInspector]
    public int listIdx7 = 0;
    [HideInInspector]
    public List<string> MyList7 = new List<string>(new string[] { "ui_card_icon_death", "ui_icon_aviator_glasses_easter", "ui_icon_baseball_cap_easter", "UI_icon_cash", "UI_icon_chest_big_nolight", "UI_icon_chest_Bronze_nolight", "UI_icon_chest_gold_nolight", "UI_icon_chest_silver_nolight", "UI_icon_chest_small_noligt", "UI_icon_chest_small_noligt", "UI_icon_chest_super_nolight", "UI_icon_gold", "ui_icon_helmet_pumpkin", "ui_icon_mle_bayonet_easter_time", "ui_icon_mle_bayonet_summer_vice", "ui_icon_render_cons_grenade_m26", "ui_icon_render_cons_grenade_m67", "ui_icon_render_cons_healthshot_2_neurostim", "ui_icon_render_cons_healthshot_2_regenerator", "ui_icon_render_t_cons_molotov", "UI_Icon_Renders_tier1_shotgun", "UI_Icon_Renders_tier2_mle", "UI_Icon_Renders_tier2_rifle", "UI_Icon_Renders_tier3_shotgun", "UI_Icon_Renders_tier3_smg", "UI_Icon_Renders_tier3_sniper", "UI_Icons_Armor_Points", "UI_Icons_Knife_Points", "UI_Icons_Pistol_Points", "UI_Icons_Pistol_Points_", "UI_Icons_Rifle_Points", "UI_Icons_Shotgun_Points", "UI_Icons_SMG_Points", "UI_Icons_Sniper_Points", "UI_Icons_Submachine_Points", "UI_Icons_Vest_Points" });

    [HideInInspector]
    public int listIdx8 = 0;
    [HideInInspector]
    public List<string> MyList8 = new List<string>(new string[] { "ui_card_icon_death", "ui_icon_aviator_glasses_easter", "ui_icon_baseball_cap_easter", "UI_icon_cash", "UI_icon_chest_big_nolight", "UI_icon_chest_Bronze_nolight", "UI_icon_chest_gold_nolight", "UI_icon_chest_silver_nolight", "UI_icon_chest_small_noligt", "UI_icon_chest_small_noligt", "UI_icon_chest_super_nolight", "UI_icon_gold", "ui_icon_helmet_pumpkin", "ui_icon_mle_bayonet_easter_time", "ui_icon_mle_bayonet_summer_vice", "ui_icon_render_cons_grenade_m26", "ui_icon_render_cons_grenade_m67", "ui_icon_render_cons_healthshot_2_neurostim", "ui_icon_render_cons_healthshot_2_regenerator", "ui_icon_render_t_cons_molotov", "UI_Icon_Renders_tier1_shotgun", "UI_Icon_Renders_tier2_mle", "UI_Icon_Renders_tier2_rifle", "UI_Icon_Renders_tier3_shotgun", "UI_Icon_Renders_tier3_smg", "UI_Icon_Renders_tier3_sniper", "UI_Icons_Armor_Points", "UI_Icons_Knife_Points", "UI_Icons_Pistol_Points", "UI_Icons_Pistol_Points_", "UI_Icons_Rifle_Points", "UI_Icons_Shotgun_Points", "UI_Icons_SMG_Points", "UI_Icons_Sniper_Points", "UI_Icons_Submachine_Points", "UI_Icons_Vest_Points" });
    public List<GameObject> ObjList;
    public List<Transform> transformList;
    private List<int> intList = new List<int>();
    private GameObject instantiatedObject;
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
            instantiatedObject = Instantiate(ObjList[intList[i]], transformList[i].transform.position, transformList[i].transform.rotation);
            instantiatedObject.transform.SetParent(transformList[i]);
        }
    }
}
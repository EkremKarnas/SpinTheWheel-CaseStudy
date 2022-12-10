using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class SpinTheWheel : MonoBehaviour
{
    [SerializeField] AnimationCurve animationCurve;
    private bool isSpinning;
    [SerializeField] int spinningTime;
    [SerializeField] int spinningAngle;
    [SerializeField] GameObject ui_card_icon_death;
    [SerializeField] Transform slot1Transform;
    //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    enum Slot1 { ui_card_icon_death, ui_icon_aviator_glasses_easter, ui_icon_baseball_cap_easter, UI_icon_cash, UI_icon_chest_Bronze_nolight, UI_icon_chest_gold_nolight, UI_icon_chest_silver_nolight, UI_icon_chest_small_noligt,UI_icon_chest_standart_nolight, UI_icon_chest_super_nolight, UI_icon_gold, ui_icon_helmet_pumpkin, ui_icon_mle_bayonet_easter_time, ui_icon_mle_bayonet_summer_vice, ui_icon_render_cons_grenade_m26, ui_icon_render_cons_grenade_m67, ui_icon_render_cons_healthshot_2_neurostim, ui_icon_render_cons_healthshot_2_regenerator, ui_icon_render_t_cons_molotov, UI_Icon_Renders_tier1_shotgun, UI_Icon_Renders_tier2_mle, UI_Icon_Renders_tier2_rifle, UI_Icon_Renders_tier3_shotgun, UI_Icon_Renders_tier3_smg, UI_Icon_Renders_tier3_sniper, UI_Icons_Armor_Points, UI_Icons_Knife_Points, UI_Icons_Pistol_Points,UI_Icons_Pistol_Points_, UI_Icons_Rifle_Points, UI_Icons_Shotgun_Points,UI_Icons_SMG_Points, UI_Icons_Sniper_Points, UI_Icons_Submachine_Points, UI_Icons_Vest_Points }
    enum Slot2 { ui_card_icon_death, ui_icon_aviator_glasses_easter, ui_icon_baseball_cap_easter, UI_icon_cash, UI_icon_chest_Bronze_nolight, UI_icon_chest_gold_nolight, UI_icon_chest_silver_nolight, UI_icon_chest_small_noligt,UI_icon_chest_standart_nolight, UI_icon_chest_super_nolight, UI_icon_gold, ui_icon_helmet_pumpkin, ui_icon_mle_bayonet_easter_time, ui_icon_mle_bayonet_summer_vice, ui_icon_render_cons_grenade_m26, ui_icon_render_cons_grenade_m67, ui_icon_render_cons_healthshot_2_neurostim, ui_icon_render_cons_healthshot_2_regenerator, ui_icon_render_t_cons_molotov, UI_Icon_Renders_tier1_shotgun, UI_Icon_Renders_tier2_mle, UI_Icon_Renders_tier2_rifle, UI_Icon_Renders_tier3_shotgun, UI_Icon_Renders_tier3_smg, UI_Icon_Renders_tier3_sniper, UI_Icons_Armor_Points, UI_Icons_Knife_Points, UI_Icons_Pistol_Points,UI_Icons_Pistol_Points_, UI_Icons_Rifle_Points, UI_Icons_Shotgun_Points,UI_Icons_SMG_Points, UI_Icons_Sniper_Points, UI_Icons_Submachine_Points, UI_Icons_Vest_Points }
    enum Slot3 { ui_card_icon_death, ui_icon_aviator_glasses_easter, ui_icon_baseball_cap_easter, UI_icon_cash, UI_icon_chest_Bronze_nolight, UI_icon_chest_gold_nolight, UI_icon_chest_silver_nolight, UI_icon_chest_small_noligt,UI_icon_chest_standart_nolight, UI_icon_chest_super_nolight, UI_icon_gold, ui_icon_helmet_pumpkin, ui_icon_mle_bayonet_easter_time, ui_icon_mle_bayonet_summer_vice, ui_icon_render_cons_grenade_m26, ui_icon_render_cons_grenade_m67, ui_icon_render_cons_healthshot_2_neurostim, ui_icon_render_cons_healthshot_2_regenerator, ui_icon_render_t_cons_molotov, UI_Icon_Renders_tier1_shotgun, UI_Icon_Renders_tier2_mle, UI_Icon_Renders_tier2_rifle, UI_Icon_Renders_tier3_shotgun, UI_Icon_Renders_tier3_smg, UI_Icon_Renders_tier3_sniper, UI_Icons_Armor_Points, UI_Icons_Knife_Points, UI_Icons_Pistol_Points,UI_Icons_Pistol_Points_, UI_Icons_Rifle_Points, UI_Icons_Shotgun_Points,UI_Icons_SMG_Points, UI_Icons_Sniper_Points, UI_Icons_Submachine_Points, UI_Icons_Vest_Points }
    enum Slot4 { ui_card_icon_death, ui_icon_aviator_glasses_easter, ui_icon_baseball_cap_easter, UI_icon_cash, UI_icon_chest_Bronze_nolight, UI_icon_chest_gold_nolight, UI_icon_chest_silver_nolight, UI_icon_chest_small_noligt,UI_icon_chest_standart_nolight, UI_icon_chest_super_nolight, UI_icon_gold, ui_icon_helmet_pumpkin, ui_icon_mle_bayonet_easter_time, ui_icon_mle_bayonet_summer_vice, ui_icon_render_cons_grenade_m26, ui_icon_render_cons_grenade_m67, ui_icon_render_cons_healthshot_2_neurostim, ui_icon_render_cons_healthshot_2_regenerator, ui_icon_render_t_cons_molotov, UI_Icon_Renders_tier1_shotgun, UI_Icon_Renders_tier2_mle, UI_Icon_Renders_tier2_rifle, UI_Icon_Renders_tier3_shotgun, UI_Icon_Renders_tier3_smg, UI_Icon_Renders_tier3_sniper, UI_Icons_Armor_Points, UI_Icons_Knife_Points, UI_Icons_Pistol_Points,UI_Icons_Pistol_Points_, UI_Icons_Rifle_Points, UI_Icons_Shotgun_Points,UI_Icons_SMG_Points, UI_Icons_Sniper_Points, UI_Icons_Submachine_Points, UI_Icons_Vest_Points }
    enum Slot5 { ui_card_icon_death, ui_icon_aviator_glasses_easter, ui_icon_baseball_cap_easter, UI_icon_cash, UI_icon_chest_Bronze_nolight, UI_icon_chest_gold_nolight, UI_icon_chest_silver_nolight, UI_icon_chest_small_noligt,UI_icon_chest_standart_nolight, UI_icon_chest_super_nolight, UI_icon_gold, ui_icon_helmet_pumpkin, ui_icon_mle_bayonet_easter_time, ui_icon_mle_bayonet_summer_vice, ui_icon_render_cons_grenade_m26, ui_icon_render_cons_grenade_m67, ui_icon_render_cons_healthshot_2_neurostim, ui_icon_render_cons_healthshot_2_regenerator, ui_icon_render_t_cons_molotov, UI_Icon_Renders_tier1_shotgun, UI_Icon_Renders_tier2_mle, UI_Icon_Renders_tier2_rifle, UI_Icon_Renders_tier3_shotgun, UI_Icon_Renders_tier3_smg, UI_Icon_Renders_tier3_sniper, UI_Icons_Armor_Points, UI_Icons_Knife_Points, UI_Icons_Pistol_Points,UI_Icons_Pistol_Points_, UI_Icons_Rifle_Points, UI_Icons_Shotgun_Points,UI_Icons_SMG_Points, UI_Icons_Sniper_Points, UI_Icons_Submachine_Points, UI_Icons_Vest_Points }
    enum Slot6 { ui_card_icon_death, ui_icon_aviator_glasses_easter, ui_icon_baseball_cap_easter, UI_icon_cash, UI_icon_chest_Bronze_nolight, UI_icon_chest_gold_nolight, UI_icon_chest_silver_nolight, UI_icon_chest_small_noligt,UI_icon_chest_standart_nolight, UI_icon_chest_super_nolight, UI_icon_gold, ui_icon_helmet_pumpkin, ui_icon_mle_bayonet_easter_time, ui_icon_mle_bayonet_summer_vice, ui_icon_render_cons_grenade_m26, ui_icon_render_cons_grenade_m67, ui_icon_render_cons_healthshot_2_neurostim, ui_icon_render_cons_healthshot_2_regenerator, ui_icon_render_t_cons_molotov, UI_Icon_Renders_tier1_shotgun, UI_Icon_Renders_tier2_mle, UI_Icon_Renders_tier2_rifle, UI_Icon_Renders_tier3_shotgun, UI_Icon_Renders_tier3_smg, UI_Icon_Renders_tier3_sniper, UI_Icons_Armor_Points, UI_Icons_Knife_Points, UI_Icons_Pistol_Points,UI_Icons_Pistol_Points_, UI_Icons_Rifle_Points, UI_Icons_Shotgun_Points,UI_Icons_SMG_Points, UI_Icons_Sniper_Points, UI_Icons_Submachine_Points, UI_Icons_Vest_Points }
    enum Slot7 { ui_card_icon_death, ui_icon_aviator_glasses_easter, ui_icon_baseball_cap_easter, UI_icon_cash, UI_icon_chest_Bronze_nolight, UI_icon_chest_gold_nolight, UI_icon_chest_silver_nolight, UI_icon_chest_small_noligt,UI_icon_chest_standart_nolight, UI_icon_chest_super_nolight, UI_icon_gold, ui_icon_helmet_pumpkin, ui_icon_mle_bayonet_easter_time, ui_icon_mle_bayonet_summer_vice, ui_icon_render_cons_grenade_m26, ui_icon_render_cons_grenade_m67, ui_icon_render_cons_healthshot_2_neurostim, ui_icon_render_cons_healthshot_2_regenerator, ui_icon_render_t_cons_molotov, UI_Icon_Renders_tier1_shotgun, UI_Icon_Renders_tier2_mle, UI_Icon_Renders_tier2_rifle, UI_Icon_Renders_tier3_shotgun, UI_Icon_Renders_tier3_smg, UI_Icon_Renders_tier3_sniper, UI_Icons_Armor_Points, UI_Icons_Knife_Points, UI_Icons_Pistol_Points,UI_Icons_Pistol_Points_, UI_Icons_Rifle_Points, UI_Icons_Shotgun_Points,UI_Icons_SMG_Points, UI_Icons_Sniper_Points, UI_Icons_Submachine_Points, UI_Icons_Vest_Points }
    enum Slot8 { ui_card_icon_death, ui_icon_aviator_glasses_easter, ui_icon_baseball_cap_easter, UI_icon_cash, UI_icon_chest_Bronze_nolight, UI_icon_chest_gold_nolight, UI_icon_chest_silver_nolight, UI_icon_chest_small_noligt,UI_icon_chest_standart_nolight, UI_icon_chest_super_nolight, UI_icon_gold, ui_icon_helmet_pumpkin, ui_icon_mle_bayonet_easter_time, ui_icon_mle_bayonet_summer_vice, ui_icon_render_cons_grenade_m26, ui_icon_render_cons_grenade_m67, ui_icon_render_cons_healthshot_2_neurostim, ui_icon_render_cons_healthshot_2_regenerator, ui_icon_render_t_cons_molotov, UI_Icon_Renders_tier1_shotgun, UI_Icon_Renders_tier2_mle, UI_Icon_Renders_tier2_rifle, UI_Icon_Renders_tier3_shotgun, UI_Icon_Renders_tier3_smg, UI_Icon_Renders_tier3_sniper, UI_Icons_Armor_Points, UI_Icons_Knife_Points, UI_Icons_Pistol_Points,UI_Icons_Pistol_Points_, UI_Icons_Rifle_Points, UI_Icons_Shotgun_Points,UI_Icons_SMG_Points, UI_Icons_Sniper_Points, UI_Icons_Submachine_Points, UI_Icons_Vest_Points }
    [SerializeField] Slot1 slot1;
    [SerializeField] Slot2 slot2;
    [SerializeField] Slot3 slot3;
    [SerializeField] Slot4 slot4;
    [SerializeField] Slot5 slot5;
    [SerializeField] Slot6 slot6;
    [SerializeField] Slot7 slot7;
    [SerializeField] Slot8 slot8;
    void Start()
    {
        isSpinning = false;

        if (slot1 == Slot1.ui_card_icon_death)
        {
            var ui_card_icon_deathObj = Instantiate(ui_card_icon_death, slot1Transform.position, Quaternion.Euler(0, 0, 0));
            ui_card_icon_deathObj.transform.SetParent(slot1Transform);
            ui_card_icon_deathObj.transform.localScale = new Vector3(0.125f, 0.125f,0.125f);
        }

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isSpinning)
        {
            StartCoroutine(SpinTheWheelFunc(spinningTime, spinningAngle));
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            // superchest1.transform.localScale = Vector3.one;
        }
    }

    IEnumerator SpinTheWheelFunc(float time, float spinningAngle)
    {
        isSpinning = true;
        float timer = 0.0f;

        while (timer < time)
        {
            float angle = spinningAngle * animationCurve.Evaluate(timer / time);
            transform.eulerAngles = new Vector3(0f, 0f, angle);
            timer += Time.deltaTime;

            yield return null;
        }
        transform.eulerAngles = new Vector3(0f, 0f, spinningAngle);
        isSpinning = false;
    }
}

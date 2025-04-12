using HarmonyLib;
using MGSC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace QM_CargoMercHotkeys
{
    [HarmonyPatch(typeof(SpaceshipScreen), nameof(SpaceshipScreen.Update))]
    public static class SpaceshipScreen_Process_HotKey_Patch
    {
        public static void Prefix(SpaceshipScreen __instance)
        {

            if (Input.GetKeyUp(Plugin.Config.CargoKey) && __instance._arsenalButton.isActiveAndEnabled)
            {
                __instance.ArsenalButtonOnClick(__instance._arsenalButton,1);
                return;
            }
            else if (Input.GetKeyUp(Plugin.Config.MercenariesKey) && __instance._mercenariesButton.isActiveAndEnabled)
            {
                __instance.MercenariesButtonOnClick(__instance._mercenariesButton,1);
                return;
            }
        }
    }
}

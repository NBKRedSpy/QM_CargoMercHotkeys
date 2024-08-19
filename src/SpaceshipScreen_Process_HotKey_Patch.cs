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
    [HarmonyPatch(typeof(SpaceshipScreen), nameof(SpaceshipScreen.Process))]
    public static class SpaceshipScreen_Process_HotKey_Patch
    {
        public static void Prefix(SpaceshipScreen __instance)
        {
            //NOTE - There is no harm in letting the original code run.

            //---The checks the game uses to ignore key processing.
            // Split across two checks
            //  if (!base.gameObject.activeSelf)
            //
            //  if (SharedUi.NarrativeTextScreen.IsViewActive || SharedUi.ConfirmMagnumUpgradeWindow.IsViewActive ||
            //  SharedUi.ConfirmDialogWindow.IsViewActive || _itemProductionContextMenu.gameObject.activeSelf)
            if (!__instance.gameObject.activeSelf || SharedUi.NarrativeTextScreen.IsViewActive || SharedUi.ConfirmMagnumUpgradeWindow.IsViewActive || SharedUi.ConfirmDialogWindow.IsViewActive || __instance._itemProductionContextMenu.gameObject.activeSelf)
            {
                return;
            }

            if (Input.GetKeyUp(Plugin.Config.CargoKey) && __instance._arsenalButton.isActiveAndEnabled)
            {
                __instance.ArsenalButtonOnClick(__instance._arsenalButton);
                return;
            }
            else if (Input.GetKeyUp(Plugin.Config.MercenariesKey) && __instance._mercenariesButton.isActiveAndEnabled)
            {
                __instance.MercenariesButtonOnClick(__instance._mercenariesButton);
                return;
            }
        }
    }
}

using System;

using BepInEx;
using HarmonyLib;
using UnityEngine;
using nel;

namespace Demosaicing_Plugin_for_AliceInCradle
{
    [BepInPlugin("Plugins.Demosaicing.AliceInCradle", "Demosaicing Plugin for AliceInCradle", "0.0.1")]
    [BepInProcess("AliceInCradle.exe")]
    public class Plugin : BaseUnityPlugin
    {
        public void Awake()
        {
            
            Logger.LogInfo("AliceInCradleMosaicPatch for AliceInCradle loaded.");

            Harmony.CreateAndPatchAll(typeof(MosaicShowerPatch));

            Logger.LogInfo("Patch MosaicShowerPatch succeed.");
        }
    }

    [HarmonyPatch]
    public class MosaicShowerPatch
    {
        [HarmonyPatch(typeof(MosaicShower), "FnDrawMosaic")]
        [HarmonyPrefix]
        public static void FnDrawMosaic(ref bool __result)
        {
            
        }
    }
}

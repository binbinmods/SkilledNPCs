using BepInEx;
using BepInEx.Logging;
using BepInEx.Configuration;
using HarmonyLib;
using static Obeliskial_Essentials.CardDescriptionNew;
using System;
using static SkilledNPCs.CustomFunctions;
using System.Text.RegularExpressions;
using System.Reflection;
using UnityEngine;
using System.Collections.Generic;
using static SkilledNPCs.Plugin;
// using static MatchManager;

// Make sure your namespace is the same everywhere
namespace SkilledNPCs
{

    [HarmonyPatch] //DO NOT REMOVE/CHANGE

    public class SkilledNPCsPatches
    {



        [HarmonyPrefix]
        [HarmonyPatch(typeof(NPC), nameof(NPC.CreateOverDeck))]
        public static void CreateOverDeck(ref NPC __instance)
        {
            // Add one to the number of cards played by each enemy
            if (__instance == null)
            {
                return;
            }

            LogDebug($"CreateOverDeck - {__instance?.NpcData?.Id} - {__instance?.NpcData?.CardsInHand}");

            __instance.NpcData.CardsInHand++;
        }




    }
}

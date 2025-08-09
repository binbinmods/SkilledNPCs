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



        [HarmonyPostfix]
        [HarmonyPatch(typeof(Globals), nameof(Functions.GetCardByRarity))]
        public static void CreateGameContentPostfix(ref string __result, int rarity, CardData _cardData, bool isChallenge = false)
        {
            // Add one to the number of cards played by each enemy


        }




    }
}

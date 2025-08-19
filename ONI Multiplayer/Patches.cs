using HarmonyLib;
using Klei;

namespace ONI_Multiplayer
{
    public class MainMenu_OnPrefabInit_Patch
    {
        [HarmonyPatch(typeof(MainMenu))]
        [HarmonyPatch("OnPrefabInit")]
        public class Db_Initialize_Patch
        {
            public static void Prefix()
            {
                Debug.Log("I execute before MainMenu.OnPrefabInit!");
            }

            public static void Postfix()
            {
                
               

            }
        }
    }
}

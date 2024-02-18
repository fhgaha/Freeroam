//using HarmonyLib;
//using UnityEngine;
//using Atomicrops.Game.GameState;

//namespace Freeroam
//{
//    [HarmonyPatch(typeof(GameStateManager), "AwakeSub")]
//    class GameStateManager_Patch
//    {
//        //static AccessTools.FieldRef<InputKeyRewired, bool> fromCode = AccessTools.FieldRefAccess<InputKeyRewired, bool>("_fromCode");
//        //static AccessTools.FieldRef<InputKeyRewired, bool> fromCodeIsHolding = AccessTools.FieldRefAccess<InputKeyRewired, bool>("_fromCodeIsHolding");
//        //static AccessTools.FieldRef<InputKeyRewired, object> reserver = AccessTools.FieldRefAccess<InputKeyRewired, object>("_reserver");

//        static bool hold = false;

//        //static bool Prefix() => false;

//        static void Postfix(InputKeyRewired __instance)
//        {
//            Debug.Log($"@@@ GameStateManager_Patch.Postfix");
//            var go = new GameObject("MyConsoleObj");
//            go.AddComponent<MyConsole>();
//            //UnityEngine.Object.Instantiate(go);
//            UnityEngine.Object.DontDestroyOnLoad(go);
//        }
//    }
//}






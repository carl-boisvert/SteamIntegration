using GameFramework.Online.Interfaces;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace GameFramework.Online {

    public class OnlineSubsystem : MonoBehaviour
    {
        public enum OnlineManager {
            STEAM
        }


        public static IOnlineManager GetOnlineManager(OnlineManager manager) {

            GameObject managerGo;
            switch (manager) {
                case OnlineManager.STEAM:
                    managerGo = CreateManager<SteamManager>();
                    break;
                default:
                    return null;
            }
            return managerGo.GetComponent<IOnlineManager>();
        }


        private static GameObject CreateManager<T>() where T : MonoBehaviour
        {
            GameObject go = new GameObject();
            go.AddComponent<T>();
            return go;
        }
    }
}

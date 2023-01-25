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

            switch (manager) {
                case OnlineManager.STEAM:
                    return new SteamManager();
                default:
                    return null;
            }
            
        }
    }
}

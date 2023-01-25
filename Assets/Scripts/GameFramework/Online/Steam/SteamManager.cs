using GameFramework.Online.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFramework{
    public class SteamManager : MonoBehaviour, IOnlineManager
    {

        private SteamUserManager _userManager;
        private SteamFriendsManager _friendManager;

        public IOnlineUserInterface GetUserInterface()
        {
            GameObject userManager = CreateManager<SteamUserManager>();
            _userManager = userManager.GetComponent<SteamUserManager>();
            return _userManager;
        }
        
        public IFriendsInterface GetFriendsInterface()
        {
            GameObject friendsManager = CreateManager<SteamFriendsManager>();
            _friendManager = friendsManager.GetComponent<SteamFriendsManager>();
            return _friendManager;
        }

        private static GameObject CreateManager<T>() where T : MonoBehaviour
        {
            GameObject go = new GameObject();
            go.AddComponent<T>();
            return go;
        }

        
    }
}
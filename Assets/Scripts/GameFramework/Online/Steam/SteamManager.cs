using GameFramework.Online.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFramework{
    public class SteamManager : MonoBehaviour, IOnlineManager
    {
        public IOnlineUserInterface GetUserInterface()
        {
            return new SteamUserManager();
        }
    }
}
using UnityEngine;

using Steamworks;
using GameFramework.Online.Interfaces;

public class SteamUserManager : MonoBehaviour, IOnlineUserInterface
{
    public string GetGamertag()
    {
        if (SteamManager.Initialized)
        {
            return SteamFriends.GetPersonaName();
        }
        return "";
    }
}

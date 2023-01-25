using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Steamworks;


public class SteamFriendsManager : MonoBehaviour, IFriendsInterface
{
    public void InviteFriend()
    {
        if (SteamManager.Initialized)
        {
            SteamFriends.ActivateGameOverlay("Friends");
        }
    }
}

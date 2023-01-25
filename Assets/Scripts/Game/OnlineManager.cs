using UnityEngine;

using GameFramework.Online;
using GameFramework.Online.Interfaces;

public class OnlineManager : MonoBehaviour
{
    [SerializeField] private OnlineSubsystem.OnlineManager OnlineManagerSubsytem;
    private IOnlineManager _manager;
    private IOnlineUserInterface _userManager;
    // Start is called before the first frame update
    void Start()
    {
        _manager = OnlineSubsystem.GetOnlineManager(OnlineManagerSubsytem);
        _userManager = _manager.GetUserInterface();
        Debug.Log(_userManager.GetGamertag());

        IFriendsInterface _friendManager = _manager.GetFriendsInterface();
        _friendManager.InviteFriend();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

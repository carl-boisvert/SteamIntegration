using UnityEngine;

using GameFramework.Online;
using GameFramework.Online.Interfaces;

public class OnlineManager : MonoBehaviour
{
    private IOnlineManager _manager;
    private IOnlineUserInterface _userManager;
    // Start is called before the first frame update
    void Start()
    {
        _manager = OnlineSubsystem.GetOnlineManager(OnlineSubsystem.OnlineManager.STEAM);
        _userManager = _manager.GetUserInterface();
        Debug.Log(_userManager.GetGamertag());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

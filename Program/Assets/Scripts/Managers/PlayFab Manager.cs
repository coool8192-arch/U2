using UnityEngine;
using Photon.Pun;
using PlayFab.ClientModels;
using TMPro;

public class PlayFabManager : MonoBehaviourPunCallbacks
{
    [SerializeField] string version;
    [SerializeField] TMP_InputField addressInputField;
    [SerializeField] TMP_InputField passwordInputField;
}

using Photon.Pun;
using Unity.VisualScripting;
using UnityEngine;

public class Head : MonoBehaviourPunCallbacks
{
    [SerializeField] Rotation rotation;
    [SerializeField] float minimumAngle = -55f;
    [SerializeField] float maximumAngle = 55f;

    void Awake()
    {
        rotation = GetComponent<Rotation>();
    }

    void Update()
    {
        
    }
}

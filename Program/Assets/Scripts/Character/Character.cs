using Photon.Pun;
using Unity.VisualScripting;
using UnityEngine;

public class Character : MonoBehaviourPun
{
    [SerializeField] Vector3 direction;

    void Start()
    {
        DisableCamera();
    }

    void Update()
    {

    }

    void FixedUpdate()
    {

    }

    void DisableCamera()
    {
        if (photonView.IsMine == true)
        {
            Camera.main.gameObject.SetActive(false);
        }
        else
        {
            Camera eyes = transform.GetComponentInChildren<Camera>();

            eyes.GetComponent<AudioListener>().gameObject.SetActive(false);

            eyes.gameObject.SetActive(false);
        }
    }

    void Control()
    {

    }

    void Move()
    {


       // rigidbody.MovePosition();
    }
}

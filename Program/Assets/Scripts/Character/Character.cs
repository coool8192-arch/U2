using Photon.Pun;
using UnityEngine;

public class Character : MonoBehaviourPun
{
    [SerializeField] Vector3 direction;
    [SerializeField] float speed;
    [SerializeField] Rotation rotation;
    [SerializeField] Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        DisableCamera();
    }

    void Update()
    {
        if (photonView.IsMine)
        {
            Control();
        }
    }

    void FixedUpdate()
    {
        if (photonView.IsMine)
        {
            Move();

            rotation.RotateY(rigidbody);
        }
    }

    void Control()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();
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

    void Move()
    {
        rigidbody.MovePosition(rigidbody.position + rigidbody.transform.TransformDirection(direction) * speed);
    }
}

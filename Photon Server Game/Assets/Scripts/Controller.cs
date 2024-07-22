using TMPro;
using Photon.Pun;
using UnityEngine;

public class Controller : MonoBehaviourPun
{
    [SerializeField] float speed;
    [SerializeField] float mouseX;

    [SerializeField] Vector3 direction;
    [SerializeField] Camera temporaryCamera; 

    void Start()
    {
        if(photonView.IsMine)
        {
            Camera.main.gameObject.SetActive(false);
        }
        else
        {
            temporaryCamera.enabled = false;
            GetComponentInChildren<AudioListener>().enabled = true;
        }
    }

    void Update()
    {

    }
}

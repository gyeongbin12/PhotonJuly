using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class View : MonoBehaviourPunCallbacks
{
    [SerializeField] TMP_Text nickName;

    public void Start()
    {
        nickName.text = PhotonNetwork.NickName;
    }

    public void Update()
    {
        transform.forward = Camera.main.transform.forward;
    }
}

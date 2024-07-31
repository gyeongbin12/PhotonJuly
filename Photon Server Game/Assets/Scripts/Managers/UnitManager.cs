using UnityEngine;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine.Experimental.Rendering;

public class UnitManager : MonoBehaviourPunCallbacks
{
    [SerializeField] float time;
    [SerializeField] Transform [ ] warp;

    void Start()
    {
        if(PhotonNetwork.IsMasterClient)
        {
            StartCoroutine(Create());
        }
    }

    public IEnumerator Create()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(time);

        while (true)
        {
            int random = Random.Range(0, warp.Length);

            PhotonNetwork.InstantiateRoomObject("unit", warp[random].position, Quaternion.identity);

            yield return waitForSeconds;
        }
    }

    public override void OnMasterClientSwitched(Player newMasterClient)
    {
        PhotonNetwork.SetMasterClient(PhotonNetwork.PlayerList[0]);

        if (PhotonNetwork.IsMasterClient)
        {
            StartCoroutine(Create());
        }
    }


}

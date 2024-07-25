using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using JetBrains.Annotations;
using UnityEngine.UI;

public class GameManager : MonoBehaviourPunCallbacks
{
    private void Awake()
    {
        Create();
    }

    void Start()
    {

    }

    public void Create()
    {
        PhotonNetwork.Instantiate
        (
             "Character",
            RandomPosition(5),
            Quaternion.identity
        );
    }

    public Vector3 RandomPosition(int value)
    {
       Vector3 direaction = Random.insideUnitSphere;

        direaction.Normalize();

        direaction *= value;

        direaction.y = 1;

        return direaction;
    }
}


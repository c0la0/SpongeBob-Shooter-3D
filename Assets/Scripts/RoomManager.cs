using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class RoomManager : MonoBehaviourPunCallbacks
{

    public GameObject player;

    [Space]
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log ("Connecting..!");
        PhotonNetwork.ConnectUsingSettings();

    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        Debug.Log("Connected!");

        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();
        PhotonNetwork.JoinOrCreateRoom("Test",null,null);

        Debug.Log ("We're Connected To Lobby");

        GameObject _player = PhotonNetwork.Instantiate(player.name, spawnPoint.position,Quaternion.identity);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}


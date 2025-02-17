using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Test : MonoBehaviour
{
    [SerializeField]public List<GameObject> listPlayers;

    PlayerInputManager manager;
    int id = 0;
    [HideInInspector]
    public int number = 0;
    GameObject player1;
    GameObject player2;
    public bool unlockMove;
    
    // Start is called before the first frame update
    void Start()
    {
        manager = GetComponent<PlayerInputManager>();
        id = 0;
        manager.playerPrefab = listPlayers[id];
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddPlayer()
    {
        id = 1;
        manager.playerPrefab = listPlayers[id];
        number += 1;
        if(number >= 2)
        {
            AttribuatePlayerList();
        }
    }

    private void AttribuatePlayerList()
    {
        player1 = listPlayers[0];    
        player2 = listPlayers[1];

        unlockMove = true;
    }
}

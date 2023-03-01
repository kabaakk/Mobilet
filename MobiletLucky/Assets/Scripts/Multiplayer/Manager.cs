using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Manager : NetworkBehaviour
{
    bool clicked = false;
    public int playerCount = 0;
    public override void OnStartClient()
    {
        base.OnStartClient();
        StarterController.instance.chooseScene();
    }

    [Server]
    public override void OnStartServer()
    {
        base.OnStartServer();
    }

    [Command]
    public void CmdActivePlayers(string playerNumber)
    {
        if (playerNumber == "Player1")
        {
            if (isOwned)
            {
                if (!clicked) 
                {
                    clicked = true;
                    StarterController.instance.InstantFirstGreen();
                    RpcActivePlayers("Player1");
                    playerCount++;
                }
            } else
            {
                if (!clicked) 
                {
                    clicked = true;
                    StarterController.instance.InstantFirstBlack();
                    RpcActivePlayers("Player1");
                }
            }
        }

        if (playerNumber == "Player2")
        {
            if (isOwned)
            {
                if (!clicked)
                {
                    clicked = true;
                    StarterController.instance.InstantSecondGreen();
                    RpcActivePlayers("Player2");
                    playerCount++;
                }
            } else
            {
                if (!clicked)
                {
                    clicked = true;
                    StarterController.instance.InstantSecondBlack();
                    RpcActivePlayers("Player2");
                }
            }
        }

        if (playerNumber == "Player3")
        {
            if (isOwned)
            {
                if (!clicked)
                {
                    clicked = true;
                    StarterController.instance.InstantThirdGreen();
                    RpcActivePlayers("Player3");
                    playerCount++;
                }
            } else
            {
                if (!clicked)
                {
                    clicked = true;
                    StarterController.instance.InstantThirdBlack();
                    RpcActivePlayers("Player3");
                }
            }
        }

        if (playerNumber == "Player4")
        {
            if (isOwned)
            {
                if (!clicked)
                {
                    clicked = true;
                    StarterController.instance.InstantForthGreen();
                    RpcActivePlayers("Player4");
                    playerCount++;
                }
            } else
            {
                if (!clicked)
                {
                    clicked = true;
                    StarterController.instance.InstantForthBlack();
                    RpcActivePlayers("Player4");
                }
            }
        }
    }

    [ClientRpc]
    void RpcActivePlayers(string playerNumber)
    {
        if (playerNumber == "Player1")
        {
            if (isOwned)
            {
                StarterController.instance.InstantFirstGreen();
                playerCount++;
            } else
            {
                StarterController.instance.InstantFirstBlack();
            }
        }

        if (playerNumber == "Player2")
        {
            if (isOwned)
            {
                StarterController.instance.InstantSecondGreen();
                playerCount++;
            } else
            {
                StarterController.instance.InstantSecondBlack();
            }
        }

        if (playerNumber == "Player3")
        {
            if (isOwned)
            {
                StarterController.instance.InstantThirdGreen();
                playerCount++;
            } else
            {
                StarterController.instance.InstantThirdBlack();
            }
        }

        if (playerNumber == "Player4")
        {
            if (isOwned)
            {
                StarterController.instance.InstantForthGreen();
                playerCount++;
            } else
            {
                StarterController.instance.InstantForthBlack();
            }
        }
    }
}

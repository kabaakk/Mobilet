using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.UI;
using System.Linq;

public class StarterController : NetworkBehaviour
{
    public Manager manager;
    public GameObject choosePlayer, gameManager;
    public GameObject[] objects;
    public Transform canvas;
    public static StarterController instance;

    public void chooseScene()
    {
        GameObject _choosePlayer = Instantiate(choosePlayer);
        _choosePlayer.transform.SetParent(canvas, true);
        _choosePlayer.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        _choosePlayer.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        _choosePlayer.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, 0, 0);
        _choosePlayer.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Right, 0, 0);
        _choosePlayer.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, 0, 0);
        _choosePlayer.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom, 0, 0);
        _choosePlayer.GetComponent<RectTransform>().anchorMin = new Vector2(0, 0);
        _choosePlayer.GetComponent<RectTransform>().anchorMax = new Vector2(1, 1);
        _choosePlayer.SetActive(true);
        if (manager.playerCount == 4)
        {
            _choosePlayer.SetActive(false);
            gamemanagerScene();
        }
    }

    public void gamemanagerScene()
    {
        GameObject _gameManager = Instantiate(gameManager);
        _gameManager.transform.SetParent(canvas, true);
        _gameManager.transform.localPosition = new Vector3(0, 0, 0);
        _gameManager.transform.localScale = new Vector3(1, 1, 1);
        _gameManager.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
        _gameManager.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
        _gameManager.SetActive(true);
    }

    private void Awake()
    {
        instance = this;
    }
    public void Player1()
    {
        NetworkIdentity identity = NetworkClient.connection.identity;
        manager = identity.GetComponent<Manager>();
        manager.CmdActivePlayers("Player1");
    }

    public void Player2() 
    {
        NetworkIdentity identity = NetworkClient.connection.identity;
        manager = identity.GetComponent<Manager>();
        manager.CmdActivePlayers("Player2");
    }

    public void Player3()
    {
        NetworkIdentity identity = NetworkClient.connection.identity;
        manager = identity.GetComponent<Manager>();
        manager.CmdActivePlayers("Player3");
    }

    public void Player4()
    {
        NetworkIdentity identity = NetworkClient.connection.identity;
        manager = identity.GetComponent<Manager>();
        manager.CmdActivePlayers("Player4");
    }

    public void InstantFirstBlack()
    {
        GameObject _object0 = Instantiate(objects[0]);
        _object0.transform.SetParent(canvas, true);
        _object0.GetComponent<RectTransform>().localScale = new Vector3(0.22f, 0.14f, 1);
        _object0.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        _object0.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, -113.2f, 0);
        _object0.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Right, 113.2f, 0);
        _object0.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, -36, 0);
        _object0.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom, 36, 0);
        _object0.GetComponent<RectTransform>().anchorMin = new Vector3(0, 0);
        _object0.GetComponent<RectTransform>().anchorMax = new Vector3(1, 1);
        _object0.SetActive(true);
    }

    public void InstantFirstGreen()
    {
        GameObject _object1 = Instantiate(objects[1]);
        _object1.transform.SetParent(canvas, true);
        _object1.GetComponent<RectTransform>().localScale = new Vector3(0.22f, 0.14f, 1);
        _object1.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        _object1.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, -113.2f, 0);
        _object1.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Right, 113.2f, 0);
        _object1.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, -36, 0);
        _object1.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom, 36, 0);
        _object1.GetComponent<RectTransform>().anchorMin = new Vector3(0, 0);
        _object1.GetComponent<RectTransform>().anchorMax = new Vector3(1, 1);
        _object1.SetActive(true);
    }

    public void InstantSecondBlack()
    {
        GameObject _object2 = Instantiate(objects[0]);
        _object2.transform.SetParent(canvas, true);
        _object2.GetComponent<RectTransform>().localScale = new Vector3(0.22f, 0.14f, 1);
        _object2.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        _object2.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, 113.2f, 0);
        _object2.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Right, -113.2f, 0);
        _object2.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, -36, 0);
        _object2.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom, 36, 0);
        _object2.GetComponent<RectTransform>().anchorMin = new Vector3(0, 0);
        _object2.GetComponent<RectTransform>().anchorMax = new Vector3(1, 1);
        _object2.SetActive(true);
    }

    public void InstantSecondGreen()
    {
        GameObject _object3 = Instantiate(objects[1]);
        _object3.transform.SetParent(canvas, true);
        _object3.GetComponent<RectTransform>().localScale = new Vector3(0.22f, 0.14f, 1);
        _object3.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        _object3.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, 113.2f, 0);
        _object3.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Right, -113.2f, 0);
        _object3.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, -36, 0);
        _object3.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom, 36, 0);
        _object3.GetComponent<RectTransform>().anchorMin = new Vector3(0, 0);
        _object3.GetComponent<RectTransform>().anchorMax = new Vector3(1, 1);
        _object3.SetActive(true);
    }

    public void InstantThirdBlack()
    {
        GameObject _object4 = Instantiate(objects[0]);
        _object4.transform.SetParent(canvas, true);
        _object4.GetComponent<RectTransform>().localScale = new Vector3(0.22f, 0.14f, 1);
        _object4.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        _object4.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, -113.2f, 0);
        _object4.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Right, 113.2f, 0);
        _object4.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, 82, 0);
        _object4.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom, -82, 0);
        _object4.GetComponent<RectTransform>().anchorMin = new Vector3(0, 0);
        _object4.GetComponent<RectTransform>().anchorMax = new Vector3(1, 1);
        _object4.SetActive(true);
    }

    public void InstantThirdGreen()
    {
        GameObject _object5 = Instantiate(objects[1]);
        _object5.transform.SetParent(canvas, true);
        _object5.GetComponent<RectTransform>().localScale = new Vector3(0.22f, 0.14f, 1);
        _object5.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        _object5.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, -113.2f, 0);
        _object5.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Right, 113.2f, 0);
        _object5.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, 82, 0);
        _object5.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom, -82, 0);
        _object5.GetComponent<RectTransform>().anchorMin = new Vector3(0, 0);
        _object5.GetComponent<RectTransform>().anchorMax = new Vector3(1, 1);
        _object5.SetActive(true);
    }

    public void InstantForthBlack()
    {
        GameObject _object6 = Instantiate(objects[0]);
        _object6.transform.SetParent(canvas, true);
        _object6.GetComponent<RectTransform>().localScale = new Vector3(0.22f, 0.14f, 1);
        _object6.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        _object6.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, 137, 0);
        _object6.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Right, -137, 0);
        _object6.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, 87, 0);
        _object6.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom, -87, 0);
        _object6.GetComponent<RectTransform>().anchorMin = new Vector3(0, 0);
        _object6.GetComponent<RectTransform>().anchorMax = new Vector3(1, 1);
        _object6.SetActive(true);
    }

    public void InstantForthGreen()
    {
        GameObject _object7 = Instantiate(objects[1]);
        _object7.transform.SetParent(canvas, true);
        _object7.GetComponent<RectTransform>().localScale = new Vector3(0.22f, 0.14f, 1);
        _object7.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        _object7.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, 137, 0);
        _object7.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Right, -137, 0);
        _object7.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, 87, 0);
        _object7.GetComponent<RectTransform>().SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom, -87, 0);
        _object7.GetComponent<RectTransform>().anchorMin = new Vector3(0, 0);
        _object7.GetComponent<RectTransform>().anchorMax = new Vector3(1, 1);
        _object7.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerBlackjack : MonoBehaviour
{
    public GameObject cards, boxCard;
    public Transform tf_boxCard;
    public Transform[] tf_Player;
    public List<GameObject> listCard = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        boxCard.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstanceCard()
    {
        for (int i = 0; i < SpriteBlackjack.instance.sp_Cards.Length; i++)
        {
            GameObject _card = Instantiate(cards, tf_boxCard.position, Quaternion.identity);
            _card.transform.SetParent(tf_boxCard, true);
            _card.GetComponent<UiBlackjack>().card.sprite = SpriteBlackjack.instance.sp_Cards[i];
            listCard.Add(_card);
        }
    }

    IEnumerator SplitCards()
    {
        for (int i = 0; i < 2; i++)
        {
            yield return new WaitForSeconds(0.5f);
        }
    }
}

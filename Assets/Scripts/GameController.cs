using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject cards, boxCard;
    public Transform tf_boxcard;
    public Transform[] tf_Player;
    public List<GameObject> listCard = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        boxCard.SetActive(true);
        InstanceCard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void InstanceCard()
    {
        for (int i = 0; i < SpriteGame.instance.sp_Cards.Length; i++)
        {
            GameObject _card = Instantiate(cards, tf_boxcard.position, Quaternion.identity);
            _card.transform.SetParent(tf_boxcard, true);
            _card.GetComponent<UiCards>().card.sprite = SpriteGame.instance.sp_Cards[i];
            listCard.Add(_card);
        }

        StartCoroutine(SplitCards());
    }

    IEnumerator SplitCards()
    {
        for (int i = 0; i < 4; i++)
        {
            yield return new WaitForSeconds(0.2f);
            int rdPlayer = Random.Range(0, listCard.Count);

            listCard[rdPlayer].transform.SetParent(tf_Player[i], true);
            iTween.MoveTo(listCard[rdPlayer], 
                iTween.Hash("position", tf_Player[i].position, "easeType", "Linear", "loopType", "none", "time", 0.4f));

            iTween.RotateBy(listCard[rdPlayer], 
                iTween.Hash("x", 0.5f, "easeType", "Linear", "loopType", "none", "time", 0.4f));
            yield return new WaitForSeconds(0.15f);
            //listCard[rdPlayer].GetComponent<UiCards>().back_card.SetActive(false);
            listCard.RemoveAt(rdPlayer);
        }

        yield return new WaitForSeconds(0.5f);
        boxCard.SetActive(false);


    }
}

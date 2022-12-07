using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindCards : MonoBehaviour
{
    public GameObject[] Cards;
    GameObject card;
    public Transform findCard;
    public GameObject findArrow;
    // Start is called before the first frame update
    void Start()
    {
        findArrow.SetActive(false);
        StartCoroutine(CardFinds());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CardFinds()
    {
        yield return new WaitForSeconds(2f);
        int rand = Random.Range(0, Cards.Length);
        findArrow.SetActive(true);

        if (rand == 0)
        {
            card = Instantiate(Cards[1], transform.position, Quaternion.identity);
            card.transform.localScale = new Vector3(0.022f, 0.022f, 0.022f);
            card.transform.SetParent(findCard, true);
            Transform[] allchildren = this.transform.GetComponentsInChildren<Transform>();
            for (int i = 0; i < allchildren.Length; i++)
            {
                GameObject gameObject = allchildren[4].gameObject;
                gameObject.SetActive(false);
            }
        } else if (rand == 1)
        {
            card =Instantiate(Cards[2], transform.position, Quaternion.identity);
            card.transform.localScale = new Vector3(0.022f, 0.022f, 0.022f);
            card.transform.SetParent(findCard, true);
            Transform[] allchildren = this.transform.GetComponentsInChildren<Transform>();
            for (int i = 0; i < allchildren.Length; i++)
            {
                GameObject gameObject = allchildren[4].gameObject;
                gameObject.SetActive(false);
            }

        } else if (rand == 2)
        {
            card = Instantiate(Cards[3], transform.position, Quaternion.identity);
            card.transform.localScale = new Vector3(0.022f, 0.022f, 0.022f);
            card.transform.SetParent(findCard, true);
            Transform[] allchildren = this.transform.GetComponentsInChildren<Transform>();
            for (int i = 0; i < allchildren.Length; i++)
            {
                GameObject gameObject = allchildren[4].gameObject;
                gameObject.SetActive(false);
            }
        } else
        {
            card = Instantiate(Cards[0], transform.position, Quaternion.identity);
            card.transform.localScale = new Vector3(0.022f, 0.022f, 0.022f);
            card.transform.SetParent(findCard, true);
            Transform[] allchildren = this.transform.GetComponentsInChildren<Transform>();
            for (int i = 0; i < allchildren.Length; i++)
            {
                GameObject gameObject = allchildren[4].gameObject;
                gameObject.SetActive(false);
            }
        }
    }
}

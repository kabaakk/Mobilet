using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetAI : MonoBehaviour
{
    public int rd, rd1, rd2, rdTime;
    bool firstCardPosition = false, secondCardPosition = false, thirdCardPosition = false, forthCardPosition = false;
    public bool secondAIBet = false, thirdAIBet = false, forthAIBet = false;
    TurnController turnController;

    // Start is called before the first frame update
    void Start()
    {
        turnController = GetComponent<TurnController>();
        rd = Random.Range(0, 3);
        rd1 = Random.Range(0, 3);
        rd2 = Random.Range(0, 3);
        rdTime = Random.Range(0, 5);
    }

    public void second()
    {
        StartCoroutine(secondBet());
    }

    public void third()
    {
        StartCoroutine(thirdBet());
    }

    public void forth()
    {
        StartCoroutine(forthBet());
    }

    IEnumerator secondBet()
    {
        yield return new WaitForSeconds(rdTime);
        if (rd == 0)
        {
            if (turnController.firstCardClicked)
            {
                firstCardPosition = true;
            } else if (firstCardPosition)
            {
                firstCardPosition = true;

            }
            else
            {
                firstCardPosition = true;
            }
        }

        if (rd == 1)
        {
            if (turnController.secondCardClicked)
            {
                secondCardPosition = true;
            } else if (secondCardPosition)
            {
                secondCardPosition = true;
            }
            else
            {
                secondCardPosition = true;
            }
        }

        if (rd == 2)
        {
            if (turnController.thirdCardClicked)
            {
                
                thirdCardPosition = true;
            } else if (thirdCardPosition)
            {
                
                thirdCardPosition = true;
            }
            else
            {
                
                thirdCardPosition = true;
            }
        }

        if (rd == 3)
        {
            if (turnController.forthCardClicked)
            {
                
                forthCardPosition = true;
            } else if (forthCardPosition)
            {
                
                forthCardPosition = true;
            } 
            else
            {
                
                forthCardPosition = true;
            }
        }
    }

    IEnumerator thirdBet()
    {
        yield return new WaitForSeconds(rdTime);

        if (rd1 == 0)
        {
            if (turnController.firstCardClicked)
            {
                
                firstCardPosition = true;
            }
            else if (firstCardPosition)
            {
                
                firstCardPosition = true;
            } else
            {
                
                firstCardPosition = true;
            }
        }

        if (rd1 == 1)
        {
            if (turnController.secondCardClicked)
            {
                
                secondCardPosition = true;
            } else  if (secondCardPosition)
            {
                
                secondCardPosition = true;
            }
            else
            {
                
                secondCardPosition = true;
            }
        }

        if (rd1 == 2)
        {
            if (turnController.thirdCardClicked)
            {
                
                thirdCardPosition = true;
            } else  if (thirdCardPosition)
            {
                
                thirdCardPosition = true;
            }
            else
            {
                
                thirdCardPosition = true;
            }
        }

        if (rd1 == 3)
        {
            if (turnController.forthCardClicked)
            {
                
                forthCardPosition = true;
            } else if (forthCardPosition)
            {
                
                forthCardPosition = true;
            }
            else
            {
                
                forthCardPosition = true;
            }
        }
    }

    IEnumerator forthBet()
    {
        yield return new WaitForSeconds(rdTime);

        if (rd2 == 0)
        {
            if (turnController.firstCardClicked)
            {
               
                firstCardPosition = true;
            } else if (firstCardPosition)
            {
               
                firstCardPosition = true;

            }
            else
            {
                
                firstCardPosition = true;
            }
        }

        if (rd2 == 1)
        {
            if (turnController.secondCardClicked)
            {
                secondCardPosition = true;
            } else if (secondCardPosition)
            {
               
                secondCardPosition = true;
            }
            else
            {
               
                secondCardPosition = true;
            }
        }

        if (rd2 == 2)
        {
            if (turnController.thirdCardClicked)
            {
               
                thirdCardPosition = true;
            } else if (thirdCardPosition)
            {
               
                thirdCardPosition = true;
            }
            else
            {
               
                thirdCardPosition = true;
            }
        }

        if (rd2 == 3)
        {
            if (turnController.forthCardClicked)
            {
               
                forthCardPosition = true;
            } else if (forthCardPosition)
            {
               
                forthCardPosition = true;
            }
            else
            {
                
                forthCardPosition = true;
            }
        }
    }
}

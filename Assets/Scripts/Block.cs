using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    Level level;
    GameStatus gameStatus;
    public GameObject particleVFX;
    public int maxHits = 3;
    int currentHits = 0;
    public Sprite[] allSprites;
    private void Start()
    {
        level = FindObjectOfType<Level>();
        if (CompareTag("Breakable"))
        {
            level.countBreakableBlocks();
        }
        gameStatus = FindObjectOfType<GameStatus>(); 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(CompareTag("Unbreakable"))
        {
            //Do nOthing
        }
        else
        {
            currentHits++;
            if(currentHits == maxHits)
            {
                Destroy(gameObject, 0.2f);
                TriggerSFX();
                TriggerVFX();
            }
            else if(maxHits - currentHits == 1)
            {
                GetComponent<SpriteRenderer>().sprite = allSprites[1];
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = allSprites[0];

            }

        }
    }

    private void TriggerSFX()
    {
        level.breakBlock();
        gameStatus.IncScore();
    }

    public void TriggerVFX()
    {
        GameObject sparkles =  Instantiate(particleVFX,transform.position,transform.rotation);
        Destroy(sparkles,2f);

    }
}

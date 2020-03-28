using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public int breakableBlocks;




    public void countBreakableBlocks()
    {
        breakableBlocks++;
    }
    public void breakBlock()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            //Win screen
            SceneLoader sceneLoader = FindObjectOfType<SceneLoader>();
            sceneLoader.NextScene();
        }
    }



    
}

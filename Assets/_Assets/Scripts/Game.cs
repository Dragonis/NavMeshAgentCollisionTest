using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    void Start()
    {
        GameObject generatedPig = GameObject.Find("Generated/Pig");
        GameObject generatedBlocks = GameObject.Find("Generated/Blocks");

        GameObject pig = Resources.Load<GameObject>("Prefabs/Pig/Pig");
        pig.transform.position = new Vector3(4f, 0f, 4f);
        pig.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        Instantiate(pig, generatedPig.transform);

        GameObject block = Resources.Load<GameObject>("Prefabs/WoodBlock/WoodenBlock");
        for(int i=0; i<5; i++)
        {
            block.transform.localScale = new Vector3(2f, 2f, 2f);
            block.transform.position = new Vector3(i*2,0f,0f);
            Instantiate(block, generatedBlocks.transform);
        }
    }

}

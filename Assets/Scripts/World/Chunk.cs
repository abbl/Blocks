using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour {
    private static GameProperties gameProperties;
    private ArrayList blocks;
    public GameObject chunkBlock;

    private void Awake()
    {
        gameProperties = GameObject.Find("GameProperties").GetComponent<GameProperties>();
    }

    private void Start()
    {
        GenerateChunk();
    }

    public void GenerateChunk()
    {
        GameObject sampleBlock = Instantiate(chunkBlock, gameObject.transform);
        Vector3 blockSize = Vector3.Scale(transform.localScale, sampleBlock.GetComponent<BoxCollider>().bounds.size);
        Debug.Log("W:" + blockSize.x + "H:" + blockSize.y + "D:" + blockSize.z);

        for(int height = 0; height < gameProperties.chunkSize.height; height++)
        {
            for(int width = 0; width < gameProperties.chunkSize.width; width++)
            {
                for(int depth = 0; depth < gameProperties.chunkSize.depth; depth++)
                {
                    Instantiate(sampleBlock, CalculateBlockPosition(height, width, depth, blockSize), new Quaternion(), gameObject.transform);
                }
            }
        }
        Destroy(sampleBlock);
    }

    private Vector3 CalculateBlockPosition(int height, int width, int depth, Vector3 blockSize)
    {
        return new Vector3(height * blockSize.x, width * blockSize.y, depth * blockSize.z);
    }
}

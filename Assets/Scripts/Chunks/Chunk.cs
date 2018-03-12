using UnityEngine;
using System.Collections;

public class Chunk : MonoBehaviour {
    private ArrayList blocksArrayList;
    private GameObject blockExample;
    private bool isChunkGenerated;
    public int width;
    public int height;
    public int depth;


	// Use this for initialization
	void Start () {
        blocksArrayList = new ArrayList();
        isChunkGenerated = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!isChunkGenerated && blockExample != null)
        {
            GenerateChunk();
            isChunkGenerated = true;
        }
        if(blockExample == null)
        {
            blockExample = Resources.Load("Prefabs/GrassBlock") as GameObject;
        }
	}

    private void GenerateChunk()
    {
        for(int y = 0; y < height; y++)
        {
            for(int z = 0; z < depth; z++)
            {
                for (int x = 0; x < width; x++)
                {
                    CreateBlock(x, -y, z);
                }
            }
        }
    }

    private void CreateBlock(int x, int y, int z)
    {

    }
}

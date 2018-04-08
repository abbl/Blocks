using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProperties : MonoBehaviour{
    [System.Serializable]
    public struct ChunkSize
    {
        [SerializeField]
        public int width;
        [SerializeField]
        public int height;
        [SerializeField]
        public int depth;
    }

    public ChunkSize chunkSize;
}

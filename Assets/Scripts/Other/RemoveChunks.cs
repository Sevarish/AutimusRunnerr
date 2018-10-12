using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveChunks : MonoBehaviour { 
    private void OnCollisionEnter(Collision other)
    {
            Destroy(other.gameObject);
    }
}

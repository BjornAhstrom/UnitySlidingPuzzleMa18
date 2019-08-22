using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{
    public TileManager tileManager;
    //public bool empty = false;

    private void OnMouseDown()
    {
        //Debug.Log("Touch " + gameObject.name);

         tileManager.TilePressed(gameObject, false);
    }
}

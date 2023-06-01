using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GridDebugObject : MonoBehaviour
{
    [SerializeField] TextMeshPro gridtext;
   private GridObject gridObject;
    public float xcheck;
    public float zcheck;
    // Start is called before the first frame update
    void Start()
    {
       /* Debug.Log(returngridobject());*/
    }
    void Update()
    {
        /*if (gridObject == null)
        {
            Debug.Log("xcheck " + xcheck + " ycheck " + zcheck);
        }*/
        /*gridtext.text = gridObject.ToString();*/
    }
    public void SetGridObject(GridObject gridObject)
    {
        this.gridObject = gridObject;
        xcheck = gridObject.gridPosition.x;
        zcheck = gridObject.gridPosition.z;
    }
    public GridObject returngridobject()
    {
      
        return gridObject;
    }

    // Update is called once per frame
   

}

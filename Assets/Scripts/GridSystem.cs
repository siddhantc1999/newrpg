using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem
{
    public int width;
    public int height;
    public int cellSize;
    public GridObject[,] gridObjects;
    public GridSystem(int width, int height, int cellSize)
    {
        this.width = width;
        this.height = height;
        this.cellSize = cellSize;
        gridObjects = new GridObject[width, height];
      
        for (int x=0;x<width;x++)
        {
            for(int z=0;z<height;z++)
            {
                GridPosition gridPosition = new GridPosition(x,z);
                GridObject gridObject = new GridObject(this, gridPosition);
                gridObjects[x, z] = gridObject;
                
            }
        }
    }
    public Vector3 GetWorldpos(GridPosition gridPosition)
    {
        return new Vector3(gridPosition.x, 0, gridPosition.z) *cellSize;
    }
    public GridPosition GetGridPosition(Vector3 worldpos)
    {
       //1.5f is taken as 2f
        return new GridPosition(
            Mathf.RoundToInt(worldpos.x / cellSize), Mathf.RoundToInt(worldpos.z / cellSize));
    }
    public void instantiatingtextobjects(Transform debugprefab)
    {
        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < height; z++)
            {
                GridPosition gridPosition = new GridPosition(x,z);
                GameObject.Instantiate(debugprefab, new Vector3(GetWorldpos(gridPosition).x,0.01f, GetWorldpos(gridPosition).z), debugprefab.transform.rotation);
                GridDebugObject griddebugobject = debugprefab.GetComponent<GridDebugObject>();
                griddebugobject.SetGridObject(GetGridObject(gridPosition));
               
            }
        }
    }
    public GridObject GetGridObject(GridPosition gridPosition)
    {
        return gridObjects[gridPosition.x,gridPosition.z];
    }


}

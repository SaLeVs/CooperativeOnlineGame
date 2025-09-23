using System;
using UnityEngine;

public class Grid
{
    private int _width;
    private int _length;
    private float _cellSize;
    private int [,] _gridArray;
    
    public Grid(int width, int length, int cellSize, GameObject cellPrefab)
    {
        _width = width;
        _length = length;
        _cellSize = cellSize;
        
        _gridArray = new int[width, length];
        
        for(int x = 0; x < _gridArray.GetLength(0); x++)
        {
            for(int z = 0; z < _gridArray.GetLength(1); z++)
            {
                // Just for Debugging
                GameObject.Instantiate(cellPrefab, GetWorldPosition(x, z), Quaternion.identity);
            }
        }
    }
   
    private Vector3 GetWorldPosition(int x, int z)
    {
        return new Vector3(x, 0, z) * _cellSize;
    }
    
    private void GetXY(Vector3 worldPosition, out int x, out int z)
    {
        x = Mathf.FloorToInt(worldPosition.x / _cellSize);
        z = Mathf.FloorToInt(worldPosition.z / _cellSize);
    }
    
    public void SetValue(int x, int z, int value)
    {
        if (x >= 0 && z >= 0 && x < _width && z < _length)
        {
            _gridArray[x, z] = value;
        }
    }
    

    public void SetValue(Vector3 worldPosition, int value)
    {
        int x;
        int z;
        
        GetXY(worldPosition, out x, out z);
        SetValue(x, z, value);
    }

    
}

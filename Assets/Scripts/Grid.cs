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
}

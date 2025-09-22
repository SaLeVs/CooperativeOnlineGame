using UnityEngine;

public class Grid
{
    private int _width;
    private int _height;
    private float _cellSize;
    private int [,] _gridArray;
    
    public Grid(int width, int height, int cellSize, GameObject cellPrefab)
    {
        _width = width;
        _height = height;
        _cellSize = cellSize;
        
        _gridArray = new int[width, height];
        
        for(int x = 0; x < _gridArray.GetLength(0); x++)
        {
            for(int y = 0; y < _gridArray.GetLength(1); y++)
            {
                GameObject.Instantiate(cellPrefab, GetWorldPosition(x, y), Quaternion.identity);
            }
        }
    }
   
    private Vector3 GetWorldPosition(int x, int z)
    {
        return new Vector3(x, 0, z) * _cellSize;
    }
}

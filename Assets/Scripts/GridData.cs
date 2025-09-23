using System;
using UnityEngine;

public class GridData
{
    public event EventHandler<OnGridValueChangedEventArgs> OnGridValueChanged;
    
    public class OnGridValueChangedEventArgs : EventArgs
    {
        public int _x;
        public int _z;
    }
    
    private int _width;
    private int _length;
    private float _cellSize;
    private Vector3 _originPosition;
    private int [,] _gridArray;

    
    public GridData(int width, int length, int cellSize, Vector3 originPosition)
    {
        _width = width;
        _length = length;
        _cellSize = cellSize;
        _originPosition = originPosition;
        _gridArray = new int[width, length];
    }
   
    public Vector3 GetWorldPosition(int x, int z)
    {
        return new Vector3(x, 0, z) * _cellSize + _originPosition;
    }
    
    public void GetXY(Vector3 worldPosition, out int x, out int z)
    {
        x = Mathf.FloorToInt((worldPosition - _originPosition).x / _cellSize);
        z = Mathf.FloorToInt((worldPosition - _originPosition).z / _cellSize);
    }
    
    public void SetValue(int x, int z, int value)
    {
        if (x >= 0 && z >= 0 && x < _width && z < _length)
        {
            _gridArray[x, z] = value;
        }
        
        OnGridValueChanged?.Invoke(this, new OnGridValueChangedEventArgs { _x = x, _z = z});
    }
    

    public void SetValue(Vector3 worldPosition, int value)
    {
        int x;
        int z;
        
        GetXY(worldPosition, out x, out z);
        SetValue(x, z, value);
    }

    public int GetValue(int x, int z)
    {
        if (x >= 0 && z >= 0 && x < _width && z < _length)
        {
            return _gridArray[x, z];
        }
        else
        {
            return 0;
        }
    }

    public int GetValue(Vector3 worldPosition)
    {
        int x, z;
        GetXY(worldPosition, out x, out z);
        return GetValue(x, z);
    }
    
}

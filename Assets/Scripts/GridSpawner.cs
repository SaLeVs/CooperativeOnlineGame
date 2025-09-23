using UnityEngine;

public class GridSpawner : MonoBehaviour
{
    [SerializeField] private GameObject cellPrefab;
    [SerializeField] private int width;
    [SerializeField] private int length;
    [SerializeField] private int cellSize;
    [SerializeField] private Vector3 originPoint;
    
    private GridData _gridData;

    private void Start()
    {
        _gridData = new GridData(width, length, cellSize, transform.position);
        
        
        for(int x = 0; x < width; x++)
        {
            for(int z = 0; z < length; z++)
            {
                // Just for Debugging
                GameObject.Instantiate(cellPrefab, _gridData.GetWorldPosition(x, z), Quaternion.identity);
            }
        }
    }
    
}

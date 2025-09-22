using UnityEngine;

public class TestGrid : MonoBehaviour
{
    [SerializeField] private GameObject cellPrefab;
    [SerializeField] private int width;
    [SerializeField] private int height;
    [SerializeField] private int cellSize;
    

    void Start()
    {
        Grid grid = new Grid(width, height, cellSize, cellPrefab);
    }
    
}

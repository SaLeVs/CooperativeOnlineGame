using UnityEngine;

public class TestGridData : MonoBehaviour
{
    [SerializeField] private GameObject cellPrefab;
    [SerializeField] private int width;
    [SerializeField] private int height;
    [SerializeField] private int cellSize;
    [SerializeField] private Vector3 originPoint;
    

    void Start()
    {
        //GridData gridData = new GridData(width, height, cellSize, originPoint, cellPrefab);
    }
    
}

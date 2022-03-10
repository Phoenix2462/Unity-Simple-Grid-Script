using UnityEngine;

public class GridCreator : MonoBehaviour
{
    [SerializeField] private GameObject gridPrefab;
    [SerializeField] private int width;
    [SerializeField] private int height;
    private void Start()
    {
        for (int i = 0; i < width; i++)
        {
            for (int heightI = 0; heightI < height; heightI++)
            {
                GameObject PlacedGrid = Instantiate(gridPrefab, new Vector2(i, heightI), Quaternion.identity);
                PlacedGrid.name = "x: " + i.ToString() + " y: " + heightI.ToString();
            }
        }
    }
}

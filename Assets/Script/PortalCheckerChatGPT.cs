using Player;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PortalChecker : MonoBehaviour
{
    private Teleport tele;
    public Tilemap wallTilemap;   // Assign your wall tilemap in Inspector
    public Tilemap floorTilemap;  // Assign your floor tilemap in Inspector

    private void Start()
    {
        tele = FindFirstObjectByType<Teleport>();
    }
    public void CheckPortal(Vector3 portalWorldPosition)
    {
        Vector3Int cell = wallTilemap.WorldToCell(portalWorldPosition);

        bool isWall = wallTilemap.HasTile(cell);
        bool isFloor = floorTilemap.HasTile(cell);

        if (isWall)
        {
           // Debug.Log("Portal is in a wall!");
            tele.DestroyPortals();
        }
        else if (isFloor)
        {
           // Debug.Log("Portal is on a floor.");
            tele.DestroyPortals();
        }
        else
        {
          //  Debug.Log("Portal is in empty space.");
        }
    }
}
using UnityEngine;

public class CustomCursor : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update () {
        Vector3 position = Input.mousePosition;
        transform.position = new Vector3(
            position.x + 12f, position.y - 12f
        );
    }

}

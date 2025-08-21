using UnityEngine;

public class SimpleRotateToggle : MonoBehaviour
{
    public float Degrees = 100f;
    private bool mRotationState = true;
    void Update () {
        if (mRotationState) {
            transform.Rotate (0f, Degrees * Time.deltaTime, 0f);
        }
    }

    
    void OnMouseDown () {
        mRotationState = !mRotationState;
        print("State = " + mRotationState);
    }

}

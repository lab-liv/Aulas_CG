using UnityEngine;

public class MousePick : MonoBehaviour
{
    private int mPicks = 0;

    void OnMouseDown()
    {
        print("Este objeto foi escolhido " + mPicks + " vezes.");
        ++mPicks;
    }
}

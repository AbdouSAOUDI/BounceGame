using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private bool p = false;
    public void Pause()
    {
        if (p)
        {
            Time.timeScale = 0f;
            p = true;
        }
        else
        {
            Time.timeScale = 1f;
            p = false;
        }
    }
}
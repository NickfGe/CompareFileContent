using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Line() { SceneManager.LoadScene(1); }
    public void File() { SceneManager.LoadScene(2); }
    public void Quit() { Application.Quit(); }
}

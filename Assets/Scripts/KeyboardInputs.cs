using UnityEngine;
using UnityEngine.SceneManagement;
public class KeyboardInputs : MonoBehaviour
{
    public GameObject left_danceer;
    public GameObject right_danceer;
    public GameObject front_danceer;
    public GameObject music;
    public GameObject glow_cube_down;
    public GameObject glow_cube_up;
    public GameObject glow_cube_ball;
    private bool isDancing = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("main");
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            isDancing = true;
            left_danceer.SetActive(true);
            right_danceer.SetActive(true);
            front_danceer.SetActive(true);
            music.SetActive(true);
            glow_cube_down.SetActive(true);
            glow_cube_up.SetActive(true);
            glow_cube_ball.SetActive(true);
        }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}

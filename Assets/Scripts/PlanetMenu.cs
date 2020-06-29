using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class PlanetMenu : MonoBehaviour
{

    [SerializeField]
    private GameObject background;
    [SerializeField]
    private GameObject ball;
    [SerializeField]
    private Text ballhit;
    [SerializeField]
    private GameObject panel;
    private void Start()
    {
        if (!Directory.Exists("Save"))
        {
            Directory.CreateDirectory("Save");
        }
        if (!File.Exists("Save/save.txt"))
        {
            File.Create("Save/save.txt");
        }
        Time.timeScale = 0;
    }

    public void ChangePlanet(PlanetData planetData)
    {
        Time.timeScale = 1;
        background.GetComponent<SpriteRenderer>().sprite = planetData.Background;
        ball.GetComponent<Rigidbody2D>().gravityScale = planetData.Gravity;
        panel.SetActive(false);
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.Backspace))
        {
            Time.timeScale = 0;
            panel.SetActive(true);
            ballhit.text = "BallHit: " + BallController.ballHit.ToString();
        }
    }
    void OnApplicationQuit()
    {
        if (File.Exists("Save/save.txt"))
        {
            File.AppendAllText("Save/save.txt", "\nBallHits: " + BallController.ballHit.ToString());
        }
    }
}

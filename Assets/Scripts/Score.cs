using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Text scoreText = null;
    public int score = 0;

    void Start()
    {
        scoreText.text = score.ToString();
    }

    void OnCollisionEnter(UnityEngine.Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacle")
        {
            score++;
            scoreText.text = score.ToString();
        }
    }
}

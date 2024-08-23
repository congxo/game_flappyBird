
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreText;
    int score = 0;
    string defaultText;
    void Start()
    {
        if (scoreText != null)
        {
            defaultText = scoreText.text;
        }
        else
        {
            Debug.LogError("scoreText is not assigned.");
        }
    }
    // [ContextMenu("ScoreIncrease")]
    public void setScore(int hit)
    {
        if (scoreText != null)
        {
            score += hit;
            scoreText.text = defaultText + " " + score.ToString();
        }
    }
    
    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

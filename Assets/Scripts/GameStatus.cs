using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameStatus : MonoBehaviour
{
    public bool autoPlay = false;
    public int scoreWhenBlockDestroyed = 83;
    public int currentScore = 0;
    public TextMeshProUGUI text;
    [Range(1f,10f)] public float gameSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
        text.text = currentScore.ToString();

    }
    private void Awake()
    {
       int gameStatusCount= FindObjectsOfType<GameStatus>().Length;
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);

        }
        else {
            DontDestroyOnLoad(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void IncScore()
    {
        currentScore += scoreWhenBlockDestroyed;
        text.text = currentScore.ToString();
    }

    public void ResetScore()
    {
        currentScore = 0;
        text.text = currentScore.ToString();

    }
}

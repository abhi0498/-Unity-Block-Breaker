using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scorer : MonoBehaviour
{
    public Text text;
    private int score=0;
    private void Start()
    {
        text.text = score.ToString();
    }
    // Start is called before the first frame update
    public void Add()
    {
        score++;
        text.text = score.ToString();
    }
}

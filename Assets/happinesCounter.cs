using UnityEngine;
using TMPro;

public class happinesCounter : MonoBehaviour
{
    public TMP_Text happyText;
    public TMP_Text happyCount;
    public TMP_Text STOP;
    private int happines;
    private int happy;
    public GameObject[] hearts;
    public GameObject restartButton;

    void Start()
    { 
        happyText.text = "Pet: 0";
        happyCount.text = "Happiness: 0";
        restartButton.SetActive(false);
        STOP.text = "";

        InactiveHearts();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addHappiness()
    {
        if(happy < 3)
        {
            happines++;
            actualHappiness();
            happyText.text = "Pet: " + happines;
        }
        else
        {
            STOP.text = "Stop! No more! :(";
            restartButton.SetActive(true);
        }
        
    }
    public void actualHappiness()
    {
        if(happines >= 3)
        {
            happines = 0;
            happy ++;
            happyCount.text = "Happiness: " + happy;
            hearts[happy - 1].SetActive(true);
        }
    }

    public void RestartGame()
    {
        restartButton.SetActive(false);
        happines = 0;
        happy = 0;

        happyText.text = "Pet: 0";
        happyCount.text = "Happiness: 0";
        STOP.text = "";

        InactiveHearts();
    }

    private void InactiveHearts()
    {
        foreach (GameObject heart in hearts)
        {
            heart.SetActive(false);
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}

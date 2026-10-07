using UnityEngine;
using TMPro;

public class happinesCounter : MonoBehaviour
{
    public TMP_Text happyText;
    private int happines;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addHappiness()
    {
        happines++;
        happyText.text = "Happiness: " + happines;
    }
}

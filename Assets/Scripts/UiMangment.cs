using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiMangment : MonoBehaviour
{
    public GameObject congragulation;
    public GameObject Next_time;
    public TMP_Text Score;
    public TMP_Text Health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = PlayerController.score.ToString();
        Health.text = PlayerController.Health.ToString();
    }
}

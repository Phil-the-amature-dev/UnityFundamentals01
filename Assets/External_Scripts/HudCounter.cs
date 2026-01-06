using TMPro;
using UnityEngine;
using UnityFundamentals;

public class HudCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text villageCounter;
    [SerializeField] private TMP_Text ruinsCounter;
    [SerializeField] IntVariable villageGems;
    [SerializeField] IntVariable ruinsGems;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        villageCounter.text = "Gems Found in Village: " + villageGems.GetValue() + "/4";
        ruinsCounter.text = "Gems Found in Ruins: " + ruinsGems.GetValue() + "/3";
    }
}

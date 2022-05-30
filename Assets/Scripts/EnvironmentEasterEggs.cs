using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnvironmentEasterEggs : MonoBehaviour
{
    
    [SerializeField] Image[] candles;
    [SerializeField] Sprite candlesOff;
    [SerializeField] Sprite candlesOn;
    [SerializeField] Button[] blower;
    [SerializeField] Button[] lighter;
    [SerializeField] bool candleOneOff = false;
    [SerializeField]bool candleTwoOff = false;
    [SerializeField] bool candleThreeOff = false;
    [SerializeField] Image[] ingots;
    [SerializeField] Sprite blueIngot;
    [SerializeField] Sprite goldIngot;
    [SerializeField] Sprite copperIngot;
    [SerializeField] Button blueIngotButtonPress;
    [SerializeField] Button goldIngotButtonPress;
    [SerializeField] Button copperIngotButtonPress;
    
    public void CandleOneDown()
    {
        if(candleOneOff == false)
        {
            candles[0].sprite = candlesOff;
            blower[0].gameObject.SetActive(false);
            lighter[0].gameObject.SetActive(true);
            candleOneOff = true;            
        }    
    }
    public void CandleTwoDown()
    {
        if(candleTwoOff == false)
        {
            candles[1].sprite = candlesOff;
            blower[1].gameObject.SetActive(false);
            lighter[1].gameObject.SetActive(true);
            candleTwoOff = true;
        }
    }
    public void CandleThreeDown()
    {
        if(candleThreeOff == false)
        {
            candles[2].sprite = candlesOff;
            blower[2].gameObject.SetActive(false);
            lighter[2].gameObject.SetActive(true);
            candleThreeOff = true;
        }
    }

    public void CandleOneUp()
    {
        if(candleOneOff == true)
        {
            candles[0].sprite = candlesOn;
            lighter[0].gameObject.SetActive(false);
            blower[0].gameObject.SetActive(true);
            candleOneOff = false;
        }       
    }
    public void CandleTwoUp()
    {
        if(candleTwoOff == true)
        {
            candles[1].sprite = candlesOn;
            lighter[1].gameObject.SetActive(false);
            blower[1].gameObject.SetActive(true);
            candleTwoOff = false;
        }
    }
    public void CandleThreeUp()
    {
        if(candleThreeOff == true)
        {
            candles[2].sprite = candlesOn;
            lighter[2].gameObject.SetActive(false);
            blower[2].gameObject.SetActive(true);
            candleThreeOff = false;
        }
    }

    public void BlueIngotButton()
    {
        ingots[0].sprite = blueIngot;
        ingots[1].sprite = blueIngot;
        ingots[2].sprite = blueIngot;
        ingots[3].sprite = blueIngot;
        ingots[4].sprite = blueIngot;
        blueIngotButtonPress.gameObject.SetActive(false);
        goldIngotButtonPress.gameObject.SetActive(true);
    }
    public void GoldIngotButton()
    {
        ingots[0].sprite = goldIngot;
        ingots[1].sprite = goldIngot;
        ingots[2].sprite = goldIngot;
        ingots[3].sprite = goldIngot;
        ingots[4].sprite = goldIngot;
        goldIngotButtonPress.gameObject.SetActive(false);
        copperIngotButtonPress.gameObject.SetActive(true);
    }
    public void CopperIngotButton()
    {
        ingots[0].sprite = copperIngot;
        ingots[1].sprite = copperIngot;
        ingots[2].sprite = copperIngot;
        ingots[3].sprite = copperIngot;
        ingots[4].sprite = copperIngot;
        copperIngotButtonPress.gameObject.SetActive(false);
        blueIngotButtonPress.gameObject.SetActive(true);
    }
}

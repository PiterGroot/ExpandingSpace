using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    public float CurrentWallet;
    private void Start()
    {
        CurrentWallet = GetMoney();
    }
    public void AddMoney(float money){
        CurrentWallet += money;
    }
    public void BuyItem(float money)
    {
        CurrentWallet -= money;
        
    }
    public float GetMoney(){
        return PlayerPrefs.GetFloat("Wallet");
    }
    private void Update(){
        PlayerPrefs.SetFloat("Wallet", CurrentWallet);
        if (CurrentWallet < 0){
            CurrentWallet = 0;
        }
    }
}

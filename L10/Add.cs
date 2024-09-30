using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class Add : MonoBehaviour
{
    public Text priceText ;
    public AddScriptableObject priceSO ;
    public int price ;
    private void Start() {
        price = priceSO.price ;
        priceText.text = "已擁有："+priceSO.price ;
    }
    public void Onclick()
    {
        price += 30 ;
        priceText.text = "已擁有："+priceSO.price ;
    }
}

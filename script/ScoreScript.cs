using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript: MonoBehaviour
{
public Text MyscoreText;
private int ScoreNum;
void start()
{
ScoreNum = 00;
MyscoreText.text = "Score : " + ScoreNum;
} 
private void OnTriggerEnter2D(Collider2D Coin)
{
 if(Coin.tag=="MyCoin")
{
ScoreNum+=1;
Destroy(Coin.gameObject);
MyscoreText.text = "Score"+ ScoreNum;
}
}
}



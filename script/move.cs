using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
  public float moveSpeed =20;
private SpriteRenderer renderer;
private Animator animator; 


void Start()
{
 renderer = GetComponent<SpriteRenderer>();
 animator =GetComponent<Animator>();
}

void Update()
{
 if(Input.GetKey(KeyCode.RightArrow))
{
   
 transform.Translate(Vector2.right * moveSpeed *Time.deltaTime);
renderer.flipX =false;
animator.SetInteger("change",2);
}
else if(Input.GetKey(KeyCode.LeftArrow))
{
 transform.Translate(Vector2.left * moveSpeed *Time.deltaTime);
renderer.flipX =true;
animator.SetInteger("change",2);
}
else if(Input.GetKey(KeyCode.UpArrow))
{
 transform.Translate(Vector2.up * moveSpeed *Time.deltaTime);
animator.SetInteger("jump",2);
}
else if(Input.GetKey(KeyCode.DownArrow))
{
 transform.Translate(Vector2.down * moveSpeed *Time.deltaTime);
animator.SetInteger("change",2);
}
else 
{
  
  animator.SetInteger("jump",1);
animator.SetInteger("change",1);
}
}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
	[Header("前進速度"),Range(1,100)]
	public float Speed = 10f;
	[Header("旋轉速度"),Range(1,100)]
	public float RSpeed = 10f;
	[Header("汽車檔次"),Range(1,5)]
	public int CarShift = 1;
	[Header("汽車品牌")]
	public string Brand ="BMW";
	[Header("是否煞車")] 
	public bool CarBrake = false;
	[Header("汽車顏色")]
    	public Color Carcolor;
	 [Header("汽車元件")] 
	public Transform car;
	//Transform 可以當作class

	





    void Start()
    {
        
    }


    void Update()
    {
	
    }

		//前進
       		public void CarMove()  
		{
			car.Translate(0f,0f, Speed*Time.deltaTime);
		}

		//後退
		public void CarBack()
		{
			car.Translate(0f, 0f, -Speed*Time.deltaTime);

		}


		//左轉
		public void CarLeft()
		{
			car.Rotate(0f, -RSpeed * Time.deltaTime,0f);
		}


		//右轉
		public void CarRight()
		{
        		car.Rotate(0f, RSpeed * Time.deltaTime, 0f);
		}
	


    }
	


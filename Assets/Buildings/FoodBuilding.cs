using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBuilding : MonoBehaviour                                                           // ласс, который прикрепл€етс€ к кормушке
																									//ѕо идее работает, но нужно сделать систему уровней из которой будут братьс€ значени€ дл€ количества ресурсов в секунду и при нажатии
{                                                                                                   //“акже надо реализовать механику нажати€
	public int CurrentLevelNumber { get; set; }                                                     //ѕеременна€, отвечающа€ за текущий уровень кормушки

	public int ResourcePerSecond { get; set; }                                                      //ѕеременна€, отвечающа€ за пассивный доход кормушки

	public int ResourcePerClick { get; set; }                                                       //ѕеременна€, отвечающа€ за активный доход кормушки

	public IncomeResource IncomeFood = new IncomeResource(1, 1);                                    //ѕеременна€ отвечающа€ за получение ресурсов

	public FoodBuilding()
	{
		ResourcePerSecond = 1;
		ResourcePerClick = 1;

		IncomeFood.OnIncomePerSecond += IncomePerSecond;
	}


	public void IncomePerSecond()                                                                   //‘ункци€, котора€ срабатывает при пассивном получении ресурсов (через каждое N количество секунд)
	{
	
		Debug.Log($" оличество еды: {IncomeFood.Resource.GetValue()}");
	}

	public void IncomePerClick()                                                                    //‘ункци€, котора€ срабатывает при активном получении ресурсов (ѕри каждом нажатии)
	{
		IncomeFood.IncomePerClick();
	}

	void OnAwake()
	{

	}

	void Update()                                                                                   //‘ункци€, срабатывающа€ каждый кадр, котора€ отвечает за работу таймера
	{
		IncomeFood.Update();
	}

}

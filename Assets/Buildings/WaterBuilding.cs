using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WaterBuilding : MonoBehaviour, IPointerClickHandler                                    // ласс, который прикрепл€етс€ к поилке
																									//ѕо идее работает, но нужно сделать систему уровней из которой будут братьс€ значени€ дл€ количества ресурсов в секунду и при нажатии
{
	public int CurrentLevelNumber { get; set; }														//ѕеременна€, отвечающа€ за текущий уровень поилки

	public int ResourcePerSecond { get; set; }														//ѕеременна€, отвечающа€ за пассивный доход поилки

	public int ResourcePerClick { get; set; }                                                       //ѕеременна€, отвечающа€ за активный доход поилки

	public IncomeResource IncomeWater = new IncomeResource(2, 1);									//ѕеременна€ отвечающа€ за получение ресурсов

	public WaterBuilding() 
	{
		ResourcePerSecond = 1;
		ResourcePerClick = 1;

		IncomeWater.OnIncomePerSecond += IncomePerSecond;
	}



	public void IncomePerSecond()                                                                   //‘ункци€, котора€ срабатывает при пассивном получении ресурсов (через каждое N количество секунд)
	{
		Debug.Log($" оличество воды: {IncomeWater.Resource.GetValue()}");
	}

	public void IncomePerClick()                                                                    //‘ункци€, котора€ срабатывает при активном получении ресурсов (ѕри каждом нажатии)
	{
		IncomeWater.IncomePerClick();
	}

	public void OnPointerClick(PointerEventData data)
	{
		IncomePerClick();
	}


	void Update()                                                                                   //‘ункци€, срабатывающа€ каждый кадр, котора€ отвечает за работу таймера
	{
		IncomeWater.Update();
	}


}

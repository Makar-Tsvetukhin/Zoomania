using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnimalMoney : MonoBehaviour
{
	public Level CurrentLevel = new Level(1, 1, 1, 1);                                              //Переменная отвечающая за уровень и количество получаемых ресурсов

	public IncomeResource IncomeMoney = new IncomeResource(1, 1);                                    //Переменная отвечающая за получение ресурсов

	public event Action OnChange;

	private void Start()
	{
		IncomeMoney.OnIncomePerSecond += IncomePerSecond;
		IncomeMoney.ResourceTimer.OnTimerEnd += Change;
	}

	public void IncomePerSecond()                                                                   //Функция, которая срабатывает при пассивном получении ресурсов (через каждое N количество секунд)
	{
		//Debug.Log($"Количество монет: {IncomeMoney.Resource.GetValue()}");
	}

	public void IncomePerClick()                                                                    //Функция, которая срабатывает при активном получении ресурсов (При каждом нажатии)
	{
		IncomeMoney.IncomePerClick();
		OnChange?.Invoke();
	}

	public void OnPointerClick(PointerEventData data)
	{
		IncomePerClick();
	}

	public void Change()                                                                            //Функция, которая срабатывает при изменении количества ресурсов или при улучшении
	{
		OnChange?.Invoke();
		UpdateData();
	}

	public void UpdateData()                                                                        //Функция, которая обновляет значения получаемых ресурсов
	{
		IncomeMoney.IncomePerSecondValue = CurrentLevel.IncomePerSecondValue;
		IncomeMoney.IncomePerClickValue = CurrentLevel.IncomePerClickValue;
	}

	void Update()                                                                                   //Функция, срабатывающая каждый кадр, которая отвечает за работу таймера
	{
		IncomeMoney.Update();
	}
}

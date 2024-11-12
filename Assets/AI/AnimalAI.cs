using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class AnimalAI : MonoBehaviour
{

	public ActionWalking AnimalWalking = new ActionWalking();

	// Время задержки между действиями панды
	private Timer DoAction = new Timer(0);

	public event Action OnTick;
	public event Action ActionEnd;

	// Флаги состояний
	public bool IsDoAction = false;

	// Стартовая функция
	public void Start()
	{
		RandomActions();

		AnimalWalking.MainCamera = Camera.main;
		AnimalWalking.CalculateScreenBounds();		// Рассчитываем границы экрана

		AnimalWalking.WalkingTime.OnTimerEnd += RandomActions;
	}

	// Функция для расчета адаптивных границ экрана

	public void RandomActions()
	{
		AnimalWalking.IsMoving = false;
		int action = /*UnityEngine.Random.Range(0, 4)*/1;

		switch (action)
		{
			case 0:
				Resting();   // Отдых
			break;

			case 1:
				IsDoAction = true;
				AnimalWalking.Walking(this.gameObject);   // Ходьба
			break;

			case 2:
				Eating();    // Еда (пока без логики потребления)
			break;

			case 3:
				Drinking();  // Питье (пока без логики потребления)
			break;
		}
	}

	public void Resting()
	{
		IsDoAction = true;
		DoAction.SetMaxTimeAndReset(UnityEngine.Random.Range(10, 31));
		Debug.Log("Панда отдыхает");
		return;
	}

	public void Eating()
	{
		IsDoAction = true;
		DoAction.SetMaxTimeAndReset(UnityEngine.Random.Range(3, 5));
		Debug.Log("Панда ест");
		return;
	}

	public void Drinking()
	{
		IsDoAction = true;
		DoAction.SetMaxTimeAndReset(UnityEngine.Random.Range(3, 5));
		Debug.Log("Панда пьет");
		return;
	}

	public void Update()
	{
		if (AnimalWalking.IsMoving)
		{
			AnimalWalking.AnimalPosition = Vector2.MoveTowards(AnimalWalking.AnimalPosition, AnimalWalking.RandomPosition, AnimalWalking.Speed);
			gameObject.transform.position = AnimalWalking.AnimalPosition;
		}
		AnimalWalking.WalkingTime.Tick(Time.deltaTime);
		OnTick?.Invoke();
	}
}
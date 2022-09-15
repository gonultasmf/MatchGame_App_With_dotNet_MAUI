﻿using MathGame.Data;

namespace MathGame;

public partial class App : Application
{
	public static GameRepository GameRepository { get; private set; }
	public App(GameRepository gameRepository)
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MainPage());

		GameRepository = gameRepository;
	}
}

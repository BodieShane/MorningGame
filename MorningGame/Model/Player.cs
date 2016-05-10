using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace MorningGame.Model
{
	public class Player
	{
		private bool active;
		private int score;
		public int Score
		{
			get { return score; }
			set {score = value; }
		}
		// Animation representing the player
		public Texture2D PlayerTexture;

		// Position of the Player relative to the upper left side of the screen
		public Vector2 Position;

		// State of the player
		public bool Active
		{
			get { return active; }
			set{ active = value; }
		}

		// Amount of hit points that player has
		public int Health;

		// Get the width of the player ship
		public int Width
		{
			get { return PlayerTexture.Width; }
		}

		// Get the height of the player ship
		public int Height
		{
			get { return PlayerTexture.Height; }
		}


		public void Initilize()
		{

		}
		public void Update()
		{

		}
		public void draw()
		{

		}
		public Player ()
		{
			
		}
	}
}


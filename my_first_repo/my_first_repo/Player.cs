using System;

namespace my_first_repo
{
	public class Player
	{
		int health;
		int mana;
		int attack;
		int defence;
		int speed;
		int luck;
		
		public Player (int h, int m, int a, int d, int s, int l)
		{
			
		}
		
		public int Health
		{
			get{return health;}
			set{health = Value;}
		}
		
		public int Mana
		{
			get{return mana;}
			set{mana = Value;}
		}
		
		public int Attack
		{
			get{return attack;}
			set{attack = Value;}
		}
		
		public int Defence
		{
			get{return defence;}
			set{defence = Value;}
		}
		
		public int Speed
		{
			get{return speed;}
			set{speed = Value;}
		}
		
		public int Luck
		{
			get{return luck;}
			set{luck = Value;}
		}
		
		
	}
}


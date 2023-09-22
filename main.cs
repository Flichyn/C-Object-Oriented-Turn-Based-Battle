using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Initiating battle !");
    
    Character hero = new Character();
    hero.name = "Nicolas";
    hero.healthPoints = 10;
    hero.strength = 3;
    hero.shield = 2;

    Console.WriteLine("Hero " + hero.name + " has " + hero.strength + " strength and " + hero.shield + " shield points.");
    
    Character enemy = new Character();
    enemy.name = "Enemy";
    enemy.healthPoints = 10;
    enemy.strength = 3;
    enemy.shield = 0;

    Console.WriteLine("Hero " + enemy.name + " has " + enemy.strength + " strength and " + enemy.shield + " shield points.");
    
    while (hero.healthPoints > 0 && enemy.healthPoints > 0) {
      Console.WriteLine(hero.name + " attacks !");
      hero.attack(enemy);
      if (enemy.isAlive() == false) {
        break;
      } 

      Console.WriteLine(enemy.name + " attacks !");
      enemy.attack(hero);
      if (enemy.isAlive() == false) {
        break;
      } 
    }
  }
}

class Character
{
  public string name;
  public int healthPoints;
  public int strength;
  public int shield;

  public bool isAlive()
  {
    bool isAlive = false;
    string message = this.name + " is dead !";
    
    if (this.healthPoints > 0) {
      isAlive = true;
      message = this.name + " is still alive with " + this.healthPoints + " HP !";
    }

    Console.WriteLine(message);
    return isAlive;
  }

  public void attack(Character enemy)
  {
    int damage = this.strength - enemy.shield;
    enemy.healthPoints -= damage;
    Console.WriteLine(enemy.name + " has lost " + damage + " health points !");
  }
}

using System;

public class task3 {
  public interface IEnemy {
    string Damage();
    string Heal();
    string BuffON();
    string BuffOFF();
  }

  public class Goblin : IEnemy {
    public string BuffOFF() {
      return "Goblin enter the field - BuffOFF is ON";
    }
    public string BuffON() {
      return "Goblin enter the field - BuffON is ON";
    }
    public string Damage() {
      return "Goblin enter the field - takes damage";
    }
    public string Heal() {
      return "Goblin enter the field - stop taking damage";
    }
  }

  public class Dragon : IEnemy {
    public string BuffOFF() {
      return "Dragon enter the field - BuffOFF is ON";
    }
    public string BuffON() {
      return "Dragon enter the field - BuffON is ON";
    }
    public string Damage() {
      return "Dragon enter the field - takes damage";
    }
    public string Heal() {
      return "Dragon enter the field - stop taking damage";
    }
  }

  public interface ICommand {
    void Execute();
    void UnDO();
  }

  public class Heal : ICommand {
    private IEnemy _reciever;
    
    public Heal(IEnemy reciever) {
      _reciever = reciever;
    }

    public void Execute() {
      Console.WriteLine(_reciever.Heal());
    }

    public void UnDO() {
      Console.WriteLine(_reciever.Damage());
    }
  }


  public class Damage : ICommand {
    private IEnemy _reciever;
    
    public Damage(IEnemy reciever) {
      _reciever = reciever;
    }

    public void Execute() {
      Console.WriteLine(_reciever.Damage());
    }

    public void UnDO() {
      Console.WriteLine(_reciever.Heal());
    }
  }

  public class Buff : ICommand {
    private IEnemy _reciever;
    
    public Buff(IEnemy reciever) {
      _reciever = reciever;
    }

    public void Execute() {
      Console.WriteLine(_reciever.BuffON());
    }

    public void UnDO() {
      Console.WriteLine(_reciever.BuffOFF());
    }
  }

  public class Field {
    private ICommand _command;
    
    public void SetCommand(ICommand command) {
      _command = command;
    }

    public void EnterField() {
      _command.Execute();
    }

    public void ExitField() {
      _command.UnDO();
    }
  }

  static void Main(string[] args) {
    Field field = new Field();

    IEnemy goblinReciever = new Goblin();
    ICommand command1 = new Heal(goblinReciever);
    field.SetCommand(command1);
    field.EnterField();
    field.ExitField();

    IEnemy dragonReciever = new Dragon();
    ICommand command2 = new Heal(dragonReciever);
    field.SetCommand(command2);
    field.EnterField();
    field.ExitField();

    ICommand command3 = new Buff(goblinReciever);
    field.SetCommand(command3);
    field.EnterField();
    field.ExitField();
  }
}

using System;
using System.Threading;

public class Vote {
  private static Vote _instance = null;
  private int _totalVotes = 0;
  private static readonly object lockObj = new object();
  private static readonly object voteLockObj = new object();

  private Vote() {}

  public static Vote Instance
  {
    get {
      if (_instance == null) {
        lock (lockObj) {
          if (_instance == null) {
            _instance = new Vote();
          }
        }
      }
      return _instance;
    }
  }

  public void RegisterVote() {
    lock (voteLockObj) {
      _totalVotes += 1;
      Console.WriteLine("Registered Vote: " + _totalVotes);
    }
  }

  public int TotalVotes {
    get {
      lock (voteLockObj) {
        return _totalVotes;
      }
    }
  }
}

public class task2 {
  public static void Main(string[] args) {
    Thread thread1 = new Thread(() => Vote.Instance.RegisterVote());
    Thread thread2 = new Thread(() => Vote.Instance.RegisterVote());
    Thread thread3 = new Thread(() => Vote.Instance.RegisterVote());

    thread1.Start();
    thread2.Start();
    thread3.Start();

    thread1.Join();
    thread2.Join();
    thread3.Join();

    Console.WriteLine("Total Votes: {0}", Vote.Instance.TotalVotes);
  }
}

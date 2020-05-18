using System;
namespace csharpLessons
{
  class RandomClass
  {
    public static int mama = 1111;
  }
  public class Person
  {
    public int age { get; set; }

    public Weapons Weapon { get; set; }

  }

  public enum Weapons
  {
    Guccigang,
    Machinegune = 0,
    yoyo
  }
}

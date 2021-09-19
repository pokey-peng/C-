using System;
namespace CSharpBook.Chapter08
{
    abstract class Animal      // ����Animal��������
    {
        public String name;
        public abstract void SayHi();
        public Animal(String name) { this.name = name; }  //���캯��
    }
    class Dog : Animal        // ������Dog
    {    //��дSayHi()
        public override void SayHi() { Console.WriteLine(this.name + " Wow Wow!"); }
        public Dog(String name) : base(name) { }   //���캯��
    }
    class Cat : Animal        // ������Cat
    {  //��дSayHi()
        public override void SayHi() { Console.WriteLine(this.name + " Mew Mew!"); }
        public Cat(String name) : base(name) { }            //���캯��
    }
    //class Horse : Animal { } //������󣬷ǳ�����Horse�̳��˳�����Animal����δʵ�ֳ��󷽷�
    abstract class Fish : Animal //����OK��������Fish�̳��˳�����Animal����δʵ�ֳ��󷽷�
    {
        public Fish(String name) : base(name) { }
    }
    class TestClass
    {
        static void Main()
        {
            //Animal animal1 = new Animal(); //������󣬳����಻��ֱ��ʵ����
            Animal[] animals = { new Dog("С��"), new Cat("С��") };
            foreach (Animal a in animals) a.SayHi();
            Console.ReadKey();
        }
    }
}

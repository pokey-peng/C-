using System;
namespace CSharpBook.Chapter09
{
    class Mammal { }
    class Dog : Mammal { }
    class Comp
    {
        public delegate Mammal HandlerMethod();//����ί��
        public delegate void HandlerMethod1(Mammal m);
        public delegate void HandlerMethod2(Dog d);
        public static Mammal FirstHandler(){Console.WriteLine("first handler"); return null;}
        public static Dog SecondHandler(){Console.WriteLine("second handler"); return null;} 
        public static void ThirdHandler(Mammal m){Console.WriteLine("third handler");}
        static void Main()
        {
            HandlerMethod handler1 = Comp.FirstHandler; //����ƥ��
            handler1();
            //Э�䣬����ֵDogĬ�Ͽ�ת��ΪMammal
            HandlerMethod handler2 = Comp.SecondHandler; handler2();
            Mammal m = new Mammal();
            HandlerMethod1 handler11 = Comp.ThirdHandler; //����ƥ��
            handler11(m);
            Dog d = new Dog();
            //��䣬����DogĬ�Ͽ�ת��ΪMammal
            HandlerMethod2 handler22 = Comp.ThirdHandler;
            handler22(d); Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    internal class Dog
    {
        //状態や属性「データ」...フィールド
        private bool hungryState;

        //振る舞い「操作」...メソッド

        //コンストラクタ（クラス名Dogと同じ名前のメソッド　Dog）
        public Dog()
        {
            hungryState = true;     //最初はおなかがすいている
        }

        public void Eat()
        {
            Console.WriteLine("ぱくぱく");
            hungryState = false;  //おなかはすいてない

        }

        //走る　→　腹ペコにする
        public void Run()
        {
            Console.WriteLine("わんわんわん");
            hungryState |= true;    //おなかがすいた

        }

        //おなかがすいている状態か調べる
        public bool IsHungry()
        {
            return hungryState;
        }


        public void Bark()
        {
            Console.WriteLine("ガウガウ");
        }

    }
}

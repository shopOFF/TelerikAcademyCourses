﻿namespace _02.DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Генерици: те могът да бъдат - класове и тн...
    // List<> - това е генерик тип, може да работи с интове с List<int>, може да работи с котки List<Cat> ,
    // може да работи със стрингове List<string> , може да работи с всичко!
    // Тоест това е генерик клас, той очаква някакъв параметър вътре в човките<>!!!
    // Генерика ни позволява, ако искаме да имаме някакъв клас, който работи с най-различни
    // параметри(като типове данни), вместо да правиме отделни класове за всеки един от тези параметри
    // пример: вместо да имаме класс ListInt и друг клас ListString със същата функционалност, с абсолютно едно и също,
    // ами генерика ни позволява това нещо да го направиме!
    // С други думи идеята им е вие да ги направите, шаблонни класове, които приемат всякакъв тип данни
    // или някакъв тип данни, който сте ограничили по някакъв начин и на базата на този тип данни, каквото зададе
    // програмиста с това да работи, тоест създаваме генерик List<T> - обикновенно вътре им се пише Т от темплейт и
    // КОГАТО НЯКОЙ ИСКА ДА ИЗПОЛЗВА ТОЗИ КЛАС, ТОЙ ТРЯБВА ДА КАЖЕ Т-ТО КАКЪВ ТИП ДАННИ Е <int>, <string>, <Cat> и тн..!!!
    // С други думи идеята е да имате различни видове параметри на този клас или темплейти. С който една и съща логика,
    // едно и съшо нещо да се случва, но да работи върху различни типове данни!!!


    // List<int> - компилатора минава и замества навсякъде в този клас с интове, с други думи, крайният резултат в крайната 
    // програма няма никакво значение за него!!!

    // пример:

    public class Generic<Т> //  но ако добавим <Т> вече можем да работим с всичко възможно без да необходимо да сменям типа данни от тук, от един на друг, а от иузър инпута директно си задаваме 
                            // типа данни тук сме ок, освен за размера, ако надвишим 16 елемента, ще гръмне!!!!!
    {
        private Т[] elements;
        private int index;      // всъщност ще пазим, на кой идекс сме пълнили от масива
        public Generic()  // конструктора на генерик листа
        {
            this.elements = new Т[16];  // подаваме си само Т-та- който ще вземат типа данни отвън!!!
            this.index = 0;
        }
        public void Add(Т elements)
        {
            this.elements[this.index] = elements;
            this.index++;
        }
        // Тоест генериците ни позволяват да си направим шаблон <T> и да го използваме, като тип данни.
        // И ТОВА ОЗНАЧАВА, ЧЕ КОГАТО НЯКОЙ СЪЗДАВА ИНСТАНЦИЯ ОТ ТОЗИ КЛАС, ТОЙ ТРЯБВА ДА КАЖЕ T-ТО КАКВО
        // ТРЯБВА ДА БЪДЕ!!! 
        // Има обаче някои ограничения, например че този елемент който е от тип Т се държи, като обект
        // Тоест, не можете да кажете примерно- var sum = elements + elements;

        // МОЖЕ ДА СИ НАПРАВИМ ГЕНЕРИК КОЙТО ДА ПРИЕМА 2 ПАРАМЕЪРА ИЛИ ПОВЕЧЕ !!!
        // public class Generic<Т, K> //  единственно като ги създаваме трябва да ги зададем и двата(Т и К) - var myList = new Generic<int, int>();
        // типа данни тук сме ок, освен за размера, ако надвишим 16 елемента, ще гръмне!!!!!


        // Още една възможност на Дженерик е да му ограничим, какъв да бъде този тип данни(да ограничим до определени възможности) 
        // public class Generic<Т> where T : class   // where T : class - казваме където е Т искам винаги да бъде : клас  не друго (може да ограничим за всичко - int, string, Cat и тн...)
        // и сега ще може да се подава в шаблона, само определения тип данни! ТОВА СЕ ПРАВИ ГЛАВНО ЗА(ПО АБСТРАКТНИ КЛАСОВЕ(БАЗОВИ)) АКО ИМАМЕ ПРИМЕРНО
        // class Animal които е главният(базов) и  class dog , class cat  които наследяват Animal ... правим си public class Generic<Animal> и вече можем да подаваме 
        // в шаблона(Т-то) само котки и кучета и тн...
        // Тоест имаме възможност да ограничаваме тези Т-та(шаблони), за да можем да ги ползваме по предназначение!!!


        // Generic метод:    идеята му е да работи с повече от един тип данни или точно определен тип!
        public static string GetString<T>(T element) //<T> и вътре вече имаме достъпно това Т... можем и да го ограничим по горният начин-  where T : struct
        {                                      // ползваме го така- var value = GetString<int>(5);   казваме му какъв тип  в случая <int>   ще бъде в темплейта и ще замести Т-то                                               var value = GetString<int>(5);
            return element.ToString();
        }
        // пример: работи и с инт и със котки, и всякакви други можем да му сложим (типове данни), а можем и да го ограничим, за определен тип, ако искаме...
        //static void Main()
        //{
        //    var value = GetString<int>(5);
        //    var anotherValue = GetString<Cat>(new Cat(CatColor.Brown));
        //}


    }
}

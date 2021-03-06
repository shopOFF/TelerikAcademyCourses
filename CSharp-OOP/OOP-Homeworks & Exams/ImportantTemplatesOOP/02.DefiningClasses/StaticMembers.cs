﻿namespace _02.DefiningClasses
{
    public class StaticMembers
    {
        // Статични неща, те са общи за целия клас(всичко в него(всичко от този тип)(всички обекти които ще създадем от този клас, ще имат статичните неща които създадем)),
        // не като инстанционните, който се инстанцират за точно определена инстанция(обект).
        // например статични Owner. и ще излезе всичко статично което сме написали за този клас Owner, a
        // инстанционните пишем даденият обект peshoOwner. и ни излизат всичките му инстанционни неща(пропъртита,методи и тн...)

        // Статично може да бъде абсолютно всичко( метод, конструктор, пропърти,полета, класове и тн...)
        // Едното се вади от самата създадена инстанция и е конкретно за тази инстанция(инстанционно), а другото е общо за всичко(статично)

        public static int NumberOfCatLegs  // правим си статично пропърти(това може дасе добави като функционалност на 01.DefiningClasses в котката)
        {
            get   // обикновенно котките имат по определен брой крака и не можем да ги променяме обикновенно, затова само get
            {
                return 4;
            }
        }
        // Всички статични неща не можем да ги извикаме от this.(защото this сочи към текуща инстанция), а
        // всичко статично е общо(глобално)!!!
        // Тоест, за да достъпим броя крака на котките, не можем да достъпим през сat. (самата инстанция обекта)
        // Но можем през самият клас Owner. и вече ще ни е достъпно да изберем всичко статично, в случая - NumberOfCatLegs (Owner.NumberOfCatLegs)!!!

        // Това се прави с цел, ами всяко нещо което е еднакво за всички инстанции(обекти от дадения тип), 
        // няма смисъл да пазим едно и също нещо в рам паметта за всеки един обект!

            //правим си статичен метод
        public static string WhatDoesTheCatSay()
        {
            return "Mew!";
        }
        // и си извикваме и принтираме на конзолата този статичен метод така Cat.WhatDoesTheCatSay()
        // разбира се от началният клас на програмата ни CatSystemStart в случая
        // Console.WriteLine(Cat.WhatDoesTheCatSay());

        // Статичните методи се извикват, в момента в, който за пръв път се използва даден клас
        // тогава се запазват в паметтна всички, методи и статични неща на дадения клас
        // например var cat = new Cat(CatColor.Mixed); тогава всички статични неща се създават и пазят в паметта!
        // когато някой каже искам да използвам котка и всичко се блъска в паметта, за да може да е достъпно от там нататъка.
        // А при инстанционните се извикват(създават в паметта) точно определените инстанции, за точно определения обект, чак при точно неговото създаване извикване.
        
        // Идеята на статичните неща е те да влязат директно в употреба, щом даденият клас в който са влезе в употреба!


        // Статичните класове(виж клас Printer) се използват по рядко,обикновенно повечето класове не искате да
        // бъдат статични, защото всеки един НЕ статичен клас се освобождава в паметта, в момента, в който спре да се използва!!!
        // Статичните си живеят през цялото време на приложението
    }
}

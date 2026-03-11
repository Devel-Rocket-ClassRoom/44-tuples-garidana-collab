using System;
using System.Collections.Generic;
using static System.Console;
// README.md를 읽고 아래에 코드를 작성하세요.



List<(string name, int quantity, int price)> InvList;

void AddItem (List<(string name, int quantity, int price)> inventory, string name, int quantity, int price)
{
    var Item = (name, quantity, price);
    inventory.Add(Item);
    InvList = inventory;
}

(string name, int price) FindMostExpensive (List<(string name, int quantity, int price)> inventory)
{
    var maxPrice = 0;
    var maxName = "";
    foreach (var item in inventory)
    {
        
        if (maxPrice > item.price)
        {
            maxPrice = item.price;
            maxName = item.name;
        }
    }
    return (maxName, maxPrice);
}

AddItem( "체력 포션", 3, 500);
# Итоговая проверочная работа

## Задача: 
 Написать программу, которая из имеющегося массива строк  формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Описание решения:
1) С помощью метода WriteRead у пользователя запрашивается размер первоночального массива.
2) Создается пустой массив (входной) заданного размера и с помощью метода CreateFillArr пользователю предлагается заполнить его.
3) С помощью метода CountItem сразу определяется количество элементов в массиве, удовлетвоярющих условию задачи (строки с длиной не больше 3).
4) Создается пустой массив (выходной) размерностью, определенной из предыдущего пункта.
5) С помощью метода Filter перебираются строки "входного" массива и "выходной" массив заполняется значениями, удовлетворяющими заданному условию.
6) С помощью метода Vivod на экран выводится исходный и сформированный массив

## Блок схема основной содержательной части

# Genetic-Code

Задача: На основе заданных данных и функции воспроизвести 100 роодительских персон с генами A,B,C. На основе функции вычислить 10 лучших из них(лучшими считаются те у которых сумма значений функции максимальна) и удалить их. Оставшиеся 90 случайным образом скрестить и подвергнуть мутациям.

Данные:
* массив значений x:  0.0, 0.2, 0.4, 0.6, 0.8, 1.0, 1.2, 1.4, 1.6, 1.8, 2.0
* массив значений y:  0.57, 0.70, 0.89, 1.10, 1.32, 1.50, 1.58, 1.40, 1.32, 1.10, 0.90

Функция:
* (y - (A * x^2 + B * x + C)^2)

# ClassicalCryptographyChipersDemo
Демонстрационна программа.

- Цель проекта провести "Рефакторинг" выпускного проекта написанного на С++.
- Логика шифрования сохранилась, однако программная реализация нуждалась в полной переработке.

На данный момент готов "Аффиный шифр":
Применялись абстрактные классы. При разработке старался придерживаться принципов SOLID:
Конкретно, построение логики в "открытом для дополнений" формате, каждый класс "сосредоточен" на одной задаче. 

Была попытка применить принцип Dependency Inversion - Выделены отдельные классы "Фабрики", которые "забирают ответственность" за создание экземпляров классов, тем самым "Сложные модули" обращаются к абстракции.

Возможно, решение может показаться через чур "усложненным" для столь простой задачи, но цель состояла именно в применении механизмов разработки и сосредоточиться на максимальном обобщении.

Реализация через консольное приложение с меню на стрелочном управлении.

Представленные шифры:
1. Аффинный шифр					-	Готов
2. Шифр Виженера					-	Требуется "Рефакторинг" 
3. Шифр Плейфера					-	Требуется "Рефакторинг"
4. Шифр Хилла					-	Представлен в виде примера из-за сложного подбора ключа-матрицы проблематично реализуем. Требуется "Рефакторинг"
5. Шифр Вертикальной перестановки	-	Не закончен. На данный момент реализон ввод и проверка ключа. В процессе разработки.

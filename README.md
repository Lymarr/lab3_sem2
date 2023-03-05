<h1>Лабораторна №3</h1>

1. Реалізуйте програму, яка читає файл CSV, що містить перелік транзакцій, і 
обчислює загальну суму грошей, витрачену за кожен день. Використовуйте делегати
типу Func<string, DateTime> і Func<string, double>, щоб отримати дату та суму 
кожної транзакції з файлу CSV, і делегат типу Action<DateTime, double>, щоб 
відобразити загальну суму, витрачену на кожну з них. день. Перезапишіть данні 
в CSV файли по 10 записів у файлі. Використовуйте замикання для збереження 
поточних параметрів для шляху до файлу CSV і формату дати.

2. Напишіть програму, яка читає файли JSON (що мають числову назву від 1 до 10),
що містить список продуктів, і фільтрує продукти на основі набору критеріїв,
визначених користувачем. Використовуйте делегати типу Predicate<Product> для 
представлення критеріїв фільтра та делегат типу Action<Product> для відображення 
відфільтрованих продуктів. Використовуйте замикання для зберігання поточних 
параметрів шляху до файлу JSON і критеріїв фільтра.

3. Реалізуйте програму, яка використовує делегати для виконання набору операцій обробки
зображень над набором зображень. Використовуйте делегати типу Func<Bitmap, Bitmap> 
для представлення операцій обробки зображення та делегат типу Action<Bitmap> для
відображення оброблених зображень. 

4. Напишіть програму, яка читає набір текстових файлів і створює звіт зі статистичними
даними щодо частоти кожного слова у файлах. Використовуйте делегати типу Func<string, IEnumerable<string>> 
і Func<IEnumerable<string>, IDictionary<string, int>> для токенізації текстових файлів і
обчислення частоти слів, а також делегат типу Action<IDictionary<string, int>> для
відображення статистики частоти слів. 

### Home tasks for the .NET mentoring program.


## Async/Await
> 1. Напишите консольное приложение для асинхронного расчета суммы целых чисел от 0 до N. N задается пользователем из консоли. Пользователь вправе внести новую границу в процессе вычислений, что должно привести к перезапуску расчета. Это не должно привести к «падению» приложения;
> 2. Напишите простейший менеджер закачек. Пользователь задает адрес страницы, которую необходимо загрузить. В процессе загрузки пользователь может ее отменить. Пользователь может задавать несколько источников для закачки. Скачивание страниц не должно блокировать интерфейс приложения;
> 3. Напишите простейший магазин по заказу еды. Пользователь может выбрать товар, и он добавляется в корзину. При изменении товаров происходит автоматический пересчет стоимости. Любые действия пользователя с меню или корзиной не должны влиять на производительность UI (замораживать);
> 4. У вас есть Entity, которое описывает класс пользователя, хранящийся в БД. Пользователь хранит информацию об Имени, Фамилии, Возрасте. Напишите пример асинхронных CRUD операций для этого класса.

## Debugging
> Взяв за основу файл TaskApp.exe, который проверяет правильность введенного кода и используя приемы отладки, изученные на лекции, найдите правильный код или напишите свой кодогенератор.

## Expression Tree
***Задание 1***
> Создайте класс-трансформатор на основе ExpressionVisitor, выполняющий следующие 2 вида преобразований дерева выражений:
> 1. Замену выражений вида <переменная> + 1 / <переменная> - 1 на операции инкремента и декремента;
> 2. Замену параметров, входящих в lambda-выражение, на константы (в качестве параметров такого преобразования передавать:
>     * Исходное выражение;
>     * Список пар <имя параметра: значение для замены.
>       Для контроля полученное дерево выводить в консоль или смотреть результат под отладчиком, использую ExpressionTree Visualizer, а также компилировать его и вызывать полученный метод.

***Задание 2***
> Используя возможность конструировать Expression Tree и выполнять его код, создайте собственный механизм маппинга (копирующего поля (свойства) одного класса в другой).

## IQueryable
> Доработайте LINQ провайдер в проекте Task.zip так, чтобы проходили все тесты.
> В частности, требуется добавить следующее:
> 1. Снять текущее ограничение на порядок операндов выражения. Должны быть допустимы:
>     * <имя фильтруемого поля> == <константа> (сейчас доступен только этот);
>     * <константа> == <имя фильтруемого поля>.
> 2. Добавить поддержку операций включения (т.е. не точное совпадение со строкой, а частичное). При этом в LINQ-нотации они должны выглядеть как обращение к методам класса string: StartsWith, EndsWith, Contains, а точнее
>     * Выражение Where(e => e.workstation.StartsWith("EPRUIZHW006")) транслируется в запрос Workstation LIKE ‘EPRUIZHW006%’;
>     * Выражение Where(e => e.workstation.EndsWith("IZHW0060")) транслируется в запрос Workstation LIKE ‘%IZHW0060’;
>     * Выражение Where(e => e.workstation.Contains("IZHW006")) транслируется в запрос Workstation LIKE ‘%IZHW006%’.
> 3. Добавить поддержку оператора AND

## Multithreading in .NET
> Demonstrate the work of the each case with console utility
> 1. Write a program, which creates an array of 100 Tasks, runs them and wait all of them are not finished. Each Task should iterate from 1 to 1000 and print into the console the following string: “Task #0 – {iteration number}”;
> 2. Write a program, which creates a chain of four Tasks. First Task – creates an array of 10 random integer. Second Task – multiplies this array with another random integer. Third Task – sorts this array by ascending. Fourth Task – calculates the average value. All this tasks should print the values to console;
> 3. Write a program, which multiplies two matrices and uses class Parallel;
> 4. Write a program which recursively creates 10 threads. Each thread should be with the same body and receive a state with integer number, decrement it, print and pass as a state into the newly created thread. Use Thread class for this task and Join for waiting threads;
> 5. Write a program which recursively creates 10 threads. Each thread should be with the same body and receive a state with integer number, decrement it, print and pass as a state into the newly created thread. Use ThreadPool class for this task and Semaphore for waiting threads;
> 6. Write a program which creates two threads and a shared collection: the first one should add 10 elements into the collection and the second should print all elements in the collection after each adding. Use Thread, ThreadPool or Task classes for thread creation and any kind of synchronization constructions;
> 7. Create a Task and attach continuations to it according to the following criteria:
>     - Continuation task should be executed regardless of the result of the parent task;
>     - Continuation task should be executed when the parent task finished without success;
>     - Continuation task should be executed when the parent task would be finished with fail and parent task thread should be reused for continuation;
>     - Continuation task should be executed outside of the thread pool when the parent task would be cancelled.

## Profiling and Optimization
***Задание 1***
> Для генерации хэш-пароля используется следующий метод:
> 
```
public string GeneratePasswordHashUsingSalt(string passwordText, byte[] salt) 
{
  var iterate = 10000; 
  var pbkdf2 = new Rfc2898DeriveBytes(passwordText, salt, iterate); 
  byte[] hash = pbkdf2.GetBytes(20);
  byte[] hashBytes = new byte[36]; 
  Array.Copy(salt, 0, hashBytes, 0, 16); 
  Array.Copy(hash, 0, hashBytes, 16, 20);
  var passwordHash = Convert.ToBase64String(hashBytes);
  
  return passwordHash;
}
```
> 
> Попытайтесь не уменьшая количество итераций, которые содержаться в переменной iterate ускорить работу метода.

***Задание 2***
> Проанализируйте приложение ASP.NET MVC из архива ProfileSample.zip. Оптимизируйте алгоритм загрузки картинок из базы данных и последующего их отображения. Резервная копия базы данных находится в папке App_Data.

***Задание 3***
> Оптимизируйте приложение из архива GameOfLife.zip как с точки зрения утечек памяти, так и с точки зрения быстродействия

***Задание 4***
> В архиве DumpHomework.zip расположено приложение, которое вызвало у пользователя ошибку. К приложению приложен dump файл. Определите ошибку, и если сможете исправьте ее.

## Interoperating with Unmanaged Code
***Задание 1***
> Создайте библиотеку для Power State management на основе Power Management API. Библиотека в минимальном варианте должна поддерживать следующий функционал:
> 1. Получение текущей информации (на основе функции CallNtPowerInformation) об управлении питанием такую как:
>     * LastSleepTime;
>     * LastWakeTime;
>     * SystemBatteryState;
>     * SystemPowerInformation;
> 2. Резервировать и удалять hibernation файл (также см.функцию CallNtPowerInformation);
> 3. Переводить компьютер в состояние сна/гибернации (см. SetSuspendState).

***Задание 2***
> На основе данной библиотеки создайте COM компонент, который будет доступен из скриптовых языков и VBA (с поддержкой IDispatch).

***Задание 3***
> Напишите тестовые приложения и скрипты (на базе VBScript/JScript), тестирующие данные библиотеки.

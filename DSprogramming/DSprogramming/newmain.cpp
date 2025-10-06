#include <iostream>
#include <string>
#include <cstdlib>
#include <ctime>

using namespace std;
//
////! \brief Структура, описывающая человека.
///**
// * В данной структуре хранится информация о имени, фамилии и возрасте человека.
// */
//struct Person
//{
//    //! Имя человека.
//    string FirstName;
//
//    //! Фамилия человека.
//    string LastName;
//
//    //! Возраст человека.
//    unsigned Age;
//};
//
////! \brief Структура, содержащая информацию о продукте.
///**
// * В данной структуре хранится информация о названии продукта, его стоимости и веса.
// */
//struct Product
//{
//    //! Название продукта.
//    string Name;
//
//    //! Стоимость продукта.
//    unsigned Cost;
//
//    //! Вес продукта.
//    unsigned Weight;
//};
//
////! \brief Выводит в консоль данные о человеке.
///**
// * \param person – данные о человеке.
// */
//void WritePerson(const Person& person)
//{
//    cout << "First Name: " + person.FirstName
//        + "; Last Name: " + person.LastName
//        + "; Age: " + to_string(person.Age)
//        << endl;
//}
//
////! \brief Выводит в консоль данные о продукте.
///**
// * \param product – данные о продукте.
// */
//void WriteProduct(const Product& product)
//{
//    cout << "Name: " + product.Name
//        + "; Cost: " + to_string(product.Cost)
//        + "; Weight: " + to_string(product.Weight)
//        << endl;
//}
//
////! \brief Количество людей в массиве.
//const int PeopleCount = 5;
//
////! \brief Создает массив людей.
////! \return Массив указателей на объекты структуры человека \see People.
//Person** CreatePeopleArray()
//{
//    Person** people = new Person * [PeopleCount];
//
//    people[0] = new Person();
//    people[0]->FirstName = "Casey";
//    people[0]->LastName = "Aguilar";
//    people[0]->Age = 30;
//
//    people[1] = new Person();
//    people[1]->FirstName = "Brock";
//    people[1]->LastName = "Curtis";
//    people[1]->Age = 19;
//
//    people[2] = new Person();
//    people[2]->FirstName = "Blake";
//    people[2]->LastName = "Diaz";
//    people[2]->Age = 21;
//
//    people[3] = new Person();
//    people[3]->FirstName = "Cristian";
//    people[3]->LastName = "Evans";
//    people[3]->Age = 55;
//
//    people[4] = new Person();
//    people[4]->FirstName = "Les";
//    people[4]->LastName = "Foss";
//    people[4]->Age = 4;
//
//    return people;
//}
//
////! \brief Очищает из памяти объект человека \see Person.
////! \param person – объект человека \see Person.
//void ClearPerson(Person* person)
//{
//    delete person;
//}
//
////! \brief Очищает массив указателей на объекты в динамической памяти людей \see Person.
////! \param people – массив объектов в динамической памяти людей.
////! \param itemsCount – количество элементов в массиве.
//void ClearPeople(Person** people, int itemsCount)
//{
//    for (int i = 0; i < itemsCount; i++)
//    {
//        ClearPerson(people[i]);
//    }
//    delete[] people;
//}
//
//// Задание 1 - Точки останова
//void Breakpoints()
//{
//    double add = 1.0;
//    double sum = 0.0;
//    for (int i = 0; i < 1000; i++)
//    {
//        sum += add * i;
//        if (i % 3 == 0)
//        {
//            add *= 1.1;
//        }
//        else
//        {
//            add /= 3.0;
//        }
//    }
//    cout << "Total sum is " << sum << endl;
//}
//
//// Задание 2 - Массивы
//void SortIntArray(int arr[], int size)
//{
//    for (int i = 0; i < size - 1; i++)
//    {
//        for (int j = 0; j < size - i - 1; j++)
//        {
//            if (arr[j] > arr[j + 1])
//            {
//                int temp = arr[j];
//                arr[j] = arr[j + 1];
//                arr[j + 1] = temp;
//            }
//        }
//    }
//}
//
//int CountElementsAboveValue(double arr[], int size, double searchingValue)
//{
//    int count = 0;
//    for (int i = 0; i < size; i++)
//    {
//        if (arr[i] >= searchingValue)
//        {
//            count++;
//        }
//    }
//    return count;
//}
//
//void PrintLettersFromArray(char arr[], int size)
//{
//    cout << "All letters in your array:" << endl;
//    for (int i = 0; i < size; i++)
//    {
//        if (arr[i] >= 'a' && arr[i] <= 'z')
//        {
//            cout << arr[i] << " ";
//        }
//    }
//    cout << endl;
//}
//
//// Задание 3 - Функции
//double GetPower(double base, int exponent)
//{
//    double result = 1.0;
//    for (int i = 0; i < exponent; i++)
//    {
//        result *= base;
//    }
//    return result;
//}
//
//void DemoGetPower(double base, int exponent)
//{
//    double result = GetPower(base, exponent);
//    cout << base << " ^ " << exponent << " = " << result << endl;
//}
//
//void RoundToTens(int& value)
//{
//    int remainder = value % 10;
//    if (remainder < 5)
//    {
//        value = (value / 10) * 10;
//    }
//    else
//    {
//        value = (value / 10 + 1) * 10;
//    }
//}
//
//// Задание 4 - Адреса и указатели
//void Demo41()
//{
//    int a = 5;
//    int b = 4;
//    cout << "Address of a: " << &a << endl;
//    cout << "Address of b: " << &b << endl;
//
//    double c = 13.5;
//    cout << "Address of c: " << &c << endl;
//
//    bool d = true;
//    cout << "Address of d: " << &d << endl;
//}
//
//void Demo42()
//{
//    int a[10] = { 1, 2, 7, -1, 5, 3, -1, 7, 1, 6 };
//    cout << "Size of int type: " << sizeof(int) << endl;
//    for (int i = 0; i < 10; i++)
//    {
//        cout << "Address of a[" << i << "]: " << &a[i] << endl;
//    }
//
//    cout << endl;
//    cout << "Size of double type: " << sizeof(double) << endl;
//    double b[10] = { 1.0, 2.0, 7.0, -1.0, 5.0, 3.5, -1.8, 7.2, 1.9, 6.2 };
//    for (int i = 0; i < 10; i++)
//    {
//        cout << "Address of b[" << i << "]: " << &b[i] << endl;
//    }
//}
//
//void Demo43()
//{
//    int a = 5;
//    int& b = a;
//
//    cout << "Address of a: " << &a << endl;
//    cout << "Address of b: " << &b << endl;
//
//    cout << endl;
//    b = 7;
//    cout << "Value of a: " << a << endl;
//}

void Foo(double a)
{
    cout << "Address of a in Foo(): " << &a << endl;
    cout << "Value of a in Foo(): " << a << endl;

    a = 15.0;
    cout << "New value of a in Foo(): " << a << endl;
}

void Demo44()
{
    double a = 5.0;
    cout << "Address of a in main(): " << &a << endl;
    cout << "Value of a in main(): " << a << endl;
    cout << endl;

    Foo(a);

    cout << endl;
    cout << "Value of a in main(): " << a << endl;
}

void FooRef(double& a)
{
    cout << "Address of a in Foo(): " << &a << endl;
    cout << "Value of a in Foo(): " << a << endl;

    a = 15.0;
    cout << "New value of a in Foo(): " << a << endl;
}

void Demo45()
{
    double a = 5.0;
    cout << "Address of a in main(): " << &a << endl;
    cout << "Value of a in main(): " << a << endl;
    cout << endl;

    FooRef(a);

    cout << endl;
    cout << "Value of a in main(): " << a << endl;
}

void Demo46()
{
    int a = 5;
    int* pointer = &a;

    cout << "Address of a: " << &a << endl;
    cout << "Address in pointer: " << pointer << endl;
    cout << "Address of pointer: " << &pointer << endl;

    cout << endl;
    *pointer = 7;
    cout << "Value in a: " << a << endl;
    cout << "Value by pointer address: " << *pointer << endl;
}

void FooPointer(double* a)
{
    cout << "Address in pointer: " << a << endl;
    cout << "Address of pointer: " << &a << endl;
    cout << "Value in pointer address: " << *a << endl;

    *a = 15.0;
    cout << "New value in pointer address: " << *a << endl;
}

void Demo47()
{
    double value = 5.0;
    double* pointer = &value;
    cout << "Address of value in main(): " << &value << endl;
    cout << "Address in pointer in main(): " << pointer << endl;
    cout << "Address of pointer in main(): " << &pointer << endl;
    cout << "Value of a in main(): " << value << endl;
    cout << endl;

    FooPointer(pointer);

    cout << endl;
    cout << "Value of a in main(): " << value << endl;
}

// Задание 5 - Динамическая память
//void SortDoubleArray(double* arr, int size)
//{
//    for (int i = 0; i < size - 1; i++)
//    {
//        for (int j = 0; j < size - i - 1; j++)
//        {
//            if (arr[j] > arr[j + 1])
//            {
//                double temp = arr[j];
//                arr[j] = arr[j + 1];
//                arr[j + 1] = temp;
//            }
//        }
//    }
//}
//
//int FindIndex(int* arr, int size, int value)
//{
//    for (int i = 0; i < size; i++)
//    {
//        if (arr[i] == value)
//        {
//            return i;
//        }
//    }
//    return -1;
//}
//
//int CountLetters(char* arr, int size)
//{
//    int count = 0;
//    for (int i = 0; i < size; i++)
//    {
//        if (arr[i] >= 'a' && arr[i] <= 'z')
//        {
//            count++;
//        }
//    }
//    return count;
//}
//
//int* MakeRandomArray(int arraySize)
//{
//    int* arr = new int[arraySize];
//    for (int i = 0; i < arraySize; i++)
//    {
//        arr[i] = rand() % 101;
//    }
//    return arr;
//}
//
//int* ReadArray(int count)
//{
//    int* values = new int[count];
//    for (int i = 0; i < count; i++)
//    {
//        cin >> values[i];
//    }
//    return values;
//}
//
//int CountPositiveValues(int* values, int count)
//{
//    int result = 0;
//    for (int i = 0; i < count; i++)
//    {
//        if (values[i] > 0)
//        {
//            result++;
//        }
//    }
//    return result;
//}
//
//// Задание 6 - Линейный поиск
//void Task1_FindPersonByLastName()
//{
//    Person** people = CreatePeopleArray();
//
//    cout << "Task 1 – Find Person by Last Name" << endl;
//    for (int i = 0; i < PeopleCount; i++)
//    {
//        WritePerson(*people[i]);
//    }
//
//    string lastName;
//    cout << "Enter last name: ";
//    cin >> lastName;
//
//    int foundIndex = -1;
//
//    for (int i = 0; i < PeopleCount; i++)
//    {
//        if (people[i]->LastName == lastName)
//        {
//            foundIndex = i;
//            break;
//        }
//    }
//
//    if (foundIndex == -1)
//    {
//        cout << "Could not find a person by last name: " << lastName << endl;
//    }
//    else
//    {
//        cout << "A person's last name "
//            << lastName
//            << " was found. Its index in the array is "
//            << foundIndex
//            << endl;
//    }
//
//    ClearPeople(people, PeopleCount);
//}

int main()
{
    srand(time(0)); // Инициализация генератора случайных чисел

    //// Задание 1
    //cout << "=== Assignment 1 ===" << endl;
    //Breakpoints();
    //cout << endl;

    //// Задание 2.1
    //cout << "=== Assignment 2.1 ===" << endl;
    //int intArray1[10] = { 12, 21, 119, -80, 300, 75, 81, -8, 47, 31 };

    //cout << "Source array is:" << endl;
    //for (int i = 0; i < 10; i++)
    //{
    //    cout << intArray1[i] << " ";
    //}
    //cout << endl;

    //SortIntArray(intArray1, 10);

    //cout << "Sorted array is:" << endl;
    //for (int i = 0; i < 10; i++)
    //{
    //    cout << intArray1[i] << " ";
    //}
    //cout << endl << endl;

    //// Задание 2.2
    //cout << "=== Assignment 2.2 ===" << endl;
    //double doubleArray1[12] = { 12.0, 21.5, 119.2, -80.7, 300.0, 75.5, 81.2, 8.1, 47.3, 31.2, 85.3, 100.1 };

    //cout << "Source array is:" << endl;
    //for (int i = 0; i < 12; i++)
    //{
    //    cout << doubleArray1[i] << " ";
    //}
    //cout << endl;

    //double searchValue1;
    //cout << "Enter searching value: ";
    //cin >> searchValue1;

    //int count1 = CountElementsAboveValue(doubleArray1, 12, searchValue1);
    //cout << "Elements of array more than " << searchValue1 << " is: " << count1 << endl << endl;

    //// Задание 2.3
    //cout << "=== Assignment 2.3 ===" << endl;
    //char charArray1[8];

    //cout << "Enter array of 8 chars" << endl;
    //for (int i = 0; i < 8; i++)
    //{
    //    cout << "a[" << i << "]: ";
    //    cin >> charArray1[i];
    //}

    //cout << "Your array is:" << endl;
    //for (int i = 0; i < 8; i++)
    //{
    //    cout << charArray1[i] << " ";
    //}
    //cout << endl;

    //PrintLettersFromArray(charArray1, 8);
    //cout << endl;

    //// Задание 3.1
    //cout << "=== Assignment 3.1 ===" << endl;
    //double base1 = 2.0;
    //int exponent1 = 5;
    //cout << base1 << " ^ " << exponent1 << " = " << GetPower(base1, exponent1) << endl;

    //base1 = 3.0;
    //exponent1 = 4;
    //cout << base1 << " ^ " << exponent1 << " = " << GetPower(base1, exponent1) << endl;

    //base1 = -2.0;
    //exponent1 = 5;
    //cout << base1 << " ^ " << exponent1 << " = " << GetPower(base1, exponent1) << endl;
    //cout << endl;

    //// Задание 3.2
    //cout << "=== Assignment 3.2 ===" << endl;
    //DemoGetPower(2.0, 5);
    //DemoGetPower(3.0, 4);
    //DemoGetPower(-2.0, 5);
    //cout << endl;

    //// Задание 3.3
    //cout << "=== Assignment 3.3 ===" << endl;
    //int value1 = 14;
    //cout << "For " << value1;
    //RoundToTens(value1);
    //cout << " rounded value is " << value1 << endl;

    //value1 = 191;
    //cout << "For " << value1;
    //RoundToTens(value1);
    //cout << " rounded value is " << value1 << endl;

    //value1 = 27;
    //cout << "For " << value1;
    //RoundToTens(value1);
    //cout << " rounded value is " << value1 << endl;
    //cout << endl;

    //// Задание 4.1
    //cout << "=== Assignment 4.1 ===" << endl;
    //Demo41();
    //cout << endl;

    //// Задание 4.2
    //cout << "=== Assignment 4.2 ===" << endl;
    //Demo42();
    //cout << endl;

    //// Задание 4.3
    //cout << "=== Assignment 4.3 ===" << endl;
    /*Demo43();
    cout << endl;*/

    // Задание 4.4
    cout << "=== Assignment 4.4 ===" << endl;
    Demo44();
    cout << endl;

    // Задание 4.5
    cout << "=== Assignment 4.5 ===" << endl;
    Demo45();
    cout << endl;

    // Задание 4.6
    cout << "=== Assignment 4.6 ===" << endl;
    Demo46();
    cout << endl;

    // Задание 4.7
    cout << "=== Assignment 4.7 ===" << endl;
    Demo47();
    cout << endl;

    //// Задание 5.1
    //cout << "=== Assignment 5.1 ===" << endl;
    //double* dynamicDoubleArray1 = new double[8] {1.0, 15.0, -8.2, -3.5, 12.6, 38.4, -0.5, 4.5};
    //cout << "Array of double:" << endl;
    //for (int i = 0; i < 8; i++)
    //{
    //    cout << dynamicDoubleArray1[i] << " ";
    //}
    //cout << endl;
    //delete[] dynamicDoubleArray1;
    //cout << endl;

    //// Задание 5.2
    //cout << "=== Assignment 5.2 ===" << endl;
    //bool* boolArray1 = new bool[8] {true, false, true, true, false, true, false, false};
    //cout << "Array of bool:" << endl;
    //for (int i = 0; i < 8; i++)
    //{
    //    cout << (boolArray1[i] ? "true" : "false") << " ";
    //}
    //cout << endl;
    //delete[] boolArray1;
    //cout << endl;

    //// Задание 5.3
    //cout << "=== Assignment 5.3 ===" << endl;
    //int size1;
    //cout << "Enter char array size: ";
    //cin >> size1;
    //char* dynamicCharArray1 = new char[size1];
    //for (int i = 0; i < size1; i++)
    //{
    //    cout << "Enter a[" << i << "]: ";
    //    cin >> dynamicCharArray1[i];
    //}
    //cout << "Your char array is:" << endl;
    //for (int i = 0; i < size1; i++)
    //{
    //    cout << dynamicCharArray1[i] << " ";
    //}
    //cout << endl;
    //delete[] dynamicCharArray1;
    //cout << endl;

    //// Задание 5.4
    //cout << "=== Assignment 5.4 ===" << endl;
    //double* dynamicDoubleArray2 = new double[10] {1.0, 15.0, -8.2, -3.5, 12.6, 38.4, -0.5, 4.5, 16.7, 4.5};

    //cout << "Array of double:" << endl;
    //for (int i = 0; i < 10; i++)
    //{
    //    cout << dynamicDoubleArray2[i] << " ";
    //}
    //cout << endl;

    //SortDoubleArray(dynamicDoubleArray2, 10);

    //cout << "Sorted array of double:" << endl;
    //for (int i = 0; i < 10; i++)
    //{
    //    cout << dynamicDoubleArray2[i] << " ";
    //}
    //cout << endl;

    //delete[] dynamicDoubleArray2;
    //cout << endl;

    //// Задание 5.5
    //cout << "=== Assignment 5.5 ===" << endl;
    //int* dynamicIntArray1 = new int[10] {1, 15, -8, -3, 12, 38, 0, 4, 16, 4};

    //cout << "Int array:" << endl;
    //for (int i = 0; i < 10; i++)
    //{
    //    cout << dynamicIntArray1[i] << " ";
    //}
    //cout << endl;

    //int searchValue2;
    //cout << "Enter searching value: ";
    //cin >> searchValue2;

    //int index1 = FindIndex(dynamicIntArray1, 10, searchValue2);
    //if (index1 != -1)
    //{
    //    cout << "Index of searching value " << searchValue2 << " is: " << index1 << endl;
    //}
    //else
    //{
    //    cout << "Value not found" << endl;
    //}

    //delete[] dynamicIntArray1;
    //cout << endl;

    //// Задание 5.6
    //cout << "=== Assignment 5.6 ===" << endl;
    //char* dynamicCharArray2 = new char[15] {'a', '5', 'm', 'i', '%', '!', 's', 'p', '*', '9', 'f', '^', ';', 'q', 'k'};

    //cout << "Char array is:" << endl;
    //for (int i = 0; i < 15; i++)
    //{
    //    cout << dynamicCharArray2[i] << " ";
    //}
    //cout << endl;

    //int letterCount1 = CountLetters(dynamicCharArray2, 15);
    //cout << "Letters in array:" << endl;
    //for (int i = 0; i < 15; i++)
    //{
    //    if (dynamicCharArray2[i] >= 'a' && dynamicCharArray2[i] <= 'z')
    //    {
    //        cout << dynamicCharArray2[i] << " ";
    //    }
    //}
    //cout << endl;
    //cout << "Number of letters: " << letterCount1 << endl;

    //delete[] dynamicCharArray2;
    //cout << endl;

    //// Задание 5.7
    //cout << "=== Assignment 5.7 ===" << endl;
    //int* randomArray5 = MakeRandomArray(5);
    //cout << "Random array of 5:" << endl;
    //for (int i = 0; i < 5; i++)
    //{
    //    cout << randomArray5[i] << " ";
    //}
    //cout << endl;
    //delete[] randomArray5;

    //int* randomArray8 = MakeRandomArray(8);
    //cout << "Random array of 8:" << endl;
    //for (int i = 0; i < 8; i++)
    //{
    //    cout << randomArray8[i] << " ";
    //}
    //cout << endl;
    //delete[] randomArray8;

    //int* randomArray13 = MakeRandomArray(13);
    //cout << "Random array of 13:" << endl;
    //for (int i = 0; i < 13; i++)
    //{
    //    cout << randomArray13[i] << " ";
    //}
    //cout << endl;
    //delete[] randomArray13;
    //cout << endl;

    //// Задание 5.8
    //cout << "=== Assignment 5.8 ===" << endl;
    //int count2 = 15;
    //int* values1 = ReadArray(count2);
    //cout << "Count is: " << CountPositiveValues(values1, count2) << endl;
    //delete[] values1;

    //count2 = 20;
    //int* values2 = ReadArray(count2);
    //cout << "Count is: " << CountPositiveValues(values2, count2) << endl;
    //delete[] values2;
    //cout << endl;

    //// Задание 6
    //cout << "=== Assignment 6 ===" << endl;
    //Person person1;
    //person1.FirstName = "John";
    //person1.LastName = "Doe";
    //person1.Age = 25;
    //WritePerson(person1);

    //cout << endl;

    //Product product1;
    //product1.Name = "Laptop";
    //product1.Cost = 50000;
    //product1.Weight = 2;
    //WriteProduct(product1);

    //cout << endl;

    //Task1_FindPersonByLastName();
}
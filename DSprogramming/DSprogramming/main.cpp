#include <iostream>
#include <string>

using namespace std;

//! \brief Структура, описывающая человека.
/**
 * В данной структуре хранится информация о имени, фамилии и возрасте человека.
 */
struct Person
{
    string FirstName;

    string LastName;

    unsigned Age;
};

//! \brief Структура, содержащая информацию о продукте.
/**
 * В данной структуре хранится информация о названии продукта, его стоимости и веса.
 */
struct Product
{
    string Name;

    unsigned Cost;

    unsigned Weight;
};

//! \brief Выводит в консоль данные о человеке.
/**
 * \param person – данные о человеке.
 */
void WritePerson(const Person& person)
{
    cout << "First Name: " + person.FirstName
        + "; Last Name: " + person.LastName
        + "; Age: " + to_string(person.Age)
        << endl;
}

//! \brief Выводит в консоль данные о продукте.
/**
 * \param product – данные о продукте.
 */
void WriteProduct(const Product& product)
{
    cout << "Name: " + product.Name
        + "; Cost: " + to_string(product.Cost)
        + "; Weight: " + to_string(product.Weight)
        << endl;
}

//! \brief Количество людей в массиве.
const int PeopleCount = 5;

//! \brief Создает массив людей.
//! \return Массив указателей на объекты структуры человека \see People.
Person** CreatePeopleArray()
{
    Person** people = new Person * [PeopleCount];

    people[0] = new Person();
    people[0]->FirstName = "Casey";
    people[0]->LastName = "Aguilar";
    people[0]->Age = 30;

    people[1] = new Person();
    people[1]->FirstName = "Brock";
    people[1]->LastName = "Curtis";
    people[1]->Age = 19;

    people[2] = new Person();
    people[2]->FirstName = "Blake";
    people[2]->LastName = "Diaz";
    people[2]->Age = 21;

    people[3] = new Person();
    people[3]->FirstName = "Cristian";
    people[3]->LastName = "Evans";
    people[3]->Age = 55;

    people[4] = new Person();
    people[4]->FirstName = "Les";
    people[4]->LastName = "Foss";
    people[4]->Age = 4;

    return people;
}

//! \brief Очищает из памяти объект человека \see Person.
//! \param person – объект человека \see Person.
void ClearPerson(Person* person)
{
    delete person;
}

//! \brief Очищает массив указателей на объекты в динамической памяти людей \see Person.
//! \param people – массив объектов в динамической памяти людей.
//! \param itemsCount – количество элементов в массиве.
void ClearPeople(Person** people, int itemsCount)
{
    for (int i = 0; i < itemsCount; i++)
    {
        ClearPerson(people[i]);
    }
    delete[] people;
}

//! \brief Задание 1. Поиск человека по фамилии.
void Task1_FindPersonByLastName()
{
    Person** people = CreatePeopleArray();

    cout << "Task 1 – Find Person by Last Name" << endl;
    for (int i = 0; i < PeopleCount; i++)
    {
        WritePerson(*people[i]);
    }

    string lastName;
    cout << "Enter last name: ";
    cin >> lastName;

    int foundIndex = -1;

    for (int i = 0; i < PeopleCount; i++)
    {
        if (people[i]->LastName == lastName)
        {
            foundIndex = i;
            break;
        }
    }

    if (foundIndex == -1)
    {
        cout << "Could not find a person by last name: " << lastName << endl;
    }
    else
    {
        cout << "A person's last name "
            << lastName
            << " was found. Its index in the array is "
            << foundIndex
            << endl;
    }

    ClearPeople(people, PeopleCount);
}

void SortIntArray(int arr[], int size) {
    for (int i = 0; i < size - 1; i++) {
        for (int j = 0; j < size - i - 1; j++) {
            if (arr[j] > arr[j + 1]) {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}

int CountElementsAboveValue(double arr[], int size, double searchingValue) {
    int count = 0;
    for (int i = 0; i < size; i++) {
        if (arr[i] >= searchingValue) {
            count++;
        }
    }
    return count;
}

void PrintLettersFromArray(char arr[], int size) {
    cout << "All letters in your array:" << endl;
    for (int i = 0; i < size; i++) {
        if (arr[i] >= 'a' && arr[i] <= 'z') {
            cout << arr[i] << " ";
        }
    }
    cout << endl;
}

double GetPower(double base, int exponent) {
    double result = 1.0;
    for (int i = 0; i < exponent; i++) {
        result *= base;
    }
    return result;
}

void DemoGetPower(double base, int exponent) {
    double result = GetPower(base, exponent);
    cout << base << " ^ " << exponent << " = " << result << endl;
}

void RoundToTens(int& value) {
    int remainder = value % 10;
    if (remainder < 5) {
        value = (value / 10) * 10;
    }
    else {
        value = (value / 10 + 1) * 10;
    }
}

void Foo(double a)
{
    cout << "Address of a in Foo(): " << &a << endl;
    cout << "Value of a in Foo(): " << a << endl;

    a = 15.0;
    cout << "New value of a in Foo(): " << a << endl;
}

void FooRef(double& a)
{
    cout << "Address of a in Foo(): " << &a << endl;
    cout << "Value of a in Foo(): " << a << endl;

    a = 15.0;
    cout << "New value of a in Foo(): " << a << endl;
}

void FooPointer(double* a)
{
    cout << "Address in pointer: " << a << endl;
    cout << "Address of pointer: " << &a << endl;
    cout << "Value in pointer address: " << *a << endl;

    *a = 15.0;
    cout << "New value in pointer address: " << *a << endl;
}

void demo41() {
    int a = 5;
    int b = 4;
    cout << "Address of a: " << &a << endl;
    cout << "Address of b: " << &b << endl;

    double c = 13.5;
    cout << "Address of c: " << &c << endl;

    bool d = true;
    cout << "Address of d: " << &d << endl;
}

void demo42() {
    int a[10] = { 1, 2, 7, -1, 5, 3, -1, 7, 1, 6 };
    cout << "Size of int type: " << sizeof(int) << endl;
    for (int i = 0; i < 10; i++)
    {
        cout << "Address of a[" << i << "]: " << &a[i] << endl;
    }

    cout << endl;
    cout << "Size of double type: " << sizeof(double) << endl;
    double b[10] = { 1.0, 2.0, 7.0, -1.0, 5.0, 3.5, -1.8, 7.2, 1.9, 6.2 };
    for (int i = 0; i < 10; i++)
    {
        cout << "Address of b[" << i << "]: " << &b[i] << endl;
    }
}

void demo43() {
    int a = 5;
    int& b = a;

    cout << "Address of a: " << &a << endl;
    cout << "Address of b: " << &b << endl;

    cout << endl;
    b = 7;
    cout << "Value of a: " << a << endl;
}

void demo44() {
    double a = 5.0;
    cout << "Address of a in main(): " << &a << endl;
    cout << "Value of a in main(): " << a << endl;
    cout << endl;

    Foo(a);

    cout << endl;
    cout << "Value of a in main(): " << a << endl;
}

void demo45() {
    double a = 5.0;
    cout << "Address of a in main(): " << &a << endl;
    cout << "Value of a in main(): " << a << endl;
    cout << endl;

    FooRef(a);

    cout << endl;
    cout << "Value of a in main(): " << a << endl;
}

void demo46() {
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

void demo47() {
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

void SortDoubleArray(double* arr, int size) {
    for (int i = 0; i < size - 1; i++) {
        for (int j = 0; j < size - i - 1; j++) {
            if (arr[j] > arr[j + 1]) {
                double temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}

int FindIndex(int* arr, int size, int value) {
    for (int i = 0; i < size; i++) {
        if (arr[i] == value) {
            return i;
        }
    }
    return -1;
}

int CountLetters(char* arr, int size) {
    int count = 0;
    for (int i = 0; i < size; i++) {
        if (arr[i] >= 'a' && arr[i] <= 'z') {
            count++;
        }
    }
    return count;
}

int* MakeRandomArray(int arraySize) {
    int* arr = new int[arraySize];
    for (int i = 0; i < arraySize; i++) {
        arr[i] = rand() % 101;
    }
    return arr;
}

int* ReadArray(int count) {
    int* values = new int[count];
    for (int i = 0; i < count; i++) {
        cin >> values[i];
    }
    return values;
}

int CountPositiveValues(int* values, int count) {
    int result = 0;
    for (int i = 0; i < count; i++) {
        if (values[i] > 0) {
            result++;
        }
    }
    return result;
}

int main() {
    // 2.1
    int intArr[10] = { 12, 21, 119, -80, 300, 75, 81, -8, 47, 31 };

    cout << "Source array is:" << endl;
    for (int i = 0; i < 10; i++) {
        cout << intArr[i] << " ";
    }
    cout << endl;

    SortIntArray(intArr, 10);

    cout << "Sorted array is:" << endl;
    for (int i = 0; i < 10; i++) {
        cout << intArr[i] << " ";
    }
    cout << endl;

    cout << endl;

    // 2.2
    double doubleArr[12] = { 12.0, 21.5, 119.2, -80.7, 300.0, 75.5, 81.2, 8.1, 47.3, 31.2, 85.3, 100.1 };

    cout << "Source array is:" << endl;
    for (int i = 0; i < 12; i++) {
        cout << doubleArr[i] << " ";
    }
    cout << endl;

    double searchingValue;
    cout << "Enter searching value: ";
    cin >> searchingValue;

    int count = CountElementsAboveValue(doubleArr, 12, searchingValue);
    cout << "Elements of array more than " << searchingValue << " is: " << count << endl;

    cout << endl;

    // 2.3
    char charArr[8];

    cout << "Enter array of 8 chars" << endl;
    for (int i = 0; i < 8; i++) {
        cout << "a[" << i << "]: ";
        cin >> charArr[i];
    }

    cout << "Your array is:" << endl;
    for (int i = 0; i < 8; i++) {
        cout << charArr[i] << " ";
    }
    cout << endl;

    PrintLettersFromArray(charArr, 8);

    cout << endl;

    //3.1
    double base = 2.0;
    int exponent = 5;
    cout << base << " ^ " << exponent << " = " << GetPower(base, exponent) << endl;

    base = 3.0;
    exponent = 4;
    cout << base << " ^ " << exponent << " = " << GetPower(base, exponent) << endl;

    base = -2.0;
    exponent = 5;
    cout << base << " ^ " << exponent << " = " << GetPower(base, exponent) << endl;

    cout << endl;

    //3.2
    DemoGetPower(2.0, 5);
    DemoGetPower(3.0, 4);
    DemoGetPower(-2.0, 5);

    cout << endl;

    //3.3
    int a = 14;
    cout << "For " << a;
    RoundToTens(a);
    cout << " rounded value is " << a << endl;

    a = 191;
    cout << "For " << a;
    RoundToTens(a);
    cout << " rounded value is " << a << endl;

    a = 27;
    cout << "For " << a;
    RoundToTens(a);
    cout << " rounded value is " << a << endl;

    //4.1
    demo41();

    //4.2
    demo42();

    //4.3
    demo43();

    //4.4
    demo44();

    //4.5
    demo45();

    //4.6
    demo46();

    //4.7
    demo47();

    //5.1
    double* doubleArr = new double[8] {1.0, 15.0, -8.2, -3.5, 12.6, 38.4, -0.5, 4.5};
    for (int i = 0; i < 8; i++) {
        cout << doubleArr[i] << " ";
    }
    cout << endl;
    delete[] doubleArr;

    //5.2
    bool* boolArr = new bool[8] {true, false, true, true, false, true, false, false};
    for (int i = 0; i < 8; i++) {
        cout << (boolArr[i] ? "true" : "false") << " ";
    }
    cout << endl;
    delete[] boolArr;

    //5.3
    int n;
    cout << "Enter char array size: ";
    cin >> n;
    char* charArr = new char[n];
    for (int i = 0; i < n; i++) {
        cout << "Enter a[" << i << "]: ";
        cin >> charArr[i];
    }
    cout << "Your char array is:" << endl;
    for (int i = 0; i < n; i++) {
        cout << charArr[i] << " ";
    }
    cout << endl;
    delete[] charArr;

    //5.4
    double* doubleArr = new double[10] {1.0, 15.0, -8.2, -3.5, 12.6, 38.4, -0.5, 4.5, 16.7, 4.5};

    cout << "Array of double:" << endl;
    for (int i = 0; i < 10; i++) {
        cout << doubleArr[i] << " ";
    }
    cout << endl;

    SortDoubleArray(doubleArr, 10);

    cout << "Sorted array of double:" << endl;
    for (int i = 0; i < 10; i++) {
        cout << doubleArr[i] << " ";
    }
    cout << endl;

    delete[] doubleArr;

    cout << endl;

    //5.5
    int* intArr = new int[10] {1, 15, -8, -3, 12, 38, 0, 4, 16, 4};

    cout << "Int array:" << endl;
    for (int i = 0; i < 10; i++) {
        cout << intArr[i] << " ";
    }
    cout << endl;

    int searchValue;
    cout << "Enter searching value: ";
    cin >> searchValue;

    int index = FindIndex(intArr, 10, searchValue);
    if (index != -1) {
        cout << "Index of searching value " << searchValue << " is: " << index << endl;
    }
    else {
        cout << "Value not found" << endl;
    }

    delete[] intArr;

    cout << endl;

    //5.6
    char* charArr = new char[15] {'a', '5', 'm', 'i', '%', '!', 's', 'p', '*', '9', 'f', '^', ';', 'q', 'k'};

    cout << "Char array is:" << endl;
    for (int i = 0; i < 15; i++) {
        cout << charArr[i] << " ";
    }
    cout << endl;

    int letterCount = CountLetters(charArr, 15);
    cout << "Letters in array:" << endl;
    for (int i = 0; i < 15; i++) {
        if (charArr[i] >= 'a' && charArr[i] <= 'z') {
            cout << charArr[i] << " ";
        }
    }
    cout << endl;
    cout << "Number of letters: " << letterCount << endl;

    delete[] charArr;

    cout << endl;

    //5.7

    int* arr5 = MakeRandomArray(5);
    cout << "Random array of 5:" << endl;
    for (int i = 0; i < 5; i++) {
        cout << arr5[i] << " ";
    }
    cout << endl;
    delete[] arr5;

    int* arr8 = MakeRandomArray(8);
    cout << "Random array of 8:" << endl;
    for (int i = 0; i < 8; i++) {
        cout << arr8[i] << " ";
    }
    cout << endl;
    delete[] arr8;

    int* arr13 = MakeRandomArray(13);
    cout << "Random array of 13:" << endl;
    for (int i = 0; i < 13; i++) {
        cout << arr13[i] << " ";
    }
    cout << endl;
    delete[] arr13;

    cout << endl;

    //5.8
    int count = 15;
    int* values = ReadArray(count);
    cout << "Count is: " << CountPositiveValues(values, count) << endl;
    delete[] values;

    count = 20;
    values = ReadArray(count);
    cout << "Count is: " << CountPositiveValues(values, count) << endl;
    delete[] values;

    //6
    Person person;
    person.FirstName = "John";
    person.LastName = "Doe";
    person.Age = 25;
    WritePerson(person);

    cout << endl;

    Product product;
    product.Name = "Laptop";
    product.Cost = 50000;
    product.Weight = 2;
    WriteProduct(product);

    cout << endl;

    Task1_FindPersonByLastName();
}
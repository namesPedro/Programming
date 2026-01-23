#include <iostream>
#include "Validator.h"

/// <summary>
/// Получает валидный числовой ввод от пользователя.
/// </summary>
/// <param name="prompt">Сообщение для пользователя</param>
/// <returns>Введенное число</returns>
int GetValidatedInput(const std::string& prompt)
{
    int value;
    while (true)
    {
        std::cout << prompt;
        std::cin >> value;

        if (std::cin.fail())
        {
            std::cin.clear();
            std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
            std::cout << "Invalid input. Please enter a number." << std::endl;
        }
        else
        {
            std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
            return value;
        }
    }
}
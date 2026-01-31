#include "IODictionary.h"
#include <iostream>

void IODictionary::Display(const Dictionary& dict)
{
    std::cout << "\n=== Dictionary State ===" << std::endl;
    std::cout << "Total entries: " << dict.GetSize() << std::endl;

    auto pairs = dict.GetAllPairs();
    for (const auto& pair : pairs)
    {
        std::cout << "[" << pair.first << "]: " << pair.second << std::endl;
    }
}
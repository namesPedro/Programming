#include "IODictionary.h"
#include <iostream>

void IODictionary::Display(const Dictionary& dict)
{
    std::cout << "=== Dictionary State ===" << std::endl;
    std::cout << "Total entries: " << dict.GetSize() << std::endl;
}
#include "IOHashTable.h"
#include <iostream>
#include <iomanip>

void IOHashTable::Display(const HashTable& table)
{
    std::cout << "\n=== Hash Table State ===" << std::endl;
    std::cout << "Capacity: " << table.GetCapacity() << std::endl;
    std::cout << "Size: " << table.GetSize() << std::endl;
    std::cout << "Load Factor: " << static_cast<double>(table.GetSize()) / table.GetCapacity() << std::endl;
    std::cout << "Unique Keys: " << table.GetUniqueKeyCount() << std::endl;
    std::cout << "\nKey-value pairs:" << std::endl;

    const auto& buckets = table.GetBuckets();
    for (size_t i = 0; i < buckets.size(); i++)
    {
        std::cout << "[" << std::setw(3) << i << "]: ";
        if (buckets[i].empty())
        {
            std::cout << "EMPTY";
        }
        else
        {
            for (size_t j = 0; j < buckets[i].size(); j++)
            {
                std::cout << "{" << buckets[i][j].GetKey() << ":" << buckets[i][j].GetValue() << "}";
                if (j != buckets[i].size() - 1) std::cout << ", ";
            }
        }
        std::cout << std::endl;
    }
}
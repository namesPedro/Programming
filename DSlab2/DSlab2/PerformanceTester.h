#pragma once
#include "List.h"
#include "DynamicArray.h"

struct MeasureResult {
    int size;
    double listTime;
    double arrayTime;
};

class PerformanceTester {
public:
    static int GetIterationsForSize(int size);

    static int MeasureInsertAtBeginning(const int* sizes, int count, MeasureResult* results);
    static int MeasureInsertAtEnd(const int* sizes, int count, MeasureResult* results);
    static int MeasureInsertAtMiddle(const int* sizes, int count, MeasureResult* results);

    static int MeasureRemoveFromBeginning(const int* sizes, int count, MeasureResult* results);
    static int MeasureRemoveFromEnd(const int* sizes, int count, MeasureResult* results);
    static int MeasureRemoveFromMiddle(const int* sizes, int count, MeasureResult* results);
};
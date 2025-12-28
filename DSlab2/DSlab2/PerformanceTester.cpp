#include "PerformanceTester.h"
#include <chrono>
#include <iostream>

int PerformanceTester::GetIterationsForSize(int size) {
    if (size <= 200) return 2000;
    if (size <= 1000) return 1000;
    return 300;
}

// ---------- ÂÑÏÎÌÎÃÀÒÅËÜÍÛÅ ÔÓÍÊÖÈÈ ----------

static inline double MeasureOnceInsertFront(int size) {
    List list;
    DynamicArray arr;

    for (int i = 0; i < size; i++) {
        list.AddToEnd(new Node(i));
        arr.Add(i);
    }

    using namespace std::chrono;

    auto start1 = high_resolution_clock::now();
    list.AddToFront(new Node(-1));
    auto end1 = high_resolution_clock::now();
    double tList = duration<double, std::micro>(end1 - start1).count();

    auto start2 = high_resolution_clock::now();
    arr.Insert(0, -1);
    auto end2 = high_resolution_clock::now();
    double tArr = duration<double, std::micro>(end2 - start2).count();

    return tList + (tArr / 1000000.0);
}

// ---------- ÒÅÑÒ ÂÑÒÀÂÊÈ Â ÍÀ×ÀËÎ ----------
int PerformanceTester::MeasureInsertAtBeginning(const int* sizes, int count, MeasureResult* results) {
    using namespace std::chrono;

    for (int i = 0; i < count; i++) {
        int size = sizes[i];
        int iters = GetIterationsForSize(size);

        double listTimeTotal = 0;
        double arrayTimeTotal = 0;

        for (int it = 0; it < iters; it++) {
            List list;
            DynamicArray arr;

            for (int j = 0; j < size; j++) {
                list.AddToEnd(new Node(j));
                arr.Add(j);
            }

            auto start1 = high_resolution_clock::now();
            list.AddToFront(new Node(-1));
            auto end1 = high_resolution_clock::now();
            listTimeTotal += duration<double, std::micro>(end1 - start1).count();

            auto start2 = high_resolution_clock::now();
            arr.Insert(0, -1);
            auto end2 = high_resolution_clock::now();
            arrayTimeTotal += duration<double, std::micro>(end2 - start2).count();
        }

        results[i] = { size, listTimeTotal / iters, arrayTimeTotal / iters };

        std::cout << "Insert begin - Size: " << size
            << " - List: " << results[i].listTime
            << " us, Array: " << results[i].arrayTime << " us\n";
    }
    return count;
}

// ---------- ÒÅÑÒ ÂÑÒÀÂÊÈ Â ÊÎÍÅÖ ----------
int PerformanceTester::MeasureInsertAtEnd(const int* sizes, int count, MeasureResult* results) {
    using namespace std::chrono;

    for (int i = 0; i < count; i++) {
        int size = sizes[i];
        int iters = GetIterationsForSize(size);

        double listTotal = 0;
        double arrTotal = 0;

        for (int it = 0; it < iters; it++) {
            List list;
            DynamicArray arr;

            for (int j = 0; j < size; j++) {
                list.AddToEnd(new Node(j));
                arr.Add(j);
            }

            auto s1 = high_resolution_clock::now();
            list.AddToEnd(new Node(-1));
            auto e1 = high_resolution_clock::now();
            listTotal += duration<double, std::micro>(e1 - s1).count();

            auto s2 = high_resolution_clock::now();
            arr.Add(-1);
            auto e2 = high_resolution_clock::now();
            arrTotal += duration<double, std::micro>(e2 - s2).count();
        }

        results[i] = { size, listTotal / iters, arrTotal / iters };
        std::cout << "Insert end - Size: " << size
            << " - List: " << results[i].listTime
            << " us, Array: " << results[i].arrayTime << " us\n";
    }
    return count;
}

// ---------- ÒÅÑÒ ÂÑÒÀÂÊÈ Â ÑÅÐÅÄÈÍÓ ----------
int PerformanceTester::MeasureInsertAtMiddle(const int* sizes, int count, MeasureResult* results) {
    using namespace std::chrono;

    for (int i = 0; i < count; i++) {
        int size = sizes[i];
        int iters = GetIterationsForSize(size);
        int mid = size / 2;

        double listTotal = 0, arrTotal = 0;

        for (int it = 0; it < iters; it++) {
            List list;
            DynamicArray arr;

            for (int j = 0; j < size; j++) {
                list.AddToEnd(new Node(j));
                arr.Add(j);
            }

            auto s1 = high_resolution_clock::now();
            list.AddNode(new Node(-1), mid);
            auto e1 = high_resolution_clock::now();
            listTotal += duration<double, std::micro>(e1 - s1).count();

            auto s2 = high_resolution_clock::now();
            arr.Insert(mid, -1);
            auto e2 = high_resolution_clock::now();
            arrTotal += duration<double, std::micro>(e2 - s2).count();
        }

        results[i] = { size, listTotal / iters, arrTotal / iters };
        std::cout << "Insert middle - Size: " << size
            << " - List: " << results[i].listTime
            << " us, Array: " << results[i].arrayTime << " us\n";
    }
    return count;
}

// ---------- ÓÄÀËÅÍÈÅ ÈÇ ÍÀ×ÀËÀ ----------
int PerformanceTester::MeasureRemoveFromBeginning(const int* sizes, int count, MeasureResult* results) {
    using namespace std::chrono;

    for (int i = 0; i < count; i++) {
        int size = sizes[i];
        int iters = GetIterationsForSize(size);

        double listTotal = 0, arrTotal = 0;

        for (int it = 0; it < iters; it++) {
            List list;
            DynamicArray arr;

            for (int j = 0; j < size; j++) {
                list.AddToEnd(new Node(j));
                arr.Add(j);
            }

            auto s1 = high_resolution_clock::now();
            list.RemoveNodeByIndex(0);
            auto e1 = high_resolution_clock::now();
            listTotal += duration<double, std::micro>(e1 - s1).count();

            auto s2 = high_resolution_clock::now();
            arr.Remove(0);
            auto e2 = high_resolution_clock::now();
            arrTotal += duration<double, std::micro>(e2 - s2).count();
        }

        results[i] = { size, listTotal / iters, arrTotal / iters };
        std::cout << "Remove begin - Size: " << size
            << " - List: " << results[i].listTime
            << " us, Array: " << results[i].arrayTime << " us\n";
    }
    return count;
}

// ---------- ÓÄÀËÅÍÈÅ Ñ ÊÎÍÖÀ ----------
int PerformanceTester::MeasureRemoveFromEnd(const int* sizes, int count, MeasureResult* results) {
    using namespace std::chrono;

    for (int i = 0; i < count; i++) {
        int size = sizes[i];
        int iters = GetIterationsForSize(size);

        double listTotal = 0, arrTotal = 0;

        for (int it = 0; it < iters; it++) {
            List list;
            DynamicArray arr;

            for (int j = 0; j < size; j++) {
                list.AddToEnd(new Node(j));
                arr.Add(j);
            }

            auto s1 = high_resolution_clock::now();
            list.RemoveNodeByIndex(list.GetSize() - 1);
            auto e1 = high_resolution_clock::now();
            listTotal += duration<double, std::micro>(e1 - s1).count();

            auto s2 = high_resolution_clock::now();
            arr.Remove(arr.GetSize() - 1);
            auto e2 = high_resolution_clock::now();
            arrTotal += duration<double, std::micro>(e2 - s2).count();
        }

        results[i] = { size, listTotal / iters, arrTotal / iters };
        std::cout << "Remove end - Size: " << size
            << " - List: " << results[i].listTime
            << " us, Array: " << results[i].arrayTime << " us\n";
    }
    return count;
}

// ---------- ÓÄÀËÅÍÈÅ ÈÇ ÑÅÐÅÄÈÍÛ ----------
int PerformanceTester::MeasureRemoveFromMiddle(const int* sizes, int count, MeasureResult* results) {
    using namespace std::chrono;

    for (int i = 0; i < count; i++) {
        int size = sizes[i];
        int iters = GetIterationsForSize(size);

        double listTotal = 0, arrTotal = 0;

        for (int it = 0; it < iters; it++) {
            List list;
            DynamicArray arr;

            for (int j = 0; j < size; j++) {
                list.AddToEnd(new Node(j));
                arr.Add(j);
            }

            int mid = size / 2;

            auto s1 = high_resolution_clock::now();
            list.RemoveNodeByIndex(mid);
            auto e1 = high_resolution_clock::now();
            listTotal += duration<double, std::micro>(e1 - s1).count();

            auto s2 = high_resolution_clock::now();
            arr.Remove(mid);
            auto e2 = high_resolution_clock::now();
            arrTotal += duration<double, std::micro>(e2 - s2).count();
        }

        results[i] = { size, listTotal / iters, arrTotal / iters };
        std::cout << "Remove middle - Size: " << size
            << " - List: " << results[i].listTime
            << " us, Array: " << results[i].arrayTime << " us\n";
    }
    return count;
}

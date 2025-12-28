#pragma once
#ifndef KEYVALUEPAIR_H
#define KEYVALUEPAIR_H

#include <string>

struct KeyValuePair {
    std::string key;
    std::string value;
    bool isDeleted;

    KeyValuePair() : key(""), value(""), isDeleted(false) {}
    KeyValuePair(const std::string& k, const std::string& v)
        : key(k), value(v), isDeleted(false) {}
};

#endif
#include "KeyValuePair.h"

KeyValuePair::KeyValuePair(const std::string& key, const std::string& value)
    : _key(key), _value(value)
{
}

std::string KeyValuePair::GetKey() const
{
    return _key;
}

std::string KeyValuePair::GetValue() const
{
    return _value;
}

void KeyValuePair::SetValue(const std::string& value)
{
    _value = value;
}
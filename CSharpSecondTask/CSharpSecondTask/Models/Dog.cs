﻿using System;
using System.Collections.Generic;
using System.Windows;

public class Dog : Animal
{
    protected double _maxSpeed = 30.0;

    protected double _speed = 0;

    public override string Stay()
    {
        if (_speed == 0) return "Dog stopped";

        _speed -= _maxSpeed / 3;
        if (_speed < 0) _speed = 0;
        return $"Dog speed = {_speed.ToString()}";
    }

    public override string Go()
    {
        if (_speed == _maxSpeed) return "Dog running";

        _speed += _maxSpeed / 3;
        if (_speed > _maxSpeed) _speed = _maxSpeed;
        return $"Dog speed = {_speed.ToString()}";
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetMaxSpeed()
    {
        return _maxSpeed;
    }

    public override string jump()
    {
        return "Cant jump on tree";
    }
}
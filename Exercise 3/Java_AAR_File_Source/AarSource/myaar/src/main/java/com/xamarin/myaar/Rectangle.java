package com.xamarin.myaar;

public class Rectangle
{
  private double width;
  private double height;
  private int    color;

  public double getWidth() { return width; }
  public void setWidth(double width) { this.width = width; }

  public double getArea() { return width * height; }

  public void setColor(int color) { this.color = color; }
}
public class Rectangle{
 public double length;
 public double width;
}

public class Circle{
 public double radius; 
}

public class AreaCalculator{
  public double calculateRectangleArea(Rectangle rectangle){
    return rectangle.length *rectangle.width;
  }
  public double calculateCircleArea(Circle circle){
    return (22/7)*circle.radius*circle.radius;
  } 
}
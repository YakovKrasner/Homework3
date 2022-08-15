Console.Write ("Введите координату Х для точки А ");
double coordinate_x_for_A = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите координату Y для точки A ");
double coordinate_y_for_A = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите координату Z для точки А ");
double coordinate_z_for_A = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите координату Х для точки B ");
double coordinate_x_for_B = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите координату Y для точки B ");
double coordinate_y_for_B = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите координату Z для точки B ");
double coordinate_z_for_B = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Расстояние между точками равно " + Math.Sqrt (Math.Pow((coordinate_x_for_B - coordinate_x_for_A), 2) + Math.Pow((coordinate_y_for_B - coordinate_y_for_A), 2) + Math.Pow((coordinate_z_for_B - coordinate_z_for_A), 2)));
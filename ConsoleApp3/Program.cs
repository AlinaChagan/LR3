/* задание: 
 Создать класс типа - Прямоугольник. Поля - высота и 
ширина. Методы вычисления площади, периметра, 
Свойства должны проверять корректность задаваемых 
параметров.
Создать массив объектов. Вывести:
a) количество четырехугольников разного типа (квадрат, 
прямоугольник, ромб, произвольный)
b) определить для каждой группы наибольший и наименьший 
по площади (периметру) объект.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

;using namespace std;
const unsigned int SIZE = 10;

int _tmain(int argc, _TCHAR* argv[])
{
	srand(time(0));
	setlocale(LC_ALL, "Rus");
	rectangle Rect[SIZE];
	for (int i = 0; i < SIZE; i++)
	{
		Rect[i].print();
	}
	cout << "Число квадратов=";
	int count = 0, maxSs = 0, maxSp = 0, maxPp = 0, maxPs = 0,
		number = 0, number1 = 0, number2 = 0, number3 = 0;
	for (int i = 0; i < SIZE; i++)
	{
		if (Rect[i].Type() == 0)
		{
			count++;
			if (maxSs < Rect[i].S())
			{
				maxSs = Rect[i].S();
				number = i;
			}

			if (maxSp < Rect[i].P())
			{
				maxSp = Rect[i].P();
				number1 = i;
			}
		}
		else
		{
			if (maxPs < Rect[i].S())
			{
				maxPs = Rect[i].S();
				number2 = i;
			}

			if (maxPp < Rect[i].P())
			{
				maxPp = Rect[i].P();
				number3 = i;
			}
		}
	}
	cout << count << endl;
	cout << "Количество прямоугольников=" << SIZE - count << endl;
	if (count > 0)
	{
		cout << "Максимальная площадь квадрата=" << maxSs << endl;
		Rect[number].print();
		cout << "Максимальный периметр квадрата=" << maxSp << endl;
		Rect[number1].print();
	}
	if (count != SIZE)
	{
		cout << "Максимальная площадь прямоугольника=" << maxPs << endl;
		Rect[number2].print();
		cout << "Максимальный периметр прямоугольника=" << maxPp << endl;
		Rect[number3].print();
	}
	return 0;
}

/* {
	width = rand() % 10 + 1;
	height = rand() % 10 + 1;
}
rectangle::rectangle(double width_, double height_)

{
	width = width_;
	height = height_;
}
rectangle::~rectangle()
{

}
double rectangle::S()
{
	return width * height;
}
double rectangle::P()
{
	return 2 * (width + height);
}
int rectangle::Type()
{
	return (width == height) ? 0 : 1;
}
void rectangle::print()
{
	std::cout << width << ":" << height << std::endl;
}
void rectangle::Setheight(double hei)
{
	if (height > 0) height = hei;
}
void rectangle::Setwidth(double wi)
{
	if (width > 0) width = wi;
}
double rectangle::Getheight()
{
	return height;
}
double rectangle::Getwidth()
{
	return width;
}
rectangle::rectangle( const rectangle &m)
{
	width = m.width;
	height = m.height;
}*/








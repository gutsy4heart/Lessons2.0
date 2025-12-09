//#include<iostream>
//#include<ctime>
//
//using namespace std;
//
//int main()
//{
//	srand(time(0)); // bez neqo noviye chisla ne budut
//	setlocale(LC_ALL, "Rus");
//	int playAgain;
//
//	do
//	{
//				// (max - min + 1) + min
//				// -40 do 40 -> (40 + 40 + 1) - 40
//		int secret = rand() % 100 + 1;
//		int guess;
//		int attempts = 0;
//
//		cout << "#####УГАДАЙ ЧИСЛО#####" << endl;
//
//		cout << "Я задагал число от 1 до 100. Попробуй угадать! " << endl;
//		do
//		{
//			cout << "Введите число: ";
//			cin >> guess;
//			attempts++;
//			if (guess > secret) {
//				cout << "Мое число меньше)" << endl;
//			}
//			else if (guess < secret) {
//				cout << "Мое число больше XD" << endl;
//			}
//			else {
//				cout << "Поздравляю! Ты угадал число " << secret 
//					<< " за " << attempts << " попыток!" << endl;
//			}
//		} 
//		while (guess != secret);
//	cout << "Хотите сыграть еще?(1 - да, 0 - нет): ";
//	cin >> playAgain;
//	} 
//	while (playAgain == 1);
//
//	cout << "Paldies Visu labu!" << endl;
//}
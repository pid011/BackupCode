using System;

namespace HelloWorld {
	class Program {
		static void Main(string[] args) {
			int[] numbers = { 1023, 1023, 1034, 1087 };

			bool result = !(numbers[0] > numbers[2]) && numbers[0] == numbers[1] && numbers[1] <= numbers[3];

			if (result) {
				Console.WriteLine("맞습니다");
			} else {
				Console.WriteLine("틀립니다");
			}
			//----디버그 모드에서 창이 바로 닫히는 문제를 위한 코드----
			Console.ReadKey();
		}
	}
}
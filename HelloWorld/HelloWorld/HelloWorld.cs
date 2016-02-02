using System;

namespace HelloWorld {
	class Program {
		static void Main(string[] args) {
			int[] numbers = { 1023, 1023, 1034, 1087, 2034, 1111 };

			bool result = !(numbers[2] < numbers[3]) && numbers[1] == numbers[0];

			if (result) {
				Console.WriteLine("같습니다");
			} else {
				Console.WriteLine("틀립니다");
			}
		}
	}
}
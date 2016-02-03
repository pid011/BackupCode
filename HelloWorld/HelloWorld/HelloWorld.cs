using System;

namespace HelloWorld {
	class Program {
		static void Main(string[] args) {
			int num = 4;
			string result = (num % 2 == 0) ? "even number" : "odd number";
			Console.WriteLine(result);
			//----디버그 모드에서 창이 바로 닫히는 문제를 위한 코드----
			Console.ReadKey();
		}
	}
}
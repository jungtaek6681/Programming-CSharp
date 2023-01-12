using System;		// 이 파일의 이후 코드부터 네임스페이스에서 정의된 식별자를 사용

// <네임스페이스>
// 내부 식별자(형식, 함수, 변수 등의 이름)에 범위를 제공하는 선언적 영역
// 같은 이름의 식별자라 하더라도 다른 네임스페이스에 있다면 다른 클래스로 인식
// 여러 라이브러리가 포함된 경우, 협업하는 과정에서 네이밍룰 등으로 이름 충돌을 방지하는데 사용

namespace _08._OOP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("System.Console 사용");
			System.Console.WriteLine("System.Console 사용");      // 코드 상단의 using을 통해 자주사용하는 네임스페이스는 생략가능
			OtherCompany.Console.Test();		// 동일한 클래스이름이지만 네임스페이스로 구분
		}
	}
}

namespace OtherCompany
{
	// 동일한 클래스 이름이 있지만 충돌하지 않음
	public class Console
	{
		public static void Test()
		{
			System.Console.WriteLine("OtherCompany.Console에서 System.Console 사용");
		}
	}
}
using System;
namespace DistanceConverter
{
	//距離計算ロジックをクラスとして分離
	//FeetConverter内のメソッドは引数によって飲み戻り値決まるので静的メソッドのみ
	//そのためクラス自体を静的クラスとして定義する
	public static class FeetConverter
	{
		//リテラルで使用している「0.3048」を定数定義して意味をもつ値にする
		private const double RATIO = 0.3048;

		public static double FromMeter(double meter)
		{
			return meter / RATIO;
		}

		public static double ToMeter(double feet)
		{
			return feet * RATIO;
		}
	}
}


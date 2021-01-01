using System;
using System.Collections.Generic;
using System.Text;

namespace Beautiful
{

	public class CrystalStatus 
	{
		public bool Generated { get; set; }
		public bool Rotated { get; set; }
		public bool Penetrated { get; set; }
		public bool Entertained { get; set; }
		public bool ComplexityInfo { get; set; }
	}
	public class Master : CrystalStatus
	{
		//public Beautiful RoleType { get; set; }
		public CrystalStatus Status { get; set; }
	}

	public class DimensionInfo
	{
		///<summary>
		///点 起源??
		///一维是线
		///二维是平面
		///三维是立体
		///一维、二维、三维均只存在思维里作为变动量使用。
		///宇宙一切物质均基于四维时空。
		///四维、五维、六维主要运用于物体定义与历史变化。
		///七维、八维、九维、十维主要运用于空间定义与历史变化。
		/// </summary>
		public short Type { get; set; }
		/// <summary>
		/// 1.Brain system, heart,underbody,neural system and the influence parallelly
		/// 0=Human being on earth currently
		/// For examples;
		/// Alien1 100.0000- 200.00000
		/// Alien2 200.0000- 500.00000
		/// Alien3 300.0000- 600.00000
		/// </summary>
		public decimal TurnRatio { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public decimal TimeRatio { get; set; }
	}
	public class SymbolInfo
	{
		public long ID { get; set; } = 0;
		public string Name { get; set; }
	}

   
}
//[[[[[asdfsdf[]]asdfsdfkjsdfkjdslfds[asdfsdfsdf]asdfsadffd[(sfsfdds>][
//asdf
//    asdf
//    asdf
//阿斯蒂芬
//    阿斯蒂芬
//    阿斯蒂芬
//        阿斯蒂芬
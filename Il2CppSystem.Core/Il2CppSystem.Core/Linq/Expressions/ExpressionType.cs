using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000047 RID: 71
	[OriginalName("System.Core.dll", "System.Linq.Expressions", "ExpressionType")]
	public enum ExpressionType
	{
		// Token: 0x04000375 RID: 885
		Add,
		// Token: 0x04000376 RID: 886
		AddChecked,
		// Token: 0x04000377 RID: 887
		And,
		// Token: 0x04000378 RID: 888
		AndAlso,
		// Token: 0x04000379 RID: 889
		ArrayLength,
		// Token: 0x0400037A RID: 890
		ArrayIndex,
		// Token: 0x0400037B RID: 891
		Call,
		// Token: 0x0400037C RID: 892
		Coalesce,
		// Token: 0x0400037D RID: 893
		Conditional,
		// Token: 0x0400037E RID: 894
		Constant,
		// Token: 0x0400037F RID: 895
		Convert,
		// Token: 0x04000380 RID: 896
		ConvertChecked,
		// Token: 0x04000381 RID: 897
		Divide,
		// Token: 0x04000382 RID: 898
		Equal,
		// Token: 0x04000383 RID: 899
		ExclusiveOr,
		// Token: 0x04000384 RID: 900
		GreaterThan,
		// Token: 0x04000385 RID: 901
		GreaterThanOrEqual,
		// Token: 0x04000386 RID: 902
		Invoke,
		// Token: 0x04000387 RID: 903
		Lambda,
		// Token: 0x04000388 RID: 904
		LeftShift,
		// Token: 0x04000389 RID: 905
		LessThan,
		// Token: 0x0400038A RID: 906
		LessThanOrEqual,
		// Token: 0x0400038B RID: 907
		ListInit,
		// Token: 0x0400038C RID: 908
		MemberAccess,
		// Token: 0x0400038D RID: 909
		MemberInit,
		// Token: 0x0400038E RID: 910
		Modulo,
		// Token: 0x0400038F RID: 911
		Multiply,
		// Token: 0x04000390 RID: 912
		MultiplyChecked,
		// Token: 0x04000391 RID: 913
		Negate,
		// Token: 0x04000392 RID: 914
		UnaryPlus,
		// Token: 0x04000393 RID: 915
		NegateChecked,
		// Token: 0x04000394 RID: 916
		New,
		// Token: 0x04000395 RID: 917
		NewArrayInit,
		// Token: 0x04000396 RID: 918
		NewArrayBounds,
		// Token: 0x04000397 RID: 919
		Not,
		// Token: 0x04000398 RID: 920
		NotEqual,
		// Token: 0x04000399 RID: 921
		Or,
		// Token: 0x0400039A RID: 922
		OrElse,
		// Token: 0x0400039B RID: 923
		Parameter,
		// Token: 0x0400039C RID: 924
		Power,
		// Token: 0x0400039D RID: 925
		Quote,
		// Token: 0x0400039E RID: 926
		RightShift,
		// Token: 0x0400039F RID: 927
		Subtract,
		// Token: 0x040003A0 RID: 928
		SubtractChecked,
		// Token: 0x040003A1 RID: 929
		TypeAs,
		// Token: 0x040003A2 RID: 930
		TypeIs,
		// Token: 0x040003A3 RID: 931
		Assign,
		// Token: 0x040003A4 RID: 932
		Block,
		// Token: 0x040003A5 RID: 933
		DebugInfo,
		// Token: 0x040003A6 RID: 934
		Decrement,
		// Token: 0x040003A7 RID: 935
		Dynamic,
		// Token: 0x040003A8 RID: 936
		Default,
		// Token: 0x040003A9 RID: 937
		Extension,
		// Token: 0x040003AA RID: 938
		Goto,
		// Token: 0x040003AB RID: 939
		Increment,
		// Token: 0x040003AC RID: 940
		Index,
		// Token: 0x040003AD RID: 941
		Label,
		// Token: 0x040003AE RID: 942
		RuntimeVariables,
		// Token: 0x040003AF RID: 943
		Loop,
		// Token: 0x040003B0 RID: 944
		Switch,
		// Token: 0x040003B1 RID: 945
		Throw,
		// Token: 0x040003B2 RID: 946
		Try,
		// Token: 0x040003B3 RID: 947
		Unbox,
		// Token: 0x040003B4 RID: 948
		AddAssign,
		// Token: 0x040003B5 RID: 949
		AndAssign,
		// Token: 0x040003B6 RID: 950
		DivideAssign,
		// Token: 0x040003B7 RID: 951
		ExclusiveOrAssign,
		// Token: 0x040003B8 RID: 952
		LeftShiftAssign,
		// Token: 0x040003B9 RID: 953
		ModuloAssign,
		// Token: 0x040003BA RID: 954
		MultiplyAssign,
		// Token: 0x040003BB RID: 955
		OrAssign,
		// Token: 0x040003BC RID: 956
		PowerAssign,
		// Token: 0x040003BD RID: 957
		RightShiftAssign,
		// Token: 0x040003BE RID: 958
		SubtractAssign,
		// Token: 0x040003BF RID: 959
		AddAssignChecked,
		// Token: 0x040003C0 RID: 960
		MultiplyAssignChecked,
		// Token: 0x040003C1 RID: 961
		SubtractAssignChecked,
		// Token: 0x040003C2 RID: 962
		PreIncrementAssign,
		// Token: 0x040003C3 RID: 963
		PreDecrementAssign,
		// Token: 0x040003C4 RID: 964
		PostIncrementAssign,
		// Token: 0x040003C5 RID: 965
		PostDecrementAssign,
		// Token: 0x040003C6 RID: 966
		TypeEqual,
		// Token: 0x040003C7 RID: 967
		OnesComplement,
		// Token: 0x040003C8 RID: 968
		IsTrue,
		// Token: 0x040003C9 RID: 969
		IsFalse
	}
}

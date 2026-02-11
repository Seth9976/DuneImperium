using System;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000D3 RID: 211
	public enum QueryOperator
	{
		// Token: 0x04000FAD RID: 4013
		None,
		// Token: 0x04000FAE RID: 4014
		Equals,
		// Token: 0x04000FAF RID: 4015
		NotEquals,
		// Token: 0x04000FB0 RID: 4016
		Exists,
		// Token: 0x04000FB1 RID: 4017
		LessThan,
		// Token: 0x04000FB2 RID: 4018
		LessThanOrEquals,
		// Token: 0x04000FB3 RID: 4019
		GreaterThan,
		// Token: 0x04000FB4 RID: 4020
		GreaterThanOrEquals,
		// Token: 0x04000FB5 RID: 4021
		And,
		// Token: 0x04000FB6 RID: 4022
		Or,
		// Token: 0x04000FB7 RID: 4023
		RegexEquals,
		// Token: 0x04000FB8 RID: 4024
		StrictEquals,
		// Token: 0x04000FB9 RID: 4025
		StrictNotEquals
	}
}

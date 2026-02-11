using System;

namespace Steamworks
{
	// Token: 0x02000087 RID: 135
	public enum NetIdentityType
	{
		// Token: 0x04000EAC RID: 3756
		Invalid,
		// Token: 0x04000EAD RID: 3757
		SteamID = 16,
		// Token: 0x04000EAE RID: 3758
		XboxPairwiseID,
		// Token: 0x04000EAF RID: 3759
		SonyPSN,
		// Token: 0x04000EB0 RID: 3760
		GoogleStadia,
		// Token: 0x04000EB1 RID: 3761
		IPAddress = 1,
		// Token: 0x04000EB2 RID: 3762
		GenericString,
		// Token: 0x04000EB3 RID: 3763
		GenericBytes,
		// Token: 0x04000EB4 RID: 3764
		UnknownType,
		// Token: 0x04000EB5 RID: 3765
		Force32bit = 2147483647
	}
}

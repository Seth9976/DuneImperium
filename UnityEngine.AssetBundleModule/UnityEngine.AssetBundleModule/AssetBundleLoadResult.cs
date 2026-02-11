using System;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	public enum AssetBundleLoadResult
	{
		// Token: 0x04000039 RID: 57
		Success,
		// Token: 0x0400003A RID: 58
		Cancelled,
		// Token: 0x0400003B RID: 59
		NotMatchingCrc,
		// Token: 0x0400003C RID: 60
		FailedCache,
		// Token: 0x0400003D RID: 61
		NotValidAssetBundle,
		// Token: 0x0400003E RID: 62
		NoSerializedData,
		// Token: 0x0400003F RID: 63
		NotCompatible,
		// Token: 0x04000040 RID: 64
		AlreadyLoaded,
		// Token: 0x04000041 RID: 65
		FailedRead,
		// Token: 0x04000042 RID: 66
		FailedDecompression,
		// Token: 0x04000043 RID: 67
		FailedWrite,
		// Token: 0x04000044 RID: 68
		FailedDeleteRecompressionTarget,
		// Token: 0x04000045 RID: 69
		RecompressionTargetIsLoaded,
		// Token: 0x04000046 RID: 70
		RecompressionTargetExistsButNotArchive
	}
}

using System;

namespace UnityEngine.Localization.Metadata
{
	// Token: 0x020000CD RID: 205
	[Flags]
	public enum MetadataType
	{
		// Token: 0x0400077F RID: 1919
		Locale = 1,
		// Token: 0x04000780 RID: 1920
		SharedTableData = 2,
		// Token: 0x04000781 RID: 1921
		StringTable = 4,
		// Token: 0x04000782 RID: 1922
		AssetTable = 8,
		// Token: 0x04000783 RID: 1923
		StringTableEntry = 16,
		// Token: 0x04000784 RID: 1924
		AssetTableEntry = 32,
		// Token: 0x04000785 RID: 1925
		SharedStringTableEntry = 64,
		// Token: 0x04000786 RID: 1926
		SharedAssetTableEntry = 128,
		// Token: 0x04000787 RID: 1927
		LocalizationSettings = 256,
		// Token: 0x04000788 RID: 1928
		AllTables = 12,
		// Token: 0x04000789 RID: 1929
		AllTableEntries = 48,
		// Token: 0x0400078A RID: 1930
		AllSharedTableEntries = 192,
		// Token: 0x0400078B RID: 1931
		All = 63
	}
}

using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	[Serializable]
	public static class AssetBundleLoadingCache
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00002116 File Offset: 0x00000316
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002122 File Offset: 0x00000322
		public static uint maxBlocksPerFile
		{
			get
			{
				return AssetBundleLoadingCache.get_maxBlocksPerFileDelegateField();
			}
			set
			{
				AssetBundleLoadingCache.set_maxBlocksPerFileDelegateField(value);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0000212F File Offset: 0x0000032F
		// (set) Token: 0x06000069 RID: 105 RVA: 0x0000213B File Offset: 0x0000033B
		public static uint blockCount
		{
			get
			{
				return AssetBundleLoadingCache.get_blockCountDelegateField();
			}
			set
			{
				AssetBundleLoadingCache.set_blockCountDelegateField(value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00002148 File Offset: 0x00000348
		public static uint blockSize
		{
			get
			{
				return AssetBundleLoadingCache.get_blockSizeDelegateField();
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000037C8 File Offset: 0x000019C8
		// (set) Token: 0x0600006C RID: 108 RVA: 0x000037E8 File Offset: 0x000019E8
		public static uint memoryBudgetKB
		{
			get
			{
				return AssetBundleLoadingCache.blockCount * AssetBundleLoadingCache.blockSize;
			}
			set
			{
				uint num = Math.Max(value / AssetBundleLoadingCache.blockSize, 2U);
				uint num2 = Math.Max(AssetBundleLoadingCache.blockCount / 4U, 2U);
				bool flag = num != AssetBundleLoadingCache.blockCount || num2 != AssetBundleLoadingCache.maxBlocksPerFile;
				if (flag)
				{
					AssetBundleLoadingCache.blockCount = num;
					AssetBundleLoadingCache.maxBlocksPerFile = num2;
				}
			}
		}

		// Token: 0x04000047 RID: 71
		public const int kMinAllowedBlockCount = 2;

		// Token: 0x04000048 RID: 72
		public const int kMinAllowedMaxBlocksPerFile = 2;

		// Token: 0x04000049 RID: 73
		private static readonly AssetBundleLoadingCache.get_maxBlocksPerFileDelegate get_maxBlocksPerFileDelegateField = IL2CPP.ResolveICall<AssetBundleLoadingCache.get_maxBlocksPerFileDelegate>("UnityEngine.AssetBundleLoadingCache::get_maxBlocksPerFile");

		// Token: 0x0400004A RID: 74
		private static readonly AssetBundleLoadingCache.set_maxBlocksPerFileDelegate set_maxBlocksPerFileDelegateField = IL2CPP.ResolveICall<AssetBundleLoadingCache.set_maxBlocksPerFileDelegate>("UnityEngine.AssetBundleLoadingCache::set_maxBlocksPerFile");

		// Token: 0x0400004B RID: 75
		private static readonly AssetBundleLoadingCache.get_blockCountDelegate get_blockCountDelegateField = IL2CPP.ResolveICall<AssetBundleLoadingCache.get_blockCountDelegate>("UnityEngine.AssetBundleLoadingCache::get_blockCount");

		// Token: 0x0400004C RID: 76
		private static readonly AssetBundleLoadingCache.set_blockCountDelegate set_blockCountDelegateField = IL2CPP.ResolveICall<AssetBundleLoadingCache.set_blockCountDelegate>("UnityEngine.AssetBundleLoadingCache::set_blockCount");

		// Token: 0x0400004D RID: 77
		private static readonly AssetBundleLoadingCache.get_blockSizeDelegate get_blockSizeDelegateField = IL2CPP.ResolveICall<AssetBundleLoadingCache.get_blockSizeDelegate>("UnityEngine.AssetBundleLoadingCache::get_blockSize");

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x06000098 RID: 152
		private delegate uint get_maxBlocksPerFileDelegate();

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x0600009A RID: 154
		private delegate void set_maxBlocksPerFileDelegate(uint value);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x0600009C RID: 156
		private delegate uint get_blockCountDelegate();

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x0600009E RID: 158
		private delegate void set_blockCountDelegate(uint value);

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x060000A0 RID: 160
		private delegate uint get_blockSizeDelegate();
	}
}

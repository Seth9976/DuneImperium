using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Android
{
	// Token: 0x02000018 RID: 24
	public static class AndroidAssetPacks
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0000BC64 File Offset: 0x00009E64
		public static bool coreUnityAssetPacksDownloaded
		{
			get
			{
				return AndroidAssetPacks.CoreUnityAssetPacksDownloaded();
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0000BC7C File Offset: 0x00009E7C
		public static string dataPackName
		{
			get
			{
				return AndroidAssetPacks.GetDataPackName();
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0000BC94 File Offset: 0x00009E94
		public static string streamingAssetsPackName
		{
			get
			{
				return AndroidAssetPacks.GetStreamingAssetsPackName();
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002C1E File Offset: 0x00000E1E
		public static bool CoreUnityAssetPacksDownloaded()
		{
			return AndroidAssetPacks.CoreUnityAssetPacksDownloadedDelegateField();
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000BCAC File Offset: 0x00009EAC
		public static Il2CppStringArray GetCoreUnityAssetPackNames()
		{
			return new Il2CppStringArray(0L);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002C2A File Offset: 0x00000E2A
		public static void GetAssetPackStateAsync(Il2CppStringArray assetPackNames, Action<ulong, Il2CppReferenceArray<AndroidAssetPackState>> callback)
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000BCC8 File Offset: 0x00009EC8
		public static GetAssetPackStateAsyncOperation GetAssetPackStateAsync(Il2CppStringArray assetPackNames)
		{
			return null;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002C2D File Offset: 0x00000E2D
		public static void DownloadAssetPackAsync(Il2CppStringArray assetPackNames, Action<AndroidAssetPackInfo> callback)
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000BCDC File Offset: 0x00009EDC
		public static DownloadAssetPackAsyncOperation DownloadAssetPackAsync(Il2CppStringArray assetPackNames)
		{
			return null;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002C30 File Offset: 0x00000E30
		public static void RequestToUseMobileDataAsync(Action<AndroidAssetPackUseMobileDataRequestResult> callback)
		{
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000BCF0 File Offset: 0x00009EF0
		public static RequestToUseMobileDataAsyncOperation RequestToUseMobileDataAsync()
		{
			return null;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000BD04 File Offset: 0x00009F04
		public static string GetAssetPackPath(string assetPackName)
		{
			return "";
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002C33 File Offset: 0x00000E33
		public static void CancelAssetPackDownload(Il2CppStringArray assetPackNames)
		{
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002C36 File Offset: 0x00000E36
		public static void RemoveAssetPack(string assetPackName)
		{
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000BD1C File Offset: 0x00009F1C
		public static string GetDataPackName()
		{
			return "UnityDataAssetPack";
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000BD34 File Offset: 0x00009F34
		public static string GetStreamingAssetsPackName()
		{
			return "UnityStreamingAssetsPack";
		}

		// Token: 0x0400018B RID: 395
		private static readonly AndroidAssetPacks.CoreUnityAssetPacksDownloadedDelegate CoreUnityAssetPacksDownloadedDelegateField = IL2CPP.ResolveICall<AndroidAssetPacks.CoreUnityAssetPacksDownloadedDelegate>("UnityEngine.Android.AndroidAssetPacks::CoreUnityAssetPacksDownloaded");

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x06000368 RID: 872
		private delegate bool CoreUnityAssetPacksDownloadedDelegate();
	}
}

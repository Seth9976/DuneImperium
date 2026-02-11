using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.VirtualTexturing
{
	// Token: 0x02000007 RID: 7
	public static class Streaming
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00002281 File Offset: 0x00000481
		public static void RequestRegion(Material mat, int stackNameId, Rect r, int mipMap, int numMips)
		{
			Streaming.RequestRegion_Injected(mat, stackNameId, ref r, mipMap, numMips);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000228F File Offset: 0x0000048F
		public static void GetTextureStackSize(Material mat, int stackNameId, out int width, out int height)
		{
			Streaming.GetTextureStackSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mat), stackNameId, out width, out height);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000022A4 File Offset: 0x000004A4
		public static void SetCPUCacheSize(int sizeInMegabytes)
		{
			Streaming.SetCPUCacheSizeDelegateField(sizeInMegabytes);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000022B1 File Offset: 0x000004B1
		public static int GetCPUCacheSize()
		{
			return Streaming.GetCPUCacheSizeDelegateField();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000022BD File Offset: 0x000004BD
		public static void EnableMipPreloading(int texturesPerFrame, int mipCount)
		{
			Streaming.EnableMipPreloadingDelegateField(texturesPerFrame, mipCount);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000022CB File Offset: 0x000004CB
		public static void RequestRegion_Injected(Material mat, int stackNameId, ref Rect r, int mipMap, int numMips)
		{
			Streaming.RequestRegion_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mat), stackNameId, ref r, mipMap, numMips);
		}

		// Token: 0x04000019 RID: 25
		private static readonly Streaming.GetTextureStackSizeDelegate GetTextureStackSizeDelegateField = IL2CPP.ResolveICall<Streaming.GetTextureStackSizeDelegate>("UnityEngine.Rendering.VirtualTexturing.Streaming::GetTextureStackSize");

		// Token: 0x0400001A RID: 26
		private static readonly Streaming.SetCPUCacheSizeDelegate SetCPUCacheSizeDelegateField = IL2CPP.ResolveICall<Streaming.SetCPUCacheSizeDelegate>("UnityEngine.Rendering.VirtualTexturing.Streaming::SetCPUCacheSize");

		// Token: 0x0400001B RID: 27
		private static readonly Streaming.GetCPUCacheSizeDelegate GetCPUCacheSizeDelegateField = IL2CPP.ResolveICall<Streaming.GetCPUCacheSizeDelegate>("UnityEngine.Rendering.VirtualTexturing.Streaming::GetCPUCacheSize");

		// Token: 0x0400001C RID: 28
		private static readonly Streaming.EnableMipPreloadingDelegate EnableMipPreloadingDelegateField = IL2CPP.ResolveICall<Streaming.EnableMipPreloadingDelegate>("UnityEngine.Rendering.VirtualTexturing.Streaming::EnableMipPreloading");

		// Token: 0x0400001D RID: 29
		private static readonly Streaming.RequestRegion_InjectedDelegate RequestRegion_InjectedDelegateField = IL2CPP.ResolveICall<Streaming.RequestRegion_InjectedDelegate>("UnityEngine.Rendering.VirtualTexturing.Streaming::RequestRegion_Injected");

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x0600005D RID: 93
		private delegate void GetTextureStackSizeDelegate(IntPtr mat, int stackNameId, [Out] IntPtr width, [Out] IntPtr height);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x0600005F RID: 95
		private delegate void SetCPUCacheSizeDelegate(int sizeInMegabytes);

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x06000061 RID: 97
		private delegate int GetCPUCacheSizeDelegate();

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x06000063 RID: 99
		private delegate void EnableMipPreloadingDelegate(int texturesPerFrame, int mipCount);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x06000065 RID: 101
		private delegate void RequestRegion_InjectedDelegate(IntPtr mat, int stackNameId, IntPtr r, int mipMap, int numMips);
	}
}

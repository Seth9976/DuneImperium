using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.VirtualTexturing
{
	// Token: 0x02000008 RID: 8
	public static class Procedural
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00002320 File Offset: 0x00000520
		public static void SetDebugFlagInteger(Guid guid, long value)
		{
			UnityEngine.Rendering.VirtualTexturing.System.SetDebugFlagInteger(guid, value);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000232B File Offset: 0x0000052B
		public static void SetDebugFlagDouble(Guid guid, double value)
		{
			UnityEngine.Rendering.VirtualTexturing.System.SetDebugFlagDouble(guid, value);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002336 File Offset: 0x00000536
		public static void SetCPUCacheSize(int sizeInMegabytes)
		{
			Procedural.SetCPUCacheSizeDelegateField(sizeInMegabytes);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002343 File Offset: 0x00000543
		public static int GetCPUCacheSize()
		{
			return Procedural.GetCPUCacheSizeDelegateField();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000234F File Offset: 0x0000054F
		public static void SetGPUCacheStagingAreaCapacity(uint tilesPerFrame)
		{
			Procedural.SetGPUCacheStagingAreaCapacityDelegateField(tilesPerFrame);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000235C File Offset: 0x0000055C
		public static uint GetGPUCacheStagingAreaCapacity()
		{
			return Procedural.GetGPUCacheStagingAreaCapacityDelegateField();
		}

		// Token: 0x0400001E RID: 30
		private static readonly Procedural.SetCPUCacheSizeDelegate SetCPUCacheSizeDelegateField = IL2CPP.ResolveICall<Procedural.SetCPUCacheSizeDelegate>("UnityEngine.Rendering.VirtualTexturing.Procedural::SetCPUCacheSize");

		// Token: 0x0400001F RID: 31
		private static readonly Procedural.GetCPUCacheSizeDelegate GetCPUCacheSizeDelegateField = IL2CPP.ResolveICall<Procedural.GetCPUCacheSizeDelegate>("UnityEngine.Rendering.VirtualTexturing.Procedural::GetCPUCacheSize");

		// Token: 0x04000020 RID: 32
		private static readonly Procedural.SetGPUCacheStagingAreaCapacityDelegate SetGPUCacheStagingAreaCapacityDelegateField = IL2CPP.ResolveICall<Procedural.SetGPUCacheStagingAreaCapacityDelegate>("UnityEngine.Rendering.VirtualTexturing.Procedural::SetGPUCacheStagingAreaCapacity");

		// Token: 0x04000021 RID: 33
		private static readonly Procedural.GetGPUCacheStagingAreaCapacityDelegate GetGPUCacheStagingAreaCapacityDelegateField = IL2CPP.ResolveICall<Procedural.GetGPUCacheStagingAreaCapacityDelegate>("UnityEngine.Rendering.VirtualTexturing.Procedural::GetGPUCacheStagingAreaCapacity");

		// Token: 0x02000023 RID: 35
		public static class Binding
		{
		}

		// Token: 0x02000024 RID: 36
		public enum ProceduralTextureStackRequestStatus
		{
			// Token: 0x04000023 RID: 35
			StatusFree = 65535,
			// Token: 0x04000024 RID: 36
			StatusRequested,
			// Token: 0x04000025 RID: 37
			StatusProcessing,
			// Token: 0x04000026 RID: 38
			StatusComplete,
			// Token: 0x04000027 RID: 39
			StatusDropped
		}

		// Token: 0x02000025 RID: 37
		public enum RequestStatus
		{
			// Token: 0x04000029 RID: 41
			Dropped = 65539,
			// Token: 0x0400002A RID: 42
			Generated = 65538
		}

		// Token: 0x02000026 RID: 38
		public sealed class GPUTextureStack : Procedural.TextureStackBase<Procedural.GPUTextureStackRequestParameters>
		{
		}

		// Token: 0x02000027 RID: 39
		public sealed class CPUTextureStack : Procedural.TextureStackBase<Procedural.CPUTextureStackRequestParameters>
		{
		}

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x06000067 RID: 103
		private delegate void SetCPUCacheSizeDelegate(int sizeInMegabytes);

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x06000069 RID: 105
		private delegate int GetCPUCacheSizeDelegate();

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x0600006B RID: 107
		private delegate void SetGPUCacheStagingAreaCapacityDelegate(uint tilesPerFrame);

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x0600006D RID: 109
		private delegate uint GetGPUCacheStagingAreaCapacityDelegate();
	}
}

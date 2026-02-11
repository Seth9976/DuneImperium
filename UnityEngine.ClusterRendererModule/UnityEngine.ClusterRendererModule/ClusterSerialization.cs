using System;
using Il2CppInterop.Runtime;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public static class ClusterSerialization
	{
		// Token: 0x06000007 RID: 7 RVA: 0x0000217C File Offset: 0x0000037C
		public static int SaveTimeManagerState(NativeArray<byte> buffer)
		{
			return ClusterSerialization.SaveTimeManagerStateInternal(buffer.GetUnsafePtr<byte>(), buffer.Length);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000021A4 File Offset: 0x000003A4
		public static bool RestoreTimeManagerState(NativeArray<byte> buffer)
		{
			return ClusterSerialization.RestoreTimeManagerStateInternal(buffer.GetUnsafePtr<byte>(), buffer.Length);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000021CC File Offset: 0x000003CC
		public static int SaveInputManagerState(NativeArray<byte> buffer)
		{
			return ClusterSerialization.SaveInputManagerStateInternal(buffer.GetUnsafePtr<byte>(), buffer.Length);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000021F4 File Offset: 0x000003F4
		public static bool RestoreInputManagerState(NativeArray<byte> buffer)
		{
			return ClusterSerialization.RestoreInputManagerStateInternal(buffer.GetUnsafePtr<byte>(), buffer.Length);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000221C File Offset: 0x0000041C
		public static int SaveClusterInputState(NativeArray<byte> buffer)
		{
			return ClusterSerialization.SaveClusterInputStateInternal(buffer.GetUnsafePtr<byte>(), buffer.Length);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002244 File Offset: 0x00000444
		public static bool RestoreClusterInputState(NativeArray<byte> buffer)
		{
			return ClusterSerialization.RestoreClusterInputStateInternal(buffer.GetUnsafePtr<byte>(), buffer.Length);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020BF File Offset: 0x000002BF
		public unsafe static int SaveTimeManagerStateInternal(void* intBuffer, int bufferSize)
		{
			return ClusterSerialization.SaveTimeManagerStateInternalDelegateField(intBuffer, bufferSize);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020CD File Offset: 0x000002CD
		public unsafe static bool RestoreTimeManagerStateInternal(void* buffer, int bufferSize)
		{
			return ClusterSerialization.RestoreTimeManagerStateInternalDelegateField(buffer, bufferSize);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020DB File Offset: 0x000002DB
		public unsafe static int SaveInputManagerStateInternal(void* intBuffer, int bufferSize)
		{
			return ClusterSerialization.SaveInputManagerStateInternalDelegateField(intBuffer, bufferSize);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020E9 File Offset: 0x000002E9
		public unsafe static bool RestoreInputManagerStateInternal(void* buffer, int bufferSize)
		{
			return ClusterSerialization.RestoreInputManagerStateInternalDelegateField(buffer, bufferSize);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000020F7 File Offset: 0x000002F7
		public unsafe static int SaveClusterInputStateInternal(void* intBuffer, int bufferSize)
		{
			return ClusterSerialization.SaveClusterInputStateInternalDelegateField(intBuffer, bufferSize);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002105 File Offset: 0x00000305
		public unsafe static bool RestoreClusterInputStateInternal(void* buffer, int bufferSize)
		{
			return ClusterSerialization.RestoreClusterInputStateInternalDelegateField(buffer, bufferSize);
		}

		// Token: 0x04000005 RID: 5
		private static readonly ClusterSerialization.SaveTimeManagerStateInternalDelegate SaveTimeManagerStateInternalDelegateField = IL2CPP.ResolveICall<ClusterSerialization.SaveTimeManagerStateInternalDelegate>("UnityEngine.ClusterSerialization::SaveTimeManagerStateInternal");

		// Token: 0x04000006 RID: 6
		private static readonly ClusterSerialization.RestoreTimeManagerStateInternalDelegate RestoreTimeManagerStateInternalDelegateField = IL2CPP.ResolveICall<ClusterSerialization.RestoreTimeManagerStateInternalDelegate>("UnityEngine.ClusterSerialization::RestoreTimeManagerStateInternal");

		// Token: 0x04000007 RID: 7
		private static readonly ClusterSerialization.SaveInputManagerStateInternalDelegate SaveInputManagerStateInternalDelegateField = IL2CPP.ResolveICall<ClusterSerialization.SaveInputManagerStateInternalDelegate>("UnityEngine.ClusterSerialization::SaveInputManagerStateInternal");

		// Token: 0x04000008 RID: 8
		private static readonly ClusterSerialization.RestoreInputManagerStateInternalDelegate RestoreInputManagerStateInternalDelegateField = IL2CPP.ResolveICall<ClusterSerialization.RestoreInputManagerStateInternalDelegate>("UnityEngine.ClusterSerialization::RestoreInputManagerStateInternal");

		// Token: 0x04000009 RID: 9
		private static readonly ClusterSerialization.SaveClusterInputStateInternalDelegate SaveClusterInputStateInternalDelegateField = IL2CPP.ResolveICall<ClusterSerialization.SaveClusterInputStateInternalDelegate>("UnityEngine.ClusterSerialization::SaveClusterInputStateInternal");

		// Token: 0x0400000A RID: 10
		private static readonly ClusterSerialization.RestoreClusterInputStateInternalDelegate RestoreClusterInputStateInternalDelegateField = IL2CPP.ResolveICall<ClusterSerialization.RestoreClusterInputStateInternalDelegate>("UnityEngine.ClusterSerialization::RestoreClusterInputStateInternal");

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x0600001C RID: 28
		private delegate int SaveTimeManagerStateInternalDelegate(IntPtr intBuffer, int bufferSize);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x0600001E RID: 30
		private delegate bool RestoreTimeManagerStateInternalDelegate(IntPtr buffer, int bufferSize);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x06000020 RID: 32
		private delegate int SaveInputManagerStateInternalDelegate(IntPtr intBuffer, int bufferSize);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000022 RID: 34
		private delegate bool RestoreInputManagerStateInternalDelegate(IntPtr buffer, int bufferSize);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000024 RID: 36
		private delegate int SaveClusterInputStateInternalDelegate(IntPtr intBuffer, int bufferSize);

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x06000026 RID: 38
		private delegate bool RestoreClusterInputStateInternalDelegate(IntPtr buffer, int bufferSize);
	}
}

using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Animations
{
	// Token: 0x02000055 RID: 85
	public static class AnimationStreamHandleUtility
	{
		// Token: 0x060004F4 RID: 1268 RVA: 0x00003F6F File Offset: 0x0000216F
		public unsafe static void ReadStreamIntsInternal(ref AnimationStream stream, void* propertyStreamHandles, void* intBuffer, int count)
		{
			AnimationStreamHandleUtility.ReadStreamIntsInternalDelegateField(ref stream, propertyStreamHandles, intBuffer, count);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00003F7F File Offset: 0x0000217F
		public unsafe static void ReadStreamFloatsInternal(ref AnimationStream stream, void* propertyStreamHandles, void* floatBuffer, int count)
		{
			AnimationStreamHandleUtility.ReadStreamFloatsInternalDelegateField(ref stream, propertyStreamHandles, floatBuffer, count);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00003F8F File Offset: 0x0000218F
		public unsafe static void WriteStreamIntsInternal(ref AnimationStream stream, void* propertyStreamHandles, void* intBuffer, int count, bool useMask)
		{
			AnimationStreamHandleUtility.WriteStreamIntsInternalDelegateField(ref stream, propertyStreamHandles, intBuffer, count, useMask);
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00003FA1 File Offset: 0x000021A1
		public unsafe static void WriteStreamFloatsInternal(ref AnimationStream stream, void* propertyStreamHandles, void* floatBuffer, int count, bool useMask)
		{
			AnimationStreamHandleUtility.WriteStreamFloatsInternalDelegateField(ref stream, propertyStreamHandles, floatBuffer, count, useMask);
		}

		// Token: 0x0400043D RID: 1085
		private static readonly AnimationStreamHandleUtility.ReadStreamIntsInternalDelegate ReadStreamIntsInternalDelegateField = IL2CPP.ResolveICall<AnimationStreamHandleUtility.ReadStreamIntsInternalDelegate>("UnityEngine.Animations.AnimationStreamHandleUtility::ReadStreamIntsInternal");

		// Token: 0x0400043E RID: 1086
		private static readonly AnimationStreamHandleUtility.ReadStreamFloatsInternalDelegate ReadStreamFloatsInternalDelegateField = IL2CPP.ResolveICall<AnimationStreamHandleUtility.ReadStreamFloatsInternalDelegate>("UnityEngine.Animations.AnimationStreamHandleUtility::ReadStreamFloatsInternal");

		// Token: 0x0400043F RID: 1087
		private static readonly AnimationStreamHandleUtility.WriteStreamIntsInternalDelegate WriteStreamIntsInternalDelegateField = IL2CPP.ResolveICall<AnimationStreamHandleUtility.WriteStreamIntsInternalDelegate>("UnityEngine.Animations.AnimationStreamHandleUtility::WriteStreamIntsInternal");

		// Token: 0x04000440 RID: 1088
		private static readonly AnimationStreamHandleUtility.WriteStreamFloatsInternalDelegate WriteStreamFloatsInternalDelegateField = IL2CPP.ResolveICall<AnimationStreamHandleUtility.WriteStreamFloatsInternalDelegate>("UnityEngine.Animations.AnimationStreamHandleUtility::WriteStreamFloatsInternal");

		// Token: 0x0200015D RID: 349
		// (Invoke) Token: 0x06000795 RID: 1941
		private delegate void ReadStreamIntsInternalDelegate(IntPtr stream, IntPtr propertyStreamHandles, IntPtr intBuffer, int count);

		// Token: 0x0200015E RID: 350
		// (Invoke) Token: 0x06000797 RID: 1943
		private delegate void ReadStreamFloatsInternalDelegate(IntPtr stream, IntPtr propertyStreamHandles, IntPtr floatBuffer, int count);

		// Token: 0x0200015F RID: 351
		// (Invoke) Token: 0x06000799 RID: 1945
		private delegate void WriteStreamIntsInternalDelegate(IntPtr stream, IntPtr propertyStreamHandles, IntPtr intBuffer, int count, bool useMask);

		// Token: 0x02000160 RID: 352
		// (Invoke) Token: 0x0600079B RID: 1947
		private delegate void WriteStreamFloatsInternalDelegate(IntPtr stream, IntPtr propertyStreamHandles, IntPtr floatBuffer, int count, bool useMask);
	}
}

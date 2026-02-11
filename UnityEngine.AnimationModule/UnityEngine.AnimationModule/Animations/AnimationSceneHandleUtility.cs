using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Animations
{
	// Token: 0x02000054 RID: 84
	public static class AnimationSceneHandleUtility
	{
		// Token: 0x060004F0 RID: 1264 RVA: 0x00013054 File Offset: 0x00011254
		public static int ValidateAndGetArrayCount<T0, T1>(ref AnimationStream stream, NativeArray<T0> handles, NativeArray<T1> buffer) where T0 : struct where T1 : struct
		{
			stream.CheckIsValid();
			bool flag = !handles.IsCreated;
			if (flag)
			{
				throw new NullReferenceException("Handle array is invalid.");
			}
			bool flag2 = !buffer.IsCreated;
			if (flag2)
			{
				throw new NullReferenceException("Data buffer is invalid.");
			}
			bool flag3 = buffer.Length < handles.Length;
			if (flag3)
			{
				throw new InvalidOperationException("Data buffer array is smaller than handles array.");
			}
			return handles.Length;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00003F11 File Offset: 0x00002111
		public unsafe static void ReadSceneIntsInternal(ref AnimationStream stream, void* propertySceneHandles, void* intBuffer, int count)
		{
			AnimationSceneHandleUtility.ReadSceneIntsInternalDelegateField(ref stream, propertySceneHandles, intBuffer, count);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00003F21 File Offset: 0x00002121
		public unsafe static void ReadSceneFloatsInternal(ref AnimationStream stream, void* propertySceneHandles, void* floatBuffer, int count)
		{
			AnimationSceneHandleUtility.ReadSceneFloatsInternalDelegateField(ref stream, propertySceneHandles, floatBuffer, count);
		}

		// Token: 0x0400043B RID: 1083
		private static readonly AnimationSceneHandleUtility.ReadSceneIntsInternalDelegate ReadSceneIntsInternalDelegateField = IL2CPP.ResolveICall<AnimationSceneHandleUtility.ReadSceneIntsInternalDelegate>("UnityEngine.Animations.AnimationSceneHandleUtility::ReadSceneIntsInternal");

		// Token: 0x0400043C RID: 1084
		private static readonly AnimationSceneHandleUtility.ReadSceneFloatsInternalDelegate ReadSceneFloatsInternalDelegateField = IL2CPP.ResolveICall<AnimationSceneHandleUtility.ReadSceneFloatsInternalDelegate>("UnityEngine.Animations.AnimationSceneHandleUtility::ReadSceneFloatsInternal");

		// Token: 0x0200015B RID: 347
		// (Invoke) Token: 0x06000791 RID: 1937
		private delegate void ReadSceneIntsInternalDelegate(IntPtr stream, IntPtr propertySceneHandles, IntPtr intBuffer, int count);

		// Token: 0x0200015C RID: 348
		// (Invoke) Token: 0x06000793 RID: 1939
		private delegate void ReadSceneFloatsInternalDelegate(IntPtr stream, IntPtr propertySceneHandles, IntPtr floatBuffer, int count);
	}
}

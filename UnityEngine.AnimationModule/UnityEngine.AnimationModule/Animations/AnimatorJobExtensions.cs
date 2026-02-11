using System;
using Il2CppInterop.Runtime;
using Unity.Jobs;

namespace UnityEngine.Animations
{
	// Token: 0x02000057 RID: 87
	public static class AnimatorJobExtensions
	{
		// Token: 0x060004F9 RID: 1273 RVA: 0x00003FB3 File Offset: 0x000021B3
		public static void AddJobDependency(Animator animator, JobHandle jobHandle)
		{
			AnimatorJobExtensions.InternalAddJobDependency(animator, jobHandle);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00013140 File Offset: 0x00011340
		public static bool OpenAnimationStream(Animator animator, ref AnimationStream stream)
		{
			return AnimatorJobExtensions.InternalOpenAnimationStream(animator, ref stream);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00003FBE File Offset: 0x000021BE
		public static void CloseAnimationStream(Animator animator, ref AnimationStream stream)
		{
			AnimatorJobExtensions.InternalCloseAnimationStream(animator, ref stream);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00003FC9 File Offset: 0x000021C9
		public static void ResolveAllStreamHandles(Animator animator)
		{
			AnimatorJobExtensions.InternalResolveAllStreamHandles(animator);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00003FD3 File Offset: 0x000021D3
		public static void ResolveAllSceneHandles(Animator animator)
		{
			AnimatorJobExtensions.InternalResolveAllSceneHandles(animator);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00003FDD File Offset: 0x000021DD
		public static void UnbindAllHandles(Animator animator)
		{
			AnimatorJobExtensions.InternalUnbindAllStreamHandles(animator);
			AnimatorJobExtensions.InternalUnbindAllSceneHandles(animator);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00003FEE File Offset: 0x000021EE
		public static void UnbindAllStreamHandles(Animator animator)
		{
			AnimatorJobExtensions.InternalUnbindAllStreamHandles(animator);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00003FF8 File Offset: 0x000021F8
		public static void UnbindAllSceneHandles(Animator animator)
		{
			AnimatorJobExtensions.InternalUnbindAllSceneHandles(animator);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00004002 File Offset: 0x00002202
		public static void InternalAddJobDependency(Animator animator, JobHandle jobHandle)
		{
			AnimatorJobExtensions.InternalAddJobDependency_Injected(animator, ref jobHandle);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0000400C File Offset: 0x0000220C
		public static bool InternalOpenAnimationStream(Animator animator, ref AnimationStream stream)
		{
			return AnimatorJobExtensions.InternalOpenAnimationStreamDelegateField(IL2CPP.Il2CppObjectBaseToPtr(animator), ref stream);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0000401F File Offset: 0x0000221F
		public static void InternalCloseAnimationStream(Animator animator, ref AnimationStream stream)
		{
			AnimatorJobExtensions.InternalCloseAnimationStreamDelegateField(IL2CPP.Il2CppObjectBaseToPtr(animator), ref stream);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00004032 File Offset: 0x00002232
		public static void InternalResolveAllStreamHandles(Animator animator)
		{
			AnimatorJobExtensions.InternalResolveAllStreamHandlesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(animator));
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00004044 File Offset: 0x00002244
		public static void InternalResolveAllSceneHandles(Animator animator)
		{
			AnimatorJobExtensions.InternalResolveAllSceneHandlesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(animator));
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00004056 File Offset: 0x00002256
		public static void InternalUnbindAllStreamHandles(Animator animator)
		{
			AnimatorJobExtensions.InternalUnbindAllStreamHandlesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(animator));
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00004068 File Offset: 0x00002268
		public static void InternalUnbindAllSceneHandles(Animator animator)
		{
			AnimatorJobExtensions.InternalUnbindAllSceneHandlesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(animator));
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0000407A File Offset: 0x0000227A
		public static void InternalAddJobDependency_Injected(Animator animator, ref JobHandle jobHandle)
		{
			AnimatorJobExtensions.InternalAddJobDependency_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(animator), ref jobHandle);
		}

		// Token: 0x04000445 RID: 1093
		private static readonly AnimatorJobExtensions.InternalOpenAnimationStreamDelegate InternalOpenAnimationStreamDelegateField = IL2CPP.ResolveICall<AnimatorJobExtensions.InternalOpenAnimationStreamDelegate>("UnityEngine.Animations.AnimatorJobExtensions::InternalOpenAnimationStream");

		// Token: 0x04000446 RID: 1094
		private static readonly AnimatorJobExtensions.InternalCloseAnimationStreamDelegate InternalCloseAnimationStreamDelegateField = IL2CPP.ResolveICall<AnimatorJobExtensions.InternalCloseAnimationStreamDelegate>("UnityEngine.Animations.AnimatorJobExtensions::InternalCloseAnimationStream");

		// Token: 0x04000447 RID: 1095
		private static readonly AnimatorJobExtensions.InternalResolveAllStreamHandlesDelegate InternalResolveAllStreamHandlesDelegateField = IL2CPP.ResolveICall<AnimatorJobExtensions.InternalResolveAllStreamHandlesDelegate>("UnityEngine.Animations.AnimatorJobExtensions::InternalResolveAllStreamHandles");

		// Token: 0x04000448 RID: 1096
		private static readonly AnimatorJobExtensions.InternalResolveAllSceneHandlesDelegate InternalResolveAllSceneHandlesDelegateField = IL2CPP.ResolveICall<AnimatorJobExtensions.InternalResolveAllSceneHandlesDelegate>("UnityEngine.Animations.AnimatorJobExtensions::InternalResolveAllSceneHandles");

		// Token: 0x04000449 RID: 1097
		private static readonly AnimatorJobExtensions.InternalUnbindAllStreamHandlesDelegate InternalUnbindAllStreamHandlesDelegateField = IL2CPP.ResolveICall<AnimatorJobExtensions.InternalUnbindAllStreamHandlesDelegate>("UnityEngine.Animations.AnimatorJobExtensions::InternalUnbindAllStreamHandles");

		// Token: 0x0400044A RID: 1098
		private static readonly AnimatorJobExtensions.InternalUnbindAllSceneHandlesDelegate InternalUnbindAllSceneHandlesDelegateField = IL2CPP.ResolveICall<AnimatorJobExtensions.InternalUnbindAllSceneHandlesDelegate>("UnityEngine.Animations.AnimatorJobExtensions::InternalUnbindAllSceneHandles");

		// Token: 0x0400044B RID: 1099
		private static readonly AnimatorJobExtensions.InternalAddJobDependency_InjectedDelegate InternalAddJobDependency_InjectedDelegateField = IL2CPP.ResolveICall<AnimatorJobExtensions.InternalAddJobDependency_InjectedDelegate>("UnityEngine.Animations.AnimatorJobExtensions::InternalAddJobDependency_Injected");

		// Token: 0x02000161 RID: 353
		// (Invoke) Token: 0x0600079D RID: 1949
		private delegate bool InternalOpenAnimationStreamDelegate(IntPtr animator, IntPtr stream);

		// Token: 0x02000162 RID: 354
		// (Invoke) Token: 0x0600079F RID: 1951
		private delegate void InternalCloseAnimationStreamDelegate(IntPtr animator, IntPtr stream);

		// Token: 0x02000163 RID: 355
		// (Invoke) Token: 0x060007A1 RID: 1953
		private delegate void InternalResolveAllStreamHandlesDelegate(IntPtr animator);

		// Token: 0x02000164 RID: 356
		// (Invoke) Token: 0x060007A3 RID: 1955
		private delegate void InternalResolveAllSceneHandlesDelegate(IntPtr animator);

		// Token: 0x02000165 RID: 357
		// (Invoke) Token: 0x060007A5 RID: 1957
		private delegate void InternalUnbindAllStreamHandlesDelegate(IntPtr animator);

		// Token: 0x02000166 RID: 358
		// (Invoke) Token: 0x060007A7 RID: 1959
		private delegate void InternalUnbindAllSceneHandlesDelegate(IntPtr animator);

		// Token: 0x02000167 RID: 359
		// (Invoke) Token: 0x060007A9 RID: 1961
		private delegate void InternalAddJobDependency_InjectedDelegate(IntPtr animator, IntPtr jobHandle);
	}
}

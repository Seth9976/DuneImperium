using System;
using Il2CppInterop.Runtime;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Animations
{
	// Token: 0x02000046 RID: 70
	public static class AnimationPlayableOutputExtensions
	{
		// Token: 0x060004A8 RID: 1192 RVA: 0x00012AC0 File Offset: 0x00010CC0
		public static AnimationStreamSource GetAnimationStreamSource(AnimationPlayableOutput output)
		{
			return AnimationPlayableOutputExtensions.InternalGetAnimationStreamSource(output.GetHandle());
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00003BDA File Offset: 0x00001DDA
		public static void SetAnimationStreamSource(AnimationPlayableOutput output, AnimationStreamSource streamSource)
		{
			AnimationPlayableOutputExtensions.InternalSetAnimationStreamSource(output.GetHandle(), streamSource);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00012AE0 File Offset: 0x00010CE0
		public static ushort GetSortingOrder(AnimationPlayableOutput output)
		{
			return (ushort)AnimationPlayableOutputExtensions.InternalGetSortingOrder(output.GetHandle());
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00003BEB File Offset: 0x00001DEB
		public static void SetSortingOrder(AnimationPlayableOutput output, ushort sortingOrder)
		{
			AnimationPlayableOutputExtensions.InternalSetSortingOrder(output.GetHandle(), (int)sortingOrder);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00003BFC File Offset: 0x00001DFC
		public static AnimationStreamSource InternalGetAnimationStreamSource(PlayableOutputHandle output)
		{
			return AnimationPlayableOutputExtensions.InternalGetAnimationStreamSource_Injected(ref output);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00003C05 File Offset: 0x00001E05
		public static void InternalSetAnimationStreamSource(PlayableOutputHandle output, AnimationStreamSource streamSource)
		{
			AnimationPlayableOutputExtensions.InternalSetAnimationStreamSource_Injected(ref output, streamSource);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00003C0F File Offset: 0x00001E0F
		public static int InternalGetSortingOrder(PlayableOutputHandle output)
		{
			return AnimationPlayableOutputExtensions.InternalGetSortingOrder_Injected(ref output);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00003C18 File Offset: 0x00001E18
		public static void InternalSetSortingOrder(PlayableOutputHandle output, int sortingOrder)
		{
			AnimationPlayableOutputExtensions.InternalSetSortingOrder_Injected(ref output, sortingOrder);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00003C22 File Offset: 0x00001E22
		public static AnimationStreamSource InternalGetAnimationStreamSource_Injected(ref PlayableOutputHandle output)
		{
			return AnimationPlayableOutputExtensions.InternalGetAnimationStreamSource_InjectedDelegateField(ref output);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00003C2F File Offset: 0x00001E2F
		public static void InternalSetAnimationStreamSource_Injected(ref PlayableOutputHandle output, AnimationStreamSource streamSource)
		{
			AnimationPlayableOutputExtensions.InternalSetAnimationStreamSource_InjectedDelegateField(ref output, streamSource);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00003C3D File Offset: 0x00001E3D
		public static int InternalGetSortingOrder_Injected(ref PlayableOutputHandle output)
		{
			return AnimationPlayableOutputExtensions.InternalGetSortingOrder_InjectedDelegateField(ref output);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00003C4A File Offset: 0x00001E4A
		public static void InternalSetSortingOrder_Injected(ref PlayableOutputHandle output, int sortingOrder)
		{
			AnimationPlayableOutputExtensions.InternalSetSortingOrder_InjectedDelegateField(ref output, sortingOrder);
		}

		// Token: 0x04000408 RID: 1032
		private static readonly AnimationPlayableOutputExtensions.InternalGetAnimationStreamSource_InjectedDelegate InternalGetAnimationStreamSource_InjectedDelegateField = IL2CPP.ResolveICall<AnimationPlayableOutputExtensions.InternalGetAnimationStreamSource_InjectedDelegate>("UnityEngine.Experimental.Animations.AnimationPlayableOutputExtensions::InternalGetAnimationStreamSource_Injected");

		// Token: 0x04000409 RID: 1033
		private static readonly AnimationPlayableOutputExtensions.InternalSetAnimationStreamSource_InjectedDelegate InternalSetAnimationStreamSource_InjectedDelegateField = IL2CPP.ResolveICall<AnimationPlayableOutputExtensions.InternalSetAnimationStreamSource_InjectedDelegate>("UnityEngine.Experimental.Animations.AnimationPlayableOutputExtensions::InternalSetAnimationStreamSource_Injected");

		// Token: 0x0400040A RID: 1034
		private static readonly AnimationPlayableOutputExtensions.InternalGetSortingOrder_InjectedDelegate InternalGetSortingOrder_InjectedDelegateField = IL2CPP.ResolveICall<AnimationPlayableOutputExtensions.InternalGetSortingOrder_InjectedDelegate>("UnityEngine.Experimental.Animations.AnimationPlayableOutputExtensions::InternalGetSortingOrder_Injected");

		// Token: 0x0400040B RID: 1035
		private static readonly AnimationPlayableOutputExtensions.InternalSetSortingOrder_InjectedDelegate InternalSetSortingOrder_InjectedDelegateField = IL2CPP.ResolveICall<AnimationPlayableOutputExtensions.InternalSetSortingOrder_InjectedDelegate>("UnityEngine.Experimental.Animations.AnimationPlayableOutputExtensions::InternalSetSortingOrder_Injected");

		// Token: 0x02000137 RID: 311
		// (Invoke) Token: 0x0600074B RID: 1867
		private delegate AnimationStreamSource InternalGetAnimationStreamSource_InjectedDelegate(IntPtr output);

		// Token: 0x02000138 RID: 312
		// (Invoke) Token: 0x0600074D RID: 1869
		private delegate void InternalSetAnimationStreamSource_InjectedDelegate(IntPtr output, AnimationStreamSource streamSource);

		// Token: 0x02000139 RID: 313
		// (Invoke) Token: 0x0600074F RID: 1871
		private delegate int InternalGetSortingOrder_InjectedDelegate(IntPtr output);

		// Token: 0x0200013A RID: 314
		// (Invoke) Token: 0x06000751 RID: 1873
		private delegate void InternalSetSortingOrder_InjectedDelegate(IntPtr output, int sortingOrder);
	}
}

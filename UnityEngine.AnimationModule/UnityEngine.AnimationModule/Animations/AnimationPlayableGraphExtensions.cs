using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x02000051 RID: 81
	public static class AnimationPlayableGraphExtensions
	{
		// Token: 0x060004E8 RID: 1256 RVA: 0x00003E87 File Offset: 0x00002087
		public static void SyncUpdateAndTimeMode(PlayableGraph graph, Animator animator)
		{
			AnimationPlayableGraphExtensions.InternalSyncUpdateAndTimeMode(ref graph, animator);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00003E93 File Offset: 0x00002093
		public static void DestroyOutput(PlayableGraph graph, PlayableOutputHandle handle)
		{
			AnimationPlayableGraphExtensions.InternalDestroyOutput(ref graph, ref handle);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00003EA0 File Offset: 0x000020A0
		public static bool InternalCreateAnimationOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle)
		{
			return AnimationPlayableGraphExtensions.InternalCreateAnimationOutputDelegateField(ref graph, IL2CPP.ManagedStringToIl2Cpp(name), out handle);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00003EB4 File Offset: 0x000020B4
		public static void InternalSyncUpdateAndTimeMode(ref PlayableGraph graph, Animator animator)
		{
			AnimationPlayableGraphExtensions.InternalSyncUpdateAndTimeModeDelegateField(ref graph, IL2CPP.Il2CppObjectBaseToPtr(animator));
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00003EC7 File Offset: 0x000020C7
		public static void InternalDestroyOutput(ref PlayableGraph graph, ref PlayableOutputHandle handle)
		{
			AnimationPlayableGraphExtensions.InternalDestroyOutputDelegateField(ref graph, ref handle);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00003ED5 File Offset: 0x000020D5
		public static int InternalAnimationOutputCount(ref PlayableGraph graph)
		{
			return AnimationPlayableGraphExtensions.InternalAnimationOutputCountDelegateField(ref graph);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00003EE2 File Offset: 0x000020E2
		public static bool InternalGetAnimationOutput(ref PlayableGraph graph, int index, out PlayableOutputHandle handle)
		{
			return AnimationPlayableGraphExtensions.InternalGetAnimationOutputDelegateField(ref graph, index, out handle);
		}

		// Token: 0x0400042A RID: 1066
		private static readonly AnimationPlayableGraphExtensions.InternalCreateAnimationOutputDelegate InternalCreateAnimationOutputDelegateField = IL2CPP.ResolveICall<AnimationPlayableGraphExtensions.InternalCreateAnimationOutputDelegate>("UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalCreateAnimationOutput");

		// Token: 0x0400042B RID: 1067
		private static readonly AnimationPlayableGraphExtensions.InternalSyncUpdateAndTimeModeDelegate InternalSyncUpdateAndTimeModeDelegateField = IL2CPP.ResolveICall<AnimationPlayableGraphExtensions.InternalSyncUpdateAndTimeModeDelegate>("UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalSyncUpdateAndTimeMode");

		// Token: 0x0400042C RID: 1068
		private static readonly AnimationPlayableGraphExtensions.InternalDestroyOutputDelegate InternalDestroyOutputDelegateField = IL2CPP.ResolveICall<AnimationPlayableGraphExtensions.InternalDestroyOutputDelegate>("UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalDestroyOutput");

		// Token: 0x0400042D RID: 1069
		private static readonly AnimationPlayableGraphExtensions.InternalAnimationOutputCountDelegate InternalAnimationOutputCountDelegateField = IL2CPP.ResolveICall<AnimationPlayableGraphExtensions.InternalAnimationOutputCountDelegate>("UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalAnimationOutputCount");

		// Token: 0x0400042E RID: 1070
		private static readonly AnimationPlayableGraphExtensions.InternalGetAnimationOutputDelegate InternalGetAnimationOutputDelegateField = IL2CPP.ResolveICall<AnimationPlayableGraphExtensions.InternalGetAnimationOutputDelegate>("UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalGetAnimationOutput");

		// Token: 0x02000156 RID: 342
		// (Invoke) Token: 0x06000787 RID: 1927
		private delegate bool InternalCreateAnimationOutputDelegate(IntPtr graph, IntPtr name, [Out] IntPtr handle);

		// Token: 0x02000157 RID: 343
		// (Invoke) Token: 0x06000789 RID: 1929
		private delegate void InternalSyncUpdateAndTimeModeDelegate(IntPtr graph, IntPtr animator);

		// Token: 0x02000158 RID: 344
		// (Invoke) Token: 0x0600078B RID: 1931
		private delegate void InternalDestroyOutputDelegate(IntPtr graph, IntPtr handle);

		// Token: 0x02000159 RID: 345
		// (Invoke) Token: 0x0600078D RID: 1933
		private delegate int InternalAnimationOutputCountDelegate(IntPtr graph);

		// Token: 0x0200015A RID: 346
		// (Invoke) Token: 0x0600078F RID: 1935
		private delegate bool InternalGetAnimationOutputDelegate(IntPtr graph, int index, [Out] IntPtr handle);
	}
}

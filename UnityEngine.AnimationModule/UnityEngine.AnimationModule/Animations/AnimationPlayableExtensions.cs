using System;
using Il2CppInterop.Runtime;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x02000050 RID: 80
	public static class AnimationPlayableExtensions
	{
		// Token: 0x060004E5 RID: 1253 RVA: 0x00012FD4 File Offset: 0x000111D4
		public static void SetAnimatedProperties<U>(U playable, AnimationClip clip) where U : struct
		{
			PlayableHandle handle = playable.GetHandle();
			AnimationPlayableExtensions.SetAnimatedPropertiesInternal(ref handle, clip);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00003E74 File Offset: 0x00002074
		public static void SetAnimatedPropertiesInternal(ref PlayableHandle playable, AnimationClip animatedProperties)
		{
			AnimationPlayableExtensions.SetAnimatedPropertiesInternalDelegateField(ref playable, IL2CPP.Il2CppObjectBaseToPtr(animatedProperties));
		}

		// Token: 0x04000429 RID: 1065
		private static readonly AnimationPlayableExtensions.SetAnimatedPropertiesInternalDelegate SetAnimatedPropertiesInternalDelegateField = IL2CPP.ResolveICall<AnimationPlayableExtensions.SetAnimatedPropertiesInternalDelegate>("UnityEngine.Animations.AnimationPlayableExtensions::SetAnimatedPropertiesInternal");

		// Token: 0x02000155 RID: 341
		// (Invoke) Token: 0x06000785 RID: 1925
		private delegate void SetAnimatedPropertiesInternalDelegate(IntPtr playable, IntPtr animatedProperties);
	}
}

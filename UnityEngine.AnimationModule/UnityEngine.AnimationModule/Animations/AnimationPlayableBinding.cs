using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x02000048 RID: 72
	public static class AnimationPlayableBinding
	{
		// Token: 0x060004B9 RID: 1209 RVA: 0x00012CA4 File Offset: 0x00010EA4
		public static PlayableBinding Create(string name, Object key)
		{
			return PlayableBinding.CreateInternal(name, key, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Animator>()), new PlayableBinding.CreateOutputMethod(AnimationPlayableBinding.CreateAnimationOutput));
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00012CD4 File Offset: 0x00010ED4
		public static PlayableOutput CreateAnimationOutput(PlayableGraph graph, string name)
		{
			return AnimationPlayableOutput.Create(graph, name, null);
		}
	}
}

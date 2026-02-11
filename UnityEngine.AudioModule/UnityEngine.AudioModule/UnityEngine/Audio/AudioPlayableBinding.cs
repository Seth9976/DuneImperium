using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Audio
{
	// Token: 0x0200002A RID: 42
	public static class AudioPlayableBinding
	{
		// Token: 0x06000210 RID: 528 RVA: 0x000083E8 File Offset: 0x000065E8
		public static PlayableBinding Create(string name, Object key)
		{
			return PlayableBinding.CreateInternal(name, key, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<AudioSource>()), new PlayableBinding.CreateOutputMethod(AudioPlayableBinding.CreateAudioOutput));
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00008418 File Offset: 0x00006618
		public static PlayableOutput CreateAudioOutput(PlayableGraph graph, string name)
		{
			return AudioPlayableOutput.Create(graph, name, null);
		}
	}
}

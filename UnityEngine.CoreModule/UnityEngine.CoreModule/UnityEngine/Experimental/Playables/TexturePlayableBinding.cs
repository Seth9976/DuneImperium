using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x02000365 RID: 869
	public static class TexturePlayableBinding
	{
		// Token: 0x06002F38 RID: 12088 RVA: 0x000B5AC8 File Offset: 0x000B3CC8
		public static UnityEngine.Playables.PlayableBinding Create(string name, Object key)
		{
			return UnityEngine.Playables.PlayableBinding.CreateInternal(name, key, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<RenderTexture>()), new UnityEngine.Playables.PlayableBinding.CreateOutputMethod(TexturePlayableBinding.CreateTextureOutput));
		}

		// Token: 0x06002F39 RID: 12089 RVA: 0x000B5AF8 File Offset: 0x000B3CF8
		public static UnityEngine.Playables.PlayableOutput CreateTextureOutput(UnityEngine.Playables.PlayableGraph graph, string name)
		{
			return TexturePlayableOutput.Create(graph, name, null);
		}
	}
}

using System;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x0200035C RID: 860
	public static class ScriptPlayableBinding
	{
		// Token: 0x06002EA0 RID: 11936 RVA: 0x000B5814 File Offset: 0x000B3A14
		public static PlayableBinding Create(string name, Object key, Type type)
		{
			return PlayableBinding.CreateInternal(name, key, type, new PlayableBinding.CreateOutputMethod(ScriptPlayableBinding.CreateScriptOutput));
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x000B583C File Offset: 0x000B3A3C
		public static PlayableOutput CreateScriptOutput(PlayableGraph graph, string name)
		{
			return ScriptPlayableOutput.Create(graph, name);
		}
	}
}

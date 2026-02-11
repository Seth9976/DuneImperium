using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Playables;

namespace UnityEngine.Audio
{
	// Token: 0x0200002B RID: 43
	public static class AudioPlayableGraphExtensions
	{
		// Token: 0x06000213 RID: 531 RVA: 0x00003254 File Offset: 0x00001454
		public static bool InternalCreateAudioOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle)
		{
			return AudioPlayableGraphExtensions.InternalCreateAudioOutputDelegateField(ref graph, IL2CPP.ManagedStringToIl2Cpp(name), out handle);
		}

		// Token: 0x040001C3 RID: 451
		private static readonly AudioPlayableGraphExtensions.InternalCreateAudioOutputDelegate InternalCreateAudioOutputDelegateField = IL2CPP.ResolveICall<AudioPlayableGraphExtensions.InternalCreateAudioOutputDelegate>("UnityEngine.Audio.AudioPlayableGraphExtensions::InternalCreateAudioOutput");

		// Token: 0x020000FD RID: 253
		// (Invoke) Token: 0x060003C7 RID: 967
		private delegate bool InternalCreateAudioOutputDelegate(IntPtr graph, IntPtr name, [Out] IntPtr handle);
	}
}

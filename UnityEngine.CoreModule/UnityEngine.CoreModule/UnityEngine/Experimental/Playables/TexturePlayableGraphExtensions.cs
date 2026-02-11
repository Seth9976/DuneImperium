using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x02000366 RID: 870
	public static class TexturePlayableGraphExtensions
	{
		// Token: 0x06002F3B RID: 12091 RVA: 0x00012E38 File Offset: 0x00011038
		public static bool InternalCreateTextureOutput(ref UnityEngine.Playables.PlayableGraph graph, string name, out UnityEngine.Playables.PlayableOutputHandle handle)
		{
			return TexturePlayableGraphExtensions.InternalCreateTextureOutputDelegateField(ref graph, IL2CPP.ManagedStringToIl2Cpp(name), out handle);
		}

		// Token: 0x04002A63 RID: 10851
		private static readonly TexturePlayableGraphExtensions.InternalCreateTextureOutputDelegate InternalCreateTextureOutputDelegateField = IL2CPP.ResolveICall<TexturePlayableGraphExtensions.InternalCreateTextureOutputDelegate>("UnityEngine.Experimental.Playables.TexturePlayableGraphExtensions::InternalCreateTextureOutput");

		// Token: 0x02000BAA RID: 2986
		// (Invoke) Token: 0x06004045 RID: 16453
		private delegate bool InternalCreateTextureOutputDelegate(IntPtr graph, IntPtr name, [Out] IntPtr handle);
	}
}

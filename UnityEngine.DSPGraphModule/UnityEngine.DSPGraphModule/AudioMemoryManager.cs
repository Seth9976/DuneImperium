using System;
using Il2CppInterop.Runtime;

namespace Unity.Audio
{
	// Token: 0x02000002 RID: 2
	public struct AudioMemoryManager
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002070 File Offset: 0x00000270
		public unsafe static void* Internal_AllocateAudioMemory(int size, int alignment)
		{
			return AudioMemoryManager.Internal_AllocateAudioMemoryDelegateField(size, alignment);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000207E File Offset: 0x0000027E
		public unsafe static void Internal_FreeAudioMemory(void* memory)
		{
			AudioMemoryManager.Internal_FreeAudioMemoryDelegateField(memory);
		}

		// Token: 0x04000001 RID: 1
		private static readonly AudioMemoryManager.Internal_AllocateAudioMemoryDelegate Internal_AllocateAudioMemoryDelegateField = IL2CPP.ResolveICall<AudioMemoryManager.Internal_AllocateAudioMemoryDelegate>("Unity.Audio.AudioMemoryManager::Internal_AllocateAudioMemory");

		// Token: 0x04000002 RID: 2
		private static readonly AudioMemoryManager.Internal_FreeAudioMemoryDelegate Internal_FreeAudioMemoryDelegateField = IL2CPP.ResolveICall<AudioMemoryManager.Internal_FreeAudioMemoryDelegate>("Unity.Audio.AudioMemoryManager::Internal_FreeAudioMemory");

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x0600001A RID: 26
		private delegate IntPtr Internal_AllocateAudioMemoryDelegate(int size, int alignment);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x0600001C RID: 28
		private delegate void Internal_FreeAudioMemoryDelegate(IntPtr memory);
	}
}

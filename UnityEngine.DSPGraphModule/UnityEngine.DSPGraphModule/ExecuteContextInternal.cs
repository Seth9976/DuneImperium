using System;
using Il2CppInterop.Runtime;

namespace Unity.Audio
{
	// Token: 0x02000008 RID: 8
	public struct ExecuteContextInternal
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002192 File Offset: 0x00000392
		public unsafe static void Internal_PostEvent(void* dspNodePtr, long eventTypeHashCode, void* eventPtr, int eventSize)
		{
			ExecuteContextInternal.Internal_PostEventDelegateField(dspNodePtr, eventTypeHashCode, eventPtr, eventSize);
		}

		// Token: 0x04000012 RID: 18
		private static readonly ExecuteContextInternal.Internal_PostEventDelegate Internal_PostEventDelegateField = IL2CPP.ResolveICall<ExecuteContextInternal.Internal_PostEventDelegate>("Unity.Audio.ExecuteContextInternal::Internal_PostEvent");

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x0600003C RID: 60
		private delegate void Internal_PostEventDelegate(IntPtr dspNodePtr, long eventTypeHashCode, IntPtr eventPtr, int eventSize);
	}
}

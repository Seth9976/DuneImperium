using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000368 RID: 872
	public static class ExternalGPUProfiler
	{
		// Token: 0x06002F40 RID: 12096 RVA: 0x00012E90 File Offset: 0x00011090
		public static void BeginGPUCapture()
		{
			ExternalGPUProfiler.BeginGPUCaptureDelegateField();
		}

		// Token: 0x06002F41 RID: 12097 RVA: 0x00012E9C File Offset: 0x0001109C
		public static void EndGPUCapture()
		{
			ExternalGPUProfiler.EndGPUCaptureDelegateField();
		}

		// Token: 0x06002F42 RID: 12098 RVA: 0x00012EA8 File Offset: 0x000110A8
		public static bool IsAttached()
		{
			return ExternalGPUProfiler.IsAttachedDelegateField();
		}

		// Token: 0x04002A64 RID: 10852
		private static readonly ExternalGPUProfiler.BeginGPUCaptureDelegate BeginGPUCaptureDelegateField = IL2CPP.ResolveICall<ExternalGPUProfiler.BeginGPUCaptureDelegate>("UnityEngine.Experimental.Rendering.ExternalGPUProfiler::BeginGPUCapture");

		// Token: 0x04002A65 RID: 10853
		private static readonly ExternalGPUProfiler.EndGPUCaptureDelegate EndGPUCaptureDelegateField = IL2CPP.ResolveICall<ExternalGPUProfiler.EndGPUCaptureDelegate>("UnityEngine.Experimental.Rendering.ExternalGPUProfiler::EndGPUCapture");

		// Token: 0x04002A66 RID: 10854
		private static readonly ExternalGPUProfiler.IsAttachedDelegate IsAttachedDelegateField = IL2CPP.ResolveICall<ExternalGPUProfiler.IsAttachedDelegate>("UnityEngine.Experimental.Rendering.ExternalGPUProfiler::IsAttached");

		// Token: 0x02000BAB RID: 2987
		// (Invoke) Token: 0x06004047 RID: 16455
		private delegate void BeginGPUCaptureDelegate();

		// Token: 0x02000BAC RID: 2988
		// (Invoke) Token: 0x06004049 RID: 16457
		private delegate void EndGPUCaptureDelegate();

		// Token: 0x02000BAD RID: 2989
		// (Invoke) Token: 0x0600404B RID: 16459
		private delegate bool IsAttachedDelegate();
	}
}

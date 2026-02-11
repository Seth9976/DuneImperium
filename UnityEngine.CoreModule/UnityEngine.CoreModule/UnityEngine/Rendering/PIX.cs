using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000335 RID: 821
	public class PIX
	{
		// Token: 0x06002E31 RID: 11825 RVA: 0x000127FB File Offset: 0x000109FB
		public static void BeginGPUCapture()
		{
			PIX.BeginGPUCaptureDelegateField();
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x00012807 File Offset: 0x00010A07
		public static void EndGPUCapture()
		{
			PIX.EndGPUCaptureDelegateField();
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x00012813 File Offset: 0x00010A13
		public static bool IsAttached()
		{
			return PIX.IsAttachedDelegateField();
		}

		// Token: 0x040029B3 RID: 10675
		private static readonly PIX.BeginGPUCaptureDelegate BeginGPUCaptureDelegateField = IL2CPP.ResolveICall<PIX.BeginGPUCaptureDelegate>("UnityEngine.Rendering.PIX::BeginGPUCapture");

		// Token: 0x040029B4 RID: 10676
		private static readonly PIX.EndGPUCaptureDelegate EndGPUCaptureDelegateField = IL2CPP.ResolveICall<PIX.EndGPUCaptureDelegate>("UnityEngine.Rendering.PIX::EndGPUCapture");

		// Token: 0x040029B5 RID: 10677
		private static readonly PIX.IsAttachedDelegate IsAttachedDelegateField = IL2CPP.ResolveICall<PIX.IsAttachedDelegate>("UnityEngine.Rendering.PIX::IsAttached");

		// Token: 0x02000B85 RID: 2949
		// (Invoke) Token: 0x06003FFD RID: 16381
		private delegate void BeginGPUCaptureDelegate();

		// Token: 0x02000B86 RID: 2950
		// (Invoke) Token: 0x06003FFF RID: 16383
		private delegate void EndGPUCaptureDelegate();

		// Token: 0x02000B87 RID: 2951
		// (Invoke) Token: 0x06004001 RID: 16385
		private delegate bool IsAttachedDelegate();
	}
}

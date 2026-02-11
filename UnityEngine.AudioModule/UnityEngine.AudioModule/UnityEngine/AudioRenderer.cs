using System;
using Il2CppInterop.Runtime;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Audio;

namespace UnityEngine
{
	// Token: 0x02000021 RID: 33
	public class AudioRenderer
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x00008010 File Offset: 0x00006210
		public static bool Start()
		{
			return AudioRenderer.Internal_AudioRenderer_Start();
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00008028 File Offset: 0x00006228
		public static bool Stop()
		{
			return AudioRenderer.Internal_AudioRenderer_Stop();
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00008040 File Offset: 0x00006240
		public static int GetSampleCountForCaptureFrame()
		{
			return AudioRenderer.Internal_AudioRenderer_GetSampleCountForCaptureFrame();
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00008058 File Offset: 0x00006258
		public static bool AddMixerGroupSink(AudioMixerGroup mixerGroup, NativeArray<float> buffer, bool excludeFromMix)
		{
			return AudioRenderer.Internal_AudioRenderer_AddMixerGroupSink(mixerGroup, buffer.GetUnsafePtr<float>(), buffer.Length, excludeFromMix);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00008080 File Offset: 0x00006280
		public static bool Render(NativeArray<float> buffer)
		{
			return AudioRenderer.Internal_AudioRenderer_Render(buffer.GetUnsafePtr<float>(), buffer.Length);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002F5D File Offset: 0x0000115D
		public static bool Internal_AudioRenderer_Start()
		{
			return AudioRenderer.Internal_AudioRenderer_StartDelegateField();
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002F69 File Offset: 0x00001169
		public static bool Internal_AudioRenderer_Stop()
		{
			return AudioRenderer.Internal_AudioRenderer_StopDelegateField();
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002F75 File Offset: 0x00001175
		public static int Internal_AudioRenderer_GetSampleCountForCaptureFrame()
		{
			return AudioRenderer.Internal_AudioRenderer_GetSampleCountForCaptureFrameDelegateField();
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002F81 File Offset: 0x00001181
		public unsafe static bool Internal_AudioRenderer_AddMixerGroupSink(AudioMixerGroup mixerGroup, void* ptr, int length, bool excludeFromMix)
		{
			return AudioRenderer.Internal_AudioRenderer_AddMixerGroupSinkDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mixerGroup), ptr, length, excludeFromMix);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002F96 File Offset: 0x00001196
		public unsafe static bool Internal_AudioRenderer_Render(void* ptr, int length)
		{
			return AudioRenderer.Internal_AudioRenderer_RenderDelegateField(ptr, length);
		}

		// Token: 0x0400019B RID: 411
		private static readonly AudioRenderer.Internal_AudioRenderer_StartDelegate Internal_AudioRenderer_StartDelegateField = IL2CPP.ResolveICall<AudioRenderer.Internal_AudioRenderer_StartDelegate>("UnityEngine.AudioRenderer::Internal_AudioRenderer_Start");

		// Token: 0x0400019C RID: 412
		private static readonly AudioRenderer.Internal_AudioRenderer_StopDelegate Internal_AudioRenderer_StopDelegateField = IL2CPP.ResolveICall<AudioRenderer.Internal_AudioRenderer_StopDelegate>("UnityEngine.AudioRenderer::Internal_AudioRenderer_Stop");

		// Token: 0x0400019D RID: 413
		private static readonly AudioRenderer.Internal_AudioRenderer_GetSampleCountForCaptureFrameDelegate Internal_AudioRenderer_GetSampleCountForCaptureFrameDelegateField = IL2CPP.ResolveICall<AudioRenderer.Internal_AudioRenderer_GetSampleCountForCaptureFrameDelegate>("UnityEngine.AudioRenderer::Internal_AudioRenderer_GetSampleCountForCaptureFrame");

		// Token: 0x0400019E RID: 414
		private static readonly AudioRenderer.Internal_AudioRenderer_AddMixerGroupSinkDelegate Internal_AudioRenderer_AddMixerGroupSinkDelegateField = IL2CPP.ResolveICall<AudioRenderer.Internal_AudioRenderer_AddMixerGroupSinkDelegate>("UnityEngine.AudioRenderer::Internal_AudioRenderer_AddMixerGroupSink");

		// Token: 0x0400019F RID: 415
		private static readonly AudioRenderer.Internal_AudioRenderer_RenderDelegate Internal_AudioRenderer_RenderDelegateField = IL2CPP.ResolveICall<AudioRenderer.Internal_AudioRenderer_RenderDelegate>("UnityEngine.AudioRenderer::Internal_AudioRenderer_Render");

		// Token: 0x020000DD RID: 221
		// (Invoke) Token: 0x06000387 RID: 903
		private delegate bool Internal_AudioRenderer_StartDelegate();

		// Token: 0x020000DE RID: 222
		// (Invoke) Token: 0x06000389 RID: 905
		private delegate bool Internal_AudioRenderer_StopDelegate();

		// Token: 0x020000DF RID: 223
		// (Invoke) Token: 0x0600038B RID: 907
		private delegate int Internal_AudioRenderer_GetSampleCountForCaptureFrameDelegate();

		// Token: 0x020000E0 RID: 224
		// (Invoke) Token: 0x0600038D RID: 909
		private delegate bool Internal_AudioRenderer_AddMixerGroupSinkDelegate(IntPtr mixerGroup, IntPtr ptr, int length, bool excludeFromMix);

		// Token: 0x020000E1 RID: 225
		// (Invoke) Token: 0x0600038F RID: 911
		private delegate bool Internal_AudioRenderer_RenderDelegate(IntPtr ptr, int length);
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Audio
{
	// Token: 0x02000010 RID: 16
	[StructLayout(2)]
	public struct AudioMixerPlayable
	{
		// Token: 0x06000137 RID: 311 RVA: 0x00007338 File Offset: 0x00005538
		// Note: this type is marked as 'beforefieldinit'.
		static AudioMixerPlayable()
		{
			Il2CppClassPointerStore<AudioMixerPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioMixerPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioMixerPlayable>.NativeClassPtr);
			AudioMixerPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioMixerPlayable>.NativeClassPtr, "m_Handle");
			AudioMixerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixerPlayable>.NativeClassPtr, 100663442);
			AudioMixerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AudioMixerPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioMixerPlayable>.NativeClassPtr, 100663443);
			AudioMixerPlayable.CreateAudioMixerPlayableInternalDelegateField = IL2CPP.ResolveICall<AudioMixerPlayable.CreateAudioMixerPlayableInternalDelegate>("UnityEngine.Audio.AudioMixerPlayable::CreateAudioMixerPlayableInternal");
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000073B4 File Offset: 0x000055B4
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000073E4 File Offset: 0x000055E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259480, XrefRangeEnd = 1259484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AudioMixerPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioMixerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AudioMixerPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000026F8 File Offset: 0x000008F8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioMixerPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00007424 File Offset: 0x00005624
		public static AudioMixerPlayable Create(PlayableGraph graph, [Optional] int inputCount, [Optional] bool normalizeInputVolumes)
		{
			PlayableHandle playableHandle = AudioMixerPlayable.CreateHandle(graph, inputCount, normalizeInputVolumes);
			return new AudioMixerPlayable(playableHandle);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00007448 File Offset: 0x00005648
		public static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount, bool normalizeInputVolumes)
		{
			PlayableHandle @null = PlayableHandle.Null;
			bool flag = !AudioMixerPlayable.CreateAudioMixerPlayableInternal(ref graph, normalizeInputVolumes, ref @null);
			PlayableHandle playableHandle;
			if (flag)
			{
				playableHandle = PlayableHandle.Null;
			}
			else
			{
				@null.SetInputCount(inputCount);
				playableHandle = @null;
			}
			return playableHandle;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00007484 File Offset: 0x00005684
		public static implicit operator Playable(AudioMixerPlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000074A4 File Offset: 0x000056A4
		public static explicit operator AudioMixerPlayable(Playable playable)
		{
			return new AudioMixerPlayable(playable.GetHandle());
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000270A File Offset: 0x0000090A
		public static bool CreateAudioMixerPlayableInternal(ref PlayableGraph graph, bool normalizeInputVolumes, ref PlayableHandle handle)
		{
			return AudioMixerPlayable.CreateAudioMixerPlayableInternalDelegateField(ref graph, normalizeInputVolumes, ref handle);
		}

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AudioMixerPlayable_0;

		// Token: 0x040000EB RID: 235
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x040000EC RID: 236
		private static readonly AudioMixerPlayable.CreateAudioMixerPlayableInternalDelegate CreateAudioMixerPlayableInternalDelegateField;

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x060002AD RID: 685
		private delegate bool CreateAudioMixerPlayableInternalDelegate(IntPtr graph, bool normalizeInputVolumes, IntPtr handle);
	}
}

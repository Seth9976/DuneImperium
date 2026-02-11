using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Audio
{
	// Token: 0x0200000C RID: 12
	[StructLayout(2)]
	public struct AudioClipPlayable
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x000066E4 File Offset: 0x000048E4
		// Note: this type is marked as 'beforefieldinit'.
		static AudioClipPlayable()
		{
			Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioClipPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr);
			AudioClipPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, "m_Handle");
			AudioClipPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663424);
			AudioClipPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AudioClipPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, 100663425);
			AudioClipPlayable.GetClipInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.GetClipInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetClipInternal");
			AudioClipPlayable.SetClipInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.SetClipInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::SetClipInternal");
			AudioClipPlayable.GetLoopedInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.GetLoopedInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetLoopedInternal");
			AudioClipPlayable.SetLoopedInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.SetLoopedInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::SetLoopedInternal");
			AudioClipPlayable.GetVolumeInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.GetVolumeInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetVolumeInternal");
			AudioClipPlayable.SetVolumeInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.SetVolumeInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::SetVolumeInternal");
			AudioClipPlayable.GetStereoPanInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.GetStereoPanInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetStereoPanInternal");
			AudioClipPlayable.SetStereoPanInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.SetStereoPanInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::SetStereoPanInternal");
			AudioClipPlayable.GetSpatialBlendInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.GetSpatialBlendInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetSpatialBlendInternal");
			AudioClipPlayable.SetSpatialBlendInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.SetSpatialBlendInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::SetSpatialBlendInternal");
			AudioClipPlayable.GetIsChannelPlayingInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.GetIsChannelPlayingInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetIsChannelPlayingInternal");
			AudioClipPlayable.GetStartDelayInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.GetStartDelayInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetStartDelayInternal");
			AudioClipPlayable.SetStartDelayInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.SetStartDelayInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::SetStartDelayInternal");
			AudioClipPlayable.GetPauseDelayInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.GetPauseDelayInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::GetPauseDelayInternal");
			AudioClipPlayable.SetPauseDelayInternalDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.SetPauseDelayInternalDelegate>("UnityEngine.Audio.AudioClipPlayable::SetPauseDelayInternal");
			AudioClipPlayable.InternalCreateAudioClipPlayableDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.InternalCreateAudioClipPlayableDelegate>("UnityEngine.Audio.AudioClipPlayable::InternalCreateAudioClipPlayable");
			AudioClipPlayable.ValidateTypeDelegateField = IL2CPP.ResolveICall<AudioClipPlayable.ValidateTypeDelegate>("UnityEngine.Audio.AudioClipPlayable::ValidateType");
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00006850 File Offset: 0x00004A50
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00006880 File Offset: 0x00004A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259397, XrefRangeEnd = 1259401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AudioClipPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClipPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AudioClipPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000025AB File Offset: 0x000007AB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioClipPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000068C0 File Offset: 0x00004AC0
		public static AudioClipPlayable Create(PlayableGraph graph, AudioClip clip, bool looping)
		{
			PlayableHandle playableHandle = AudioClipPlayable.CreateHandle(graph, clip, looping);
			AudioClipPlayable audioClipPlayable = new AudioClipPlayable(playableHandle);
			bool flag = clip != null;
			if (flag)
			{
				PlayableExtensions.SetDuration<AudioClipPlayable>(audioClipPlayable, (double)clip.length);
			}
			return audioClipPlayable;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00006900 File Offset: 0x00004B00
		public static PlayableHandle CreateHandle(PlayableGraph graph, AudioClip clip, bool looping)
		{
			PlayableHandle @null = PlayableHandle.Null;
			bool flag = !AudioClipPlayable.InternalCreateAudioClipPlayable(ref graph, clip, looping, ref @null);
			PlayableHandle playableHandle;
			if (flag)
			{
				playableHandle = PlayableHandle.Null;
			}
			else
			{
				playableHandle = @null;
			}
			return playableHandle;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00006934 File Offset: 0x00004B34
		public static implicit operator Playable(AudioClipPlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00006954 File Offset: 0x00004B54
		public static explicit operator AudioClipPlayable(Playable playable)
		{
			return new AudioClipPlayable(playable.GetHandle());
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00006974 File Offset: 0x00004B74
		public AudioClip GetClip()
		{
			return AudioClipPlayable.GetClipInternal(ref this.m_Handle);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000025BD File Offset: 0x000007BD
		public void SetClip(AudioClip value)
		{
			AudioClipPlayable.SetClipInternal(ref this.m_Handle, value);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00006994 File Offset: 0x00004B94
		public bool GetLooped()
		{
			return AudioClipPlayable.GetLoopedInternal(ref this.m_Handle);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000025CD File Offset: 0x000007CD
		public void SetLooped(bool value)
		{
			AudioClipPlayable.SetLoopedInternal(ref this.m_Handle, value);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000069B4 File Offset: 0x00004BB4
		public float GetVolume()
		{
			return AudioClipPlayable.GetVolumeInternal(ref this.m_Handle);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000069D4 File Offset: 0x00004BD4
		public void SetVolume(float value)
		{
			bool flag = value < 0f || value > 1f;
			if (flag)
			{
				throw new ArgumentException(String.Concat("Trying to set AudioClipPlayable volume outside of range (0.0 - 1.0): ", value.ToString()));
			}
			AudioClipPlayable.SetVolumeInternal(ref this.m_Handle, value);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00006A20 File Offset: 0x00004C20
		public float GetStereoPan()
		{
			return AudioClipPlayable.GetStereoPanInternal(ref this.m_Handle);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00006A40 File Offset: 0x00004C40
		public void SetStereoPan(float value)
		{
			bool flag = value < -1f || value > 1f;
			if (flag)
			{
				throw new ArgumentException(String.Concat("Trying to set AudioClipPlayable stereo pan outside of range (-1.0 - 1.0): ", value.ToString()));
			}
			AudioClipPlayable.SetStereoPanInternal(ref this.m_Handle, value);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00006A8C File Offset: 0x00004C8C
		public float GetSpatialBlend()
		{
			return AudioClipPlayable.GetSpatialBlendInternal(ref this.m_Handle);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00006AAC File Offset: 0x00004CAC
		public void SetSpatialBlend(float value)
		{
			bool flag = value < 0f || value > 1f;
			if (flag)
			{
				throw new ArgumentException(String.Concat("Trying to set AudioClipPlayable spatial blend outside of range (0.0 - 1.0): ", value.ToString()));
			}
			AudioClipPlayable.SetSpatialBlendInternal(ref this.m_Handle, value);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00006AF8 File Offset: 0x00004CF8
		public bool IsPlaying()
		{
			return this.IsChannelPlaying();
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00006B10 File Offset: 0x00004D10
		public bool IsChannelPlaying()
		{
			return AudioClipPlayable.GetIsChannelPlayingInternal(ref this.m_Handle);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00006B30 File Offset: 0x00004D30
		public double GetStartDelay()
		{
			return AudioClipPlayable.GetStartDelayInternal(ref this.m_Handle);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000025DD File Offset: 0x000007DD
		public void SetStartDelay(double value)
		{
			AudioClipPlayable.SetStartDelayInternal(ref this.m_Handle, value);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00006B50 File Offset: 0x00004D50
		public double GetPauseDelay()
		{
			return AudioClipPlayable.GetPauseDelayInternal(ref this.m_Handle);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00006B70 File Offset: 0x00004D70
		public void GetPauseDelay(double value)
		{
			double pauseDelayInternal = AudioClipPlayable.GetPauseDelayInternal(ref this.m_Handle);
			bool flag = this.m_Handle.GetPlayState() == PlayState.Playing && (value < 0.05 || (pauseDelayInternal != 0.0 && pauseDelayInternal < 0.05));
			if (flag)
			{
				throw new ArgumentException(String.Concat("AudioClipPlayable.pauseDelay: Setting new delay when existing delay is too small or 0.0 (", pauseDelayInternal.ToString(), "), audio system will not be able to change in time"));
			}
			AudioClipPlayable.SetPauseDelayInternal(ref this.m_Handle, value);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000025ED File Offset: 0x000007ED
		public void Seek(double startTime, double startDelay)
		{
			this.Seek(startTime, startDelay, 0.0);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00006BF4 File Offset: 0x00004DF4
		public void Seek(double startTime, double startDelay, double duration)
		{
			AudioClipPlayable.SetStartDelayInternal(ref this.m_Handle, startDelay);
			bool flag = duration > 0.0;
			if (flag)
			{
				double num = startDelay + duration;
				bool flag2 = num >= this.m_Handle.GetDuration();
				if (flag2)
				{
					this.m_Handle.SetDone(true);
				}
				this.m_Handle.SetDuration(duration + startTime);
				AudioClipPlayable.SetPauseDelayInternal(ref this.m_Handle, startDelay + duration);
			}
			else
			{
				this.m_Handle.SetDone(true);
				this.m_Handle.SetDuration(double.MaxValue);
				AudioClipPlayable.SetPauseDelayInternal(ref this.m_Handle, 0.0);
			}
			this.m_Handle.SetTime(startTime);
			this.m_Handle.Play();
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00006CBC File Offset: 0x00004EBC
		public static AudioClip GetClipInternal(ref PlayableHandle hdl)
		{
			IntPtr intPtr = AudioClipPlayable.GetClipInternalDelegateField(ref hdl);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002602 File Offset: 0x00000802
		public static void SetClipInternal(ref PlayableHandle hdl, AudioClip clip)
		{
			AudioClipPlayable.SetClipInternalDelegateField(ref hdl, IL2CPP.Il2CppObjectBaseToPtr(clip));
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002615 File Offset: 0x00000815
		public static bool GetLoopedInternal(ref PlayableHandle hdl)
		{
			return AudioClipPlayable.GetLoopedInternalDelegateField(ref hdl);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002622 File Offset: 0x00000822
		public static void SetLoopedInternal(ref PlayableHandle hdl, bool looped)
		{
			AudioClipPlayable.SetLoopedInternalDelegateField(ref hdl, looped);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002630 File Offset: 0x00000830
		public static float GetVolumeInternal(ref PlayableHandle hdl)
		{
			return AudioClipPlayable.GetVolumeInternalDelegateField(ref hdl);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000263D File Offset: 0x0000083D
		public static void SetVolumeInternal(ref PlayableHandle hdl, float volume)
		{
			AudioClipPlayable.SetVolumeInternalDelegateField(ref hdl, volume);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000264B File Offset: 0x0000084B
		public static float GetStereoPanInternal(ref PlayableHandle hdl)
		{
			return AudioClipPlayable.GetStereoPanInternalDelegateField(ref hdl);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002658 File Offset: 0x00000858
		public static void SetStereoPanInternal(ref PlayableHandle hdl, float stereoPan)
		{
			AudioClipPlayable.SetStereoPanInternalDelegateField(ref hdl, stereoPan);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002666 File Offset: 0x00000866
		public static float GetSpatialBlendInternal(ref PlayableHandle hdl)
		{
			return AudioClipPlayable.GetSpatialBlendInternalDelegateField(ref hdl);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002673 File Offset: 0x00000873
		public static void SetSpatialBlendInternal(ref PlayableHandle hdl, float spatialBlend)
		{
			AudioClipPlayable.SetSpatialBlendInternalDelegateField(ref hdl, spatialBlend);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002681 File Offset: 0x00000881
		public static bool GetIsChannelPlayingInternal(ref PlayableHandle hdl)
		{
			return AudioClipPlayable.GetIsChannelPlayingInternalDelegateField(ref hdl);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000268E File Offset: 0x0000088E
		public static double GetStartDelayInternal(ref PlayableHandle hdl)
		{
			return AudioClipPlayable.GetStartDelayInternalDelegateField(ref hdl);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000269B File Offset: 0x0000089B
		public static void SetStartDelayInternal(ref PlayableHandle hdl, double delay)
		{
			AudioClipPlayable.SetStartDelayInternalDelegateField(ref hdl, delay);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000026A9 File Offset: 0x000008A9
		public static double GetPauseDelayInternal(ref PlayableHandle hdl)
		{
			return AudioClipPlayable.GetPauseDelayInternalDelegateField(ref hdl);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000026B6 File Offset: 0x000008B6
		public static void SetPauseDelayInternal(ref PlayableHandle hdl, double delay)
		{
			AudioClipPlayable.SetPauseDelayInternalDelegateField(ref hdl, delay);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000026C4 File Offset: 0x000008C4
		public static bool InternalCreateAudioClipPlayable(ref PlayableGraph graph, AudioClip clip, bool looping, ref PlayableHandle handle)
		{
			return AudioClipPlayable.InternalCreateAudioClipPlayableDelegateField(ref graph, IL2CPP.Il2CppObjectBaseToPtr(clip), looping, ref handle);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000026D9 File Offset: 0x000008D9
		public static bool ValidateType(ref PlayableHandle hdl)
		{
			return AudioClipPlayable.ValidateTypeDelegateField(ref hdl);
		}

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AudioClipPlayable_0;

		// Token: 0x040000C3 RID: 195
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x040000C4 RID: 196
		private static readonly AudioClipPlayable.GetClipInternalDelegate GetClipInternalDelegateField;

		// Token: 0x040000C5 RID: 197
		private static readonly AudioClipPlayable.SetClipInternalDelegate SetClipInternalDelegateField;

		// Token: 0x040000C6 RID: 198
		private static readonly AudioClipPlayable.GetLoopedInternalDelegate GetLoopedInternalDelegateField;

		// Token: 0x040000C7 RID: 199
		private static readonly AudioClipPlayable.SetLoopedInternalDelegate SetLoopedInternalDelegateField;

		// Token: 0x040000C8 RID: 200
		private static readonly AudioClipPlayable.GetVolumeInternalDelegate GetVolumeInternalDelegateField;

		// Token: 0x040000C9 RID: 201
		private static readonly AudioClipPlayable.SetVolumeInternalDelegate SetVolumeInternalDelegateField;

		// Token: 0x040000CA RID: 202
		private static readonly AudioClipPlayable.GetStereoPanInternalDelegate GetStereoPanInternalDelegateField;

		// Token: 0x040000CB RID: 203
		private static readonly AudioClipPlayable.SetStereoPanInternalDelegate SetStereoPanInternalDelegateField;

		// Token: 0x040000CC RID: 204
		private static readonly AudioClipPlayable.GetSpatialBlendInternalDelegate GetSpatialBlendInternalDelegateField;

		// Token: 0x040000CD RID: 205
		private static readonly AudioClipPlayable.SetSpatialBlendInternalDelegate SetSpatialBlendInternalDelegateField;

		// Token: 0x040000CE RID: 206
		private static readonly AudioClipPlayable.GetIsChannelPlayingInternalDelegate GetIsChannelPlayingInternalDelegateField;

		// Token: 0x040000CF RID: 207
		private static readonly AudioClipPlayable.GetStartDelayInternalDelegate GetStartDelayInternalDelegateField;

		// Token: 0x040000D0 RID: 208
		private static readonly AudioClipPlayable.SetStartDelayInternalDelegate SetStartDelayInternalDelegateField;

		// Token: 0x040000D1 RID: 209
		private static readonly AudioClipPlayable.GetPauseDelayInternalDelegate GetPauseDelayInternalDelegateField;

		// Token: 0x040000D2 RID: 210
		private static readonly AudioClipPlayable.SetPauseDelayInternalDelegate SetPauseDelayInternalDelegateField;

		// Token: 0x040000D3 RID: 211
		private static readonly AudioClipPlayable.InternalCreateAudioClipPlayableDelegate InternalCreateAudioClipPlayableDelegateField;

		// Token: 0x040000D4 RID: 212
		private static readonly AudioClipPlayable.ValidateTypeDelegate ValidateTypeDelegateField;

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x0600028B RID: 651
		private delegate IntPtr GetClipInternalDelegate(IntPtr hdl);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x0600028D RID: 653
		private delegate void SetClipInternalDelegate(IntPtr hdl, IntPtr clip);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x0600028F RID: 655
		private delegate bool GetLoopedInternalDelegate(IntPtr hdl);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x06000291 RID: 657
		private delegate void SetLoopedInternalDelegate(IntPtr hdl, bool looped);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x06000293 RID: 659
		private delegate float GetVolumeInternalDelegate(IntPtr hdl);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x06000295 RID: 661
		private delegate void SetVolumeInternalDelegate(IntPtr hdl, float volume);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x06000297 RID: 663
		private delegate float GetStereoPanInternalDelegate(IntPtr hdl);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x06000299 RID: 665
		private delegate void SetStereoPanInternalDelegate(IntPtr hdl, float stereoPan);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x0600029B RID: 667
		private delegate float GetSpatialBlendInternalDelegate(IntPtr hdl);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x0600029D RID: 669
		private delegate void SetSpatialBlendInternalDelegate(IntPtr hdl, float spatialBlend);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x0600029F RID: 671
		private delegate bool GetIsChannelPlayingInternalDelegate(IntPtr hdl);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x060002A1 RID: 673
		private delegate double GetStartDelayInternalDelegate(IntPtr hdl);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x060002A3 RID: 675
		private delegate void SetStartDelayInternalDelegate(IntPtr hdl, double delay);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x060002A5 RID: 677
		private delegate double GetPauseDelayInternalDelegate(IntPtr hdl);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x060002A7 RID: 679
		private delegate void SetPauseDelayInternalDelegate(IntPtr hdl, double delay);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x060002A9 RID: 681
		private delegate bool InternalCreateAudioClipPlayableDelegate(IntPtr graph, IntPtr clip, bool looping, IntPtr handle);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x060002AB RID: 683
		private delegate bool ValidateTypeDelegate(IntPtr hdl);
	}
}

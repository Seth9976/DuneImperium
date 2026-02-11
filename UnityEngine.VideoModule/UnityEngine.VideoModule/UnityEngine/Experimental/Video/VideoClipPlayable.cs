using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;
using UnityEngine.Video;

namespace UnityEngine.Experimental.Video
{
	// Token: 0x02000002 RID: 2
	[StructLayout(2)]
	public struct VideoClipPlayable
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002E1C File Offset: 0x0000101C
		// Note: this type is marked as 'beforefieldinit'.
		static VideoClipPlayable()
		{
			Il2CppClassPointerStore<VideoClipPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VideoModule.dll", "UnityEngine.Experimental.Video", "VideoClipPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoClipPlayable>.NativeClassPtr);
			VideoClipPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoClipPlayable>.NativeClassPtr, "m_Handle");
			VideoClipPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoClipPlayable>.NativeClassPtr, 100663297);
			VideoClipPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VideoClipPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoClipPlayable>.NativeClassPtr, 100663298);
			VideoClipPlayable.GetClipInternalDelegateField = IL2CPP.ResolveICall<VideoClipPlayable.GetClipInternalDelegate>("UnityEngine.Experimental.Video.VideoClipPlayable::GetClipInternal");
			VideoClipPlayable.SetClipInternalDelegateField = IL2CPP.ResolveICall<VideoClipPlayable.SetClipInternalDelegate>("UnityEngine.Experimental.Video.VideoClipPlayable::SetClipInternal");
			VideoClipPlayable.GetLoopedInternalDelegateField = IL2CPP.ResolveICall<VideoClipPlayable.GetLoopedInternalDelegate>("UnityEngine.Experimental.Video.VideoClipPlayable::GetLoopedInternal");
			VideoClipPlayable.SetLoopedInternalDelegateField = IL2CPP.ResolveICall<VideoClipPlayable.SetLoopedInternalDelegate>("UnityEngine.Experimental.Video.VideoClipPlayable::SetLoopedInternal");
			VideoClipPlayable.GetIsPlayingInternalDelegateField = IL2CPP.ResolveICall<VideoClipPlayable.GetIsPlayingInternalDelegate>("UnityEngine.Experimental.Video.VideoClipPlayable::GetIsPlayingInternal");
			VideoClipPlayable.GetStartDelayInternalDelegateField = IL2CPP.ResolveICall<VideoClipPlayable.GetStartDelayInternalDelegate>("UnityEngine.Experimental.Video.VideoClipPlayable::GetStartDelayInternal");
			VideoClipPlayable.SetStartDelayInternalDelegateField = IL2CPP.ResolveICall<VideoClipPlayable.SetStartDelayInternalDelegate>("UnityEngine.Experimental.Video.VideoClipPlayable::SetStartDelayInternal");
			VideoClipPlayable.GetPauseDelayInternalDelegateField = IL2CPP.ResolveICall<VideoClipPlayable.GetPauseDelayInternalDelegate>("UnityEngine.Experimental.Video.VideoClipPlayable::GetPauseDelayInternal");
			VideoClipPlayable.SetPauseDelayInternalDelegateField = IL2CPP.ResolveICall<VideoClipPlayable.SetPauseDelayInternalDelegate>("UnityEngine.Experimental.Video.VideoClipPlayable::SetPauseDelayInternal");
			VideoClipPlayable.InternalCreateVideoClipPlayableDelegateField = IL2CPP.ResolveICall<VideoClipPlayable.InternalCreateVideoClipPlayableDelegate>("UnityEngine.Experimental.Video.VideoClipPlayable::InternalCreateVideoClipPlayable");
			VideoClipPlayable.ValidateTypeDelegateField = IL2CPP.ResolveICall<VideoClipPlayable.ValidateTypeDelegate>("UnityEngine.Experimental.Video.VideoClipPlayable::ValidateType");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002F30 File Offset: 0x00001130
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoClipPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002F60 File Offset: 0x00001160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270790, XrefRangeEnd = 1270794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(VideoClipPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VideoClipPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VideoClipPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VideoClipPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002FA0 File Offset: 0x000011A0
		public static VideoClipPlayable Create(PlayableGraph graph, VideoClip clip, bool looping)
		{
			PlayableHandle playableHandle = VideoClipPlayable.CreateHandle(graph, clip, looping);
			VideoClipPlayable videoClipPlayable = new VideoClipPlayable(playableHandle);
			bool flag = clip != null;
			if (flag)
			{
				PlayableExtensions.SetDuration<VideoClipPlayable>(videoClipPlayable, clip.length);
			}
			return videoClipPlayable;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002FDC File Offset: 0x000011DC
		public static PlayableHandle CreateHandle(PlayableGraph graph, VideoClip clip, bool looping)
		{
			PlayableHandle @null = PlayableHandle.Null;
			bool flag = !VideoClipPlayable.InternalCreateVideoClipPlayable(ref graph, clip, looping, ref @null);
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

		// Token: 0x06000007 RID: 7 RVA: 0x00003010 File Offset: 0x00001210
		public static implicit operator Playable(VideoClipPlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00003030 File Offset: 0x00001230
		public static explicit operator VideoClipPlayable(Playable playable)
		{
			return new VideoClipPlayable(playable.GetHandle());
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00003050 File Offset: 0x00001250
		public VideoClip GetClip()
		{
			return VideoClipPlayable.GetClipInternal(ref this.m_Handle);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002062 File Offset: 0x00000262
		public void SetClip(VideoClip value)
		{
			VideoClipPlayable.SetClipInternal(ref this.m_Handle, value);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00003070 File Offset: 0x00001270
		public bool GetLooped()
		{
			return VideoClipPlayable.GetLoopedInternal(ref this.m_Handle);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002072 File Offset: 0x00000272
		public void SetLooped(bool value)
		{
			VideoClipPlayable.SetLoopedInternal(ref this.m_Handle, value);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00003090 File Offset: 0x00001290
		public bool IsPlaying()
		{
			return VideoClipPlayable.GetIsPlayingInternal(ref this.m_Handle);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000030B0 File Offset: 0x000012B0
		public double GetStartDelay()
		{
			return VideoClipPlayable.GetStartDelayInternal(ref this.m_Handle);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002082 File Offset: 0x00000282
		public void SetStartDelay(double value)
		{
			this.ValidateStartDelayInternal(value);
			VideoClipPlayable.SetStartDelayInternal(ref this.m_Handle, value);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000030D0 File Offset: 0x000012D0
		public double GetPauseDelay()
		{
			return VideoClipPlayable.GetPauseDelayInternal(ref this.m_Handle);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000030F0 File Offset: 0x000012F0
		public void GetPauseDelay(double value)
		{
			double pauseDelayInternal = VideoClipPlayable.GetPauseDelayInternal(ref this.m_Handle);
			bool flag = this.m_Handle.GetPlayState() == PlayState.Playing && (value < 0.05 || (pauseDelayInternal != 0.0 && pauseDelayInternal < 0.05));
			if (flag)
			{
				throw new ArgumentException(String.Concat("VideoClipPlayable.pauseDelay: Setting new delay when existing delay is too small or 0.0 (", pauseDelayInternal.ToString(), "), Video system will not be able to change in time"));
			}
			VideoClipPlayable.SetPauseDelayInternal(ref this.m_Handle, value);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000209A File Offset: 0x0000029A
		public void Seek(double startTime, double startDelay)
		{
			this.Seek(startTime, startDelay, 0.0);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003174 File Offset: 0x00001374
		public void Seek(double startTime, double startDelay, double duration)
		{
			this.ValidateStartDelayInternal(startDelay);
			VideoClipPlayable.SetStartDelayInternal(ref this.m_Handle, startDelay);
			bool flag = duration > 0.0;
			if (flag)
			{
				this.m_Handle.SetDuration(duration + startTime);
				VideoClipPlayable.SetPauseDelayInternal(ref this.m_Handle, startDelay + duration);
			}
			else
			{
				this.m_Handle.SetDuration(double.MaxValue);
				VideoClipPlayable.SetPauseDelayInternal(ref this.m_Handle, 0.0);
			}
			this.m_Handle.SetTime(startTime);
			this.m_Handle.Play();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003210 File Offset: 0x00001410
		public void ValidateStartDelayInternal(double startDelay)
		{
			double startDelayInternal = VideoClipPlayable.GetStartDelayInternal(ref this.m_Handle);
			bool flag = this.IsPlaying() && (startDelay < 0.05 || (startDelayInternal >= 1E-05 && startDelayInternal < 0.05));
			if (flag)
			{
				Debug.LogWarning(String.Concat("VideoClipPlayable.StartDelay: Setting new delay when existing delay is too small or 0.0 (", startDelayInternal.ToString(), "), Video system will not be able to change in time"));
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003284 File Offset: 0x00001484
		public static VideoClip GetClipInternal(ref PlayableHandle hdl)
		{
			IntPtr intPtr = VideoClipPlayable.GetClipInternalDelegateField(ref hdl);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<VideoClip>(intPtr2) : null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020AF File Offset: 0x000002AF
		public static void SetClipInternal(ref PlayableHandle hdl, VideoClip clip)
		{
			VideoClipPlayable.SetClipInternalDelegateField(ref hdl, IL2CPP.Il2CppObjectBaseToPtr(clip));
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000020C2 File Offset: 0x000002C2
		public static bool GetLoopedInternal(ref PlayableHandle hdl)
		{
			return VideoClipPlayable.GetLoopedInternalDelegateField(ref hdl);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000020CF File Offset: 0x000002CF
		public static void SetLoopedInternal(ref PlayableHandle hdl, bool looped)
		{
			VideoClipPlayable.SetLoopedInternalDelegateField(ref hdl, looped);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020DD File Offset: 0x000002DD
		public static bool GetIsPlayingInternal(ref PlayableHandle hdl)
		{
			return VideoClipPlayable.GetIsPlayingInternalDelegateField(ref hdl);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020EA File Offset: 0x000002EA
		public static double GetStartDelayInternal(ref PlayableHandle hdl)
		{
			return VideoClipPlayable.GetStartDelayInternalDelegateField(ref hdl);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000020F7 File Offset: 0x000002F7
		public static void SetStartDelayInternal(ref PlayableHandle hdl, double delay)
		{
			VideoClipPlayable.SetStartDelayInternalDelegateField(ref hdl, delay);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002105 File Offset: 0x00000305
		public static double GetPauseDelayInternal(ref PlayableHandle hdl)
		{
			return VideoClipPlayable.GetPauseDelayInternalDelegateField(ref hdl);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002112 File Offset: 0x00000312
		public static void SetPauseDelayInternal(ref PlayableHandle hdl, double delay)
		{
			VideoClipPlayable.SetPauseDelayInternalDelegateField(ref hdl, delay);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002120 File Offset: 0x00000320
		public static bool InternalCreateVideoClipPlayable(ref PlayableGraph graph, VideoClip clip, bool looping, ref PlayableHandle handle)
		{
			return VideoClipPlayable.InternalCreateVideoClipPlayableDelegateField(ref graph, IL2CPP.Il2CppObjectBaseToPtr(clip), looping, ref handle);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002135 File Offset: 0x00000335
		public static bool ValidateType(ref PlayableHandle hdl)
		{
			return VideoClipPlayable.ValidateTypeDelegateField(ref hdl);
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VideoClipPlayable_0;

		// Token: 0x04000004 RID: 4
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x04000005 RID: 5
		private static readonly VideoClipPlayable.GetClipInternalDelegate GetClipInternalDelegateField;

		// Token: 0x04000006 RID: 6
		private static readonly VideoClipPlayable.SetClipInternalDelegate SetClipInternalDelegateField;

		// Token: 0x04000007 RID: 7
		private static readonly VideoClipPlayable.GetLoopedInternalDelegate GetLoopedInternalDelegateField;

		// Token: 0x04000008 RID: 8
		private static readonly VideoClipPlayable.SetLoopedInternalDelegate SetLoopedInternalDelegateField;

		// Token: 0x04000009 RID: 9
		private static readonly VideoClipPlayable.GetIsPlayingInternalDelegate GetIsPlayingInternalDelegateField;

		// Token: 0x0400000A RID: 10
		private static readonly VideoClipPlayable.GetStartDelayInternalDelegate GetStartDelayInternalDelegateField;

		// Token: 0x0400000B RID: 11
		private static readonly VideoClipPlayable.SetStartDelayInternalDelegate SetStartDelayInternalDelegateField;

		// Token: 0x0400000C RID: 12
		private static readonly VideoClipPlayable.GetPauseDelayInternalDelegate GetPauseDelayInternalDelegateField;

		// Token: 0x0400000D RID: 13
		private static readonly VideoClipPlayable.SetPauseDelayInternalDelegate SetPauseDelayInternalDelegateField;

		// Token: 0x0400000E RID: 14
		private static readonly VideoClipPlayable.InternalCreateVideoClipPlayableDelegate InternalCreateVideoClipPlayableDelegateField;

		// Token: 0x0400000F RID: 15
		private static readonly VideoClipPlayable.ValidateTypeDelegate ValidateTypeDelegateField;

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x060000DF RID: 223
		private delegate IntPtr GetClipInternalDelegate(IntPtr hdl);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x060000E1 RID: 225
		private delegate void SetClipInternalDelegate(IntPtr hdl, IntPtr clip);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x060000E3 RID: 227
		private delegate bool GetLoopedInternalDelegate(IntPtr hdl);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x060000E5 RID: 229
		private delegate void SetLoopedInternalDelegate(IntPtr hdl, bool looped);

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x060000E7 RID: 231
		private delegate bool GetIsPlayingInternalDelegate(IntPtr hdl);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x060000E9 RID: 233
		private delegate double GetStartDelayInternalDelegate(IntPtr hdl);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x060000EB RID: 235
		private delegate void SetStartDelayInternalDelegate(IntPtr hdl, double delay);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x060000ED RID: 237
		private delegate double GetPauseDelayInternalDelegate(IntPtr hdl);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x060000EF RID: 239
		private delegate void SetPauseDelayInternalDelegate(IntPtr hdl, double delay);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x060000F1 RID: 241
		private delegate bool InternalCreateVideoClipPlayableDelegate(IntPtr graph, IntPtr clip, bool looping, IntPtr handle);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x060000F3 RID: 243
		private delegate bool ValidateTypeDelegate(IntPtr hdl);
	}
}

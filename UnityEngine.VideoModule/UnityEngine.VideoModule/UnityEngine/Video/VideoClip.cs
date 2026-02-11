using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Video
{
	// Token: 0x02000003 RID: 3
	public sealed class VideoClip : Object
	{
		// Token: 0x06000020 RID: 32 RVA: 0x000032AC File Offset: 0x000014AC
		// Note: this type is marked as 'beforefieldinit'.
		static VideoClip()
		{
			Il2CppClassPointerStore<VideoClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VideoModule.dll", "UnityEngine.Video", "VideoClip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoClip>.NativeClassPtr);
			VideoClip.get_originalPathDelegateField = IL2CPP.ResolveICall<VideoClip.get_originalPathDelegate>("UnityEngine.Video.VideoClip::get_originalPath");
			VideoClip.get_frameCountDelegateField = IL2CPP.ResolveICall<VideoClip.get_frameCountDelegate>("UnityEngine.Video.VideoClip::get_frameCount");
			VideoClip.get_frameRateDelegateField = IL2CPP.ResolveICall<VideoClip.get_frameRateDelegate>("UnityEngine.Video.VideoClip::get_frameRate");
			VideoClip.get_lengthDelegateField = IL2CPP.ResolveICall<VideoClip.get_lengthDelegate>("UnityEngine.Video.VideoClip::get_length");
			VideoClip.get_widthDelegateField = IL2CPP.ResolveICall<VideoClip.get_widthDelegate>("UnityEngine.Video.VideoClip::get_width");
			VideoClip.get_heightDelegateField = IL2CPP.ResolveICall<VideoClip.get_heightDelegate>("UnityEngine.Video.VideoClip::get_height");
			VideoClip.get_pixelAspectRatioNumeratorDelegateField = IL2CPP.ResolveICall<VideoClip.get_pixelAspectRatioNumeratorDelegate>("UnityEngine.Video.VideoClip::get_pixelAspectRatioNumerator");
			VideoClip.get_pixelAspectRatioDenominatorDelegateField = IL2CPP.ResolveICall<VideoClip.get_pixelAspectRatioDenominatorDelegate>("UnityEngine.Video.VideoClip::get_pixelAspectRatioDenominator");
			VideoClip.get_sRGBDelegateField = IL2CPP.ResolveICall<VideoClip.get_sRGBDelegate>("UnityEngine.Video.VideoClip::get_sRGB");
			VideoClip.get_audioTrackCountDelegateField = IL2CPP.ResolveICall<VideoClip.get_audioTrackCountDelegate>("UnityEngine.Video.VideoClip::get_audioTrackCount");
			VideoClip.GetAudioChannelCountDelegateField = IL2CPP.ResolveICall<VideoClip.GetAudioChannelCountDelegate>("UnityEngine.Video.VideoClip::GetAudioChannelCount");
			VideoClip.GetAudioSampleRateDelegateField = IL2CPP.ResolveICall<VideoClip.GetAudioSampleRateDelegate>("UnityEngine.Video.VideoClip::GetAudioSampleRate");
			VideoClip.GetAudioLanguageDelegateField = IL2CPP.ResolveICall<VideoClip.GetAudioLanguageDelegate>("UnityEngine.Video.VideoClip::GetAudioLanguage");
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002142 File Offset: 0x00000342
		public VideoClip(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000033A0 File Offset: 0x000015A0
		public string originalPath
		{
			get
			{
				IntPtr intPtr = VideoClip.get_originalPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000023 RID: 35 RVA: 0x0000214B File Offset: 0x0000034B
		public ulong frameCount
		{
			get
			{
				return VideoClip.get_frameCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000024 RID: 36 RVA: 0x0000215D File Offset: 0x0000035D
		public double frameRate
		{
			get
			{
				return VideoClip.get_frameRateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000025 RID: 37 RVA: 0x0000216F File Offset: 0x0000036F
		public double length
		{
			get
			{
				return VideoClip.get_lengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002181 File Offset: 0x00000381
		public uint width
		{
			get
			{
				return VideoClip.get_widthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002193 File Offset: 0x00000393
		public uint height
		{
			get
			{
				return VideoClip.get_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000021A5 File Offset: 0x000003A5
		public uint pixelAspectRatioNumerator
		{
			get
			{
				return VideoClip.get_pixelAspectRatioNumeratorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000021B7 File Offset: 0x000003B7
		public uint pixelAspectRatioDenominator
		{
			get
			{
				return VideoClip.get_pixelAspectRatioDenominatorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000021C9 File Offset: 0x000003C9
		public bool sRGB
		{
			get
			{
				return VideoClip.get_sRGBDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000021DB File Offset: 0x000003DB
		public ushort audioTrackCount
		{
			get
			{
				return VideoClip.get_audioTrackCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000021ED File Offset: 0x000003ED
		public ushort GetAudioChannelCount(ushort audioTrackIdx)
		{
			return VideoClip.GetAudioChannelCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), audioTrackIdx);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002200 File Offset: 0x00000400
		public uint GetAudioSampleRate(ushort audioTrackIdx)
		{
			return VideoClip.GetAudioSampleRateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), audioTrackIdx);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000033C4 File Offset: 0x000015C4
		public string GetAudioLanguage(ushort audioTrackIdx)
		{
			IntPtr intPtr = VideoClip.GetAudioLanguageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), audioTrackIdx);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x04000010 RID: 16
		private static readonly VideoClip.get_originalPathDelegate get_originalPathDelegateField;

		// Token: 0x04000011 RID: 17
		private static readonly VideoClip.get_frameCountDelegate get_frameCountDelegateField;

		// Token: 0x04000012 RID: 18
		private static readonly VideoClip.get_frameRateDelegate get_frameRateDelegateField;

		// Token: 0x04000013 RID: 19
		private static readonly VideoClip.get_lengthDelegate get_lengthDelegateField;

		// Token: 0x04000014 RID: 20
		private static readonly VideoClip.get_widthDelegate get_widthDelegateField;

		// Token: 0x04000015 RID: 21
		private static readonly VideoClip.get_heightDelegate get_heightDelegateField;

		// Token: 0x04000016 RID: 22
		private static readonly VideoClip.get_pixelAspectRatioNumeratorDelegate get_pixelAspectRatioNumeratorDelegateField;

		// Token: 0x04000017 RID: 23
		private static readonly VideoClip.get_pixelAspectRatioDenominatorDelegate get_pixelAspectRatioDenominatorDelegateField;

		// Token: 0x04000018 RID: 24
		private static readonly VideoClip.get_sRGBDelegate get_sRGBDelegateField;

		// Token: 0x04000019 RID: 25
		private static readonly VideoClip.get_audioTrackCountDelegate get_audioTrackCountDelegateField;

		// Token: 0x0400001A RID: 26
		private static readonly VideoClip.GetAudioChannelCountDelegate GetAudioChannelCountDelegateField;

		// Token: 0x0400001B RID: 27
		private static readonly VideoClip.GetAudioSampleRateDelegate GetAudioSampleRateDelegateField;

		// Token: 0x0400001C RID: 28
		private static readonly VideoClip.GetAudioLanguageDelegate GetAudioLanguageDelegateField;

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x060000F5 RID: 245
		private delegate IntPtr get_originalPathDelegate(IntPtr @this);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x060000F7 RID: 247
		private delegate ulong get_frameCountDelegate(IntPtr @this);

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x060000F9 RID: 249
		private delegate double get_frameRateDelegate(IntPtr @this);

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x060000FB RID: 251
		private delegate double get_lengthDelegate(IntPtr @this);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x060000FD RID: 253
		private delegate uint get_widthDelegate(IntPtr @this);

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x060000FF RID: 255
		private delegate uint get_heightDelegate(IntPtr @this);

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x06000101 RID: 257
		private delegate uint get_pixelAspectRatioNumeratorDelegate(IntPtr @this);

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x06000103 RID: 259
		private delegate uint get_pixelAspectRatioDenominatorDelegate(IntPtr @this);

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x06000105 RID: 261
		private delegate bool get_sRGBDelegate(IntPtr @this);

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x06000107 RID: 263
		private delegate ushort get_audioTrackCountDelegate(IntPtr @this);

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x06000109 RID: 265
		private delegate ushort GetAudioChannelCountDelegate(IntPtr @this, ushort audioTrackIdx);

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x0600010B RID: 267
		private delegate uint GetAudioSampleRateDelegate(IntPtr @this, ushort audioTrackIdx);

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x0600010D RID: 269
		private delegate IntPtr GetAudioLanguageDelegate(IntPtr @this, ushort audioTrackIdx);
	}
}

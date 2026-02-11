using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Audio;
using UnityEngine.Video;

namespace UnityEngine.Experimental.Video
{
	// Token: 0x0200000D RID: 13
	public static class VideoPlayerExtensions
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x00003FB4 File Offset: 0x000021B4
		public static AudioSampleProvider GetAudioSampleProvider(VideoPlayer vp, ushort trackIndex)
		{
			ushort controlledAudioTrackCount = vp.controlledAudioTrackCount;
			bool flag = trackIndex >= controlledAudioTrackCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("trackIndex", trackIndex, String.Concat("VideoPlayer is currently configured with ", controlledAudioTrackCount.ToString(), " tracks."));
			}
			VideoAudioOutputMode audioOutputMode = vp.audioOutputMode;
			bool flag2 = audioOutputMode != VideoAudioOutputMode.APIOnly;
			if (flag2)
			{
				throw new InvalidOperationException(String.Concat("VideoPlayer.GetAudioSampleProvider requires audioOutputMode to be APIOnly. Current: ", audioOutputMode.ToString()));
			}
			AudioSampleProvider audioSampleProvider = AudioSampleProvider.Lookup(VideoPlayerExtensions.InternalGetAudioSampleProviderId(vp, trackIndex), vp, trackIndex);
			bool flag3 = audioSampleProvider == null;
			if (flag3)
			{
				throw new InvalidOperationException("VideoPlayer.GetAudioSampleProvider got null provider.");
			}
			bool flag4 = audioSampleProvider.owner != vp;
			if (flag4)
			{
				throw new InvalidOperationException("Internal error: VideoPlayer.GetAudioSampleProvider got provider used by another object.");
			}
			bool flag5 = audioSampleProvider.trackIndex != trackIndex;
			if (flag5)
			{
				throw new InvalidOperationException(String.Concat("Internal error: VideoPlayer.GetAudioSampleProvider got provider for track ", audioSampleProvider.trackIndex.ToString(), " instead of ", trackIndex.ToString()));
			}
			return audioSampleProvider;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000029B4 File Offset: 0x00000BB4
		public static uint InternalGetAudioSampleProviderId(VideoPlayer vp, ushort trackIndex)
		{
			return VideoPlayerExtensions.InternalGetAudioSampleProviderIdDelegateField(IL2CPP.Il2CppObjectBaseToPtr(vp), trackIndex);
		}

		// Token: 0x040000A8 RID: 168
		private static readonly VideoPlayerExtensions.InternalGetAudioSampleProviderIdDelegate InternalGetAudioSampleProviderIdDelegateField = IL2CPP.ResolveICall<VideoPlayerExtensions.InternalGetAudioSampleProviderIdDelegate>("UnityEngine.Experimental.Video.VideoPlayerExtensions::InternalGetAudioSampleProviderId");

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x060001D9 RID: 473
		private delegate uint InternalGetAudioSampleProviderIdDelegate(IntPtr vp, ushort trackIndex);
	}
}

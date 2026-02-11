using System;
using Il2CppInterop.Runtime;

namespace UnityEngineInternal.Video
{
	// Token: 0x02000012 RID: 18
	public class VideoPlaybackMgr
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x00002BF5 File Offset: 0x00000DF5
		public void Dispose()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002C02 File Offset: 0x00000E02
		public static IntPtr Internal_Create()
		{
			return VideoPlaybackMgr.Internal_CreateDelegateField();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002C0E File Offset: 0x00000E0E
		public static void Internal_Destroy(IntPtr ptr)
		{
			VideoPlaybackMgr.Internal_DestroyDelegateField(ptr);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002C1B File Offset: 0x00000E1B
		public void ReleaseVideoPlayback(VideoPlayback playback)
		{
			VideoPlaybackMgr.ReleaseVideoPlaybackDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(playback));
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00002C33 File Offset: 0x00000E33
		public ulong videoPlaybackCount
		{
			get
			{
				return VideoPlaybackMgr.get_videoPlaybackCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002C45 File Offset: 0x00000E45
		public void Update()
		{
			VideoPlaybackMgr.UpdateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002C57 File Offset: 0x00000E57
		public static void ProcessOSMainLoopMessagesForTesting()
		{
			VideoPlaybackMgr.ProcessOSMainLoopMessagesForTestingDelegateField();
		}

		// Token: 0x040000DB RID: 219
		private static readonly VideoPlaybackMgr.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<VideoPlaybackMgr.Internal_CreateDelegate>("UnityEngineInternal.Video.VideoPlaybackMgr::Internal_Create");

		// Token: 0x040000DC RID: 220
		private static readonly VideoPlaybackMgr.Internal_DestroyDelegate Internal_DestroyDelegateField = IL2CPP.ResolveICall<VideoPlaybackMgr.Internal_DestroyDelegate>("UnityEngineInternal.Video.VideoPlaybackMgr::Internal_Destroy");

		// Token: 0x040000DD RID: 221
		private static readonly VideoPlaybackMgr.ReleaseVideoPlaybackDelegate ReleaseVideoPlaybackDelegateField = IL2CPP.ResolveICall<VideoPlaybackMgr.ReleaseVideoPlaybackDelegate>("UnityEngineInternal.Video.VideoPlaybackMgr::ReleaseVideoPlayback");

		// Token: 0x040000DE RID: 222
		private static readonly VideoPlaybackMgr.get_videoPlaybackCountDelegate get_videoPlaybackCountDelegateField = IL2CPP.ResolveICall<VideoPlaybackMgr.get_videoPlaybackCountDelegate>("UnityEngineInternal.Video.VideoPlaybackMgr::get_videoPlaybackCount");

		// Token: 0x040000DF RID: 223
		private static readonly VideoPlaybackMgr.UpdateDelegate UpdateDelegateField = IL2CPP.ResolveICall<VideoPlaybackMgr.UpdateDelegate>("UnityEngineInternal.Video.VideoPlaybackMgr::Update");

		// Token: 0x040000E0 RID: 224
		private static readonly VideoPlaybackMgr.ProcessOSMainLoopMessagesForTestingDelegate ProcessOSMainLoopMessagesForTestingDelegateField = IL2CPP.ResolveICall<VideoPlaybackMgr.ProcessOSMainLoopMessagesForTestingDelegate>("UnityEngineInternal.Video.VideoPlaybackMgr::ProcessOSMainLoopMessagesForTesting");

		// Token: 0x020000A6 RID: 166
		// (Invoke) Token: 0x06000219 RID: 537
		private delegate IntPtr Internal_CreateDelegate();

		// Token: 0x020000A7 RID: 167
		// (Invoke) Token: 0x0600021B RID: 539
		private delegate void Internal_DestroyDelegate(IntPtr ptr);

		// Token: 0x020000A8 RID: 168
		// (Invoke) Token: 0x0600021D RID: 541
		private delegate void ReleaseVideoPlaybackDelegate(IntPtr @this, IntPtr playback);

		// Token: 0x020000A9 RID: 169
		// (Invoke) Token: 0x0600021F RID: 543
		private delegate ulong get_videoPlaybackCountDelegate(IntPtr @this);

		// Token: 0x020000AA RID: 170
		// (Invoke) Token: 0x06000221 RID: 545
		private delegate void UpdateDelegate(IntPtr @this);

		// Token: 0x020000AB RID: 171
		// (Invoke) Token: 0x06000223 RID: 547
		private delegate void ProcessOSMainLoopMessagesForTestingDelegate();
	}
}

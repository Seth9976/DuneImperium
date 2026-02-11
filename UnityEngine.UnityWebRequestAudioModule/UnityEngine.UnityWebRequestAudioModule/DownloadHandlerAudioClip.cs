using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Networking
{
	// Token: 0x02000002 RID: 2
	public sealed class DownloadHandlerAudioClip : DownloadHandler
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		public static IntPtr Create(DownloadHandlerAudioClip obj, string url, AudioType audioType)
		{
			return DownloadHandlerAudioClip.CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj), IL2CPP.ManagedStringToIl2Cpp(url), audioType);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002069 File Offset: 0x00000269
		public void InternalCreateAudioClip(string url, AudioType audioType)
		{
			base.m_Ptr = DownloadHandlerAudioClip.Create(this, url, audioType);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000207A File Offset: 0x0000027A
		public override NativeArray<byte> GetNativeData()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002087 File Offset: 0x00000287
		public override void Dispose()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002094 File Offset: 0x00000294
		public override string GetText()
		{
			throw new NotSupportedException("String access is not supported for audio clips");
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002170 File Offset: 0x00000370
		public AudioClip audioClip
		{
			get
			{
				IntPtr intPtr = DownloadHandlerAudioClip.get_audioClipDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000020A1 File Offset: 0x000002A1
		// (set) Token: 0x06000009 RID: 9 RVA: 0x000020B3 File Offset: 0x000002B3
		public bool streamAudio
		{
			get
			{
				return DownloadHandlerAudioClip.get_streamAudioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				DownloadHandlerAudioClip.set_streamAudioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000020C6 File Offset: 0x000002C6
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000020D8 File Offset: 0x000002D8
		public bool compressed
		{
			get
			{
				return DownloadHandlerAudioClip.get_compressedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				DownloadHandlerAudioClip.set_compressedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000219C File Offset: 0x0000039C
		public static AudioClip GetContent(UnityWebRequest www)
		{
			return DownloadHandler.GetCheckedDownloader<DownloadHandlerAudioClip>(www).audioClip;
		}

		// Token: 0x04000001 RID: 1
		private static readonly DownloadHandlerAudioClip.CreateDelegate CreateDelegateField = IL2CPP.ResolveICall<DownloadHandlerAudioClip.CreateDelegate>("UnityEngine.Networking.DownloadHandlerAudioClip::Create");

		// Token: 0x04000002 RID: 2
		private static readonly DownloadHandlerAudioClip.get_audioClipDelegate get_audioClipDelegateField = IL2CPP.ResolveICall<DownloadHandlerAudioClip.get_audioClipDelegate>("UnityEngine.Networking.DownloadHandlerAudioClip::get_audioClip");

		// Token: 0x04000003 RID: 3
		private static readonly DownloadHandlerAudioClip.get_streamAudioDelegate get_streamAudioDelegateField = IL2CPP.ResolveICall<DownloadHandlerAudioClip.get_streamAudioDelegate>("UnityEngine.Networking.DownloadHandlerAudioClip::get_streamAudio");

		// Token: 0x04000004 RID: 4
		private static readonly DownloadHandlerAudioClip.set_streamAudioDelegate set_streamAudioDelegateField = IL2CPP.ResolveICall<DownloadHandlerAudioClip.set_streamAudioDelegate>("UnityEngine.Networking.DownloadHandlerAudioClip::set_streamAudio");

		// Token: 0x04000005 RID: 5
		private static readonly DownloadHandlerAudioClip.get_compressedDelegate get_compressedDelegateField = IL2CPP.ResolveICall<DownloadHandlerAudioClip.get_compressedDelegate>("UnityEngine.Networking.DownloadHandlerAudioClip::get_compressed");

		// Token: 0x04000006 RID: 6
		private static readonly DownloadHandlerAudioClip.set_compressedDelegate set_compressedDelegateField = IL2CPP.ResolveICall<DownloadHandlerAudioClip.set_compressedDelegate>("UnityEngine.Networking.DownloadHandlerAudioClip::set_compressed");

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x06000015 RID: 21
		private delegate IntPtr CreateDelegate(IntPtr obj, IntPtr url, AudioType audioType);

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000017 RID: 23
		private delegate IntPtr get_audioClipDelegate(IntPtr @this);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x06000019 RID: 25
		private delegate bool get_streamAudioDelegate(IntPtr @this);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x0600001B RID: 27
		private delegate void set_streamAudioDelegate(IntPtr @this, bool value);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x0600001D RID: 29
		private delegate bool get_compressedDelegate(IntPtr @this);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x0600001F RID: 31
		private delegate void set_compressedDelegate(IntPtr @this, bool value);
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using UnityEngine.Networking;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public class WWW : CustomYieldInstruction
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002158 File Offset: 0x00000358
		public static string EscapeURL(string s)
		{
			return WWW.EscapeURL(s, Encoding.UTF8);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002178 File Offset: 0x00000378
		public static string EscapeURL(string s, Encoding e)
		{
			return UnityWebRequest.EscapeURL(s, e);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002194 File Offset: 0x00000394
		public static string UnEscapeURL(string s)
		{
			return WWW.UnEscapeURL(s, Encoding.UTF8);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000021B4 File Offset: 0x000003B4
		public static string UnEscapeURL(string s, Encoding e)
		{
			return UnityWebRequest.UnEscapeURL(s, e);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021D0 File Offset: 0x000003D0
		public static WWW LoadFromCacheOrDownload(string url, int version)
		{
			return WWW.LoadFromCacheOrDownload(url, version, 0U);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021EC File Offset: 0x000003EC
		public static WWW LoadFromCacheOrDownload(string url, int version, uint crc)
		{
			Hash128 hash = new Hash128(0U, 0U, 0U, (uint)version);
			return WWW.LoadFromCacheOrDownload(url, hash, crc);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002214 File Offset: 0x00000414
		public static WWW LoadFromCacheOrDownload(string url, Hash128 hash)
		{
			return WWW.LoadFromCacheOrDownload(url, hash, 0U);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002230 File Offset: 0x00000430
		public static WWW LoadFromCacheOrDownload(string url, Hash128 hash, uint crc)
		{
			return new WWW(url, "", hash, crc);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002250 File Offset: 0x00000450
		public static WWW LoadFromCacheOrDownload(string url, CachedAssetBundle cachedBundle, [Optional] uint crc)
		{
			return new WWW(url, cachedBundle.name, cachedBundle.hash, crc);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		public AssetBundle assetBundle
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002278 File Offset: 0x00000478
		public Object audioClip
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0000205D File Offset: 0x0000025D
		public Il2CppStructArray<byte> bytes
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000D RID: 13 RVA: 0x0000228C File Offset: 0x0000048C
		public Object movie
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000022A0 File Offset: 0x000004A0
		public int size
		{
			get
			{
				return this.bytesDownloaded;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000F RID: 15 RVA: 0x0000206A File Offset: 0x0000026A
		public int bytesDownloaded
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002077 File Offset: 0x00000277
		public string error
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002084 File Offset: 0x00000284
		public bool isDone
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002091 File Offset: 0x00000291
		public float progress
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000013 RID: 19 RVA: 0x0000209E File Offset: 0x0000029E
		public Dictionary<string, string> responseHeaders
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000022B8 File Offset: 0x000004B8
		public string data
		{
			get
			{
				return this.text;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000020AB File Offset: 0x000002AB
		public string text
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020B8 File Offset: 0x000002B8
		public Texture2D CreateTextureFromDownloadedData(bool markNonReadable)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000022D0 File Offset: 0x000004D0
		public Texture2D texture
		{
			get
			{
				return this.CreateTextureFromDownloadedData(false);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000022EC File Offset: 0x000004EC
		public Texture2D textureNonReadable
		{
			get
			{
				return this.CreateTextureFromDownloadedData(true);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020C5 File Offset: 0x000002C5
		public void LoadImageIntoTexture(Texture2D texture)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000020D2 File Offset: 0x000002D2
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000020DF File Offset: 0x000002DF
		public ThreadPriority threadPriority
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000020EC File Offset: 0x000002EC
		public float uploadProgress
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000020F9 File Offset: 0x000002F9
		public string url
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002106 File Offset: 0x00000306
		public override bool keepWaiting
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002113 File Offset: 0x00000313
		public void Dispose()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002120 File Offset: 0x00000320
		public Object GetAudioClipInternal(bool threeD, bool stream, bool compressed, AudioType audioType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002308 File Offset: 0x00000508
		public AudioClip GetAudioClip()
		{
			return this.GetAudioClip(true, false, AudioType.UNKNOWN);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002324 File Offset: 0x00000524
		public AudioClip GetAudioClip(bool threeD)
		{
			return this.GetAudioClip(threeD, false, AudioType.UNKNOWN);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002340 File Offset: 0x00000540
		public AudioClip GetAudioClip(bool threeD, bool stream)
		{
			return this.GetAudioClip(threeD, stream, AudioType.UNKNOWN);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000235C File Offset: 0x0000055C
		public AudioClip GetAudioClip(bool threeD, bool stream, AudioType audioType)
		{
			return this.GetAudioClipInternal(threeD, stream, false, audioType).Cast<AudioClip>();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002380 File Offset: 0x00000580
		public AudioClip GetAudioClipCompressed()
		{
			return this.GetAudioClipCompressed(false, AudioType.UNKNOWN);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000239C File Offset: 0x0000059C
		public AudioClip GetAudioClipCompressed(bool threeD)
		{
			return this.GetAudioClipCompressed(threeD, AudioType.UNKNOWN);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000023B8 File Offset: 0x000005B8
		public AudioClip GetAudioClipCompressed(bool threeD, AudioType audioType)
		{
			return this.GetAudioClipInternal(threeD, false, true, audioType).Cast<AudioClip>();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000212D File Offset: 0x0000032D
		public MovieTexture GetMovieTexture()
		{
			throw new Exception("MovieTexture has been removed from Unity. Use VideoPlayer instead.");
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000213A File Offset: 0x0000033A
		public bool WaitUntilDoneIfPossible()
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}

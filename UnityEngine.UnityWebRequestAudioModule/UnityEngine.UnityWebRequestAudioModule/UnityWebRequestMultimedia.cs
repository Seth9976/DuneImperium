using System;

namespace UnityEngine.Networking
{
	// Token: 0x02000004 RID: 4
	public static class UnityWebRequestMultimedia
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002210 File Offset: 0x00000410
		public static UnityWebRequest GetAudioClip(string uri, AudioType audioType)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerAudioClip(uri, audioType), null);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002238 File Offset: 0x00000438
		public static UnityWebRequest GetMovieTexture(string uri)
		{
			return null;
		}
	}
}

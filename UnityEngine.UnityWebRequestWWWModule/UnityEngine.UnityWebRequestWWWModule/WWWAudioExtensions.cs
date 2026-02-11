using System;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public static class WWWAudioExtensions
	{
		// Token: 0x0600002A RID: 42 RVA: 0x000023DC File Offset: 0x000005DC
		public static AudioClip GetAudioClip(WWW www)
		{
			return www.GetAudioClip();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000023F4 File Offset: 0x000005F4
		public static AudioClip GetAudioClip(WWW www, bool threeD)
		{
			return www.GetAudioClip(threeD);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002410 File Offset: 0x00000610
		public static AudioClip GetAudioClip(WWW www, bool threeD, bool stream)
		{
			return www.GetAudioClip(threeD, stream);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000242C File Offset: 0x0000062C
		public static AudioClip GetAudioClip(WWW www, bool threeD, bool stream, AudioType audioType)
		{
			return www.GetAudioClip(threeD, stream, audioType);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002448 File Offset: 0x00000648
		public static AudioClip GetAudioClipCompressed(WWW www)
		{
			return www.GetAudioClipCompressed();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002460 File Offset: 0x00000660
		public static AudioClip GetAudioClipCompressed(WWW www, bool threeD)
		{
			return www.GetAudioClipCompressed(threeD);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000247C File Offset: 0x0000067C
		public static AudioClip GetAudioClipCompressed(WWW www, bool threeD, AudioType audioType)
		{
			return www.GetAudioClipCompressed(threeD, audioType);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002498 File Offset: 0x00000698
		public static MovieTexture GetMovieTexture(WWW www)
		{
			return www.GetMovieTexture();
		}
	}
}

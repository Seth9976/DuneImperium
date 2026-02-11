using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Networking
{
	// Token: 0x02000003 RID: 3
	public sealed class DownloadHandlerMovieTexture : DownloadHandler
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000021BC File Offset: 0x000003BC
		public override Il2CppStructArray<byte> GetData()
		{
			DownloadHandlerMovieTexture.FeatureRemoved();
			return null;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020EB File Offset: 0x000002EB
		public override string GetText()
		{
			throw new NotSupportedException("String access is not supported for movies");
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000021D8 File Offset: 0x000003D8
		public MovieTexture movieTexture
		{
			get
			{
				DownloadHandlerMovieTexture.FeatureRemoved();
				return null;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000021F4 File Offset: 0x000003F4
		public static MovieTexture GetContent(UnityWebRequest uwr)
		{
			DownloadHandlerMovieTexture.FeatureRemoved();
			return null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000020F8 File Offset: 0x000002F8
		public static void FeatureRemoved()
		{
			throw new Exception("Movie texture has been removed, use VideoPlayer instead");
		}
	}
}

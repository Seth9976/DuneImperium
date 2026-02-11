using System;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000022 RID: 34
	public sealed class MovieTexture : Texture
	{
		// Token: 0x060001DC RID: 476 RVA: 0x00002FA4 File Offset: 0x000011A4
		public static void FeatureRemoved()
		{
			throw new Exception("MovieTexture has been removed from Unity. Use VideoPlayer instead.");
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002FB1 File Offset: 0x000011B1
		public void Play()
		{
			MovieTexture.FeatureRemoved();
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002FBA File Offset: 0x000011BA
		public void Stop()
		{
			MovieTexture.FeatureRemoved();
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002FC3 File Offset: 0x000011C3
		public void Pause()
		{
			MovieTexture.FeatureRemoved();
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x000080A4 File Offset: 0x000062A4
		public AudioClip audioClip
		{
			get
			{
				MovieTexture.FeatureRemoved();
				return null;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x000080C0 File Offset: 0x000062C0
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x00002FCC File Offset: 0x000011CC
		public bool loop
		{
			get
			{
				MovieTexture.FeatureRemoved();
				return false;
			}
			set
			{
				MovieTexture.FeatureRemoved();
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x000080DC File Offset: 0x000062DC
		public bool isPlaying
		{
			get
			{
				MovieTexture.FeatureRemoved();
				return false;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x000080F8 File Offset: 0x000062F8
		public bool isReadyToPlay
		{
			get
			{
				MovieTexture.FeatureRemoved();
				return false;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00008114 File Offset: 0x00006314
		public float duration
		{
			get
			{
				MovieTexture.FeatureRemoved();
				return 1f;
			}
		}
	}
}

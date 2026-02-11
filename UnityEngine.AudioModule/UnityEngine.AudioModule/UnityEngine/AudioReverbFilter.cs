using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200001F RID: 31
	public sealed class AudioReverbFilter : Behaviour
	{
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00002CD0 File Offset: 0x00000ED0
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00002CE2 File Offset: 0x00000EE2
		public AudioReverbPreset reverbPreset
		{
			get
			{
				return AudioReverbFilter.get_reverbPresetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_reverbPresetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00002CF5 File Offset: 0x00000EF5
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00002D07 File Offset: 0x00000F07
		public float dryLevel
		{
			get
			{
				return AudioReverbFilter.get_dryLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_dryLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00002D1A File Offset: 0x00000F1A
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00002D2C File Offset: 0x00000F2C
		public float room
		{
			get
			{
				return AudioReverbFilter.get_roomDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_roomDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00002D3F File Offset: 0x00000F3F
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00002D51 File Offset: 0x00000F51
		public float roomHF
		{
			get
			{
				return AudioReverbFilter.get_roomHFDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_roomHFDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00007D50 File Offset: 0x00005F50
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00002D64 File Offset: 0x00000F64
		public float roomRolloffFactor
		{
			get
			{
				Debug.LogWarning("Warning! roomRolloffFactor is no longer supported.");
				return 10f;
			}
			set
			{
				Debug.LogWarning("Warning! roomRolloffFactor is no longer supported.");
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00002D72 File Offset: 0x00000F72
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00002D84 File Offset: 0x00000F84
		public float decayTime
		{
			get
			{
				return AudioReverbFilter.get_decayTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_decayTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00002D97 File Offset: 0x00000F97
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00002DA9 File Offset: 0x00000FA9
		public float decayHFRatio
		{
			get
			{
				return AudioReverbFilter.get_decayHFRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_decayHFRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00002DBC File Offset: 0x00000FBC
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00002DCE File Offset: 0x00000FCE
		public float reflectionsLevel
		{
			get
			{
				return AudioReverbFilter.get_reflectionsLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_reflectionsLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00002DE1 File Offset: 0x00000FE1
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002DF3 File Offset: 0x00000FF3
		public float reflectionsDelay
		{
			get
			{
				return AudioReverbFilter.get_reflectionsDelayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_reflectionsDelayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00002E06 File Offset: 0x00001006
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00002E18 File Offset: 0x00001018
		public float reverbLevel
		{
			get
			{
				return AudioReverbFilter.get_reverbLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_reverbLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00002E2B File Offset: 0x0000102B
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00002E3D File Offset: 0x0000103D
		public float reverbDelay
		{
			get
			{
				return AudioReverbFilter.get_reverbDelayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_reverbDelayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00002E50 File Offset: 0x00001050
		// (set) Token: 0x060001BA RID: 442 RVA: 0x00002E62 File Offset: 0x00001062
		public float diffusion
		{
			get
			{
				return AudioReverbFilter.get_diffusionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_diffusionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00002E75 File Offset: 0x00001075
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00002E87 File Offset: 0x00001087
		public float density
		{
			get
			{
				return AudioReverbFilter.get_densityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_densityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00002E9A File Offset: 0x0000109A
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00002EAC File Offset: 0x000010AC
		public float hfReference
		{
			get
			{
				return AudioReverbFilter.get_hfReferenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_hfReferenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00002EBF File Offset: 0x000010BF
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00002ED1 File Offset: 0x000010D1
		public float roomLF
		{
			get
			{
				return AudioReverbFilter.get_roomLFDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_roomLFDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00002EE4 File Offset: 0x000010E4
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00002EF6 File Offset: 0x000010F6
		public float lfReference
		{
			get
			{
				return AudioReverbFilter.get_lfReferenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_lfReferenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000175 RID: 373
		private static readonly AudioReverbFilter.get_reverbPresetDelegate get_reverbPresetDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_reverbPresetDelegate>("UnityEngine.AudioReverbFilter::get_reverbPreset");

		// Token: 0x04000176 RID: 374
		private static readonly AudioReverbFilter.set_reverbPresetDelegate set_reverbPresetDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_reverbPresetDelegate>("UnityEngine.AudioReverbFilter::set_reverbPreset");

		// Token: 0x04000177 RID: 375
		private static readonly AudioReverbFilter.get_dryLevelDelegate get_dryLevelDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_dryLevelDelegate>("UnityEngine.AudioReverbFilter::get_dryLevel");

		// Token: 0x04000178 RID: 376
		private static readonly AudioReverbFilter.set_dryLevelDelegate set_dryLevelDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_dryLevelDelegate>("UnityEngine.AudioReverbFilter::set_dryLevel");

		// Token: 0x04000179 RID: 377
		private static readonly AudioReverbFilter.get_roomDelegate get_roomDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_roomDelegate>("UnityEngine.AudioReverbFilter::get_room");

		// Token: 0x0400017A RID: 378
		private static readonly AudioReverbFilter.set_roomDelegate set_roomDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_roomDelegate>("UnityEngine.AudioReverbFilter::set_room");

		// Token: 0x0400017B RID: 379
		private static readonly AudioReverbFilter.get_roomHFDelegate get_roomHFDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_roomHFDelegate>("UnityEngine.AudioReverbFilter::get_roomHF");

		// Token: 0x0400017C RID: 380
		private static readonly AudioReverbFilter.set_roomHFDelegate set_roomHFDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_roomHFDelegate>("UnityEngine.AudioReverbFilter::set_roomHF");

		// Token: 0x0400017D RID: 381
		private static readonly AudioReverbFilter.get_decayTimeDelegate get_decayTimeDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_decayTimeDelegate>("UnityEngine.AudioReverbFilter::get_decayTime");

		// Token: 0x0400017E RID: 382
		private static readonly AudioReverbFilter.set_decayTimeDelegate set_decayTimeDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_decayTimeDelegate>("UnityEngine.AudioReverbFilter::set_decayTime");

		// Token: 0x0400017F RID: 383
		private static readonly AudioReverbFilter.get_decayHFRatioDelegate get_decayHFRatioDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_decayHFRatioDelegate>("UnityEngine.AudioReverbFilter::get_decayHFRatio");

		// Token: 0x04000180 RID: 384
		private static readonly AudioReverbFilter.set_decayHFRatioDelegate set_decayHFRatioDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_decayHFRatioDelegate>("UnityEngine.AudioReverbFilter::set_decayHFRatio");

		// Token: 0x04000181 RID: 385
		private static readonly AudioReverbFilter.get_reflectionsLevelDelegate get_reflectionsLevelDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_reflectionsLevelDelegate>("UnityEngine.AudioReverbFilter::get_reflectionsLevel");

		// Token: 0x04000182 RID: 386
		private static readonly AudioReverbFilter.set_reflectionsLevelDelegate set_reflectionsLevelDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_reflectionsLevelDelegate>("UnityEngine.AudioReverbFilter::set_reflectionsLevel");

		// Token: 0x04000183 RID: 387
		private static readonly AudioReverbFilter.get_reflectionsDelayDelegate get_reflectionsDelayDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_reflectionsDelayDelegate>("UnityEngine.AudioReverbFilter::get_reflectionsDelay");

		// Token: 0x04000184 RID: 388
		private static readonly AudioReverbFilter.set_reflectionsDelayDelegate set_reflectionsDelayDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_reflectionsDelayDelegate>("UnityEngine.AudioReverbFilter::set_reflectionsDelay");

		// Token: 0x04000185 RID: 389
		private static readonly AudioReverbFilter.get_reverbLevelDelegate get_reverbLevelDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_reverbLevelDelegate>("UnityEngine.AudioReverbFilter::get_reverbLevel");

		// Token: 0x04000186 RID: 390
		private static readonly AudioReverbFilter.set_reverbLevelDelegate set_reverbLevelDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_reverbLevelDelegate>("UnityEngine.AudioReverbFilter::set_reverbLevel");

		// Token: 0x04000187 RID: 391
		private static readonly AudioReverbFilter.get_reverbDelayDelegate get_reverbDelayDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_reverbDelayDelegate>("UnityEngine.AudioReverbFilter::get_reverbDelay");

		// Token: 0x04000188 RID: 392
		private static readonly AudioReverbFilter.set_reverbDelayDelegate set_reverbDelayDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_reverbDelayDelegate>("UnityEngine.AudioReverbFilter::set_reverbDelay");

		// Token: 0x04000189 RID: 393
		private static readonly AudioReverbFilter.get_diffusionDelegate get_diffusionDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_diffusionDelegate>("UnityEngine.AudioReverbFilter::get_diffusion");

		// Token: 0x0400018A RID: 394
		private static readonly AudioReverbFilter.set_diffusionDelegate set_diffusionDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_diffusionDelegate>("UnityEngine.AudioReverbFilter::set_diffusion");

		// Token: 0x0400018B RID: 395
		private static readonly AudioReverbFilter.get_densityDelegate get_densityDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_densityDelegate>("UnityEngine.AudioReverbFilter::get_density");

		// Token: 0x0400018C RID: 396
		private static readonly AudioReverbFilter.set_densityDelegate set_densityDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_densityDelegate>("UnityEngine.AudioReverbFilter::set_density");

		// Token: 0x0400018D RID: 397
		private static readonly AudioReverbFilter.get_hfReferenceDelegate get_hfReferenceDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_hfReferenceDelegate>("UnityEngine.AudioReverbFilter::get_hfReference");

		// Token: 0x0400018E RID: 398
		private static readonly AudioReverbFilter.set_hfReferenceDelegate set_hfReferenceDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_hfReferenceDelegate>("UnityEngine.AudioReverbFilter::set_hfReference");

		// Token: 0x0400018F RID: 399
		private static readonly AudioReverbFilter.get_roomLFDelegate get_roomLFDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_roomLFDelegate>("UnityEngine.AudioReverbFilter::get_roomLF");

		// Token: 0x04000190 RID: 400
		private static readonly AudioReverbFilter.set_roomLFDelegate set_roomLFDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_roomLFDelegate>("UnityEngine.AudioReverbFilter::set_roomLF");

		// Token: 0x04000191 RID: 401
		private static readonly AudioReverbFilter.get_lfReferenceDelegate get_lfReferenceDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_lfReferenceDelegate>("UnityEngine.AudioReverbFilter::get_lfReference");

		// Token: 0x04000192 RID: 402
		private static readonly AudioReverbFilter.set_lfReferenceDelegate set_lfReferenceDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_lfReferenceDelegate>("UnityEngine.AudioReverbFilter::set_lfReference");

		// Token: 0x020000B7 RID: 183
		// (Invoke) Token: 0x0600033B RID: 827
		private delegate AudioReverbPreset get_reverbPresetDelegate(IntPtr @this);

		// Token: 0x020000B8 RID: 184
		// (Invoke) Token: 0x0600033D RID: 829
		private delegate void set_reverbPresetDelegate(IntPtr @this, AudioReverbPreset value);

		// Token: 0x020000B9 RID: 185
		// (Invoke) Token: 0x0600033F RID: 831
		private delegate float get_dryLevelDelegate(IntPtr @this);

		// Token: 0x020000BA RID: 186
		// (Invoke) Token: 0x06000341 RID: 833
		private delegate void set_dryLevelDelegate(IntPtr @this, float value);

		// Token: 0x020000BB RID: 187
		// (Invoke) Token: 0x06000343 RID: 835
		private delegate float get_roomDelegate(IntPtr @this);

		// Token: 0x020000BC RID: 188
		// (Invoke) Token: 0x06000345 RID: 837
		private delegate void set_roomDelegate(IntPtr @this, float value);

		// Token: 0x020000BD RID: 189
		// (Invoke) Token: 0x06000347 RID: 839
		private delegate float get_roomHFDelegate(IntPtr @this);

		// Token: 0x020000BE RID: 190
		// (Invoke) Token: 0x06000349 RID: 841
		private delegate void set_roomHFDelegate(IntPtr @this, float value);

		// Token: 0x020000BF RID: 191
		// (Invoke) Token: 0x0600034B RID: 843
		private delegate float get_decayTimeDelegate(IntPtr @this);

		// Token: 0x020000C0 RID: 192
		// (Invoke) Token: 0x0600034D RID: 845
		private delegate void set_decayTimeDelegate(IntPtr @this, float value);

		// Token: 0x020000C1 RID: 193
		// (Invoke) Token: 0x0600034F RID: 847
		private delegate float get_decayHFRatioDelegate(IntPtr @this);

		// Token: 0x020000C2 RID: 194
		// (Invoke) Token: 0x06000351 RID: 849
		private delegate void set_decayHFRatioDelegate(IntPtr @this, float value);

		// Token: 0x020000C3 RID: 195
		// (Invoke) Token: 0x06000353 RID: 851
		private delegate float get_reflectionsLevelDelegate(IntPtr @this);

		// Token: 0x020000C4 RID: 196
		// (Invoke) Token: 0x06000355 RID: 853
		private delegate void set_reflectionsLevelDelegate(IntPtr @this, float value);

		// Token: 0x020000C5 RID: 197
		// (Invoke) Token: 0x06000357 RID: 855
		private delegate float get_reflectionsDelayDelegate(IntPtr @this);

		// Token: 0x020000C6 RID: 198
		// (Invoke) Token: 0x06000359 RID: 857
		private delegate void set_reflectionsDelayDelegate(IntPtr @this, float value);

		// Token: 0x020000C7 RID: 199
		// (Invoke) Token: 0x0600035B RID: 859
		private delegate float get_reverbLevelDelegate(IntPtr @this);

		// Token: 0x020000C8 RID: 200
		// (Invoke) Token: 0x0600035D RID: 861
		private delegate void set_reverbLevelDelegate(IntPtr @this, float value);

		// Token: 0x020000C9 RID: 201
		// (Invoke) Token: 0x0600035F RID: 863
		private delegate float get_reverbDelayDelegate(IntPtr @this);

		// Token: 0x020000CA RID: 202
		// (Invoke) Token: 0x06000361 RID: 865
		private delegate void set_reverbDelayDelegate(IntPtr @this, float value);

		// Token: 0x020000CB RID: 203
		// (Invoke) Token: 0x06000363 RID: 867
		private delegate float get_diffusionDelegate(IntPtr @this);

		// Token: 0x020000CC RID: 204
		// (Invoke) Token: 0x06000365 RID: 869
		private delegate void set_diffusionDelegate(IntPtr @this, float value);

		// Token: 0x020000CD RID: 205
		// (Invoke) Token: 0x06000367 RID: 871
		private delegate float get_densityDelegate(IntPtr @this);

		// Token: 0x020000CE RID: 206
		// (Invoke) Token: 0x06000369 RID: 873
		private delegate void set_densityDelegate(IntPtr @this, float value);

		// Token: 0x020000CF RID: 207
		// (Invoke) Token: 0x0600036B RID: 875
		private delegate float get_hfReferenceDelegate(IntPtr @this);

		// Token: 0x020000D0 RID: 208
		// (Invoke) Token: 0x0600036D RID: 877
		private delegate void set_hfReferenceDelegate(IntPtr @this, float value);

		// Token: 0x020000D1 RID: 209
		// (Invoke) Token: 0x0600036F RID: 879
		private delegate float get_roomLFDelegate(IntPtr @this);

		// Token: 0x020000D2 RID: 210
		// (Invoke) Token: 0x06000371 RID: 881
		private delegate void set_roomLFDelegate(IntPtr @this, float value);

		// Token: 0x020000D3 RID: 211
		// (Invoke) Token: 0x06000373 RID: 883
		private delegate float get_lfReferenceDelegate(IntPtr @this);

		// Token: 0x020000D4 RID: 212
		// (Invoke) Token: 0x06000375 RID: 885
		private delegate void set_lfReferenceDelegate(IntPtr @this, float value);
	}
}

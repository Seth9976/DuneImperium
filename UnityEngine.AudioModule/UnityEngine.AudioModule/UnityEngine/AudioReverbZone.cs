using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000019 RID: 25
	public sealed class AudioReverbZone : Behaviour
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00002793 File Offset: 0x00000993
		// (set) Token: 0x06000156 RID: 342 RVA: 0x000027A5 File Offset: 0x000009A5
		public float minDistance
		{
			get
			{
				return AudioReverbZone.get_minDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_minDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000157 RID: 343 RVA: 0x000027B8 File Offset: 0x000009B8
		// (set) Token: 0x06000158 RID: 344 RVA: 0x000027CA File Offset: 0x000009CA
		public float maxDistance
		{
			get
			{
				return AudioReverbZone.get_maxDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_maxDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000027DD File Offset: 0x000009DD
		// (set) Token: 0x0600015A RID: 346 RVA: 0x000027EF File Offset: 0x000009EF
		public AudioReverbPreset reverbPreset
		{
			get
			{
				return AudioReverbZone.get_reverbPresetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_reverbPresetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00002802 File Offset: 0x00000A02
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00002814 File Offset: 0x00000A14
		public int room
		{
			get
			{
				return AudioReverbZone.get_roomDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_roomDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00002827 File Offset: 0x00000A27
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00002839 File Offset: 0x00000A39
		public int roomHF
		{
			get
			{
				return AudioReverbZone.get_roomHFDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_roomHFDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600015F RID: 351 RVA: 0x0000284C File Offset: 0x00000A4C
		// (set) Token: 0x06000160 RID: 352 RVA: 0x0000285E File Offset: 0x00000A5E
		public int roomLF
		{
			get
			{
				return AudioReverbZone.get_roomLFDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_roomLFDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00002871 File Offset: 0x00000A71
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00002883 File Offset: 0x00000A83
		public float decayTime
		{
			get
			{
				return AudioReverbZone.get_decayTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_decayTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00002896 File Offset: 0x00000A96
		// (set) Token: 0x06000164 RID: 356 RVA: 0x000028A8 File Offset: 0x00000AA8
		public float decayHFRatio
		{
			get
			{
				return AudioReverbZone.get_decayHFRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_decayHFRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000165 RID: 357 RVA: 0x000028BB File Offset: 0x00000ABB
		// (set) Token: 0x06000166 RID: 358 RVA: 0x000028CD File Offset: 0x00000ACD
		public int reflections
		{
			get
			{
				return AudioReverbZone.get_reflectionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_reflectionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000167 RID: 359 RVA: 0x000028E0 File Offset: 0x00000AE0
		// (set) Token: 0x06000168 RID: 360 RVA: 0x000028F2 File Offset: 0x00000AF2
		public float reflectionsDelay
		{
			get
			{
				return AudioReverbZone.get_reflectionsDelayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_reflectionsDelayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00002905 File Offset: 0x00000B05
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00002917 File Offset: 0x00000B17
		public int reverb
		{
			get
			{
				return AudioReverbZone.get_reverbDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_reverbDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600016B RID: 363 RVA: 0x0000292A File Offset: 0x00000B2A
		// (set) Token: 0x0600016C RID: 364 RVA: 0x0000293C File Offset: 0x00000B3C
		public float reverbDelay
		{
			get
			{
				return AudioReverbZone.get_reverbDelayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_reverbDelayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0000294F File Offset: 0x00000B4F
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00002961 File Offset: 0x00000B61
		public float HFReference
		{
			get
			{
				return AudioReverbZone.get_HFReferenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_HFReferenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00002974 File Offset: 0x00000B74
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00002986 File Offset: 0x00000B86
		public float LFReference
		{
			get
			{
				return AudioReverbZone.get_LFReferenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_LFReferenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00007924 File Offset: 0x00005B24
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00002999 File Offset: 0x00000B99
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

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000173 RID: 371 RVA: 0x000029A7 File Offset: 0x00000BA7
		// (set) Token: 0x06000174 RID: 372 RVA: 0x000029B9 File Offset: 0x00000BB9
		public float diffusion
		{
			get
			{
				return AudioReverbZone.get_diffusionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_diffusionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000175 RID: 373 RVA: 0x000029CC File Offset: 0x00000BCC
		// (set) Token: 0x06000176 RID: 374 RVA: 0x000029DE File Offset: 0x00000BDE
		public float density
		{
			get
			{
				return AudioReverbZone.get_densityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_densityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000133 RID: 307
		private static readonly AudioReverbZone.get_minDistanceDelegate get_minDistanceDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_minDistanceDelegate>("UnityEngine.AudioReverbZone::get_minDistance");

		// Token: 0x04000134 RID: 308
		private static readonly AudioReverbZone.set_minDistanceDelegate set_minDistanceDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_minDistanceDelegate>("UnityEngine.AudioReverbZone::set_minDistance");

		// Token: 0x04000135 RID: 309
		private static readonly AudioReverbZone.get_maxDistanceDelegate get_maxDistanceDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_maxDistanceDelegate>("UnityEngine.AudioReverbZone::get_maxDistance");

		// Token: 0x04000136 RID: 310
		private static readonly AudioReverbZone.set_maxDistanceDelegate set_maxDistanceDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_maxDistanceDelegate>("UnityEngine.AudioReverbZone::set_maxDistance");

		// Token: 0x04000137 RID: 311
		private static readonly AudioReverbZone.get_reverbPresetDelegate get_reverbPresetDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_reverbPresetDelegate>("UnityEngine.AudioReverbZone::get_reverbPreset");

		// Token: 0x04000138 RID: 312
		private static readonly AudioReverbZone.set_reverbPresetDelegate set_reverbPresetDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_reverbPresetDelegate>("UnityEngine.AudioReverbZone::set_reverbPreset");

		// Token: 0x04000139 RID: 313
		private static readonly AudioReverbZone.get_roomDelegate get_roomDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_roomDelegate>("UnityEngine.AudioReverbZone::get_room");

		// Token: 0x0400013A RID: 314
		private static readonly AudioReverbZone.set_roomDelegate set_roomDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_roomDelegate>("UnityEngine.AudioReverbZone::set_room");

		// Token: 0x0400013B RID: 315
		private static readonly AudioReverbZone.get_roomHFDelegate get_roomHFDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_roomHFDelegate>("UnityEngine.AudioReverbZone::get_roomHF");

		// Token: 0x0400013C RID: 316
		private static readonly AudioReverbZone.set_roomHFDelegate set_roomHFDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_roomHFDelegate>("UnityEngine.AudioReverbZone::set_roomHF");

		// Token: 0x0400013D RID: 317
		private static readonly AudioReverbZone.get_roomLFDelegate get_roomLFDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_roomLFDelegate>("UnityEngine.AudioReverbZone::get_roomLF");

		// Token: 0x0400013E RID: 318
		private static readonly AudioReverbZone.set_roomLFDelegate set_roomLFDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_roomLFDelegate>("UnityEngine.AudioReverbZone::set_roomLF");

		// Token: 0x0400013F RID: 319
		private static readonly AudioReverbZone.get_decayTimeDelegate get_decayTimeDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_decayTimeDelegate>("UnityEngine.AudioReverbZone::get_decayTime");

		// Token: 0x04000140 RID: 320
		private static readonly AudioReverbZone.set_decayTimeDelegate set_decayTimeDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_decayTimeDelegate>("UnityEngine.AudioReverbZone::set_decayTime");

		// Token: 0x04000141 RID: 321
		private static readonly AudioReverbZone.get_decayHFRatioDelegate get_decayHFRatioDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_decayHFRatioDelegate>("UnityEngine.AudioReverbZone::get_decayHFRatio");

		// Token: 0x04000142 RID: 322
		private static readonly AudioReverbZone.set_decayHFRatioDelegate set_decayHFRatioDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_decayHFRatioDelegate>("UnityEngine.AudioReverbZone::set_decayHFRatio");

		// Token: 0x04000143 RID: 323
		private static readonly AudioReverbZone.get_reflectionsDelegate get_reflectionsDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_reflectionsDelegate>("UnityEngine.AudioReverbZone::get_reflections");

		// Token: 0x04000144 RID: 324
		private static readonly AudioReverbZone.set_reflectionsDelegate set_reflectionsDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_reflectionsDelegate>("UnityEngine.AudioReverbZone::set_reflections");

		// Token: 0x04000145 RID: 325
		private static readonly AudioReverbZone.get_reflectionsDelayDelegate get_reflectionsDelayDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_reflectionsDelayDelegate>("UnityEngine.AudioReverbZone::get_reflectionsDelay");

		// Token: 0x04000146 RID: 326
		private static readonly AudioReverbZone.set_reflectionsDelayDelegate set_reflectionsDelayDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_reflectionsDelayDelegate>("UnityEngine.AudioReverbZone::set_reflectionsDelay");

		// Token: 0x04000147 RID: 327
		private static readonly AudioReverbZone.get_reverbDelegate get_reverbDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_reverbDelegate>("UnityEngine.AudioReverbZone::get_reverb");

		// Token: 0x04000148 RID: 328
		private static readonly AudioReverbZone.set_reverbDelegate set_reverbDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_reverbDelegate>("UnityEngine.AudioReverbZone::set_reverb");

		// Token: 0x04000149 RID: 329
		private static readonly AudioReverbZone.get_reverbDelayDelegate get_reverbDelayDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_reverbDelayDelegate>("UnityEngine.AudioReverbZone::get_reverbDelay");

		// Token: 0x0400014A RID: 330
		private static readonly AudioReverbZone.set_reverbDelayDelegate set_reverbDelayDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_reverbDelayDelegate>("UnityEngine.AudioReverbZone::set_reverbDelay");

		// Token: 0x0400014B RID: 331
		private static readonly AudioReverbZone.get_HFReferenceDelegate get_HFReferenceDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_HFReferenceDelegate>("UnityEngine.AudioReverbZone::get_HFReference");

		// Token: 0x0400014C RID: 332
		private static readonly AudioReverbZone.set_HFReferenceDelegate set_HFReferenceDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_HFReferenceDelegate>("UnityEngine.AudioReverbZone::set_HFReference");

		// Token: 0x0400014D RID: 333
		private static readonly AudioReverbZone.get_LFReferenceDelegate get_LFReferenceDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_LFReferenceDelegate>("UnityEngine.AudioReverbZone::get_LFReference");

		// Token: 0x0400014E RID: 334
		private static readonly AudioReverbZone.set_LFReferenceDelegate set_LFReferenceDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_LFReferenceDelegate>("UnityEngine.AudioReverbZone::set_LFReference");

		// Token: 0x0400014F RID: 335
		private static readonly AudioReverbZone.get_diffusionDelegate get_diffusionDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_diffusionDelegate>("UnityEngine.AudioReverbZone::get_diffusion");

		// Token: 0x04000150 RID: 336
		private static readonly AudioReverbZone.set_diffusionDelegate set_diffusionDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_diffusionDelegate>("UnityEngine.AudioReverbZone::set_diffusion");

		// Token: 0x04000151 RID: 337
		private static readonly AudioReverbZone.get_densityDelegate get_densityDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_densityDelegate>("UnityEngine.AudioReverbZone::get_density");

		// Token: 0x04000152 RID: 338
		private static readonly AudioReverbZone.set_densityDelegate set_densityDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_densityDelegate>("UnityEngine.AudioReverbZone::set_density");

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x060002B7 RID: 695
		private delegate float get_minDistanceDelegate(IntPtr @this);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x060002B9 RID: 697
		private delegate void set_minDistanceDelegate(IntPtr @this, float value);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x060002BB RID: 699
		private delegate float get_maxDistanceDelegate(IntPtr @this);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x060002BD RID: 701
		private delegate void set_maxDistanceDelegate(IntPtr @this, float value);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x060002BF RID: 703
		private delegate AudioReverbPreset get_reverbPresetDelegate(IntPtr @this);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x060002C1 RID: 705
		private delegate void set_reverbPresetDelegate(IntPtr @this, AudioReverbPreset value);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x060002C3 RID: 707
		private delegate int get_roomDelegate(IntPtr @this);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x060002C5 RID: 709
		private delegate void set_roomDelegate(IntPtr @this, int value);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x060002C7 RID: 711
		private delegate int get_roomHFDelegate(IntPtr @this);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x060002C9 RID: 713
		private delegate void set_roomHFDelegate(IntPtr @this, int value);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x060002CB RID: 715
		private delegate int get_roomLFDelegate(IntPtr @this);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x060002CD RID: 717
		private delegate void set_roomLFDelegate(IntPtr @this, int value);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x060002CF RID: 719
		private delegate float get_decayTimeDelegate(IntPtr @this);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x060002D1 RID: 721
		private delegate void set_decayTimeDelegate(IntPtr @this, float value);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x060002D3 RID: 723
		private delegate float get_decayHFRatioDelegate(IntPtr @this);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x060002D5 RID: 725
		private delegate void set_decayHFRatioDelegate(IntPtr @this, float value);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x060002D7 RID: 727
		private delegate int get_reflectionsDelegate(IntPtr @this);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x060002D9 RID: 729
		private delegate void set_reflectionsDelegate(IntPtr @this, int value);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x060002DB RID: 731
		private delegate float get_reflectionsDelayDelegate(IntPtr @this);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x060002DD RID: 733
		private delegate void set_reflectionsDelayDelegate(IntPtr @this, float value);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x060002DF RID: 735
		private delegate int get_reverbDelegate(IntPtr @this);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x060002E1 RID: 737
		private delegate void set_reverbDelegate(IntPtr @this, int value);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x060002E3 RID: 739
		private delegate float get_reverbDelayDelegate(IntPtr @this);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x060002E5 RID: 741
		private delegate void set_reverbDelayDelegate(IntPtr @this, float value);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x060002E7 RID: 743
		private delegate float get_HFReferenceDelegate(IntPtr @this);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x060002E9 RID: 745
		private delegate void set_HFReferenceDelegate(IntPtr @this, float value);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x060002EB RID: 747
		private delegate float get_LFReferenceDelegate(IntPtr @this);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x060002ED RID: 749
		private delegate void set_LFReferenceDelegate(IntPtr @this, float value);

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x060002EF RID: 751
		private delegate float get_diffusionDelegate(IntPtr @this);

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x060002F1 RID: 753
		private delegate void set_diffusionDelegate(IntPtr @this, float value);

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x060002F3 RID: 755
		private delegate float get_densityDelegate(IntPtr @this);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x060002F5 RID: 757
		private delegate void set_densityDelegate(IntPtr @this, float value);
	}
}

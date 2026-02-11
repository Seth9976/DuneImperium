using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	public sealed class AnimationState : TrackedReference
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00006678 File Offset: 0x00004878
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationState()
		{
			Il2CppClassPointerStore<AnimationState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimationState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationState>.NativeClassPtr);
			AnimationState.NativeMethodInfoPtr_get_clip_Public_get_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationState>.NativeClassPtr, 100663376);
			AnimationState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationState>.NativeClassPtr, 100663377);
			AnimationState.get_enabledDelegateField = IL2CPP.ResolveICall<AnimationState.get_enabledDelegate>("UnityEngine.AnimationState::get_enabled");
			AnimationState.set_enabledDelegateField = IL2CPP.ResolveICall<AnimationState.set_enabledDelegate>("UnityEngine.AnimationState::set_enabled");
			AnimationState.get_weightDelegateField = IL2CPP.ResolveICall<AnimationState.get_weightDelegate>("UnityEngine.AnimationState::get_weight");
			AnimationState.set_weightDelegateField = IL2CPP.ResolveICall<AnimationState.set_weightDelegate>("UnityEngine.AnimationState::set_weight");
			AnimationState.get_wrapModeDelegateField = IL2CPP.ResolveICall<AnimationState.get_wrapModeDelegate>("UnityEngine.AnimationState::get_wrapMode");
			AnimationState.set_wrapModeDelegateField = IL2CPP.ResolveICall<AnimationState.set_wrapModeDelegate>("UnityEngine.AnimationState::set_wrapMode");
			AnimationState.get_timeDelegateField = IL2CPP.ResolveICall<AnimationState.get_timeDelegate>("UnityEngine.AnimationState::get_time");
			AnimationState.set_timeDelegateField = IL2CPP.ResolveICall<AnimationState.set_timeDelegate>("UnityEngine.AnimationState::set_time");
			AnimationState.get_normalizedTimeDelegateField = IL2CPP.ResolveICall<AnimationState.get_normalizedTimeDelegate>("UnityEngine.AnimationState::get_normalizedTime");
			AnimationState.set_normalizedTimeDelegateField = IL2CPP.ResolveICall<AnimationState.set_normalizedTimeDelegate>("UnityEngine.AnimationState::set_normalizedTime");
			AnimationState.get_speedDelegateField = IL2CPP.ResolveICall<AnimationState.get_speedDelegate>("UnityEngine.AnimationState::get_speed");
			AnimationState.set_speedDelegateField = IL2CPP.ResolveICall<AnimationState.set_speedDelegate>("UnityEngine.AnimationState::set_speed");
			AnimationState.get_normalizedSpeedDelegateField = IL2CPP.ResolveICall<AnimationState.get_normalizedSpeedDelegate>("UnityEngine.AnimationState::get_normalizedSpeed");
			AnimationState.set_normalizedSpeedDelegateField = IL2CPP.ResolveICall<AnimationState.set_normalizedSpeedDelegate>("UnityEngine.AnimationState::set_normalizedSpeed");
			AnimationState.get_lengthDelegateField = IL2CPP.ResolveICall<AnimationState.get_lengthDelegate>("UnityEngine.AnimationState::get_length");
			AnimationState.get_layerDelegateField = IL2CPP.ResolveICall<AnimationState.get_layerDelegate>("UnityEngine.AnimationState::get_layer");
			AnimationState.set_layerDelegateField = IL2CPP.ResolveICall<AnimationState.set_layerDelegate>("UnityEngine.AnimationState::set_layer");
			AnimationState.get_nameDelegateField = IL2CPP.ResolveICall<AnimationState.get_nameDelegate>("UnityEngine.AnimationState::get_name");
			AnimationState.set_nameDelegateField = IL2CPP.ResolveICall<AnimationState.set_nameDelegate>("UnityEngine.AnimationState::set_name");
			AnimationState.get_blendModeDelegateField = IL2CPP.ResolveICall<AnimationState.get_blendModeDelegate>("UnityEngine.AnimationState::get_blendMode");
			AnimationState.set_blendModeDelegateField = IL2CPP.ResolveICall<AnimationState.set_blendModeDelegate>("UnityEngine.AnimationState::set_blendMode");
			AnimationState.AddMixingTransformDelegateField = IL2CPP.ResolveICall<AnimationState.AddMixingTransformDelegate>("UnityEngine.AnimationState::AddMixingTransform");
			AnimationState.RemoveMixingTransformDelegateField = IL2CPP.ResolveICall<AnimationState.RemoveMixingTransformDelegate>("UnityEngine.AnimationState::RemoveMixingTransform");
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000053 RID: 83 RVA: 0x0000682C File Offset: 0x00004A2C
		public unsafe AnimationClip clip
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219639, XrefRangeEnd = 1219641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationState.NativeMethodInfoPtr_get_clip_Public_get_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr3) : null;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000686C File Offset: 0x00004A6C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002090 File Offset: 0x00000290
		public AnimationState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002099 File Offset: 0x00000299
		// (set) Token: 0x06000057 RID: 87 RVA: 0x000020AB File Offset: 0x000002AB
		public bool enabled
		{
			get
			{
				return AnimationState.get_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000020BE File Offset: 0x000002BE
		// (set) Token: 0x06000059 RID: 89 RVA: 0x000020D0 File Offset: 0x000002D0
		public float weight
		{
			get
			{
				return AnimationState.get_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600005A RID: 90 RVA: 0x000020E3 File Offset: 0x000002E3
		// (set) Token: 0x0600005B RID: 91 RVA: 0x000020F5 File Offset: 0x000002F5
		public WrapMode wrapMode
		{
			get
			{
				return AnimationState.get_wrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_wrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00002108 File Offset: 0x00000308
		// (set) Token: 0x0600005D RID: 93 RVA: 0x0000211A File Offset: 0x0000031A
		public float time
		{
			get
			{
				return AnimationState.get_timeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_timeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0000212D File Offset: 0x0000032D
		// (set) Token: 0x0600005F RID: 95 RVA: 0x0000213F File Offset: 0x0000033F
		public float normalizedTime
		{
			get
			{
				return AnimationState.get_normalizedTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_normalizedTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002152 File Offset: 0x00000352
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00002164 File Offset: 0x00000364
		public float speed
		{
			get
			{
				return AnimationState.get_speedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_speedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002177 File Offset: 0x00000377
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00002189 File Offset: 0x00000389
		public float normalizedSpeed
		{
			get
			{
				return AnimationState.get_normalizedSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_normalizedSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0000219C File Offset: 0x0000039C
		public float length
		{
			get
			{
				return AnimationState.get_lengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000021AE File Offset: 0x000003AE
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000021C0 File Offset: 0x000003C0
		public int layer
		{
			get
			{
				return AnimationState.get_layerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_layerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000068A8 File Offset: 0x00004AA8
		// (set) Token: 0x06000068 RID: 104 RVA: 0x000021D3 File Offset: 0x000003D3
		public string name
		{
			get
			{
				IntPtr intPtr = AnimationState.get_nameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				AnimationState.set_nameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000021EB File Offset: 0x000003EB
		// (set) Token: 0x0600006A RID: 106 RVA: 0x000021FD File Offset: 0x000003FD
		public AnimationBlendMode blendMode
		{
			get
			{
				return AnimationState.get_blendModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_blendModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002210 File Offset: 0x00000410
		public void AddMixingTransform(Transform mix)
		{
			this.AddMixingTransform(mix, true);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000221C File Offset: 0x0000041C
		public void AddMixingTransform(Transform mix, bool recursive)
		{
			AnimationState.AddMixingTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mix), recursive);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002235 File Offset: 0x00000435
		public void RemoveMixingTransform(Transform mix)
		{
			AnimationState.RemoveMixingTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mix));
		}

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_get_clip_Public_get_AnimationClip_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000061 RID: 97
		private static readonly AnimationState.get_enabledDelegate get_enabledDelegateField;

		// Token: 0x04000062 RID: 98
		private static readonly AnimationState.set_enabledDelegate set_enabledDelegateField;

		// Token: 0x04000063 RID: 99
		private static readonly AnimationState.get_weightDelegate get_weightDelegateField;

		// Token: 0x04000064 RID: 100
		private static readonly AnimationState.set_weightDelegate set_weightDelegateField;

		// Token: 0x04000065 RID: 101
		private static readonly AnimationState.get_wrapModeDelegate get_wrapModeDelegateField;

		// Token: 0x04000066 RID: 102
		private static readonly AnimationState.set_wrapModeDelegate set_wrapModeDelegateField;

		// Token: 0x04000067 RID: 103
		private static readonly AnimationState.get_timeDelegate get_timeDelegateField;

		// Token: 0x04000068 RID: 104
		private static readonly AnimationState.set_timeDelegate set_timeDelegateField;

		// Token: 0x04000069 RID: 105
		private static readonly AnimationState.get_normalizedTimeDelegate get_normalizedTimeDelegateField;

		// Token: 0x0400006A RID: 106
		private static readonly AnimationState.set_normalizedTimeDelegate set_normalizedTimeDelegateField;

		// Token: 0x0400006B RID: 107
		private static readonly AnimationState.get_speedDelegate get_speedDelegateField;

		// Token: 0x0400006C RID: 108
		private static readonly AnimationState.set_speedDelegate set_speedDelegateField;

		// Token: 0x0400006D RID: 109
		private static readonly AnimationState.get_normalizedSpeedDelegate get_normalizedSpeedDelegateField;

		// Token: 0x0400006E RID: 110
		private static readonly AnimationState.set_normalizedSpeedDelegate set_normalizedSpeedDelegateField;

		// Token: 0x0400006F RID: 111
		private static readonly AnimationState.get_lengthDelegate get_lengthDelegateField;

		// Token: 0x04000070 RID: 112
		private static readonly AnimationState.get_layerDelegate get_layerDelegateField;

		// Token: 0x04000071 RID: 113
		private static readonly AnimationState.set_layerDelegate set_layerDelegateField;

		// Token: 0x04000072 RID: 114
		private static readonly AnimationState.get_nameDelegate get_nameDelegateField;

		// Token: 0x04000073 RID: 115
		private static readonly AnimationState.set_nameDelegate set_nameDelegateField;

		// Token: 0x04000074 RID: 116
		private static readonly AnimationState.get_blendModeDelegate get_blendModeDelegateField;

		// Token: 0x04000075 RID: 117
		private static readonly AnimationState.set_blendModeDelegate set_blendModeDelegateField;

		// Token: 0x04000076 RID: 118
		private static readonly AnimationState.AddMixingTransformDelegate AddMixingTransformDelegateField;

		// Token: 0x04000077 RID: 119
		private static readonly AnimationState.RemoveMixingTransformDelegate RemoveMixingTransformDelegateField;

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x0600059D RID: 1437
		private delegate bool get_enabledDelegate(IntPtr @this);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x0600059F RID: 1439
		private delegate void set_enabledDelegate(IntPtr @this, bool value);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x060005A1 RID: 1441
		private delegate float get_weightDelegate(IntPtr @this);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x060005A3 RID: 1443
		private delegate void set_weightDelegate(IntPtr @this, float value);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x060005A5 RID: 1445
		private delegate WrapMode get_wrapModeDelegate(IntPtr @this);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x060005A7 RID: 1447
		private delegate void set_wrapModeDelegate(IntPtr @this, WrapMode value);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x060005A9 RID: 1449
		private delegate float get_timeDelegate(IntPtr @this);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x060005AB RID: 1451
		private delegate void set_timeDelegate(IntPtr @this, float value);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x060005AD RID: 1453
		private delegate float get_normalizedTimeDelegate(IntPtr @this);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x060005AF RID: 1455
		private delegate void set_normalizedTimeDelegate(IntPtr @this, float value);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x060005B1 RID: 1457
		private delegate float get_speedDelegate(IntPtr @this);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x060005B3 RID: 1459
		private delegate void set_speedDelegate(IntPtr @this, float value);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x060005B5 RID: 1461
		private delegate float get_normalizedSpeedDelegate(IntPtr @this);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x060005B7 RID: 1463
		private delegate void set_normalizedSpeedDelegate(IntPtr @this, float value);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x060005B9 RID: 1465
		private delegate float get_lengthDelegate(IntPtr @this);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x060005BB RID: 1467
		private delegate int get_layerDelegate(IntPtr @this);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x060005BD RID: 1469
		private delegate void set_layerDelegate(IntPtr @this, int value);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x060005BF RID: 1471
		private delegate IntPtr get_nameDelegate(IntPtr @this);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x060005C1 RID: 1473
		private delegate void set_nameDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x060005C3 RID: 1475
		private delegate AnimationBlendMode get_blendModeDelegate(IntPtr @this);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x060005C5 RID: 1477
		private delegate void set_blendModeDelegate(IntPtr @this, AnimationBlendMode value);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x060005C7 RID: 1479
		private delegate void AddMixingTransformDelegate(IntPtr @this, IntPtr mix, bool recursive);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x060005C9 RID: 1481
		private delegate void RemoveMixingTransformDelegate(IntPtr @this, IntPtr mix);
	}
}

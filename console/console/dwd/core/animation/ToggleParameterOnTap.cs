using System;
using dwd.core.input;
using dwd.core.input.click;
using dwd.core.input.multitouch;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dwd.core.animation
{
	// Token: 0x0200000C RID: 12
	public class ToggleParameterOnTap : MonoBehaviour
	{
		// Token: 0x06000083 RID: 131 RVA: 0x000042DC File Offset: 0x000024DC
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleParameterOnTap()
		{
			Il2CppClassPointerStore<ToggleParameterOnTap>.NativeClassPtr = IL2CPP.GetIl2CppClass("console.dll", "dwd.core.animation", "ToggleParameterOnTap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleParameterOnTap>.NativeClassPtr);
			ToggleParameterOnTap.NativeFieldInfoPtr_parameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleParameterOnTap>.NativeClassPtr, "parameterName");
			ToggleParameterOnTap.NativeFieldInfoPtr_tapCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleParameterOnTap>.NativeClassPtr, "tapCount");
			ToggleParameterOnTap.NativeFieldInfoPtr_useUnityTouches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleParameterOnTap>.NativeClassPtr, "useUnityTouches");
			ToggleParameterOnTap.NativeFieldInfoPtr_parameterHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleParameterOnTap>.NativeClassPtr, "parameterHash");
			ToggleParameterOnTap.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleParameterOnTap>.NativeClassPtr, "startTime");
			ToggleParameterOnTap.NativeFieldInfoPtr_clickConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleParameterOnTap>.NativeClassPtr, "clickConfig");
			ToggleParameterOnTap.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleParameterOnTap>.NativeClassPtr, "animator");
			ToggleParameterOnTap.NativeFieldInfoPtr_pressFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleParameterOnTap>.NativeClassPtr, "pressFilters");
			ToggleParameterOnTap.NativeFieldInfoPtr_cachedTouches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleParameterOnTap>.NativeClassPtr, "cachedTouches");
			ToggleParameterOnTap.NativeFieldInfoPtr_unityTouchesInvalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleParameterOnTap>.NativeClassPtr, "unityTouchesInvalid");
			ToggleParameterOnTap.NativeFieldInfoPtr_gestureActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleParameterOnTap>.NativeClassPtr, "gestureActive");
			ToggleParameterOnTap.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleParameterOnTap>.NativeClassPtr, 100663334);
			ToggleParameterOnTap.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleParameterOnTap>.NativeClassPtr, 100663335);
			ToggleParameterOnTap.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleParameterOnTap>.NativeClassPtr, 100663336);
			ToggleParameterOnTap.NativeMethodInfoPtr_start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleParameterOnTap>.NativeClassPtr, 100663337);
			ToggleParameterOnTap.NativeMethodInfoPtr_cancel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleParameterOnTap>.NativeClassPtr, 100663338);
			ToggleParameterOnTap.NativeMethodInfoPtr_end_Private_Void_GestureEndedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleParameterOnTap>.NativeClassPtr, 100663339);
			ToggleParameterOnTap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleParameterOnTap>.NativeClassPtr, 100663340);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00004474 File Offset: 0x00002674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255874, XrefRangeEnd = 1255879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleParameterOnTap.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000044B4 File Offset: 0x000026B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255879, XrefRangeEnd = 1255908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleParameterOnTap.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000044E8 File Offset: 0x000026E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255908, XrefRangeEnd = 1255918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleParameterOnTap.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000451C File Offset: 0x0000271C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255918, XrefRangeEnd = 1255919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleParameterOnTap.NativeMethodInfoPtr_start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00004550 File Offset: 0x00002750
		[CallerCount(0)]
		public unsafe void cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleParameterOnTap.NativeMethodInfoPtr_cancel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00004584 File Offset: 0x00002784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255919, XrefRangeEnd = 1255939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void end(GestureEndedEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleParameterOnTap.NativeMethodInfoPtr_end_Private_Void_GestureEndedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000045C8 File Offset: 0x000027C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255939, XrefRangeEnd = 1255944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleParameterOnTap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleParameterOnTap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleParameterOnTap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002537 File Offset: 0x00000737
		public ToggleParameterOnTap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00004604 File Offset: 0x00002804
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00002540 File Offset: 0x00000740
		public unsafe string parameterName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap.NativeFieldInfoPtr_parameterName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap.NativeFieldInfoPtr_parameterName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000462C File Offset: 0x0000282C
		// (set) Token: 0x0600008F RID: 143 RVA: 0x0000255F File Offset: 0x0000075F
		public unsafe int tapCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap.NativeFieldInfoPtr_tapCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap.NativeFieldInfoPtr_tapCount)) = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00004654 File Offset: 0x00002854
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0000257A File Offset: 0x0000077A
		public unsafe bool useUnityTouches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap.NativeFieldInfoPtr_useUnityTouches);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap.NativeFieldInfoPtr_useUnityTouches)) = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000467C File Offset: 0x0000287C
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002595 File Offset: 0x00000795
		public unsafe int parameterHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap.NativeFieldInfoPtr_parameterHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap.NativeFieldInfoPtr_parameterHash)) = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000094 RID: 148 RVA: 0x000046A4 File Offset: 0x000028A4
		// (set) Token: 0x06000095 RID: 149 RVA: 0x000025B0 File Offset: 0x000007B0
		public unsafe float startTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap.NativeFieldInfoPtr_startTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap.NativeFieldInfoPtr_startTime)) = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000096 RID: 150 RVA: 0x000046CC File Offset: 0x000028CC
		// (set) Token: 0x06000097 RID: 151 RVA: 0x000025CB File Offset: 0x000007CB
		public unsafe IClickConfig clickConfig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap.NativeFieldInfoPtr_clickConfig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClickConfig>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap.NativeFieldInfoPtr_clickConfig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000046FC File Offset: 0x000028FC
		// (set) Token: 0x06000099 RID: 153 RVA: 0x000025EA File Offset: 0x000007EA
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000472C File Offset: 0x0000292C
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00002609 File Offset: 0x00000809
		public unsafe Il2CppReferenceArray<PressFilter> pressFilters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap.NativeFieldInfoPtr_pressFilters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PressFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap.NativeFieldInfoPtr_pressFilters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0000475C File Offset: 0x0000295C
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002628 File Offset: 0x00000828
		public unsafe int cachedTouches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap.NativeFieldInfoPtr_cachedTouches);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap.NativeFieldInfoPtr_cachedTouches)) = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00004784 File Offset: 0x00002984
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00002643 File Offset: 0x00000843
		public unsafe bool unityTouchesInvalid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap.NativeFieldInfoPtr_unityTouchesInvalid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap.NativeFieldInfoPtr_unityTouchesInvalid)) = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000047AC File Offset: 0x000029AC
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000265E File Offset: 0x0000085E
		public unsafe bool gestureActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap.NativeFieldInfoPtr_gestureActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap.NativeFieldInfoPtr_gestureActive)) = value;
			}
		}

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_parameterName;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_tapCount;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_useUnityTouches;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr_parameterHash;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr_startTime;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr_clickConfig;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_pressFilters;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_cachedTouches;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr_unityTouchesInvalid;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr_gestureActive;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_start_Private_Void_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_cancel_Private_Void_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_end_Private_Void_GestureEndedEvent_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000019 RID: 25
		[ObfuscatedName("dwd.core.animation.ToggleParameterOnTap+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000130 RID: 304 RVA: 0x00006020 File Offset: 0x00004220
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<ToggleParameterOnTap.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ToggleParameterOnTap>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleParameterOnTap.__c__DisplayClass16_0>.NativeClassPtr);
				ToggleParameterOnTap.__c__DisplayClass16_0.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleParameterOnTap.__c__DisplayClass16_0>.NativeClassPtr, "evt");
				ToggleParameterOnTap.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleParameterOnTap.__c__DisplayClass16_0>.NativeClassPtr, 100663341);
				ToggleParameterOnTap.__c__DisplayClass16_0.NativeMethodInfoPtr__end_b__0_Internal_Boolean_PressFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleParameterOnTap.__c__DisplayClass16_0>.NativeClassPtr, 100663342);
			}

			// Token: 0x06000131 RID: 305 RVA: 0x00006088 File Offset: 0x00004288
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleParameterOnTap.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleParameterOnTap.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000132 RID: 306 RVA: 0x000060C4 File Offset: 0x000042C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255801, XrefRangeEnd = 1255820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _end_b__0(PressFilter x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleParameterOnTap.__c__DisplayClass16_0.NativeMethodInfoPtr__end_b__0_Internal_Boolean_PressFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000133 RID: 307 RVA: 0x00002B10 File Offset: 0x00000D10
			public __c__DisplayClass16_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x06000134 RID: 308 RVA: 0x00006114 File Offset: 0x00004314
			// (set) Token: 0x06000135 RID: 309 RVA: 0x00002B19 File Offset: 0x00000D19
			public unsafe GestureEndedEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap.__c__DisplayClass16_0.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GestureEndedEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap.__c__DisplayClass16_0.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000AA RID: 170
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x040000AB RID: 171
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040000AC RID: 172
			private static readonly IntPtr NativeMethodInfoPtr__end_b__0_Internal_Boolean_PressFilter_0;
		}

		// Token: 0x0200001A RID: 26
		[ObfuscatedName("dwd.core.animation.ToggleParameterOnTap+<Start>d__10")]
		public sealed class _Start_d__10 : global::Il2CppSystem.Object
		{
			// Token: 0x06000136 RID: 310 RVA: 0x00006144 File Offset: 0x00004344
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__10()
			{
				Il2CppClassPointerStore<ToggleParameterOnTap._Start_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ToggleParameterOnTap>.NativeClassPtr, "<Start>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleParameterOnTap._Start_d__10>.NativeClassPtr);
				ToggleParameterOnTap._Start_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleParameterOnTap._Start_d__10>.NativeClassPtr, "<>1__state");
				ToggleParameterOnTap._Start_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleParameterOnTap._Start_d__10>.NativeClassPtr, "<>2__current");
				ToggleParameterOnTap._Start_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleParameterOnTap._Start_d__10>.NativeClassPtr, "<>4__this");
				ToggleParameterOnTap._Start_d__10.NativeFieldInfoPtr__mtInputManager_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleParameterOnTap._Start_d__10>.NativeClassPtr, "<mtInputManager>5__2");
				ToggleParameterOnTap._Start_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleParameterOnTap._Start_d__10>.NativeClassPtr, 100663343);
				ToggleParameterOnTap._Start_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleParameterOnTap._Start_d__10>.NativeClassPtr, 100663344);
				ToggleParameterOnTap._Start_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleParameterOnTap._Start_d__10>.NativeClassPtr, 100663345);
				ToggleParameterOnTap._Start_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleParameterOnTap._Start_d__10>.NativeClassPtr, 100663346);
				ToggleParameterOnTap._Start_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleParameterOnTap._Start_d__10>.NativeClassPtr, 100663347);
				ToggleParameterOnTap._Start_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleParameterOnTap._Start_d__10>.NativeClassPtr, 100663348);
			}

			// Token: 0x06000137 RID: 311 RVA: 0x00006238 File Offset: 0x00004438
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleParameterOnTap._Start_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleParameterOnTap._Start_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000138 RID: 312 RVA: 0x00006280 File Offset: 0x00004480
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleParameterOnTap._Start_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000139 RID: 313 RVA: 0x000062B4 File Offset: 0x000044B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255820, XrefRangeEnd = 1255869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleParameterOnTap._Start_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x0600013A RID: 314 RVA: 0x000062F0 File Offset: 0x000044F0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleParameterOnTap._Start_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600013B RID: 315 RVA: 0x00006330 File Offset: 0x00004530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255869, XrefRangeEnd = 1255874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleParameterOnTap._Start_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x0600013C RID: 316 RVA: 0x00006364 File Offset: 0x00004564
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleParameterOnTap._Start_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600013D RID: 317 RVA: 0x00002B38 File Offset: 0x00000D38
			public _Start_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x0600013E RID: 318 RVA: 0x000063A4 File Offset: 0x000045A4
			// (set) Token: 0x0600013F RID: 319 RVA: 0x00002B41 File Offset: 0x00000D41
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap._Start_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap._Start_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x06000140 RID: 320 RVA: 0x000063CC File Offset: 0x000045CC
			// (set) Token: 0x06000141 RID: 321 RVA: 0x00002B5C File Offset: 0x00000D5C
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap._Start_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap._Start_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x06000142 RID: 322 RVA: 0x000063FC File Offset: 0x000045FC
			// (set) Token: 0x06000143 RID: 323 RVA: 0x00002B7B File Offset: 0x00000D7B
			public unsafe ToggleParameterOnTap __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap._Start_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleParameterOnTap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap._Start_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x06000144 RID: 324 RVA: 0x0000642C File Offset: 0x0000462C
			// (set) Token: 0x06000145 RID: 325 RVA: 0x00002B9A File Offset: 0x00000D9A
			public unsafe MultitouchInputManager _mtInputManager_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap._Start_d__10.NativeFieldInfoPtr__mtInputManager_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultitouchInputManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterOnTap._Start_d__10.NativeFieldInfoPtr__mtInputManager_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000AD RID: 173
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040000AE RID: 174
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040000AF RID: 175
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040000B0 RID: 176
			private static readonly IntPtr NativeFieldInfoPtr__mtInputManager_5__2;

			// Token: 0x040000B1 RID: 177
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040000B2 RID: 178
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000B3 RID: 179
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040000B4 RID: 180
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040000B5 RID: 181
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000B6 RID: 182
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

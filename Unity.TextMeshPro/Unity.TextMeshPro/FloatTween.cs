using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;

namespace TMPro
{
	// Token: 0x0200002A RID: 42
	public sealed class FloatTween : ValueType
	{
		// Token: 0x060003BB RID: 955 RVA: 0x00015A38 File Offset: 0x00013C38
		// Note: this type is marked as 'beforefieldinit'.
		static FloatTween()
		{
			Il2CppClassPointerStore<FloatTween>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "FloatTween");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatTween>.NativeClassPtr);
			FloatTween.NativeFieldInfoPtr_m_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, "m_Target");
			FloatTween.NativeFieldInfoPtr_m_StartValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, "m_StartValue");
			FloatTween.NativeFieldInfoPtr_m_TargetValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, "m_TargetValue");
			FloatTween.NativeFieldInfoPtr_m_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, "m_Duration");
			FloatTween.NativeFieldInfoPtr_m_IgnoreTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, "m_IgnoreTimeScale");
			FloatTween.NativeMethodInfoPtr_get_startValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100663644);
			FloatTween.NativeMethodInfoPtr_set_startValue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100663645);
			FloatTween.NativeMethodInfoPtr_get_targetValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100663646);
			FloatTween.NativeMethodInfoPtr_set_targetValue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100663647);
			FloatTween.NativeMethodInfoPtr_get_duration_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100663648);
			FloatTween.NativeMethodInfoPtr_set_duration_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100663649);
			FloatTween.NativeMethodInfoPtr_get_ignoreTimeScale_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100663650);
			FloatTween.NativeMethodInfoPtr_set_ignoreTimeScale_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100663651);
			FloatTween.NativeMethodInfoPtr_TweenValue_Public_Virtual_Final_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100663652);
			FloatTween.NativeMethodInfoPtr_AddOnChangedCallback_Public_Void_UnityAction_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100663653);
			FloatTween.NativeMethodInfoPtr_GetIgnoreTimescale_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100663654);
			FloatTween.NativeMethodInfoPtr_GetDuration_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100663655);
			FloatTween.NativeMethodInfoPtr_ValidTarget_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100663656);
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00015BD0 File Offset: 0x00013DD0
		// (set) Token: 0x060003BD RID: 957 RVA: 0x00015C14 File Offset: 0x00013E14
		public unsafe float startValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_get_startValue_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 644429, RefRangeEnd = 644431, XrefRangeStart = 644429, XrefRangeEnd = 644431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_set_startValue_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00015C58 File Offset: 0x00013E58
		// (set) Token: 0x060003BF RID: 959 RVA: 0x00015C9C File Offset: 0x00013E9C
		public unsafe float targetValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_get_targetValue_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 642841, RefRangeEnd = 642843, XrefRangeStart = 642841, XrefRangeEnd = 642843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_set_targetValue_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00015CE0 File Offset: 0x00013EE0
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00015D24 File Offset: 0x00013F24
		public unsafe float duration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_get_duration_Public_Virtual_Final_New_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_set_duration_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00015D68 File Offset: 0x00013F68
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x00015DAC File Offset: 0x00013FAC
		public unsafe bool ignoreTimeScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_get_ignoreTimeScale_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_set_ignoreTimeScale_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00015DF0 File Offset: 0x00013FF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1038144, RefRangeEnd = 1038145, XrefRangeStart = 1038140, XrefRangeEnd = 1038144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TweenValue(float floatPercentage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref floatPercentage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_TweenValue_Public_Virtual_Final_New_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00015E34 File Offset: 0x00014034
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1038156, RefRangeEnd = 1038157, XrefRangeStart = 1038145, XrefRangeEnd = 1038156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOnChangedCallback(UnityAction<float> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_AddOnChangedCallback_Public_Void_UnityAction_1_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00015E7C File Offset: 0x0001407C
		[CallerCount(0)]
		public unsafe bool GetIgnoreTimescale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_GetIgnoreTimescale_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00015EC0 File Offset: 0x000140C0
		[CallerCount(0)]
		public unsafe float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_GetDuration_Public_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00015F04 File Offset: 0x00014104
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 608772, RefRangeEnd = 608784, XrefRangeStart = 608772, XrefRangeEnd = 608784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_ValidTarget_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00003E72 File Offset: 0x00002072
		public FloatTween(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00003E7B File Offset: 0x0000207B
		public FloatTween()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatTween>.NativeClassPtr))
		{
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060003CB RID: 971 RVA: 0x00015F48 File Offset: 0x00014148
		// (set) Token: 0x060003CC RID: 972 RVA: 0x00003E8D File Offset: 0x0000208D
		public unsafe FloatTween.FloatTweenCallback m_Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatTween.NativeFieldInfoPtr_m_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatTween.FloatTweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatTween.NativeFieldInfoPtr_m_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00015F78 File Offset: 0x00014178
		// (set) Token: 0x060003CE RID: 974 RVA: 0x00003EAC File Offset: 0x000020AC
		public unsafe float m_StartValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatTween.NativeFieldInfoPtr_m_StartValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatTween.NativeFieldInfoPtr_m_StartValue)) = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060003CF RID: 975 RVA: 0x00015FA0 File Offset: 0x000141A0
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x00003EC7 File Offset: 0x000020C7
		public unsafe float m_TargetValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatTween.NativeFieldInfoPtr_m_TargetValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatTween.NativeFieldInfoPtr_m_TargetValue)) = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x00015FC8 File Offset: 0x000141C8
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x00003EE2 File Offset: 0x000020E2
		public unsafe float m_Duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatTween.NativeFieldInfoPtr_m_Duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatTween.NativeFieldInfoPtr_m_Duration)) = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x00015FF0 File Offset: 0x000141F0
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x00003EFD File Offset: 0x000020FD
		public unsafe bool m_IgnoreTimeScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatTween.NativeFieldInfoPtr_m_IgnoreTimeScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatTween.NativeFieldInfoPtr_m_IgnoreTimeScale)) = value;
			}
		}

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeFieldInfoPtr_m_Target;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeFieldInfoPtr_m_StartValue;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetValue;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeFieldInfoPtr_m_Duration;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeFieldInfoPtr_m_IgnoreTimeScale;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_get_startValue_Public_get_Single_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_set_startValue_Public_set_Void_Single_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_get_targetValue_Public_get_Single_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_set_targetValue_Public_set_Void_Single_0;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr_set_duration_Public_set_Void_Single_0;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreTimeScale_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_set_ignoreTimeScale_Public_set_Void_Boolean_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_TweenValue_Public_Virtual_Final_New_Void_Single_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_AddOnChangedCallback_Public_Void_UnityAction_1_Single_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_GetIgnoreTimescale_Public_Boolean_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Single_0;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr_ValidTarget_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0200007E RID: 126
		public class FloatTweenCallback : UnityEvent<float>
		{
			// Token: 0x06000EB4 RID: 3764 RVA: 0x00008EE6 File Offset: 0x000070E6
			// Note: this type is marked as 'beforefieldinit'.
			static FloatTweenCallback()
			{
				Il2CppClassPointerStore<FloatTween.FloatTweenCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, "FloatTweenCallback");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatTween.FloatTweenCallback>.NativeClassPtr);
				FloatTween.FloatTweenCallback.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween.FloatTweenCallback>.NativeClassPtr, 100663657);
			}

			// Token: 0x06000EB5 RID: 3765 RVA: 0x0003B3E8 File Offset: 0x000395E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038137, XrefRangeEnd = 1038140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FloatTweenCallback()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatTween.FloatTweenCallback>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.FloatTweenCallback.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000EB6 RID: 3766 RVA: 0x00008F1A File Offset: 0x0000711A
			public FloatTweenCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000BA9 RID: 2985
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

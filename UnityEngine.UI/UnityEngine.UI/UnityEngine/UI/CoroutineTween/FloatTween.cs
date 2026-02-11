using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;

namespace UnityEngine.UI.CoroutineTween
{
	// Token: 0x02000049 RID: 73
	public sealed class FloatTween : ValueType
	{
		// Token: 0x0600088E RID: 2190 RVA: 0x00028B2C File Offset: 0x00026D2C
		// Note: this type is marked as 'beforefieldinit'.
		static FloatTween()
		{
			Il2CppClassPointerStore<FloatTween>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI.CoroutineTween", "FloatTween");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatTween>.NativeClassPtr);
			FloatTween.NativeFieldInfoPtr_m_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, "m_Target");
			FloatTween.NativeFieldInfoPtr_m_StartValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, "m_StartValue");
			FloatTween.NativeFieldInfoPtr_m_TargetValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, "m_TargetValue");
			FloatTween.NativeFieldInfoPtr_m_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, "m_Duration");
			FloatTween.NativeFieldInfoPtr_m_IgnoreTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, "m_IgnoreTimeScale");
			FloatTween.NativeMethodInfoPtr_get_startValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664686);
			FloatTween.NativeMethodInfoPtr_set_startValue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664687);
			FloatTween.NativeMethodInfoPtr_get_targetValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664688);
			FloatTween.NativeMethodInfoPtr_set_targetValue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664689);
			FloatTween.NativeMethodInfoPtr_get_duration_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664690);
			FloatTween.NativeMethodInfoPtr_set_duration_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664691);
			FloatTween.NativeMethodInfoPtr_get_ignoreTimeScale_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664692);
			FloatTween.NativeMethodInfoPtr_set_ignoreTimeScale_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664693);
			FloatTween.NativeMethodInfoPtr_TweenValue_Public_Virtual_Final_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664694);
			FloatTween.NativeMethodInfoPtr_AddOnChangedCallback_Public_Void_UnityAction_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664695);
			FloatTween.NativeMethodInfoPtr_GetIgnoreTimescale_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664696);
			FloatTween.NativeMethodInfoPtr_GetDuration_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664697);
			FloatTween.NativeMethodInfoPtr_ValidTarget_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664698);
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x00028CC4 File Offset: 0x00026EC4
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x00028D08 File Offset: 0x00026F08
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

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00028D4C File Offset: 0x00026F4C
		// (set) Token: 0x06000892 RID: 2194 RVA: 0x00028D90 File Offset: 0x00026F90
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

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x00028DD4 File Offset: 0x00026FD4
		// (set) Token: 0x06000894 RID: 2196 RVA: 0x00028E18 File Offset: 0x00027018
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

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x00028E5C File Offset: 0x0002705C
		// (set) Token: 0x06000896 RID: 2198 RVA: 0x00028EA0 File Offset: 0x000270A0
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

		// Token: 0x06000897 RID: 2199 RVA: 0x00028EE4 File Offset: 0x000270E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094192, XrefRangeEnd = 1094196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000898 RID: 2200 RVA: 0x00028F28 File Offset: 0x00027128
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1094207, RefRangeEnd = 1094208, XrefRangeStart = 1094196, XrefRangeEnd = 1094207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000899 RID: 2201 RVA: 0x00028F70 File Offset: 0x00027170
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

		// Token: 0x0600089A RID: 2202 RVA: 0x00028FB4 File Offset: 0x000271B4
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

		// Token: 0x0600089B RID: 2203 RVA: 0x00028FF8 File Offset: 0x000271F8
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

		// Token: 0x0600089C RID: 2204 RVA: 0x00004EE6 File Offset: 0x000030E6
		public FloatTween(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00004EEF File Offset: 0x000030EF
		public FloatTween()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatTween>.NativeClassPtr))
		{
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x0002903C File Offset: 0x0002723C
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x00004F01 File Offset: 0x00003101
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

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x0002906C File Offset: 0x0002726C
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x00004F20 File Offset: 0x00003120
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

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x00029094 File Offset: 0x00027294
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x00004F3B File Offset: 0x0000313B
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

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x000290BC File Offset: 0x000272BC
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x00004F56 File Offset: 0x00003156
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

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x000290E4 File Offset: 0x000272E4
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x00004F71 File Offset: 0x00003171
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

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeFieldInfoPtr_m_Target;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeFieldInfoPtr_m_StartValue;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetValue;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeFieldInfoPtr_m_Duration;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeFieldInfoPtr_m_IgnoreTimeScale;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr_get_startValue_Public_get_Single_0;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeMethodInfoPtr_set_startValue_Public_set_Void_Single_0;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeMethodInfoPtr_get_targetValue_Public_get_Single_0;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeMethodInfoPtr_set_targetValue_Public_set_Void_Single_0;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeMethodInfoPtr_set_duration_Public_set_Void_Single_0;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreTimeScale_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeMethodInfoPtr_set_ignoreTimeScale_Public_set_Void_Boolean_0;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeMethodInfoPtr_TweenValue_Public_Virtual_Final_New_Void_Single_0;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeMethodInfoPtr_AddOnChangedCallback_Public_Void_UnityAction_1_Single_0;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr_GetIgnoreTimescale_Public_Boolean_0;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Single_0;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr_ValidTarget_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x020000C3 RID: 195
		public class FloatTweenCallback : UnityEvent<float>
		{
			// Token: 0x06000D34 RID: 3380 RVA: 0x00007054 File Offset: 0x00005254
			// Note: this type is marked as 'beforefieldinit'.
			static FloatTweenCallback()
			{
				Il2CppClassPointerStore<FloatTween.FloatTweenCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, "FloatTweenCallback");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatTween.FloatTweenCallback>.NativeClassPtr);
				FloatTween.FloatTweenCallback.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween.FloatTweenCallback>.NativeClassPtr, 100664699);
			}

			// Token: 0x06000D35 RID: 3381 RVA: 0x00038A88 File Offset: 0x00036C88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094189, XrefRangeEnd = 1094192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FloatTweenCallback()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatTween.FloatTweenCallback>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.FloatTweenCallback.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D36 RID: 3382 RVA: 0x00007088 File Offset: 0x00005288
			public FloatTweenCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000A3E RID: 2622
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

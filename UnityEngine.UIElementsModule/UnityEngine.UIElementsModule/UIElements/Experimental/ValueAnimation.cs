using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.Experimental
{
	// Token: 0x020002A9 RID: 681
	public sealed class ValueAnimation<T> : Object
	{
		// Token: 0x0600322F RID: 12847 RVA: 0x000D48BC File Offset: 0x000D2ABC
		// Note: this type is marked as 'beforefieldinit'.
		static ValueAnimation()
		{
			Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.Experimental", "ValueAnimation`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr);
			ValueAnimation<T>.NativeFieldInfoPtr_m_StartTimeMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, "m_StartTimeMs");
			ValueAnimation<T>.NativeFieldInfoPtr_m_DurationMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, "m_DurationMs");
			ValueAnimation<T>.NativeFieldInfoPtr__easingCurve_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, "<easingCurve>k__BackingField");
			ValueAnimation<T>.NativeFieldInfoPtr__isRunning_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, "<isRunning>k__BackingField");
			ValueAnimation<T>.NativeFieldInfoPtr__onAnimationCompleted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, "<onAnimationCompleted>k__BackingField");
			ValueAnimation<T>.NativeFieldInfoPtr__autoRecycle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, "<autoRecycle>k__BackingField");
			ValueAnimation<T>.NativeFieldInfoPtr__recycled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, "<recycled>k__BackingField");
			ValueAnimation<T>.NativeFieldInfoPtr_sObjectPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, "sObjectPool");
			ValueAnimation<T>.NativeFieldInfoPtr__owner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, "<owner>k__BackingField");
			ValueAnimation<T>.NativeFieldInfoPtr__valueUpdated_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, "<valueUpdated>k__BackingField");
			ValueAnimation<T>.NativeFieldInfoPtr__initialValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, "<initialValue>k__BackingField");
			ValueAnimation<T>.NativeFieldInfoPtr__interpolator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, "<interpolator>k__BackingField");
			ValueAnimation<T>.NativeFieldInfoPtr__from = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, "_from");
			ValueAnimation<T>.NativeFieldInfoPtr_fromValueSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, "fromValueSet");
			ValueAnimation<T>.NativeFieldInfoPtr__to_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, "<to>k__BackingField");
			ValueAnimation<T>.NativeMethodInfoPtr_get_durationMs_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670589);
			ValueAnimation<T>.NativeMethodInfoPtr_set_durationMs_Public_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670590);
			ValueAnimation<T>.NativeMethodInfoPtr_get_easingCurve_Public_get_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670591);
			ValueAnimation<T>.NativeMethodInfoPtr_set_easingCurve_Public_set_Void_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670592);
			ValueAnimation<T>.NativeMethodInfoPtr_get_isRunning_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670593);
			ValueAnimation<T>.NativeMethodInfoPtr_set_isRunning_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670594);
			ValueAnimation<T>.NativeMethodInfoPtr_get_onAnimationCompleted_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670595);
			ValueAnimation<T>.NativeMethodInfoPtr_set_onAnimationCompleted_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670596);
			ValueAnimation<T>.NativeMethodInfoPtr_get_autoRecycle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670597);
			ValueAnimation<T>.NativeMethodInfoPtr_set_autoRecycle_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670598);
			ValueAnimation<T>.NativeMethodInfoPtr_get_recycled_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670599);
			ValueAnimation<T>.NativeMethodInfoPtr_set_recycled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670600);
			ValueAnimation<T>.NativeMethodInfoPtr_get_owner_Private_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670601);
			ValueAnimation<T>.NativeMethodInfoPtr_set_owner_Private_set_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670602);
			ValueAnimation<T>.NativeMethodInfoPtr_get_valueUpdated_Public_get_Action_2_VisualElement_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670603);
			ValueAnimation<T>.NativeMethodInfoPtr_set_valueUpdated_Public_set_Void_Action_2_VisualElement_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670604);
			ValueAnimation<T>.NativeMethodInfoPtr_get_initialValue_Public_get_Func_2_VisualElement_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670605);
			ValueAnimation<T>.NativeMethodInfoPtr_set_initialValue_Public_set_Void_Func_2_VisualElement_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670606);
			ValueAnimation<T>.NativeMethodInfoPtr_get_interpolator_Public_get_Func_4_T_T_Single_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670607);
			ValueAnimation<T>.NativeMethodInfoPtr_set_interpolator_Public_set_Void_Func_4_T_T_Single_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670608);
			ValueAnimation<T>.NativeMethodInfoPtr_get_from_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670609);
			ValueAnimation<T>.NativeMethodInfoPtr_set_from_Public_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670610);
			ValueAnimation<T>.NativeMethodInfoPtr_get_to_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670611);
			ValueAnimation<T>.NativeMethodInfoPtr_set_to_Public_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670612);
			ValueAnimation<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670613);
			ValueAnimation<T>.NativeMethodInfoPtr_Start_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670614);
			ValueAnimation<T>.NativeMethodInfoPtr_Stop_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670615);
			ValueAnimation<T>.NativeMethodInfoPtr_Recycle_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670616);
			ValueAnimation<T>.NativeMethodInfoPtr_UnityEngine_UIElements_Experimental_IValueAnimationUpdate_Tick_Private_Virtual_Final_New_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670617);
			ValueAnimation<T>.NativeMethodInfoPtr_SetDefaultValues_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670618);
			ValueAnimation<T>.NativeMethodInfoPtr_Unregister_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670619);
			ValueAnimation<T>.NativeMethodInfoPtr_Register_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670620);
			ValueAnimation<T>.NativeMethodInfoPtr_SetOwner_Internal_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670621);
			ValueAnimation<T>.NativeMethodInfoPtr_CheckNotRecycled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670622);
			ValueAnimation<T>.NativeMethodInfoPtr_Create_Public_Static_ValueAnimation_1_T_VisualElement_Func_4_T_T_Single_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670623);
			ValueAnimation<T>.NativeMethodInfoPtr_KeepAlive_Public_ValueAnimation_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, 100670624);
		}

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x06003230 RID: 12848 RVA: 0x000D4D24 File Offset: 0x000D2F24
		// (set) Token: 0x06003231 RID: 12849 RVA: 0x000D4D60 File Offset: 0x000D2F60
		public unsafe int durationMs
		{
			[CallerCount(66)]
			[CachedScanResults(RefRangeStart = 320372, RefRangeEnd = 320438, XrefRangeStart = 320372, XrefRangeEnd = 320438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_get_durationMs_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 359724, RefRangeEnd = 359725, XrefRangeStart = 359724, XrefRangeEnd = 359724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_set_durationMs_Public_Virtual_Final_New_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x06003232 RID: 12850 RVA: 0x000D4DA0 File Offset: 0x000D2FA0
		// (set) Token: 0x06003233 RID: 12851 RVA: 0x000D4DE0 File Offset: 0x000D2FE0
		public unsafe Func<float, float> easingCurve
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_get_easingCurve_Public_get_Func_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_set_easingCurve_Public_set_Void_Func_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x06003234 RID: 12852 RVA: 0x000D4E24 File Offset: 0x000D3024
		// (set) Token: 0x06003235 RID: 12853 RVA: 0x000D4E60 File Offset: 0x000D3060
		public unsafe bool isRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_get_isRunning_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 287297, RefRangeEnd = 287316, XrefRangeStart = 287297, XrefRangeEnd = 287316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_set_isRunning_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x06003236 RID: 12854 RVA: 0x000D4EA0 File Offset: 0x000D30A0
		// (set) Token: 0x06003237 RID: 12855 RVA: 0x000D4EE0 File Offset: 0x000D30E0
		public unsafe Action onAnimationCompleted
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_get_onAnimationCompleted_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_set_onAnimationCompleted_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x06003238 RID: 12856 RVA: 0x000D4F24 File Offset: 0x000D3124
		// (set) Token: 0x06003239 RID: 12857 RVA: 0x000D4F60 File Offset: 0x000D3160
		public unsafe bool autoRecycle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_get_autoRecycle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_set_autoRecycle_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x0600323A RID: 12858 RVA: 0x000D4FA0 File Offset: 0x000D31A0
		// (set) Token: 0x0600323B RID: 12859 RVA: 0x000D4FDC File Offset: 0x000D31DC
		public unsafe bool recycled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_get_recycled_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_set_recycled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x0600323C RID: 12860 RVA: 0x000D501C File Offset: 0x000D321C
		// (set) Token: 0x0600323D RID: 12861 RVA: 0x000D505C File Offset: 0x000D325C
		public unsafe VisualElement owner
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_get_owner_Private_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359725, XrefRangeEnd = 359726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_set_owner_Private_set_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x0600323E RID: 12862 RVA: 0x000D50A0 File Offset: 0x000D32A0
		// (set) Token: 0x0600323F RID: 12863 RVA: 0x000D50E0 File Offset: 0x000D32E0
		public unsafe Action<VisualElement, T> valueUpdated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_get_valueUpdated_Public_get_Action_2_VisualElement_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<VisualElement, T>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_set_valueUpdated_Public_set_Void_Action_2_VisualElement_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x06003240 RID: 12864 RVA: 0x000D5124 File Offset: 0x000D3324
		// (set) Token: 0x06003241 RID: 12865 RVA: 0x000D5164 File Offset: 0x000D3364
		public unsafe Func<VisualElement, T> initialValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_get_initialValue_Public_get_Func_2_VisualElement_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<VisualElement, T>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_set_initialValue_Public_set_Void_Func_2_VisualElement_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x06003242 RID: 12866 RVA: 0x000D51A8 File Offset: 0x000D33A8
		// (set) Token: 0x06003243 RID: 12867 RVA: 0x000D51E8 File Offset: 0x000D33E8
		public unsafe Func<T, T, float, T> interpolator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_get_interpolator_Public_get_Func_4_T_T_Single_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<T, T, float, T>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_set_interpolator_Public_set_Void_Func_4_T_T_Single_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x06003244 RID: 12868 RVA: 0x000D522C File Offset: 0x000D342C
		// (set) Token: 0x06003245 RID: 12869 RVA: 0x000D5268 File Offset: 0x000D3468
		public unsafe T from
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359726, XrefRangeEnd = 359727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_get_from_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359727, XrefRangeEnd = 359746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_set_from_Public_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x06003246 RID: 12870 RVA: 0x000D52E0 File Offset: 0x000D34E0
		// (set) Token: 0x06003247 RID: 12871 RVA: 0x000D531C File Offset: 0x000D351C
		public unsafe T to
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_get_to_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359746, XrefRangeEnd = 359756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_set_to_Public_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x06003248 RID: 12872 RVA: 0x000D5394 File Offset: 0x000D3594
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359759, RefRangeEnd = 359760, XrefRangeStart = 359756, XrefRangeEnd = 359759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueAnimation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003249 RID: 12873 RVA: 0x000D53D0 File Offset: 0x000D35D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359765, RefRangeEnd = 359766, XrefRangeStart = 359760, XrefRangeEnd = 359765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_Start_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600324A RID: 12874 RVA: 0x000D5404 File Offset: 0x000D3604
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 359773, RefRangeEnd = 359777, XrefRangeStart = 359766, XrefRangeEnd = 359773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_Stop_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600324B RID: 12875 RVA: 0x000D5438 File Offset: 0x000D3638
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 359778, RefRangeEnd = 359780, XrefRangeStart = 359777, XrefRangeEnd = 359778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Recycle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_Recycle_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600324C RID: 12876 RVA: 0x000D546C File Offset: 0x000D366C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359780, XrefRangeEnd = 359782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnityEngine_UIElements_Experimental_IValueAnimationUpdate_Tick(long currentTimeMs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentTimeMs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_UnityEngine_UIElements_Experimental_IValueAnimationUpdate_Tick_Private_Virtual_Final_New_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x000D54AC File Offset: 0x000D36AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359782, XrefRangeEnd = 359796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefaultValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_SetDefaultValues_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600324E RID: 12878 RVA: 0x000D54E0 File Offset: 0x000D36E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359796, XrefRangeEnd = 359797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unregister()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_Unregister_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600324F RID: 12879 RVA: 0x000D5514 File Offset: 0x000D3714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359797, XrefRangeEnd = 359798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Register()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_Register_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003250 RID: 12880 RVA: 0x000D5548 File Offset: 0x000D3748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359798, XrefRangeEnd = 359801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOwner(VisualElement e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_SetOwner_Internal_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003251 RID: 12881 RVA: 0x000D558C File Offset: 0x000D378C
		[CallerCount(0)]
		public unsafe void CheckNotRecycled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_CheckNotRecycled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003252 RID: 12882 RVA: 0x000D55C0 File Offset: 0x000D37C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 359815, RefRangeEnd = 359817, XrefRangeStart = 359801, XrefRangeEnd = 359815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueAnimation<T> Create(VisualElement e, Func<T, T, float, T> interpolator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(interpolator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_Create_Public_Static_ValueAnimation_1_T_VisualElement_Func_4_T_T_Single_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValueAnimation<T>>(intPtr3) : null;
		}

		// Token: 0x06003253 RID: 12883 RVA: 0x000D5618 File Offset: 0x000D3818
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359817, RefRangeEnd = 359818, XrefRangeStart = 359817, XrefRangeEnd = 359817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueAnimation<T> KeepAlive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.NativeMethodInfoPtr_KeepAlive_Public_ValueAnimation_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValueAnimation<T>>(intPtr3) : null;
		}

		// Token: 0x06003254 RID: 12884 RVA: 0x000144E5 File Offset: 0x000126E5
		public ValueAnimation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x06003255 RID: 12885 RVA: 0x000D5658 File Offset: 0x000D3858
		// (set) Token: 0x06003256 RID: 12886 RVA: 0x000144EE File Offset: 0x000126EE
		public unsafe long m_StartTimeMs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr_m_StartTimeMs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr_m_StartTimeMs)) = value;
			}
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x06003257 RID: 12887 RVA: 0x000D5680 File Offset: 0x000D3880
		// (set) Token: 0x06003258 RID: 12888 RVA: 0x00014509 File Offset: 0x00012709
		public unsafe int m_DurationMs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr_m_DurationMs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr_m_DurationMs)) = value;
			}
		}

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x06003259 RID: 12889 RVA: 0x000D56A8 File Offset: 0x000D38A8
		// (set) Token: 0x0600325A RID: 12890 RVA: 0x00014524 File Offset: 0x00012724
		public unsafe Func<float, float> _easingCurve_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr__easingCurve_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr__easingCurve_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x0600325B RID: 12891 RVA: 0x000D56D8 File Offset: 0x000D38D8
		// (set) Token: 0x0600325C RID: 12892 RVA: 0x00014543 File Offset: 0x00012743
		public unsafe bool _isRunning_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr__isRunning_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr__isRunning_k__BackingField)) = value;
			}
		}

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x0600325D RID: 12893 RVA: 0x000D5700 File Offset: 0x000D3900
		// (set) Token: 0x0600325E RID: 12894 RVA: 0x0001455E File Offset: 0x0001275E
		public unsafe Action _onAnimationCompleted_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr__onAnimationCompleted_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr__onAnimationCompleted_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x0600325F RID: 12895 RVA: 0x000D5730 File Offset: 0x000D3930
		// (set) Token: 0x06003260 RID: 12896 RVA: 0x0001457D File Offset: 0x0001277D
		public unsafe bool _autoRecycle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr__autoRecycle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr__autoRecycle_k__BackingField)) = value;
			}
		}

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x06003261 RID: 12897 RVA: 0x000D5758 File Offset: 0x000D3958
		// (set) Token: 0x06003262 RID: 12898 RVA: 0x00014598 File Offset: 0x00012798
		public unsafe bool _recycled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr__recycled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr__recycled_k__BackingField)) = value;
			}
		}

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x06003263 RID: 12899 RVA: 0x000D5780 File Offset: 0x000D3980
		// (set) Token: 0x06003264 RID: 12900 RVA: 0x000145B3 File Offset: 0x000127B3
		public unsafe static ObjectPool<ValueAnimation<T>> sObjectPool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ValueAnimation<T>.NativeFieldInfoPtr_sObjectPool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<ValueAnimation<T>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValueAnimation<T>.NativeFieldInfoPtr_sObjectPool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x06003265 RID: 12901 RVA: 0x000D57A8 File Offset: 0x000D39A8
		// (set) Token: 0x06003266 RID: 12902 RVA: 0x000145C5 File Offset: 0x000127C5
		public unsafe VisualElement _owner_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr__owner_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr__owner_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x06003267 RID: 12903 RVA: 0x000D57D8 File Offset: 0x000D39D8
		// (set) Token: 0x06003268 RID: 12904 RVA: 0x000145E4 File Offset: 0x000127E4
		public unsafe Action<VisualElement, T> _valueUpdated_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr__valueUpdated_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<VisualElement, T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr__valueUpdated_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x06003269 RID: 12905 RVA: 0x000D5808 File Offset: 0x000D3A08
		// (set) Token: 0x0600326A RID: 12906 RVA: 0x00014603 File Offset: 0x00012803
		public unsafe Func<VisualElement, T> _initialValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr__initialValue_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VisualElement, T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr__initialValue_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x0600326B RID: 12907 RVA: 0x000D5838 File Offset: 0x000D3A38
		// (set) Token: 0x0600326C RID: 12908 RVA: 0x00014622 File Offset: 0x00012822
		public unsafe Func<T, T, float, T> _interpolator_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr__interpolator_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, T, float, T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr__interpolator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x0600326D RID: 12909 RVA: 0x000D5868 File Offset: 0x000D3A68
		// (set) Token: 0x0600326E RID: 12910 RVA: 0x000D5890 File Offset: 0x000D3A90
		public unsafe T _from
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr__from);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr__from);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x0600326F RID: 12911 RVA: 0x000D5938 File Offset: 0x000D3B38
		// (set) Token: 0x06003270 RID: 12912 RVA: 0x00014641 File Offset: 0x00012841
		public unsafe bool fromValueSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr_fromValueSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr_fromValueSet)) = value;
			}
		}

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x06003271 RID: 12913 RVA: 0x000D5960 File Offset: 0x000D3B60
		// (set) Token: 0x06003272 RID: 12914 RVA: 0x000D5988 File Offset: 0x000D3B88
		public unsafe T _to_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr__to_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueAnimation<T>.NativeFieldInfoPtr__to_k__BackingField);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x000D5A30 File Offset: 0x000D3C30
		public ValueAnimation<T> Ease(Func<float, float> easing)
		{
			this.easingCurve = easing;
			return this;
		}

		// Token: 0x06003274 RID: 12916 RVA: 0x000D5A4C File Offset: 0x000D3C4C
		public ValueAnimation<T> OnCompleted(Action callback)
		{
			this.onAnimationCompleted = callback;
			return this;
		}

		// Token: 0x040024D0 RID: 9424
		private static readonly IntPtr NativeFieldInfoPtr_m_StartTimeMs;

		// Token: 0x040024D1 RID: 9425
		private static readonly IntPtr NativeFieldInfoPtr_m_DurationMs;

		// Token: 0x040024D2 RID: 9426
		private static readonly IntPtr NativeFieldInfoPtr__easingCurve_k__BackingField;

		// Token: 0x040024D3 RID: 9427
		private static readonly IntPtr NativeFieldInfoPtr__isRunning_k__BackingField;

		// Token: 0x040024D4 RID: 9428
		private static readonly IntPtr NativeFieldInfoPtr__onAnimationCompleted_k__BackingField;

		// Token: 0x040024D5 RID: 9429
		private static readonly IntPtr NativeFieldInfoPtr__autoRecycle_k__BackingField;

		// Token: 0x040024D6 RID: 9430
		private static readonly IntPtr NativeFieldInfoPtr__recycled_k__BackingField;

		// Token: 0x040024D7 RID: 9431
		private static readonly IntPtr NativeFieldInfoPtr_sObjectPool;

		// Token: 0x040024D8 RID: 9432
		private static readonly IntPtr NativeFieldInfoPtr__owner_k__BackingField;

		// Token: 0x040024D9 RID: 9433
		private static readonly IntPtr NativeFieldInfoPtr__valueUpdated_k__BackingField;

		// Token: 0x040024DA RID: 9434
		private static readonly IntPtr NativeFieldInfoPtr__initialValue_k__BackingField;

		// Token: 0x040024DB RID: 9435
		private static readonly IntPtr NativeFieldInfoPtr__interpolator_k__BackingField;

		// Token: 0x040024DC RID: 9436
		private static readonly IntPtr NativeFieldInfoPtr__from;

		// Token: 0x040024DD RID: 9437
		private static readonly IntPtr NativeFieldInfoPtr_fromValueSet;

		// Token: 0x040024DE RID: 9438
		private static readonly IntPtr NativeFieldInfoPtr__to_k__BackingField;

		// Token: 0x040024DF RID: 9439
		private static readonly IntPtr NativeMethodInfoPtr_get_durationMs_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040024E0 RID: 9440
		private static readonly IntPtr NativeMethodInfoPtr_set_durationMs_Public_Virtual_Final_New_set_Void_Int32_0;

		// Token: 0x040024E1 RID: 9441
		private static readonly IntPtr NativeMethodInfoPtr_get_easingCurve_Public_get_Func_2_Single_Single_0;

		// Token: 0x040024E2 RID: 9442
		private static readonly IntPtr NativeMethodInfoPtr_set_easingCurve_Public_set_Void_Func_2_Single_Single_0;

		// Token: 0x040024E3 RID: 9443
		private static readonly IntPtr NativeMethodInfoPtr_get_isRunning_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040024E4 RID: 9444
		private static readonly IntPtr NativeMethodInfoPtr_set_isRunning_Private_set_Void_Boolean_0;

		// Token: 0x040024E5 RID: 9445
		private static readonly IntPtr NativeMethodInfoPtr_get_onAnimationCompleted_Public_get_Action_0;

		// Token: 0x040024E6 RID: 9446
		private static readonly IntPtr NativeMethodInfoPtr_set_onAnimationCompleted_Public_set_Void_Action_0;

		// Token: 0x040024E7 RID: 9447
		private static readonly IntPtr NativeMethodInfoPtr_get_autoRecycle_Public_get_Boolean_0;

		// Token: 0x040024E8 RID: 9448
		private static readonly IntPtr NativeMethodInfoPtr_set_autoRecycle_Public_set_Void_Boolean_0;

		// Token: 0x040024E9 RID: 9449
		private static readonly IntPtr NativeMethodInfoPtr_get_recycled_Private_get_Boolean_0;

		// Token: 0x040024EA RID: 9450
		private static readonly IntPtr NativeMethodInfoPtr_set_recycled_Private_set_Void_Boolean_0;

		// Token: 0x040024EB RID: 9451
		private static readonly IntPtr NativeMethodInfoPtr_get_owner_Private_get_VisualElement_0;

		// Token: 0x040024EC RID: 9452
		private static readonly IntPtr NativeMethodInfoPtr_set_owner_Private_set_Void_VisualElement_0;

		// Token: 0x040024ED RID: 9453
		private static readonly IntPtr NativeMethodInfoPtr_get_valueUpdated_Public_get_Action_2_VisualElement_T_0;

		// Token: 0x040024EE RID: 9454
		private static readonly IntPtr NativeMethodInfoPtr_set_valueUpdated_Public_set_Void_Action_2_VisualElement_T_0;

		// Token: 0x040024EF RID: 9455
		private static readonly IntPtr NativeMethodInfoPtr_get_initialValue_Public_get_Func_2_VisualElement_T_0;

		// Token: 0x040024F0 RID: 9456
		private static readonly IntPtr NativeMethodInfoPtr_set_initialValue_Public_set_Void_Func_2_VisualElement_T_0;

		// Token: 0x040024F1 RID: 9457
		private static readonly IntPtr NativeMethodInfoPtr_get_interpolator_Public_get_Func_4_T_T_Single_T_0;

		// Token: 0x040024F2 RID: 9458
		private static readonly IntPtr NativeMethodInfoPtr_set_interpolator_Public_set_Void_Func_4_T_T_Single_T_0;

		// Token: 0x040024F3 RID: 9459
		private static readonly IntPtr NativeMethodInfoPtr_get_from_Public_get_T_0;

		// Token: 0x040024F4 RID: 9460
		private static readonly IntPtr NativeMethodInfoPtr_set_from_Public_set_Void_T_0;

		// Token: 0x040024F5 RID: 9461
		private static readonly IntPtr NativeMethodInfoPtr_get_to_Public_get_T_0;

		// Token: 0x040024F6 RID: 9462
		private static readonly IntPtr NativeMethodInfoPtr_set_to_Public_set_Void_T_0;

		// Token: 0x040024F7 RID: 9463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040024F8 RID: 9464
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Final_New_Void_0;

		// Token: 0x040024F9 RID: 9465
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Virtual_Final_New_Void_0;

		// Token: 0x040024FA RID: 9466
		private static readonly IntPtr NativeMethodInfoPtr_Recycle_Public_Virtual_Final_New_Void_0;

		// Token: 0x040024FB RID: 9467
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_Experimental_IValueAnimationUpdate_Tick_Private_Virtual_Final_New_Void_Int64_0;

		// Token: 0x040024FC RID: 9468
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultValues_Private_Void_0;

		// Token: 0x040024FD RID: 9469
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Private_Void_0;

		// Token: 0x040024FE RID: 9470
		private static readonly IntPtr NativeMethodInfoPtr_Register_Private_Void_0;

		// Token: 0x040024FF RID: 9471
		private static readonly IntPtr NativeMethodInfoPtr_SetOwner_Internal_Void_VisualElement_0;

		// Token: 0x04002500 RID: 9472
		private static readonly IntPtr NativeMethodInfoPtr_CheckNotRecycled_Private_Void_0;

		// Token: 0x04002501 RID: 9473
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ValueAnimation_1_T_VisualElement_Func_4_T_T_Single_T_0;

		// Token: 0x04002502 RID: 9474
		private static readonly IntPtr NativeMethodInfoPtr_KeepAlive_Public_ValueAnimation_1_T_0;

		// Token: 0x04002503 RID: 9475
		public const int k_DefaultDurationMs = 400;

		// Token: 0x04002504 RID: 9476
		public const int k_DefaultMaxPoolSize = 100;

		// Token: 0x02000574 RID: 1396
		[ObfuscatedName("UnityEngine.UIElements.Experimental.ValueAnimation`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600426C RID: 17004 RVA: 0x00104A54 File Offset: 0x00102C54
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ValueAnimation<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValueAnimation<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueAnimation<T>.__c>.NativeClassPtr);
				ValueAnimation<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueAnimation<T>.__c>.NativeClassPtr, "<>9");
				ValueAnimation<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>.__c>.NativeClassPtr, 100670627);
				ValueAnimation<T>.__c.NativeMethodInfoPtr___cctor_b__67_0_Internal_ValueAnimation_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueAnimation<T>.__c>.NativeClassPtr, 100670628);
			}

			// Token: 0x0600426D RID: 17005 RVA: 0x00104AF8 File Offset: 0x00102CF8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueAnimation<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600426E RID: 17006 RVA: 0x00104B34 File Offset: 0x00102D34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359721, XrefRangeEnd = 359724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueAnimation<T> __cctor_b__67_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueAnimation<T>.__c.NativeMethodInfoPtr___cctor_b__67_0_Internal_ValueAnimation_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValueAnimation<T>>(intPtr3) : null;
			}

			// Token: 0x0600426F RID: 17007 RVA: 0x0001C5CF File Offset: 0x0001A7CF
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013E6 RID: 5094
			// (get) Token: 0x06004270 RID: 17008 RVA: 0x00104B74 File Offset: 0x00102D74
			// (set) Token: 0x06004271 RID: 17009 RVA: 0x0001C5D8 File Offset: 0x0001A7D8
			public unsafe static ValueAnimation<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ValueAnimation<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueAnimation<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ValueAnimation<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E90 RID: 11920
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002E91 RID: 11921
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002E92 RID: 11922
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__67_0_Internal_ValueAnimation_1_T_0;
		}
	}
}

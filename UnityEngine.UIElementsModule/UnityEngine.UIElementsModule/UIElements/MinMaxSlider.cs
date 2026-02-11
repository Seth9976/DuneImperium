using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000071 RID: 113
	public class MinMaxSlider : BaseField<Vector2>
	{
		// Token: 0x06000A73 RID: 2675 RVA: 0x00041B88 File Offset: 0x0003FD88
		// Note: this type is marked as 'beforefieldinit'.
		static MinMaxSlider()
		{
			Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MinMaxSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr);
			MinMaxSlider.NativeFieldInfoPtr__dragElement_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, "<dragElement>k__BackingField");
			MinMaxSlider.NativeFieldInfoPtr__dragMinThumb_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, "<dragMinThumb>k__BackingField");
			MinMaxSlider.NativeFieldInfoPtr__dragMaxThumb_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, "<dragMaxThumb>k__BackingField");
			MinMaxSlider.NativeFieldInfoPtr__clampedDragger_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, "<clampedDragger>k__BackingField");
			MinMaxSlider.NativeFieldInfoPtr_m_DragElementStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, "m_DragElementStartPos");
			MinMaxSlider.NativeFieldInfoPtr_m_ValueStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, "m_ValueStartPos");
			MinMaxSlider.NativeFieldInfoPtr_m_DragMinThumbRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, "m_DragMinThumbRect");
			MinMaxSlider.NativeFieldInfoPtr_m_DragMaxThumbRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, "m_DragMaxThumbRect");
			MinMaxSlider.NativeFieldInfoPtr_m_DragState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, "m_DragState");
			MinMaxSlider.NativeFieldInfoPtr_m_MinLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, "m_MinLimit");
			MinMaxSlider.NativeFieldInfoPtr_m_MaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, "m_MaxLimit");
			MinMaxSlider.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, "ussClassName");
			MinMaxSlider.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, "labelUssClassName");
			MinMaxSlider.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, "inputUssClassName");
			MinMaxSlider.NativeFieldInfoPtr_trackerUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, "trackerUssClassName");
			MinMaxSlider.NativeFieldInfoPtr_draggerUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, "draggerUssClassName");
			MinMaxSlider.NativeFieldInfoPtr_minThumbUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, "minThumbUssClassName");
			MinMaxSlider.NativeFieldInfoPtr_maxThumbUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, "maxThumbUssClassName");
			MinMaxSlider.NativeMethodInfoPtr_get_dragElement_Internal_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664815);
			MinMaxSlider.NativeMethodInfoPtr_set_dragElement_Private_set_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664816);
			MinMaxSlider.NativeMethodInfoPtr_get_dragMinThumb_Internal_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664817);
			MinMaxSlider.NativeMethodInfoPtr_set_dragMinThumb_Private_set_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664818);
			MinMaxSlider.NativeMethodInfoPtr_get_dragMaxThumb_Internal_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664819);
			MinMaxSlider.NativeMethodInfoPtr_set_dragMaxThumb_Private_set_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664820);
			MinMaxSlider.NativeMethodInfoPtr_get_clampedDragger_Internal_get_ClampedDragger_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664821);
			MinMaxSlider.NativeMethodInfoPtr_set_clampedDragger_Private_set_Void_ClampedDragger_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664822);
			MinMaxSlider.NativeMethodInfoPtr_get_minValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664823);
			MinMaxSlider.NativeMethodInfoPtr_set_minValue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664824);
			MinMaxSlider.NativeMethodInfoPtr_get_maxValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664825);
			MinMaxSlider.NativeMethodInfoPtr_set_maxValue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664826);
			MinMaxSlider.NativeMethodInfoPtr_get_value_Public_Virtual_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664827);
			MinMaxSlider.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664828);
			MinMaxSlider.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664829);
			MinMaxSlider.NativeMethodInfoPtr_get_lowLimit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664830);
			MinMaxSlider.NativeMethodInfoPtr_set_lowLimit_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664831);
			MinMaxSlider.NativeMethodInfoPtr_get_highLimit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664832);
			MinMaxSlider.NativeMethodInfoPtr_set_highLimit_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664833);
			MinMaxSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664834);
			MinMaxSlider.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664835);
			MinMaxSlider.NativeMethodInfoPtr_ClampValues_Private_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664836);
			MinMaxSlider.NativeMethodInfoPtr_UpdateDragElementPosition_Private_Void_GeometryChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664837);
			MinMaxSlider.NativeMethodInfoPtr_UpdateDragElementPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664838);
			MinMaxSlider.NativeMethodInfoPtr_UpdateDragThumbsRect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664839);
			MinMaxSlider.NativeMethodInfoPtr_SliderLerpUnclamped_Internal_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664840);
			MinMaxSlider.NativeMethodInfoPtr_SliderNormalizeValue_Internal_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664841);
			MinMaxSlider.NativeMethodInfoPtr_ComputeValueFromPosition_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664842);
			MinMaxSlider.NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664843);
			MinMaxSlider.NativeMethodInfoPtr_SetSliderValueFromDrag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664844);
			MinMaxSlider.NativeMethodInfoPtr_SetSliderValueFromClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664845);
			MinMaxSlider.NativeMethodInfoPtr_ComputeValueFromDraggingThumb_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664846);
			MinMaxSlider.NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664847);
			MinMaxSlider.NativeMethodInfoPtr_RegisterEditingCallbacks_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664848);
			MinMaxSlider.NativeMethodInfoPtr_UnregisterEditingCallbacks_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, 100664849);
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x00041FDC File Offset: 0x000401DC
		// (set) Token: 0x06000A75 RID: 2677 RVA: 0x0004201C File Offset: 0x0004021C
		public unsafe VisualElement dragElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_get_dragElement_Internal_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299633, XrefRangeEnd = 299634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_set_dragElement_Private_set_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x00042060 File Offset: 0x00040260
		// (set) Token: 0x06000A77 RID: 2679 RVA: 0x000420A0 File Offset: 0x000402A0
		public unsafe VisualElement dragMinThumb
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_get_dragMinThumb_Internal_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_set_dragMinThumb_Private_set_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x000420E4 File Offset: 0x000402E4
		// (set) Token: 0x06000A79 RID: 2681 RVA: 0x00042124 File Offset: 0x00040324
		public unsafe VisualElement dragMaxThumb
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_get_dragMaxThumb_Internal_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_set_dragMaxThumb_Private_set_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x00042168 File Offset: 0x00040368
		// (set) Token: 0x06000A7B RID: 2683 RVA: 0x000421A8 File Offset: 0x000403A8
		public unsafe ClampedDragger<float> clampedDragger
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_get_clampedDragger_Internal_get_ClampedDragger_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClampedDragger<float>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_set_clampedDragger_Private_set_Void_ClampedDragger_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x000421EC File Offset: 0x000403EC
		// (set) Token: 0x06000A7D RID: 2685 RVA: 0x00042228 File Offset: 0x00040428
		public unsafe float minValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_get_minValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299634, XrefRangeEnd = 299641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_set_minValue_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x00042268 File Offset: 0x00040468
		// (set) Token: 0x06000A7F RID: 2687 RVA: 0x000422A4 File Offset: 0x000404A4
		public unsafe float maxValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_get_maxValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299641, XrefRangeEnd = 299648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_set_maxValue_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x000422E4 File Offset: 0x000404E4
		// (set) Token: 0x06000A81 RID: 2689 RVA: 0x0004232C File Offset: 0x0004052C
		public unsafe override Vector2 value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299648, XrefRangeEnd = 299651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MinMaxSlider.NativeMethodInfoPtr_get_value_Public_Virtual_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299651, XrefRangeEnd = 299655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MinMaxSlider.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00042378 File Offset: 0x00040578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299655, XrefRangeEnd = 299660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValueWithoutNotify(Vector2 newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MinMaxSlider.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x000423C4 File Offset: 0x000405C4
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x00042400 File Offset: 0x00040600
		public unsafe float lowLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_get_lowLimit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 299667, RefRangeEnd = 299669, XrefRangeStart = 299660, XrefRangeEnd = 299667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_set_lowLimit_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x00042440 File Offset: 0x00040640
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x0004247C File Offset: 0x0004067C
		public unsafe float highLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_get_highLimit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 299676, RefRangeEnd = 299678, XrefRangeStart = 299669, XrefRangeEnd = 299676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_set_highLimit_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x000424BC File Offset: 0x000406BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299678, XrefRangeEnd = 299679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MinMaxSlider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x000424F8 File Offset: 0x000406F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299799, RefRangeEnd = 299800, XrefRangeStart = 299679, XrefRangeEnd = 299799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MinMaxSlider(string label, float minValue = 0f, float maxValue = 10f, float minLimit = -3.4028235E+38f, float maxLimit = 3.4028235E+38f)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minLimit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLimit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x0004257C File Offset: 0x0004077C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 299801, RefRangeEnd = 299809, XrefRangeStart = 299800, XrefRangeEnd = 299801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 ClampValues(Vector2 valueToClamp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valueToClamp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_ClampValues_Private_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x000425C8 File Offset: 0x000407C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299809, XrefRangeEnd = 299810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDragElementPosition(GeometryChangedEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_UpdateDragElementPosition_Private_Void_GeometryChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0004260C File Offset: 0x0004080C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 299899, RefRangeEnd = 299905, XrefRangeStart = 299810, XrefRangeEnd = 299899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDragElementPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_UpdateDragElementPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00042640 File Offset: 0x00040840
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 299944, RefRangeEnd = 299946, XrefRangeStart = 299905, XrefRangeEnd = 299944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDragThumbsRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_UpdateDragThumbsRect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00042674 File Offset: 0x00040874
		[CallerCount(0)]
		public unsafe float SliderLerpUnclamped(float a, float b, float interpolant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interpolant;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_SliderLerpUnclamped_Internal_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x000426DC File Offset: 0x000408DC
		[CallerCount(0)]
		public unsafe float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowerValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref higherValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_SliderNormalizeValue_Internal_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00042744 File Offset: 0x00040944
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 299957, RefRangeEnd = 299960, XrefRangeStart = 299946, XrefRangeEnd = 299957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ComputeValueFromPosition(float positionToConvert)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref positionToConvert;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_ComputeValueFromPosition_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00042790 File Offset: 0x00040990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299960, XrefRangeEnd = 299970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ExecuteDefaultAction(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MinMaxSlider.NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x000427E0 File Offset: 0x000409E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299970, XrefRangeEnd = 299975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderValueFromDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_SetSliderValueFromDrag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00042814 File Offset: 0x00040A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299975, XrefRangeEnd = 299987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderValueFromClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_SetSliderValueFromClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00042848 File Offset: 0x00040A48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299994, RefRangeEnd = 299995, XrefRangeStart = 299987, XrefRangeEnd = 299994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ComputeValueFromDraggingThumb(float dragElementStartPos, float dragElementEndPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dragElementStartPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dragElementEndPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.NativeMethodInfoPtr_ComputeValueFromDraggingThumb_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00042894 File Offset: 0x00040A94
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateMixedValueContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MinMaxSlider.NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x000428D0 File Offset: 0x00040AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299995, XrefRangeEnd = 300019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RegisterEditingCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MinMaxSlider.NativeMethodInfoPtr_RegisterEditingCallbacks_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x0004290C File Offset: 0x00040B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300019, XrefRangeEnd = 300043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UnregisterEditingCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MinMaxSlider.NativeMethodInfoPtr_UnregisterEditingCallbacks_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00005C6C File Offset: 0x00003E6C
		public MinMaxSlider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x00042948 File Offset: 0x00040B48
		// (set) Token: 0x06000A99 RID: 2713 RVA: 0x00005C75 File Offset: 0x00003E75
		public unsafe VisualElement _dragElement_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.NativeFieldInfoPtr__dragElement_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.NativeFieldInfoPtr__dragElement_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x00042978 File Offset: 0x00040B78
		// (set) Token: 0x06000A9B RID: 2715 RVA: 0x00005C94 File Offset: 0x00003E94
		public unsafe VisualElement _dragMinThumb_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.NativeFieldInfoPtr__dragMinThumb_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.NativeFieldInfoPtr__dragMinThumb_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x000429A8 File Offset: 0x00040BA8
		// (set) Token: 0x06000A9D RID: 2717 RVA: 0x00005CB3 File Offset: 0x00003EB3
		public unsafe VisualElement _dragMaxThumb_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.NativeFieldInfoPtr__dragMaxThumb_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.NativeFieldInfoPtr__dragMaxThumb_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x000429D8 File Offset: 0x00040BD8
		// (set) Token: 0x06000A9F RID: 2719 RVA: 0x00005CD2 File Offset: 0x00003ED2
		public unsafe ClampedDragger<float> _clampedDragger_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.NativeFieldInfoPtr__clampedDragger_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedDragger<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.NativeFieldInfoPtr__clampedDragger_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x00042A08 File Offset: 0x00040C08
		// (set) Token: 0x06000AA1 RID: 2721 RVA: 0x00005CF1 File Offset: 0x00003EF1
		public unsafe Vector2 m_DragElementStartPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.NativeFieldInfoPtr_m_DragElementStartPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.NativeFieldInfoPtr_m_DragElementStartPos)) = value;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x00042A30 File Offset: 0x00040C30
		// (set) Token: 0x06000AA3 RID: 2723 RVA: 0x00005D0C File Offset: 0x00003F0C
		public unsafe Vector2 m_ValueStartPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.NativeFieldInfoPtr_m_ValueStartPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.NativeFieldInfoPtr_m_ValueStartPos)) = value;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x00042A58 File Offset: 0x00040C58
		// (set) Token: 0x06000AA5 RID: 2725 RVA: 0x00005D27 File Offset: 0x00003F27
		public unsafe Rect m_DragMinThumbRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.NativeFieldInfoPtr_m_DragMinThumbRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.NativeFieldInfoPtr_m_DragMinThumbRect)) = value;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x00042A80 File Offset: 0x00040C80
		// (set) Token: 0x06000AA7 RID: 2727 RVA: 0x00005D42 File Offset: 0x00003F42
		public unsafe Rect m_DragMaxThumbRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.NativeFieldInfoPtr_m_DragMaxThumbRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.NativeFieldInfoPtr_m_DragMaxThumbRect)) = value;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x00042AA8 File Offset: 0x00040CA8
		// (set) Token: 0x06000AA9 RID: 2729 RVA: 0x00005D5D File Offset: 0x00003F5D
		public unsafe MinMaxSlider.DragState m_DragState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.NativeFieldInfoPtr_m_DragState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.NativeFieldInfoPtr_m_DragState)) = value;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x00042AD0 File Offset: 0x00040CD0
		// (set) Token: 0x06000AAB RID: 2731 RVA: 0x00005D78 File Offset: 0x00003F78
		public unsafe float m_MinLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.NativeFieldInfoPtr_m_MinLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.NativeFieldInfoPtr_m_MinLimit)) = value;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x00042AF8 File Offset: 0x00040CF8
		// (set) Token: 0x06000AAD RID: 2733 RVA: 0x00005D93 File Offset: 0x00003F93
		public unsafe float m_MaxLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.NativeFieldInfoPtr_m_MaxLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.NativeFieldInfoPtr_m_MaxLimit)) = value;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x00042B20 File Offset: 0x00040D20
		// (set) Token: 0x06000AAF RID: 2735 RVA: 0x00005DAE File Offset: 0x00003FAE
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MinMaxSlider.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MinMaxSlider.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x00042B40 File Offset: 0x00040D40
		// (set) Token: 0x06000AB1 RID: 2737 RVA: 0x00005DC0 File Offset: 0x00003FC0
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MinMaxSlider.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MinMaxSlider.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x00042B60 File Offset: 0x00040D60
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x00005DD2 File Offset: 0x00003FD2
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MinMaxSlider.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MinMaxSlider.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x00042B80 File Offset: 0x00040D80
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x00005DE4 File Offset: 0x00003FE4
		public unsafe static string trackerUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MinMaxSlider.NativeFieldInfoPtr_trackerUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MinMaxSlider.NativeFieldInfoPtr_trackerUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x00042BA0 File Offset: 0x00040DA0
		// (set) Token: 0x06000AB7 RID: 2743 RVA: 0x00005DF6 File Offset: 0x00003FF6
		public unsafe static string draggerUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MinMaxSlider.NativeFieldInfoPtr_draggerUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MinMaxSlider.NativeFieldInfoPtr_draggerUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x00042BC0 File Offset: 0x00040DC0
		// (set) Token: 0x06000AB9 RID: 2745 RVA: 0x00005E08 File Offset: 0x00004008
		public unsafe static string minThumbUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MinMaxSlider.NativeFieldInfoPtr_minThumbUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MinMaxSlider.NativeFieldInfoPtr_minThumbUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x00042BE0 File Offset: 0x00040DE0
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x00005E1A File Offset: 0x0000401A
		public unsafe static string maxThumbUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MinMaxSlider.NativeFieldInfoPtr_maxThumbUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MinMaxSlider.NativeFieldInfoPtr_maxThumbUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x00042C00 File Offset: 0x00040E00
		public float range
		{
			get
			{
				return Math.Abs(this.highLimit - this.lowLimit);
			}
		}

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeFieldInfoPtr__dragElement_k__BackingField;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeFieldInfoPtr__dragMinThumb_k__BackingField;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeFieldInfoPtr__dragMaxThumb_k__BackingField;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeFieldInfoPtr__clampedDragger_k__BackingField;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeFieldInfoPtr_m_DragElementStartPos;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeFieldInfoPtr_m_ValueStartPos;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeFieldInfoPtr_m_DragMinThumbRect;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeFieldInfoPtr_m_DragMaxThumbRect;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeFieldInfoPtr_m_DragState;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeFieldInfoPtr_m_MinLimit;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxLimit;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeFieldInfoPtr_trackerUssClassName;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeFieldInfoPtr_draggerUssClassName;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeFieldInfoPtr_minThumbUssClassName;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeFieldInfoPtr_maxThumbUssClassName;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeMethodInfoPtr_get_dragElement_Internal_get_VisualElement_0;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeMethodInfoPtr_set_dragElement_Private_set_Void_VisualElement_0;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeMethodInfoPtr_get_dragMinThumb_Internal_get_VisualElement_0;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeMethodInfoPtr_set_dragMinThumb_Private_set_Void_VisualElement_0;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeMethodInfoPtr_get_dragMaxThumb_Internal_get_VisualElement_0;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeMethodInfoPtr_set_dragMaxThumb_Private_set_Void_VisualElement_0;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeMethodInfoPtr_get_clampedDragger_Internal_get_ClampedDragger_1_Single_0;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr_set_clampedDragger_Private_set_Void_ClampedDragger_1_Single_0;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeMethodInfoPtr_get_minValue_Public_get_Single_0;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeMethodInfoPtr_set_minValue_Public_set_Void_Single_0;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeMethodInfoPtr_get_maxValue_Public_get_Single_0;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeMethodInfoPtr_set_maxValue_Public_set_Void_Single_0;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_get_Vector2_0;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Vector2_0;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_Vector2_0;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeMethodInfoPtr_get_lowLimit_Public_get_Single_0;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr_set_lowLimit_Public_set_Void_Single_0;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr_get_highLimit_Public_get_Single_0;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeMethodInfoPtr_set_highLimit_Public_set_Void_Single_0;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Single_Single_0;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr_ClampValues_Private_Vector2_Vector2_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDragElementPosition_Private_Void_GeometryChangedEvent_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDragElementPosition_Private_Void_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDragThumbsRect_Private_Void_0;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr_SliderLerpUnclamped_Internal_Single_Single_Single_Single_0;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_SliderNormalizeValue_Internal_Single_Single_Single_Single_0;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_ComputeValueFromPosition_Private_Single_Single_0;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_Void_EventBase_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderValueFromDrag_Private_Void_0;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderValueFromClick_Private_Void_0;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr_ComputeValueFromDraggingThumb_Private_Void_Single_Single_0;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEditingCallbacks_Internal_Virtual_Void_0;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterEditingCallbacks_Internal_Virtual_Void_0;

		// Token: 0x04000763 RID: 1891
		public const float kDefaultHighValue = 10f;

		// Token: 0x02000396 RID: 918
		public new class UxmlFactory : UxmlFactory<MinMaxSlider, MinMaxSlider.UxmlTraits>
		{
			// Token: 0x06003885 RID: 14469 RVA: 0x0001786B File Offset: 0x00015A6B
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<MinMaxSlider.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinMaxSlider.UxmlFactory>.NativeClassPtr);
				MinMaxSlider.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider.UxmlFactory>.NativeClassPtr, 100664851);
			}

			// Token: 0x06003886 RID: 14470 RVA: 0x000E6AEC File Offset: 0x000E4CEC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 299589, RefRangeEnd = 299590, XrefRangeStart = 299586, XrefRangeEnd = 299589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinMaxSlider.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003887 RID: 14471 RVA: 0x0001789F File Offset: 0x00015A9F
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002825 RID: 10277
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000397 RID: 919
		public new class UxmlTraits : BaseField<Vector2>.UxmlTraits
		{
			// Token: 0x06003888 RID: 14472 RVA: 0x000E6B28 File Offset: 0x000E4D28
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<MinMaxSlider.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MinMaxSlider>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinMaxSlider.UxmlTraits>.NativeClassPtr);
				MinMaxSlider.UxmlTraits.NativeFieldInfoPtr_m_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxSlider.UxmlTraits>.NativeClassPtr, "m_MinValue");
				MinMaxSlider.UxmlTraits.NativeFieldInfoPtr_m_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxSlider.UxmlTraits>.NativeClassPtr, "m_MaxValue");
				MinMaxSlider.UxmlTraits.NativeFieldInfoPtr_m_LowLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxSlider.UxmlTraits>.NativeClassPtr, "m_LowLimit");
				MinMaxSlider.UxmlTraits.NativeFieldInfoPtr_m_HighLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxSlider.UxmlTraits>.NativeClassPtr, "m_HighLimit");
				MinMaxSlider.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider.UxmlTraits>.NativeClassPtr, 100664852);
				MinMaxSlider.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxSlider.UxmlTraits>.NativeClassPtr, 100664853);
			}

			// Token: 0x06003889 RID: 14473 RVA: 0x000E6BCC File Offset: 0x000E4DCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299590, XrefRangeEnd = 299624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinMaxSlider.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxSlider.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600388A RID: 14474 RVA: 0x000E6C08 File Offset: 0x000E4E08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299624, XrefRangeEnd = 299633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bag);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MinMaxSlider.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600388B RID: 14475 RVA: 0x000178A8 File Offset: 0x00015AA8
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001168 RID: 4456
			// (get) Token: 0x0600388C RID: 14476 RVA: 0x000E6C80 File Offset: 0x000E4E80
			// (set) Token: 0x0600388D RID: 14477 RVA: 0x000178B1 File Offset: 0x00015AB1
			public unsafe UxmlFloatAttributeDescription m_MinValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.UxmlTraits.NativeFieldInfoPtr_m_MinValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.UxmlTraits.NativeFieldInfoPtr_m_MinValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001169 RID: 4457
			// (get) Token: 0x0600388E RID: 14478 RVA: 0x000E6CB0 File Offset: 0x000E4EB0
			// (set) Token: 0x0600388F RID: 14479 RVA: 0x000178D0 File Offset: 0x00015AD0
			public unsafe UxmlFloatAttributeDescription m_MaxValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.UxmlTraits.NativeFieldInfoPtr_m_MaxValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.UxmlTraits.NativeFieldInfoPtr_m_MaxValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700116A RID: 4458
			// (get) Token: 0x06003890 RID: 14480 RVA: 0x000E6CE0 File Offset: 0x000E4EE0
			// (set) Token: 0x06003891 RID: 14481 RVA: 0x000178EF File Offset: 0x00015AEF
			public unsafe UxmlFloatAttributeDescription m_LowLimit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.UxmlTraits.NativeFieldInfoPtr_m_LowLimit);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.UxmlTraits.NativeFieldInfoPtr_m_LowLimit), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700116B RID: 4459
			// (get) Token: 0x06003892 RID: 14482 RVA: 0x000E6D10 File Offset: 0x000E4F10
			// (set) Token: 0x06003893 RID: 14483 RVA: 0x0001790E File Offset: 0x00015B0E
			public unsafe UxmlFloatAttributeDescription m_HighLimit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.UxmlTraits.NativeFieldInfoPtr_m_HighLimit);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxSlider.UxmlTraits.NativeFieldInfoPtr_m_HighLimit), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002826 RID: 10278
			private static readonly IntPtr NativeFieldInfoPtr_m_MinValue;

			// Token: 0x04002827 RID: 10279
			private static readonly IntPtr NativeFieldInfoPtr_m_MaxValue;

			// Token: 0x04002828 RID: 10280
			private static readonly IntPtr NativeFieldInfoPtr_m_LowLimit;

			// Token: 0x04002829 RID: 10281
			private static readonly IntPtr NativeFieldInfoPtr_m_HighLimit;

			// Token: 0x0400282A RID: 10282
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400282B RID: 10283
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;
		}

		// Token: 0x02000398 RID: 920
		public enum DragState
		{
			// Token: 0x0400282D RID: 10285
			NoThumb,
			// Token: 0x0400282E RID: 10286
			MinThumb,
			// Token: 0x0400282F RID: 10287
			MiddleThumb,
			// Token: 0x04002830 RID: 10288
			MaxThumb
		}
	}
}

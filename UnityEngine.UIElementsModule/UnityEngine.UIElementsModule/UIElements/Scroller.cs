using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000084 RID: 132
	public class Scroller : VisualElement
	{
		// Token: 0x06000D10 RID: 3344 RVA: 0x0004B014 File Offset: 0x00049214
		// Note: this type is marked as 'beforefieldinit'.
		static Scroller()
		{
			Il2CppClassPointerStore<Scroller>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Scroller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scroller>.NativeClassPtr);
			Scroller.NativeFieldInfoPtr_valueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, "valueChanged");
			Scroller.NativeFieldInfoPtr__slider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, "<slider>k__BackingField");
			Scroller.NativeFieldInfoPtr__lowButton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, "<lowButton>k__BackingField");
			Scroller.NativeFieldInfoPtr__highButton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, "<highButton>k__BackingField");
			Scroller.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, "ussClassName");
			Scroller.NativeFieldInfoPtr_horizontalVariantUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, "horizontalVariantUssClassName");
			Scroller.NativeFieldInfoPtr_verticalVariantUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, "verticalVariantUssClassName");
			Scroller.NativeFieldInfoPtr_sliderUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, "sliderUssClassName");
			Scroller.NativeFieldInfoPtr_lowButtonUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, "lowButtonUssClassName");
			Scroller.NativeFieldInfoPtr_highButtonUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller>.NativeClassPtr, "highButtonUssClassName");
			Scroller.NativeMethodInfoPtr_add_valueChanged_Public_add_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100665176);
			Scroller.NativeMethodInfoPtr_remove_valueChanged_Public_rem_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100665177);
			Scroller.NativeMethodInfoPtr_get_slider_Public_get_Slider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100665178);
			Scroller.NativeMethodInfoPtr_set_slider_Private_set_Void_Slider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100665179);
			Scroller.NativeMethodInfoPtr_get_lowButton_Public_get_RepeatButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100665180);
			Scroller.NativeMethodInfoPtr_set_lowButton_Private_set_Void_RepeatButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100665181);
			Scroller.NativeMethodInfoPtr_get_highButton_Public_get_RepeatButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100665182);
			Scroller.NativeMethodInfoPtr_set_highButton_Private_set_Void_RepeatButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100665183);
			Scroller.NativeMethodInfoPtr_get_value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100665184);
			Scroller.NativeMethodInfoPtr_set_value_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100665185);
			Scroller.NativeMethodInfoPtr_get_lowValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100665186);
			Scroller.NativeMethodInfoPtr_set_lowValue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100665187);
			Scroller.NativeMethodInfoPtr_get_highValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100665188);
			Scroller.NativeMethodInfoPtr_set_highValue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100665189);
			Scroller.NativeMethodInfoPtr_set_direction_Public_set_Void_SliderDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100665190);
			Scroller.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100665191);
			Scroller.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Action_1_Single_SliderDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100665192);
			Scroller.NativeMethodInfoPtr_Adjust_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100665193);
			Scroller.NativeMethodInfoPtr_OnSliderValueChange_Private_Void_ChangeEvent_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100665194);
			Scroller.NativeMethodInfoPtr_ScrollPageUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100665195);
			Scroller.NativeMethodInfoPtr_ScrollPageDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100665196);
			Scroller.NativeMethodInfoPtr_ScrollPageUp_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100665197);
			Scroller.NativeMethodInfoPtr_ScrollPageDown_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller>.NativeClassPtr, 100665198);
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x0004B2D8 File Offset: 0x000494D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 303508, RefRangeEnd = 303510, XrefRangeStart = 303503, XrefRangeEnd = 303508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_valueChanged(Action<float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_add_valueChanged_Public_add_Void_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x0004B31C File Offset: 0x0004951C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303515, RefRangeEnd = 303516, XrefRangeStart = 303510, XrefRangeEnd = 303515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_valueChanged(Action<float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_remove_valueChanged_Public_rem_Void_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000D13 RID: 3347 RVA: 0x0004B360 File Offset: 0x00049560
		// (set) Token: 0x06000D14 RID: 3348 RVA: 0x0004B3A0 File Offset: 0x000495A0
		public unsafe Slider slider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_get_slider_Public_get_Slider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_set_slider_Private_set_Void_Slider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x0004B3E4 File Offset: 0x000495E4
		// (set) Token: 0x06000D16 RID: 3350 RVA: 0x0004B424 File Offset: 0x00049624
		public unsafe RepeatButton lowButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_get_lowButton_Public_get_RepeatButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RepeatButton>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303516, XrefRangeEnd = 303517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_set_lowButton_Private_set_Void_RepeatButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x0004B468 File Offset: 0x00049668
		// (set) Token: 0x06000D18 RID: 3352 RVA: 0x0004B4A8 File Offset: 0x000496A8
		public unsafe RepeatButton highButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_get_highButton_Public_get_RepeatButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RepeatButton>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 303518, RefRangeEnd = 303519, XrefRangeStart = 303517, XrefRangeEnd = 303518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_set_highButton_Private_set_Void_RepeatButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000D19 RID: 3353 RVA: 0x0004B4EC File Offset: 0x000496EC
		// (set) Token: 0x06000D1A RID: 3354 RVA: 0x0004B528 File Offset: 0x00049728
		public unsafe float value
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 303520, RefRangeEnd = 303523, XrefRangeStart = 303519, XrefRangeEnd = 303520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_get_value_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 303524, RefRangeEnd = 303526, XrefRangeStart = 303523, XrefRangeEnd = 303524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_set_value_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000D1B RID: 3355 RVA: 0x0004B568 File Offset: 0x00049768
		// (set) Token: 0x06000D1C RID: 3356 RVA: 0x0004B5A4 File Offset: 0x000497A4
		public unsafe float lowValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303526, XrefRangeEnd = 303530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_get_lowValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303530, XrefRangeEnd = 303534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_set_lowValue_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x0004B5E4 File Offset: 0x000497E4
		// (set) Token: 0x06000D1E RID: 3358 RVA: 0x0004B620 File Offset: 0x00049820
		public unsafe float highValue
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 303538, RefRangeEnd = 303540, XrefRangeStart = 303534, XrefRangeEnd = 303538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_get_highValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303540, XrefRangeEnd = 303544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_set_highValue_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x0004BA40 File Offset: 0x00049C40
		// (set) Token: 0x06000D1F RID: 3359 RVA: 0x0004B660 File Offset: 0x00049860
		public unsafe SliderDirection direction
		{
			get
			{
				return (base.resolvedStyle.flexDirection == FlexDirection.Row) ? SliderDirection.Horizontal : SliderDirection.Vertical;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 303564, RefRangeEnd = 303566, XrefRangeStart = 303544, XrefRangeEnd = 303564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_set_direction_Public_set_Void_SliderDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x0004B6A0 File Offset: 0x000498A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303566, XrefRangeEnd = 303567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Scroller()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Scroller>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x0004B6DC File Offset: 0x000498DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 303637, RefRangeEnd = 303640, XrefRangeStart = 303567, XrefRangeEnd = 303637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Scroller(float lowValue, float highValue, Action<float> valueChanged, SliderDirection direction = SliderDirection.Vertical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Scroller>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lowValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref highValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueChanged);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Action_1_Single_SliderDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x0004B754 File Offset: 0x00049954
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 303645, RefRangeEnd = 303647, XrefRangeStart = 303640, XrefRangeEnd = 303645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Adjust(float factor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref factor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_Adjust_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x0004B794 File Offset: 0x00049994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303647, XrefRangeEnd = 303650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSliderValueChange(ChangeEvent<float> evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_OnSliderValueChange_Private_Void_ChangeEvent_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x0004B7D8 File Offset: 0x000499D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303650, XrefRangeEnd = 303700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScrollPageUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_ScrollPageUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x0004B80C File Offset: 0x00049A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303700, XrefRangeEnd = 303708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScrollPageDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_ScrollPageDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x0004B840 File Offset: 0x00049A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303708, XrefRangeEnd = 303716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScrollPageUp(float factor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref factor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_ScrollPageUp_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x0004B880 File Offset: 0x00049A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303716, XrefRangeEnd = 303724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScrollPageDown(float factor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref factor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.NativeMethodInfoPtr_ScrollPageDown_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00006DDB File Offset: 0x00004FDB
		public Scroller(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000D29 RID: 3369 RVA: 0x0004B8C0 File Offset: 0x00049AC0
		// (set) Token: 0x06000D2A RID: 3370 RVA: 0x00006DE4 File Offset: 0x00004FE4
		public unsafe Action<float> valueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_valueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr_valueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x0004B8F0 File Offset: 0x00049AF0
		// (set) Token: 0x06000D2C RID: 3372 RVA: 0x00006E03 File Offset: 0x00005003
		public unsafe Slider _slider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr__slider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr__slider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x0004B920 File Offset: 0x00049B20
		// (set) Token: 0x06000D2E RID: 3374 RVA: 0x00006E22 File Offset: 0x00005022
		public unsafe RepeatButton _lowButton_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr__lowButton_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RepeatButton>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr__lowButton_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x0004B950 File Offset: 0x00049B50
		// (set) Token: 0x06000D30 RID: 3376 RVA: 0x00006E41 File Offset: 0x00005041
		public unsafe RepeatButton _highButton_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr__highButton_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RepeatButton>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scroller.NativeFieldInfoPtr__highButton_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x0004B980 File Offset: 0x00049B80
		// (set) Token: 0x06000D32 RID: 3378 RVA: 0x00006E60 File Offset: 0x00005060
		public unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Scroller.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Scroller.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000D33 RID: 3379 RVA: 0x0004B9A0 File Offset: 0x00049BA0
		// (set) Token: 0x06000D34 RID: 3380 RVA: 0x00006E72 File Offset: 0x00005072
		public unsafe static string horizontalVariantUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Scroller.NativeFieldInfoPtr_horizontalVariantUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Scroller.NativeFieldInfoPtr_horizontalVariantUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000D35 RID: 3381 RVA: 0x0004B9C0 File Offset: 0x00049BC0
		// (set) Token: 0x06000D36 RID: 3382 RVA: 0x00006E84 File Offset: 0x00005084
		public unsafe static string verticalVariantUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Scroller.NativeFieldInfoPtr_verticalVariantUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Scroller.NativeFieldInfoPtr_verticalVariantUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x0004B9E0 File Offset: 0x00049BE0
		// (set) Token: 0x06000D38 RID: 3384 RVA: 0x00006E96 File Offset: 0x00005096
		public unsafe static string sliderUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Scroller.NativeFieldInfoPtr_sliderUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Scroller.NativeFieldInfoPtr_sliderUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x0004BA00 File Offset: 0x00049C00
		// (set) Token: 0x06000D3A RID: 3386 RVA: 0x00006EA8 File Offset: 0x000050A8
		public unsafe static string lowButtonUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Scroller.NativeFieldInfoPtr_lowButtonUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Scroller.NativeFieldInfoPtr_lowButtonUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x0004BA20 File Offset: 0x00049C20
		// (set) Token: 0x06000D3C RID: 3388 RVA: 0x00006EBA File Offset: 0x000050BA
		public unsafe static string highButtonUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Scroller.NativeFieldInfoPtr_highButtonUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Scroller.NativeFieldInfoPtr_highButtonUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400090A RID: 2314
		private static readonly IntPtr NativeFieldInfoPtr_valueChanged;

		// Token: 0x0400090B RID: 2315
		private static readonly IntPtr NativeFieldInfoPtr__slider_k__BackingField;

		// Token: 0x0400090C RID: 2316
		private static readonly IntPtr NativeFieldInfoPtr__lowButton_k__BackingField;

		// Token: 0x0400090D RID: 2317
		private static readonly IntPtr NativeFieldInfoPtr__highButton_k__BackingField;

		// Token: 0x0400090E RID: 2318
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x0400090F RID: 2319
		private static readonly IntPtr NativeFieldInfoPtr_horizontalVariantUssClassName;

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeFieldInfoPtr_verticalVariantUssClassName;

		// Token: 0x04000911 RID: 2321
		private static readonly IntPtr NativeFieldInfoPtr_sliderUssClassName;

		// Token: 0x04000912 RID: 2322
		private static readonly IntPtr NativeFieldInfoPtr_lowButtonUssClassName;

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeFieldInfoPtr_highButtonUssClassName;

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeMethodInfoPtr_add_valueChanged_Public_add_Void_Action_1_Single_0;

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeMethodInfoPtr_remove_valueChanged_Public_rem_Void_Action_1_Single_0;

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeMethodInfoPtr_get_slider_Public_get_Slider_0;

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeMethodInfoPtr_set_slider_Private_set_Void_Slider_0;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeMethodInfoPtr_get_lowButton_Public_get_RepeatButton_0;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeMethodInfoPtr_set_lowButton_Private_set_Void_RepeatButton_0;

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeMethodInfoPtr_get_highButton_Public_get_RepeatButton_0;

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeMethodInfoPtr_set_highButton_Private_set_Void_RepeatButton_0;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Single_0;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_set_Void_Single_0;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeMethodInfoPtr_get_lowValue_Public_get_Single_0;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeMethodInfoPtr_set_lowValue_Public_set_Void_Single_0;

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeMethodInfoPtr_get_highValue_Public_get_Single_0;

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeMethodInfoPtr_set_highValue_Public_set_Void_Single_0;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeMethodInfoPtr_set_direction_Public_set_Void_SliderDirection_0;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Action_1_Single_SliderDirection_0;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeMethodInfoPtr_Adjust_Public_Void_Single_0;

		// Token: 0x04000926 RID: 2342
		private static readonly IntPtr NativeMethodInfoPtr_OnSliderValueChange_Private_Void_ChangeEvent_1_Single_0;

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeMethodInfoPtr_ScrollPageUp_Public_Void_0;

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeMethodInfoPtr_ScrollPageDown_Public_Void_0;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeMethodInfoPtr_ScrollPageUp_Public_Void_Single_0;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeMethodInfoPtr_ScrollPageDown_Public_Void_Single_0;

		// Token: 0x0400092B RID: 2347
		public const float kDefaultPageSize = 20f;

		// Token: 0x020003BB RID: 955
		public class ScrollerSlider : Slider
		{
			// Token: 0x0600394C RID: 14668 RVA: 0x000E8EB8 File Offset: 0x000E70B8
			// Note: this type is marked as 'beforefieldinit'.
			static ScrollerSlider()
			{
				Il2CppClassPointerStore<Scroller.ScrollerSlider>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Scroller>.NativeClassPtr, "ScrollerSlider");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scroller.ScrollerSlider>.NativeClassPtr);
				Scroller.ScrollerSlider.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_SliderDirection_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller.ScrollerSlider>.NativeClassPtr, 100665200);
				Scroller.ScrollerSlider.NativeMethodInfoPtr_SliderNormalizeValue_Internal_Virtual_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller.ScrollerSlider>.NativeClassPtr, 100665201);
			}

			// Token: 0x0600394D RID: 14669 RVA: 0x000E8F0C File Offset: 0x000E710C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303434, XrefRangeEnd = 303438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ScrollerSlider(float start, float end, SliderDirection direction, float pageSize)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Scroller.ScrollerSlider>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref start;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pageSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.ScrollerSlider.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_SliderDirection_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600394E RID: 14670 RVA: 0x000E8F80 File Offset: 0x000E7180
			[CallerCount(0)]
			public unsafe override float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scroller.ScrollerSlider.NativeMethodInfoPtr_SliderNormalizeValue_Internal_Virtual_Single_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600394F RID: 14671 RVA: 0x000180CA File Offset: 0x000162CA
			public ScrollerSlider(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400288C RID: 10380
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_SliderDirection_Single_0;

			// Token: 0x0400288D RID: 10381
			private static readonly IntPtr NativeMethodInfoPtr_SliderNormalizeValue_Internal_Virtual_Single_Single_Single_Single_0;
		}

		// Token: 0x020003BC RID: 956
		public new class UxmlFactory : UxmlFactory<Scroller, Scroller.UxmlTraits>
		{
			// Token: 0x06003950 RID: 14672 RVA: 0x000180D3 File Offset: 0x000162D3
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<Scroller.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Scroller>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scroller.UxmlFactory>.NativeClassPtr);
				Scroller.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller.UxmlFactory>.NativeClassPtr, 100665202);
			}

			// Token: 0x06003951 RID: 14673 RVA: 0x000E8FF0 File Offset: 0x000E71F0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 303441, RefRangeEnd = 303442, XrefRangeStart = 303438, XrefRangeEnd = 303441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Scroller.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003952 RID: 14674 RVA: 0x00018107 File Offset: 0x00016307
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400288E RID: 10382
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003BD RID: 957
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x06003953 RID: 14675 RVA: 0x000E902C File Offset: 0x000E722C
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<Scroller.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Scroller>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scroller.UxmlTraits>.NativeClassPtr);
				Scroller.UxmlTraits.NativeFieldInfoPtr_m_LowValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller.UxmlTraits>.NativeClassPtr, "m_LowValue");
				Scroller.UxmlTraits.NativeFieldInfoPtr_m_HighValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller.UxmlTraits>.NativeClassPtr, "m_HighValue");
				Scroller.UxmlTraits.NativeFieldInfoPtr_m_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller.UxmlTraits>.NativeClassPtr, "m_Direction");
				Scroller.UxmlTraits.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroller.UxmlTraits>.NativeClassPtr, "m_Value");
				Scroller.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller.UxmlTraits>.NativeClassPtr, 100665203);
				Scroller.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroller.UxmlTraits>.NativeClassPtr, 100665204);
			}

			// Token: 0x06003954 RID: 14676 RVA: 0x000E90D0 File Offset: 0x000E72D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303442, XrefRangeEnd = 303454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scroller.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003955 RID: 14677 RVA: 0x000E9148 File Offset: 0x000E7348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303454, XrefRangeEnd = 303503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Scroller.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scroller.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003956 RID: 14678 RVA: 0x00018110 File Offset: 0x00016310
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001198 RID: 4504
			// (get) Token: 0x06003957 RID: 14679 RVA: 0x000E9184 File Offset: 0x000E7384
			// (set) Token: 0x06003958 RID: 14680 RVA: 0x00018119 File Offset: 0x00016319
			public unsafe UxmlFloatAttributeDescription m_LowValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scroller.UxmlTraits.NativeFieldInfoPtr_m_LowValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scroller.UxmlTraits.NativeFieldInfoPtr_m_LowValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001199 RID: 4505
			// (get) Token: 0x06003959 RID: 14681 RVA: 0x000E91B4 File Offset: 0x000E73B4
			// (set) Token: 0x0600395A RID: 14682 RVA: 0x00018138 File Offset: 0x00016338
			public unsafe UxmlFloatAttributeDescription m_HighValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scroller.UxmlTraits.NativeFieldInfoPtr_m_HighValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scroller.UxmlTraits.NativeFieldInfoPtr_m_HighValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700119A RID: 4506
			// (get) Token: 0x0600395B RID: 14683 RVA: 0x000E91E4 File Offset: 0x000E73E4
			// (set) Token: 0x0600395C RID: 14684 RVA: 0x00018157 File Offset: 0x00016357
			public unsafe UxmlEnumAttributeDescription<SliderDirection> m_Direction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scroller.UxmlTraits.NativeFieldInfoPtr_m_Direction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlEnumAttributeDescription<SliderDirection>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scroller.UxmlTraits.NativeFieldInfoPtr_m_Direction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700119B RID: 4507
			// (get) Token: 0x0600395D RID: 14685 RVA: 0x000E9214 File Offset: 0x000E7414
			// (set) Token: 0x0600395E RID: 14686 RVA: 0x00018176 File Offset: 0x00016376
			public unsafe UxmlFloatAttributeDescription m_Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scroller.UxmlTraits.NativeFieldInfoPtr_m_Value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scroller.UxmlTraits.NativeFieldInfoPtr_m_Value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400288F RID: 10383
			private static readonly IntPtr NativeFieldInfoPtr_m_LowValue;

			// Token: 0x04002890 RID: 10384
			private static readonly IntPtr NativeFieldInfoPtr_m_HighValue;

			// Token: 0x04002891 RID: 10385
			private static readonly IntPtr NativeFieldInfoPtr_m_Direction;

			// Token: 0x04002892 RID: 10386
			private static readonly IntPtr NativeFieldInfoPtr_m_Value;

			// Token: 0x04002893 RID: 10387
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x04002894 RID: 10388
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0200058D RID: 1421
			public sealed class <get_uxmlChildElementsDescription>d__5
			{
			}
		}
	}
}

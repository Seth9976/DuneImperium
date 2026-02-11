using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000088 RID: 136
	public class Slider : BaseSlider<float>
	{
		// Token: 0x06000E0A RID: 3594 RVA: 0x0004E230 File Offset: 0x0004C430
		// Note: this type is marked as 'beforefieldinit'.
		static Slider()
		{
			Il2CppClassPointerStore<Slider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Slider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Slider>.NativeClassPtr);
			Slider.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider>.NativeClassPtr, "ussClassName");
			Slider.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider>.NativeClassPtr, "labelUssClassName");
			Slider.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider>.NativeClassPtr, "inputUssClassName");
			Slider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100665286);
			Slider.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_SliderDirection_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100665287);
			Slider.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_SliderDirection_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100665288);
			Slider.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100665289);
			Slider.NativeMethodInfoPtr_SliderLerpUnclamped_Internal_Virtual_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100665290);
			Slider.NativeMethodInfoPtr_SliderNormalizeValue_Internal_Virtual_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100665291);
			Slider.NativeMethodInfoPtr_ParseStringToValue_Internal_Virtual_Single_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100665292);
			Slider.NativeMethodInfoPtr_ComputeValueFromKey_Internal_Virtual_Void_SliderKey_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100665293);
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x0004E33C File Offset: 0x0004C53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305018, XrefRangeEnd = 305019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Slider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Slider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x0004E378 File Offset: 0x0004C578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305019, XrefRangeEnd = 305020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Slider(float start, float end, SliderDirection direction = SliderDirection.Horizontal, float pageSize = 0f)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Slider>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_SliderDirection_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x0004E3EC File Offset: 0x0004C5EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 305040, RefRangeEnd = 305044, XrefRangeStart = 305020, XrefRangeEnd = 305040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Slider(string label, float start = 0f, float end = 10f, SliderDirection direction = SliderDirection.Horizontal, float pageSize = 0f)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Slider>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pageSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_SliderDirection_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x0004E470 File Offset: 0x0004C670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305044, XrefRangeEnd = 305053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delta;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x0004E4D8 File Offset: 0x0004C6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305053, XrefRangeEnd = 305080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float SliderLerpUnclamped(float a, float b, float interpolant)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_SliderLerpUnclamped_Internal_Virtual_Single_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x0004E548 File Offset: 0x0004C748
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_SliderNormalizeValue_Internal_Virtual_Single_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x0004E5B8 File Offset: 0x0004C7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305080, XrefRangeEnd = 305084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float ParseStringToValue(string previousValue, string newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(previousValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_ParseStringToValue_Internal_Virtual_Single_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x0004E624 File Offset: 0x0004C824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305084, XrefRangeEnd = 305108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ComputeValueFromKey(BaseSlider<float>.SliderKey sliderKey, bool isShift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sliderKey;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isShift;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_ComputeValueFromKey_Internal_Virtual_Void_SliderKey_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x000074B4 File Offset: 0x000056B4
		public Slider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x0004E67C File Offset: 0x0004C87C
		// (set) Token: 0x06000E15 RID: 3605 RVA: 0x000074BD File Offset: 0x000056BD
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Slider.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Slider.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000E16 RID: 3606 RVA: 0x0004E69C File Offset: 0x0004C89C
		// (set) Token: 0x06000E17 RID: 3607 RVA: 0x000074CF File Offset: 0x000056CF
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Slider.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Slider.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000E18 RID: 3608 RVA: 0x0004E6BC File Offset: 0x0004C8BC
		// (set) Token: 0x06000E19 RID: 3609 RVA: 0x000074E1 File Offset: 0x000056E1
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Slider.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Slider.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x0004E6DC File Offset: 0x0004C8DC
		public override float SliderRange()
		{
			return Math.Abs(base.highValue - base.lowValue);
		}

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_SliderDirection_Single_0;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_SliderDirection_Single_0;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_Single_0;

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeMethodInfoPtr_SliderLerpUnclamped_Internal_Virtual_Single_Single_Single_Single_0;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeMethodInfoPtr_SliderNormalizeValue_Internal_Virtual_Single_Single_Single_Single_0;

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeMethodInfoPtr_ParseStringToValue_Internal_Virtual_Single_String_String_0;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeMethodInfoPtr_ComputeValueFromKey_Internal_Virtual_Void_SliderKey_Single_Boolean_0;

		// Token: 0x040009D1 RID: 2513
		public const float kDefaultHighValue = 10f;

		// Token: 0x020003C3 RID: 963
		public new class UxmlFactory : UxmlFactory<Slider, Slider.UxmlTraits>
		{
			// Token: 0x06003980 RID: 14720 RVA: 0x0001836E File Offset: 0x0001656E
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<Slider.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Slider>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Slider.UxmlFactory>.NativeClassPtr);
				Slider.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider.UxmlFactory>.NativeClassPtr, 100665295);
			}

			// Token: 0x06003981 RID: 14721 RVA: 0x000E96FC File Offset: 0x000E78FC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 304945, RefRangeEnd = 304946, XrefRangeStart = 304942, XrefRangeEnd = 304945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Slider.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003982 RID: 14722 RVA: 0x000183A2 File Offset: 0x000165A2
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040028B1 RID: 10417
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003C4 RID: 964
		public new class UxmlTraits : BaseSlider<float>.UxmlTraits
		{
			// Token: 0x06003983 RID: 14723 RVA: 0x000E9738 File Offset: 0x000E7938
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<Slider.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Slider>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Slider.UxmlTraits>.NativeClassPtr);
				Slider.UxmlTraits.NativeFieldInfoPtr_m_LowValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider.UxmlTraits>.NativeClassPtr, "m_LowValue");
				Slider.UxmlTraits.NativeFieldInfoPtr_m_HighValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider.UxmlTraits>.NativeClassPtr, "m_HighValue");
				Slider.UxmlTraits.NativeFieldInfoPtr_m_PageSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider.UxmlTraits>.NativeClassPtr, "m_PageSize");
				Slider.UxmlTraits.NativeFieldInfoPtr_m_ShowInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider.UxmlTraits>.NativeClassPtr, "m_ShowInputField");
				Slider.UxmlTraits.NativeFieldInfoPtr_m_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider.UxmlTraits>.NativeClassPtr, "m_Direction");
				Slider.UxmlTraits.NativeFieldInfoPtr_m_Inverted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider.UxmlTraits>.NativeClassPtr, "m_Inverted");
				Slider.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider.UxmlTraits>.NativeClassPtr, 100665296);
				Slider.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider.UxmlTraits>.NativeClassPtr, 100665297);
			}

			// Token: 0x06003984 RID: 14724 RVA: 0x000E9804 File Offset: 0x000E7A04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304946, XrefRangeEnd = 304964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003985 RID: 14725 RVA: 0x000E987C File Offset: 0x000E7A7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304964, XrefRangeEnd = 305018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Slider.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003986 RID: 14726 RVA: 0x000183AB File Offset: 0x000165AB
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011A9 RID: 4521
			// (get) Token: 0x06003987 RID: 14727 RVA: 0x000E98B8 File Offset: 0x000E7AB8
			// (set) Token: 0x06003988 RID: 14728 RVA: 0x000183B4 File Offset: 0x000165B4
			public unsafe UxmlFloatAttributeDescription m_LowValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.UxmlTraits.NativeFieldInfoPtr_m_LowValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.UxmlTraits.NativeFieldInfoPtr_m_LowValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011AA RID: 4522
			// (get) Token: 0x06003989 RID: 14729 RVA: 0x000E98E8 File Offset: 0x000E7AE8
			// (set) Token: 0x0600398A RID: 14730 RVA: 0x000183D3 File Offset: 0x000165D3
			public unsafe UxmlFloatAttributeDescription m_HighValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.UxmlTraits.NativeFieldInfoPtr_m_HighValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.UxmlTraits.NativeFieldInfoPtr_m_HighValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011AB RID: 4523
			// (get) Token: 0x0600398B RID: 14731 RVA: 0x000E9918 File Offset: 0x000E7B18
			// (set) Token: 0x0600398C RID: 14732 RVA: 0x000183F2 File Offset: 0x000165F2
			public unsafe UxmlFloatAttributeDescription m_PageSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.UxmlTraits.NativeFieldInfoPtr_m_PageSize);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.UxmlTraits.NativeFieldInfoPtr_m_PageSize), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011AC RID: 4524
			// (get) Token: 0x0600398D RID: 14733 RVA: 0x000E9948 File Offset: 0x000E7B48
			// (set) Token: 0x0600398E RID: 14734 RVA: 0x00018411 File Offset: 0x00016611
			public unsafe UxmlBoolAttributeDescription m_ShowInputField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.UxmlTraits.NativeFieldInfoPtr_m_ShowInputField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.UxmlTraits.NativeFieldInfoPtr_m_ShowInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011AD RID: 4525
			// (get) Token: 0x0600398F RID: 14735 RVA: 0x000E9978 File Offset: 0x000E7B78
			// (set) Token: 0x06003990 RID: 14736 RVA: 0x00018430 File Offset: 0x00016630
			public unsafe UxmlEnumAttributeDescription<SliderDirection> m_Direction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.UxmlTraits.NativeFieldInfoPtr_m_Direction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlEnumAttributeDescription<SliderDirection>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.UxmlTraits.NativeFieldInfoPtr_m_Direction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011AE RID: 4526
			// (get) Token: 0x06003991 RID: 14737 RVA: 0x000E99A8 File Offset: 0x000E7BA8
			// (set) Token: 0x06003992 RID: 14738 RVA: 0x0001844F File Offset: 0x0001664F
			public unsafe UxmlBoolAttributeDescription m_Inverted
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.UxmlTraits.NativeFieldInfoPtr_m_Inverted);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.UxmlTraits.NativeFieldInfoPtr_m_Inverted), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040028B2 RID: 10418
			private static readonly IntPtr NativeFieldInfoPtr_m_LowValue;

			// Token: 0x040028B3 RID: 10419
			private static readonly IntPtr NativeFieldInfoPtr_m_HighValue;

			// Token: 0x040028B4 RID: 10420
			private static readonly IntPtr NativeFieldInfoPtr_m_PageSize;

			// Token: 0x040028B5 RID: 10421
			private static readonly IntPtr NativeFieldInfoPtr_m_ShowInputField;

			// Token: 0x040028B6 RID: 10422
			private static readonly IntPtr NativeFieldInfoPtr_m_Direction;

			// Token: 0x040028B7 RID: 10423
			private static readonly IntPtr NativeFieldInfoPtr_m_Inverted;

			// Token: 0x040028B8 RID: 10424
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x040028B9 RID: 10425
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

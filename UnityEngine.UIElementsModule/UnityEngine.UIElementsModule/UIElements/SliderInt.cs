using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000089 RID: 137
	public class SliderInt : BaseSlider<int>
	{
		// Token: 0x06000E1B RID: 3611 RVA: 0x0004E700 File Offset: 0x0004C900
		// Note: this type is marked as 'beforefieldinit'.
		static SliderInt()
		{
			Il2CppClassPointerStore<SliderInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "SliderInt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SliderInt>.NativeClassPtr);
			SliderInt.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderInt>.NativeClassPtr, "ussClassName");
			SliderInt.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderInt>.NativeClassPtr, "labelUssClassName");
			SliderInt.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderInt>.NativeClassPtr, "inputUssClassName");
			SliderInt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderInt>.NativeClassPtr, 100665298);
			SliderInt.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_SliderDirection_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderInt>.NativeClassPtr, 100665299);
			SliderInt.NativeMethodInfoPtr_get_pageSize_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderInt>.NativeClassPtr, 100665300);
			SliderInt.NativeMethodInfoPtr_set_pageSize_Public_Virtual_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderInt>.NativeClassPtr, 100665301);
			SliderInt.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderInt>.NativeClassPtr, 100665302);
			SliderInt.NativeMethodInfoPtr_SliderLerpUnclamped_Internal_Virtual_Int32_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderInt>.NativeClassPtr, 100665303);
			SliderInt.NativeMethodInfoPtr_SliderNormalizeValue_Internal_Virtual_Single_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderInt>.NativeClassPtr, 100665304);
			SliderInt.NativeMethodInfoPtr_ParseStringToValue_Internal_Virtual_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderInt>.NativeClassPtr, 100665305);
			SliderInt.NativeMethodInfoPtr_ComputeValueAndDirectionFromClick_Internal_Virtual_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderInt>.NativeClassPtr, 100665306);
			SliderInt.NativeMethodInfoPtr_ComputeValueFromKey_Internal_Virtual_Void_SliderKey_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderInt>.NativeClassPtr, 100665307);
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x0004E834 File Offset: 0x0004CA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305184, XrefRangeEnd = 305204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SliderInt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SliderInt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderInt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x0004E870 File Offset: 0x0004CA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305204, XrefRangeEnd = 305224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SliderInt(string label, int start = 0, int end = 10, SliderDirection direction = SliderDirection.Horizontal, float pageSize = 0f)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SliderInt>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderInt.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_SliderDirection_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x0004E8F4 File Offset: 0x0004CAF4
		// (set) Token: 0x06000E1F RID: 3615 RVA: 0x0004E93C File Offset: 0x0004CB3C
		public unsafe override float pageSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305224, XrefRangeEnd = 305227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SliderInt.NativeMethodInfoPtr_get_pageSize_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305227, XrefRangeEnd = 305234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SliderInt.NativeMethodInfoPtr_set_pageSize_Public_Virtual_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x0004E988 File Offset: 0x0004CB88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305234, XrefRangeEnd = 305247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SliderInt.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x0004E9F0 File Offset: 0x0004CBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305247, XrefRangeEnd = 305251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int SliderLerpUnclamped(int a, int b, float interpolant)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SliderInt.NativeMethodInfoPtr_SliderLerpUnclamped_Internal_Virtual_Int32_Int32_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x0004EA60 File Offset: 0x0004CC60
		[CallerCount(0)]
		public unsafe override float SliderNormalizeValue(int currentValue, int lowerValue, int higherValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SliderInt.NativeMethodInfoPtr_SliderNormalizeValue_Internal_Virtual_Single_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x0004EAD0 File Offset: 0x0004CCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305251, XrefRangeEnd = 305255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ParseStringToValue(string previousValue, string newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SliderInt.NativeMethodInfoPtr_ParseStringToValue_Internal_Virtual_Int32_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x0004EB3C File Offset: 0x0004CD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305255, XrefRangeEnd = 305286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sliderLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dragElementLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dragElementPos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dragElementLastPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SliderInt.NativeMethodInfoPtr_ComputeValueAndDirectionFromClick_Internal_Virtual_Void_Single_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x0004EBB0 File Offset: 0x0004CDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305286, XrefRangeEnd = 305311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ComputeValueFromKey(BaseSlider<int>.SliderKey sliderKey, bool isShift)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SliderInt.NativeMethodInfoPtr_ComputeValueFromKey_Internal_Virtual_Void_SliderKey_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x000074F3 File Offset: 0x000056F3
		public SliderInt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x0004EC08 File Offset: 0x0004CE08
		// (set) Token: 0x06000E28 RID: 3624 RVA: 0x000074FC File Offset: 0x000056FC
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SliderInt.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SliderInt.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x0004EC28 File Offset: 0x0004CE28
		// (set) Token: 0x06000E2A RID: 3626 RVA: 0x0000750E File Offset: 0x0000570E
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SliderInt.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SliderInt.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x0004EC48 File Offset: 0x0004CE48
		// (set) Token: 0x06000E2C RID: 3628 RVA: 0x00007520 File Offset: 0x00005720
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SliderInt.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SliderInt.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x0004EC68 File Offset: 0x0004CE68
		public override int SliderRange()
		{
			return Math.Abs(base.highValue - base.lowValue);
		}

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_SliderDirection_Single_0;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeMethodInfoPtr_get_pageSize_Public_Virtual_get_Single_0;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeMethodInfoPtr_set_pageSize_Public_Virtual_set_Void_Single_0;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_Int32_0;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeMethodInfoPtr_SliderLerpUnclamped_Internal_Virtual_Int32_Int32_Int32_Single_0;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeMethodInfoPtr_SliderNormalizeValue_Internal_Virtual_Single_Int32_Int32_Int32_0;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeMethodInfoPtr_ParseStringToValue_Internal_Virtual_Int32_String_String_0;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeMethodInfoPtr_ComputeValueAndDirectionFromClick_Internal_Virtual_Void_Single_Single_Single_Single_0;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr_ComputeValueFromKey_Internal_Virtual_Void_SliderKey_Int32_Boolean_0;

		// Token: 0x040009DF RID: 2527
		public const int kDefaultHighValue = 10;

		// Token: 0x020003C5 RID: 965
		public new class UxmlFactory : UxmlFactory<SliderInt, SliderInt.UxmlTraits>
		{
			// Token: 0x06003993 RID: 14739 RVA: 0x0001846E File Offset: 0x0001666E
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<SliderInt.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SliderInt>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SliderInt.UxmlFactory>.NativeClassPtr);
				SliderInt.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderInt.UxmlFactory>.NativeClassPtr, 100665309);
			}

			// Token: 0x06003994 RID: 14740 RVA: 0x000E99D8 File Offset: 0x000E7BD8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 305111, RefRangeEnd = 305112, XrefRangeStart = 305108, XrefRangeEnd = 305111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SliderInt.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderInt.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003995 RID: 14741 RVA: 0x000184A2 File Offset: 0x000166A2
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040028BA RID: 10426
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003C6 RID: 966
		public new class UxmlTraits : BaseSlider<int>.UxmlTraits
		{
			// Token: 0x06003996 RID: 14742 RVA: 0x000E9A14 File Offset: 0x000E7C14
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<SliderInt.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SliderInt>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SliderInt.UxmlTraits>.NativeClassPtr);
				SliderInt.UxmlTraits.NativeFieldInfoPtr_m_LowValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderInt.UxmlTraits>.NativeClassPtr, "m_LowValue");
				SliderInt.UxmlTraits.NativeFieldInfoPtr_m_HighValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderInt.UxmlTraits>.NativeClassPtr, "m_HighValue");
				SliderInt.UxmlTraits.NativeFieldInfoPtr_m_PageSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderInt.UxmlTraits>.NativeClassPtr, "m_PageSize");
				SliderInt.UxmlTraits.NativeFieldInfoPtr_m_ShowInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderInt.UxmlTraits>.NativeClassPtr, "m_ShowInputField");
				SliderInt.UxmlTraits.NativeFieldInfoPtr_m_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderInt.UxmlTraits>.NativeClassPtr, "m_Direction");
				SliderInt.UxmlTraits.NativeFieldInfoPtr_m_Inverted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderInt.UxmlTraits>.NativeClassPtr, "m_Inverted");
				SliderInt.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderInt.UxmlTraits>.NativeClassPtr, 100665310);
				SliderInt.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderInt.UxmlTraits>.NativeClassPtr, 100665311);
			}

			// Token: 0x06003997 RID: 14743 RVA: 0x000E9AE0 File Offset: 0x000E7CE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305112, XrefRangeEnd = 305130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SliderInt.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003998 RID: 14744 RVA: 0x000E9B58 File Offset: 0x000E7D58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305130, XrefRangeEnd = 305184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SliderInt.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderInt.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003999 RID: 14745 RVA: 0x000184AB File Offset: 0x000166AB
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011AF RID: 4527
			// (get) Token: 0x0600399A RID: 14746 RVA: 0x000E9B94 File Offset: 0x000E7D94
			// (set) Token: 0x0600399B RID: 14747 RVA: 0x000184B4 File Offset: 0x000166B4
			public unsafe UxmlIntAttributeDescription m_LowValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderInt.UxmlTraits.NativeFieldInfoPtr_m_LowValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderInt.UxmlTraits.NativeFieldInfoPtr_m_LowValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011B0 RID: 4528
			// (get) Token: 0x0600399C RID: 14748 RVA: 0x000E9BC4 File Offset: 0x000E7DC4
			// (set) Token: 0x0600399D RID: 14749 RVA: 0x000184D3 File Offset: 0x000166D3
			public unsafe UxmlIntAttributeDescription m_HighValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderInt.UxmlTraits.NativeFieldInfoPtr_m_HighValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderInt.UxmlTraits.NativeFieldInfoPtr_m_HighValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011B1 RID: 4529
			// (get) Token: 0x0600399E RID: 14750 RVA: 0x000E9BF4 File Offset: 0x000E7DF4
			// (set) Token: 0x0600399F RID: 14751 RVA: 0x000184F2 File Offset: 0x000166F2
			public unsafe UxmlIntAttributeDescription m_PageSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderInt.UxmlTraits.NativeFieldInfoPtr_m_PageSize);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderInt.UxmlTraits.NativeFieldInfoPtr_m_PageSize), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011B2 RID: 4530
			// (get) Token: 0x060039A0 RID: 14752 RVA: 0x000E9C24 File Offset: 0x000E7E24
			// (set) Token: 0x060039A1 RID: 14753 RVA: 0x00018511 File Offset: 0x00016711
			public unsafe UxmlBoolAttributeDescription m_ShowInputField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderInt.UxmlTraits.NativeFieldInfoPtr_m_ShowInputField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderInt.UxmlTraits.NativeFieldInfoPtr_m_ShowInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011B3 RID: 4531
			// (get) Token: 0x060039A2 RID: 14754 RVA: 0x000E9C54 File Offset: 0x000E7E54
			// (set) Token: 0x060039A3 RID: 14755 RVA: 0x00018530 File Offset: 0x00016730
			public unsafe UxmlEnumAttributeDescription<SliderDirection> m_Direction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderInt.UxmlTraits.NativeFieldInfoPtr_m_Direction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlEnumAttributeDescription<SliderDirection>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderInt.UxmlTraits.NativeFieldInfoPtr_m_Direction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011B4 RID: 4532
			// (get) Token: 0x060039A4 RID: 14756 RVA: 0x000E9C84 File Offset: 0x000E7E84
			// (set) Token: 0x060039A5 RID: 14757 RVA: 0x0001854F File Offset: 0x0001674F
			public unsafe UxmlBoolAttributeDescription m_Inverted
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderInt.UxmlTraits.NativeFieldInfoPtr_m_Inverted);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderInt.UxmlTraits.NativeFieldInfoPtr_m_Inverted), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040028BB RID: 10427
			private static readonly IntPtr NativeFieldInfoPtr_m_LowValue;

			// Token: 0x040028BC RID: 10428
			private static readonly IntPtr NativeFieldInfoPtr_m_HighValue;

			// Token: 0x040028BD RID: 10429
			private static readonly IntPtr NativeFieldInfoPtr_m_PageSize;

			// Token: 0x040028BE RID: 10430
			private static readonly IntPtr NativeFieldInfoPtr_m_ShowInputField;

			// Token: 0x040028BF RID: 10431
			private static readonly IntPtr NativeFieldInfoPtr_m_Direction;

			// Token: 0x040028C0 RID: 10432
			private static readonly IntPtr NativeFieldInfoPtr_m_Inverted;

			// Token: 0x040028C1 RID: 10433
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x040028C2 RID: 10434
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

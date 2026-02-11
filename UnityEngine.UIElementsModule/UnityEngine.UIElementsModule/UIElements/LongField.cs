using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000070 RID: 112
	public class LongField : TextValueField<long>
	{
		// Token: 0x06000A64 RID: 2660 RVA: 0x000417F0 File Offset: 0x0003F9F0
		// Note: this type is marked as 'beforefieldinit'.
		static LongField()
		{
			Il2CppClassPointerStore<LongField>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "LongField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LongField>.NativeClassPtr);
			LongField.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LongField>.NativeClassPtr, "ussClassName");
			LongField.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LongField>.NativeClassPtr, "labelUssClassName");
			LongField.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LongField>.NativeClassPtr, "inputUssClassName");
			LongField.NativeMethodInfoPtr_get_longInput_Private_get_LongInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongField>.NativeClassPtr, 100664798);
			LongField.NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongField>.NativeClassPtr, 100664799);
			LongField.NativeMethodInfoPtr_StringToValue_Protected_Virtual_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongField>.NativeClassPtr, 100664800);
			LongField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongField>.NativeClassPtr, 100664801);
			LongField.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongField>.NativeClassPtr, 100664802);
			LongField.NativeMethodInfoPtr_CanTryParse_Internal_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongField>.NativeClassPtr, 100664803);
			LongField.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongField>.NativeClassPtr, 100664804);
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x000418E8 File Offset: 0x0003FAE8
		public unsafe LongField.LongInput longInput
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299498, XrefRangeEnd = 299501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongField.NativeMethodInfoPtr_get_longInput_Private_get_LongInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LongField.LongInput>(intPtr3) : null;
			}
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00041928 File Offset: 0x0003FB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299501, XrefRangeEnd = 299509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ValueToString(long v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LongField.NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00041978 File Offset: 0x0003FB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299509, XrefRangeEnd = 299518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long StringToValue(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LongField.NativeMethodInfoPtr_StringToValue_Protected_Virtual_Int64_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x000419D0 File Offset: 0x0003FBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299518, XrefRangeEnd = 299550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LongField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LongField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00041A0C File Offset: 0x0003FC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299550, XrefRangeEnd = 299582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LongField(string label, int maxLength = 1000)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LongField>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongField.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00041A68 File Offset: 0x0003FC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299582, XrefRangeEnd = 299583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanTryParse(string textString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(textString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LongField.NativeMethodInfoPtr_CanTryParse_Internal_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00041AC0 File Offset: 0x0003FCC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299583, XrefRangeEnd = 299586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, long startValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LongField.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00005C2D File Offset: 0x00003E2D
		public LongField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x00041B28 File Offset: 0x0003FD28
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x00005C36 File Offset: 0x00003E36
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LongField.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LongField.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x00041B48 File Offset: 0x0003FD48
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x00005C48 File Offset: 0x00003E48
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LongField.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LongField.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x00041B68 File Offset: 0x0003FD68
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x00005C5A File Offset: 0x00003E5A
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LongField.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LongField.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeMethodInfoPtr_get_longInput_Private_get_LongInput_0;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_Int64_0;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeMethodInfoPtr_StringToValue_Protected_Virtual_Int64_String_0;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_CanTryParse_Internal_Virtual_Boolean_String_0;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_Int64_0;

		// Token: 0x02000393 RID: 915
		public new class UxmlFactory : UxmlFactory<LongField, LongField.UxmlTraits>
		{
			// Token: 0x06003876 RID: 14454 RVA: 0x000177E8 File Offset: 0x000159E8
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<LongField.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LongField>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LongField.UxmlFactory>.NativeClassPtr);
				LongField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongField.UxmlFactory>.NativeClassPtr, 100664806);
			}

			// Token: 0x06003877 RID: 14455 RVA: 0x000E6794 File Offset: 0x000E4994
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 299448, RefRangeEnd = 299449, XrefRangeStart = 299445, XrefRangeEnd = 299448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LongField.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003878 RID: 14456 RVA: 0x0001781C File Offset: 0x00015A1C
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400281C RID: 10268
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000394 RID: 916
		public new class UxmlTraits : TextValueFieldTraits<long, UxmlLongAttributeDescription>
		{
			// Token: 0x06003879 RID: 14457 RVA: 0x00017825 File Offset: 0x00015A25
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<LongField.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LongField>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LongField.UxmlTraits>.NativeClassPtr);
				LongField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongField.UxmlTraits>.NativeClassPtr, 100664807);
			}

			// Token: 0x0600387A RID: 14458 RVA: 0x000E67D0 File Offset: 0x000E49D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299449, XrefRangeEnd = 299452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LongField.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600387B RID: 14459 RVA: 0x00017859 File Offset: 0x00015A59
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400281D RID: 10269
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000395 RID: 917
		public class LongInput : TextValueField<long>.TextValueInput
		{
			// Token: 0x0600387C RID: 14460 RVA: 0x000E680C File Offset: 0x000E4A0C
			// Note: this type is marked as 'beforefieldinit'.
			static LongInput()
			{
				Il2CppClassPointerStore<LongField.LongInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LongField>.NativeClassPtr, "LongInput");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LongField.LongInput>.NativeClassPtr);
				LongField.LongInput.NativeMethodInfoPtr_get_parentLongField_Private_get_LongField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongField.LongInput>.NativeClassPtr, 100664808);
				LongField.LongInput.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongField.LongInput>.NativeClassPtr, 100664809);
				LongField.LongInput.NativeMethodInfoPtr_get_allowedCharacters_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongField.LongInput>.NativeClassPtr, 100664810);
				LongField.LongInput.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongField.LongInput>.NativeClassPtr, 100664811);
				LongField.LongInput.NativeMethodInfoPtr_ClampMinMaxLongValue_Private_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongField.LongInput>.NativeClassPtr, 100664812);
				LongField.LongInput.NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongField.LongInput>.NativeClassPtr, 100664813);
				LongField.LongInput.NativeMethodInfoPtr_StringToValue_Protected_Virtual_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongField.LongInput>.NativeClassPtr, 100664814);
			}

			// Token: 0x17001166 RID: 4454
			// (get) Token: 0x0600387D RID: 14461 RVA: 0x000E68C4 File Offset: 0x000E4AC4
			public unsafe LongField parentLongField
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 299455, RefRangeEnd = 299458, XrefRangeStart = 299452, XrefRangeEnd = 299455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongField.LongInput.NativeMethodInfoPtr_get_parentLongField_Private_get_LongField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<LongField>(intPtr3) : null;
				}
			}

			// Token: 0x0600387E RID: 14462 RVA: 0x000E6904 File Offset: 0x000E4B04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299458, XrefRangeEnd = 299467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LongInput()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LongField.LongInput>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongField.LongInput.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001167 RID: 4455
			// (get) Token: 0x0600387F RID: 14463 RVA: 0x000E6940 File Offset: 0x000E4B40
			public unsafe override string allowedCharacters
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299467, XrefRangeEnd = 299471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LongField.LongInput.NativeMethodInfoPtr_get_allowedCharacters_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06003880 RID: 14464 RVA: 0x000E6984 File Offset: 0x000E4B84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299471, XrefRangeEnd = 299491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, long startValue)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LongField.LongInput.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003881 RID: 14465 RVA: 0x000E69EC File Offset: 0x000E4BEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299491, XrefRangeEnd = 299494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe long ClampMinMaxLongValue(long niceDelta, long value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref niceDelta;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongField.LongInput.NativeMethodInfoPtr_ClampMinMaxLongValue_Private_Int64_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003882 RID: 14466 RVA: 0x000E6A44 File Offset: 0x000E4C44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299494, XrefRangeEnd = 299496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ValueToString(long v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LongField.LongInput.NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06003883 RID: 14467 RVA: 0x000E6A94 File Offset: 0x000E4C94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299496, XrefRangeEnd = 299498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override long StringToValue(string str)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LongField.LongInput.NativeMethodInfoPtr_StringToValue_Protected_Virtual_Int64_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003884 RID: 14468 RVA: 0x00017862 File Offset: 0x00015A62
			public LongInput(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400281E RID: 10270
			private static readonly IntPtr NativeMethodInfoPtr_get_parentLongField_Private_get_LongField_0;

			// Token: 0x0400281F RID: 10271
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x04002820 RID: 10272
			private static readonly IntPtr NativeMethodInfoPtr_get_allowedCharacters_Protected_Virtual_get_String_0;

			// Token: 0x04002821 RID: 10273
			private static readonly IntPtr NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_Int64_0;

			// Token: 0x04002822 RID: 10274
			private static readonly IntPtr NativeMethodInfoPtr_ClampMinMaxLongValue_Private_Int64_Int64_Int64_0;

			// Token: 0x04002823 RID: 10275
			private static readonly IntPtr NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_Int64_0;

			// Token: 0x04002824 RID: 10276
			private static readonly IntPtr NativeMethodInfoPtr_StringToValue_Protected_Virtual_Int64_String_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x0200003A RID: 58
	[Serializable]
	public sealed class InputDeviceMatcher : ValueType
	{
		// Token: 0x060004C6 RID: 1222 RVA: 0x00019144 File Offset: 0x00017344
		// Note: this type is marked as 'beforefieldinit'.
		static InputDeviceMatcher()
		{
			Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "InputDeviceMatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr);
			InputDeviceMatcher.NativeFieldInfoPtr_vendorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr, "vendorID");
			InputDeviceMatcher.NativeFieldInfoPtr_productID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr, "productID");
			InputDeviceMatcher.NativeFieldInfoPtr_versionNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr, "versionNumber");
			InputDeviceMatcher.NativeFieldInfoPtr_driverType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr, "driverType");
			InputDeviceMatcher.NativeFieldInfoPtr_transportType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr, "transportType");
			InputDeviceMatcher.NativeFieldInfoPtr_nameLiteral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr, "nameLiteral");
			InputDeviceMatcher.NativeFieldInfoPtr_namePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr, "namePattern");
			InputDeviceMatcher.NativeMethodInfoPtr_get_VendorID_Public_get_OptionalUInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr, 100663935);
			InputDeviceMatcher.NativeMethodInfoPtr_set_VendorID_Public_set_Void_OptionalUInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr, 100663936);
			InputDeviceMatcher.NativeMethodInfoPtr_get_ProductID_Public_get_OptionalUInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr, 100663937);
			InputDeviceMatcher.NativeMethodInfoPtr_set_ProductID_Public_set_Void_OptionalUInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr, 100663938);
			InputDeviceMatcher.NativeMethodInfoPtr_get_VersionNumber_Public_get_OptionalUInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr, 100663939);
			InputDeviceMatcher.NativeMethodInfoPtr_set_VersionNumber_Public_set_Void_OptionalUInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr, 100663940);
			InputDeviceMatcher.NativeMethodInfoPtr_get_DriverType_Public_get_OptionalInputDeviceDriverType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr, 100663941);
			InputDeviceMatcher.NativeMethodInfoPtr_set_DriverType_Public_set_Void_OptionalInputDeviceDriverType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr, 100663942);
			InputDeviceMatcher.NativeMethodInfoPtr_get_TransportType_Public_get_OptionalInputDeviceTransportType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr, 100663943);
			InputDeviceMatcher.NativeMethodInfoPtr_set_TransportType_Public_set_Void_OptionalInputDeviceTransportType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr, 100663944);
			InputDeviceMatcher.NativeMethodInfoPtr_get_NameLiteral_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr, 100663945);
			InputDeviceMatcher.NativeMethodInfoPtr_set_NameLiteral_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr, 100663946);
			InputDeviceMatcher.NativeMethodInfoPtr_get_NamePattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr, 100663947);
			InputDeviceMatcher.NativeMethodInfoPtr_set_NamePattern_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr, 100663948);
			InputDeviceMatcher.NativeMethodInfoPtr_Matches_Internal_Boolean_InputDeviceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr, 100663949);
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x0001932C File Offset: 0x0001752C
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00019370 File Offset: 0x00017570
		public unsafe OptionalUInt16 VendorID
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMatcher.NativeMethodInfoPtr_get_VendorID_Public_get_OptionalUInt16_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMatcher.NativeMethodInfoPtr_set_VendorID_Public_set_Void_OptionalUInt16_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x000193B4 File Offset: 0x000175B4
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x000193F8 File Offset: 0x000175F8
		public unsafe OptionalUInt16 ProductID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMatcher.NativeMethodInfoPtr_get_ProductID_Public_get_OptionalUInt16_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 320170, RefRangeEnd = 320176, XrefRangeStart = 320170, XrefRangeEnd = 320176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMatcher.NativeMethodInfoPtr_set_ProductID_Public_set_Void_OptionalUInt16_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x0001943C File Offset: 0x0001763C
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x00019480 File Offset: 0x00017680
		public unsafe OptionalUInt32 VersionNumber
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMatcher.NativeMethodInfoPtr_get_VersionNumber_Public_get_OptionalUInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMatcher.NativeMethodInfoPtr_set_VersionNumber_Public_set_Void_OptionalUInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x000194C4 File Offset: 0x000176C4
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x00019508 File Offset: 0x00017708
		public unsafe OptionalInputDeviceDriverType DriverType
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMatcher.NativeMethodInfoPtr_get_DriverType_Public_get_OptionalInputDeviceDriverType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMatcher.NativeMethodInfoPtr_set_DriverType_Public_set_Void_OptionalInputDeviceDriverType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x0001954C File Offset: 0x0001774C
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x00019590 File Offset: 0x00017790
		public unsafe OptionalInputDeviceTransportType TransportType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMatcher.NativeMethodInfoPtr_get_TransportType_Public_get_OptionalInputDeviceTransportType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 310312, RefRangeEnd = 310318, XrefRangeStart = 310312, XrefRangeEnd = 310318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMatcher.NativeMethodInfoPtr_set_TransportType_Public_set_Void_OptionalInputDeviceTransportType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x000195D4 File Offset: 0x000177D4
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00019610 File Offset: 0x00017810
		public unsafe string NameLiteral
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMatcher.NativeMethodInfoPtr_get_NameLiteral_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMatcher.NativeMethodInfoPtr_set_NameLiteral_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00019658 File Offset: 0x00017858
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x00019694 File Offset: 0x00017894
		public unsafe string NamePattern
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMatcher.NativeMethodInfoPtr_get_NamePattern_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMatcher.NativeMethodInfoPtr_set_NamePattern_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x000196DC File Offset: 0x000178DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 774915, RefRangeEnd = 774918, XrefRangeStart = 774905, XrefRangeEnd = 774915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Matches(InputDeviceInfo deviceInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(deviceInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceMatcher.NativeMethodInfoPtr_Matches_Internal_Boolean_InputDeviceInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00003DD6 File Offset: 0x00001FD6
		public InputDeviceMatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00003DDF File Offset: 0x00001FDF
		public InputDeviceMatcher()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDeviceMatcher>.NativeClassPtr))
		{
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00019734 File Offset: 0x00017934
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x00003DF1 File Offset: 0x00001FF1
		public unsafe OptionalUInt16 vendorID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceMatcher.NativeFieldInfoPtr_vendorID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceMatcher.NativeFieldInfoPtr_vendorID)) = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x0001975C File Offset: 0x0001795C
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x00003E0C File Offset: 0x0000200C
		public unsafe OptionalUInt16 productID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceMatcher.NativeFieldInfoPtr_productID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceMatcher.NativeFieldInfoPtr_productID)) = value;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00019784 File Offset: 0x00017984
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x00003E27 File Offset: 0x00002027
		public unsafe OptionalUInt32 versionNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceMatcher.NativeFieldInfoPtr_versionNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceMatcher.NativeFieldInfoPtr_versionNumber)) = value;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x000197AC File Offset: 0x000179AC
		// (set) Token: 0x060004DF RID: 1247 RVA: 0x00003E42 File Offset: 0x00002042
		public unsafe OptionalInputDeviceDriverType driverType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceMatcher.NativeFieldInfoPtr_driverType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceMatcher.NativeFieldInfoPtr_driverType)) = value;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x000197D4 File Offset: 0x000179D4
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x00003E5D File Offset: 0x0000205D
		public unsafe OptionalInputDeviceTransportType transportType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceMatcher.NativeFieldInfoPtr_transportType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceMatcher.NativeFieldInfoPtr_transportType)) = value;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x000197FC File Offset: 0x000179FC
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x00003E78 File Offset: 0x00002078
		public unsafe string nameLiteral
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceMatcher.NativeFieldInfoPtr_nameLiteral);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceMatcher.NativeFieldInfoPtr_nameLiteral), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x00019824 File Offset: 0x00017A24
		// (set) Token: 0x060004E5 RID: 1253 RVA: 0x00003E97 File Offset: 0x00002097
		public unsafe string namePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceMatcher.NativeFieldInfoPtr_namePattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceMatcher.NativeFieldInfoPtr_namePattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeFieldInfoPtr_vendorID;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeFieldInfoPtr_productID;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeFieldInfoPtr_versionNumber;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeFieldInfoPtr_driverType;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeFieldInfoPtr_transportType;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeFieldInfoPtr_nameLiteral;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeFieldInfoPtr_namePattern;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr_get_VendorID_Public_get_OptionalUInt16_0;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeMethodInfoPtr_set_VendorID_Public_set_Void_OptionalUInt16_0;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeMethodInfoPtr_get_ProductID_Public_get_OptionalUInt16_0;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeMethodInfoPtr_set_ProductID_Public_set_Void_OptionalUInt16_0;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeMethodInfoPtr_get_VersionNumber_Public_get_OptionalUInt32_0;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeMethodInfoPtr_set_VersionNumber_Public_set_Void_OptionalUInt32_0;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeMethodInfoPtr_get_DriverType_Public_get_OptionalInputDeviceDriverType_0;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeMethodInfoPtr_set_DriverType_Public_set_Void_OptionalInputDeviceDriverType_0;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeMethodInfoPtr_get_TransportType_Public_get_OptionalInputDeviceTransportType_0;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeMethodInfoPtr_set_TransportType_Public_set_Void_OptionalInputDeviceTransportType_0;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeMethodInfoPtr_get_NameLiteral_Public_get_String_0;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeMethodInfoPtr_set_NameLiteral_Public_set_Void_String_0;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeMethodInfoPtr_get_NamePattern_Public_get_String_0;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeMethodInfoPtr_set_NamePattern_Public_set_Void_String_0;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Internal_Boolean_InputDeviceInfo_0;
	}
}

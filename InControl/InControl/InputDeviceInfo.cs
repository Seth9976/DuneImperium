using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x02000037 RID: 55
	public sealed class InputDeviceInfo : ValueType
	{
		// Token: 0x060004A0 RID: 1184 RVA: 0x00018AE4 File Offset: 0x00016CE4
		// Note: this type is marked as 'beforefieldinit'.
		static InputDeviceInfo()
		{
			Il2CppClassPointerStore<InputDeviceInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "InputDeviceInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDeviceInfo>.NativeClassPtr);
			InputDeviceInfo.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceInfo>.NativeClassPtr, "name");
			InputDeviceInfo.NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceInfo>.NativeClassPtr, "location");
			InputDeviceInfo.NativeFieldInfoPtr_serialNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceInfo>.NativeClassPtr, "serialNumber");
			InputDeviceInfo.NativeFieldInfoPtr_vendorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceInfo>.NativeClassPtr, "vendorID");
			InputDeviceInfo.NativeFieldInfoPtr_productID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceInfo>.NativeClassPtr, "productID");
			InputDeviceInfo.NativeFieldInfoPtr_versionNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceInfo>.NativeClassPtr, "versionNumber");
			InputDeviceInfo.NativeFieldInfoPtr_driverType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceInfo>.NativeClassPtr, "driverType");
			InputDeviceInfo.NativeFieldInfoPtr_transportType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceInfo>.NativeClassPtr, "transportType");
			InputDeviceInfo.NativeFieldInfoPtr_numButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceInfo>.NativeClassPtr, "numButtons");
			InputDeviceInfo.NativeFieldInfoPtr_numAnalogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceInfo>.NativeClassPtr, "numAnalogs");
			InputDeviceInfo.NativeMethodInfoPtr_HasSameVendorID_Public_Boolean_InputDeviceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceInfo>.NativeClassPtr, 100663926);
			InputDeviceInfo.NativeMethodInfoPtr_HasSameProductID_Public_Boolean_InputDeviceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceInfo>.NativeClassPtr, 100663927);
			InputDeviceInfo.NativeMethodInfoPtr_HasSameVersionNumber_Public_Boolean_InputDeviceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceInfo>.NativeClassPtr, 100663928);
			InputDeviceInfo.NativeMethodInfoPtr_HasSameLocation_Public_Boolean_InputDeviceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceInfo>.NativeClassPtr, 100663929);
			InputDeviceInfo.NativeMethodInfoPtr_HasSameSerialNumber_Public_Boolean_InputDeviceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceInfo>.NativeClassPtr, 100663930);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00018C40 File Offset: 0x00016E40
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 774875, RefRangeEnd = 774879, XrefRangeStart = 774875, XrefRangeEnd = 774875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSameVendorID(InputDeviceInfo deviceInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(deviceInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceInfo.NativeMethodInfoPtr_HasSameVendorID_Public_Boolean_InputDeviceInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00018C98 File Offset: 0x00016E98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 774879, RefRangeEnd = 774883, XrefRangeStart = 774879, XrefRangeEnd = 774879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSameProductID(InputDeviceInfo deviceInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(deviceInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceInfo.NativeMethodInfoPtr_HasSameProductID_Public_Boolean_InputDeviceInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00018CF0 File Offset: 0x00016EF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 774883, RefRangeEnd = 774885, XrefRangeStart = 774883, XrefRangeEnd = 774883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSameVersionNumber(InputDeviceInfo deviceInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(deviceInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceInfo.NativeMethodInfoPtr_HasSameVersionNumber_Public_Boolean_InputDeviceInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00018D48 File Offset: 0x00016F48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 774887, RefRangeEnd = 774890, XrefRangeStart = 774885, XrefRangeEnd = 774887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSameLocation(InputDeviceInfo deviceInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(deviceInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceInfo.NativeMethodInfoPtr_HasSameLocation_Public_Boolean_InputDeviceInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00018DA0 File Offset: 0x00016FA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 774892, RefRangeEnd = 774894, XrefRangeStart = 774890, XrefRangeEnd = 774892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSameSerialNumber(InputDeviceInfo deviceInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(deviceInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceInfo.NativeMethodInfoPtr_HasSameSerialNumber_Public_Boolean_InputDeviceInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00003C37 File Offset: 0x00001E37
		public InputDeviceInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00003C40 File Offset: 0x00001E40
		public InputDeviceInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDeviceInfo>.NativeClassPtr))
		{
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00018DF8 File Offset: 0x00016FF8
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x00003C52 File Offset: 0x00001E52
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceInfo.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceInfo.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x00018E20 File Offset: 0x00017020
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x00003C71 File Offset: 0x00001E71
		public unsafe string location
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceInfo.NativeFieldInfoPtr_location);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceInfo.NativeFieldInfoPtr_location), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x00018E48 File Offset: 0x00017048
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x00003C90 File Offset: 0x00001E90
		public unsafe string serialNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceInfo.NativeFieldInfoPtr_serialNumber);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceInfo.NativeFieldInfoPtr_serialNumber), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00018E70 File Offset: 0x00017070
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00003CAF File Offset: 0x00001EAF
		public unsafe ushort vendorID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceInfo.NativeFieldInfoPtr_vendorID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceInfo.NativeFieldInfoPtr_vendorID)) = value;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00018E98 File Offset: 0x00017098
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00003CCA File Offset: 0x00001ECA
		public unsafe ushort productID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceInfo.NativeFieldInfoPtr_productID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceInfo.NativeFieldInfoPtr_productID)) = value;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00018EC0 File Offset: 0x000170C0
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00003CE5 File Offset: 0x00001EE5
		public unsafe uint versionNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceInfo.NativeFieldInfoPtr_versionNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceInfo.NativeFieldInfoPtr_versionNumber)) = value;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00018EE8 File Offset: 0x000170E8
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00003D00 File Offset: 0x00001F00
		public unsafe InputDeviceDriverType driverType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceInfo.NativeFieldInfoPtr_driverType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceInfo.NativeFieldInfoPtr_driverType)) = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00018F10 File Offset: 0x00017110
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00003D1B File Offset: 0x00001F1B
		public unsafe InputDeviceTransportType transportType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceInfo.NativeFieldInfoPtr_transportType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceInfo.NativeFieldInfoPtr_transportType)) = value;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00018F38 File Offset: 0x00017138
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x00003D36 File Offset: 0x00001F36
		public unsafe uint numButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceInfo.NativeFieldInfoPtr_numButtons);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceInfo.NativeFieldInfoPtr_numButtons)) = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x00018F60 File Offset: 0x00017160
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x00003D51 File Offset: 0x00001F51
		public unsafe uint numAnalogs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceInfo.NativeFieldInfoPtr_numAnalogs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceInfo.NativeFieldInfoPtr_numAnalogs)) = value;
			}
		}

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeFieldInfoPtr_location;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeFieldInfoPtr_serialNumber;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeFieldInfoPtr_vendorID;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeFieldInfoPtr_productID;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeFieldInfoPtr_versionNumber;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeFieldInfoPtr_driverType;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeFieldInfoPtr_transportType;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeFieldInfoPtr_numButtons;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeFieldInfoPtr_numAnalogs;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr_HasSameVendorID_Public_Boolean_InputDeviceInfo_0;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr_HasSameProductID_Public_Boolean_InputDeviceInfo_0;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr_HasSameVersionNumber_Public_Boolean_InputDeviceInfo_0;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_HasSameLocation_Public_Boolean_InputDeviceInfo_0;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr_HasSameSerialNumber_Public_Boolean_InputDeviceInfo_0;
	}
}

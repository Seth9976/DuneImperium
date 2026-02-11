using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200004B RID: 75
	public class CutPasteRequest : Object
	{
		// Token: 0x060005C4 RID: 1476 RVA: 0x00020FD8 File Offset: 0x0001F1D8
		// Note: this type is marked as 'beforefieldinit'.
		static CutPasteRequest()
		{
			Il2CppClassPointerStore<CutPasteRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "CutPasteRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutPasteRequest>.NativeClassPtr);
			CutPasteRequest.NativeFieldInfoPtr__Destination_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutPasteRequest>.NativeClassPtr, "<Destination>k__BackingField");
			CutPasteRequest.NativeFieldInfoPtr__PasteType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutPasteRequest>.NativeClassPtr, "<PasteType>k__BackingField");
			CutPasteRequest.NativeFieldInfoPtr__Source_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutPasteRequest>.NativeClassPtr, "<Source>k__BackingField");
			CutPasteRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutPasteRequest>.NativeClassPtr, "<ETag>k__BackingField");
			CutPasteRequest.NativeMethodInfoPtr_get_Destination_Public_Virtual_New_get_GridCoordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutPasteRequest>.NativeClassPtr, 100664221);
			CutPasteRequest.NativeMethodInfoPtr_set_Destination_Public_Virtual_New_set_Void_GridCoordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutPasteRequest>.NativeClassPtr, 100664222);
			CutPasteRequest.NativeMethodInfoPtr_get_PasteType_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutPasteRequest>.NativeClassPtr, 100664223);
			CutPasteRequest.NativeMethodInfoPtr_set_PasteType_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutPasteRequest>.NativeClassPtr, 100664224);
			CutPasteRequest.NativeMethodInfoPtr_get_Source_Public_Virtual_New_get_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutPasteRequest>.NativeClassPtr, 100664225);
			CutPasteRequest.NativeMethodInfoPtr_set_Source_Public_Virtual_New_set_Void_GridRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutPasteRequest>.NativeClassPtr, 100664226);
			CutPasteRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutPasteRequest>.NativeClassPtr, 100664227);
			CutPasteRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutPasteRequest>.NativeClassPtr, 100664228);
			CutPasteRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutPasteRequest>.NativeClassPtr, 100664229);
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x0002110C File Offset: 0x0001F30C
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x00021158 File Offset: 0x0001F358
		public unsafe virtual GridCoordinate Destination
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutPasteRequest.NativeMethodInfoPtr_get_Destination_Public_Virtual_New_get_GridCoordinate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GridCoordinate>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutPasteRequest.NativeMethodInfoPtr_set_Destination_Public_Virtual_New_set_Void_GridCoordinate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x000211A8 File Offset: 0x0001F3A8
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x000211EC File Offset: 0x0001F3EC
		public unsafe virtual string PasteType
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutPasteRequest.NativeMethodInfoPtr_get_PasteType_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutPasteRequest.NativeMethodInfoPtr_set_PasteType_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x0002123C File Offset: 0x0001F43C
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x00021288 File Offset: 0x0001F488
		public unsafe virtual GridRange Source
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutPasteRequest.NativeMethodInfoPtr_get_Source_Public_Virtual_New_get_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GridRange>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutPasteRequest.NativeMethodInfoPtr_set_Source_Public_Virtual_New_set_Void_GridRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x000212D8 File Offset: 0x0001F4D8
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x0002131C File Offset: 0x0001F51C
		public unsafe virtual string ETag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutPasteRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutPasteRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0002136C File Offset: 0x0001F56C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CutPasteRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutPasteRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutPasteRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00004B05 File Offset: 0x00002D05
		public CutPasteRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x000213A8 File Offset: 0x0001F5A8
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x00004B0E File Offset: 0x00002D0E
		public unsafe GridCoordinate _Destination_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutPasteRequest.NativeFieldInfoPtr__Destination_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridCoordinate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutPasteRequest.NativeFieldInfoPtr__Destination_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x000213D8 File Offset: 0x0001F5D8
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x00004B2D File Offset: 0x00002D2D
		public unsafe string _PasteType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutPasteRequest.NativeFieldInfoPtr__PasteType_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutPasteRequest.NativeFieldInfoPtr__PasteType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00021400 File Offset: 0x0001F600
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x00004B4C File Offset: 0x00002D4C
		public unsafe GridRange _Source_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutPasteRequest.NativeFieldInfoPtr__Source_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutPasteRequest.NativeFieldInfoPtr__Source_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x00021430 File Offset: 0x0001F630
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x00004B6B File Offset: 0x00002D6B
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutPasteRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutPasteRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeFieldInfoPtr__Destination_k__BackingField;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeFieldInfoPtr__PasteType_k__BackingField;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeFieldInfoPtr__Source_k__BackingField;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeMethodInfoPtr_get_Destination_Public_Virtual_New_get_GridCoordinate_0;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeMethodInfoPtr_set_Destination_Public_Virtual_New_set_Void_GridCoordinate_0;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeMethodInfoPtr_get_PasteType_Public_Virtual_New_get_String_0;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeMethodInfoPtr_set_PasteType_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr_get_Source_Public_Virtual_New_get_GridRange_0;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeMethodInfoPtr_set_Source_Public_Virtual_New_set_Void_GridRange_0;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200006C RID: 108
	public class EmbeddedObjectPosition : Object
	{
		// Token: 0x060007CF RID: 1999 RVA: 0x00028A08 File Offset: 0x00026C08
		// Note: this type is marked as 'beforefieldinit'.
		static EmbeddedObjectPosition()
		{
			Il2CppClassPointerStore<EmbeddedObjectPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "EmbeddedObjectPosition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmbeddedObjectPosition>.NativeClassPtr);
			EmbeddedObjectPosition.NativeFieldInfoPtr__NewSheet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmbeddedObjectPosition>.NativeClassPtr, "<NewSheet>k__BackingField");
			EmbeddedObjectPosition.NativeFieldInfoPtr__OverlayPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmbeddedObjectPosition>.NativeClassPtr, "<OverlayPosition>k__BackingField");
			EmbeddedObjectPosition.NativeFieldInfoPtr__SheetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmbeddedObjectPosition>.NativeClassPtr, "<SheetId>k__BackingField");
			EmbeddedObjectPosition.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmbeddedObjectPosition>.NativeClassPtr, "<ETag>k__BackingField");
			EmbeddedObjectPosition.NativeMethodInfoPtr_get_NewSheet_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedObjectPosition>.NativeClassPtr, 100664466);
			EmbeddedObjectPosition.NativeMethodInfoPtr_set_NewSheet_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedObjectPosition>.NativeClassPtr, 100664467);
			EmbeddedObjectPosition.NativeMethodInfoPtr_get_OverlayPosition_Public_Virtual_New_get_OverlayPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedObjectPosition>.NativeClassPtr, 100664468);
			EmbeddedObjectPosition.NativeMethodInfoPtr_set_OverlayPosition_Public_Virtual_New_set_Void_OverlayPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedObjectPosition>.NativeClassPtr, 100664469);
			EmbeddedObjectPosition.NativeMethodInfoPtr_get_SheetId_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedObjectPosition>.NativeClassPtr, 100664470);
			EmbeddedObjectPosition.NativeMethodInfoPtr_set_SheetId_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedObjectPosition>.NativeClassPtr, 100664471);
			EmbeddedObjectPosition.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedObjectPosition>.NativeClassPtr, 100664472);
			EmbeddedObjectPosition.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedObjectPosition>.NativeClassPtr, 100664473);
			EmbeddedObjectPosition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedObjectPosition>.NativeClassPtr, 100664474);
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x00028B3C File Offset: 0x00026D3C
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x00028B80 File Offset: 0x00026D80
		public unsafe virtual Nullable<bool> NewSheet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmbeddedObjectPosition.NativeMethodInfoPtr_get_NewSheet_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmbeddedObjectPosition.NativeMethodInfoPtr_set_NewSheet_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x00028BD4 File Offset: 0x00026DD4
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x00028C20 File Offset: 0x00026E20
		public unsafe virtual OverlayPosition OverlayPosition
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmbeddedObjectPosition.NativeMethodInfoPtr_get_OverlayPosition_Public_Virtual_New_get_OverlayPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OverlayPosition>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmbeddedObjectPosition.NativeMethodInfoPtr_set_OverlayPosition_Public_Virtual_New_set_Void_OverlayPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x00028C70 File Offset: 0x00026E70
		// (set) Token: 0x060007D5 RID: 2005 RVA: 0x00028CB4 File Offset: 0x00026EB4
		public unsafe virtual Nullable<int> SheetId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmbeddedObjectPosition.NativeMethodInfoPtr_get_SheetId_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmbeddedObjectPosition.NativeMethodInfoPtr_set_SheetId_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x00028D08 File Offset: 0x00026F08
		// (set) Token: 0x060007D7 RID: 2007 RVA: 0x00028D4C File Offset: 0x00026F4C
		public unsafe virtual string ETag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmbeddedObjectPosition.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmbeddedObjectPosition.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00028D9C File Offset: 0x00026F9C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmbeddedObjectPosition()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmbeddedObjectPosition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmbeddedObjectPosition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00005AA8 File Offset: 0x00003CA8
		public EmbeddedObjectPosition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x00028DD8 File Offset: 0x00026FD8
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x00005AB1 File Offset: 0x00003CB1
		public Nullable<bool> _NewSheet_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedObjectPosition.NativeFieldInfoPtr__NewSheet_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedObjectPosition.NativeFieldInfoPtr__NewSheet_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x00028E08 File Offset: 0x00027008
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x00005ADF File Offset: 0x00003CDF
		public unsafe OverlayPosition _OverlayPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedObjectPosition.NativeFieldInfoPtr__OverlayPosition_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverlayPosition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedObjectPosition.NativeFieldInfoPtr__OverlayPosition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x00028E38 File Offset: 0x00027038
		// (set) Token: 0x060007DF RID: 2015 RVA: 0x00005AFE File Offset: 0x00003CFE
		public Nullable<int> _SheetId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedObjectPosition.NativeFieldInfoPtr__SheetId_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedObjectPosition.NativeFieldInfoPtr__SheetId_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x00028E68 File Offset: 0x00027068
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x00005B2C File Offset: 0x00003D2C
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedObjectPosition.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedObjectPosition.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeFieldInfoPtr__NewSheet_k__BackingField;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeFieldInfoPtr__OverlayPosition_k__BackingField;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeFieldInfoPtr__SheetId_k__BackingField;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeMethodInfoPtr_get_NewSheet_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeMethodInfoPtr_set_NewSheet_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeMethodInfoPtr_get_OverlayPosition_Public_Virtual_New_get_OverlayPosition_0;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeMethodInfoPtr_set_OverlayPosition_Public_Virtual_New_set_Void_OverlayPosition_0;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeMethodInfoPtr_get_SheetId_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeMethodInfoPtr_set_SheetId_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

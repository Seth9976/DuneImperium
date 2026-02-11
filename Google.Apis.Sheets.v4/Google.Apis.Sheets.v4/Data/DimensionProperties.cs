using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000064 RID: 100
	public class DimensionProperties : Object
	{
		// Token: 0x06000743 RID: 1859 RVA: 0x000268F0 File Offset: 0x00024AF0
		// Note: this type is marked as 'beforefieldinit'.
		static DimensionProperties()
		{
			Il2CppClassPointerStore<DimensionProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "DimensionProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DimensionProperties>.NativeClassPtr);
			DimensionProperties.NativeFieldInfoPtr__DeveloperMetadata_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DimensionProperties>.NativeClassPtr, "<DeveloperMetadata>k__BackingField");
			DimensionProperties.NativeFieldInfoPtr__HiddenByFilter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DimensionProperties>.NativeClassPtr, "<HiddenByFilter>k__BackingField");
			DimensionProperties.NativeFieldInfoPtr__HiddenByUser_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DimensionProperties>.NativeClassPtr, "<HiddenByUser>k__BackingField");
			DimensionProperties.NativeFieldInfoPtr__PixelSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DimensionProperties>.NativeClassPtr, "<PixelSize>k__BackingField");
			DimensionProperties.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DimensionProperties>.NativeClassPtr, "<ETag>k__BackingField");
			DimensionProperties.NativeMethodInfoPtr_get_DeveloperMetadata_Public_Virtual_New_get_IList_1_DeveloperMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DimensionProperties>.NativeClassPtr, 100664400);
			DimensionProperties.NativeMethodInfoPtr_set_DeveloperMetadata_Public_Virtual_New_set_Void_IList_1_DeveloperMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DimensionProperties>.NativeClassPtr, 100664401);
			DimensionProperties.NativeMethodInfoPtr_get_HiddenByFilter_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DimensionProperties>.NativeClassPtr, 100664402);
			DimensionProperties.NativeMethodInfoPtr_set_HiddenByFilter_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DimensionProperties>.NativeClassPtr, 100664403);
			DimensionProperties.NativeMethodInfoPtr_get_HiddenByUser_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DimensionProperties>.NativeClassPtr, 100664404);
			DimensionProperties.NativeMethodInfoPtr_set_HiddenByUser_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DimensionProperties>.NativeClassPtr, 100664405);
			DimensionProperties.NativeMethodInfoPtr_get_PixelSize_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DimensionProperties>.NativeClassPtr, 100664406);
			DimensionProperties.NativeMethodInfoPtr_set_PixelSize_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DimensionProperties>.NativeClassPtr, 100664407);
			DimensionProperties.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DimensionProperties>.NativeClassPtr, 100664408);
			DimensionProperties.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DimensionProperties>.NativeClassPtr, 100664409);
			DimensionProperties.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DimensionProperties>.NativeClassPtr, 100664410);
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x00026A60 File Offset: 0x00024C60
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x00026AAC File Offset: 0x00024CAC
		public unsafe virtual IList<DeveloperMetadata> DeveloperMetadata
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DimensionProperties.NativeMethodInfoPtr_get_DeveloperMetadata_Public_Virtual_New_get_IList_1_DeveloperMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<DeveloperMetadata>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DimensionProperties.NativeMethodInfoPtr_set_DeveloperMetadata_Public_Virtual_New_set_Void_IList_1_DeveloperMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00026AFC File Offset: 0x00024CFC
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x00026B40 File Offset: 0x00024D40
		public unsafe virtual Nullable<bool> HiddenByFilter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DimensionProperties.NativeMethodInfoPtr_get_HiddenByFilter_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DimensionProperties.NativeMethodInfoPtr_set_HiddenByFilter_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00026B94 File Offset: 0x00024D94
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x00026BD8 File Offset: 0x00024DD8
		public unsafe virtual Nullable<bool> HiddenByUser
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DimensionProperties.NativeMethodInfoPtr_get_HiddenByUser_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DimensionProperties.NativeMethodInfoPtr_set_HiddenByUser_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x00026C2C File Offset: 0x00024E2C
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x00026C70 File Offset: 0x00024E70
		public unsafe virtual Nullable<int> PixelSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DimensionProperties.NativeMethodInfoPtr_get_PixelSize_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DimensionProperties.NativeMethodInfoPtr_set_PixelSize_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x00026CC4 File Offset: 0x00024EC4
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x00026D08 File Offset: 0x00024F08
		public unsafe virtual string ETag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DimensionProperties.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DimensionProperties.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00026D58 File Offset: 0x00024F58
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DimensionProperties()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DimensionProperties>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DimensionProperties.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00005629 File Offset: 0x00003829
		public DimensionProperties(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x00026D94 File Offset: 0x00024F94
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x00005632 File Offset: 0x00003832
		public unsafe IList<DeveloperMetadata> _DeveloperMetadata_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DimensionProperties.NativeFieldInfoPtr__DeveloperMetadata_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<DeveloperMetadata>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DimensionProperties.NativeFieldInfoPtr__DeveloperMetadata_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x00026DC4 File Offset: 0x00024FC4
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x00005651 File Offset: 0x00003851
		public Nullable<bool> _HiddenByFilter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DimensionProperties.NativeFieldInfoPtr__HiddenByFilter_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DimensionProperties.NativeFieldInfoPtr__HiddenByFilter_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x00026DF4 File Offset: 0x00024FF4
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x0000567F File Offset: 0x0000387F
		public Nullable<bool> _HiddenByUser_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DimensionProperties.NativeFieldInfoPtr__HiddenByUser_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DimensionProperties.NativeFieldInfoPtr__HiddenByUser_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x00026E24 File Offset: 0x00025024
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x000056AD File Offset: 0x000038AD
		public Nullable<int> _PixelSize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DimensionProperties.NativeFieldInfoPtr__PixelSize_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DimensionProperties.NativeFieldInfoPtr__PixelSize_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x00026E54 File Offset: 0x00025054
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x000056DB File Offset: 0x000038DB
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DimensionProperties.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DimensionProperties.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeFieldInfoPtr__DeveloperMetadata_k__BackingField;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeFieldInfoPtr__HiddenByFilter_k__BackingField;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeFieldInfoPtr__HiddenByUser_k__BackingField;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeFieldInfoPtr__PixelSize_k__BackingField;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeMethodInfoPtr_get_DeveloperMetadata_Public_Virtual_New_get_IList_1_DeveloperMetadata_0;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr_set_DeveloperMetadata_Public_Virtual_New_set_Void_IList_1_DeveloperMetadata_0;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeMethodInfoPtr_get_HiddenByFilter_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeMethodInfoPtr_set_HiddenByFilter_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_get_HiddenByUser_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeMethodInfoPtr_set_HiddenByUser_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeMethodInfoPtr_get_PixelSize_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeMethodInfoPtr_set_PixelSize_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.AddressableAssets.ResourceLocators
{
	// Token: 0x0200001F RID: 31
	public class ContentCatalogDataEntry : Object
	{
		// Token: 0x0600025D RID: 605 RVA: 0x0000F924 File Offset: 0x0000DB24
		// Note: this type is marked as 'beforefieldinit'.
		static ContentCatalogDataEntry()
		{
			Il2CppClassPointerStore<ContentCatalogDataEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets.ResourceLocators", "ContentCatalogDataEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContentCatalogDataEntry>.NativeClassPtr);
			ContentCatalogDataEntry.NativeFieldInfoPtr__InternalId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogDataEntry>.NativeClassPtr, "<InternalId>k__BackingField");
			ContentCatalogDataEntry.NativeFieldInfoPtr__Provider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogDataEntry>.NativeClassPtr, "<Provider>k__BackingField");
			ContentCatalogDataEntry.NativeFieldInfoPtr__Keys_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogDataEntry>.NativeClassPtr, "<Keys>k__BackingField");
			ContentCatalogDataEntry.NativeFieldInfoPtr__Dependencies_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogDataEntry>.NativeClassPtr, "<Dependencies>k__BackingField");
			ContentCatalogDataEntry.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogDataEntry>.NativeClassPtr, "<Data>k__BackingField");
			ContentCatalogDataEntry.NativeFieldInfoPtr__ResourceType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogDataEntry>.NativeClassPtr, "<ResourceType>k__BackingField");
			ContentCatalogDataEntry.NativeMethodInfoPtr_get_InternalId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogDataEntry>.NativeClassPtr, 100663805);
			ContentCatalogDataEntry.NativeMethodInfoPtr_set_InternalId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogDataEntry>.NativeClassPtr, 100663806);
			ContentCatalogDataEntry.NativeMethodInfoPtr_get_Provider_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogDataEntry>.NativeClassPtr, 100663807);
			ContentCatalogDataEntry.NativeMethodInfoPtr_set_Provider_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogDataEntry>.NativeClassPtr, 100663808);
			ContentCatalogDataEntry.NativeMethodInfoPtr_get_Keys_Public_get_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogDataEntry>.NativeClassPtr, 100663809);
			ContentCatalogDataEntry.NativeMethodInfoPtr_set_Keys_Private_set_Void_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogDataEntry>.NativeClassPtr, 100663810);
			ContentCatalogDataEntry.NativeMethodInfoPtr_get_Dependencies_Public_get_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogDataEntry>.NativeClassPtr, 100663811);
			ContentCatalogDataEntry.NativeMethodInfoPtr_set_Dependencies_Private_set_Void_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogDataEntry>.NativeClassPtr, 100663812);
			ContentCatalogDataEntry.NativeMethodInfoPtr_get_Data_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogDataEntry>.NativeClassPtr, 100663813);
			ContentCatalogDataEntry.NativeMethodInfoPtr_set_Data_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogDataEntry>.NativeClassPtr, 100663814);
			ContentCatalogDataEntry.NativeMethodInfoPtr_get_ResourceType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogDataEntry>.NativeClassPtr, 100663815);
			ContentCatalogDataEntry.NativeMethodInfoPtr_set_ResourceType_Private_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogDataEntry>.NativeClassPtr, 100663816);
			ContentCatalogDataEntry.NativeMethodInfoPtr__ctor_Public_Void_Type_String_String_IEnumerable_1_Object_IEnumerable_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogDataEntry>.NativeClassPtr, 100663817);
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0000FAD0 File Offset: 0x0000DCD0
		// (set) Token: 0x0600025F RID: 607 RVA: 0x0000FB08 File Offset: 0x0000DD08
		public unsafe string InternalId
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogDataEntry.NativeMethodInfoPtr_get_InternalId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogDataEntry.NativeMethodInfoPtr_set_InternalId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0000FB4C File Offset: 0x0000DD4C
		// (set) Token: 0x06000261 RID: 609 RVA: 0x0000FB84 File Offset: 0x0000DD84
		public unsafe string Provider
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogDataEntry.NativeMethodInfoPtr_get_Provider_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogDataEntry.NativeMethodInfoPtr_set_Provider_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0000FBC8 File Offset: 0x0000DDC8
		// (set) Token: 0x06000263 RID: 611 RVA: 0x0000FC08 File Offset: 0x0000DE08
		public unsafe List<Object> Keys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogDataEntry.NativeMethodInfoPtr_get_Keys_Public_get_List_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Object>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogDataEntry.NativeMethodInfoPtr_set_Keys_Private_set_Void_List_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0000FC4C File Offset: 0x0000DE4C
		// (set) Token: 0x06000265 RID: 613 RVA: 0x0000FC8C File Offset: 0x0000DE8C
		public unsafe List<Object> Dependencies
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogDataEntry.NativeMethodInfoPtr_get_Dependencies_Public_get_List_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Object>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogDataEntry.NativeMethodInfoPtr_set_Dependencies_Private_set_Void_List_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0000FCD0 File Offset: 0x0000DED0
		// (set) Token: 0x06000267 RID: 615 RVA: 0x0000FD10 File Offset: 0x0000DF10
		public unsafe Object Data
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogDataEntry.NativeMethodInfoPtr_get_Data_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogDataEntry.NativeMethodInfoPtr_set_Data_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0000FD54 File Offset: 0x0000DF54
		// (set) Token: 0x06000269 RID: 617 RVA: 0x0000FD94 File Offset: 0x0000DF94
		public unsafe Type ResourceType
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogDataEntry.NativeMethodInfoPtr_get_ResourceType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogDataEntry.NativeMethodInfoPtr_set_ResourceType_Private_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000FDD8 File Offset: 0x0000DFD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1163902, RefRangeEnd = 1163903, XrefRangeStart = 1163881, XrefRangeEnd = 1163902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContentCatalogDataEntry(Type type, string internalId, string provider, IEnumerable<Object> keys, IEnumerable<Object> dependencies = null, Object extraData = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentCatalogDataEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(provider);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keys);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dependencies);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extraData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogDataEntry.NativeMethodInfoPtr__ctor_Public_Void_Type_String_String_IEnumerable_1_Object_IEnumerable_1_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002B29 File Offset: 0x00000D29
		public ContentCatalogDataEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0000FE80 File Offset: 0x0000E080
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00002B32 File Offset: 0x00000D32
		public unsafe string _InternalId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogDataEntry.NativeFieldInfoPtr__InternalId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogDataEntry.NativeFieldInfoPtr__InternalId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0000FEA8 File Offset: 0x0000E0A8
		// (set) Token: 0x0600026F RID: 623 RVA: 0x00002B51 File Offset: 0x00000D51
		public unsafe string _Provider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogDataEntry.NativeFieldInfoPtr__Provider_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogDataEntry.NativeFieldInfoPtr__Provider_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0000FED0 File Offset: 0x0000E0D0
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00002B70 File Offset: 0x00000D70
		public unsafe List<Object> _Keys_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogDataEntry.NativeFieldInfoPtr__Keys_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogDataEntry.NativeFieldInfoPtr__Keys_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0000FF00 File Offset: 0x0000E100
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00002B8F File Offset: 0x00000D8F
		public unsafe List<Object> _Dependencies_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogDataEntry.NativeFieldInfoPtr__Dependencies_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogDataEntry.NativeFieldInfoPtr__Dependencies_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0000FF30 File Offset: 0x0000E130
		// (set) Token: 0x06000275 RID: 629 RVA: 0x00002BAE File Offset: 0x00000DAE
		public unsafe Object _Data_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogDataEntry.NativeFieldInfoPtr__Data_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogDataEntry.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000276 RID: 630 RVA: 0x0000FF60 File Offset: 0x0000E160
		// (set) Token: 0x06000277 RID: 631 RVA: 0x00002BCD File Offset: 0x00000DCD
		public unsafe Type _ResourceType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogDataEntry.NativeFieldInfoPtr__ResourceType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogDataEntry.NativeFieldInfoPtr__ResourceType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeFieldInfoPtr__InternalId_k__BackingField;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeFieldInfoPtr__Provider_k__BackingField;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeFieldInfoPtr__Keys_k__BackingField;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeFieldInfoPtr__Dependencies_k__BackingField;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeFieldInfoPtr__Data_k__BackingField;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeFieldInfoPtr__ResourceType_k__BackingField;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalId_Public_get_String_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_set_InternalId_Public_set_Void_String_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_get_Provider_Public_get_String_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_set_Provider_Private_set_Void_String_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_get_List_1_Object_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_set_Keys_Private_set_Void_List_1_Object_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_get_Dependencies_Public_get_List_1_Object_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_set_Dependencies_Private_set_Void_List_1_Object_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_Object_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_Object_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_get_ResourceType_Public_get_Type_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_set_ResourceType_Private_set_Void_Type_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_String_String_IEnumerable_1_Object_IEnumerable_1_Object_Object_0;
	}
}

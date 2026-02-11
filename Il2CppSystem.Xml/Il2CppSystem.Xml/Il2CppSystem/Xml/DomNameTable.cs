using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200005D RID: 93
	public class DomNameTable : Object
	{
		// Token: 0x06000B5F RID: 2911 RVA: 0x00046D44 File Offset: 0x00044F44
		// Note: this type is marked as 'beforefieldinit'.
		static DomNameTable()
		{
			Il2CppClassPointerStore<DomNameTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "DomNameTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr);
			DomNameTable.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, "entries");
			DomNameTable.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, "count");
			DomNameTable.NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, "mask");
			DomNameTable.NativeFieldInfoPtr_ownerDocument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, "ownerDocument");
			DomNameTable.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, "nameTable");
			DomNameTable.NativeMethodInfoPtr__ctor_Public_Void_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, 100665157);
			DomNameTable.NativeMethodInfoPtr_GetName_Public_XmlName_String_String_String_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, 100665158);
			DomNameTable.NativeMethodInfoPtr_AddName_Public_XmlName_String_String_String_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, 100665159);
			DomNameTable.NativeMethodInfoPtr_Grow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, 100665160);
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00046E28 File Offset: 0x00045028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373285, XrefRangeEnd = 373292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DomNameTable(XmlDocument document)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(document);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomNameTable.NativeMethodInfoPtr__ctor_Public_Void_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00046E74 File Offset: 0x00045074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373292, XrefRangeEnd = 373298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomNameTable.NativeMethodInfoPtr_GetName_Public_XmlName_String_String_String_IXmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlName>(intPtr3) : null;
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00046EFC File Offset: 0x000450FC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 373307, RefRangeEnd = 373315, XrefRangeStart = 373298, XrefRangeEnd = 373307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomNameTable.NativeMethodInfoPtr_AddName_Public_XmlName_String_String_String_IXmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlName>(intPtr3) : null;
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00046F84 File Offset: 0x00045184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373315, XrefRangeEnd = 373323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Grow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomNameTable.NativeMethodInfoPtr_Grow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00005D95 File Offset: 0x00003F95
		public DomNameTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x00046FB8 File Offset: 0x000451B8
		// (set) Token: 0x06000B66 RID: 2918 RVA: 0x00005D9E File Offset: 0x00003F9E
		public unsafe Il2CppReferenceArray<XmlName> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlName>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x00046FE8 File Offset: 0x000451E8
		// (set) Token: 0x06000B68 RID: 2920 RVA: 0x00005DBD File Offset: 0x00003FBD
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x00047010 File Offset: 0x00045210
		// (set) Token: 0x06000B6A RID: 2922 RVA: 0x00005DD8 File Offset: 0x00003FD8
		public unsafe int mask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_mask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_mask)) = value;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x00047038 File Offset: 0x00045238
		// (set) Token: 0x06000B6C RID: 2924 RVA: 0x00005DF3 File Offset: 0x00003FF3
		public unsafe XmlDocument ownerDocument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_ownerDocument);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_ownerDocument), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x00047068 File Offset: 0x00045268
		// (set) Token: 0x06000B6E RID: 2926 RVA: 0x00005E12 File Offset: 0x00004012
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeFieldInfoPtr_mask;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeFieldInfoPtr_ownerDocument;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlDocument_0;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_XmlName_String_String_String_IXmlSchemaInfo_0;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeMethodInfoPtr_AddName_Public_XmlName_String_String_String_IXmlSchemaInfo_0;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeMethodInfoPtr_Grow_Private_Void_0;
	}
}

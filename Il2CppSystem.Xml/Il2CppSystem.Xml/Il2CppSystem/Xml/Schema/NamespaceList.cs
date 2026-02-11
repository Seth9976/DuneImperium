using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200017B RID: 379
	public class NamespaceList : Object
	{
		// Token: 0x06001DFB RID: 7675 RVA: 0x00094848 File Offset: 0x00092A48
		// Note: this type is marked as 'beforefieldinit'.
		static NamespaceList()
		{
			Il2CppClassPointerStore<NamespaceList>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "NamespaceList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr);
			NamespaceList.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, "type");
			NamespaceList.NativeFieldInfoPtr_set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, "set");
			NamespaceList.NativeFieldInfoPtr_targetNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, "targetNamespace");
			NamespaceList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667812);
			NamespaceList.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667813);
			NamespaceList.NativeMethodInfoPtr_Clone_Public_NamespaceList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667814);
			NamespaceList.NativeMethodInfoPtr_get_Type_Public_get_ListType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667815);
			NamespaceList.NativeMethodInfoPtr_get_Excluded_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667816);
			NamespaceList.NativeMethodInfoPtr_get_Enumerate_Public_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667817);
			NamespaceList.NativeMethodInfoPtr_Allows_Public_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667818);
			NamespaceList.NativeMethodInfoPtr_Allows_Public_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667819);
			NamespaceList.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667820);
			NamespaceList.NativeMethodInfoPtr_IsSubset_Public_Static_Boolean_NamespaceList_NamespaceList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667821);
			NamespaceList.NativeMethodInfoPtr_Union_Public_Static_NamespaceList_NamespaceList_NamespaceList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667822);
			NamespaceList.NativeMethodInfoPtr_CompareSetToOther_Private_NamespaceList_NamespaceList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667823);
			NamespaceList.NativeMethodInfoPtr_Intersection_Public_Static_NamespaceList_NamespaceList_NamespaceList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667824);
			NamespaceList.NativeMethodInfoPtr_RemoveNamespace_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667825);
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x000949CC File Offset: 0x00092BCC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamespaceList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x00094A08 File Offset: 0x00092C08
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 397608, RefRangeEnd = 397614, XrefRangeStart = 397576, XrefRangeEnd = 397608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamespaceList(string namespaces, string targetNamespace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaces);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x00094A68 File Offset: 0x00092C68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 397623, RefRangeEnd = 397626, XrefRangeStart = 397614, XrefRangeEnd = 397623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamespaceList Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr_Clone_Public_NamespaceList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NamespaceList>(intPtr3) : null;
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06001DFF RID: 7679 RVA: 0x00094AA8 File Offset: 0x00092CA8
		public unsafe NamespaceList.ListType Type
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr_get_Type_Public_get_ListType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06001E00 RID: 7680 RVA: 0x00094AE4 File Offset: 0x00092CE4
		public unsafe string Excluded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr_get_Excluded_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06001E01 RID: 7681 RVA: 0x00094B1C File Offset: 0x00092D1C
		public unsafe ICollection Enumerate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 397632, RefRangeEnd = 397633, XrefRangeStart = 397626, XrefRangeEnd = 397632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr_get_Enumerate_Public_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x00094B5C File Offset: 0x00092D5C
		[CallerCount(0)]
		public unsafe virtual bool Allows(string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamespaceList.NativeMethodInfoPtr_Allows_Public_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x00094BB4 File Offset: 0x00092DB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 397634, RefRangeEnd = 397636, XrefRangeStart = 397633, XrefRangeEnd = 397634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Allows(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr_Allows_Public_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x00094C04 File Offset: 0x00092E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397636, XrefRangeEnd = 397647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamespaceList.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x00094C48 File Offset: 0x00092E48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 397652, RefRangeEnd = 397656, XrefRangeStart = 397647, XrefRangeEnd = 397652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSubset(NamespaceList sub, NamespaceList super)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sub);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(super);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr_IsSubset_Public_Static_Boolean_NamespaceList_NamespaceList_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x00094C9C File Offset: 0x00092E9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 397683, RefRangeEnd = 397684, XrefRangeStart = 397656, XrefRangeEnd = 397683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NamespaceList Union(NamespaceList o1, NamespaceList o2, bool v1Compat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v1Compat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr_Union_Public_Static_NamespaceList_NamespaceList_NamespaceList_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NamespaceList>(intPtr3) : null;
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x00094D00 File Offset: 0x00092F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397684, XrefRangeEnd = 397689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamespaceList CompareSetToOther(NamespaceList other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr_CompareSetToOther_Private_NamespaceList_NamespaceList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NamespaceList>(intPtr3) : null;
			}
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x00094D50 File Offset: 0x00092F50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 397699, RefRangeEnd = 397700, XrefRangeStart = 397689, XrefRangeEnd = 397699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NamespaceList Intersection(NamespaceList o1, NamespaceList o2, bool v1Compat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v1Compat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr_Intersection_Public_Static_NamespaceList_NamespaceList_NamespaceList_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NamespaceList>(intPtr3) : null;
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x00094DB4 File Offset: 0x00092FB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 397700, RefRangeEnd = 397702, XrefRangeStart = 397700, XrefRangeEnd = 397700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveNamespace(string tns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr_RemoveNamespace_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x0000C4A5 File Offset: 0x0000A6A5
		public NamespaceList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06001E0B RID: 7691 RVA: 0x00094DF8 File Offset: 0x00092FF8
		// (set) Token: 0x06001E0C RID: 7692 RVA: 0x0000C4AE File Offset: 0x0000A6AE
		public unsafe NamespaceList.ListType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceList.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceList.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06001E0D RID: 7693 RVA: 0x00094E20 File Offset: 0x00093020
		// (set) Token: 0x06001E0E RID: 7694 RVA: 0x0000C4C9 File Offset: 0x0000A6C9
		public unsafe Hashtable set
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceList.NativeFieldInfoPtr_set);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceList.NativeFieldInfoPtr_set), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06001E0F RID: 7695 RVA: 0x00094E50 File Offset: 0x00093050
		// (set) Token: 0x06001E10 RID: 7696 RVA: 0x0000C4E8 File Offset: 0x0000A6E8
		public unsafe string targetNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceList.NativeFieldInfoPtr_targetNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceList.NativeFieldInfoPtr_targetNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040016D9 RID: 5849
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040016DA RID: 5850
		private static readonly IntPtr NativeFieldInfoPtr_set;

		// Token: 0x040016DB RID: 5851
		private static readonly IntPtr NativeFieldInfoPtr_targetNamespace;

		// Token: 0x040016DC RID: 5852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040016DD RID: 5853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x040016DE RID: 5854
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_NamespaceList_0;

		// Token: 0x040016DF RID: 5855
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_ListType_0;

		// Token: 0x040016E0 RID: 5856
		private static readonly IntPtr NativeMethodInfoPtr_get_Excluded_Public_get_String_0;

		// Token: 0x040016E1 RID: 5857
		private static readonly IntPtr NativeMethodInfoPtr_get_Enumerate_Public_get_ICollection_0;

		// Token: 0x040016E2 RID: 5858
		private static readonly IntPtr NativeMethodInfoPtr_Allows_Public_Virtual_New_Boolean_String_0;

		// Token: 0x040016E3 RID: 5859
		private static readonly IntPtr NativeMethodInfoPtr_Allows_Public_Boolean_XmlQualifiedName_0;

		// Token: 0x040016E4 RID: 5860
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040016E5 RID: 5861
		private static readonly IntPtr NativeMethodInfoPtr_IsSubset_Public_Static_Boolean_NamespaceList_NamespaceList_0;

		// Token: 0x040016E6 RID: 5862
		private static readonly IntPtr NativeMethodInfoPtr_Union_Public_Static_NamespaceList_NamespaceList_NamespaceList_Boolean_0;

		// Token: 0x040016E7 RID: 5863
		private static readonly IntPtr NativeMethodInfoPtr_CompareSetToOther_Private_NamespaceList_NamespaceList_0;

		// Token: 0x040016E8 RID: 5864
		private static readonly IntPtr NativeMethodInfoPtr_Intersection_Public_Static_NamespaceList_NamespaceList_NamespaceList_Boolean_0;

		// Token: 0x040016E9 RID: 5865
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNamespace_Private_Void_String_0;

		// Token: 0x0200025B RID: 603
		public enum ListType
		{
			// Token: 0x04002663 RID: 9827
			Any,
			// Token: 0x04002664 RID: 9828
			Other,
			// Token: 0x04002665 RID: 9829
			Set
		}
	}
}

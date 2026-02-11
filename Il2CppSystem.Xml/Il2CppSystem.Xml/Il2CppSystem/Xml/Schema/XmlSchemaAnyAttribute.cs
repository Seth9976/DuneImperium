using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200019B RID: 411
	public class XmlSchemaAnyAttribute : XmlSchemaAnnotated
	{
		// Token: 0x060023DC RID: 9180 RVA: 0x000AA7D8 File Offset: 0x000A89D8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaAnyAttribute()
		{
			Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaAnyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr);
			XmlSchemaAnyAttribute.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr, "ns");
			XmlSchemaAnyAttribute.NativeFieldInfoPtr_processContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr, "processContents");
			XmlSchemaAnyAttribute.NativeFieldInfoPtr_namespaceList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr, "namespaceList");
			XmlSchemaAnyAttribute.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr, 100668504);
			XmlSchemaAnyAttribute.NativeMethodInfoPtr_get_ProcessContents_Public_get_XmlSchemaContentProcessing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr, 100668505);
			XmlSchemaAnyAttribute.NativeMethodInfoPtr_set_ProcessContents_Public_set_Void_XmlSchemaContentProcessing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr, 100668506);
			XmlSchemaAnyAttribute.NativeMethodInfoPtr_get_NamespaceList_Internal_get_NamespaceList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr, 100668507);
			XmlSchemaAnyAttribute.NativeMethodInfoPtr_get_ProcessContentsCorrect_Internal_get_XmlSchemaContentProcessing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr, 100668508);
			XmlSchemaAnyAttribute.NativeMethodInfoPtr_BuildNamespaceList_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr, 100668509);
			XmlSchemaAnyAttribute.NativeMethodInfoPtr_BuildNamespaceListV1Compat_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr, 100668510);
			XmlSchemaAnyAttribute.NativeMethodInfoPtr_Allows_Internal_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr, 100668511);
			XmlSchemaAnyAttribute.NativeMethodInfoPtr_IsSubset_Internal_Static_Boolean_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr, 100668512);
			XmlSchemaAnyAttribute.NativeMethodInfoPtr_Intersection_Internal_Static_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr, 100668513);
			XmlSchemaAnyAttribute.NativeMethodInfoPtr_Union_Internal_Static_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr, 100668514);
			XmlSchemaAnyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr, 100668515);
		}

		// Token: 0x17000C15 RID: 3093
		// (set) Token: 0x060023DD RID: 9181 RVA: 0x000AA934 File Offset: 0x000A8B34
		public unsafe string Namespace
		{
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnyAttribute.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x060023DE RID: 9182 RVA: 0x000AA978 File Offset: 0x000A8B78
		// (set) Token: 0x060023DF RID: 9183 RVA: 0x000AA9B4 File Offset: 0x000A8BB4
		public unsafe XmlSchemaContentProcessing ProcessContents
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnyAttribute.NativeMethodInfoPtr_get_ProcessContents_Public_get_XmlSchemaContentProcessing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 403849, RefRangeEnd = 403852, XrefRangeStart = 403849, XrefRangeEnd = 403852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnyAttribute.NativeMethodInfoPtr_set_ProcessContents_Public_set_Void_XmlSchemaContentProcessing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x060023E0 RID: 9184 RVA: 0x000AA9F4 File Offset: 0x000A8BF4
		public unsafe NamespaceList NamespaceList
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnyAttribute.NativeMethodInfoPtr_get_NamespaceList_Internal_get_NamespaceList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NamespaceList>(intPtr3) : null;
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x060023E1 RID: 9185 RVA: 0x000AAA34 File Offset: 0x000A8C34
		public unsafe XmlSchemaContentProcessing ProcessContentsCorrect
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 410935, RefRangeEnd = 410939, XrefRangeStart = 410935, XrefRangeEnd = 410935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnyAttribute.NativeMethodInfoPtr_get_ProcessContentsCorrect_Internal_get_XmlSchemaContentProcessing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x000AAA70 File Offset: 0x000A8C70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 410947, RefRangeEnd = 410948, XrefRangeStart = 410939, XrefRangeEnd = 410947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildNamespaceList(string targetNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnyAttribute.NativeMethodInfoPtr_BuildNamespaceList_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x000AAAB4 File Offset: 0x000A8CB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 410958, RefRangeEnd = 410959, XrefRangeStart = 410948, XrefRangeEnd = 410958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildNamespaceListV1Compat(string targetNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnyAttribute.NativeMethodInfoPtr_BuildNamespaceListV1Compat_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023E4 RID: 9188 RVA: 0x000AAAF8 File Offset: 0x000A8CF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 410960, RefRangeEnd = 410963, XrefRangeStart = 410959, XrefRangeEnd = 410960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Allows(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnyAttribute.NativeMethodInfoPtr_Allows_Internal_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x000AAB48 File Offset: 0x000A8D48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 410965, RefRangeEnd = 410968, XrefRangeStart = 410963, XrefRangeEnd = 410965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSubset(XmlSchemaAnyAttribute sub, XmlSchemaAnyAttribute super)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sub);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(super);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnyAttribute.NativeMethodInfoPtr_IsSubset_Internal_Static_Boolean_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x000AAB9C File Offset: 0x000A8D9C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 410970, RefRangeEnd = 410976, XrefRangeStart = 410968, XrefRangeEnd = 410970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaAnyAttribute Intersection(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnyAttribute.NativeMethodInfoPtr_Intersection_Internal_Static_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr3) : null;
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x000AAC00 File Offset: 0x000A8E00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 410978, RefRangeEnd = 410982, XrefRangeStart = 410976, XrefRangeEnd = 410978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaAnyAttribute Union(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnyAttribute.NativeMethodInfoPtr_Union_Internal_Static_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr3) : null;
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x000AAC64 File Offset: 0x000A8E64
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaAnyAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x0000F302 File Offset: 0x0000D502
		public XmlSchemaAnyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x060023EA RID: 9194 RVA: 0x000AACA0 File Offset: 0x000A8EA0
		// (set) Token: 0x060023EB RID: 9195 RVA: 0x0000F30B File Offset: 0x0000D50B
		public unsafe string ns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAnyAttribute.NativeFieldInfoPtr_ns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAnyAttribute.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x060023EC RID: 9196 RVA: 0x000AACC8 File Offset: 0x000A8EC8
		// (set) Token: 0x060023ED RID: 9197 RVA: 0x0000F32A File Offset: 0x0000D52A
		public unsafe XmlSchemaContentProcessing processContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAnyAttribute.NativeFieldInfoPtr_processContents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAnyAttribute.NativeFieldInfoPtr_processContents)) = value;
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x060023EE RID: 9198 RVA: 0x000AACF0 File Offset: 0x000A8EF0
		// (set) Token: 0x060023EF RID: 9199 RVA: 0x0000F345 File Offset: 0x0000D545
		public unsafe NamespaceList namespaceList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAnyAttribute.NativeFieldInfoPtr_namespaceList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NamespaceList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAnyAttribute.NativeFieldInfoPtr_namespaceList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B15 RID: 6933
		private static readonly IntPtr NativeFieldInfoPtr_ns;

		// Token: 0x04001B16 RID: 6934
		private static readonly IntPtr NativeFieldInfoPtr_processContents;

		// Token: 0x04001B17 RID: 6935
		private static readonly IntPtr NativeFieldInfoPtr_namespaceList;

		// Token: 0x04001B18 RID: 6936
		private static readonly IntPtr NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0;

		// Token: 0x04001B19 RID: 6937
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessContents_Public_get_XmlSchemaContentProcessing_0;

		// Token: 0x04001B1A RID: 6938
		private static readonly IntPtr NativeMethodInfoPtr_set_ProcessContents_Public_set_Void_XmlSchemaContentProcessing_0;

		// Token: 0x04001B1B RID: 6939
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceList_Internal_get_NamespaceList_0;

		// Token: 0x04001B1C RID: 6940
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessContentsCorrect_Internal_get_XmlSchemaContentProcessing_0;

		// Token: 0x04001B1D RID: 6941
		private static readonly IntPtr NativeMethodInfoPtr_BuildNamespaceList_Internal_Void_String_0;

		// Token: 0x04001B1E RID: 6942
		private static readonly IntPtr NativeMethodInfoPtr_BuildNamespaceListV1Compat_Internal_Void_String_0;

		// Token: 0x04001B1F RID: 6943
		private static readonly IntPtr NativeMethodInfoPtr_Allows_Internal_Boolean_XmlQualifiedName_0;

		// Token: 0x04001B20 RID: 6944
		private static readonly IntPtr NativeMethodInfoPtr_IsSubset_Internal_Static_Boolean_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_0;

		// Token: 0x04001B21 RID: 6945
		private static readonly IntPtr NativeMethodInfoPtr_Intersection_Internal_Static_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_Boolean_0;

		// Token: 0x04001B22 RID: 6946
		private static readonly IntPtr NativeMethodInfoPtr_Union_Internal_Static_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_Boolean_0;

		// Token: 0x04001B23 RID: 6947
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

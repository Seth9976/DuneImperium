using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200019A RID: 410
	public class XmlSchemaAny : XmlSchemaParticle
	{
		// Token: 0x060023C9 RID: 9161 RVA: 0x000AA348 File Offset: 0x000A8548
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaAny()
		{
			Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaAny");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr);
			XmlSchemaAny.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr, "ns");
			XmlSchemaAny.NativeFieldInfoPtr_processContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr, "processContents");
			XmlSchemaAny.NativeFieldInfoPtr_namespaceList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr, "namespaceList");
			XmlSchemaAny.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr, 100668493);
			XmlSchemaAny.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr, 100668494);
			XmlSchemaAny.NativeMethodInfoPtr_set_ProcessContents_Public_set_Void_XmlSchemaContentProcessing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr, 100668495);
			XmlSchemaAny.NativeMethodInfoPtr_get_NamespaceList_Internal_get_NamespaceList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr, 100668496);
			XmlSchemaAny.NativeMethodInfoPtr_get_ResolvedNamespace_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr, 100668497);
			XmlSchemaAny.NativeMethodInfoPtr_get_ProcessContentsCorrect_Internal_get_XmlSchemaContentProcessing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr, 100668498);
			XmlSchemaAny.NativeMethodInfoPtr_get_NameString_Internal_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr, 100668499);
			XmlSchemaAny.NativeMethodInfoPtr_BuildNamespaceList_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr, 100668500);
			XmlSchemaAny.NativeMethodInfoPtr_BuildNamespaceListV1Compat_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr, 100668501);
			XmlSchemaAny.NativeMethodInfoPtr_Allows_Internal_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr, 100668502);
			XmlSchemaAny.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr, 100668503);
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x060023CA RID: 9162 RVA: 0x000AA490 File Offset: 0x000A8690
		// (set) Token: 0x060023CB RID: 9163 RVA: 0x000AA4C8 File Offset: 0x000A86C8
		public unsafe string Namespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAny.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAny.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (set) Token: 0x060023CC RID: 9164 RVA: 0x000AA50C File Offset: 0x000A870C
		public unsafe XmlSchemaContentProcessing ProcessContents
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAny.NativeMethodInfoPtr_set_ProcessContents_Public_set_Void_XmlSchemaContentProcessing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x060023CD RID: 9165 RVA: 0x000AA54C File Offset: 0x000A874C
		public unsafe NamespaceList NamespaceList
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAny.NativeMethodInfoPtr_get_NamespaceList_Internal_get_NamespaceList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NamespaceList>(intPtr3) : null;
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x060023CE RID: 9166 RVA: 0x000AA58C File Offset: 0x000A878C
		public unsafe string ResolvedNamespace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410885, XrefRangeEnd = 410887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAny.NativeMethodInfoPtr_get_ResolvedNamespace_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x060023CF RID: 9167 RVA: 0x000AA5C4 File Offset: 0x000A87C4
		public unsafe XmlSchemaContentProcessing ProcessContentsCorrect
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 410887, RefRangeEnd = 410891, XrefRangeStart = 410887, XrefRangeEnd = 410887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAny.NativeMethodInfoPtr_get_ProcessContentsCorrect_Internal_get_XmlSchemaContentProcessing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x060023D0 RID: 9168 RVA: 0x000AA600 File Offset: 0x000A8800
		public unsafe override string NameString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410891, XrefRangeEnd = 410902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaAny.NativeMethodInfoPtr_get_NameString_Internal_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x000AA644 File Offset: 0x000A8844
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 410910, RefRangeEnd = 410911, XrefRangeStart = 410902, XrefRangeEnd = 410910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildNamespaceList(string targetNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAny.NativeMethodInfoPtr_BuildNamespaceList_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x000AA688 File Offset: 0x000A8888
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 410921, RefRangeEnd = 410922, XrefRangeStart = 410911, XrefRangeEnd = 410921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildNamespaceListV1Compat(string targetNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAny.NativeMethodInfoPtr_BuildNamespaceListV1Compat_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x000AA6CC File Offset: 0x000A88CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 410923, RefRangeEnd = 410926, XrefRangeStart = 410922, XrefRangeEnd = 410923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Allows(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAny.NativeMethodInfoPtr_Allows_Internal_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x000AA71C File Offset: 0x000A891C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 410930, RefRangeEnd = 410935, XrefRangeStart = 410926, XrefRangeEnd = 410930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaAny()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAny.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
		public XmlSchemaAny(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x060023D6 RID: 9174 RVA: 0x000AA758 File Offset: 0x000A8958
		// (set) Token: 0x060023D7 RID: 9175 RVA: 0x0000F2A9 File Offset: 0x0000D4A9
		public unsafe string ns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAny.NativeFieldInfoPtr_ns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAny.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x060023D8 RID: 9176 RVA: 0x000AA780 File Offset: 0x000A8980
		// (set) Token: 0x060023D9 RID: 9177 RVA: 0x0000F2C8 File Offset: 0x0000D4C8
		public unsafe XmlSchemaContentProcessing processContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAny.NativeFieldInfoPtr_processContents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAny.NativeFieldInfoPtr_processContents)) = value;
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x060023DA RID: 9178 RVA: 0x000AA7A8 File Offset: 0x000A89A8
		// (set) Token: 0x060023DB RID: 9179 RVA: 0x0000F2E3 File Offset: 0x0000D4E3
		public unsafe NamespaceList namespaceList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAny.NativeFieldInfoPtr_namespaceList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NamespaceList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAny.NativeFieldInfoPtr_namespaceList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B07 RID: 6919
		private static readonly IntPtr NativeFieldInfoPtr_ns;

		// Token: 0x04001B08 RID: 6920
		private static readonly IntPtr NativeFieldInfoPtr_processContents;

		// Token: 0x04001B09 RID: 6921
		private static readonly IntPtr NativeFieldInfoPtr_namespaceList;

		// Token: 0x04001B0A RID: 6922
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x04001B0B RID: 6923
		private static readonly IntPtr NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0;

		// Token: 0x04001B0C RID: 6924
		private static readonly IntPtr NativeMethodInfoPtr_set_ProcessContents_Public_set_Void_XmlSchemaContentProcessing_0;

		// Token: 0x04001B0D RID: 6925
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceList_Internal_get_NamespaceList_0;

		// Token: 0x04001B0E RID: 6926
		private static readonly IntPtr NativeMethodInfoPtr_get_ResolvedNamespace_Internal_get_String_0;

		// Token: 0x04001B0F RID: 6927
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessContentsCorrect_Internal_get_XmlSchemaContentProcessing_0;

		// Token: 0x04001B10 RID: 6928
		private static readonly IntPtr NativeMethodInfoPtr_get_NameString_Internal_Virtual_get_String_0;

		// Token: 0x04001B11 RID: 6929
		private static readonly IntPtr NativeMethodInfoPtr_BuildNamespaceList_Internal_Void_String_0;

		// Token: 0x04001B12 RID: 6930
		private static readonly IntPtr NativeMethodInfoPtr_BuildNamespaceListV1Compat_Internal_Void_String_0;

		// Token: 0x04001B13 RID: 6931
		private static readonly IntPtr NativeMethodInfoPtr_Allows_Internal_Boolean_XmlQualifiedName_0;

		// Token: 0x04001B14 RID: 6932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

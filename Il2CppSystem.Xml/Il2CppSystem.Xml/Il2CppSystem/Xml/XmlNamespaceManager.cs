using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml
{
	// Token: 0x020000A3 RID: 163
	public class XmlNamespaceManager : Object
	{
		// Token: 0x06001191 RID: 4497 RVA: 0x00063DDC File Offset: 0x00061FDC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNamespaceManager()
		{
			Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlNamespaceManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr);
			XmlNamespaceManager.NativeFieldInfoPtr_nsdecls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "nsdecls");
			XmlNamespaceManager.NativeFieldInfoPtr_lastDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "lastDecl");
			XmlNamespaceManager.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "nameTable");
			XmlNamespaceManager.NativeFieldInfoPtr_scopeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "scopeId");
			XmlNamespaceManager.NativeFieldInfoPtr_hashTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "hashTable");
			XmlNamespaceManager.NativeFieldInfoPtr_useHashtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "useHashtable");
			XmlNamespaceManager.NativeFieldInfoPtr_xml = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "xml");
			XmlNamespaceManager.NativeFieldInfoPtr_xmlNs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "xmlNs");
			XmlNamespaceManager.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100666212);
			XmlNamespaceManager.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100666213);
			XmlNamespaceManager.NativeMethodInfoPtr_get_NameTable_Public_Virtual_New_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100666214);
			XmlNamespaceManager.NativeMethodInfoPtr_get_DefaultNamespace_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100666215);
			XmlNamespaceManager.NativeMethodInfoPtr_PushScope_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100666216);
			XmlNamespaceManager.NativeMethodInfoPtr_PopScope_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100666217);
			XmlNamespaceManager.NativeMethodInfoPtr_AddNamespace_Public_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100666218);
			XmlNamespaceManager.NativeMethodInfoPtr_RemoveNamespace_Public_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100666219);
			XmlNamespaceManager.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100666220);
			XmlNamespaceManager.NativeMethodInfoPtr_GetNamespacesInScope_Public_Virtual_New_IDictionary_2_String_String_XmlNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100666221);
			XmlNamespaceManager.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100666222);
			XmlNamespaceManager.NativeMethodInfoPtr_LookupNamespaceDecl_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100666223);
			XmlNamespaceManager.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100666224);
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x00063FB0 File Offset: 0x000621B0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNamespaceManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamespaceManager.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x00063FEC File Offset: 0x000621EC
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 382465, RefRangeEnd = 382483, XrefRangeStart = 382441, XrefRangeEnd = 382465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNamespaceManager(XmlNameTable nameTable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamespaceManager.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x00064038 File Offset: 0x00062238
		public unsafe virtual XmlNameTable NameTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_get_NameTable_Public_Virtual_New_get_XmlNameTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x00064084 File Offset: 0x00062284
		public unsafe virtual string DefaultNamespace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382483, XrefRangeEnd = 382486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_get_DefaultNamespace_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x000640C8 File Offset: 0x000622C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 336299, RefRangeEnd = 336300, XrefRangeStart = 336299, XrefRangeEnd = 336300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PushScope()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_PushScope_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x00064104 File Offset: 0x00062304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382486, XrefRangeEnd = 382490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool PopScope()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_PopScope_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x0006414C File Offset: 0x0006234C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382490, XrefRangeEnd = 382512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddNamespace(string prefix, string uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_AddNamespace_Public_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x000641AC File Offset: 0x000623AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382512, XrefRangeEnd = 382515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveNamespace(string prefix, string uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_RemoveNamespace_Public_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x0006420C File Offset: 0x0006240C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382515, XrefRangeEnd = 382533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00064258 File Offset: 0x00062458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382533, XrefRangeEnd = 382549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scope;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_GetNamespacesInScope_Public_Virtual_New_IDictionary_2_String_String_XmlNamespaceScope_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x000642B0 File Offset: 0x000624B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382549, XrefRangeEnd = 382550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x00064304 File Offset: 0x00062504
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 382552, RefRangeEnd = 382555, XrefRangeStart = 382550, XrefRangeEnd = 382552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LookupNamespaceDecl(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamespaceManager.NativeMethodInfoPtr_LookupNamespaceDecl_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x00064354 File Offset: 0x00062554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382555, XrefRangeEnd = 382557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string LookupPrefix(string uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x0000780E File Offset: 0x00005A0E
		public XmlNamespaceManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x000643A8 File Offset: 0x000625A8
		// (set) Token: 0x060011A1 RID: 4513 RVA: 0x00007817 File Offset: 0x00005A17
		public unsafe Il2CppReferenceArray<XmlNamespaceManager.NamespaceDeclaration> nsdecls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_nsdecls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlNamespaceManager.NamespaceDeclaration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_nsdecls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x000643D8 File Offset: 0x000625D8
		// (set) Token: 0x060011A3 RID: 4515 RVA: 0x00007836 File Offset: 0x00005A36
		public unsafe int lastDecl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_lastDecl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_lastDecl)) = value;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x00064400 File Offset: 0x00062600
		// (set) Token: 0x060011A5 RID: 4517 RVA: 0x00007851 File Offset: 0x00005A51
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x00064430 File Offset: 0x00062630
		// (set) Token: 0x060011A7 RID: 4519 RVA: 0x00007870 File Offset: 0x00005A70
		public unsafe int scopeId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_scopeId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_scopeId)) = value;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x060011A8 RID: 4520 RVA: 0x00064458 File Offset: 0x00062658
		// (set) Token: 0x060011A9 RID: 4521 RVA: 0x0000788B File Offset: 0x00005A8B
		public unsafe Dictionary<string, int> hashTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_hashTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_hashTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x00064488 File Offset: 0x00062688
		// (set) Token: 0x060011AB RID: 4523 RVA: 0x000078AA File Offset: 0x00005AAA
		public unsafe bool useHashtable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_useHashtable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_useHashtable)) = value;
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x000644B0 File Offset: 0x000626B0
		// (set) Token: 0x060011AD RID: 4525 RVA: 0x000078C5 File Offset: 0x00005AC5
		public unsafe string xml
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_xml);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_xml), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x000644D8 File Offset: 0x000626D8
		// (set) Token: 0x060011AF RID: 4527 RVA: 0x000078E4 File Offset: 0x00005AE4
		public unsafe string xmlNs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_xmlNs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_xmlNs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000E52 RID: 3666
		private static readonly IntPtr NativeFieldInfoPtr_nsdecls;

		// Token: 0x04000E53 RID: 3667
		private static readonly IntPtr NativeFieldInfoPtr_lastDecl;

		// Token: 0x04000E54 RID: 3668
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x04000E55 RID: 3669
		private static readonly IntPtr NativeFieldInfoPtr_scopeId;

		// Token: 0x04000E56 RID: 3670
		private static readonly IntPtr NativeFieldInfoPtr_hashTable;

		// Token: 0x04000E57 RID: 3671
		private static readonly IntPtr NativeFieldInfoPtr_useHashtable;

		// Token: 0x04000E58 RID: 3672
		private static readonly IntPtr NativeFieldInfoPtr_xml;

		// Token: 0x04000E59 RID: 3673
		private static readonly IntPtr NativeFieldInfoPtr_xmlNs;

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000E5B RID: 3675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0;

		// Token: 0x04000E5C RID: 3676
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_Virtual_New_get_XmlNameTable_0;

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultNamespace_Public_Virtual_New_get_String_0;

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeMethodInfoPtr_PushScope_Public_Virtual_New_Void_0;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeMethodInfoPtr_PopScope_Public_Virtual_New_Boolean_0;

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeMethodInfoPtr_AddNamespace_Public_Virtual_New_Void_String_String_0;

		// Token: 0x04000E61 RID: 3681
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNamespace_Public_Virtual_New_Void_String_String_0;

		// Token: 0x04000E62 RID: 3682
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

		// Token: 0x04000E63 RID: 3683
		private static readonly IntPtr NativeMethodInfoPtr_GetNamespacesInScope_Public_Virtual_New_IDictionary_2_String_String_XmlNamespaceScope_0;

		// Token: 0x04000E64 RID: 3684
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_New_String_String_0;

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespaceDecl_Private_Int32_String_0;

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeMethodInfoPtr_LookupPrefix_Public_Virtual_New_String_String_0;

		// Token: 0x02000246 RID: 582
		public sealed class NamespaceDeclaration : ValueType
		{
			// Token: 0x060030A9 RID: 12457 RVA: 0x000DAE30 File Offset: 0x000D9030
			// Note: this type is marked as 'beforefieldinit'.
			static NamespaceDeclaration()
			{
				Il2CppClassPointerStore<XmlNamespaceManager.NamespaceDeclaration>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "NamespaceDeclaration");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNamespaceManager.NamespaceDeclaration>.NativeClassPtr);
				XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager.NamespaceDeclaration>.NativeClassPtr, "prefix");
				XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager.NamespaceDeclaration>.NativeClassPtr, "uri");
				XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_scopeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager.NamespaceDeclaration>.NativeClassPtr, "scopeId");
				XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_previousNsIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager.NamespaceDeclaration>.NativeClassPtr, "previousNsIndex");
				XmlNamespaceManager.NamespaceDeclaration.NativeMethodInfoPtr_Set_Public_Void_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager.NamespaceDeclaration>.NativeClassPtr, 100666225);
			}

			// Token: 0x060030AA RID: 12458 RVA: 0x000DAEC0 File Offset: 0x000D90C0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 382440, RefRangeEnd = 382441, XrefRangeStart = 382438, XrefRangeEnd = 382440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Set(string prefix, string uri, int scopeId, int previousNsIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uri);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopeId;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousNsIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamespaceManager.NamespaceDeclaration.NativeMethodInfoPtr_Set_Public_Void_String_String_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030AB RID: 12459 RVA: 0x0001473A File Offset: 0x0001293A
			public NamespaceDeclaration(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060030AC RID: 12460 RVA: 0x00014743 File Offset: 0x00012943
			public NamespaceDeclaration()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNamespaceManager.NamespaceDeclaration>.NativeClassPtr))
			{
			}

			// Token: 0x1700105F RID: 4191
			// (get) Token: 0x060030AD RID: 12461 RVA: 0x000DAF38 File Offset: 0x000D9138
			// (set) Token: 0x060030AE RID: 12462 RVA: 0x00014755 File Offset: 0x00012955
			public unsafe string prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001060 RID: 4192
			// (get) Token: 0x060030AF RID: 12463 RVA: 0x000DAF60 File Offset: 0x000D9160
			// (set) Token: 0x060030B0 RID: 12464 RVA: 0x00014774 File Offset: 0x00012974
			public unsafe string uri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_uri);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_uri), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001061 RID: 4193
			// (get) Token: 0x060030B1 RID: 12465 RVA: 0x000DAF88 File Offset: 0x000D9188
			// (set) Token: 0x060030B2 RID: 12466 RVA: 0x00014793 File Offset: 0x00012993
			public unsafe int scopeId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_scopeId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_scopeId)) = value;
				}
			}

			// Token: 0x17001062 RID: 4194
			// (get) Token: 0x060030B3 RID: 12467 RVA: 0x000DAFB0 File Offset: 0x000D91B0
			// (set) Token: 0x060030B4 RID: 12468 RVA: 0x000147AE File Offset: 0x000129AE
			public unsafe int previousNsIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_previousNsIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_previousNsIndex)) = value;
				}
			}

			// Token: 0x040025D1 RID: 9681
			private static readonly IntPtr NativeFieldInfoPtr_prefix;

			// Token: 0x040025D2 RID: 9682
			private static readonly IntPtr NativeFieldInfoPtr_uri;

			// Token: 0x040025D3 RID: 9683
			private static readonly IntPtr NativeFieldInfoPtr_scopeId;

			// Token: 0x040025D4 RID: 9684
			private static readonly IntPtr NativeFieldInfoPtr_previousNsIndex;

			// Token: 0x040025D5 RID: 9685
			private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_String_String_Int32_Int32_0;
		}
	}
}

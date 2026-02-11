using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200018B RID: 395
	public class SchemaNamespaceManager : XmlNamespaceManager
	{
		// Token: 0x06002187 RID: 8583 RVA: 0x000A1030 File Offset: 0x0009F230
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaNamespaceManager()
		{
			Il2CppClassPointerStore<SchemaNamespaceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaNamespaceManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaNamespaceManager>.NativeClassPtr);
			SchemaNamespaceManager.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaNamespaceManager>.NativeClassPtr, "node");
			SchemaNamespaceManager.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNamespaceManager>.NativeClassPtr, 100668170);
			SchemaNamespaceManager.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNamespaceManager>.NativeClassPtr, 100668171);
			SchemaNamespaceManager.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaNamespaceManager>.NativeClassPtr, 100668172);
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x000A10B0 File Offset: 0x0009F2B0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 405301, RefRangeEnd = 405307, XrefRangeStart = 405299, XrefRangeEnd = 405301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaNamespaceManager(XmlSchemaObject node)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaNamespaceManager>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaNamespaceManager.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x000A10FC File Offset: 0x0009F2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 405307, XrefRangeEnd = 405315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchemaNamespaceManager.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x000A1150 File Offset: 0x0009F350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 405315, XrefRangeEnd = 405333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string LookupPrefix(string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchemaNamespaceManager.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x0000E419 File Offset: 0x0000C619
		public SchemaNamespaceManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x0600218C RID: 8588 RVA: 0x000A11A4 File Offset: 0x0009F3A4
		// (set) Token: 0x0600218D RID: 8589 RVA: 0x0000E422 File Offset: 0x0000C622
		public unsafe XmlSchemaObject node
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNamespaceManager.NativeFieldInfoPtr_node);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaNamespaceManager.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001953 RID: 6483
		private static readonly IntPtr NativeFieldInfoPtr_node;

		// Token: 0x04001954 RID: 6484
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaObject_0;

		// Token: 0x04001955 RID: 6485
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0;

		// Token: 0x04001956 RID: 6486
		private static readonly IntPtr NativeMethodInfoPtr_LookupPrefix_Public_Virtual_String_String_0;
	}
}

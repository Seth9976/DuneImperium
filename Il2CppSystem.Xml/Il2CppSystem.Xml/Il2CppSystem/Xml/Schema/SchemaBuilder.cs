using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000182 RID: 386
	public class SchemaBuilder : Object
	{
		// Token: 0x06001EE1 RID: 7905 RVA: 0x00097F8C File Offset: 0x0009618C
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaBuilder()
		{
			Il2CppClassPointerStore<SchemaBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaBuilder>.NativeClassPtr);
			SchemaBuilder.NativeMethodInfoPtr_ProcessElement_Internal_Abstract_Virtual_New_Boolean_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaBuilder>.NativeClassPtr, 100667925);
			SchemaBuilder.NativeMethodInfoPtr_ProcessAttribute_Internal_Abstract_Virtual_New_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaBuilder>.NativeClassPtr, 100667926);
			SchemaBuilder.NativeMethodInfoPtr_IsContentParsed_Internal_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaBuilder>.NativeClassPtr, 100667927);
			SchemaBuilder.NativeMethodInfoPtr_ProcessMarkup_Internal_Abstract_Virtual_New_Void_Il2CppReferenceArray_1_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaBuilder>.NativeClassPtr, 100667928);
			SchemaBuilder.NativeMethodInfoPtr_ProcessCData_Internal_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaBuilder>.NativeClassPtr, 100667929);
			SchemaBuilder.NativeMethodInfoPtr_StartChildren_Internal_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaBuilder>.NativeClassPtr, 100667930);
			SchemaBuilder.NativeMethodInfoPtr_EndChildren_Internal_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaBuilder>.NativeClassPtr, 100667931);
			SchemaBuilder.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaBuilder>.NativeClassPtr, 100667932);
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x0009805C File Offset: 0x0009625C
		[CallerCount(0)]
		public unsafe virtual bool ProcessElement(string prefix, string name, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchemaBuilder.NativeMethodInfoPtr_ProcessElement_Internal_Abstract_Virtual_New_Boolean_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x000980D8 File Offset: 0x000962D8
		[CallerCount(0)]
		public unsafe virtual void ProcessAttribute(string prefix, string name, string ns, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchemaBuilder.NativeMethodInfoPtr_ProcessAttribute_Internal_Abstract_Virtual_New_Void_String_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x0009815C File Offset: 0x0009635C
		[CallerCount(0)]
		public unsafe virtual bool IsContentParsed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchemaBuilder.NativeMethodInfoPtr_IsContentParsed_Internal_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x000981A4 File Offset: 0x000963A4
		[CallerCount(0)]
		public unsafe virtual void ProcessMarkup(Il2CppReferenceArray<XmlNode> markup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(markup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchemaBuilder.NativeMethodInfoPtr_ProcessMarkup_Internal_Abstract_Virtual_New_Void_Il2CppReferenceArray_1_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x000981F4 File Offset: 0x000963F4
		[CallerCount(0)]
		public unsafe virtual void ProcessCData(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchemaBuilder.NativeMethodInfoPtr_ProcessCData_Internal_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x00098244 File Offset: 0x00096444
		[CallerCount(0)]
		public unsafe virtual void StartChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchemaBuilder.NativeMethodInfoPtr_StartChildren_Internal_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x00098280 File Offset: 0x00096480
		[CallerCount(0)]
		public unsafe virtual void EndChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchemaBuilder.NativeMethodInfoPtr_EndChildren_Internal_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x000982BC File Offset: 0x000964BC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaBuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaBuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaBuilder.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x0000CAFB File Offset: 0x0000ACFB
		public SchemaBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001783 RID: 6019
		private static readonly IntPtr NativeMethodInfoPtr_ProcessElement_Internal_Abstract_Virtual_New_Boolean_String_String_String_0;

		// Token: 0x04001784 RID: 6020
		private static readonly IntPtr NativeMethodInfoPtr_ProcessAttribute_Internal_Abstract_Virtual_New_Void_String_String_String_String_0;

		// Token: 0x04001785 RID: 6021
		private static readonly IntPtr NativeMethodInfoPtr_IsContentParsed_Internal_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04001786 RID: 6022
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMarkup_Internal_Abstract_Virtual_New_Void_Il2CppReferenceArray_1_XmlNode_0;

		// Token: 0x04001787 RID: 6023
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCData_Internal_Abstract_Virtual_New_Void_String_0;

		// Token: 0x04001788 RID: 6024
		private static readonly IntPtr NativeMethodInfoPtr_StartChildren_Internal_Abstract_Virtual_New_Void_0;

		// Token: 0x04001789 RID: 6025
		private static readonly IntPtr NativeMethodInfoPtr_EndChildren_Internal_Abstract_Virtual_New_Void_0;

		// Token: 0x0400178A RID: 6026
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

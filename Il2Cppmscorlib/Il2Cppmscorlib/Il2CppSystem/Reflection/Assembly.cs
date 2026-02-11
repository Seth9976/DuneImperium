using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Security.Policy;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200043D RID: 1085
	[Serializable]
	public class Assembly : Object
	{
		// Token: 0x06003E45 RID: 15941 RVA: 0x0012AA5C File Offset: 0x00128C5C
		// Note: this type is marked as 'beforefieldinit'.
		static Assembly()
		{
			Il2CppClassPointerStore<Assembly>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "Assembly");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Assembly>.NativeClassPtr);
			Assembly.NativeMethodInfoPtr_get_CodeBase_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672660);
			Assembly.NativeMethodInfoPtr_get_FullName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672661);
			Assembly.NativeMethodInfoPtr_get_MonoAssembly_Internal_Virtual_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672662);
			Assembly.NativeMethodInfoPtr_get_Location_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672663);
			Assembly.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672664);
			Assembly.NativeMethodInfoPtr_IsDefined_Public_Virtual_New_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672665);
			Assembly.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_New_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672666);
			Assembly.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672667);
			Assembly.NativeMethodInfoPtr_GetManifestResourceStream_Public_Virtual_New_Stream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672668);
			Assembly.NativeMethodInfoPtr_GetManifestResourceStream_Internal_Stream_Type_String_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672669);
			Assembly.NativeMethodInfoPtr_GetManifestResourceStream_Internal_Stream_String_byref_StackCrawlMark_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672670);
			Assembly.NativeMethodInfoPtr_GetSimpleName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672671);
			Assembly.NativeMethodInfoPtr_GetPublicKey_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672672);
			Assembly.NativeMethodInfoPtr_GetVersion_Internal_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672673);
			Assembly.NativeMethodInfoPtr_GetFlags_Private_AssemblyNameFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672674);
			Assembly.NativeMethodInfoPtr_GetTypes_Internal_Virtual_New_Il2CppReferenceArray_1_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672675);
			Assembly.NativeMethodInfoPtr_GetTypes_Public_Virtual_New_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672676);
			Assembly.NativeMethodInfoPtr_GetExportedTypes_Public_Virtual_New_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672677);
			Assembly.NativeMethodInfoPtr_GetType_Public_Virtual_New_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672678);
			Assembly.NativeMethodInfoPtr_InternalGetType_Internal_Type_Module_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672679);
			Assembly.NativeMethodInfoPtr_GetName_Public_Virtual_New_AssemblyName_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672680);
			Assembly.NativeMethodInfoPtr_GetName_Public_Virtual_New_AssemblyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672681);
			Assembly.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672682);
			Assembly.NativeMethodInfoPtr_GetAssembly_Public_Static_Assembly_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672683);
			Assembly.NativeMethodInfoPtr_InternalGetSatelliteAssembly_Internal_RuntimeAssembly_String_CultureInfo_Version_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672684);
			Assembly.NativeMethodInfoPtr_LoadFrom_Private_Static_Assembly_String_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672685);
			Assembly.NativeMethodInfoPtr_Load_Public_Static_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672686);
			Assembly.NativeMethodInfoPtr_ReflectionOnlyLoad_Public_Static_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672687);
			Assembly.NativeMethodInfoPtr_LoadWithPartialName_Public_Static_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672688);
			Assembly.NativeMethodInfoPtr_load_with_partial_name_Private_Static_Assembly_String_Evidence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672689);
			Assembly.NativeMethodInfoPtr_LoadWithPartialName_Public_Static_Assembly_String_Evidence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672690);
			Assembly.NativeMethodInfoPtr_LoadWithPartialName_Internal_Static_Assembly_String_Evidence_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672691);
			Assembly.NativeMethodInfoPtr_GetModulesInternal_Internal_Virtual_New_Il2CppReferenceArray_1_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672692);
			Assembly.NativeMethodInfoPtr_GetExecutingAssembly_Public_Static_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672693);
			Assembly.NativeMethodInfoPtr_GetCallingAssembly_Public_Static_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672694);
			Assembly.NativeMethodInfoPtr_GetManifestResourceNames_Public_Virtual_New_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672695);
			Assembly.NativeMethodInfoPtr_GetManifestResourceInfo_Public_Virtual_New_ManifestResourceInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672696);
			Assembly.NativeMethodInfoPtr_get_ReflectionOnly_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672697);
			Assembly.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672698);
			Assembly.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672699);
			Assembly.NativeMethodInfoPtr_CreateNIE_Private_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672700);
			Assembly.NativeMethodInfoPtr_get_IsFullyTrusted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672701);
			Assembly.NativeMethodInfoPtr_GetType_Public_Virtual_New_Type_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672702);
			Assembly.NativeMethodInfoPtr_GetModule_Public_Virtual_New_Module_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672703);
			Assembly.NativeMethodInfoPtr_GetModules_Public_Virtual_New_Il2CppReferenceArray_1_Module_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672704);
			Assembly.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Assembly_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672705);
			Assembly.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Assembly_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672706);
			Assembly.NativeMethodInfoPtr_get_ExportedTypes_Public_Virtual_New_get_IEnumerable_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672707);
			Assembly.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly>.NativeClassPtr, 100672708);
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06003E46 RID: 15942 RVA: 0x0012AE60 File Offset: 0x00129060
		public unsafe virtual string CodeBase
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400298, XrefRangeEnd = 1400303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_get_CodeBase_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06003E47 RID: 15943 RVA: 0x0012AEA4 File Offset: 0x001290A4
		public unsafe virtual string FullName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400303, XrefRangeEnd = 1400308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_get_FullName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06003E48 RID: 15944 RVA: 0x0012AEE8 File Offset: 0x001290E8
		public unsafe virtual IntPtr MonoAssembly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400308, XrefRangeEnd = 1400313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_get_MonoAssembly_Internal_Virtual_New_get_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06003E49 RID: 15945 RVA: 0x0012AF30 File Offset: 0x00129130
		public unsafe virtual string Location
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400313, XrefRangeEnd = 1400318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_get_Location_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003E4A RID: 15946 RVA: 0x0012AF74 File Offset: 0x00129174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400318, XrefRangeEnd = 1400323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E4B RID: 15947 RVA: 0x0012AFD8 File Offset: 0x001291D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400323, XrefRangeEnd = 1400328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsDefined(Type attributeType, bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_IsDefined_Public_Virtual_New_Boolean_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003E4C RID: 15948 RVA: 0x0012B040 File Offset: 0x00129240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400328, XrefRangeEnd = 1400333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Object> GetCustomAttributes(bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inherit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_New_Il2CppReferenceArray_1_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06003E4D RID: 15949 RVA: 0x0012B098 File Offset: 0x00129298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400333, XrefRangeEnd = 1400338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Object> GetCustomAttributes(Type attributeType, bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06003E4E RID: 15950 RVA: 0x0012B104 File Offset: 0x00129304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400338, XrefRangeEnd = 1400343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Stream GetManifestResourceStream(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetManifestResourceStream_Public_Virtual_New_Stream_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x06003E4F RID: 15951 RVA: 0x0012B160 File Offset: 0x00129360
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1400366, RefRangeEnd = 1400369, XrefRangeStart = 1400343, XrefRangeEnd = 1400366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stream GetManifestResourceStream(Type type, string name, bool skipSecurityCheck, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipSecurityCheck;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_GetManifestResourceStream_Internal_Stream_Type_String_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x06003E50 RID: 15952 RVA: 0x0012B1E0 File Offset: 0x001293E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1400370, RefRangeEnd = 1400371, XrefRangeStart = 1400369, XrefRangeEnd = 1400370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stream GetManifestResourceStream(string name, ref StackCrawlMark stackMark, bool skipSecurityCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipSecurityCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_GetManifestResourceStream_Internal_Stream_String_byref_StackCrawlMark_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x0012B24C File Offset: 0x0012944C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1400371, RefRangeEnd = 1400375, XrefRangeStart = 1400371, XrefRangeEnd = 1400371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSimpleName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_GetSimpleName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x0012B284 File Offset: 0x00129484
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1400375, RefRangeEnd = 1400376, XrefRangeStart = 1400375, XrefRangeEnd = 1400375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetPublicKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_GetPublicKey_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003E53 RID: 15955 RVA: 0x0012B2C4 File Offset: 0x001294C4
		[CallerCount(0)]
		public unsafe Version GetVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_GetVersion_Internal_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
		}

		// Token: 0x06003E54 RID: 15956 RVA: 0x0012B304 File Offset: 0x00129504
		[CallerCount(0)]
		public unsafe AssemblyNameFlags GetFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_GetFlags_Private_AssemblyNameFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003E55 RID: 15957 RVA: 0x0012B340 File Offset: 0x00129540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400376, XrefRangeEnd = 1400377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Type> GetTypes(bool exportedOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref exportedOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetTypes_Internal_Virtual_New_Il2CppReferenceArray_1_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06003E56 RID: 15958 RVA: 0x0012B398 File Offset: 0x00129598
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<Type> GetTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetTypes_Public_Virtual_New_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06003E57 RID: 15959 RVA: 0x0012B3E4 File Offset: 0x001295E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400377, XrefRangeEnd = 1400382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Type> GetExportedTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetExportedTypes_Public_Virtual_New_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06003E58 RID: 15960 RVA: 0x0012B430 File Offset: 0x00129630
		[CallerCount(0)]
		public unsafe virtual Type GetType(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetType_Public_Virtual_New_Type_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003E59 RID: 15961 RVA: 0x0012B48C File Offset: 0x0012968C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400382, XrefRangeEnd = 1400383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(module);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_InternalGetType_Internal_Type_Module_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003E5A RID: 15962 RVA: 0x0012B50C File Offset: 0x0012970C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400383, XrefRangeEnd = 1400388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AssemblyName GetName(bool copiedName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref copiedName;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetName_Public_Virtual_New_AssemblyName_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssemblyName>(intPtr3) : null;
			}
		}

		// Token: 0x06003E5B RID: 15963 RVA: 0x0012B564 File Offset: 0x00129764
		[CallerCount(0)]
		public unsafe virtual AssemblyName GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetName_Public_Virtual_New_AssemblyName_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssemblyName>(intPtr3) : null;
		}

		// Token: 0x06003E5C RID: 15964 RVA: 0x0012B5B0 File Offset: 0x001297B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x0012B5F4 File Offset: 0x001297F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400388, XrefRangeEnd = 1400399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly GetAssembly(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_GetAssembly_Public_Static_Assembly_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06003E5E RID: 15966 RVA: 0x0012B638 File Offset: 0x00129838
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1400433, RefRangeEnd = 1400434, XrefRangeStart = 1400399, XrefRangeEnd = 1400433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeAssembly InternalGetSatelliteAssembly(string name, CultureInfo culture, Version version, bool throwOnFileNotFound, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(version);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnFileNotFound;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_InternalGetSatelliteAssembly_Internal_RuntimeAssembly_String_CultureInfo_Version_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeAssembly>(intPtr3) : null;
		}

		// Token: 0x06003E5F RID: 15967 RVA: 0x0012B6CC File Offset: 0x001298CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400434, XrefRangeEnd = 1400435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly LoadFrom(string assemblyFile, bool refOnly, ref StackCrawlMark stackMark)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyFile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref refOnly;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_LoadFrom_Private_Static_Assembly_String_Boolean_byref_StackCrawlMark_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x06003E60 RID: 15968 RVA: 0x0012B72C File Offset: 0x0012992C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1400438, RefRangeEnd = 1400457, XrefRangeStart = 1400435, XrefRangeEnd = 1400438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly Load(string assemblyString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_Load_Public_Static_Assembly_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06003E61 RID: 15969 RVA: 0x0012B770 File Offset: 0x00129970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400457, XrefRangeEnd = 1400459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly ReflectionOnlyLoad(string assemblyString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_ReflectionOnlyLoad_Public_Static_Assembly_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06003E62 RID: 15970 RVA: 0x0012B7B4 File Offset: 0x001299B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400459, XrefRangeEnd = 1400465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly LoadWithPartialName(string partialName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(partialName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_LoadWithPartialName_Public_Static_Assembly_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06003E63 RID: 15971 RVA: 0x0012B7F8 File Offset: 0x001299F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400465, XrefRangeEnd = 1400466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly load_with_partial_name(string name, Evidence e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_load_with_partial_name_Private_Static_Assembly_String_Evidence_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x06003E64 RID: 15972 RVA: 0x0012B850 File Offset: 0x00129A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400466, XrefRangeEnd = 1400472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(partialName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(securityEvidence);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_LoadWithPartialName_Public_Static_Assembly_String_Evidence_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x06003E65 RID: 15973 RVA: 0x0012B8A8 File Offset: 0x00129AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400472, XrefRangeEnd = 1400483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(partialName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(securityEvidence);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldBehavior;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_LoadWithPartialName_Internal_Static_Assembly_String_Evidence_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x06003E66 RID: 15974 RVA: 0x0012B90C File Offset: 0x00129B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400483, XrefRangeEnd = 1400488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Module> GetModulesInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetModulesInternal_Internal_Virtual_New_Il2CppReferenceArray_1_Module_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Module>>(intPtr3) : null;
		}

		// Token: 0x06003E67 RID: 15975 RVA: 0x0012B958 File Offset: 0x00129B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400488, XrefRangeEnd = 1400491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly GetExecutingAssembly()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_GetExecutingAssembly_Public_Static_Assembly_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x06003E68 RID: 15976 RVA: 0x0012B98C File Offset: 0x00129B8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1400492, RefRangeEnd = 1400494, XrefRangeStart = 1400491, XrefRangeEnd = 1400492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly GetCallingAssembly()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_GetCallingAssembly_Public_Static_Assembly_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x06003E69 RID: 15977 RVA: 0x0012B9C0 File Offset: 0x00129BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400494, XrefRangeEnd = 1400499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStringArray GetManifestResourceNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetManifestResourceNames_Public_Virtual_New_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06003E6A RID: 15978 RVA: 0x0012BA0C File Offset: 0x00129C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400499, XrefRangeEnd = 1400504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(resourceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetManifestResourceInfo_Public_Virtual_New_ManifestResourceInfo_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ManifestResourceInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06003E6B RID: 15979 RVA: 0x0012BA68 File Offset: 0x00129C68
		public unsafe virtual bool ReflectionOnly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400504, XrefRangeEnd = 1400509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_get_ReflectionOnly_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003E6C RID: 15980 RVA: 0x0012BAB0 File Offset: 0x00129CB0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 389658, RefRangeEnd = 389671, XrefRangeStart = 389658, XrefRangeEnd = 389671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003E6D RID: 15981 RVA: 0x0012BAF8 File Offset: 0x00129CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003E6E RID: 15982 RVA: 0x0012BB50 File Offset: 0x00129D50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1400515, RefRangeEnd = 1400518, XrefRangeStart = 1400509, XrefRangeEnd = 1400515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateNIE()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_CreateNIE_Private_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06003E6F RID: 15983 RVA: 0x0012BB84 File Offset: 0x00129D84
		public unsafe bool IsFullyTrusted
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_get_IsFullyTrusted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003E70 RID: 15984 RVA: 0x0012BBC0 File Offset: 0x00129DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400518, XrefRangeEnd = 1400521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Type GetType(string name, bool throwOnError, bool ignoreCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetType_Public_Virtual_New_Type_String_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003E71 RID: 15985 RVA: 0x0012BC38 File Offset: 0x00129E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400521, XrefRangeEnd = 1400524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Module GetModule(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetModule_Public_Virtual_New_Module_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Module>(intPtr3) : null;
			}
		}

		// Token: 0x06003E72 RID: 15986 RVA: 0x0012BC94 File Offset: 0x00129E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1400524, XrefRangeEnd = 1400527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Module> GetModules(bool getResourceModules)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref getResourceModules;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_GetModules_Public_Virtual_New_Il2CppReferenceArray_1_Module_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Module>>(intPtr3) : null;
			}
		}

		// Token: 0x06003E73 RID: 15987 RVA: 0x0012BCEC File Offset: 0x00129EEC
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 1400527, RefRangeEnd = 1400563, XrefRangeStart = 1400527, XrefRangeEnd = 1400527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Assembly left, Assembly right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Assembly_Assembly_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003E74 RID: 15988 RVA: 0x0012BD40 File Offset: 0x00129F40
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1400563, RefRangeEnd = 1400571, XrefRangeStart = 1400563, XrefRangeEnd = 1400563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Assembly left, Assembly right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Assembly_Assembly_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06003E75 RID: 15989 RVA: 0x0012BD94 File Offset: 0x00129F94
		public unsafe virtual IEnumerable<Type> ExportedTypes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assembly.NativeMethodInfoPtr_get_ExportedTypes_Public_Virtual_New_get_IEnumerable_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06003E76 RID: 15990 RVA: 0x0012BDE0 File Offset: 0x00129FE0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Assembly>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E77 RID: 15991 RVA: 0x00016C68 File Offset: 0x00014E68
		public Assembly(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003353 RID: 13139
		private static readonly IntPtr NativeMethodInfoPtr_get_CodeBase_Public_Virtual_New_get_String_0;

		// Token: 0x04003354 RID: 13140
		private static readonly IntPtr NativeMethodInfoPtr_get_FullName_Public_Virtual_New_get_String_0;

		// Token: 0x04003355 RID: 13141
		private static readonly IntPtr NativeMethodInfoPtr_get_MonoAssembly_Internal_Virtual_New_get_IntPtr_0;

		// Token: 0x04003356 RID: 13142
		private static readonly IntPtr NativeMethodInfoPtr_get_Location_Public_Virtual_New_get_String_0;

		// Token: 0x04003357 RID: 13143
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003358 RID: 13144
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Virtual_New_Boolean_Type_Boolean_0;

		// Token: 0x04003359 RID: 13145
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_New_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x0400335A RID: 13146
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x0400335B RID: 13147
		private static readonly IntPtr NativeMethodInfoPtr_GetManifestResourceStream_Public_Virtual_New_Stream_String_0;

		// Token: 0x0400335C RID: 13148
		private static readonly IntPtr NativeMethodInfoPtr_GetManifestResourceStream_Internal_Stream_Type_String_Boolean_byref_StackCrawlMark_0;

		// Token: 0x0400335D RID: 13149
		private static readonly IntPtr NativeMethodInfoPtr_GetManifestResourceStream_Internal_Stream_String_byref_StackCrawlMark_Boolean_0;

		// Token: 0x0400335E RID: 13150
		private static readonly IntPtr NativeMethodInfoPtr_GetSimpleName_Internal_String_0;

		// Token: 0x0400335F RID: 13151
		private static readonly IntPtr NativeMethodInfoPtr_GetPublicKey_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x04003360 RID: 13152
		private static readonly IntPtr NativeMethodInfoPtr_GetVersion_Internal_Version_0;

		// Token: 0x04003361 RID: 13153
		private static readonly IntPtr NativeMethodInfoPtr_GetFlags_Private_AssemblyNameFlags_0;

		// Token: 0x04003362 RID: 13154
		private static readonly IntPtr NativeMethodInfoPtr_GetTypes_Internal_Virtual_New_Il2CppReferenceArray_1_Type_Boolean_0;

		// Token: 0x04003363 RID: 13155
		private static readonly IntPtr NativeMethodInfoPtr_GetTypes_Public_Virtual_New_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04003364 RID: 13156
		private static readonly IntPtr NativeMethodInfoPtr_GetExportedTypes_Public_Virtual_New_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04003365 RID: 13157
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Public_Virtual_New_Type_String_0;

		// Token: 0x04003366 RID: 13158
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetType_Internal_Type_Module_String_Boolean_Boolean_0;

		// Token: 0x04003367 RID: 13159
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_New_AssemblyName_Boolean_0;

		// Token: 0x04003368 RID: 13160
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_New_AssemblyName_0;

		// Token: 0x04003369 RID: 13161
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400336A RID: 13162
		private static readonly IntPtr NativeMethodInfoPtr_GetAssembly_Public_Static_Assembly_Type_0;

		// Token: 0x0400336B RID: 13163
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetSatelliteAssembly_Internal_RuntimeAssembly_String_CultureInfo_Version_Boolean_byref_StackCrawlMark_0;

		// Token: 0x0400336C RID: 13164
		private static readonly IntPtr NativeMethodInfoPtr_LoadFrom_Private_Static_Assembly_String_Boolean_byref_StackCrawlMark_0;

		// Token: 0x0400336D RID: 13165
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_Assembly_String_0;

		// Token: 0x0400336E RID: 13166
		private static readonly IntPtr NativeMethodInfoPtr_ReflectionOnlyLoad_Public_Static_Assembly_String_0;

		// Token: 0x0400336F RID: 13167
		private static readonly IntPtr NativeMethodInfoPtr_LoadWithPartialName_Public_Static_Assembly_String_0;

		// Token: 0x04003370 RID: 13168
		private static readonly IntPtr NativeMethodInfoPtr_load_with_partial_name_Private_Static_Assembly_String_Evidence_0;

		// Token: 0x04003371 RID: 13169
		private static readonly IntPtr NativeMethodInfoPtr_LoadWithPartialName_Public_Static_Assembly_String_Evidence_0;

		// Token: 0x04003372 RID: 13170
		private static readonly IntPtr NativeMethodInfoPtr_LoadWithPartialName_Internal_Static_Assembly_String_Evidence_Boolean_0;

		// Token: 0x04003373 RID: 13171
		private static readonly IntPtr NativeMethodInfoPtr_GetModulesInternal_Internal_Virtual_New_Il2CppReferenceArray_1_Module_0;

		// Token: 0x04003374 RID: 13172
		private static readonly IntPtr NativeMethodInfoPtr_GetExecutingAssembly_Public_Static_Assembly_0;

		// Token: 0x04003375 RID: 13173
		private static readonly IntPtr NativeMethodInfoPtr_GetCallingAssembly_Public_Static_Assembly_0;

		// Token: 0x04003376 RID: 13174
		private static readonly IntPtr NativeMethodInfoPtr_GetManifestResourceNames_Public_Virtual_New_Il2CppStringArray_0;

		// Token: 0x04003377 RID: 13175
		private static readonly IntPtr NativeMethodInfoPtr_GetManifestResourceInfo_Public_Virtual_New_ManifestResourceInfo_String_0;

		// Token: 0x04003378 RID: 13176
		private static readonly IntPtr NativeMethodInfoPtr_get_ReflectionOnly_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04003379 RID: 13177
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400337A RID: 13178
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400337B RID: 13179
		private static readonly IntPtr NativeMethodInfoPtr_CreateNIE_Private_Static_Exception_0;

		// Token: 0x0400337C RID: 13180
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFullyTrusted_Public_get_Boolean_0;

		// Token: 0x0400337D RID: 13181
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Public_Virtual_New_Type_String_Boolean_Boolean_0;

		// Token: 0x0400337E RID: 13182
		private static readonly IntPtr NativeMethodInfoPtr_GetModule_Public_Virtual_New_Module_String_0;

		// Token: 0x0400337F RID: 13183
		private static readonly IntPtr NativeMethodInfoPtr_GetModules_Public_Virtual_New_Il2CppReferenceArray_1_Module_Boolean_0;

		// Token: 0x04003380 RID: 13184
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Assembly_Assembly_0;

		// Token: 0x04003381 RID: 13185
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Assembly_Assembly_0;

		// Token: 0x04003382 RID: 13186
		private static readonly IntPtr NativeMethodInfoPtr_get_ExportedTypes_Public_Virtual_New_get_IEnumerable_1_Type_0;

		// Token: 0x04003383 RID: 13187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020006BE RID: 1726
		public class ResolveEventHolder : Object
		{
			// Token: 0x06005CA0 RID: 23712 RVA: 0x00021999 File Offset: 0x0001FB99
			// Note: this type is marked as 'beforefieldinit'.
			static ResolveEventHolder()
			{
				Il2CppClassPointerStore<Assembly.ResolveEventHolder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Assembly>.NativeClassPtr, "ResolveEventHolder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Assembly.ResolveEventHolder>.NativeClassPtr);
				Assembly.ResolveEventHolder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assembly.ResolveEventHolder>.NativeClassPtr, 100672709);
			}

			// Token: 0x06005CA1 RID: 23713 RVA: 0x001A4234 File Offset: 0x001A2434
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ResolveEventHolder()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Assembly.ResolveEventHolder>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assembly.ResolveEventHolder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005CA2 RID: 23714 RVA: 0x000219CD File Offset: 0x0001FBCD
			public ResolveEventHolder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04004B3F RID: 19263
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

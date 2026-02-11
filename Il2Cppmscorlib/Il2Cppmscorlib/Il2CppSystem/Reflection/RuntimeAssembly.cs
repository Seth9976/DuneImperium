using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Security.Policy;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000442 RID: 1090
	[Serializable]
	public class RuntimeAssembly : Assembly
	{
		// Token: 0x06003EEE RID: 16110 RVA: 0x0012D890 File Offset: 0x0012BA90
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeAssembly()
		{
			Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "RuntimeAssembly");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr);
			RuntimeAssembly.NativeFieldInfoPtr__mono_assembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, "_mono_assembly");
			RuntimeAssembly.NativeFieldInfoPtr__evidence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, "_evidence");
			RuntimeAssembly.NativeFieldInfoPtr_resolve_event_holder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, "resolve_event_holder");
			RuntimeAssembly.NativeFieldInfoPtr__minimum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, "_minimum");
			RuntimeAssembly.NativeFieldInfoPtr__optional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, "_optional");
			RuntimeAssembly.NativeFieldInfoPtr__refuse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, "_refuse");
			RuntimeAssembly.NativeFieldInfoPtr__granted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, "_granted");
			RuntimeAssembly.NativeFieldInfoPtr__denied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, "_denied");
			RuntimeAssembly.NativeFieldInfoPtr_fromByteArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, "fromByteArray");
			RuntimeAssembly.NativeFieldInfoPtr_assemblyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, "assemblyName");
			RuntimeAssembly.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672761);
			RuntimeAssembly.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672762);
			RuntimeAssembly.NativeMethodInfoPtr_LoadWithPartialNameInternal_Internal_Static_RuntimeAssembly_String_Evidence_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672763);
			RuntimeAssembly.NativeMethodInfoPtr_LoadWithPartialNameInternal_Internal_Static_RuntimeAssembly_AssemblyName_Evidence_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672764);
			RuntimeAssembly.NativeMethodInfoPtr_GetName_Public_Virtual_AssemblyName_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672765);
			RuntimeAssembly.NativeMethodInfoPtr_GetType_Public_Virtual_Type_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672766);
			RuntimeAssembly.NativeMethodInfoPtr_GetModule_Public_Virtual_Module_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672767);
			RuntimeAssembly.NativeMethodInfoPtr_GetModules_Public_Virtual_Il2CppReferenceArray_1_Module_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672768);
			RuntimeAssembly.NativeMethodInfoPtr_GetExportedTypes_Public_Virtual_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672769);
			RuntimeAssembly.NativeMethodInfoPtr_GetAotId_Internal_Static_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672770);
			RuntimeAssembly.NativeMethodInfoPtr_get_code_base_Private_Static_String_Assembly_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672771);
			RuntimeAssembly.NativeMethodInfoPtr_get_location_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672772);
			RuntimeAssembly.NativeMethodInfoPtr_get_fullname_Internal_Static_String_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672773);
			RuntimeAssembly.NativeMethodInfoPtr_GetAotIdInternal_Internal_Static_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672774);
			RuntimeAssembly.NativeMethodInfoPtr_get_ReflectionOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672775);
			RuntimeAssembly.NativeMethodInfoPtr_GetCodeBase_Internal_Static_String_Assembly_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672776);
			RuntimeAssembly.NativeMethodInfoPtr_get_CodeBase_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672777);
			RuntimeAssembly.NativeMethodInfoPtr_get_FullName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672778);
			RuntimeAssembly.NativeMethodInfoPtr_get_MonoAssembly_Internal_Virtual_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672779);
			RuntimeAssembly.NativeMethodInfoPtr_get_Location_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672780);
			RuntimeAssembly.NativeMethodInfoPtr_GetManifestResourceInfoInternal_Private_Boolean_String_ManifestResourceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672781);
			RuntimeAssembly.NativeMethodInfoPtr_GetManifestResourceInfo_Public_Virtual_ManifestResourceInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672782);
			RuntimeAssembly.NativeMethodInfoPtr_GetManifestResourceNames_Public_Virtual_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672783);
			RuntimeAssembly.NativeMethodInfoPtr_GetManifestResourceInternal_Internal_IntPtr_String_byref_Int32_byref_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672784);
			RuntimeAssembly.NativeMethodInfoPtr_GetManifestResourceStream_Public_Virtual_Stream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672785);
			RuntimeAssembly.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672786);
			RuntimeAssembly.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672787);
			RuntimeAssembly.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672788);
			RuntimeAssembly.NativeMethodInfoPtr_GetModulesInternal_Internal_Virtual_Il2CppReferenceArray_1_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672789);
			RuntimeAssembly.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672790);
			RuntimeAssembly.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672791);
			RuntimeAssembly.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100672792);
		}

		// Token: 0x06003EEF RID: 16111 RVA: 0x0012DC08 File Offset: 0x0012BE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401159, XrefRangeEnd = 1401165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeAssembly()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeAssembly.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EF0 RID: 16112 RVA: 0x0012DC44 File Offset: 0x0012BE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401165, XrefRangeEnd = 1401166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeAssembly.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EF1 RID: 16113 RVA: 0x0012DCA8 File Offset: 0x0012BEA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1401169, RefRangeEnd = 1401170, XrefRangeStart = 1401166, XrefRangeEnd = 1401169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeAssembly LoadWithPartialNameInternal(string partialName, Evidence securityEvidence, ref StackCrawlMark stackMark)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(partialName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(securityEvidence);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeAssembly.NativeMethodInfoPtr_LoadWithPartialNameInternal_Internal_Static_RuntimeAssembly_String_Evidence_byref_StackCrawlMark_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeAssembly>(intPtr3) : null;
		}

		// Token: 0x06003EF2 RID: 16114 RVA: 0x0012DD0C File Offset: 0x0012BF0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1401173, RefRangeEnd = 1401174, XrefRangeStart = 1401170, XrefRangeEnd = 1401173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeAssembly LoadWithPartialNameInternal(AssemblyName an, Evidence securityEvidence, ref StackCrawlMark stackMark)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(an);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(securityEvidence);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeAssembly.NativeMethodInfoPtr_LoadWithPartialNameInternal_Internal_Static_RuntimeAssembly_AssemblyName_Evidence_byref_StackCrawlMark_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeAssembly>(intPtr3) : null;
		}

		// Token: 0x06003EF3 RID: 16115 RVA: 0x0012DD70 File Offset: 0x0012BF70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401174, XrefRangeEnd = 1401180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AssemblyName GetName(bool copiedName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref copiedName;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeAssembly.NativeMethodInfoPtr_GetName_Public_Virtual_AssemblyName_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssemblyName>(intPtr3) : null;
			}
		}

		// Token: 0x06003EF4 RID: 16116 RVA: 0x0012DDC8 File Offset: 0x0012BFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401180, XrefRangeEnd = 1401193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetType(string name, bool throwOnError, bool ignoreCase)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeAssembly.NativeMethodInfoPtr_GetType_Public_Virtual_Type_String_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003EF5 RID: 16117 RVA: 0x0012DE40 File Offset: 0x0012C040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401193, XrefRangeEnd = 1401195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Module GetModule(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeAssembly.NativeMethodInfoPtr_GetModule_Public_Virtual_Module_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Module>(intPtr3) : null;
			}
		}

		// Token: 0x06003EF6 RID: 16118 RVA: 0x0012DE9C File Offset: 0x0012C09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401195, XrefRangeEnd = 1401208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Module> GetModules(bool getResourceModules)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref getResourceModules;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeAssembly.NativeMethodInfoPtr_GetModules_Public_Virtual_Il2CppReferenceArray_1_Module_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Module>>(intPtr3) : null;
			}
		}

		// Token: 0x06003EF7 RID: 16119 RVA: 0x0012DEF4 File Offset: 0x0012C0F4
		[CallerCount(0)]
		public unsafe override Il2CppReferenceArray<Type> GetExportedTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeAssembly.NativeMethodInfoPtr_GetExportedTypes_Public_Virtual_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06003EF8 RID: 16120 RVA: 0x0012DF40 File Offset: 0x0012C140
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1401212, RefRangeEnd = 1401213, XrefRangeStart = 1401208, XrefRangeEnd = 1401212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetAotId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeAssembly.NativeMethodInfoPtr_GetAotId_Internal_Static_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003EF9 RID: 16121 RVA: 0x0012DF74 File Offset: 0x0012C174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401213, XrefRangeEnd = 1401214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string get_code_base(Assembly a, bool escaped)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref escaped;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeAssembly.NativeMethodInfoPtr_get_code_base_Private_Static_String_Assembly_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003EFA RID: 16122 RVA: 0x0012DFC0 File Offset: 0x0012C1C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401214, XrefRangeEnd = 1401215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string get_location()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeAssembly.NativeMethodInfoPtr_get_location_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003EFB RID: 16123 RVA: 0x0012DFF8 File Offset: 0x0012C1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401215, XrefRangeEnd = 1401216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string get_fullname(Assembly a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeAssembly.NativeMethodInfoPtr_get_fullname_Internal_Static_String_Assembly_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003EFC RID: 16124 RVA: 0x0012E034 File Offset: 0x0012C234
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429053, RefRangeEnd = 429054, XrefRangeStart = 429053, XrefRangeEnd = 429054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetAotIdInternal(Il2CppStructArray<byte> aotid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aotid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeAssembly.NativeMethodInfoPtr_GetAotIdInternal_Internal_Static_Boolean_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x06003EFD RID: 16125 RVA: 0x0012E078 File Offset: 0x0012C278
		public unsafe override bool ReflectionOnly
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 429053, RefRangeEnd = 429054, XrefRangeStart = 429053, XrefRangeEnd = 429054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeAssembly.NativeMethodInfoPtr_get_ReflectionOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003EFE RID: 16126 RVA: 0x0012E0C0 File Offset: 0x0012C2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCodeBase(Assembly a, bool escaped)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref escaped;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeAssembly.NativeMethodInfoPtr_GetCodeBase_Internal_Static_String_Assembly_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x06003EFF RID: 16127 RVA: 0x0012E10C File Offset: 0x0012C30C
		public unsafe override string CodeBase
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401216, XrefRangeEnd = 1401217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeAssembly.NativeMethodInfoPtr_get_CodeBase_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06003F00 RID: 16128 RVA: 0x0012E150 File Offset: 0x0012C350
		public unsafe override string FullName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeAssembly.NativeMethodInfoPtr_get_FullName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06003F01 RID: 16129 RVA: 0x0012E194 File Offset: 0x0012C394
		public unsafe override IntPtr MonoAssembly
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeAssembly.NativeMethodInfoPtr_get_MonoAssembly_Internal_Virtual_get_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06003F02 RID: 16130 RVA: 0x0012E1DC File Offset: 0x0012C3DC
		public unsafe override string Location
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401217, XrefRangeEnd = 1401220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeAssembly.NativeMethodInfoPtr_get_Location_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003F03 RID: 16131 RVA: 0x0012E220 File Offset: 0x0012C420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401220, XrefRangeEnd = 1401221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetManifestResourceInfoInternal(string name, ManifestResourceInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeAssembly.NativeMethodInfoPtr_GetManifestResourceInfoInternal_Private_Boolean_String_ManifestResourceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003F04 RID: 16132 RVA: 0x0012E280 File Offset: 0x0012C480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401221, XrefRangeEnd = 1401228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ManifestResourceInfo GetManifestResourceInfo(string resourceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(resourceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeAssembly.NativeMethodInfoPtr_GetManifestResourceInfo_Public_Virtual_ManifestResourceInfo_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ManifestResourceInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06003F05 RID: 16133 RVA: 0x0012E2DC File Offset: 0x0012C4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401228, XrefRangeEnd = 1401229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStringArray GetManifestResourceNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeAssembly.NativeMethodInfoPtr_GetManifestResourceNames_Public_Virtual_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06003F06 RID: 16134 RVA: 0x0012E328 File Offset: 0x0012C528
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1401230, RefRangeEnd = 1401231, XrefRangeStart = 1401229, XrefRangeEnd = 1401230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetManifestResourceInternal(string name, out int size, out Module module)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &size;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RuntimeAssembly.NativeMethodInfoPtr_GetManifestResourceInternal_Internal_IntPtr_String_byref_Int32_byref_Module_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			module = ((intPtr4 == 0) ? null : new Module(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003F07 RID: 16135 RVA: 0x0012E3A8 File Offset: 0x0012C5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401231, XrefRangeEnd = 1401241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Stream GetManifestResourceStream(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeAssembly.NativeMethodInfoPtr_GetManifestResourceStream_Public_Virtual_Stream_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x06003F08 RID: 16136 RVA: 0x0012E404 File Offset: 0x0012C604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401241, XrefRangeEnd = 1401245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsDefined(Type attributeType, bool inherit)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeAssembly.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003F09 RID: 16137 RVA: 0x0012E46C File Offset: 0x0012C66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401245, XrefRangeEnd = 1401249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Object> GetCustomAttributes(bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inherit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeAssembly.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06003F0A RID: 16138 RVA: 0x0012E4C4 File Offset: 0x0012C6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401249, XrefRangeEnd = 1401253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Object> GetCustomAttributes(Type attributeType, bool inherit)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeAssembly.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06003F0B RID: 16139 RVA: 0x0012E530 File Offset: 0x0012C730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401253, XrefRangeEnd = 1401254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Module> GetModulesInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeAssembly.NativeMethodInfoPtr_GetModulesInternal_Internal_Virtual_Il2CppReferenceArray_1_Module_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Module>>(intPtr3) : null;
		}

		// Token: 0x06003F0C RID: 16140 RVA: 0x0012E57C File Offset: 0x0012C77C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 389658, RefRangeEnd = 389671, XrefRangeStart = 389658, XrefRangeEnd = 389671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeAssembly.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003F0D RID: 16141 RVA: 0x0012E5C4 File Offset: 0x0012C7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401254, XrefRangeEnd = 1401257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeAssembly.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F0E RID: 16142 RVA: 0x0012E61C File Offset: 0x0012C81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401257, XrefRangeEnd = 1401258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeAssembly.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003F0F RID: 16143 RVA: 0x00016FF3 File Offset: 0x000151F3
		public RuntimeAssembly(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06003F10 RID: 16144 RVA: 0x0012E660 File Offset: 0x0012C860
		// (set) Token: 0x06003F11 RID: 16145 RVA: 0x00016FFC File Offset: 0x000151FC
		public unsafe IntPtr _mono_assembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeAssembly.NativeFieldInfoPtr__mono_assembly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeAssembly.NativeFieldInfoPtr__mono_assembly)) = value;
			}
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06003F12 RID: 16146 RVA: 0x0012E688 File Offset: 0x0012C888
		// (set) Token: 0x06003F13 RID: 16147 RVA: 0x00017017 File Offset: 0x00015217
		public unsafe Object _evidence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeAssembly.NativeFieldInfoPtr__evidence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeAssembly.NativeFieldInfoPtr__evidence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06003F14 RID: 16148 RVA: 0x0012E6B8 File Offset: 0x0012C8B8
		// (set) Token: 0x06003F15 RID: 16149 RVA: 0x00017036 File Offset: 0x00015236
		public unsafe Assembly.ResolveEventHolder resolve_event_holder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeAssembly.NativeFieldInfoPtr_resolve_event_holder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly.ResolveEventHolder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeAssembly.NativeFieldInfoPtr_resolve_event_holder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06003F16 RID: 16150 RVA: 0x0012E6E8 File Offset: 0x0012C8E8
		// (set) Token: 0x06003F17 RID: 16151 RVA: 0x00017055 File Offset: 0x00015255
		public unsafe Object _minimum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeAssembly.NativeFieldInfoPtr__minimum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeAssembly.NativeFieldInfoPtr__minimum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06003F18 RID: 16152 RVA: 0x0012E718 File Offset: 0x0012C918
		// (set) Token: 0x06003F19 RID: 16153 RVA: 0x00017074 File Offset: 0x00015274
		public unsafe Object _optional
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeAssembly.NativeFieldInfoPtr__optional);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeAssembly.NativeFieldInfoPtr__optional), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x06003F1A RID: 16154 RVA: 0x0012E748 File Offset: 0x0012C948
		// (set) Token: 0x06003F1B RID: 16155 RVA: 0x00017093 File Offset: 0x00015293
		public unsafe Object _refuse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeAssembly.NativeFieldInfoPtr__refuse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeAssembly.NativeFieldInfoPtr__refuse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06003F1C RID: 16156 RVA: 0x0012E778 File Offset: 0x0012C978
		// (set) Token: 0x06003F1D RID: 16157 RVA: 0x000170B2 File Offset: 0x000152B2
		public unsafe Object _granted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeAssembly.NativeFieldInfoPtr__granted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeAssembly.NativeFieldInfoPtr__granted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x06003F1E RID: 16158 RVA: 0x0012E7A8 File Offset: 0x0012C9A8
		// (set) Token: 0x06003F1F RID: 16159 RVA: 0x000170D1 File Offset: 0x000152D1
		public unsafe Object _denied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeAssembly.NativeFieldInfoPtr__denied);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeAssembly.NativeFieldInfoPtr__denied), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06003F20 RID: 16160 RVA: 0x0012E7D8 File Offset: 0x0012C9D8
		// (set) Token: 0x06003F21 RID: 16161 RVA: 0x000170F0 File Offset: 0x000152F0
		public unsafe bool fromByteArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeAssembly.NativeFieldInfoPtr_fromByteArray);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeAssembly.NativeFieldInfoPtr_fromByteArray)) = value;
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x06003F22 RID: 16162 RVA: 0x0012E800 File Offset: 0x0012CA00
		// (set) Token: 0x06003F23 RID: 16163 RVA: 0x0001710B File Offset: 0x0001530B
		public unsafe string assemblyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeAssembly.NativeFieldInfoPtr_assemblyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeAssembly.NativeFieldInfoPtr_assemblyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040033D4 RID: 13268
		private static readonly IntPtr NativeFieldInfoPtr__mono_assembly;

		// Token: 0x040033D5 RID: 13269
		private static readonly IntPtr NativeFieldInfoPtr__evidence;

		// Token: 0x040033D6 RID: 13270
		private static readonly IntPtr NativeFieldInfoPtr_resolve_event_holder;

		// Token: 0x040033D7 RID: 13271
		private static readonly IntPtr NativeFieldInfoPtr__minimum;

		// Token: 0x040033D8 RID: 13272
		private static readonly IntPtr NativeFieldInfoPtr__optional;

		// Token: 0x040033D9 RID: 13273
		private static readonly IntPtr NativeFieldInfoPtr__refuse;

		// Token: 0x040033DA RID: 13274
		private static readonly IntPtr NativeFieldInfoPtr__granted;

		// Token: 0x040033DB RID: 13275
		private static readonly IntPtr NativeFieldInfoPtr__denied;

		// Token: 0x040033DC RID: 13276
		private static readonly IntPtr NativeFieldInfoPtr_fromByteArray;

		// Token: 0x040033DD RID: 13277
		private static readonly IntPtr NativeFieldInfoPtr_assemblyName;

		// Token: 0x040033DE RID: 13278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040033DF RID: 13279
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040033E0 RID: 13280
		private static readonly IntPtr NativeMethodInfoPtr_LoadWithPartialNameInternal_Internal_Static_RuntimeAssembly_String_Evidence_byref_StackCrawlMark_0;

		// Token: 0x040033E1 RID: 13281
		private static readonly IntPtr NativeMethodInfoPtr_LoadWithPartialNameInternal_Internal_Static_RuntimeAssembly_AssemblyName_Evidence_byref_StackCrawlMark_0;

		// Token: 0x040033E2 RID: 13282
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_AssemblyName_Boolean_0;

		// Token: 0x040033E3 RID: 13283
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Public_Virtual_Type_String_Boolean_Boolean_0;

		// Token: 0x040033E4 RID: 13284
		private static readonly IntPtr NativeMethodInfoPtr_GetModule_Public_Virtual_Module_String_0;

		// Token: 0x040033E5 RID: 13285
		private static readonly IntPtr NativeMethodInfoPtr_GetModules_Public_Virtual_Il2CppReferenceArray_1_Module_Boolean_0;

		// Token: 0x040033E6 RID: 13286
		private static readonly IntPtr NativeMethodInfoPtr_GetExportedTypes_Public_Virtual_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040033E7 RID: 13287
		private static readonly IntPtr NativeMethodInfoPtr_GetAotId_Internal_Static_Il2CppStructArray_1_Byte_0;

		// Token: 0x040033E8 RID: 13288
		private static readonly IntPtr NativeMethodInfoPtr_get_code_base_Private_Static_String_Assembly_Boolean_0;

		// Token: 0x040033E9 RID: 13289
		private static readonly IntPtr NativeMethodInfoPtr_get_location_Private_String_0;

		// Token: 0x040033EA RID: 13290
		private static readonly IntPtr NativeMethodInfoPtr_get_fullname_Internal_Static_String_Assembly_0;

		// Token: 0x040033EB RID: 13291
		private static readonly IntPtr NativeMethodInfoPtr_GetAotIdInternal_Internal_Static_Boolean_Il2CppStructArray_1_Byte_0;

		// Token: 0x040033EC RID: 13292
		private static readonly IntPtr NativeMethodInfoPtr_get_ReflectionOnly_Public_Virtual_get_Boolean_0;

		// Token: 0x040033ED RID: 13293
		private static readonly IntPtr NativeMethodInfoPtr_GetCodeBase_Internal_Static_String_Assembly_Boolean_0;

		// Token: 0x040033EE RID: 13294
		private static readonly IntPtr NativeMethodInfoPtr_get_CodeBase_Public_Virtual_get_String_0;

		// Token: 0x040033EF RID: 13295
		private static readonly IntPtr NativeMethodInfoPtr_get_FullName_Public_Virtual_get_String_0;

		// Token: 0x040033F0 RID: 13296
		private static readonly IntPtr NativeMethodInfoPtr_get_MonoAssembly_Internal_Virtual_get_IntPtr_0;

		// Token: 0x040033F1 RID: 13297
		private static readonly IntPtr NativeMethodInfoPtr_get_Location_Public_Virtual_get_String_0;

		// Token: 0x040033F2 RID: 13298
		private static readonly IntPtr NativeMethodInfoPtr_GetManifestResourceInfoInternal_Private_Boolean_String_ManifestResourceInfo_0;

		// Token: 0x040033F3 RID: 13299
		private static readonly IntPtr NativeMethodInfoPtr_GetManifestResourceInfo_Public_Virtual_ManifestResourceInfo_String_0;

		// Token: 0x040033F4 RID: 13300
		private static readonly IntPtr NativeMethodInfoPtr_GetManifestResourceNames_Public_Virtual_Il2CppStringArray_0;

		// Token: 0x040033F5 RID: 13301
		private static readonly IntPtr NativeMethodInfoPtr_GetManifestResourceInternal_Internal_IntPtr_String_byref_Int32_byref_Module_0;

		// Token: 0x040033F6 RID: 13302
		private static readonly IntPtr NativeMethodInfoPtr_GetManifestResourceStream_Public_Virtual_Stream_String_0;

		// Token: 0x040033F7 RID: 13303
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0;

		// Token: 0x040033F8 RID: 13304
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x040033F9 RID: 13305
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x040033FA RID: 13306
		private static readonly IntPtr NativeMethodInfoPtr_GetModulesInternal_Internal_Virtual_Il2CppReferenceArray_1_Module_0;

		// Token: 0x040033FB RID: 13307
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040033FC RID: 13308
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040033FD RID: 13309
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x020006C1 RID: 1729
		public class UnmanagedMemoryStreamForModule : UnmanagedMemoryStream
		{
			// Token: 0x06005CAD RID: 23725 RVA: 0x001A43FC File Offset: 0x001A25FC
			// Note: this type is marked as 'beforefieldinit'.
			static UnmanagedMemoryStreamForModule()
			{
				Il2CppClassPointerStore<RuntimeAssembly.UnmanagedMemoryStreamForModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, "UnmanagedMemoryStreamForModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeAssembly.UnmanagedMemoryStreamForModule>.NativeClassPtr);
				RuntimeAssembly.UnmanagedMemoryStreamForModule.NativeFieldInfoPtr_module = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeAssembly.UnmanagedMemoryStreamForModule>.NativeClassPtr, "module");
				RuntimeAssembly.UnmanagedMemoryStreamForModule.NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_Int64_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly.UnmanagedMemoryStreamForModule>.NativeClassPtr, 100672793);
				RuntimeAssembly.UnmanagedMemoryStreamForModule.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly.UnmanagedMemoryStreamForModule>.NativeClassPtr, 100672794);
			}

			// Token: 0x06005CAE RID: 23726 RVA: 0x001A4464 File Offset: 0x001A2664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401151, XrefRangeEnd = 1401157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UnmanagedMemoryStreamForModule(byte* pointer, long length, Module module)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeAssembly.UnmanagedMemoryStreamForModule>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = pointer;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(module);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeAssembly.UnmanagedMemoryStreamForModule.NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_Int64_Module_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005CAF RID: 23727 RVA: 0x001A44CC File Offset: 0x001A26CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401157, XrefRangeEnd = 1401159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose(bool disposing)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref disposing;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeAssembly.UnmanagedMemoryStreamForModule.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005CB0 RID: 23728 RVA: 0x00021A34 File Offset: 0x0001FC34
			public UnmanagedMemoryStreamForModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017B9 RID: 6073
			// (get) Token: 0x06005CB1 RID: 23729 RVA: 0x001A4518 File Offset: 0x001A2718
			// (set) Token: 0x06005CB2 RID: 23730 RVA: 0x00021A3D File Offset: 0x0001FC3D
			public unsafe Module module
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeAssembly.UnmanagedMemoryStreamForModule.NativeFieldInfoPtr_module);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Module>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeAssembly.UnmanagedMemoryStreamForModule.NativeFieldInfoPtr_module), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004B45 RID: 19269
			private static readonly IntPtr NativeFieldInfoPtr_module;

			// Token: 0x04004B46 RID: 19270
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_Int64_Module_0;

			// Token: 0x04004B47 RID: 19271
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
		}
	}
}

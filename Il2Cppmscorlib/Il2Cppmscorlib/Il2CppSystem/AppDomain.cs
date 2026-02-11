using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Runtime.Remoting.Messaging;
using Il2CppSystem.Security.Policy;
using Il2CppSystem.Threading;

namespace Il2CppSystem
{
	// Token: 0x02000140 RID: 320
	public sealed class AppDomain : MarshalByRefObject
	{
		// Token: 0x060015E7 RID: 5607 RVA: 0x0009008C File Offset: 0x0008E28C
		// Note: this type is marked as 'beforefieldinit'.
		static AppDomain()
		{
			Il2CppClassPointerStore<AppDomain>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AppDomain");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppDomain>.NativeClassPtr);
			AppDomain.NativeFieldInfoPtr__mono_app_domain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_mono_app_domain");
			AppDomain.NativeFieldInfoPtr__process_guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_process_guid");
			AppDomain.NativeFieldInfoPtr_type_resolve_in_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "type_resolve_in_progress");
			AppDomain.NativeFieldInfoPtr_assembly_resolve_in_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "assembly_resolve_in_progress");
			AppDomain.NativeFieldInfoPtr_assembly_resolve_in_progress_refonly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "assembly_resolve_in_progress_refonly");
			AppDomain.NativeFieldInfoPtr__evidence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_evidence");
			AppDomain.NativeFieldInfoPtr__granted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_granted");
			AppDomain.NativeFieldInfoPtr__principalPolicy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_principalPolicy");
			AppDomain.NativeFieldInfoPtr_AssemblyLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "AssemblyLoad");
			AppDomain.NativeFieldInfoPtr_AssemblyResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "AssemblyResolve");
			AppDomain.NativeFieldInfoPtr_DomainUnload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "DomainUnload");
			AppDomain.NativeFieldInfoPtr_ProcessExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "ProcessExit");
			AppDomain.NativeFieldInfoPtr_ResourceResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "ResourceResolve");
			AppDomain.NativeFieldInfoPtr_TypeResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "TypeResolve");
			AppDomain.NativeFieldInfoPtr_UnhandledException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "UnhandledException");
			AppDomain.NativeFieldInfoPtr_FirstChanceException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "FirstChanceException");
			AppDomain.NativeFieldInfoPtr__domain_manager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_domain_manager");
			AppDomain.NativeFieldInfoPtr_ReflectionOnlyAssemblyResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "ReflectionOnlyAssemblyResolve");
			AppDomain.NativeFieldInfoPtr__activation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_activation");
			AppDomain.NativeFieldInfoPtr__applicationIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_applicationIdentity");
			AppDomain.NativeFieldInfoPtr_compatibility_switch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "compatibility_switch");
			AppDomain.NativeMethodInfoPtr_IsAppXModel_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667194);
			AppDomain.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667195);
			AppDomain.NativeMethodInfoPtr_getFriendlyName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667196);
			AppDomain.NativeMethodInfoPtr_getCurDomain_Private_Static_AppDomain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667197);
			AppDomain.NativeMethodInfoPtr_get_CurrentDomain_Public_Static_get_AppDomain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667198);
			AppDomain.NativeMethodInfoPtr_GetAssemblies_Private_Il2CppReferenceArray_1_Assembly_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667199);
			AppDomain.NativeMethodInfoPtr_GetAssemblies_Public_Virtual_Final_New_Il2CppReferenceArray_1_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667200);
			AppDomain.NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667201);
			AppDomain.NativeMethodInfoPtr_InitializeLifetimeService_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667202);
			AppDomain.NativeMethodInfoPtr_LoadAssembly_Internal_Assembly_String_Evidence_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667203);
			AppDomain.NativeMethodInfoPtr_LoadSatellite_Internal_Assembly_AssemblyName_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667204);
			AppDomain.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667205);
			AppDomain.NativeMethodInfoPtr_Load_Internal_Assembly_String_Evidence_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667206);
			AppDomain.NativeMethodInfoPtr_InternalSetDomainByID_Private_Static_AppDomain_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667207);
			AppDomain.NativeMethodInfoPtr_InternalSetDomain_Private_Static_AppDomain_AppDomain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667208);
			AppDomain.NativeMethodInfoPtr_InternalPushDomainRefByID_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667209);
			AppDomain.NativeMethodInfoPtr_InternalPopDomainRef_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667210);
			AppDomain.NativeMethodInfoPtr_InternalSetContext_Internal_Static_Context_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667211);
			AppDomain.NativeMethodInfoPtr_InternalGetContext_Internal_Static_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667212);
			AppDomain.NativeMethodInfoPtr_InternalGetDefaultContext_Internal_Static_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667213);
			AppDomain.NativeMethodInfoPtr_InternalGetProcessGuid_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667214);
			AppDomain.NativeMethodInfoPtr_InvokeInDomainByID_Internal_Static_Object_Int32_MethodInfo_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667215);
			AppDomain.NativeMethodInfoPtr_GetProcessGuid_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667216);
			AppDomain.NativeMethodInfoPtr_InternalIsFinalizingForUnload_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667217);
			AppDomain.NativeMethodInfoPtr_IsFinalizingForUnload_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667218);
			AppDomain.NativeMethodInfoPtr_getDomainID_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667219);
			AppDomain.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667220);
			AppDomain.NativeMethodInfoPtr_DoAssemblyLoad_Private_Void_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667221);
			AppDomain.NativeMethodInfoPtr_DoAssemblyResolve_Private_Assembly_String_Assembly_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667222);
			AppDomain.NativeMethodInfoPtr_DoTypeResolve_Internal_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667223);
			AppDomain.NativeMethodInfoPtr_DoResourceResolve_Internal_Assembly_String_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667224);
			AppDomain.NativeMethodInfoPtr_DoDomainUnload_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667225);
			AppDomain.NativeMethodInfoPtr_GetMarshalledDomainObjRef_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667226);
			AppDomain.NativeMethodInfoPtr_ProcessMessageInDomain_Internal_Void_Il2CppStructArray_1_Byte_CADMethodCallMessage_byref_Il2CppStructArray_1_Byte_byref_CADMethodReturnMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667227);
			AppDomain.NativeMethodInfoPtr_add_AssemblyResolve_Public_Virtual_Final_New_add_Void_ResolveEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667228);
			AppDomain.NativeMethodInfoPtr_remove_AssemblyResolve_Public_Virtual_Final_New_rem_Void_ResolveEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667229);
			AppDomain.NativeMethodInfoPtr_add_DomainUnload_Public_Virtual_Final_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667230);
			AppDomain.NativeMethodInfoPtr_remove_DomainUnload_Public_Virtual_Final_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667231);
			AppDomain.NativeMethodInfoPtr_add_UnhandledException_Public_Virtual_Final_New_add_Void_UnhandledExceptionEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667232);
			AppDomain.NativeMethodInfoPtr_remove_UnhandledException_Public_Virtual_Final_New_rem_Void_UnhandledExceptionEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667233);
			AppDomain.NativeMethodInfoPtr_get_IsHomogenous_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667234);
			AppDomain.NativeMethodInfoPtr_get_IsFullyTrusted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100667235);
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x000905A8 File Offset: 0x0008E7A8
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAppXModel()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_IsAppXModel_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x000905D8 File Offset: 0x0008E7D8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppDomain()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppDomain>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00090614 File Offset: 0x0008E814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343874, XrefRangeEnd = 1343875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string getFriendlyName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_getFriendlyName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x0009064C File Offset: 0x0008E84C
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 1343876, RefRangeEnd = 1343906, XrefRangeStart = 1343875, XrefRangeEnd = 1343876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AppDomain getCurDomain()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_getCurDomain_Private_Static_AppDomain_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AppDomain>(intPtr3) : null;
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x060015EC RID: 5612 RVA: 0x00090680 File Offset: 0x0008E880
		public unsafe static AppDomain CurrentDomain
		{
			[CallerCount(30)]
			[CachedScanResults(RefRangeStart = 1343876, RefRangeEnd = 1343906, XrefRangeStart = 1343876, XrefRangeEnd = 1343906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_get_CurrentDomain_Public_Static_get_AppDomain_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AppDomain>(intPtr3) : null;
			}
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x000906B4 File Offset: 0x0008E8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343906, XrefRangeEnd = 1343907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Assembly> GetAssemblies(bool refOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref refOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_GetAssemblies_Private_Il2CppReferenceArray_1_Assembly_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Assembly>>(intPtr3) : null;
			}
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00090700 File Offset: 0x0008E900
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1343908, RefRangeEnd = 1343921, XrefRangeStart = 1343907, XrefRangeEnd = 1343908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Assembly> GetAssemblies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_GetAssemblies_Public_Virtual_Final_New_Il2CppReferenceArray_1_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Assembly>>(intPtr3) : null;
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00090740 File Offset: 0x0008E940
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1343922, RefRangeEnd = 1343925, XrefRangeStart = 1343921, XrefRangeEnd = 1343922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetData(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00090790 File Offset: 0x0008E990
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object InitializeLifetimeService()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InitializeLifetimeService_Public_Virtual_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x000907D0 File Offset: 0x0008E9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343925, XrefRangeEnd = 1343926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyRef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(securityEvidence);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref refOnly;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_LoadAssembly_Internal_Assembly_String_Evidence_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00090850 File Offset: 0x0008EA50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1343929, RefRangeEnd = 1343930, XrefRangeStart = 1343926, XrefRangeEnd = 1343929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly LoadSatellite(AssemblyName assemblyRef, bool throwOnError, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assemblyRef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_LoadSatellite_Internal_Assembly_AssemblyName_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x000908BC File Offset: 0x0008EABC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1343932, RefRangeEnd = 1343934, XrefRangeStart = 1343930, XrefRangeEnd = 1343932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly Load(string assemblyString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Assembly_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x0009090C File Offset: 0x0008EB0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1343936, RefRangeEnd = 1343937, XrefRangeStart = 1343934, XrefRangeEnd = 1343936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemblySecurity);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref refonly;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_Load_Internal_Assembly_String_Evidence_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x0009098C File Offset: 0x0008EB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343937, XrefRangeEnd = 1343938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AppDomain InternalSetDomainByID(int domain_id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domain_id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalSetDomainByID_Private_Static_AppDomain_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AppDomain>(intPtr3) : null;
			}
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x000909CC File Offset: 0x0008EBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343938, XrefRangeEnd = 1343939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AppDomain InternalSetDomain(AppDomain context)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalSetDomain_Private_Static_AppDomain_AppDomain_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AppDomain>(intPtr3) : null;
			}
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00090A10 File Offset: 0x0008EC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343939, XrefRangeEnd = 1343940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalPushDomainRefByID(int domain_id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domain_id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalPushDomainRefByID_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x00090A44 File Offset: 0x0008EC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343940, XrefRangeEnd = 1343941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalPopDomainRef()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalPopDomainRef_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x00090A6C File Offset: 0x0008EC6C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1343942, RefRangeEnd = 1343955, XrefRangeStart = 1343941, XrefRangeEnd = 1343942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Context InternalSetContext(Context context)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalSetContext_Internal_Static_Context_Context_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00090AB0 File Offset: 0x0008ECB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1343956, RefRangeEnd = 1343959, XrefRangeStart = 1343955, XrefRangeEnd = 1343956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Context InternalGetContext()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalGetContext_Internal_Static_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00090AE4 File Offset: 0x0008ECE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1343956, RefRangeEnd = 1343959, XrefRangeStart = 1343956, XrefRangeEnd = 1343959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Context InternalGetDefaultContext()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalGetDefaultContext_Internal_Static_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00090B18 File Offset: 0x0008ED18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343959, XrefRangeEnd = 1343960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InternalGetProcessGuid(string newguid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newguid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalGetProcessGuid_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00090B54 File Offset: 0x0008ED54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1343971, RefRangeEnd = 1343972, XrefRangeStart = 1343960, XrefRangeEnd = 1343971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object InvokeInDomainByID(int domain_id, MethodInfo method, Object obj, Il2CppReferenceArray<Object> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domain_id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InvokeInDomainByID_Internal_Static_Object_Int32_MethodInfo_Object_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00090BCC File Offset: 0x0008EDCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1343981, RefRangeEnd = 1343982, XrefRangeStart = 1343972, XrefRangeEnd = 1343981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetProcessGuid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_GetProcessGuid_Internal_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00090BF8 File Offset: 0x0008EDF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429053, RefRangeEnd = 429054, XrefRangeStart = 429053, XrefRangeEnd = 429054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalIsFinalizingForUnload(int domain_id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domain_id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalIsFinalizingForUnload_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00090C38 File Offset: 0x0008EE38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1343984, RefRangeEnd = 1343985, XrefRangeStart = 1343982, XrefRangeEnd = 1343984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsFinalizingForUnload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_IsFinalizingForUnload_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00090C74 File Offset: 0x0008EE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343985, XrefRangeEnd = 1343986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int getDomainID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_getDomainID_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x00090CB0 File Offset: 0x0008EEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00090CE8 File Offset: 0x0008EEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343986, XrefRangeEnd = 1343990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoAssemblyLoad(Assembly assembly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assembly);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_DoAssemblyLoad_Private_Void_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00090D2C File Offset: 0x0008EF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343990, XrefRangeEnd = 1344038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requestingAssembly);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref refonly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_DoAssemblyResolve_Private_Assembly_String_Assembly_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x00090D9C File Offset: 0x0008EF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344038, XrefRangeEnd = 1344076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly DoTypeResolve(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_DoTypeResolve_Internal_Assembly_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00090DEC File Offset: 0x0008EFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344076, XrefRangeEnd = 1344085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly DoResourceResolve(string name, Assembly requesting)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requesting);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_DoResourceResolve_Internal_Assembly_String_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00090E50 File Offset: 0x0008F050
		[CallerCount(0)]
		public unsafe void DoDomainUnload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_DoDomainUnload_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x00090E84 File Offset: 0x0008F084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344085, XrefRangeEnd = 1344098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetMarshalledDomainObjRef()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_GetMarshalledDomainObjRef_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x00090EC4 File Offset: 0x0008F0C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1344118, RefRangeEnd = 1344119, XrefRangeStart = 1344098, XrefRangeEnd = 1344118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessMessageInDomain(Il2CppStructArray<byte> arrRequest, CADMethodCallMessage cadMsg, out Il2CppStructArray<byte> arrResponse, out CADMethodReturnMessage cadMrm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arrRequest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cadMsg);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_ProcessMessageInDomain_Internal_Void_Il2CppStructArray_1_Byte_CADMethodCallMessage_byref_Il2CppStructArray_1_Byte_byref_CADMethodReturnMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			arrResponse = ((intPtr5 == 0) ? null : new Il2CppStructArray<byte>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			cadMrm = ((intPtr6 == 0) ? null : new CADMethodReturnMessage(intPtr6));
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00090F60 File Offset: 0x0008F160
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1344123, RefRangeEnd = 1344124, XrefRangeStart = 1344119, XrefRangeEnd = 1344123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_AssemblyResolve(ResolveEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_add_AssemblyResolve_Public_Virtual_Final_New_add_Void_ResolveEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00090FA4 File Offset: 0x0008F1A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344124, XrefRangeEnd = 1344128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_AssemblyResolve(ResolveEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_remove_AssemblyResolve_Public_Virtual_Final_New_rem_Void_ResolveEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x00090FE8 File Offset: 0x0008F1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344128, XrefRangeEnd = 1344132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_DomainUnload(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_add_DomainUnload_Public_Virtual_Final_New_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x0009102C File Offset: 0x0008F22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344132, XrefRangeEnd = 1344136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_DomainUnload(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_remove_DomainUnload_Public_Virtual_Final_New_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x00091070 File Offset: 0x0008F270
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1344140, RefRangeEnd = 1344143, XrefRangeStart = 1344136, XrefRangeEnd = 1344140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_UnhandledException(UnhandledExceptionEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_add_UnhandledException_Public_Virtual_Final_New_add_Void_UnhandledExceptionEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x000910B4 File Offset: 0x0008F2B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1344147, RefRangeEnd = 1344149, XrefRangeStart = 1344143, XrefRangeEnd = 1344147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_UnhandledException(UnhandledExceptionEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_remove_UnhandledException_Public_Virtual_Final_New_rem_Void_UnhandledExceptionEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001610 RID: 5648 RVA: 0x000910F8 File Offset: 0x0008F2F8
		public unsafe bool IsHomogenous
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_get_IsHomogenous_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001611 RID: 5649 RVA: 0x00091134 File Offset: 0x0008F334
		public unsafe bool IsFullyTrusted
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_get_IsFullyTrusted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x00006CB4 File Offset: 0x00004EB4
		public AppDomain(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001613 RID: 5651 RVA: 0x00091170 File Offset: 0x0008F370
		// (set) Token: 0x06001614 RID: 5652 RVA: 0x00006CBD File Offset: 0x00004EBD
		public unsafe IntPtr _mono_app_domain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__mono_app_domain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__mono_app_domain)) = value;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001615 RID: 5653 RVA: 0x00091198 File Offset: 0x0008F398
		// (set) Token: 0x06001616 RID: 5654 RVA: 0x00006CD8 File Offset: 0x00004ED8
		public unsafe static string _process_guid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppDomain.NativeFieldInfoPtr__process_guid, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppDomain.NativeFieldInfoPtr__process_guid, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001617 RID: 5655 RVA: 0x000911B8 File Offset: 0x0008F3B8
		// (set) Token: 0x06001618 RID: 5656 RVA: 0x00006CEA File Offset: 0x00004EEA
		public unsafe static Dictionary<string, Object> type_resolve_in_progress
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppDomain.NativeFieldInfoPtr_type_resolve_in_progress, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppDomain.NativeFieldInfoPtr_type_resolve_in_progress, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001619 RID: 5657 RVA: 0x000911E0 File Offset: 0x0008F3E0
		// (set) Token: 0x0600161A RID: 5658 RVA: 0x00006CFC File Offset: 0x00004EFC
		public unsafe static Dictionary<string, Object> assembly_resolve_in_progress
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppDomain.NativeFieldInfoPtr_assembly_resolve_in_progress, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppDomain.NativeFieldInfoPtr_assembly_resolve_in_progress, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x0600161B RID: 5659 RVA: 0x00091208 File Offset: 0x0008F408
		// (set) Token: 0x0600161C RID: 5660 RVA: 0x00006D0E File Offset: 0x00004F0E
		public unsafe static Dictionary<string, Object> assembly_resolve_in_progress_refonly
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppDomain.NativeFieldInfoPtr_assembly_resolve_in_progress_refonly, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppDomain.NativeFieldInfoPtr_assembly_resolve_in_progress_refonly, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x0600161D RID: 5661 RVA: 0x00091230 File Offset: 0x0008F430
		// (set) Token: 0x0600161E RID: 5662 RVA: 0x00006D20 File Offset: 0x00004F20
		public unsafe Object _evidence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__evidence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__evidence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x00091260 File Offset: 0x0008F460
		// (set) Token: 0x06001620 RID: 5664 RVA: 0x00006D3F File Offset: 0x00004F3F
		public unsafe Object _granted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__granted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__granted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x00091290 File Offset: 0x0008F490
		// (set) Token: 0x06001622 RID: 5666 RVA: 0x00006D5E File Offset: 0x00004F5E
		public unsafe int _principalPolicy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__principalPolicy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__principalPolicy)) = value;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001623 RID: 5667 RVA: 0x000912B8 File Offset: 0x0008F4B8
		// (set) Token: 0x06001624 RID: 5668 RVA: 0x00006D79 File Offset: 0x00004F79
		public unsafe AssemblyLoadEventHandler AssemblyLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_AssemblyLoad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssemblyLoadEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_AssemblyLoad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001625 RID: 5669 RVA: 0x000912E8 File Offset: 0x0008F4E8
		// (set) Token: 0x06001626 RID: 5670 RVA: 0x00006D98 File Offset: 0x00004F98
		public unsafe ResolveEventHandler AssemblyResolve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_AssemblyResolve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_AssemblyResolve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001627 RID: 5671 RVA: 0x00091318 File Offset: 0x0008F518
		// (set) Token: 0x06001628 RID: 5672 RVA: 0x00006DB7 File Offset: 0x00004FB7
		public unsafe EventHandler DomainUnload
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_DomainUnload);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_DomainUnload), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001629 RID: 5673 RVA: 0x00091348 File Offset: 0x0008F548
		// (set) Token: 0x0600162A RID: 5674 RVA: 0x00006DD6 File Offset: 0x00004FD6
		public unsafe EventHandler ProcessExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_ProcessExit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_ProcessExit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x0600162B RID: 5675 RVA: 0x00091378 File Offset: 0x0008F578
		// (set) Token: 0x0600162C RID: 5676 RVA: 0x00006DF5 File Offset: 0x00004FF5
		public unsafe ResolveEventHandler ResourceResolve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_ResourceResolve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_ResourceResolve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x0600162D RID: 5677 RVA: 0x000913A8 File Offset: 0x0008F5A8
		// (set) Token: 0x0600162E RID: 5678 RVA: 0x00006E14 File Offset: 0x00005014
		public unsafe ResolveEventHandler TypeResolve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_TypeResolve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_TypeResolve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x0600162F RID: 5679 RVA: 0x000913D8 File Offset: 0x0008F5D8
		// (set) Token: 0x06001630 RID: 5680 RVA: 0x00006E33 File Offset: 0x00005033
		public unsafe UnhandledExceptionEventHandler UnhandledException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_UnhandledException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnhandledExceptionEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_UnhandledException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001631 RID: 5681 RVA: 0x00091408 File Offset: 0x0008F608
		// (set) Token: 0x06001632 RID: 5682 RVA: 0x00006E52 File Offset: 0x00005052
		public unsafe EventHandler<FirstChanceExceptionEventArgs> FirstChanceException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_FirstChanceException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<FirstChanceExceptionEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_FirstChanceException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x00091438 File Offset: 0x0008F638
		// (set) Token: 0x06001634 RID: 5684 RVA: 0x00006E71 File Offset: 0x00005071
		public unsafe Object _domain_manager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__domain_manager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__domain_manager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001635 RID: 5685 RVA: 0x00091468 File Offset: 0x0008F668
		// (set) Token: 0x06001636 RID: 5686 RVA: 0x00006E90 File Offset: 0x00005090
		public unsafe ResolveEventHandler ReflectionOnlyAssemblyResolve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_ReflectionOnlyAssemblyResolve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_ReflectionOnlyAssemblyResolve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001637 RID: 5687 RVA: 0x00091498 File Offset: 0x0008F698
		// (set) Token: 0x06001638 RID: 5688 RVA: 0x00006EAF File Offset: 0x000050AF
		public unsafe Object _activation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__activation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__activation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001639 RID: 5689 RVA: 0x000914C8 File Offset: 0x0008F6C8
		// (set) Token: 0x0600163A RID: 5690 RVA: 0x00006ECE File Offset: 0x000050CE
		public unsafe Object _applicationIdentity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__applicationIdentity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__applicationIdentity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x0600163B RID: 5691 RVA: 0x000914F8 File Offset: 0x0008F6F8
		// (set) Token: 0x0600163C RID: 5692 RVA: 0x00006EED File Offset: 0x000050ED
		public unsafe List<string> compatibility_switch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_compatibility_switch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_compatibility_switch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001303 RID: 4867
		private static readonly IntPtr NativeFieldInfoPtr__mono_app_domain;

		// Token: 0x04001304 RID: 4868
		private static readonly IntPtr NativeFieldInfoPtr__process_guid;

		// Token: 0x04001305 RID: 4869
		private static readonly IntPtr NativeFieldInfoPtr_type_resolve_in_progress;

		// Token: 0x04001306 RID: 4870
		private static readonly IntPtr NativeFieldInfoPtr_assembly_resolve_in_progress;

		// Token: 0x04001307 RID: 4871
		private static readonly IntPtr NativeFieldInfoPtr_assembly_resolve_in_progress_refonly;

		// Token: 0x04001308 RID: 4872
		private static readonly IntPtr NativeFieldInfoPtr__evidence;

		// Token: 0x04001309 RID: 4873
		private static readonly IntPtr NativeFieldInfoPtr__granted;

		// Token: 0x0400130A RID: 4874
		private static readonly IntPtr NativeFieldInfoPtr__principalPolicy;

		// Token: 0x0400130B RID: 4875
		private static readonly IntPtr NativeFieldInfoPtr_AssemblyLoad;

		// Token: 0x0400130C RID: 4876
		private static readonly IntPtr NativeFieldInfoPtr_AssemblyResolve;

		// Token: 0x0400130D RID: 4877
		private static readonly IntPtr NativeFieldInfoPtr_DomainUnload;

		// Token: 0x0400130E RID: 4878
		private static readonly IntPtr NativeFieldInfoPtr_ProcessExit;

		// Token: 0x0400130F RID: 4879
		private static readonly IntPtr NativeFieldInfoPtr_ResourceResolve;

		// Token: 0x04001310 RID: 4880
		private static readonly IntPtr NativeFieldInfoPtr_TypeResolve;

		// Token: 0x04001311 RID: 4881
		private static readonly IntPtr NativeFieldInfoPtr_UnhandledException;

		// Token: 0x04001312 RID: 4882
		private static readonly IntPtr NativeFieldInfoPtr_FirstChanceException;

		// Token: 0x04001313 RID: 4883
		private static readonly IntPtr NativeFieldInfoPtr__domain_manager;

		// Token: 0x04001314 RID: 4884
		private static readonly IntPtr NativeFieldInfoPtr_ReflectionOnlyAssemblyResolve;

		// Token: 0x04001315 RID: 4885
		private static readonly IntPtr NativeFieldInfoPtr__activation;

		// Token: 0x04001316 RID: 4886
		private static readonly IntPtr NativeFieldInfoPtr__applicationIdentity;

		// Token: 0x04001317 RID: 4887
		private static readonly IntPtr NativeFieldInfoPtr_compatibility_switch;

		// Token: 0x04001318 RID: 4888
		private static readonly IntPtr NativeMethodInfoPtr_IsAppXModel_Internal_Static_Boolean_0;

		// Token: 0x04001319 RID: 4889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400131A RID: 4890
		private static readonly IntPtr NativeMethodInfoPtr_getFriendlyName_Private_String_0;

		// Token: 0x0400131B RID: 4891
		private static readonly IntPtr NativeMethodInfoPtr_getCurDomain_Private_Static_AppDomain_0;

		// Token: 0x0400131C RID: 4892
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDomain_Public_Static_get_AppDomain_0;

		// Token: 0x0400131D RID: 4893
		private static readonly IntPtr NativeMethodInfoPtr_GetAssemblies_Private_Il2CppReferenceArray_1_Assembly_Boolean_0;

		// Token: 0x0400131E RID: 4894
		private static readonly IntPtr NativeMethodInfoPtr_GetAssemblies_Public_Virtual_Final_New_Il2CppReferenceArray_1_Assembly_0;

		// Token: 0x0400131F RID: 4895
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_Object_String_0;

		// Token: 0x04001320 RID: 4896
		private static readonly IntPtr NativeMethodInfoPtr_InitializeLifetimeService_Public_Virtual_Object_0;

		// Token: 0x04001321 RID: 4897
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssembly_Internal_Assembly_String_Evidence_Boolean_byref_StackCrawlMark_0;

		// Token: 0x04001322 RID: 4898
		private static readonly IntPtr NativeMethodInfoPtr_LoadSatellite_Internal_Assembly_AssemblyName_Boolean_byref_StackCrawlMark_0;

		// Token: 0x04001323 RID: 4899
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Assembly_String_0;

		// Token: 0x04001324 RID: 4900
		private static readonly IntPtr NativeMethodInfoPtr_Load_Internal_Assembly_String_Evidence_Boolean_byref_StackCrawlMark_0;

		// Token: 0x04001325 RID: 4901
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetDomainByID_Private_Static_AppDomain_Int32_0;

		// Token: 0x04001326 RID: 4902
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetDomain_Private_Static_AppDomain_AppDomain_0;

		// Token: 0x04001327 RID: 4903
		private static readonly IntPtr NativeMethodInfoPtr_InternalPushDomainRefByID_Internal_Static_Void_Int32_0;

		// Token: 0x04001328 RID: 4904
		private static readonly IntPtr NativeMethodInfoPtr_InternalPopDomainRef_Internal_Static_Void_0;

		// Token: 0x04001329 RID: 4905
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetContext_Internal_Static_Context_Context_0;

		// Token: 0x0400132A RID: 4906
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetContext_Internal_Static_Context_0;

		// Token: 0x0400132B RID: 4907
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetDefaultContext_Internal_Static_Context_0;

		// Token: 0x0400132C RID: 4908
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetProcessGuid_Internal_Static_String_String_0;

		// Token: 0x0400132D RID: 4909
		private static readonly IntPtr NativeMethodInfoPtr_InvokeInDomainByID_Internal_Static_Object_Int32_MethodInfo_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400132E RID: 4910
		private static readonly IntPtr NativeMethodInfoPtr_GetProcessGuid_Internal_Static_String_0;

		// Token: 0x0400132F RID: 4911
		private static readonly IntPtr NativeMethodInfoPtr_InternalIsFinalizingForUnload_Private_Static_Boolean_Int32_0;

		// Token: 0x04001330 RID: 4912
		private static readonly IntPtr NativeMethodInfoPtr_IsFinalizingForUnload_Public_Boolean_0;

		// Token: 0x04001331 RID: 4913
		private static readonly IntPtr NativeMethodInfoPtr_getDomainID_Private_Int32_0;

		// Token: 0x04001332 RID: 4914
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001333 RID: 4915
		private static readonly IntPtr NativeMethodInfoPtr_DoAssemblyLoad_Private_Void_Assembly_0;

		// Token: 0x04001334 RID: 4916
		private static readonly IntPtr NativeMethodInfoPtr_DoAssemblyResolve_Private_Assembly_String_Assembly_Boolean_0;

		// Token: 0x04001335 RID: 4917
		private static readonly IntPtr NativeMethodInfoPtr_DoTypeResolve_Internal_Assembly_String_0;

		// Token: 0x04001336 RID: 4918
		private static readonly IntPtr NativeMethodInfoPtr_DoResourceResolve_Internal_Assembly_String_Assembly_0;

		// Token: 0x04001337 RID: 4919
		private static readonly IntPtr NativeMethodInfoPtr_DoDomainUnload_Private_Void_0;

		// Token: 0x04001338 RID: 4920
		private static readonly IntPtr NativeMethodInfoPtr_GetMarshalledDomainObjRef_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001339 RID: 4921
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMessageInDomain_Internal_Void_Il2CppStructArray_1_Byte_CADMethodCallMessage_byref_Il2CppStructArray_1_Byte_byref_CADMethodReturnMessage_0;

		// Token: 0x0400133A RID: 4922
		private static readonly IntPtr NativeMethodInfoPtr_add_AssemblyResolve_Public_Virtual_Final_New_add_Void_ResolveEventHandler_0;

		// Token: 0x0400133B RID: 4923
		private static readonly IntPtr NativeMethodInfoPtr_remove_AssemblyResolve_Public_Virtual_Final_New_rem_Void_ResolveEventHandler_0;

		// Token: 0x0400133C RID: 4924
		private static readonly IntPtr NativeMethodInfoPtr_add_DomainUnload_Public_Virtual_Final_New_add_Void_EventHandler_0;

		// Token: 0x0400133D RID: 4925
		private static readonly IntPtr NativeMethodInfoPtr_remove_DomainUnload_Public_Virtual_Final_New_rem_Void_EventHandler_0;

		// Token: 0x0400133E RID: 4926
		private static readonly IntPtr NativeMethodInfoPtr_add_UnhandledException_Public_Virtual_Final_New_add_Void_UnhandledExceptionEventHandler_0;

		// Token: 0x0400133F RID: 4927
		private static readonly IntPtr NativeMethodInfoPtr_remove_UnhandledException_Public_Virtual_Final_New_rem_Void_UnhandledExceptionEventHandler_0;

		// Token: 0x04001340 RID: 4928
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHomogenous_Public_get_Boolean_0;

		// Token: 0x04001341 RID: 4929
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFullyTrusted_Public_get_Boolean_0;
	}
}

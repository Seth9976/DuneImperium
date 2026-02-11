using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem
{
	// Token: 0x02000142 RID: 322
	public static class Environment : Object
	{
		// Token: 0x06001641 RID: 5697 RVA: 0x00091544 File Offset: 0x0008F744
		// Note: this type is marked as 'beforefieldinit'.
		static Environment()
		{
			Il2CppClassPointerStore<Environment>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Environment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Environment>.NativeClassPtr);
			Environment.NativeFieldInfoPtr_mono_corlib_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment>.NativeClassPtr, "mono_corlib_version");
			Environment.NativeFieldInfoPtr_nl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment>.NativeClassPtr, "nl");
			Environment.NativeFieldInfoPtr_os = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment>.NativeClassPtr, "os");
			Environment.NativeMethodInfoPtr_GetResourceString_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667236);
			Environment.NativeMethodInfoPtr_GetResourceString_Internal_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667237);
			Environment.NativeMethodInfoPtr_GetResourceStringEncodingName_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667238);
			Environment.NativeMethodInfoPtr_get_CurrentDirectory_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667239);
			Environment.NativeMethodInfoPtr_get_CurrentManagedThreadId_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667240);
			Environment.NativeMethodInfoPtr_get_HasShutdownStarted_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667241);
			Environment.NativeMethodInfoPtr_get_MachineName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667242);
			Environment.NativeMethodInfoPtr_GetNewLine_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667243);
			Environment.NativeMethodInfoPtr_get_NewLine_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667244);
			Environment.NativeMethodInfoPtr_get_Platform_Internal_Static_get_PlatformID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667245);
			Environment.NativeMethodInfoPtr_GetOSVersionString_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667246);
			Environment.NativeMethodInfoPtr_get_OSVersion_Public_Static_get_OperatingSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667247);
			Environment.NativeMethodInfoPtr_CreateVersionFromString_Internal_Static_Version_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667248);
			Environment.NativeMethodInfoPtr_get_StackTrace_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667249);
			Environment.NativeMethodInfoPtr_get_SystemDirectory_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667250);
			Environment.NativeMethodInfoPtr_get_TickCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667251);
			Environment.NativeMethodInfoPtr_get_UserDomainName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667252);
			Environment.NativeMethodInfoPtr_get_UserName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667253);
			Environment.NativeMethodInfoPtr_get_Version_Public_Static_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667254);
			Environment.NativeMethodInfoPtr_Exit_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667255);
			Environment.NativeMethodInfoPtr_ExpandEnvironmentVariables_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667256);
			Environment.NativeMethodInfoPtr_GetCommandLineArgs_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667257);
			Environment.NativeMethodInfoPtr_internalGetEnvironmentVariable_native_Internal_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667258);
			Environment.NativeMethodInfoPtr_internalGetEnvironmentVariable_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667259);
			Environment.NativeMethodInfoPtr_GetEnvironmentVariable_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667260);
			Environment.NativeMethodInfoPtr_GetEnvironmentVariablesNoCase_Private_Static_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667261);
			Environment.NativeMethodInfoPtr_GetEnvironmentVariables_Public_Static_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667262);
			Environment.NativeMethodInfoPtr_GetFolderPath_Public_Static_String_SpecialFolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667263);
			Environment.NativeMethodInfoPtr_GetWindowsFolderPath_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667264);
			Environment.NativeMethodInfoPtr_GetFolderPath_Public_Static_String_SpecialFolder_SpecialFolderOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667265);
			Environment.NativeMethodInfoPtr_ReadXdgUserDir_Private_Static_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667266);
			Environment.NativeMethodInfoPtr_UnixGetFolderPath_Internal_Static_String_SpecialFolder_SpecialFolderOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667267);
			Environment.NativeMethodInfoPtr_SetEnvironmentVariable_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667268);
			Environment.NativeMethodInfoPtr_InternalSetEnvironmentVariable_Internal_Static_Void_ptr_Char_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667269);
			Environment.NativeMethodInfoPtr_InternalSetEnvironmentVariable_Internal_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667270);
			Environment.NativeMethodInfoPtr_FailFast_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667271);
			Environment.NativeMethodInfoPtr_FailFast_Public_Static_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667272);
			Environment.NativeMethodInfoPtr_FailFast_Internal_Static_Void_String_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667273);
			Environment.NativeMethodInfoPtr_get_ProcessorCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667274);
			Environment.NativeMethodInfoPtr_get_IsRunningOnWindows_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667275);
			Environment.NativeMethodInfoPtr_GetEnvironmentVariableNames_Private_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667276);
			Environment.NativeMethodInfoPtr_GetMachineConfigPath_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667277);
			Environment.NativeMethodInfoPtr_internalGetHome_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667278);
			Environment.NativeMethodInfoPtr_GetPageSize_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667279);
			Environment.NativeMethodInfoPtr_get_IsUnix_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667280);
			Environment.NativeMethodInfoPtr_GetStackTrace_Internal_Static_String_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667281);
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00091948 File Offset: 0x0008FB48
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetResourceString(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetResourceString_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00091984 File Offset: 0x0008FB84
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 1344154, RefRangeEnd = 1344190, XrefRangeStart = 1344149, XrefRangeEnd = 1344154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetResourceString(string key, [Optional] Il2CppReferenceArray<Object> values)
		{
			if (values == null)
			{
				values = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetResourceString_Internal_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x000919E0 File Offset: 0x0008FBE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1344199, RefRangeEnd = 1344200, XrefRangeStart = 1344190, XrefRangeEnd = 1344199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetResourceStringEncodingName(int codePage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codePage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetResourceStringEncodingName_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001645 RID: 5701 RVA: 0x00091A18 File Offset: 0x0008FC18
		public unsafe static string CurrentDirectory
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1344201, RefRangeEnd = 1344204, XrefRangeStart = 1344200, XrefRangeEnd = 1344201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_CurrentDirectory_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001646 RID: 5702 RVA: 0x00091A44 File Offset: 0x0008FC44
		public unsafe static int CurrentManagedThreadId
		{
			[CallerCount(7918)]
			[CachedScanResults(RefRangeStart = 442884, RefRangeEnd = 450802, XrefRangeStart = 442884, XrefRangeEnd = 450802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_CurrentManagedThreadId_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001647 RID: 5703 RVA: 0x00091A74 File Offset: 0x0008FC74
		public unsafe static bool HasShutdownStarted
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1344205, RefRangeEnd = 1344208, XrefRangeStart = 1344204, XrefRangeEnd = 1344205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_HasShutdownStarted_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x00091AA4 File Offset: 0x0008FCA4
		public unsafe static string MachineName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1344209, RefRangeEnd = 1344212, XrefRangeStart = 1344208, XrefRangeEnd = 1344209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_MachineName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x00091AD0 File Offset: 0x0008FCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344212, XrefRangeEnd = 1344213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNewLine()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetNewLine_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x00091AFC File Offset: 0x0008FCFC
		public unsafe static string NewLine
		{
			[CallerCount(110)]
			[CachedScanResults(RefRangeStart = 1344220, RefRangeEnd = 1344330, XrefRangeStart = 1344213, XrefRangeEnd = 1344220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_NewLine_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x0600164B RID: 5707 RVA: 0x00091B28 File Offset: 0x0008FD28
		public unsafe static PlatformID Platform
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344330, XrefRangeEnd = 1344331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_Platform_Internal_Static_get_PlatformID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00091B58 File Offset: 0x0008FD58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344331, XrefRangeEnd = 1344332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetOSVersionString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetOSVersionString_Internal_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x0600164D RID: 5709 RVA: 0x00091B84 File Offset: 0x0008FD84
		public unsafe static OperatingSystem OSVersion
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 1344371, RefRangeEnd = 1344387, XrefRangeStart = 1344332, XrefRangeEnd = 1344371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_OSVersion_Public_Static_get_OperatingSystem_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OperatingSystem>(intPtr3) : null;
			}
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x00091BB8 File Offset: 0x0008FDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344387, XrefRangeEnd = 1344408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Version CreateVersionFromString(string info)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_CreateVersionFromString_Internal_Static_Version_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x0600164F RID: 5711 RVA: 0x00091BFC File Offset: 0x0008FDFC
		public unsafe static string StackTrace
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1344413, RefRangeEnd = 1344415, XrefRangeStart = 1344408, XrefRangeEnd = 1344413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_StackTrace_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x00091C28 File Offset: 0x0008FE28
		public unsafe static string SystemDirectory
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1344462, RefRangeEnd = 1344463, XrefRangeStart = 1344415, XrefRangeEnd = 1344462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_SystemDirectory_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001651 RID: 5713 RVA: 0x00091C54 File Offset: 0x0008FE54
		public unsafe static int TickCount
		{
			[CallerCount(55)]
			[CachedScanResults(RefRangeStart = 1344464, RefRangeEnd = 1344519, XrefRangeStart = 1344463, XrefRangeEnd = 1344464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_TickCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001652 RID: 5714 RVA: 0x00091C84 File Offset: 0x0008FE84
		public unsafe static string UserDomainName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1344209, RefRangeEnd = 1344212, XrefRangeStart = 1344209, XrefRangeEnd = 1344212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_UserDomainName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001653 RID: 5715 RVA: 0x00091CB0 File Offset: 0x0008FEB0
		public unsafe static string UserName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1344520, RefRangeEnd = 1344521, XrefRangeStart = 1344519, XrefRangeEnd = 1344520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_UserName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001654 RID: 5716 RVA: 0x00091CDC File Offset: 0x0008FEDC
		public unsafe static Version Version
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1344527, RefRangeEnd = 1344528, XrefRangeStart = 1344521, XrefRangeEnd = 1344527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_Version_Public_Static_get_Version_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00091D10 File Offset: 0x0008FF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344528, XrefRangeEnd = 1344529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Exit(int exitCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref exitCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_Exit_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x00091D44 File Offset: 0x0008FF44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1344561, RefRangeEnd = 1344562, XrefRangeStart = 1344529, XrefRangeEnd = 1344561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ExpandEnvironmentVariables(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_ExpandEnvironmentVariables_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00091D80 File Offset: 0x0008FF80
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1344563, RefRangeEnd = 1344568, XrefRangeStart = 1344562, XrefRangeEnd = 1344563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetCommandLineArgs()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetCommandLineArgs_Public_Static_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x00091DB4 File Offset: 0x0008FFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344568, XrefRangeEnd = 1344569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string internalGetEnvironmentVariable_native(IntPtr variable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref variable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_internalGetEnvironmentVariable_native_Internal_Static_String_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x00091DEC File Offset: 0x0008FFEC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1344575, RefRangeEnd = 1344589, XrefRangeStart = 1344569, XrefRangeEnd = 1344575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string internalGetEnvironmentVariable(string variable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_internalGetEnvironmentVariable_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x00091E28 File Offset: 0x00090028
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1344590, RefRangeEnd = 1344603, XrefRangeStart = 1344589, XrefRangeEnd = 1344590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetEnvironmentVariable(string variable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetEnvironmentVariable_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x00091E64 File Offset: 0x00090064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344603, XrefRangeEnd = 1344612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Hashtable GetEnvironmentVariablesNoCase()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetEnvironmentVariablesNoCase_Private_Static_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x00091E98 File Offset: 0x00090098
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1344619, RefRangeEnd = 1344620, XrefRangeStart = 1344612, XrefRangeEnd = 1344619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IDictionary GetEnvironmentVariables()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetEnvironmentVariables_Public_Static_IDictionary_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x00091ECC File Offset: 0x000900CC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1344624, RefRangeEnd = 1344635, XrefRangeStart = 1344620, XrefRangeEnd = 1344624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFolderPath(Environment.SpecialFolder folder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref folder;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetFolderPath_Public_Static_String_SpecialFolder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00091F04 File Offset: 0x00090104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344635, XrefRangeEnd = 1344636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetWindowsFolderPath(int folder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref folder;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetWindowsFolderPath_Private_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x00091F3C File Offset: 0x0009013C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344636, XrefRangeEnd = 1344640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref folder;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref option;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetFolderPath_Public_Static_String_SpecialFolder_SpecialFolderOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x00091F84 File Offset: 0x00090184
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1344688, RefRangeEnd = 1344689, XrefRangeStart = 1344640, XrefRangeEnd = 1344688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(config_dir);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(home_dir);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_ReadXdgUserDir_Private_Static_String_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x00091FF8 File Offset: 0x000901F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1344744, RefRangeEnd = 1344746, XrefRangeStart = 1344689, XrefRangeEnd = 1344744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UnixGetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref folder;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref option;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_UnixGetFolderPath_Internal_Static_String_SpecialFolder_SpecialFolderOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x00092040 File Offset: 0x00090240
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1344782, RefRangeEnd = 1344786, XrefRangeStart = 1344746, XrefRangeEnd = 1344782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetEnvironmentVariable(string variable, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_SetEnvironmentVariable_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x00092088 File Offset: 0x00090288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344786, XrefRangeEnd = 1344787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetEnvironmentVariable(char* variable, int variable_length, char* value, int value_length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = variable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref variable_length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = value;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value_length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_InternalSetEnvironmentVariable_Internal_Static_Void_ptr_Char_Int32_ptr_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x000920E4 File Offset: 0x000902E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344787, XrefRangeEnd = 1344791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetEnvironmentVariable(string variable, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_InternalSetEnvironmentVariable_Internal_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x0009212C File Offset: 0x0009032C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1344792, RefRangeEnd = 1344793, XrefRangeStart = 1344791, XrefRangeEnd = 1344792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FailFast(string message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_FailFast_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x00092164 File Offset: 0x00090364
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1344794, RefRangeEnd = 1344795, XrefRangeStart = 1344793, XrefRangeEnd = 1344794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FailFast(string message, Exception exception)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_FailFast_Public_Static_Void_String_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x000921AC File Offset: 0x000903AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344795, XrefRangeEnd = 1344796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FailFast(string message, Exception exception, string errorSource)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(errorSource);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_FailFast_Internal_Static_Void_String_Exception_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001668 RID: 5736 RVA: 0x00092208 File Offset: 0x00090408
		public unsafe static int ProcessorCount
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1344797, RefRangeEnd = 1344801, XrefRangeStart = 1344796, XrefRangeEnd = 1344797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_ProcessorCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001669 RID: 5737 RVA: 0x00092238 File Offset: 0x00090438
		public unsafe static bool IsRunningOnWindows
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1344802, RefRangeEnd = 1344810, XrefRangeStart = 1344801, XrefRangeEnd = 1344802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_IsRunningOnWindows_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x00092268 File Offset: 0x00090468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344810, XrefRangeEnd = 1344811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetEnvironmentVariableNames()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetEnvironmentVariableNames_Private_Static_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x0009229C File Offset: 0x0009049C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1344812, RefRangeEnd = 1344813, XrefRangeStart = 1344811, XrefRangeEnd = 1344812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMachineConfigPath()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetMachineConfigPath_Internal_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x000922C8 File Offset: 0x000904C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344813, XrefRangeEnd = 1344814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string internalGetHome()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_internalGetHome_Internal_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x000922F4 File Offset: 0x000904F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1344815, RefRangeEnd = 1344817, XrefRangeStart = 1344814, XrefRangeEnd = 1344815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPageSize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetPageSize_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x0600166E RID: 5742 RVA: 0x00092324 File Offset: 0x00090524
		public unsafe static bool IsUnix
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1344818, RefRangeEnd = 1344819, XrefRangeStart = 1344817, XrefRangeEnd = 1344818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_IsUnix_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x00092354 File Offset: 0x00090554
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1344827, RefRangeEnd = 1344831, XrefRangeStart = 1344819, XrefRangeEnd = 1344827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStackTrace(Exception e, bool needFileInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needFileInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetStackTrace_Internal_Static_String_Exception_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x00006F5C File Offset: 0x0000515C
		public static string GetResourceString(string key, params Object[] values)
		{
			return Environment.GetResourceString(key, new Il2CppReferenceArray<Object>(values));
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00006F6A File Offset: 0x0000516A
		public Environment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001672 RID: 5746 RVA: 0x000923A0 File Offset: 0x000905A0
		// (set) Token: 0x06001673 RID: 5747 RVA: 0x00006F73 File Offset: 0x00005173
		public unsafe static string mono_corlib_version
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Environment.NativeFieldInfoPtr_mono_corlib_version, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Environment.NativeFieldInfoPtr_mono_corlib_version, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001674 RID: 5748 RVA: 0x000923C0 File Offset: 0x000905C0
		// (set) Token: 0x06001675 RID: 5749 RVA: 0x00006F85 File Offset: 0x00005185
		public unsafe static string nl
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Environment.NativeFieldInfoPtr_nl, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Environment.NativeFieldInfoPtr_nl, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001676 RID: 5750 RVA: 0x000923E0 File Offset: 0x000905E0
		// (set) Token: 0x06001677 RID: 5751 RVA: 0x00006F97 File Offset: 0x00005197
		public unsafe static OperatingSystem os
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Environment.NativeFieldInfoPtr_os, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OperatingSystem>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Environment.NativeFieldInfoPtr_os, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001343 RID: 4931
		private static readonly IntPtr NativeFieldInfoPtr_mono_corlib_version;

		// Token: 0x04001344 RID: 4932
		private static readonly IntPtr NativeFieldInfoPtr_nl;

		// Token: 0x04001345 RID: 4933
		private static readonly IntPtr NativeFieldInfoPtr_os;

		// Token: 0x04001346 RID: 4934
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceString_Internal_Static_String_String_0;

		// Token: 0x04001347 RID: 4935
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceString_Internal_Static_String_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001348 RID: 4936
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceStringEncodingName_Internal_Static_String_Int32_0;

		// Token: 0x04001349 RID: 4937
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDirectory_Public_Static_get_String_0;

		// Token: 0x0400134A RID: 4938
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentManagedThreadId_Public_Static_get_Int32_0;

		// Token: 0x0400134B RID: 4939
		private static readonly IntPtr NativeMethodInfoPtr_get_HasShutdownStarted_Public_Static_get_Boolean_0;

		// Token: 0x0400134C RID: 4940
		private static readonly IntPtr NativeMethodInfoPtr_get_MachineName_Public_Static_get_String_0;

		// Token: 0x0400134D RID: 4941
		private static readonly IntPtr NativeMethodInfoPtr_GetNewLine_Private_Static_String_0;

		// Token: 0x0400134E RID: 4942
		private static readonly IntPtr NativeMethodInfoPtr_get_NewLine_Public_Static_get_String_0;

		// Token: 0x0400134F RID: 4943
		private static readonly IntPtr NativeMethodInfoPtr_get_Platform_Internal_Static_get_PlatformID_0;

		// Token: 0x04001350 RID: 4944
		private static readonly IntPtr NativeMethodInfoPtr_GetOSVersionString_Internal_Static_String_0;

		// Token: 0x04001351 RID: 4945
		private static readonly IntPtr NativeMethodInfoPtr_get_OSVersion_Public_Static_get_OperatingSystem_0;

		// Token: 0x04001352 RID: 4946
		private static readonly IntPtr NativeMethodInfoPtr_CreateVersionFromString_Internal_Static_Version_String_0;

		// Token: 0x04001353 RID: 4947
		private static readonly IntPtr NativeMethodInfoPtr_get_StackTrace_Public_Static_get_String_0;

		// Token: 0x04001354 RID: 4948
		private static readonly IntPtr NativeMethodInfoPtr_get_SystemDirectory_Public_Static_get_String_0;

		// Token: 0x04001355 RID: 4949
		private static readonly IntPtr NativeMethodInfoPtr_get_TickCount_Public_Static_get_Int32_0;

		// Token: 0x04001356 RID: 4950
		private static readonly IntPtr NativeMethodInfoPtr_get_UserDomainName_Public_Static_get_String_0;

		// Token: 0x04001357 RID: 4951
		private static readonly IntPtr NativeMethodInfoPtr_get_UserName_Public_Static_get_String_0;

		// Token: 0x04001358 RID: 4952
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Static_get_Version_0;

		// Token: 0x04001359 RID: 4953
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Static_Void_Int32_0;

		// Token: 0x0400135A RID: 4954
		private static readonly IntPtr NativeMethodInfoPtr_ExpandEnvironmentVariables_Public_Static_String_String_0;

		// Token: 0x0400135B RID: 4955
		private static readonly IntPtr NativeMethodInfoPtr_GetCommandLineArgs_Public_Static_Il2CppStringArray_0;

		// Token: 0x0400135C RID: 4956
		private static readonly IntPtr NativeMethodInfoPtr_internalGetEnvironmentVariable_native_Internal_Static_String_IntPtr_0;

		// Token: 0x0400135D RID: 4957
		private static readonly IntPtr NativeMethodInfoPtr_internalGetEnvironmentVariable_Internal_Static_String_String_0;

		// Token: 0x0400135E RID: 4958
		private static readonly IntPtr NativeMethodInfoPtr_GetEnvironmentVariable_Public_Static_String_String_0;

		// Token: 0x0400135F RID: 4959
		private static readonly IntPtr NativeMethodInfoPtr_GetEnvironmentVariablesNoCase_Private_Static_Hashtable_0;

		// Token: 0x04001360 RID: 4960
		private static readonly IntPtr NativeMethodInfoPtr_GetEnvironmentVariables_Public_Static_IDictionary_0;

		// Token: 0x04001361 RID: 4961
		private static readonly IntPtr NativeMethodInfoPtr_GetFolderPath_Public_Static_String_SpecialFolder_0;

		// Token: 0x04001362 RID: 4962
		private static readonly IntPtr NativeMethodInfoPtr_GetWindowsFolderPath_Private_Static_String_Int32_0;

		// Token: 0x04001363 RID: 4963
		private static readonly IntPtr NativeMethodInfoPtr_GetFolderPath_Public_Static_String_SpecialFolder_SpecialFolderOption_0;

		// Token: 0x04001364 RID: 4964
		private static readonly IntPtr NativeMethodInfoPtr_ReadXdgUserDir_Private_Static_String_String_String_String_String_0;

		// Token: 0x04001365 RID: 4965
		private static readonly IntPtr NativeMethodInfoPtr_UnixGetFolderPath_Internal_Static_String_SpecialFolder_SpecialFolderOption_0;

		// Token: 0x04001366 RID: 4966
		private static readonly IntPtr NativeMethodInfoPtr_SetEnvironmentVariable_Public_Static_Void_String_String_0;

		// Token: 0x04001367 RID: 4967
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetEnvironmentVariable_Internal_Static_Void_ptr_Char_Int32_ptr_Char_Int32_0;

		// Token: 0x04001368 RID: 4968
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetEnvironmentVariable_Internal_Static_Void_String_String_0;

		// Token: 0x04001369 RID: 4969
		private static readonly IntPtr NativeMethodInfoPtr_FailFast_Public_Static_Void_String_0;

		// Token: 0x0400136A RID: 4970
		private static readonly IntPtr NativeMethodInfoPtr_FailFast_Public_Static_Void_String_Exception_0;

		// Token: 0x0400136B RID: 4971
		private static readonly IntPtr NativeMethodInfoPtr_FailFast_Internal_Static_Void_String_Exception_String_0;

		// Token: 0x0400136C RID: 4972
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessorCount_Public_Static_get_Int32_0;

		// Token: 0x0400136D RID: 4973
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunningOnWindows_Internal_Static_get_Boolean_0;

		// Token: 0x0400136E RID: 4974
		private static readonly IntPtr NativeMethodInfoPtr_GetEnvironmentVariableNames_Private_Static_Il2CppStringArray_0;

		// Token: 0x0400136F RID: 4975
		private static readonly IntPtr NativeMethodInfoPtr_GetMachineConfigPath_Internal_Static_String_0;

		// Token: 0x04001370 RID: 4976
		private static readonly IntPtr NativeMethodInfoPtr_internalGetHome_Internal_Static_String_0;

		// Token: 0x04001371 RID: 4977
		private static readonly IntPtr NativeMethodInfoPtr_GetPageSize_Internal_Static_Int32_0;

		// Token: 0x04001372 RID: 4978
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnix_Internal_Static_get_Boolean_0;

		// Token: 0x04001373 RID: 4979
		private static readonly IntPtr NativeMethodInfoPtr_GetStackTrace_Internal_Static_String_Exception_Boolean_0;

		// Token: 0x020005F1 RID: 1521
		public enum SpecialFolder
		{
			// Token: 0x040047E7 RID: 18407
			MyDocuments = 5,
			// Token: 0x040047E8 RID: 18408
			Desktop = 0,
			// Token: 0x040047E9 RID: 18409
			MyComputer = 17,
			// Token: 0x040047EA RID: 18410
			Programs = 2,
			// Token: 0x040047EB RID: 18411
			Personal = 5,
			// Token: 0x040047EC RID: 18412
			Favorites,
			// Token: 0x040047ED RID: 18413
			Startup,
			// Token: 0x040047EE RID: 18414
			Recent,
			// Token: 0x040047EF RID: 18415
			SendTo,
			// Token: 0x040047F0 RID: 18416
			StartMenu = 11,
			// Token: 0x040047F1 RID: 18417
			MyMusic = 13,
			// Token: 0x040047F2 RID: 18418
			DesktopDirectory = 16,
			// Token: 0x040047F3 RID: 18419
			Templates = 21,
			// Token: 0x040047F4 RID: 18420
			ApplicationData = 26,
			// Token: 0x040047F5 RID: 18421
			LocalApplicationData = 28,
			// Token: 0x040047F6 RID: 18422
			InternetCache = 32,
			// Token: 0x040047F7 RID: 18423
			Cookies,
			// Token: 0x040047F8 RID: 18424
			History,
			// Token: 0x040047F9 RID: 18425
			CommonApplicationData,
			// Token: 0x040047FA RID: 18426
			System = 37,
			// Token: 0x040047FB RID: 18427
			ProgramFiles,
			// Token: 0x040047FC RID: 18428
			MyPictures,
			// Token: 0x040047FD RID: 18429
			CommonProgramFiles = 43,
			// Token: 0x040047FE RID: 18430
			MyVideos = 14,
			// Token: 0x040047FF RID: 18431
			NetworkShortcuts = 19,
			// Token: 0x04004800 RID: 18432
			Fonts,
			// Token: 0x04004801 RID: 18433
			CommonStartMenu = 22,
			// Token: 0x04004802 RID: 18434
			CommonPrograms,
			// Token: 0x04004803 RID: 18435
			CommonStartup,
			// Token: 0x04004804 RID: 18436
			CommonDesktopDirectory,
			// Token: 0x04004805 RID: 18437
			PrinterShortcuts = 27,
			// Token: 0x04004806 RID: 18438
			Windows = 36,
			// Token: 0x04004807 RID: 18439
			UserProfile = 40,
			// Token: 0x04004808 RID: 18440
			SystemX86,
			// Token: 0x04004809 RID: 18441
			ProgramFilesX86,
			// Token: 0x0400480A RID: 18442
			CommonProgramFilesX86 = 44,
			// Token: 0x0400480B RID: 18443
			CommonTemplates,
			// Token: 0x0400480C RID: 18444
			CommonDocuments,
			// Token: 0x0400480D RID: 18445
			CommonAdminTools,
			// Token: 0x0400480E RID: 18446
			AdminTools,
			// Token: 0x0400480F RID: 18447
			CommonMusic = 53,
			// Token: 0x04004810 RID: 18448
			CommonPictures,
			// Token: 0x04004811 RID: 18449
			CommonVideos,
			// Token: 0x04004812 RID: 18450
			Resources,
			// Token: 0x04004813 RID: 18451
			LocalizedResources,
			// Token: 0x04004814 RID: 18452
			CommonOemLinks,
			// Token: 0x04004815 RID: 18453
			CDBurning
		}

		// Token: 0x020005F2 RID: 1522
		public enum SpecialFolderOption
		{
			// Token: 0x04004817 RID: 18455
			None,
			// Token: 0x04004818 RID: 18456
			DoNotVerify = 16384,
			// Token: 0x04004819 RID: 18457
			Create = 32768
		}
	}
}

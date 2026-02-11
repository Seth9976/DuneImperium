using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Collections.Specialized;
using Il2CppSystem.Security;
using Il2CppSystem.Text;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020000A0 RID: 160
	public sealed class ProcessStartInfo : Object
	{
		// Token: 0x06000BDB RID: 3035 RVA: 0x00048A28 File Offset: 0x00046C28
		// Note: this type is marked as 'beforefieldinit'.
		static ProcessStartInfo()
		{
			Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "ProcessStartInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr);
			ProcessStartInfo.NativeFieldInfoPtr_fileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "fileName");
			ProcessStartInfo.NativeFieldInfoPtr_arguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "arguments");
			ProcessStartInfo.NativeFieldInfoPtr_directory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "directory");
			ProcessStartInfo.NativeFieldInfoPtr_verb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "verb");
			ProcessStartInfo.NativeFieldInfoPtr_windowStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "windowStyle");
			ProcessStartInfo.NativeFieldInfoPtr_errorDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "errorDialog");
			ProcessStartInfo.NativeFieldInfoPtr_errorDialogParentHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "errorDialogParentHandle");
			ProcessStartInfo.NativeFieldInfoPtr_useShellExecute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "useShellExecute");
			ProcessStartInfo.NativeFieldInfoPtr_userName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "userName");
			ProcessStartInfo.NativeFieldInfoPtr_domain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "domain");
			ProcessStartInfo.NativeFieldInfoPtr_password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "password");
			ProcessStartInfo.NativeFieldInfoPtr_passwordInClearText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "passwordInClearText");
			ProcessStartInfo.NativeFieldInfoPtr_loadUserProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "loadUserProfile");
			ProcessStartInfo.NativeFieldInfoPtr_redirectStandardInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "redirectStandardInput");
			ProcessStartInfo.NativeFieldInfoPtr_redirectStandardOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "redirectStandardOutput");
			ProcessStartInfo.NativeFieldInfoPtr_redirectStandardError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "redirectStandardError");
			ProcessStartInfo.NativeFieldInfoPtr_standardOutputEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "standardOutputEncoding");
			ProcessStartInfo.NativeFieldInfoPtr_standardErrorEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "standardErrorEncoding");
			ProcessStartInfo.NativeFieldInfoPtr_createNoWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "createNoWindow");
			ProcessStartInfo.NativeFieldInfoPtr_weakParentProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "weakParentProcess");
			ProcessStartInfo.NativeFieldInfoPtr_environmentVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "environmentVariables");
			ProcessStartInfo.NativeFieldInfoPtr_empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "empty");
			ProcessStartInfo.NativeFieldInfoPtr__argumentList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "_argumentList");
			ProcessStartInfo.NativeFieldInfoPtr_environment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "environment");
			ProcessStartInfo.NativeFieldInfoPtr__StandardInputEncoding_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, "<StandardInputEncoding>k__BackingField");
			ProcessStartInfo.NativeMethodInfoPtr__ctor_Internal_Void_Process_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, 100665020);
			ProcessStartInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, 100665021);
			ProcessStartInfo.NativeMethodInfoPtr_get_ArgumentList_Public_get_Collection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, 100665022);
			ProcessStartInfo.NativeMethodInfoPtr_get_Arguments_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, 100665023);
			ProcessStartInfo.NativeMethodInfoPtr_set_Arguments_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, 100665024);
			ProcessStartInfo.NativeMethodInfoPtr_get_EnvironmentVariables_Public_get_StringDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, 100665025);
			ProcessStartInfo.NativeMethodInfoPtr_get_RedirectStandardInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, 100665026);
			ProcessStartInfo.NativeMethodInfoPtr_get_RedirectStandardOutput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, 100665027);
			ProcessStartInfo.NativeMethodInfoPtr_get_RedirectStandardError_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, 100665028);
			ProcessStartInfo.NativeMethodInfoPtr_get_StandardErrorEncoding_Public_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, 100665029);
			ProcessStartInfo.NativeMethodInfoPtr_get_StandardOutputEncoding_Public_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, 100665030);
			ProcessStartInfo.NativeMethodInfoPtr_get_UseShellExecute_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, 100665031);
			ProcessStartInfo.NativeMethodInfoPtr_get_UserName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, 100665032);
			ProcessStartInfo.NativeMethodInfoPtr_get_Password_Public_get_SecureString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, 100665033);
			ProcessStartInfo.NativeMethodInfoPtr_get_Domain_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, 100665034);
			ProcessStartInfo.NativeMethodInfoPtr_get_LoadUserProfile_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, 100665035);
			ProcessStartInfo.NativeMethodInfoPtr_get_FileName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, 100665036);
			ProcessStartInfo.NativeMethodInfoPtr_get_WorkingDirectory_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, 100665037);
			ProcessStartInfo.NativeMethodInfoPtr_get_HaveEnvVars_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, 100665038);
			ProcessStartInfo.NativeMethodInfoPtr_get_StandardInputEncoding_Public_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr, 100665039);
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x00048DDC File Offset: 0x00046FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451693, XrefRangeEnd = 451699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProcessStartInfo(Process parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessStartInfo.NativeMethodInfoPtr__ctor_Internal_Void_Process_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x00048E28 File Offset: 0x00047028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451699, XrefRangeEnd = 451701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProcessStartInfo(string fileName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProcessStartInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessStartInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x00048E74 File Offset: 0x00047074
		public unsafe Collection<string> ArgumentList
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 451708, RefRangeEnd = 451710, XrefRangeStart = 451701, XrefRangeEnd = 451708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessStartInfo.NativeMethodInfoPtr_get_ArgumentList_Public_get_Collection_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collection<string>>(intPtr3) : null;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x00048EB4 File Offset: 0x000470B4
		// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x00048EEC File Offset: 0x000470EC
		public unsafe string Arguments
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451710, XrefRangeEnd = 451711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessStartInfo.NativeMethodInfoPtr_get_Arguments_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessStartInfo.NativeMethodInfoPtr_set_Arguments_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x00048F30 File Offset: 0x00047130
		public unsafe StringDictionary EnvironmentVariables
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 451745, RefRangeEnd = 451746, XrefRangeStart = 451711, XrefRangeEnd = 451745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessStartInfo.NativeMethodInfoPtr_get_EnvironmentVariables_Public_get_StringDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x00048F70 File Offset: 0x00047170
		public unsafe bool RedirectStandardInput
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessStartInfo.NativeMethodInfoPtr_get_RedirectStandardInput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x00048FAC File Offset: 0x000471AC
		public unsafe bool RedirectStandardOutput
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessStartInfo.NativeMethodInfoPtr_get_RedirectStandardOutput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x00048FE8 File Offset: 0x000471E8
		public unsafe bool RedirectStandardError
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessStartInfo.NativeMethodInfoPtr_get_RedirectStandardError_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x00049024 File Offset: 0x00047224
		public unsafe Encoding StandardErrorEncoding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessStartInfo.NativeMethodInfoPtr_get_StandardErrorEncoding_Public_get_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x00049064 File Offset: 0x00047264
		public unsafe Encoding StandardOutputEncoding
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessStartInfo.NativeMethodInfoPtr_get_StandardOutputEncoding_Public_get_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x000490A4 File Offset: 0x000472A4
		public unsafe bool UseShellExecute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessStartInfo.NativeMethodInfoPtr_get_UseShellExecute_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x000490E0 File Offset: 0x000472E0
		public unsafe string UserName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451746, XrefRangeEnd = 451747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessStartInfo.NativeMethodInfoPtr_get_UserName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x00049118 File Offset: 0x00047318
		public unsafe SecureString Password
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessStartInfo.NativeMethodInfoPtr_get_Password_Public_get_SecureString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecureString>(intPtr3) : null;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x00049158 File Offset: 0x00047358
		public unsafe string Domain
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451747, XrefRangeEnd = 451748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessStartInfo.NativeMethodInfoPtr_get_Domain_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000BEB RID: 3051 RVA: 0x00049190 File Offset: 0x00047390
		public unsafe bool LoadUserProfile
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessStartInfo.NativeMethodInfoPtr_get_LoadUserProfile_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x000491CC File Offset: 0x000473CC
		public unsafe string FileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451748, XrefRangeEnd = 451749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessStartInfo.NativeMethodInfoPtr_get_FileName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x00049204 File Offset: 0x00047404
		public unsafe string WorkingDirectory
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451749, XrefRangeEnd = 451750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessStartInfo.NativeMethodInfoPtr_get_WorkingDirectory_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x0004923C File Offset: 0x0004743C
		public unsafe bool HaveEnvVars
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessStartInfo.NativeMethodInfoPtr_get_HaveEnvVars_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x00049278 File Offset: 0x00047478
		public unsafe Encoding StandardInputEncoding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessStartInfo.NativeMethodInfoPtr_get_StandardInputEncoding_Public_get_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00006501 File Offset: 0x00004701
		public ProcessStartInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x000492B8 File Offset: 0x000474B8
		// (set) Token: 0x06000BF2 RID: 3058 RVA: 0x0000650A File Offset: 0x0000470A
		public unsafe string fileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_fileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_fileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x000492E0 File Offset: 0x000474E0
		// (set) Token: 0x06000BF4 RID: 3060 RVA: 0x00006529 File Offset: 0x00004729
		public unsafe string arguments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_arguments);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_arguments), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x00049308 File Offset: 0x00047508
		// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x00006548 File Offset: 0x00004748
		public unsafe string directory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_directory);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_directory), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x00049330 File Offset: 0x00047530
		// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x00006567 File Offset: 0x00004767
		public unsafe string verb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_verb);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_verb), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x00049358 File Offset: 0x00047558
		// (set) Token: 0x06000BFA RID: 3066 RVA: 0x00006586 File Offset: 0x00004786
		public unsafe ProcessWindowStyle windowStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_windowStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_windowStyle)) = value;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x00049380 File Offset: 0x00047580
		// (set) Token: 0x06000BFC RID: 3068 RVA: 0x000065A1 File Offset: 0x000047A1
		public unsafe bool errorDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_errorDialog);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_errorDialog)) = value;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x000493A8 File Offset: 0x000475A8
		// (set) Token: 0x06000BFE RID: 3070 RVA: 0x000065BC File Offset: 0x000047BC
		public unsafe IntPtr errorDialogParentHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_errorDialogParentHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_errorDialogParentHandle)) = value;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x000493D0 File Offset: 0x000475D0
		// (set) Token: 0x06000C00 RID: 3072 RVA: 0x000065D7 File Offset: 0x000047D7
		public unsafe bool useShellExecute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_useShellExecute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_useShellExecute)) = value;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000C01 RID: 3073 RVA: 0x000493F8 File Offset: 0x000475F8
		// (set) Token: 0x06000C02 RID: 3074 RVA: 0x000065F2 File Offset: 0x000047F2
		public unsafe string userName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_userName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_userName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x00049420 File Offset: 0x00047620
		// (set) Token: 0x06000C04 RID: 3076 RVA: 0x00006611 File Offset: 0x00004811
		public unsafe string domain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_domain);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_domain), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000C05 RID: 3077 RVA: 0x00049448 File Offset: 0x00047648
		// (set) Token: 0x06000C06 RID: 3078 RVA: 0x00006630 File Offset: 0x00004830
		public unsafe SecureString password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_password);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SecureString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_password), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x00049478 File Offset: 0x00047678
		// (set) Token: 0x06000C08 RID: 3080 RVA: 0x0000664F File Offset: 0x0000484F
		public unsafe string passwordInClearText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_passwordInClearText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_passwordInClearText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x000494A0 File Offset: 0x000476A0
		// (set) Token: 0x06000C0A RID: 3082 RVA: 0x0000666E File Offset: 0x0000486E
		public unsafe bool loadUserProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_loadUserProfile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_loadUserProfile)) = value;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x000494C8 File Offset: 0x000476C8
		// (set) Token: 0x06000C0C RID: 3084 RVA: 0x00006689 File Offset: 0x00004889
		public unsafe bool redirectStandardInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_redirectStandardInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_redirectStandardInput)) = value;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x000494F0 File Offset: 0x000476F0
		// (set) Token: 0x06000C0E RID: 3086 RVA: 0x000066A4 File Offset: 0x000048A4
		public unsafe bool redirectStandardOutput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_redirectStandardOutput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_redirectStandardOutput)) = value;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x00049518 File Offset: 0x00047718
		// (set) Token: 0x06000C10 RID: 3088 RVA: 0x000066BF File Offset: 0x000048BF
		public unsafe bool redirectStandardError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_redirectStandardError);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_redirectStandardError)) = value;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x00049540 File Offset: 0x00047740
		// (set) Token: 0x06000C12 RID: 3090 RVA: 0x000066DA File Offset: 0x000048DA
		public unsafe Encoding standardOutputEncoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_standardOutputEncoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_standardOutputEncoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x00049570 File Offset: 0x00047770
		// (set) Token: 0x06000C14 RID: 3092 RVA: 0x000066F9 File Offset: 0x000048F9
		public unsafe Encoding standardErrorEncoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_standardErrorEncoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_standardErrorEncoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x000495A0 File Offset: 0x000477A0
		// (set) Token: 0x06000C16 RID: 3094 RVA: 0x00006718 File Offset: 0x00004918
		public unsafe bool createNoWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_createNoWindow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_createNoWindow)) = value;
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x000495C8 File Offset: 0x000477C8
		// (set) Token: 0x06000C18 RID: 3096 RVA: 0x00006733 File Offset: 0x00004933
		public unsafe WeakReference weakParentProcess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_weakParentProcess);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeakReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_weakParentProcess), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x000495F8 File Offset: 0x000477F8
		// (set) Token: 0x06000C1A RID: 3098 RVA: 0x00006752 File Offset: 0x00004952
		public unsafe StringDictionary environmentVariables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_environmentVariables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_environmentVariables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x00049628 File Offset: 0x00047828
		// (set) Token: 0x06000C1C RID: 3100 RVA: 0x00006771 File Offset: 0x00004971
		public unsafe static Il2CppStringArray empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProcessStartInfo.NativeFieldInfoPtr_empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProcessStartInfo.NativeFieldInfoPtr_empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x00049650 File Offset: 0x00047850
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x00006783 File Offset: 0x00004983
		public unsafe Collection<string> _argumentList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr__argumentList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collection<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr__argumentList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x00049680 File Offset: 0x00047880
		// (set) Token: 0x06000C20 RID: 3104 RVA: 0x000067A2 File Offset: 0x000049A2
		public unsafe IDictionary<string, string> environment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_environment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr_environment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x000496B0 File Offset: 0x000478B0
		// (set) Token: 0x06000C22 RID: 3106 RVA: 0x000067C1 File Offset: 0x000049C1
		public unsafe Encoding _StandardInputEncoding_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr__StandardInputEncoding_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessStartInfo.NativeFieldInfoPtr__StandardInputEncoding_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeFieldInfoPtr_fileName;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeFieldInfoPtr_arguments;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeFieldInfoPtr_directory;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeFieldInfoPtr_verb;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeFieldInfoPtr_windowStyle;

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeFieldInfoPtr_errorDialog;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeFieldInfoPtr_errorDialogParentHandle;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeFieldInfoPtr_useShellExecute;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeFieldInfoPtr_userName;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeFieldInfoPtr_domain;

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeFieldInfoPtr_password;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeFieldInfoPtr_passwordInClearText;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeFieldInfoPtr_loadUserProfile;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeFieldInfoPtr_redirectStandardInput;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeFieldInfoPtr_redirectStandardOutput;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeFieldInfoPtr_redirectStandardError;

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeFieldInfoPtr_standardOutputEncoding;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeFieldInfoPtr_standardErrorEncoding;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeFieldInfoPtr_createNoWindow;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeFieldInfoPtr_weakParentProcess;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeFieldInfoPtr_environmentVariables;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeFieldInfoPtr_empty;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeFieldInfoPtr__argumentList;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeFieldInfoPtr_environment;

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeFieldInfoPtr__StandardInputEncoding_k__BackingField;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Process_0;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgumentList_Public_get_Collection_1_String_0;

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeMethodInfoPtr_get_Arguments_Public_get_String_0;

		// Token: 0x04000981 RID: 2433
		private static readonly IntPtr NativeMethodInfoPtr_set_Arguments_Public_set_Void_String_0;

		// Token: 0x04000982 RID: 2434
		private static readonly IntPtr NativeMethodInfoPtr_get_EnvironmentVariables_Public_get_StringDictionary_0;

		// Token: 0x04000983 RID: 2435
		private static readonly IntPtr NativeMethodInfoPtr_get_RedirectStandardInput_Public_get_Boolean_0;

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeMethodInfoPtr_get_RedirectStandardOutput_Public_get_Boolean_0;

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeMethodInfoPtr_get_RedirectStandardError_Public_get_Boolean_0;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeMethodInfoPtr_get_StandardErrorEncoding_Public_get_Encoding_0;

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeMethodInfoPtr_get_StandardOutputEncoding_Public_get_Encoding_0;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeMethodInfoPtr_get_UseShellExecute_Public_get_Boolean_0;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeMethodInfoPtr_get_UserName_Public_get_String_0;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeMethodInfoPtr_get_Password_Public_get_SecureString_0;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeMethodInfoPtr_get_Domain_Public_get_String_0;

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadUserProfile_Public_get_Boolean_0;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeMethodInfoPtr_get_FileName_Public_get_String_0;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeMethodInfoPtr_get_WorkingDirectory_Public_get_String_0;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeMethodInfoPtr_get_HaveEnvVars_Internal_get_Boolean_0;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeMethodInfoPtr_get_StandardInputEncoding_Public_get_Encoding_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem.ComponentModel;
using Il2CppSystem.IO;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x0200009D RID: 157
	public class Process : Component
	{
		// Token: 0x06000B52 RID: 2898 RVA: 0x00046F98 File Offset: 0x00045198
		// Note: this type is marked as 'beforefieldinit'.
		static Process()
		{
			Il2CppClassPointerStore<Process>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "Process");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Process>.NativeClassPtr);
			Process.NativeFieldInfoPtr_haveProcessId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "haveProcessId");
			Process.NativeFieldInfoPtr_processId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "processId");
			Process.NativeFieldInfoPtr_haveProcessHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "haveProcessHandle");
			Process.NativeFieldInfoPtr_m_processHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "m_processHandle");
			Process.NativeFieldInfoPtr_isRemoteMachine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "isRemoteMachine");
			Process.NativeFieldInfoPtr_machineName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "machineName");
			Process.NativeFieldInfoPtr_m_processAccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "m_processAccess");
			Process.NativeFieldInfoPtr_threads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "threads");
			Process.NativeFieldInfoPtr_modules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "modules");
			Process.NativeFieldInfoPtr_haveWorkingSetLimits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "haveWorkingSetLimits");
			Process.NativeFieldInfoPtr_minWorkingSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "minWorkingSet");
			Process.NativeFieldInfoPtr_maxWorkingSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "maxWorkingSet");
			Process.NativeFieldInfoPtr_havePriorityClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "havePriorityClass");
			Process.NativeFieldInfoPtr_priorityClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "priorityClass");
			Process.NativeFieldInfoPtr_startInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "startInfo");
			Process.NativeFieldInfoPtr_watchForExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "watchForExit");
			Process.NativeFieldInfoPtr_watchingForExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "watchingForExit");
			Process.NativeFieldInfoPtr_onExited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "onExited");
			Process.NativeFieldInfoPtr_exited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "exited");
			Process.NativeFieldInfoPtr_exitCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "exitCode");
			Process.NativeFieldInfoPtr_signaled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "signaled");
			Process.NativeFieldInfoPtr_exitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "exitTime");
			Process.NativeFieldInfoPtr_haveExitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "haveExitTime");
			Process.NativeFieldInfoPtr_raisedOnExited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "raisedOnExited");
			Process.NativeFieldInfoPtr_registeredWaitHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "registeredWaitHandle");
			Process.NativeFieldInfoPtr_waitHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "waitHandle");
			Process.NativeFieldInfoPtr_synchronizingObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "synchronizingObject");
			Process.NativeFieldInfoPtr_standardOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "standardOutput");
			Process.NativeFieldInfoPtr_standardInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "standardInput");
			Process.NativeFieldInfoPtr_standardError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "standardError");
			Process.NativeFieldInfoPtr_operatingSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "operatingSystem");
			Process.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "disposed");
			Process.NativeFieldInfoPtr_outputStreamReadMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "outputStreamReadMode");
			Process.NativeFieldInfoPtr_errorStreamReadMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "errorStreamReadMode");
			Process.NativeFieldInfoPtr_inputStreamReadMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "inputStreamReadMode");
			Process.NativeFieldInfoPtr_OutputDataReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "OutputDataReceived");
			Process.NativeFieldInfoPtr_ErrorDataReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "ErrorDataReceived");
			Process.NativeFieldInfoPtr_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "output");
			Process.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "error");
			Process.NativeFieldInfoPtr_pendingOutputRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "pendingOutputRead");
			Process.NativeFieldInfoPtr_pendingErrorRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "pendingErrorRead");
			Process.NativeFieldInfoPtr_process_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "process_name");
			Process.NativeFieldInfoPtr_current_main_module = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process>.NativeClassPtr, "current_main_module");
			Process.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664975);
			Process.NativeMethodInfoPtr__ctor_Private_Void_String_Boolean_Int32_ProcessInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664976);
			Process.NativeMethodInfoPtr_get_Associated_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664977);
			Process.NativeMethodInfoPtr_get_HasExited_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664978);
			Process.NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664979);
			Process.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664980);
			Process.NativeMethodInfoPtr_get_StartInfo_Public_get_ProcessStartInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664981);
			Process.NativeMethodInfoPtr_set_StartInfo_Public_set_Void_ProcessStartInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664982);
			Process.NativeMethodInfoPtr_get_SynchronizingObject_Public_get_ISynchronizeInvoke_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664983);
			Process.NativeMethodInfoPtr_ReleaseProcessHandle_Private_Void_SafeProcessHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664984);
			Process.NativeMethodInfoPtr_CompletionCallback_Private_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664985);
			Process.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664986);
			Process.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664987);
			Process.NativeMethodInfoPtr_EnsureState_Private_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664988);
			Process.NativeMethodInfoPtr_EnsureWatchingForExit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664989);
			Process.NativeMethodInfoPtr_GetCurrentProcess_Public_Static_Process_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664990);
			Process.NativeMethodInfoPtr_OnExited_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664991);
			Process.NativeMethodInfoPtr_GetProcessHandle_Private_SafeProcessHandle_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664992);
			Process.NativeMethodInfoPtr_GetProcessHandle_Private_SafeProcessHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664993);
			Process.NativeMethodInfoPtr_OpenProcessHandle_Private_SafeProcessHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664994);
			Process.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664995);
			Process.NativeMethodInfoPtr_SetProcessHandle_Private_Void_SafeProcessHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664996);
			Process.NativeMethodInfoPtr_SetProcessId_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664997);
			Process.NativeMethodInfoPtr_Start_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664998);
			Process.NativeMethodInfoPtr_Start_Public_Static_Process_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100664999);
			Process.NativeMethodInfoPtr_Start_Public_Static_Process_ProcessStartInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100665000);
			Process.NativeMethodInfoPtr_StopWatchingForExit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100665001);
			Process.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100665002);
			Process.NativeMethodInfoPtr_get_MainModule_Public_get_ProcessModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100665003);
			Process.NativeMethodInfoPtr_GetModules_icall_Private_Il2CppReferenceArray_1_ProcessModule_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100665004);
			Process.NativeMethodInfoPtr_GetModules_internal_Private_Il2CppReferenceArray_1_ProcessModule_SafeProcessHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100665005);
			Process.NativeMethodInfoPtr_get_Modules_Public_get_ProcessModuleCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100665006);
			Process.NativeMethodInfoPtr_ProcessName_icall_Private_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100665007);
			Process.NativeMethodInfoPtr_ProcessName_internal_Private_Static_String_SafeProcessHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100665008);
			Process.NativeMethodInfoPtr_get_ProcessName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100665009);
			Process.NativeMethodInfoPtr_ShellExecuteEx_internal_Private_Static_Boolean_ProcessStartInfo_byref_ProcInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100665010);
			Process.NativeMethodInfoPtr_CreateProcess_internal_Private_Static_Boolean_ProcessStartInfo_IntPtr_IntPtr_IntPtr_byref_ProcInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100665011);
			Process.NativeMethodInfoPtr_StartWithShellExecuteEx_Private_Boolean_ProcessStartInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100665012);
			Process.NativeMethodInfoPtr_CreatePipe_Private_Static_Void_byref_IntPtr_byref_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100665013);
			Process.NativeMethodInfoPtr_get_IsWindows_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100665014);
			Process.NativeMethodInfoPtr_StartWithCreateProcess_Private_Boolean_ProcessStartInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100665015);
			Process.NativeMethodInfoPtr_FillUserInfo_Private_Static_Void_ProcessStartInfo_byref_ProcInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100665016);
			Process.NativeMethodInfoPtr_RaiseOnExited_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Process>.NativeClassPtr, 100665017);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00047680 File Offset: 0x00045880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451162, XrefRangeEnd = 451170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Process()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Process>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x000476BC File Offset: 0x000458BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451170, XrefRangeEnd = 451175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Process(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Process>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(machineName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRemoteMachine;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref processId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(processInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr__ctor_Private_Void_String_Boolean_Int32_ProcessInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x00047738 File Offset: 0x00045938
		public unsafe bool Associated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_get_Associated_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x00047774 File Offset: 0x00045974
		public unsafe bool HasExited
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 451189, RefRangeEnd = 451190, XrefRangeStart = 451175, XrefRangeEnd = 451189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_get_HasExited_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x000477B0 File Offset: 0x000459B0
		public unsafe IntPtr Handle
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 451194, RefRangeEnd = 451196, XrefRangeStart = 451190, XrefRangeEnd = 451194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x000477EC File Offset: 0x000459EC
		public unsafe int Id
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451196, XrefRangeEnd = 451197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x00047828 File Offset: 0x00045A28
		// (set) Token: 0x06000B5A RID: 2906 RVA: 0x00047868 File Offset: 0x00045A68
		public unsafe ProcessStartInfo StartInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451197, XrefRangeEnd = 451207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_get_StartInfo_Public_get_ProcessStartInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProcessStartInfo>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451207, XrefRangeEnd = 451214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_set_StartInfo_Public_set_Void_ProcessStartInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x000478AC File Offset: 0x00045AAC
		public unsafe ISynchronizeInvoke SynchronizingObject
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 451234, RefRangeEnd = 451237, XrefRangeStart = 451214, XrefRangeEnd = 451234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_get_SynchronizingObject_Public_get_ISynchronizeInvoke_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISynchronizeInvoke>(intPtr3) : null;
			}
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x000478EC File Offset: 0x00045AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451237, XrefRangeEnd = 451238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseProcessHandle(SafeProcessHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_ReleaseProcessHandle_Private_Void_SafeProcessHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00047930 File Offset: 0x00045B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451238, XrefRangeEnd = 451240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompletionCallback(Object context, bool wasSignaled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wasSignaled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_CompletionCallback_Private_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00047980 File Offset: 0x00045B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451240, XrefRangeEnd = 451242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Process.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x000479CC File Offset: 0x00045BCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 451256, RefRangeEnd = 451259, XrefRangeStart = 451242, XrefRangeEnd = 451256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00047A00 File Offset: 0x00045C00
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 451260, RefRangeEnd = 451265, XrefRangeStart = 451259, XrefRangeEnd = 451260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureState(Process.State state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_EnsureState_Private_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00047A40 File Offset: 0x00045C40
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 451272, RefRangeEnd = 451276, XrefRangeStart = 451265, XrefRangeEnd = 451272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureWatchingForExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_EnsureWatchingForExit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00047A74 File Offset: 0x00045C74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 451287, RefRangeEnd = 451291, XrefRangeStart = 451276, XrefRangeEnd = 451287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Process GetCurrentProcess()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_GetCurrentProcess_Public_Static_Process_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Process>(intPtr3) : null;
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00047AA8 File Offset: 0x00045CA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 451315, RefRangeEnd = 451316, XrefRangeStart = 451291, XrefRangeEnd = 451315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnExited()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_OnExited_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00047ADC File Offset: 0x00045CDC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 451330, RefRangeEnd = 451336, XrefRangeStart = 451316, XrefRangeEnd = 451330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeProcessHandle GetProcessHandle(int access, bool throwIfExited)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref access;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwIfExited;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_GetProcessHandle_Private_SafeProcessHandle_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeProcessHandle>(intPtr3) : null;
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00047B38 File Offset: 0x00045D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451336, XrefRangeEnd = 451337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeProcessHandle GetProcessHandle(int access)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref access;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_GetProcessHandle_Private_SafeProcessHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeProcessHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00047B84 File Offset: 0x00045D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451337, XrefRangeEnd = 451340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeProcessHandle OpenProcessHandle(int access)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref access;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_OpenProcessHandle_Private_SafeProcessHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeProcessHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00047BD0 File Offset: 0x00045DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451340, XrefRangeEnd = 451342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00047C04 File Offset: 0x00045E04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 451344, RefRangeEnd = 451345, XrefRangeStart = 451342, XrefRangeEnd = 451344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProcessHandle(SafeProcessHandle processHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(processHandle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_SetProcessHandle_Private_Void_SafeProcessHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x00047C48 File Offset: 0x00045E48
		[CallerCount(0)]
		public unsafe void SetProcessId(int processId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref processId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_SetProcessId_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00047C88 File Offset: 0x00045E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451345, XrefRangeEnd = 451369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_Start_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00047CC4 File Offset: 0x00045EC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 451375, RefRangeEnd = 451378, XrefRangeStart = 451369, XrefRangeEnd = 451375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Process Start(string fileName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_Start_Public_Static_Process_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Process>(intPtr3) : null;
			}
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00047D08 File Offset: 0x00045F08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 451407, RefRangeEnd = 451408, XrefRangeStart = 451378, XrefRangeEnd = 451407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Process Start(ProcessStartInfo startInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(startInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_Start_Public_Static_Process_ProcessStartInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Process>(intPtr3) : null;
			}
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00047D4C File Offset: 0x00045F4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 451415, RefRangeEnd = 451417, XrefRangeStart = 451408, XrefRangeEnd = 451415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopWatchingForExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_StopWatchingForExit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00047D80 File Offset: 0x00045F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451417, XrefRangeEnd = 451430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Process.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x00047DC4 File Offset: 0x00045FC4
		public unsafe ProcessModule MainModule
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 451441, RefRangeEnd = 451442, XrefRangeStart = 451430, XrefRangeEnd = 451441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_get_MainModule_Public_get_ProcessModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProcessModule>(intPtr3) : null;
			}
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00047E04 File Offset: 0x00046004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451442, XrefRangeEnd = 451443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<ProcessModule> GetModules_icall(IntPtr handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_GetModules_icall_Private_Il2CppReferenceArray_1_ProcessModule_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProcessModule>>(intPtr3) : null;
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00047E50 File Offset: 0x00046050
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 451448, RefRangeEnd = 451449, XrefRangeStart = 451443, XrefRangeEnd = 451448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<ProcessModule> GetModules_internal(SafeProcessHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_GetModules_internal_Private_Il2CppReferenceArray_1_ProcessModule_SafeProcessHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProcessModule>>(intPtr3) : null;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000B72 RID: 2930 RVA: 0x00047EA0 File Offset: 0x000460A0
		public unsafe ProcessModuleCollection Modules
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 451460, RefRangeEnd = 451462, XrefRangeStart = 451449, XrefRangeEnd = 451460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_get_Modules_Public_get_ProcessModuleCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProcessModuleCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00047EE0 File Offset: 0x000460E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451462, XrefRangeEnd = 451463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ProcessName_icall(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_ProcessName_icall_Private_Static_String_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00047F18 File Offset: 0x00046118
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 451468, RefRangeEnd = 451469, XrefRangeStart = 451463, XrefRangeEnd = 451468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ProcessName_internal(SafeProcessHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_ProcessName_internal_Private_Static_String_SafeProcessHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x00047F54 File Offset: 0x00046154
		public unsafe string ProcessName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 451486, RefRangeEnd = 451488, XrefRangeStart = 451469, XrefRangeEnd = 451486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_get_ProcessName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00047F8C File Offset: 0x0004618C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429053, RefRangeEnd = 429054, XrefRangeStart = 429053, XrefRangeEnd = 429054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShellExecuteEx_internal(ProcessStartInfo startInfo, ref Process.ProcInfo procInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(startInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(procInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_ShellExecuteEx_internal_Private_Static_Boolean_ProcessStartInfo_byref_ProcInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00047FE0 File Offset: 0x000461E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429053, RefRangeEnd = 429054, XrefRangeStart = 429053, XrefRangeEnd = 429054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CreateProcess_internal(ProcessStartInfo startInfo, IntPtr stdin, IntPtr stdout, IntPtr stderr, ref Process.ProcInfo procInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(startInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stdin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stdout;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stderr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(procInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_CreateProcess_internal_Private_Static_Boolean_ProcessStartInfo_IntPtr_IntPtr_IntPtr_byref_ProcInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00048060 File Offset: 0x00046260
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 451503, RefRangeEnd = 451505, XrefRangeStart = 451488, XrefRangeEnd = 451503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartWithShellExecuteEx(ProcessStartInfo startInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(startInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_StartWithShellExecuteEx_Private_Boolean_ProcessStartInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x000480B0 File Offset: 0x000462B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 451520, RefRangeEnd = 451523, XrefRangeStart = 451505, XrefRangeEnd = 451520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreatePipe(out IntPtr read, out IntPtr write, bool writeDirection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &read;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &write;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_CreatePipe_Private_Static_Void_byref_IntPtr_byref_IntPtr_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x00048100 File Offset: 0x00046300
		public unsafe static bool IsWindows
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451523, XrefRangeEnd = 451524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_get_IsWindows_Private_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00048130 File Offset: 0x00046330
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 451660, RefRangeEnd = 451662, XrefRangeStart = 451524, XrefRangeEnd = 451660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartWithCreateProcess(ProcessStartInfo startInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(startInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_StartWithCreateProcess_Private_Boolean_ProcessStartInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00048180 File Offset: 0x00046380
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 451676, RefRangeEnd = 451678, XrefRangeStart = 451662, XrefRangeEnd = 451676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FillUserInfo(ProcessStartInfo startInfo, ref Process.ProcInfo procInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(startInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(procInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_FillUserInfo_Private_Static_Void_ProcessStartInfo_byref_ProcInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x000481CC File Offset: 0x000463CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 451683, RefRangeEnd = 451685, XrefRangeStart = 451678, XrefRangeEnd = 451683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaiseOnExited()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Process.NativeMethodInfoPtr_RaiseOnExited_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00005FF9 File Offset: 0x000041F9
		public Process(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x00048200 File Offset: 0x00046400
		// (set) Token: 0x06000B80 RID: 2944 RVA: 0x00006002 File Offset: 0x00004202
		public unsafe bool haveProcessId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_haveProcessId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_haveProcessId)) = value;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x00048228 File Offset: 0x00046428
		// (set) Token: 0x06000B82 RID: 2946 RVA: 0x0000601D File Offset: 0x0000421D
		public unsafe int processId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_processId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_processId)) = value;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x00048250 File Offset: 0x00046450
		// (set) Token: 0x06000B84 RID: 2948 RVA: 0x00006038 File Offset: 0x00004238
		public unsafe bool haveProcessHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_haveProcessHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_haveProcessHandle)) = value;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x00048278 File Offset: 0x00046478
		// (set) Token: 0x06000B86 RID: 2950 RVA: 0x00006053 File Offset: 0x00004253
		public unsafe SafeProcessHandle m_processHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_m_processHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SafeProcessHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_m_processHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x000482A8 File Offset: 0x000464A8
		// (set) Token: 0x06000B88 RID: 2952 RVA: 0x00006072 File Offset: 0x00004272
		public unsafe bool isRemoteMachine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_isRemoteMachine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_isRemoteMachine)) = value;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x000482D0 File Offset: 0x000464D0
		// (set) Token: 0x06000B8A RID: 2954 RVA: 0x0000608D File Offset: 0x0000428D
		public unsafe string machineName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_machineName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_machineName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x000482F8 File Offset: 0x000464F8
		// (set) Token: 0x06000B8C RID: 2956 RVA: 0x000060AC File Offset: 0x000042AC
		public unsafe int m_processAccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_m_processAccess);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_m_processAccess)) = value;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x00048320 File Offset: 0x00046520
		// (set) Token: 0x06000B8E RID: 2958 RVA: 0x000060C7 File Offset: 0x000042C7
		public unsafe ProcessThreadCollection threads
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_threads);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProcessThreadCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_threads), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000B8F RID: 2959 RVA: 0x00048350 File Offset: 0x00046550
		// (set) Token: 0x06000B90 RID: 2960 RVA: 0x000060E6 File Offset: 0x000042E6
		public unsafe ProcessModuleCollection modules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_modules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProcessModuleCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_modules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000B91 RID: 2961 RVA: 0x00048380 File Offset: 0x00046580
		// (set) Token: 0x06000B92 RID: 2962 RVA: 0x00006105 File Offset: 0x00004305
		public unsafe bool haveWorkingSetLimits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_haveWorkingSetLimits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_haveWorkingSetLimits)) = value;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x000483A8 File Offset: 0x000465A8
		// (set) Token: 0x06000B94 RID: 2964 RVA: 0x00006120 File Offset: 0x00004320
		public unsafe IntPtr minWorkingSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_minWorkingSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_minWorkingSet)) = value;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x000483D0 File Offset: 0x000465D0
		// (set) Token: 0x06000B96 RID: 2966 RVA: 0x0000613B File Offset: 0x0000433B
		public unsafe IntPtr maxWorkingSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_maxWorkingSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_maxWorkingSet)) = value;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x000483F8 File Offset: 0x000465F8
		// (set) Token: 0x06000B98 RID: 2968 RVA: 0x00006156 File Offset: 0x00004356
		public unsafe bool havePriorityClass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_havePriorityClass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_havePriorityClass)) = value;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x00048420 File Offset: 0x00046620
		// (set) Token: 0x06000B9A RID: 2970 RVA: 0x00006171 File Offset: 0x00004371
		public unsafe ProcessPriorityClass priorityClass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_priorityClass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_priorityClass)) = value;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x00048448 File Offset: 0x00046648
		// (set) Token: 0x06000B9C RID: 2972 RVA: 0x0000618C File Offset: 0x0000438C
		public unsafe ProcessStartInfo startInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_startInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProcessStartInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_startInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x00048478 File Offset: 0x00046678
		// (set) Token: 0x06000B9E RID: 2974 RVA: 0x000061AB File Offset: 0x000043AB
		public unsafe bool watchForExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_watchForExit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_watchForExit)) = value;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x000484A0 File Offset: 0x000466A0
		// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x000061C6 File Offset: 0x000043C6
		public unsafe bool watchingForExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_watchingForExit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_watchingForExit)) = value;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x000484C8 File Offset: 0x000466C8
		// (set) Token: 0x06000BA2 RID: 2978 RVA: 0x000061E1 File Offset: 0x000043E1
		public unsafe EventHandler onExited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_onExited);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_onExited), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x000484F8 File Offset: 0x000466F8
		// (set) Token: 0x06000BA4 RID: 2980 RVA: 0x00006200 File Offset: 0x00004400
		public unsafe bool exited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_exited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_exited)) = value;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x00048520 File Offset: 0x00046720
		// (set) Token: 0x06000BA6 RID: 2982 RVA: 0x0000621B File Offset: 0x0000441B
		public unsafe int exitCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_exitCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_exitCode)) = value;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x00048548 File Offset: 0x00046748
		// (set) Token: 0x06000BA8 RID: 2984 RVA: 0x00006236 File Offset: 0x00004436
		public unsafe bool signaled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_signaled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_signaled)) = value;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x00048570 File Offset: 0x00046770
		// (set) Token: 0x06000BAA RID: 2986 RVA: 0x00006251 File Offset: 0x00004451
		public unsafe DateTime exitTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_exitTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_exitTime)) = value;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000BAB RID: 2987 RVA: 0x00048598 File Offset: 0x00046798
		// (set) Token: 0x06000BAC RID: 2988 RVA: 0x0000626C File Offset: 0x0000446C
		public unsafe bool haveExitTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_haveExitTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_haveExitTime)) = value;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000BAD RID: 2989 RVA: 0x000485C0 File Offset: 0x000467C0
		// (set) Token: 0x06000BAE RID: 2990 RVA: 0x00006287 File Offset: 0x00004487
		public unsafe bool raisedOnExited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_raisedOnExited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_raisedOnExited)) = value;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000BAF RID: 2991 RVA: 0x000485E8 File Offset: 0x000467E8
		// (set) Token: 0x06000BB0 RID: 2992 RVA: 0x000062A2 File Offset: 0x000044A2
		public unsafe RegisteredWaitHandle registeredWaitHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_registeredWaitHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegisteredWaitHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_registeredWaitHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x00048618 File Offset: 0x00046818
		// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x000062C1 File Offset: 0x000044C1
		public unsafe WaitHandle waitHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_waitHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_waitHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x00048648 File Offset: 0x00046848
		// (set) Token: 0x06000BB4 RID: 2996 RVA: 0x000062E0 File Offset: 0x000044E0
		public unsafe ISynchronizeInvoke synchronizingObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_synchronizingObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISynchronizeInvoke>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_synchronizingObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x00048678 File Offset: 0x00046878
		// (set) Token: 0x06000BB6 RID: 2998 RVA: 0x000062FF File Offset: 0x000044FF
		public unsafe StreamReader standardOutput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_standardOutput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_standardOutput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x000486A8 File Offset: 0x000468A8
		// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x0000631E File Offset: 0x0000451E
		public unsafe StreamWriter standardInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_standardInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_standardInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x000486D8 File Offset: 0x000468D8
		// (set) Token: 0x06000BBA RID: 3002 RVA: 0x0000633D File Offset: 0x0000453D
		public unsafe StreamReader standardError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_standardError);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_standardError), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x00048708 File Offset: 0x00046908
		// (set) Token: 0x06000BBC RID: 3004 RVA: 0x0000635C File Offset: 0x0000455C
		public unsafe OperatingSystem operatingSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_operatingSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OperatingSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_operatingSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x00048738 File Offset: 0x00046938
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x0000637B File Offset: 0x0000457B
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x00048760 File Offset: 0x00046960
		// (set) Token: 0x06000BC0 RID: 3008 RVA: 0x00006396 File Offset: 0x00004596
		public unsafe Process.StreamReadMode outputStreamReadMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_outputStreamReadMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_outputStreamReadMode)) = value;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x00048788 File Offset: 0x00046988
		// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x000063B1 File Offset: 0x000045B1
		public unsafe Process.StreamReadMode errorStreamReadMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_errorStreamReadMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_errorStreamReadMode)) = value;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x000487B0 File Offset: 0x000469B0
		// (set) Token: 0x06000BC4 RID: 3012 RVA: 0x000063CC File Offset: 0x000045CC
		public unsafe Process.StreamReadMode inputStreamReadMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_inputStreamReadMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_inputStreamReadMode)) = value;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x000487D8 File Offset: 0x000469D8
		// (set) Token: 0x06000BC6 RID: 3014 RVA: 0x000063E7 File Offset: 0x000045E7
		public unsafe DataReceivedEventHandler OutputDataReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_OutputDataReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataReceivedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_OutputDataReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x00048808 File Offset: 0x00046A08
		// (set) Token: 0x06000BC8 RID: 3016 RVA: 0x00006406 File Offset: 0x00004606
		public unsafe DataReceivedEventHandler ErrorDataReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_ErrorDataReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataReceivedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_ErrorDataReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x00048838 File Offset: 0x00046A38
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x00006425 File Offset: 0x00004625
		public unsafe AsyncStreamReader output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_output);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncStreamReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_output), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x00048868 File Offset: 0x00046A68
		// (set) Token: 0x06000BCC RID: 3020 RVA: 0x00006444 File Offset: 0x00004644
		public unsafe AsyncStreamReader error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_error);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncStreamReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_error), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x00048898 File Offset: 0x00046A98
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x00006463 File Offset: 0x00004663
		public unsafe bool pendingOutputRead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_pendingOutputRead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_pendingOutputRead)) = value;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x000488C0 File Offset: 0x00046AC0
		// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x0000647E File Offset: 0x0000467E
		public unsafe bool pendingErrorRead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_pendingErrorRead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_pendingErrorRead)) = value;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x000488E8 File Offset: 0x00046AE8
		// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x00006499 File Offset: 0x00004699
		public unsafe string process_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_process_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.NativeFieldInfoPtr_process_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x00048910 File Offset: 0x00046B10
		// (set) Token: 0x06000BD4 RID: 3028 RVA: 0x000064B8 File Offset: 0x000046B8
		public unsafe static ProcessModule current_main_module
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Process.NativeFieldInfoPtr_current_main_module, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProcessModule>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Process.NativeFieldInfoPtr_current_main_module, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400090C RID: 2316
		private static readonly IntPtr NativeFieldInfoPtr_haveProcessId;

		// Token: 0x0400090D RID: 2317
		private static readonly IntPtr NativeFieldInfoPtr_processId;

		// Token: 0x0400090E RID: 2318
		private static readonly IntPtr NativeFieldInfoPtr_haveProcessHandle;

		// Token: 0x0400090F RID: 2319
		private static readonly IntPtr NativeFieldInfoPtr_m_processHandle;

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeFieldInfoPtr_isRemoteMachine;

		// Token: 0x04000911 RID: 2321
		private static readonly IntPtr NativeFieldInfoPtr_machineName;

		// Token: 0x04000912 RID: 2322
		private static readonly IntPtr NativeFieldInfoPtr_m_processAccess;

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeFieldInfoPtr_threads;

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeFieldInfoPtr_modules;

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeFieldInfoPtr_haveWorkingSetLimits;

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeFieldInfoPtr_minWorkingSet;

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeFieldInfoPtr_maxWorkingSet;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeFieldInfoPtr_havePriorityClass;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeFieldInfoPtr_priorityClass;

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeFieldInfoPtr_startInfo;

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeFieldInfoPtr_watchForExit;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeFieldInfoPtr_watchingForExit;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeFieldInfoPtr_onExited;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeFieldInfoPtr_exited;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeFieldInfoPtr_exitCode;

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeFieldInfoPtr_signaled;

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeFieldInfoPtr_exitTime;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeFieldInfoPtr_haveExitTime;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeFieldInfoPtr_raisedOnExited;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeFieldInfoPtr_registeredWaitHandle;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeFieldInfoPtr_waitHandle;

		// Token: 0x04000926 RID: 2342
		private static readonly IntPtr NativeFieldInfoPtr_synchronizingObject;

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeFieldInfoPtr_standardOutput;

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeFieldInfoPtr_standardInput;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeFieldInfoPtr_standardError;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeFieldInfoPtr_operatingSystem;

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeFieldInfoPtr_outputStreamReadMode;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeFieldInfoPtr_errorStreamReadMode;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeFieldInfoPtr_inputStreamReadMode;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeFieldInfoPtr_OutputDataReceived;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeFieldInfoPtr_ErrorDataReceived;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeFieldInfoPtr_output;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeFieldInfoPtr_error;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeFieldInfoPtr_pendingOutputRead;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeFieldInfoPtr_pendingErrorRead;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeFieldInfoPtr_process_name;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeFieldInfoPtr_current_main_module;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_Boolean_Int32_ProcessInfo_0;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeMethodInfoPtr_get_Associated_Private_get_Boolean_0;

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeMethodInfoPtr_get_HasExited_Public_get_Boolean_0;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeMethodInfoPtr_get_StartInfo_Public_get_ProcessStartInfo_0;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeMethodInfoPtr_set_StartInfo_Public_set_Void_ProcessStartInfo_0;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeMethodInfoPtr_get_SynchronizingObject_Public_get_ISynchronizeInvoke_0;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseProcessHandle_Private_Void_SafeProcessHandle_0;

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeMethodInfoPtr_CompletionCallback_Private_Void_Object_Boolean_0;

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeMethodInfoPtr_EnsureState_Private_Void_State_0;

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeMethodInfoPtr_EnsureWatchingForExit_Private_Void_0;

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentProcess_Public_Static_Process_0;

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeMethodInfoPtr_OnExited_Protected_Void_0;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeMethodInfoPtr_GetProcessHandle_Private_SafeProcessHandle_Int32_Boolean_0;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeMethodInfoPtr_GetProcessHandle_Private_SafeProcessHandle_Int32_0;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeMethodInfoPtr_OpenProcessHandle_Private_SafeProcessHandle_Int32_0;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeMethodInfoPtr_SetProcessHandle_Private_Void_SafeProcessHandle_0;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeMethodInfoPtr_SetProcessId_Private_Void_Int32_0;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Boolean_0;

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Static_Process_String_0;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Static_Process_ProcessStartInfo_0;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeMethodInfoPtr_StopWatchingForExit_Private_Void_0;

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeMethodInfoPtr_get_MainModule_Public_get_ProcessModule_0;

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeMethodInfoPtr_GetModules_icall_Private_Il2CppReferenceArray_1_ProcessModule_IntPtr_0;

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeMethodInfoPtr_GetModules_internal_Private_Il2CppReferenceArray_1_ProcessModule_SafeProcessHandle_0;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeMethodInfoPtr_get_Modules_Public_get_ProcessModuleCollection_0;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeMethodInfoPtr_ProcessName_icall_Private_Static_String_IntPtr_0;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeMethodInfoPtr_ProcessName_internal_Private_Static_String_SafeProcessHandle_0;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessName_Public_get_String_0;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeMethodInfoPtr_ShellExecuteEx_internal_Private_Static_Boolean_ProcessStartInfo_byref_ProcInfo_0;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeMethodInfoPtr_CreateProcess_internal_Private_Static_Boolean_ProcessStartInfo_IntPtr_IntPtr_IntPtr_byref_ProcInfo_0;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeMethodInfoPtr_StartWithShellExecuteEx_Private_Boolean_ProcessStartInfo_0;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeMethodInfoPtr_CreatePipe_Private_Static_Void_byref_IntPtr_byref_IntPtr_Boolean_0;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeMethodInfoPtr_get_IsWindows_Private_Static_get_Boolean_0;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeMethodInfoPtr_StartWithCreateProcess_Private_Boolean_ProcessStartInfo_0;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeMethodInfoPtr_FillUserInfo_Private_Static_Void_ProcessStartInfo_byref_ProcInfo_0;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeMethodInfoPtr_RaiseOnExited_Private_Void_0;

		// Token: 0x020002D0 RID: 720
		public enum StreamReadMode
		{
			// Token: 0x0400229A RID: 8858
			undefined,
			// Token: 0x0400229B RID: 8859
			syncMode,
			// Token: 0x0400229C RID: 8860
			asyncMode
		}

		// Token: 0x020002D1 RID: 721
		public enum State
		{
			// Token: 0x0400229E RID: 8862
			HaveId = 1,
			// Token: 0x0400229F RID: 8863
			IsLocal,
			// Token: 0x040022A0 RID: 8864
			IsNt = 4,
			// Token: 0x040022A1 RID: 8865
			HaveProcessInfo = 8,
			// Token: 0x040022A2 RID: 8866
			Exited = 16,
			// Token: 0x040022A3 RID: 8867
			Associated = 32,
			// Token: 0x040022A4 RID: 8868
			IsWin2k = 64,
			// Token: 0x040022A5 RID: 8869
			HaveNtProcessInfo = 12
		}

		// Token: 0x020002D2 RID: 722
		public sealed class ProcInfo : ValueType
		{
			// Token: 0x06002BCE RID: 11214 RVA: 0x000C1AC8 File Offset: 0x000BFCC8
			// Note: this type is marked as 'beforefieldinit'.
			static ProcInfo()
			{
				Il2CppClassPointerStore<Process.ProcInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Process>.NativeClassPtr, "ProcInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Process.ProcInfo>.NativeClassPtr);
				Process.ProcInfo.NativeFieldInfoPtr_process_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process.ProcInfo>.NativeClassPtr, "process_handle");
				Process.ProcInfo.NativeFieldInfoPtr_pid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process.ProcInfo>.NativeClassPtr, "pid");
				Process.ProcInfo.NativeFieldInfoPtr_envVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process.ProcInfo>.NativeClassPtr, "envVariables");
				Process.ProcInfo.NativeFieldInfoPtr_UserName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process.ProcInfo>.NativeClassPtr, "UserName");
				Process.ProcInfo.NativeFieldInfoPtr_Domain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process.ProcInfo>.NativeClassPtr, "Domain");
				Process.ProcInfo.NativeFieldInfoPtr_Password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process.ProcInfo>.NativeClassPtr, "Password");
				Process.ProcInfo.NativeFieldInfoPtr_LoadUserProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Process.ProcInfo>.NativeClassPtr, "LoadUserProfile");
			}

			// Token: 0x06002BCF RID: 11215 RVA: 0x00013B72 File Offset: 0x00011D72
			public ProcInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002BD0 RID: 11216 RVA: 0x00013B7B File Offset: 0x00011D7B
			public ProcInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Process.ProcInfo>.NativeClassPtr))
			{
			}

			// Token: 0x17000DC0 RID: 3520
			// (get) Token: 0x06002BD1 RID: 11217 RVA: 0x000C1B80 File Offset: 0x000BFD80
			// (set) Token: 0x06002BD2 RID: 11218 RVA: 0x00013B8D File Offset: 0x00011D8D
			public unsafe IntPtr process_handle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.ProcInfo.NativeFieldInfoPtr_process_handle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.ProcInfo.NativeFieldInfoPtr_process_handle)) = value;
				}
			}

			// Token: 0x17000DC1 RID: 3521
			// (get) Token: 0x06002BD3 RID: 11219 RVA: 0x000C1BA8 File Offset: 0x000BFDA8
			// (set) Token: 0x06002BD4 RID: 11220 RVA: 0x00013BA8 File Offset: 0x00011DA8
			public unsafe int pid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.ProcInfo.NativeFieldInfoPtr_pid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.ProcInfo.NativeFieldInfoPtr_pid)) = value;
				}
			}

			// Token: 0x17000DC2 RID: 3522
			// (get) Token: 0x06002BD5 RID: 11221 RVA: 0x000C1BD0 File Offset: 0x000BFDD0
			// (set) Token: 0x06002BD6 RID: 11222 RVA: 0x00013BC3 File Offset: 0x00011DC3
			public unsafe Il2CppStringArray envVariables
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.ProcInfo.NativeFieldInfoPtr_envVariables);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.ProcInfo.NativeFieldInfoPtr_envVariables), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DC3 RID: 3523
			// (get) Token: 0x06002BD7 RID: 11223 RVA: 0x000C1C00 File Offset: 0x000BFE00
			// (set) Token: 0x06002BD8 RID: 11224 RVA: 0x00013BE2 File Offset: 0x00011DE2
			public unsafe string UserName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.ProcInfo.NativeFieldInfoPtr_UserName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.ProcInfo.NativeFieldInfoPtr_UserName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000DC4 RID: 3524
			// (get) Token: 0x06002BD9 RID: 11225 RVA: 0x000C1C28 File Offset: 0x000BFE28
			// (set) Token: 0x06002BDA RID: 11226 RVA: 0x00013C01 File Offset: 0x00011E01
			public unsafe string Domain
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.ProcInfo.NativeFieldInfoPtr_Domain);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.ProcInfo.NativeFieldInfoPtr_Domain), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000DC5 RID: 3525
			// (get) Token: 0x06002BDB RID: 11227 RVA: 0x000C1C50 File Offset: 0x000BFE50
			// (set) Token: 0x06002BDC RID: 11228 RVA: 0x00013C20 File Offset: 0x00011E20
			public unsafe IntPtr Password
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.ProcInfo.NativeFieldInfoPtr_Password);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.ProcInfo.NativeFieldInfoPtr_Password)) = value;
				}
			}

			// Token: 0x17000DC6 RID: 3526
			// (get) Token: 0x06002BDD RID: 11229 RVA: 0x000C1C78 File Offset: 0x000BFE78
			// (set) Token: 0x06002BDE RID: 11230 RVA: 0x00013C3B File Offset: 0x00011E3B
			public unsafe bool LoadUserProfile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.ProcInfo.NativeFieldInfoPtr_LoadUserProfile);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Process.ProcInfo.NativeFieldInfoPtr_LoadUserProfile)) = value;
				}
			}

			// Token: 0x040022A6 RID: 8870
			private static readonly IntPtr NativeFieldInfoPtr_process_handle;

			// Token: 0x040022A7 RID: 8871
			private static readonly IntPtr NativeFieldInfoPtr_pid;

			// Token: 0x040022A8 RID: 8872
			private static readonly IntPtr NativeFieldInfoPtr_envVariables;

			// Token: 0x040022A9 RID: 8873
			private static readonly IntPtr NativeFieldInfoPtr_UserName;

			// Token: 0x040022AA RID: 8874
			private static readonly IntPtr NativeFieldInfoPtr_Domain;

			// Token: 0x040022AB RID: 8875
			private static readonly IntPtr NativeFieldInfoPtr_Password;

			// Token: 0x040022AC RID: 8876
			private static readonly IntPtr NativeFieldInfoPtr_LoadUserProfile;
		}
	}
}

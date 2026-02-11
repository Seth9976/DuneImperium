using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200007E RID: 126
	public class Debug : Object
	{
		// Token: 0x0600061C RID: 1564 RVA: 0x00029CC0 File Offset: 0x00027EC0
		// Note: this type is marked as 'beforefieldinit'.
		static Debug()
		{
			Il2CppClassPointerStore<Debug>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Debug");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Debug>.NativeClassPtr);
			Debug.NativeFieldInfoPtr_s_DefaultLogger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debug>.NativeClassPtr, "s_DefaultLogger");
			Debug.NativeFieldInfoPtr_s_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debug>.NativeClassPtr, "s_Logger");
			Debug.NativeMethodInfoPtr_get_unityLogger_Public_Static_get_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664035);
			Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664036);
			Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664037);
			Debug.NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664038);
			Debug.NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664039);
			Debug.NativeMethodInfoPtr_ExtractStackTraceNoAlloc_Public_Static_Int32_ptr_Byte_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664040);
			Debug.NativeMethodInfoPtr_Log_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664041);
			Debug.NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664042);
			Debug.NativeMethodInfoPtr_LogFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664043);
			Debug.NativeMethodInfoPtr_LogFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664044);
			Debug.NativeMethodInfoPtr_LogFormat_Public_Static_Void_LogType_LogOption_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664045);
			Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664046);
			Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664047);
			Debug.NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664048);
			Debug.NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664049);
			Debug.NativeMethodInfoPtr_set_developerConsoleVisible_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664050);
			Debug.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664051);
			Debug.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664052);
			Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664053);
			Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664054);
			Debug.NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664055);
			Debug.NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664056);
			Debug.NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664057);
			Debug.NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664058);
			Debug.NativeMethodInfoPtr_LogAssertion_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664059);
			Debug.NativeMethodInfoPtr_LogAssertionFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664060);
			Debug.NativeMethodInfoPtr_get_isDebugBuild_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664061);
			Debug.NativeMethodInfoPtr_CallOverridenDebugHandler_Internal_Static_Boolean_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664062);
			Debug.NativeMethodInfoPtr_IsLoggingEnabled_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664063);
			Debug.NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664065);
			Debug.BreakDelegateField = IL2CPP.ResolveICall<Debug.BreakDelegate>("UnityEngine.Debug::Break");
			Debug.DebugBreakDelegateField = IL2CPP.ResolveICall<Debug.DebugBreakDelegate>("UnityEngine.Debug::DebugBreak");
			Debug.ClearDeveloperConsoleDelegateField = IL2CPP.ResolveICall<Debug.ClearDeveloperConsoleDelegate>("UnityEngine.Debug::ClearDeveloperConsole");
			Debug.get_developerConsoleEnabledDelegateField = IL2CPP.ResolveICall<Debug.get_developerConsoleEnabledDelegate>("UnityEngine.Debug::get_developerConsoleEnabled");
			Debug.set_developerConsoleEnabledDelegateField = IL2CPP.ResolveICall<Debug.set_developerConsoleEnabledDelegate>("UnityEngine.Debug::set_developerConsoleEnabled");
			Debug.get_developerConsoleVisibleDelegateField = IL2CPP.ResolveICall<Debug.get_developerConsoleVisibleDelegate>("UnityEngine.Debug::get_developerConsoleVisible");
			Debug.OpenConsoleFileDelegateField = IL2CPP.ResolveICall<Debug.OpenConsoleFileDelegate>("UnityEngine.Debug::OpenConsoleFile");
			Debug.get_diagnosticSwitchesDelegateField = IL2CPP.ResolveICall<Debug.get_diagnosticSwitchesDelegate>("UnityEngine.Debug::get_diagnosticSwitches");
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x00029FE8 File Offset: 0x000281E8
		public unsafe static ILogger unityLogger
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646432, XrefRangeEnd = 646436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_get_unityLogger_Public_Static_get_ILogger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0002A01C File Offset: 0x0002821C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 646444, RefRangeEnd = 646445, XrefRangeStart = 646436, XrefRangeEnd = 646444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine(Vector3 start, Vector3 end, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0002A06C File Offset: 0x0002826C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646445, XrefRangeEnd = 646450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthTest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0002A0D8 File Offset: 0x000282D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 646461, RefRangeEnd = 646462, XrefRangeStart = 646450, XrefRangeEnd = 646461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawRay(Vector3 start, Vector3 dir, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0002A128 File Offset: 0x00028328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646462, XrefRangeEnd = 646470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthTest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0002A194 File Offset: 0x00028394
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 646472, RefRangeEnd = 646473, XrefRangeStart = 646470, XrefRangeEnd = 646472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferMax;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(projectFolder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_ExtractStackTraceNoAlloc_Public_Static_Int32_ptr_Byte_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0002A1F0 File Offset: 0x000283F0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 646483, RefRangeEnd = 646701, XrefRangeStart = 646473, XrefRangeEnd = 646483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_Log_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0002A228 File Offset: 0x00028428
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 646711, RefRangeEnd = 646728, XrefRangeStart = 646701, XrefRangeEnd = 646711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(Object message, Object context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0002A270 File Offset: 0x00028470
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 646738, RefRangeEnd = 646762, XrefRangeStart = 646728, XrefRangeEnd = 646738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0002A2C8 File Offset: 0x000284C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 646772, RefRangeEnd = 646773, XrefRangeStart = 646762, XrefRangeEnd = 646772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogFormat(Object context, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0002A330 File Offset: 0x00028530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 646797, RefRangeEnd = 646798, XrefRangeStart = 646773, XrefRangeEnd = 646797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogFormat(LogType logType, LogOption logOptions, Object context, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogFormat_Public_Static_Void_LogType_LogOption_Object_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0002A3B8 File Offset: 0x000285B8
		[CallerCount(228)]
		[CachedScanResults(RefRangeStart = 646808, RefRangeEnd = 647036, XrefRangeStart = 646798, XrefRangeEnd = 646808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogError(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0002A3F0 File Offset: 0x000285F0
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 647046, RefRangeEnd = 647082, XrefRangeStart = 647036, XrefRangeEnd = 647046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogError(Object message, Object context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0002A438 File Offset: 0x00028638
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 647092, RefRangeEnd = 647128, XrefRangeStart = 647082, XrefRangeEnd = 647092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogErrorFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0002A490 File Offset: 0x00028690
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 647138, RefRangeEnd = 647142, XrefRangeStart = 647128, XrefRangeEnd = 647138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogErrorFormat(Object context, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x0000483C File Offset: 0x00002A3C
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x0002A4F8 File Offset: 0x000286F8
		public unsafe static bool developerConsoleVisible
		{
			get
			{
				return Debug.get_developerConsoleVisibleDelegateField();
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 647144, RefRangeEnd = 647145, XrefRangeStart = 647142, XrefRangeEnd = 647144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_set_developerConsoleVisible_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0002A52C File Offset: 0x0002872C
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 647155, RefRangeEnd = 647211, XrefRangeStart = 647145, XrefRangeEnd = 647155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogException(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0002A564 File Offset: 0x00028764
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 647221, RefRangeEnd = 647228, XrefRangeStart = 647211, XrefRangeEnd = 647221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogException(Exception exception, Object context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0002A5AC File Offset: 0x000287AC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 647238, RefRangeEnd = 647458, XrefRangeStart = 647228, XrefRangeEnd = 647238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarning(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0002A5E4 File Offset: 0x000287E4
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 647468, RefRangeEnd = 647514, XrefRangeStart = 647458, XrefRangeEnd = 647468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarning(Object message, Object context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0002A62C File Offset: 0x0002882C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 647524, RefRangeEnd = 647541, XrefRangeStart = 647514, XrefRangeEnd = 647524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarningFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0002A684 File Offset: 0x00028884
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 647551, RefRangeEnd = 647555, XrefRangeStart = 647541, XrefRangeEnd = 647551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarningFormat(Object context, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0002A6EC File Offset: 0x000288EC
		[CallerCount(162)]
		[CachedScanResults(RefRangeStart = 647567, RefRangeEnd = 647729, XrefRangeStart = 647555, XrefRangeEnd = 647567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Assert(bool condition)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref condition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0002A720 File Offset: 0x00028920
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 647739, RefRangeEnd = 647765, XrefRangeStart = 647729, XrefRangeEnd = 647739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Assert(bool condition, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref condition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0002A764 File Offset: 0x00028964
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 647775, RefRangeEnd = 647781, XrefRangeStart = 647765, XrefRangeEnd = 647775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogAssertion(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogAssertion_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0002A79C File Offset: 0x0002899C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 647791, RefRangeEnd = 647793, XrefRangeStart = 647781, XrefRangeEnd = 647791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogAssertionFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogAssertionFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x0002A7F4 File Offset: 0x000289F4
		public unsafe static bool isDebugBuild
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 647795, RefRangeEnd = 647798, XrefRangeStart = 647793, XrefRangeEnd = 647795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_get_isDebugBuild_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0002A824 File Offset: 0x00028A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 647798, XrefRangeEnd = 647819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CallOverridenDebugHandler(Exception exception, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_CallOverridenDebugHandler_Internal_Static_Boolean_Exception_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0002A878 File Offset: 0x00028A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 647819, XrefRangeEnd = 647843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLoggingEnabled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_IsLoggingEnabled_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0002A8A8 File Offset: 0x00028AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 647843, XrefRangeEnd = 647845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine_Injected(ref Vector3 start, ref Vector3 end, ref Color color, float duration, bool depthTest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &color;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthTest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Color_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0000475B File Offset: 0x0000295B
		public static void LogFormat(string format, params Object[] args)
		{
			Debug.LogFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00004769 File Offset: 0x00002969
		public static void LogFormat(Object context, string format, params Object[] args)
		{
			Debug.LogFormat(context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00004778 File Offset: 0x00002978
		public static void LogFormat(LogType logType, LogOption logOptions, Object context, string format, params Object[] args)
		{
			Debug.LogFormat(logType, logOptions, context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0000478A File Offset: 0x0000298A
		public static void LogErrorFormat(string format, params Object[] args)
		{
			Debug.LogErrorFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00004798 File Offset: 0x00002998
		public static void LogErrorFormat(Object context, string format, params Object[] args)
		{
			Debug.LogErrorFormat(context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x000047A7 File Offset: 0x000029A7
		public static void LogWarningFormat(string format, params Object[] args)
		{
			Debug.LogWarningFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x000047B5 File Offset: 0x000029B5
		public static void LogWarningFormat(Object context, string format, params Object[] args)
		{
			Debug.LogWarningFormat(context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x000047C4 File Offset: 0x000029C4
		public static void LogAssertionFormat(string format, params Object[] args)
		{
			Debug.LogAssertionFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x000047D2 File Offset: 0x000029D2
		public Debug(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x0002A914 File Offset: 0x00028B14
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x000047DB File Offset: 0x000029DB
		public unsafe static ILogger s_DefaultLogger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Debug.NativeFieldInfoPtr_s_DefaultLogger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Debug.NativeFieldInfoPtr_s_DefaultLogger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x0002A93C File Offset: 0x00028B3C
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x000047ED File Offset: 0x000029ED
		public unsafe static ILogger s_Logger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Debug.NativeFieldInfoPtr_s_Logger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Debug.NativeFieldInfoPtr_s_Logger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0002A964 File Offset: 0x00028B64
		public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
		{
			bool flag = true;
			Debug.DrawLine(start, end, color, duration, flag);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0002A980 File Offset: 0x00028B80
		public static void DrawLine(Vector3 start, Vector3 end)
		{
			bool flag = true;
			float num = 0f;
			Color white = Color.white;
			Debug.DrawLine(start, end, white, num, flag);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0002A9A8 File Offset: 0x00028BA8
		public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration)
		{
			bool flag = true;
			Debug.DrawRay(start, dir, color, duration, flag);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0002A9C4 File Offset: 0x00028BC4
		public static void DrawRay(Vector3 start, Vector3 dir)
		{
			bool flag = true;
			float num = 0f;
			Color white = Color.white;
			Debug.DrawRay(start, dir, white, num, flag);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x000047FF File Offset: 0x000029FF
		public static void Break()
		{
			Debug.BreakDelegateField();
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0000480B File Offset: 0x00002A0B
		public static void DebugBreak()
		{
			Debug.DebugBreakDelegateField();
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00004817 File Offset: 0x00002A17
		public static void ClearDeveloperConsole()
		{
			Debug.ClearDeveloperConsoleDelegateField();
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x00004823 File Offset: 0x00002A23
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x0000482F File Offset: 0x00002A2F
		public static bool developerConsoleEnabled
		{
			get
			{
				return Debug.get_developerConsoleEnabledDelegateField();
			}
			set
			{
				Debug.set_developerConsoleEnabledDelegateField(value);
			}
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0002A9EC File Offset: 0x00028BEC
		public static void Assert(bool condition, Object context)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.Log(LogType.Assert, "Assertion failed", context);
			}
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0002AA14 File Offset: 0x00028C14
		public static void Assert(bool condition, Object message)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.Log(LogType.Assert, message);
			}
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0002AA38 File Offset: 0x00028C38
		public static void Assert(bool condition, Object message, Object context)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.Log(LogType.Assert, message, context);
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0002AA5C File Offset: 0x00028C5C
		public static void Assert(bool condition, string message, Object context)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.Log(LogType.Assert, message, context);
			}
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0002AA80 File Offset: 0x00028C80
		public static void AssertFormat(bool condition, string format, Il2CppReferenceArray<Object> args)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.LogFormat(LogType.Assert, format, args);
			}
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00004848 File Offset: 0x00002A48
		public static void AssertFormat(bool condition, string format, params Object[] args)
		{
			Debug.AssertFormat(condition, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0002AAA4 File Offset: 0x00028CA4
		public static void AssertFormat(bool condition, Object context, string format, Il2CppReferenceArray<Object> args)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.LogFormat(LogType.Assert, context, format, args);
			}
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00004857 File Offset: 0x00002A57
		public static void AssertFormat(bool condition, Object context, string format, params Object[] args)
		{
			Debug.AssertFormat(condition, context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00004867 File Offset: 0x00002A67
		public static void LogAssertion(Object message, Object context)
		{
			Debug.unityLogger.Log(LogType.Assert, message, context);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00004878 File Offset: 0x00002A78
		public static void LogAssertionFormat(Object context, string format, Il2CppReferenceArray<Object> args)
		{
			Debug.unityLogger.LogFormat(LogType.Assert, context, format, args);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0000488A File Offset: 0x00002A8A
		public static void LogAssertionFormat(Object context, string format, params Object[] args)
		{
			Debug.LogAssertionFormat(context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00004899 File Offset: 0x00002A99
		public static void OpenConsoleFile()
		{
			Debug.OpenConsoleFileDelegateField();
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x0002AACC File Offset: 0x00028CCC
		public static Il2CppReferenceArray<DiagnosticSwitch> diagnosticSwitches
		{
			get
			{
				IntPtr intPtr = Debug.get_diagnosticSwitchesDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DiagnosticSwitch>>(intPtr2) : null;
			}
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x000048A5 File Offset: 0x00002AA5
		public static DiagnosticSwitch GetDiagnosticSwitch(string name)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0002AAF4 File Offset: 0x00028CF4
		public static void Assert(bool condition, string format, Il2CppReferenceArray<Object> args)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.LogFormat(LogType.Assert, format, args);
			}
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x000048B2 File Offset: 0x00002AB2
		public static void Assert(bool condition, string format, params Object[] args)
		{
			Debug.Assert(condition, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x0002AB18 File Offset: 0x00028D18
		public static ILogger logger
		{
			get
			{
				return Debug.s_Logger;
			}
		}

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultLogger;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeFieldInfoPtr_s_Logger;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeMethodInfoPtr_get_unityLogger_Public_Static_get_ILogger_0;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_0;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_Color_0;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeMethodInfoPtr_ExtractStackTraceNoAlloc_Public_Static_Int32_ptr_Byte_Int32_String_0;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_Object_0;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeMethodInfoPtr_LogFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeMethodInfoPtr_LogFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeMethodInfoPtr_LogFormat_Public_Static_Void_LogType_LogOption_Object_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeMethodInfoPtr_set_developerConsoleVisible_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_0;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_Object_0;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_0;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_String_0;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeMethodInfoPtr_LogAssertion_Public_Static_Void_Object_0;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeMethodInfoPtr_LogAssertionFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr_get_isDebugBuild_Public_Static_get_Boolean_0;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr_CallOverridenDebugHandler_Internal_Static_Boolean_Exception_Object_0;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr_IsLoggingEnabled_Internal_Static_Boolean_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Color_Single_Boolean_0;

		// Token: 0x0400056F RID: 1391
		private static readonly Debug.BreakDelegate BreakDelegateField;

		// Token: 0x04000570 RID: 1392
		private static readonly Debug.DebugBreakDelegate DebugBreakDelegateField;

		// Token: 0x04000571 RID: 1393
		private static readonly Debug.ClearDeveloperConsoleDelegate ClearDeveloperConsoleDelegateField;

		// Token: 0x04000572 RID: 1394
		private static readonly Debug.get_developerConsoleEnabledDelegate get_developerConsoleEnabledDelegateField;

		// Token: 0x04000573 RID: 1395
		private static readonly Debug.set_developerConsoleEnabledDelegate set_developerConsoleEnabledDelegateField;

		// Token: 0x04000574 RID: 1396
		private static readonly Debug.get_developerConsoleVisibleDelegate get_developerConsoleVisibleDelegateField;

		// Token: 0x04000575 RID: 1397
		private static readonly Debug.OpenConsoleFileDelegate OpenConsoleFileDelegateField;

		// Token: 0x04000576 RID: 1398
		private static readonly Debug.get_diagnosticSwitchesDelegate get_diagnosticSwitchesDelegateField;

		// Token: 0x02000494 RID: 1172
		// (Invoke) Token: 0x0600321F RID: 12831
		private delegate void BreakDelegate();

		// Token: 0x02000495 RID: 1173
		// (Invoke) Token: 0x06003221 RID: 12833
		private delegate void DebugBreakDelegate();

		// Token: 0x02000496 RID: 1174
		// (Invoke) Token: 0x06003223 RID: 12835
		private delegate void ClearDeveloperConsoleDelegate();

		// Token: 0x02000497 RID: 1175
		// (Invoke) Token: 0x06003225 RID: 12837
		private delegate bool get_developerConsoleEnabledDelegate();

		// Token: 0x02000498 RID: 1176
		// (Invoke) Token: 0x06003227 RID: 12839
		private delegate void set_developerConsoleEnabledDelegate(bool value);

		// Token: 0x02000499 RID: 1177
		// (Invoke) Token: 0x06003229 RID: 12841
		private delegate bool get_developerConsoleVisibleDelegate();

		// Token: 0x0200049A RID: 1178
		// (Invoke) Token: 0x0600322B RID: 12843
		private delegate void OpenConsoleFileDelegate();

		// Token: 0x0200049B RID: 1179
		// (Invoke) Token: 0x0600322D RID: 12845
		private delegate IntPtr get_diagnosticSwitchesDelegate();
	}
}

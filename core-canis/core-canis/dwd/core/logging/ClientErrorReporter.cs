using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.logging
{
	// Token: 0x02000173 RID: 371
	public sealed class ClientErrorReporter : MonoBehaviour
	{
		// Token: 0x06001555 RID: 5461 RVA: 0x00069584 File Offset: 0x00067784
		// Note: this type is marked as 'beforefieldinit'.
		static ClientErrorReporter()
		{
			Il2CppClassPointerStore<ClientErrorReporter>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.logging", "ClientErrorReporter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientErrorReporter>.NativeClassPtr);
			ClientErrorReporter.NativeFieldInfoPtr_REPEAT_THRESHOLD_MILLISECONDS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientErrorReporter>.NativeClassPtr, "REPEAT_THRESHOLD_MILLISECONDS");
			ClientErrorReporter.NativeFieldInfoPtr_REPEAT_THRESHOLD_SECONDS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientErrorReporter>.NativeClassPtr, "REPEAT_THRESHOLD_SECONDS");
			ClientErrorReporter.NativeFieldInfoPtr_errorHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientErrorReporter>.NativeClassPtr, "errorHandlers");
			ClientErrorReporter.NativeFieldInfoPtr_HandleError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientErrorReporter>.NativeClassPtr, "HandleError");
			ClientErrorReporter.NativeFieldInfoPtr_exceptionQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientErrorReporter>.NativeClassPtr, "exceptionQueue");
			ClientErrorReporter.NativeFieldInfoPtr_repeatExceptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientErrorReporter>.NativeClassPtr, "repeatExceptions");
			ClientErrorReporter.NativeFieldInfoPtr_nextRepeatPurge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientErrorReporter>.NativeClassPtr, "nextRepeatPurge");
			ClientErrorReporter.NativeMethodInfoPtr_add_HandleError_Public_add_Void_Action_3_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientErrorReporter>.NativeClassPtr, 100666518);
			ClientErrorReporter.NativeMethodInfoPtr_remove_HandleError_Public_rem_Void_Action_3_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientErrorReporter>.NativeClassPtr, 100666519);
			ClientErrorReporter.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientErrorReporter>.NativeClassPtr, 100666520);
			ClientErrorReporter.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientErrorReporter>.NativeClassPtr, 100666521);
			ClientErrorReporter.NativeMethodInfoPtr_RegisterErrorHandler_Public_Void_IClientErrorHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientErrorReporter>.NativeClassPtr, 100666522);
			ClientErrorReporter.NativeMethodInfoPtr_RemoveErrorHandler_Public_Void_IClientErrorHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientErrorReporter>.NativeClassPtr, 100666523);
			ClientErrorReporter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientErrorReporter>.NativeClassPtr, 100666524);
			ClientErrorReporter.NativeMethodInfoPtr_onHandleLogCallback_Private_Void_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientErrorReporter>.NativeClassPtr, 100666525);
			ClientErrorReporter.NativeMethodInfoPtr_onHandleUnresolvedException_Private_Void_Object_UnhandledExceptionEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientErrorReporter>.NativeClassPtr, 100666526);
			ClientErrorReporter.NativeMethodInfoPtr_queueErrorReport_Private_Void_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientErrorReporter>.NativeClassPtr, 100666527);
			ClientErrorReporter.NativeMethodInfoPtr_generateContextInfoForErrorReport_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientErrorReporter>.NativeClassPtr, 100666528);
			ClientErrorReporter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientErrorReporter>.NativeClassPtr, 100666529);
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x00069730 File Offset: 0x00067930
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 876132, RefRangeEnd = 876133, XrefRangeStart = 876127, XrefRangeEnd = 876132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_HandleError(Action<string, string, LogType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientErrorReporter.NativeMethodInfoPtr_add_HandleError_Public_add_Void_Action_3_String_String_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x00069774 File Offset: 0x00067974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876133, XrefRangeEnd = 876138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_HandleError(Action<string, string, LogType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientErrorReporter.NativeMethodInfoPtr_remove_HandleError_Public_rem_Void_Action_3_String_String_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x000697B8 File Offset: 0x000679B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876138, XrefRangeEnd = 876154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientErrorReporter.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x000697EC File Offset: 0x000679EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876154, XrefRangeEnd = 876170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientErrorReporter.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x00069820 File Offset: 0x00067A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876170, XrefRangeEnd = 876176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterErrorHandler(IClientErrorHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientErrorReporter.NativeMethodInfoPtr_RegisterErrorHandler_Public_Void_IClientErrorHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x00069864 File Offset: 0x00067A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876176, XrefRangeEnd = 876180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveErrorHandler(IClientErrorHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientErrorReporter.NativeMethodInfoPtr_RemoveErrorHandler_Public_Void_IClientErrorHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x000698A8 File Offset: 0x00067AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876180, XrefRangeEnd = 876217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientErrorReporter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x000698DC File Offset: 0x00067ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876217, XrefRangeEnd = 876218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onHandleLogCallback(string logString, string stackTrace, LogType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(logString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientErrorReporter.NativeMethodInfoPtr_onHandleLogCallback_Private_Void_String_String_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00069940 File Offset: 0x00067B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876218, XrefRangeEnd = 876222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onHandleUnresolvedException(global::Il2CppSystem.Object sender, UnhandledExceptionEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientErrorReporter.NativeMethodInfoPtr_onHandleUnresolvedException_Private_Void_Object_UnhandledExceptionEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00069994 File Offset: 0x00067B94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 876250, RefRangeEnd = 876252, XrefRangeStart = 876222, XrefRangeEnd = 876250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void queueErrorReport(string logString, string stackTrace, LogType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(logString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientErrorReporter.NativeMethodInfoPtr_queueErrorReport_Private_Void_String_String_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x000699F8 File Offset: 0x00067BF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 876286, RefRangeEnd = 876287, XrefRangeStart = 876252, XrefRangeEnd = 876286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string generateContextInfoForErrorReport()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientErrorReporter.NativeMethodInfoPtr_generateContextInfoForErrorReport_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x00069A24 File Offset: 0x00067C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876287, XrefRangeEnd = 876309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientErrorReporter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientErrorReporter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientErrorReporter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x00009699 File Offset: 0x00007899
		public ClientErrorReporter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001563 RID: 5475 RVA: 0x00069A60 File Offset: 0x00067C60
		// (set) Token: 0x06001564 RID: 5476 RVA: 0x000096A2 File Offset: 0x000078A2
		public unsafe static int REPEAT_THRESHOLD_MILLISECONDS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ClientErrorReporter.NativeFieldInfoPtr_REPEAT_THRESHOLD_MILLISECONDS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClientErrorReporter.NativeFieldInfoPtr_REPEAT_THRESHOLD_MILLISECONDS, (void*)(&value));
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001565 RID: 5477 RVA: 0x00069A7C File Offset: 0x00067C7C
		// (set) Token: 0x06001566 RID: 5478 RVA: 0x000096B0 File Offset: 0x000078B0
		public unsafe static float REPEAT_THRESHOLD_SECONDS
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ClientErrorReporter.NativeFieldInfoPtr_REPEAT_THRESHOLD_SECONDS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClientErrorReporter.NativeFieldInfoPtr_REPEAT_THRESHOLD_SECONDS, (void*)(&value));
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001567 RID: 5479 RVA: 0x00069A98 File Offset: 0x00067C98
		// (set) Token: 0x06001568 RID: 5480 RVA: 0x000096BE File Offset: 0x000078BE
		public unsafe List<IClientErrorHandler> errorHandlers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientErrorReporter.NativeFieldInfoPtr_errorHandlers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IClientErrorHandler>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientErrorReporter.NativeFieldInfoPtr_errorHandlers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x00069AC8 File Offset: 0x00067CC8
		// (set) Token: 0x0600156A RID: 5482 RVA: 0x000096DD File Offset: 0x000078DD
		public unsafe Action<string, string, LogType> HandleError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientErrorReporter.NativeFieldInfoPtr_HandleError);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, string, LogType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientErrorReporter.NativeFieldInfoPtr_HandleError), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x00069AF8 File Offset: 0x00067CF8
		// (set) Token: 0x0600156C RID: 5484 RVA: 0x000096FC File Offset: 0x000078FC
		public unsafe ConcurrentQueue<ClientErrorReporter.ExceptionInfo> exceptionQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientErrorReporter.NativeFieldInfoPtr_exceptionQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentQueue<ClientErrorReporter.ExceptionInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientErrorReporter.NativeFieldInfoPtr_exceptionQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x00069B28 File Offset: 0x00067D28
		// (set) Token: 0x0600156E RID: 5486 RVA: 0x0000971B File Offset: 0x0000791B
		public unsafe List<ClientErrorReporter.ExceptionInfo> repeatExceptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientErrorReporter.NativeFieldInfoPtr_repeatExceptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ClientErrorReporter.ExceptionInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientErrorReporter.NativeFieldInfoPtr_repeatExceptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x0600156F RID: 5487 RVA: 0x00069B58 File Offset: 0x00067D58
		// (set) Token: 0x06001570 RID: 5488 RVA: 0x0000973A File Offset: 0x0000793A
		public unsafe float nextRepeatPurge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientErrorReporter.NativeFieldInfoPtr_nextRepeatPurge);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientErrorReporter.NativeFieldInfoPtr_nextRepeatPurge)) = value;
			}
		}

		// Token: 0x04000F2E RID: 3886
		private static readonly IntPtr NativeFieldInfoPtr_REPEAT_THRESHOLD_MILLISECONDS;

		// Token: 0x04000F2F RID: 3887
		private static readonly IntPtr NativeFieldInfoPtr_REPEAT_THRESHOLD_SECONDS;

		// Token: 0x04000F30 RID: 3888
		private static readonly IntPtr NativeFieldInfoPtr_errorHandlers;

		// Token: 0x04000F31 RID: 3889
		private static readonly IntPtr NativeFieldInfoPtr_HandleError;

		// Token: 0x04000F32 RID: 3890
		private static readonly IntPtr NativeFieldInfoPtr_exceptionQueue;

		// Token: 0x04000F33 RID: 3891
		private static readonly IntPtr NativeFieldInfoPtr_repeatExceptions;

		// Token: 0x04000F34 RID: 3892
		private static readonly IntPtr NativeFieldInfoPtr_nextRepeatPurge;

		// Token: 0x04000F35 RID: 3893
		private static readonly IntPtr NativeMethodInfoPtr_add_HandleError_Public_add_Void_Action_3_String_String_LogType_0;

		// Token: 0x04000F36 RID: 3894
		private static readonly IntPtr NativeMethodInfoPtr_remove_HandleError_Public_rem_Void_Action_3_String_String_LogType_0;

		// Token: 0x04000F37 RID: 3895
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000F38 RID: 3896
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000F39 RID: 3897
		private static readonly IntPtr NativeMethodInfoPtr_RegisterErrorHandler_Public_Void_IClientErrorHandler_0;

		// Token: 0x04000F3A RID: 3898
		private static readonly IntPtr NativeMethodInfoPtr_RemoveErrorHandler_Public_Void_IClientErrorHandler_0;

		// Token: 0x04000F3B RID: 3899
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000F3C RID: 3900
		private static readonly IntPtr NativeMethodInfoPtr_onHandleLogCallback_Private_Void_String_String_LogType_0;

		// Token: 0x04000F3D RID: 3901
		private static readonly IntPtr NativeMethodInfoPtr_onHandleUnresolvedException_Private_Void_Object_UnhandledExceptionEventArgs_0;

		// Token: 0x04000F3E RID: 3902
		private static readonly IntPtr NativeMethodInfoPtr_queueErrorReport_Private_Void_String_String_LogType_0;

		// Token: 0x04000F3F RID: 3903
		private static readonly IntPtr NativeMethodInfoPtr_generateContextInfoForErrorReport_Private_Static_String_0;

		// Token: 0x04000F40 RID: 3904
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002EC RID: 748
		public class ExceptionInfo : global::Il2CppSystem.Object
		{
			// Token: 0x0600229C RID: 8860 RVA: 0x000994D8 File Offset: 0x000976D8
			// Note: this type is marked as 'beforefieldinit'.
			static ExceptionInfo()
			{
				Il2CppClassPointerStore<ClientErrorReporter.ExceptionInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientErrorReporter>.NativeClassPtr, "ExceptionInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientErrorReporter.ExceptionInfo>.NativeClassPtr);
				ClientErrorReporter.ExceptionInfo.NativeFieldInfoPtr_LogString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientErrorReporter.ExceptionInfo>.NativeClassPtr, "LogString");
				ClientErrorReporter.ExceptionInfo.NativeFieldInfoPtr_StackTrace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientErrorReporter.ExceptionInfo>.NativeClassPtr, "StackTrace");
				ClientErrorReporter.ExceptionInfo.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientErrorReporter.ExceptionInfo>.NativeClassPtr, "Type");
				ClientErrorReporter.ExceptionInfo.NativeFieldInfoPtr_LastOccurence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientErrorReporter.ExceptionInfo>.NativeClassPtr, "LastOccurence");
				ClientErrorReporter.ExceptionInfo.NativeMethodInfoPtr__ctor_Public_Void_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientErrorReporter.ExceptionInfo>.NativeClassPtr, 100666530);
			}

			// Token: 0x0600229D RID: 8861 RVA: 0x00099568 File Offset: 0x00097768
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExceptionInfo(string logString, string stackTrace, LogType type)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientErrorReporter.ExceptionInfo>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(logString);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientErrorReporter.ExceptionInfo.NativeMethodInfoPtr__ctor_Public_Void_String_String_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600229E RID: 8862 RVA: 0x0000EDED File Offset: 0x0000CFED
			public ExceptionInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000975 RID: 2421
			// (get) Token: 0x0600229F RID: 8863 RVA: 0x000995D4 File Offset: 0x000977D4
			// (set) Token: 0x060022A0 RID: 8864 RVA: 0x0000EDF6 File Offset: 0x0000CFF6
			public unsafe string LogString
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientErrorReporter.ExceptionInfo.NativeFieldInfoPtr_LogString);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientErrorReporter.ExceptionInfo.NativeFieldInfoPtr_LogString), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000976 RID: 2422
			// (get) Token: 0x060022A1 RID: 8865 RVA: 0x000995FC File Offset: 0x000977FC
			// (set) Token: 0x060022A2 RID: 8866 RVA: 0x0000EE15 File Offset: 0x0000D015
			public unsafe string StackTrace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientErrorReporter.ExceptionInfo.NativeFieldInfoPtr_StackTrace);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientErrorReporter.ExceptionInfo.NativeFieldInfoPtr_StackTrace), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000977 RID: 2423
			// (get) Token: 0x060022A3 RID: 8867 RVA: 0x00099624 File Offset: 0x00097824
			// (set) Token: 0x060022A4 RID: 8868 RVA: 0x0000EE34 File Offset: 0x0000D034
			public unsafe LogType Type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientErrorReporter.ExceptionInfo.NativeFieldInfoPtr_Type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientErrorReporter.ExceptionInfo.NativeFieldInfoPtr_Type)) = value;
				}
			}

			// Token: 0x17000978 RID: 2424
			// (get) Token: 0x060022A5 RID: 8869 RVA: 0x0009964C File Offset: 0x0009784C
			// (set) Token: 0x060022A6 RID: 8870 RVA: 0x0000EE4F File Offset: 0x0000D04F
			public unsafe int LastOccurence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientErrorReporter.ExceptionInfo.NativeFieldInfoPtr_LastOccurence);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientErrorReporter.ExceptionInfo.NativeFieldInfoPtr_LastOccurence)) = value;
				}
			}

			// Token: 0x040017E5 RID: 6117
			private static readonly IntPtr NativeFieldInfoPtr_LogString;

			// Token: 0x040017E6 RID: 6118
			private static readonly IntPtr NativeFieldInfoPtr_StackTrace;

			// Token: 0x040017E7 RID: 6119
			private static readonly IntPtr NativeFieldInfoPtr_Type;

			// Token: 0x040017E8 RID: 6120
			private static readonly IntPtr NativeFieldInfoPtr_LastOccurence;

			// Token: 0x040017E9 RID: 6121
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_LogType_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x0200020E RID: 526
	public class ServicePointScheduler : Object
	{
		// Token: 0x060022BF RID: 8895 RVA: 0x000A1C70 File Offset: 0x0009FE70
		// Note: this type is marked as 'beforefieldinit'.
		static ServicePointScheduler()
		{
			Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ServicePointScheduler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr);
			ServicePointScheduler.NativeFieldInfoPtr__ServicePoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "<ServicePoint>k__BackingField");
			ServicePointScheduler.NativeFieldInfoPtr_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "running");
			ServicePointScheduler.NativeFieldInfoPtr_maxIdleTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "maxIdleTime");
			ServicePointScheduler.NativeFieldInfoPtr_schedulerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "schedulerEvent");
			ServicePointScheduler.NativeFieldInfoPtr_defaultGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "defaultGroup");
			ServicePointScheduler.NativeFieldInfoPtr_groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "groups");
			ServicePointScheduler.NativeFieldInfoPtr_operations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "operations");
			ServicePointScheduler.NativeFieldInfoPtr_idleConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "idleConnections");
			ServicePointScheduler.NativeFieldInfoPtr_currentConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "currentConnections");
			ServicePointScheduler.NativeFieldInfoPtr_connectionLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "connectionLimit");
			ServicePointScheduler.NativeFieldInfoPtr_idleSince = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "idleSince");
			ServicePointScheduler.NativeFieldInfoPtr_nextId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "nextId");
			ServicePointScheduler.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "ID");
			ServicePointScheduler.NativeMethodInfoPtr_get_ServicePoint_Private_get_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100668439);
			ServicePointScheduler.NativeMethodInfoPtr_set_ServicePoint_Private_set_Void_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100668440);
			ServicePointScheduler.NativeMethodInfoPtr_get_MaxIdleTime_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100668441);
			ServicePointScheduler.NativeMethodInfoPtr__ctor_Public_Void_ServicePoint_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100668442);
			ServicePointScheduler.NativeMethodInfoPtr_Run_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100668443);
			ServicePointScheduler.NativeMethodInfoPtr_RunScheduler_Private_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100668444);
			ServicePointScheduler.NativeMethodInfoPtr_Cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100668445);
			ServicePointScheduler.NativeMethodInfoPtr_RunSchedulerIteration_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100668446);
			ServicePointScheduler.NativeMethodInfoPtr_OperationCompleted_Private_Boolean_ConnectionGroup_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100668447);
			ServicePointScheduler.NativeMethodInfoPtr_CloseIdleConnection_Private_Void_ConnectionGroup_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100668448);
			ServicePointScheduler.NativeMethodInfoPtr_SchedulerIteration_Private_Boolean_ConnectionGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100668449);
			ServicePointScheduler.NativeMethodInfoPtr_RemoveOperation_Private_Void_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100668450);
			ServicePointScheduler.NativeMethodInfoPtr_RemoveIdleConnection_Private_Void_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100668451);
			ServicePointScheduler.NativeMethodInfoPtr_FinalCleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100668452);
			ServicePointScheduler.NativeMethodInfoPtr_SendRequest_Public_Void_WebOperation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100668453);
			ServicePointScheduler.NativeMethodInfoPtr_CloseConnectionGroup_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100668454);
			ServicePointScheduler.NativeMethodInfoPtr_GetConnectionGroup_Private_ConnectionGroup_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100668455);
			ServicePointScheduler.NativeMethodInfoPtr_OnConnectionCreated_Private_Void_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100668456);
			ServicePointScheduler.NativeMethodInfoPtr_OnConnectionClosed_Private_Void_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100668457);
			ServicePointScheduler.NativeMethodInfoPtr_WaitAsync_Public_Static_Task_1_Boolean_Task_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100668458);
			ServicePointScheduler.NativeMethodInfoPtr__Run_b__31_0_Private_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, 100668459);
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x060022C0 RID: 8896 RVA: 0x000A1F48 File Offset: 0x000A0148
		// (set) Token: 0x060022C1 RID: 8897 RVA: 0x000A1F88 File Offset: 0x000A0188
		public unsafe ServicePoint ServicePoint
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_get_ServicePoint_Private_get_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_set_ServicePoint_Private_set_Void_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x060022C2 RID: 8898 RVA: 0x000A1FCC File Offset: 0x000A01CC
		public unsafe int MaxIdleTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_get_MaxIdleTime_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x000A2008 File Offset: 0x000A0208
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 484005, RefRangeEnd = 484007, XrefRangeStart = 483963, XrefRangeEnd = 484005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServicePointScheduler(ServicePoint servicePoint, int connectionLimit, int maxIdleTime)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(servicePoint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref connectionLimit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxIdleTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr__ctor_Public_Void_ServicePoint_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x000A2070 File Offset: 0x000A0270
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 484020, RefRangeEnd = 484022, XrefRangeStart = 484007, XrefRangeEnd = 484020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Run()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_Run_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x000A20A4 File Offset: 0x000A02A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484022, XrefRangeEnd = 484032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task RunScheduler()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_RunScheduler_Private_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x000A20E4 File Offset: 0x000A02E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484032, XrefRangeEnd = 484058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_Cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x000A2118 File Offset: 0x000A0318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484058, XrefRangeEnd = 484086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunSchedulerIteration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_RunSchedulerIteration_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x000A214C File Offset: 0x000A034C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484086, XrefRangeEnd = 484112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OperationCompleted(ServicePointScheduler.ConnectionGroup group, WebOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(operation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_OperationCompleted_Private_Boolean_ConnectionGroup_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x000A21AC File Offset: 0x000A03AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484112, XrefRangeEnd = 484115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseIdleConnection(ServicePointScheduler.ConnectionGroup group, WebConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_CloseIdleConnection_Private_Void_ConnectionGroup_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x000A2200 File Offset: 0x000A0400
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 484129, RefRangeEnd = 484131, XrefRangeStart = 484115, XrefRangeEnd = 484129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SchedulerIteration(ServicePointScheduler.ConnectionGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_SchedulerIteration_Private_Boolean_ConnectionGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x000A2250 File Offset: 0x000A0450
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 484140, RefRangeEnd = 484143, XrefRangeStart = 484131, XrefRangeEnd = 484140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOperation(WebOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_RemoveOperation_Private_Void_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x000A2294 File Offset: 0x000A0494
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 484151, RefRangeEnd = 484156, XrefRangeStart = 484143, XrefRangeEnd = 484151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveIdleConnection(WebConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_RemoveIdleConnection_Private_Void_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x000A22D8 File Offset: 0x000A04D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484156, XrefRangeEnd = 484174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalCleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_FinalCleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x000A230C File Offset: 0x000A050C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484183, RefRangeEnd = 484184, XrefRangeStart = 484174, XrefRangeEnd = 484183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRequest(WebOperation operation, string groupName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(groupName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_SendRequest_Public_Void_WebOperation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x000A2360 File Offset: 0x000A0560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484184, XrefRangeEnd = 484191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CloseConnectionGroup(string groupName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(groupName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_CloseConnectionGroup_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x000A23B0 File Offset: 0x000A05B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484217, RefRangeEnd = 484218, XrefRangeStart = 484191, XrefRangeEnd = 484217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServicePointScheduler.ConnectionGroup GetConnectionGroup(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_GetConnectionGroup_Private_ConnectionGroup_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler.ConnectionGroup>(intPtr3) : null;
			}
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x000A2400 File Offset: 0x000A0600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484218, XrefRangeEnd = 484219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnConnectionCreated(WebConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_OnConnectionCreated_Private_Void_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x000A2444 File Offset: 0x000A0644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484219, XrefRangeEnd = 484221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnConnectionClosed(WebConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_OnConnectionClosed_Private_Void_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x000A2488 File Offset: 0x000A0688
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484235, RefRangeEnd = 484236, XrefRangeStart = 484221, XrefRangeEnd = 484235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<bool> WaitAsync(Task workerTask, int millisecondTimeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(workerTask);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr_WaitAsync_Public_Static_Task_1_Boolean_Task_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x000A24DC File Offset: 0x000A06DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task _Run_b__31_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.NativeMethodInfoPtr__Run_b__31_0_Private_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x0000F06F File Offset: 0x0000D26F
		public ServicePointScheduler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x060022D6 RID: 8918 RVA: 0x000A251C File Offset: 0x000A071C
		// (set) Token: 0x060022D7 RID: 8919 RVA: 0x0000F078 File Offset: 0x0000D278
		public unsafe ServicePoint _ServicePoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr__ServicePoint_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr__ServicePoint_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x060022D8 RID: 8920 RVA: 0x000A254C File Offset: 0x000A074C
		// (set) Token: 0x060022D9 RID: 8921 RVA: 0x0000F097 File Offset: 0x0000D297
		public unsafe int running
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_running);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_running)) = value;
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x060022DA RID: 8922 RVA: 0x000A2574 File Offset: 0x000A0774
		// (set) Token: 0x060022DB RID: 8923 RVA: 0x0000F0B2 File Offset: 0x0000D2B2
		public unsafe int maxIdleTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_maxIdleTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_maxIdleTime)) = value;
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x060022DC RID: 8924 RVA: 0x000A259C File Offset: 0x000A079C
		// (set) Token: 0x060022DD RID: 8925 RVA: 0x0000F0CD File Offset: 0x0000D2CD
		public unsafe ServicePointScheduler.AsyncManualResetEvent schedulerEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_schedulerEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler.AsyncManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_schedulerEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x060022DE RID: 8926 RVA: 0x000A25CC File Offset: 0x000A07CC
		// (set) Token: 0x060022DF RID: 8927 RVA: 0x0000F0EC File Offset: 0x0000D2EC
		public unsafe ServicePointScheduler.ConnectionGroup defaultGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_defaultGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler.ConnectionGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_defaultGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x060022E0 RID: 8928 RVA: 0x000A25FC File Offset: 0x000A07FC
		// (set) Token: 0x060022E1 RID: 8929 RVA: 0x0000F10B File Offset: 0x0000D30B
		public unsafe Dictionary<string, ServicePointScheduler.ConnectionGroup> groups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_groups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ServicePointScheduler.ConnectionGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_groups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x060022E2 RID: 8930 RVA: 0x000A262C File Offset: 0x000A082C
		// (set) Token: 0x060022E3 RID: 8931 RVA: 0x0000F12A File Offset: 0x0000D32A
		public unsafe LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>> operations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_operations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_operations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x060022E4 RID: 8932 RVA: 0x000A265C File Offset: 0x000A085C
		// (set) Token: 0x060022E5 RID: 8933 RVA: 0x0000F149 File Offset: 0x0000D349
		public unsafe LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>> idleConnections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_idleConnections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_idleConnections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x060022E6 RID: 8934 RVA: 0x000A268C File Offset: 0x000A088C
		// (set) Token: 0x060022E7 RID: 8935 RVA: 0x0000F168 File Offset: 0x0000D368
		public unsafe int currentConnections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_currentConnections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_currentConnections)) = value;
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x060022E8 RID: 8936 RVA: 0x000A26B4 File Offset: 0x000A08B4
		// (set) Token: 0x060022E9 RID: 8937 RVA: 0x0000F183 File Offset: 0x0000D383
		public unsafe int connectionLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_connectionLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_connectionLimit)) = value;
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x060022EA RID: 8938 RVA: 0x000A26DC File Offset: 0x000A08DC
		// (set) Token: 0x060022EB RID: 8939 RVA: 0x0000F19E File Offset: 0x0000D39E
		public unsafe DateTime idleSince
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_idleSince);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_idleSince)) = value;
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x060022EC RID: 8940 RVA: 0x000A2704 File Offset: 0x000A0904
		// (set) Token: 0x060022ED RID: 8941 RVA: 0x0000F1B9 File Offset: 0x0000D3B9
		public unsafe static int nextId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ServicePointScheduler.NativeFieldInfoPtr_nextId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointScheduler.NativeFieldInfoPtr_nextId, (void*)(&value));
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x060022EE RID: 8942 RVA: 0x000A2720 File Offset: 0x000A0920
		// (set) Token: 0x060022EF RID: 8943 RVA: 0x0000F1C7 File Offset: 0x0000D3C7
		public unsafe int ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_ID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.NativeFieldInfoPtr_ID)) = value;
			}
		}

		// Token: 0x04001AFF RID: 6911
		private static readonly IntPtr NativeFieldInfoPtr__ServicePoint_k__BackingField;

		// Token: 0x04001B00 RID: 6912
		private static readonly IntPtr NativeFieldInfoPtr_running;

		// Token: 0x04001B01 RID: 6913
		private static readonly IntPtr NativeFieldInfoPtr_maxIdleTime;

		// Token: 0x04001B02 RID: 6914
		private static readonly IntPtr NativeFieldInfoPtr_schedulerEvent;

		// Token: 0x04001B03 RID: 6915
		private static readonly IntPtr NativeFieldInfoPtr_defaultGroup;

		// Token: 0x04001B04 RID: 6916
		private static readonly IntPtr NativeFieldInfoPtr_groups;

		// Token: 0x04001B05 RID: 6917
		private static readonly IntPtr NativeFieldInfoPtr_operations;

		// Token: 0x04001B06 RID: 6918
		private static readonly IntPtr NativeFieldInfoPtr_idleConnections;

		// Token: 0x04001B07 RID: 6919
		private static readonly IntPtr NativeFieldInfoPtr_currentConnections;

		// Token: 0x04001B08 RID: 6920
		private static readonly IntPtr NativeFieldInfoPtr_connectionLimit;

		// Token: 0x04001B09 RID: 6921
		private static readonly IntPtr NativeFieldInfoPtr_idleSince;

		// Token: 0x04001B0A RID: 6922
		private static readonly IntPtr NativeFieldInfoPtr_nextId;

		// Token: 0x04001B0B RID: 6923
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04001B0C RID: 6924
		private static readonly IntPtr NativeMethodInfoPtr_get_ServicePoint_Private_get_ServicePoint_0;

		// Token: 0x04001B0D RID: 6925
		private static readonly IntPtr NativeMethodInfoPtr_set_ServicePoint_Private_set_Void_ServicePoint_0;

		// Token: 0x04001B0E RID: 6926
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxIdleTime_Public_get_Int32_0;

		// Token: 0x04001B0F RID: 6927
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServicePoint_Int32_Int32_0;

		// Token: 0x04001B10 RID: 6928
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Void_0;

		// Token: 0x04001B11 RID: 6929
		private static readonly IntPtr NativeMethodInfoPtr_RunScheduler_Private_Task_0;

		// Token: 0x04001B12 RID: 6930
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_0;

		// Token: 0x04001B13 RID: 6931
		private static readonly IntPtr NativeMethodInfoPtr_RunSchedulerIteration_Private_Void_0;

		// Token: 0x04001B14 RID: 6932
		private static readonly IntPtr NativeMethodInfoPtr_OperationCompleted_Private_Boolean_ConnectionGroup_WebOperation_0;

		// Token: 0x04001B15 RID: 6933
		private static readonly IntPtr NativeMethodInfoPtr_CloseIdleConnection_Private_Void_ConnectionGroup_WebConnection_0;

		// Token: 0x04001B16 RID: 6934
		private static readonly IntPtr NativeMethodInfoPtr_SchedulerIteration_Private_Boolean_ConnectionGroup_0;

		// Token: 0x04001B17 RID: 6935
		private static readonly IntPtr NativeMethodInfoPtr_RemoveOperation_Private_Void_WebOperation_0;

		// Token: 0x04001B18 RID: 6936
		private static readonly IntPtr NativeMethodInfoPtr_RemoveIdleConnection_Private_Void_WebConnection_0;

		// Token: 0x04001B19 RID: 6937
		private static readonly IntPtr NativeMethodInfoPtr_FinalCleanup_Private_Void_0;

		// Token: 0x04001B1A RID: 6938
		private static readonly IntPtr NativeMethodInfoPtr_SendRequest_Public_Void_WebOperation_String_0;

		// Token: 0x04001B1B RID: 6939
		private static readonly IntPtr NativeMethodInfoPtr_CloseConnectionGroup_Public_Boolean_String_0;

		// Token: 0x04001B1C RID: 6940
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionGroup_Private_ConnectionGroup_String_0;

		// Token: 0x04001B1D RID: 6941
		private static readonly IntPtr NativeMethodInfoPtr_OnConnectionCreated_Private_Void_WebConnection_0;

		// Token: 0x04001B1E RID: 6942
		private static readonly IntPtr NativeMethodInfoPtr_OnConnectionClosed_Private_Void_WebConnection_0;

		// Token: 0x04001B1F RID: 6943
		private static readonly IntPtr NativeMethodInfoPtr_WaitAsync_Public_Static_Task_1_Boolean_Task_Int32_0;

		// Token: 0x04001B20 RID: 6944
		private static readonly IntPtr NativeMethodInfoPtr__Run_b__31_0_Private_Task_0;

		// Token: 0x02000349 RID: 841
		public class ConnectionGroup : Object
		{
			// Token: 0x06003064 RID: 12388 RVA: 0x000D0F28 File Offset: 0x000CF128
			// Note: this type is marked as 'beforefieldinit'.
			static ConnectionGroup()
			{
				Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "ConnectionGroup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr);
				ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr__Scheduler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, "<Scheduler>k__BackingField");
				ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, "<Name>k__BackingField");
				ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_nextId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, "nextId");
				ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, "ID");
				ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, "connections");
				ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, "queue");
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_get_Scheduler_Public_get_ServicePointScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100668460);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr__ctor_Public_Void_ServicePointScheduler_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100668461);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100668462);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_RemoveConnection_Public_Void_WebConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100668463);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_Cleanup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100668464);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100668465);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_EnqueueOperation_Public_Void_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100668466);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_GetNextOperation_Public_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100668467);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_FindIdleConnection_Public_WebConnection_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100668468);
				ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_CreateOrReuseConnection_Public_ValueTuple_2_WebConnection_Boolean_WebOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr, 100668469);
			}

			// Token: 0x17000F32 RID: 3890
			// (get) Token: 0x06003065 RID: 12389 RVA: 0x000D1094 File Offset: 0x000CF294
			public unsafe ServicePointScheduler Scheduler
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_get_Scheduler_Public_get_ServicePointScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler>(intPtr3) : null;
				}
			}

			// Token: 0x06003066 RID: 12390 RVA: 0x000D10D4 File Offset: 0x000CF2D4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 483542, RefRangeEnd = 483544, XrefRangeStart = 483523, XrefRangeEnd = 483542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConnectionGroup(ServicePointScheduler scheduler, string name)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePointScheduler.ConnectionGroup>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr__ctor_Public_Void_ServicePointScheduler_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003067 RID: 12391 RVA: 0x000D1134 File Offset: 0x000CF334
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 483546, RefRangeEnd = 483548, XrefRangeStart = 483544, XrefRangeEnd = 483546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsEmpty()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003068 RID: 12392 RVA: 0x000D1170 File Offset: 0x000CF370
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 483556, RefRangeEnd = 483558, XrefRangeStart = 483548, XrefRangeEnd = 483556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RemoveConnection(WebConnection connection)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_RemoveConnection_Public_Void_WebConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003069 RID: 12393 RVA: 0x000D11B4 File Offset: 0x000CF3B4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 483568, RefRangeEnd = 483570, XrefRangeStart = 483558, XrefRangeEnd = 483568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Cleanup()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_Cleanup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600306A RID: 12394 RVA: 0x000D11E8 File Offset: 0x000CF3E8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 483613, RefRangeEnd = 483614, XrefRangeStart = 483570, XrefRangeEnd = 483613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Close()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600306B RID: 12395 RVA: 0x000D121C File Offset: 0x000CF41C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483614, XrefRangeEnd = 483618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EnqueueOperation(WebOperation operation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_EnqueueOperation_Public_Void_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600306C RID: 12396 RVA: 0x000D1260 File Offset: 0x000CF460
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483618, XrefRangeEnd = 483629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WebOperation GetNextOperation()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_GetNextOperation_Public_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr3) : null;
			}

			// Token: 0x0600306D RID: 12397 RVA: 0x000D12A0 File Offset: 0x000CF4A0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 483652, RefRangeEnd = 483653, XrefRangeStart = 483629, XrefRangeEnd = 483652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WebConnection FindIdleConnection(WebOperation operation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_FindIdleConnection_Public_WebConnection_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebConnection>(intPtr3) : null;
				}
			}

			// Token: 0x0600306E RID: 12398 RVA: 0x000D12F0 File Offset: 0x000CF4F0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 483661, RefRangeEnd = 483662, XrefRangeStart = 483653, XrefRangeEnd = 483661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<WebConnection, bool> CreateOrReuseConnection(WebOperation operation, bool force)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.ConnectionGroup.NativeMethodInfoPtr_CreateOrReuseConnection_Public_ValueTuple_2_WebConnection_Boolean_WebOperation_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<WebConnection, bool>(intPtr);
			}

			// Token: 0x0600306F RID: 12399 RVA: 0x0001611D File Offset: 0x0001431D
			public ConnectionGroup(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F2C RID: 3884
			// (get) Token: 0x06003070 RID: 12400 RVA: 0x000D1348 File Offset: 0x000CF548
			// (set) Token: 0x06003071 RID: 12401 RVA: 0x00016126 File Offset: 0x00014326
			public unsafe ServicePointScheduler _Scheduler_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr__Scheduler_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr__Scheduler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F2D RID: 3885
			// (get) Token: 0x06003072 RID: 12402 RVA: 0x000D1378 File Offset: 0x000CF578
			// (set) Token: 0x06003073 RID: 12403 RVA: 0x00016145 File Offset: 0x00014345
			public unsafe string _Name_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr__Name_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000F2E RID: 3886
			// (get) Token: 0x06003074 RID: 12404 RVA: 0x000D13A0 File Offset: 0x000CF5A0
			// (set) Token: 0x06003075 RID: 12405 RVA: 0x00016164 File Offset: 0x00014364
			public unsafe static int nextId
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_nextId, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_nextId, (void*)(&value));
				}
			}

			// Token: 0x17000F2F RID: 3887
			// (get) Token: 0x06003076 RID: 12406 RVA: 0x000D13BC File Offset: 0x000CF5BC
			// (set) Token: 0x06003077 RID: 12407 RVA: 0x00016172 File Offset: 0x00014372
			public unsafe int ID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_ID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_ID)) = value;
				}
			}

			// Token: 0x17000F30 RID: 3888
			// (get) Token: 0x06003078 RID: 12408 RVA: 0x000D13E4 File Offset: 0x000CF5E4
			// (set) Token: 0x06003079 RID: 12409 RVA: 0x0001618D File Offset: 0x0001438D
			public unsafe LinkedList<WebConnection> connections
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_connections);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<WebConnection>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_connections), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F31 RID: 3889
			// (get) Token: 0x0600307A RID: 12410 RVA: 0x000D1414 File Offset: 0x000CF614
			// (set) Token: 0x0600307B RID: 12411 RVA: 0x000161AC File Offset: 0x000143AC
			public unsafe LinkedList<WebOperation> queue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_queue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<WebOperation>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.ConnectionGroup.NativeFieldInfoPtr_queue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040025B1 RID: 9649
			private static readonly IntPtr NativeFieldInfoPtr__Scheduler_k__BackingField;

			// Token: 0x040025B2 RID: 9650
			private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

			// Token: 0x040025B3 RID: 9651
			private static readonly IntPtr NativeFieldInfoPtr_nextId;

			// Token: 0x040025B4 RID: 9652
			private static readonly IntPtr NativeFieldInfoPtr_ID;

			// Token: 0x040025B5 RID: 9653
			private static readonly IntPtr NativeFieldInfoPtr_connections;

			// Token: 0x040025B6 RID: 9654
			private static readonly IntPtr NativeFieldInfoPtr_queue;

			// Token: 0x040025B7 RID: 9655
			private static readonly IntPtr NativeMethodInfoPtr_get_Scheduler_Public_get_ServicePointScheduler_0;

			// Token: 0x040025B8 RID: 9656
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServicePointScheduler_String_0;

			// Token: 0x040025B9 RID: 9657
			private static readonly IntPtr NativeMethodInfoPtr_IsEmpty_Public_Boolean_0;

			// Token: 0x040025BA RID: 9658
			private static readonly IntPtr NativeMethodInfoPtr_RemoveConnection_Public_Void_WebConnection_0;

			// Token: 0x040025BB RID: 9659
			private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Public_Void_0;

			// Token: 0x040025BC RID: 9660
			private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

			// Token: 0x040025BD RID: 9661
			private static readonly IntPtr NativeMethodInfoPtr_EnqueueOperation_Public_Void_WebOperation_0;

			// Token: 0x040025BE RID: 9662
			private static readonly IntPtr NativeMethodInfoPtr_GetNextOperation_Public_WebOperation_0;

			// Token: 0x040025BF RID: 9663
			private static readonly IntPtr NativeMethodInfoPtr_FindIdleConnection_Public_WebConnection_WebOperation_0;

			// Token: 0x040025C0 RID: 9664
			private static readonly IntPtr NativeMethodInfoPtr_CreateOrReuseConnection_Public_ValueTuple_2_WebConnection_Boolean_WebOperation_Boolean_0;
		}

		// Token: 0x0200034A RID: 842
		public class AsyncManualResetEvent : Object
		{
			// Token: 0x0600307C RID: 12412 RVA: 0x000D1444 File Offset: 0x000CF644
			// Note: this type is marked as 'beforefieldinit'.
			static AsyncManualResetEvent()
			{
				Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "AsyncManualResetEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr);
				ServicePointScheduler.AsyncManualResetEvent.NativeFieldInfoPtr_m_tcs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr, "m_tcs");
				ServicePointScheduler.AsyncManualResetEvent.NativeMethodInfoPtr_WaitAsync_Public_Task_1_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr, 100668470);
				ServicePointScheduler.AsyncManualResetEvent.NativeMethodInfoPtr_Set_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr, 100668471);
				ServicePointScheduler.AsyncManualResetEvent.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr, 100668472);
				ServicePointScheduler.AsyncManualResetEvent.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr, 100668473);
			}

			// Token: 0x0600307D RID: 12413 RVA: 0x000D14D4 File Offset: 0x000CF6D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483683, XrefRangeEnd = 483699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task<bool> WaitAsync(int millisecondTimeout)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref millisecondTimeout;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.AsyncManualResetEvent.NativeMethodInfoPtr_WaitAsync_Public_Task_1_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
				}
			}

			// Token: 0x0600307E RID: 12414 RVA: 0x000D1520 File Offset: 0x000CF720
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 483739, RefRangeEnd = 483741, XrefRangeStart = 483699, XrefRangeEnd = 483739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Set()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.AsyncManualResetEvent.NativeMethodInfoPtr_Set_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600307F RID: 12415 RVA: 0x000D1554 File Offset: 0x000CF754
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483741, XrefRangeEnd = 483752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.AsyncManualResetEvent.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003080 RID: 12416 RVA: 0x000D1588 File Offset: 0x000CF788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483752, XrefRangeEnd = 483762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncManualResetEvent(bool state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.AsyncManualResetEvent.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003081 RID: 12417 RVA: 0x000161CB File Offset: 0x000143CB
			public AsyncManualResetEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F33 RID: 3891
			// (get) Token: 0x06003082 RID: 12418 RVA: 0x000D15D0 File Offset: 0x000CF7D0
			// (set) Token: 0x06003083 RID: 12419 RVA: 0x000161D4 File Offset: 0x000143D4
			public unsafe TaskCompletionSource<bool> m_tcs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent.NativeFieldInfoPtr_m_tcs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskCompletionSource<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler.AsyncManualResetEvent.NativeFieldInfoPtr_m_tcs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040025C1 RID: 9665
			private static readonly IntPtr NativeFieldInfoPtr_m_tcs;

			// Token: 0x040025C2 RID: 9666
			private static readonly IntPtr NativeMethodInfoPtr_WaitAsync_Public_Task_1_Boolean_Int32_0;

			// Token: 0x040025C3 RID: 9667
			private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_0;

			// Token: 0x040025C4 RID: 9668
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

			// Token: 0x040025C5 RID: 9669
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

			// Token: 0x020003C5 RID: 965
			[ObfuscatedName("System.Net.ServicePointScheduler+AsyncManualResetEvent+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x060035E5 RID: 13797 RVA: 0x000DF8A0 File Offset: 0x000DDAA0
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent.__c>.NativeClassPtr);
					ServicePointScheduler.AsyncManualResetEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent.__c>.NativeClassPtr, "<>9");
					ServicePointScheduler.AsyncManualResetEvent.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent.__c>.NativeClassPtr, "<>9__4_0");
					ServicePointScheduler.AsyncManualResetEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent.__c>.NativeClassPtr, 100668475);
					ServicePointScheduler.AsyncManualResetEvent.__c.NativeMethodInfoPtr__Set_b__4_0_Internal_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent.__c>.NativeClassPtr, 100668476);
				}

				// Token: 0x060035E6 RID: 13798 RVA: 0x000DF91C File Offset: 0x000DDB1C
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePointScheduler.AsyncManualResetEvent.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.AsyncManualResetEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060035E7 RID: 13799 RVA: 0x000DF958 File Offset: 0x000DDB58
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483662, XrefRangeEnd = 483683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _Set_b__4_0(Object s)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler.AsyncManualResetEvent.__c.NativeMethodInfoPtr__Set_b__4_0_Internal_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060035E8 RID: 13800 RVA: 0x0001A71F File Offset: 0x0001891F
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170010D4 RID: 4308
				// (get) Token: 0x060035E9 RID: 13801 RVA: 0x000DF9A8 File Offset: 0x000DDBA8
				// (set) Token: 0x060035EA RID: 13802 RVA: 0x0001A728 File Offset: 0x00018928
				public unsafe static ServicePointScheduler.AsyncManualResetEvent.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(ServicePointScheduler.AsyncManualResetEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler.AsyncManualResetEvent.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(ServicePointScheduler.AsyncManualResetEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170010D5 RID: 4309
				// (get) Token: 0x060035EB RID: 13803 RVA: 0x000DF9D0 File Offset: 0x000DDBD0
				// (set) Token: 0x060035EC RID: 13804 RVA: 0x0001A73A File Offset: 0x0001893A
				public unsafe static Func<Object, bool> __9__4_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(ServicePointScheduler.AsyncManualResetEvent.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, bool>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(ServicePointScheduler.AsyncManualResetEvent.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040028B1 RID: 10417
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x040028B2 RID: 10418
				private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

				// Token: 0x040028B3 RID: 10419
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040028B4 RID: 10420
				private static readonly IntPtr NativeMethodInfoPtr__Set_b__4_0_Internal_Boolean_Object_0;
			}
		}

		// Token: 0x0200034B RID: 843
		[ObfuscatedName("System.Net.ServicePointScheduler+<RunScheduler>d__32")]
		public sealed class _RunScheduler_d__32 : ValueType
		{
			// Token: 0x06003084 RID: 12420 RVA: 0x000D1600 File Offset: 0x000CF800
			// Note: this type is marked as 'beforefieldinit'.
			static _RunScheduler_d__32()
			{
				Il2CppClassPointerStore<ServicePointScheduler._RunScheduler_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "<RunScheduler>d__32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePointScheduler._RunScheduler_d__32>.NativeClassPtr);
				ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._RunScheduler_d__32>.NativeClassPtr, "<>1__state");
				ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._RunScheduler_d__32>.NativeClassPtr, "<>t__builder");
				ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._RunScheduler_d__32>.NativeClassPtr, "<>4__this");
				ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr__operationArray_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._RunScheduler_d__32>.NativeClassPtr, "<operationArray>5__2");
				ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr__idleArray_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._RunScheduler_d__32>.NativeClassPtr, "<idleArray>5__3");
				ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr__taskList_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._RunScheduler_d__32>.NativeClassPtr, "<taskList>5__4");
				ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr__schedulerTask_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._RunScheduler_d__32>.NativeClassPtr, "<schedulerTask>5__5");
				ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr__finalCleanup_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._RunScheduler_d__32>.NativeClassPtr, "<finalCleanup>5__6");
				ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._RunScheduler_d__32>.NativeClassPtr, "<>u__1");
				ServicePointScheduler._RunScheduler_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler._RunScheduler_d__32>.NativeClassPtr, 100668477);
				ServicePointScheduler._RunScheduler_d__32.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler._RunScheduler_d__32>.NativeClassPtr, 100668478);
			}

			// Token: 0x06003085 RID: 12421 RVA: 0x000D1708 File Offset: 0x000CF908
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483762, XrefRangeEnd = 483913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler._RunScheduler_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003086 RID: 12422 RVA: 0x000D1740 File Offset: 0x000CF940
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483913, XrefRangeEnd = 483917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler._RunScheduler_d__32.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003087 RID: 12423 RVA: 0x000161F3 File Offset: 0x000143F3
			public _RunScheduler_d__32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003088 RID: 12424 RVA: 0x000161FC File Offset: 0x000143FC
			public _RunScheduler_d__32()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePointScheduler._RunScheduler_d__32>.NativeClassPtr))
			{
			}

			// Token: 0x17000F34 RID: 3892
			// (get) Token: 0x06003089 RID: 12425 RVA: 0x000D1788 File Offset: 0x000CF988
			// (set) Token: 0x0600308A RID: 12426 RVA: 0x0001620E File Offset: 0x0001440E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F35 RID: 3893
			// (get) Token: 0x0600308B RID: 12427 RVA: 0x000D17B0 File Offset: 0x000CF9B0
			// (set) Token: 0x0600308C RID: 12428 RVA: 0x00016229 File Offset: 0x00014429
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F36 RID: 3894
			// (get) Token: 0x0600308D RID: 12429 RVA: 0x000D17E0 File Offset: 0x000CF9E0
			// (set) Token: 0x0600308E RID: 12430 RVA: 0x00016257 File Offset: 0x00014457
			public unsafe ServicePointScheduler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F37 RID: 3895
			// (get) Token: 0x0600308F RID: 12431 RVA: 0x000D1810 File Offset: 0x000CFA10
			// (set) Token: 0x06003090 RID: 12432 RVA: 0x00016276 File Offset: 0x00014476
			public unsafe Il2CppReferenceArray<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>> _operationArray_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr__operationArray_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr__operationArray_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F38 RID: 3896
			// (get) Token: 0x06003091 RID: 12433 RVA: 0x000D1840 File Offset: 0x000CFA40
			// (set) Token: 0x06003092 RID: 12434 RVA: 0x00016295 File Offset: 0x00014495
			public unsafe Il2CppReferenceArray<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>> _idleArray_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr__idleArray_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr__idleArray_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F39 RID: 3897
			// (get) Token: 0x06003093 RID: 12435 RVA: 0x000D1870 File Offset: 0x000CFA70
			// (set) Token: 0x06003094 RID: 12436 RVA: 0x000162B4 File Offset: 0x000144B4
			public unsafe List<Task> _taskList_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr__taskList_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Task>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr__taskList_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F3A RID: 3898
			// (get) Token: 0x06003095 RID: 12437 RVA: 0x000D18A0 File Offset: 0x000CFAA0
			// (set) Token: 0x06003096 RID: 12438 RVA: 0x000162D3 File Offset: 0x000144D3
			public unsafe Task<bool> _schedulerTask_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr__schedulerTask_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr__schedulerTask_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F3B RID: 3899
			// (get) Token: 0x06003097 RID: 12439 RVA: 0x000D18D0 File Offset: 0x000CFAD0
			// (set) Token: 0x06003098 RID: 12440 RVA: 0x000162F2 File Offset: 0x000144F2
			public unsafe bool _finalCleanup_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr__finalCleanup_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr__finalCleanup_5__6)) = value;
				}
			}

			// Token: 0x17000F3C RID: 3900
			// (get) Token: 0x06003099 RID: 12441 RVA: 0x000D18F8 File Offset: 0x000CFAF8
			// (set) Token: 0x0600309A RID: 12442 RVA: 0x0001630D File Offset: 0x0001450D
			public ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._RunScheduler_d__32.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040025C6 RID: 9670
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040025C7 RID: 9671
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040025C8 RID: 9672
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040025C9 RID: 9673
			private static readonly IntPtr NativeFieldInfoPtr__operationArray_5__2;

			// Token: 0x040025CA RID: 9674
			private static readonly IntPtr NativeFieldInfoPtr__idleArray_5__3;

			// Token: 0x040025CB RID: 9675
			private static readonly IntPtr NativeFieldInfoPtr__taskList_5__4;

			// Token: 0x040025CC RID: 9676
			private static readonly IntPtr NativeFieldInfoPtr__schedulerTask_5__5;

			// Token: 0x040025CD RID: 9677
			private static readonly IntPtr NativeFieldInfoPtr__finalCleanup_5__6;

			// Token: 0x040025CE RID: 9678
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040025CF RID: 9679
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040025D0 RID: 9680
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200034C RID: 844
		[ObfuscatedName("System.Net.ServicePointScheduler+<WaitAsync>d__46")]
		public sealed class _WaitAsync_d__46 : ValueType
		{
			// Token: 0x0600309B RID: 12443 RVA: 0x000D1928 File Offset: 0x000CFB28
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitAsync_d__46()
			{
				Il2CppClassPointerStore<ServicePointScheduler._WaitAsync_d__46>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServicePointScheduler>.NativeClassPtr, "<WaitAsync>d__46");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePointScheduler._WaitAsync_d__46>.NativeClassPtr);
				ServicePointScheduler._WaitAsync_d__46.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._WaitAsync_d__46>.NativeClassPtr, "<>1__state");
				ServicePointScheduler._WaitAsync_d__46.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._WaitAsync_d__46>.NativeClassPtr, "<>t__builder");
				ServicePointScheduler._WaitAsync_d__46.NativeFieldInfoPtr_millisecondTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._WaitAsync_d__46>.NativeClassPtr, "millisecondTimeout");
				ServicePointScheduler._WaitAsync_d__46.NativeFieldInfoPtr_workerTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._WaitAsync_d__46>.NativeClassPtr, "workerTask");
				ServicePointScheduler._WaitAsync_d__46.NativeFieldInfoPtr__cts_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._WaitAsync_d__46>.NativeClassPtr, "<cts>5__2");
				ServicePointScheduler._WaitAsync_d__46.NativeFieldInfoPtr__timeoutTask_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._WaitAsync_d__46>.NativeClassPtr, "<timeoutTask>5__3");
				ServicePointScheduler._WaitAsync_d__46.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointScheduler._WaitAsync_d__46>.NativeClassPtr, "<>u__1");
				ServicePointScheduler._WaitAsync_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler._WaitAsync_d__46>.NativeClassPtr, 100668479);
				ServicePointScheduler._WaitAsync_d__46.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointScheduler._WaitAsync_d__46>.NativeClassPtr, 100668480);
			}

			// Token: 0x0600309C RID: 12444 RVA: 0x000D1A08 File Offset: 0x000CFC08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483917, XrefRangeEnd = 483957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler._WaitAsync_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600309D RID: 12445 RVA: 0x000D1A40 File Offset: 0x000CFC40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483957, XrefRangeEnd = 483963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointScheduler._WaitAsync_d__46.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600309E RID: 12446 RVA: 0x0001633B File Offset: 0x0001453B
			public _WaitAsync_d__46(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600309F RID: 12447 RVA: 0x00016344 File Offset: 0x00014544
			public _WaitAsync_d__46()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePointScheduler._WaitAsync_d__46>.NativeClassPtr))
			{
			}

			// Token: 0x17000F3D RID: 3901
			// (get) Token: 0x060030A0 RID: 12448 RVA: 0x000D1A88 File Offset: 0x000CFC88
			// (set) Token: 0x060030A1 RID: 12449 RVA: 0x00016356 File Offset: 0x00014556
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._WaitAsync_d__46.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._WaitAsync_d__46.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F3E RID: 3902
			// (get) Token: 0x060030A2 RID: 12450 RVA: 0x000D1AB0 File Offset: 0x000CFCB0
			// (set) Token: 0x060030A3 RID: 12451 RVA: 0x00016371 File Offset: 0x00014571
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._WaitAsync_d__46.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._WaitAsync_d__46.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F3F RID: 3903
			// (get) Token: 0x060030A4 RID: 12452 RVA: 0x000D1AE0 File Offset: 0x000CFCE0
			// (set) Token: 0x060030A5 RID: 12453 RVA: 0x0001639F File Offset: 0x0001459F
			public unsafe int millisecondTimeout
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._WaitAsync_d__46.NativeFieldInfoPtr_millisecondTimeout);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._WaitAsync_d__46.NativeFieldInfoPtr_millisecondTimeout)) = value;
				}
			}

			// Token: 0x17000F40 RID: 3904
			// (get) Token: 0x060030A6 RID: 12454 RVA: 0x000D1B08 File Offset: 0x000CFD08
			// (set) Token: 0x060030A7 RID: 12455 RVA: 0x000163BA File Offset: 0x000145BA
			public unsafe Task workerTask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._WaitAsync_d__46.NativeFieldInfoPtr_workerTask);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._WaitAsync_d__46.NativeFieldInfoPtr_workerTask), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F41 RID: 3905
			// (get) Token: 0x060030A8 RID: 12456 RVA: 0x000D1B38 File Offset: 0x000CFD38
			// (set) Token: 0x060030A9 RID: 12457 RVA: 0x000163D9 File Offset: 0x000145D9
			public unsafe CancellationTokenSource _cts_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._WaitAsync_d__46.NativeFieldInfoPtr__cts_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._WaitAsync_d__46.NativeFieldInfoPtr__cts_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F42 RID: 3906
			// (get) Token: 0x060030AA RID: 12458 RVA: 0x000D1B68 File Offset: 0x000CFD68
			// (set) Token: 0x060030AB RID: 12459 RVA: 0x000163F8 File Offset: 0x000145F8
			public unsafe Task _timeoutTask_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._WaitAsync_d__46.NativeFieldInfoPtr__timeoutTask_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._WaitAsync_d__46.NativeFieldInfoPtr__timeoutTask_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F43 RID: 3907
			// (get) Token: 0x060030AC RID: 12460 RVA: 0x000D1B98 File Offset: 0x000CFD98
			// (set) Token: 0x060030AD RID: 12461 RVA: 0x00016417 File Offset: 0x00014617
			public ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._WaitAsync_d__46.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointScheduler._WaitAsync_d__46.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040025D1 RID: 9681
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040025D2 RID: 9682
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040025D3 RID: 9683
			private static readonly IntPtr NativeFieldInfoPtr_millisecondTimeout;

			// Token: 0x040025D4 RID: 9684
			private static readonly IntPtr NativeFieldInfoPtr_workerTask;

			// Token: 0x040025D5 RID: 9685
			private static readonly IntPtr NativeFieldInfoPtr__cts_5__2;

			// Token: 0x040025D6 RID: 9686
			private static readonly IntPtr NativeFieldInfoPtr__timeoutTask_5__3;

			// Token: 0x040025D7 RID: 9687
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040025D8 RID: 9688
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040025D9 RID: 9689
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}

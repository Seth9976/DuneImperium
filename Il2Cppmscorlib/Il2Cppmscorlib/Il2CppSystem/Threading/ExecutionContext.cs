using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Remoting.Messaging;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001A8 RID: 424
	[Serializable]
	public sealed class ExecutionContext : Object
	{
		// Token: 0x06001B7A RID: 7034 RVA: 0x000A5470 File Offset: 0x000A3670
		// Note: this type is marked as 'beforefieldinit'.
		static ExecutionContext()
		{
			Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ExecutionContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr);
			ExecutionContext.NativeFieldInfoPtr__syncContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "_syncContext");
			ExecutionContext.NativeFieldInfoPtr__syncContextNoFlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "_syncContextNoFlow");
			ExecutionContext.NativeFieldInfoPtr__logicalCallContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "_logicalCallContext");
			ExecutionContext.NativeFieldInfoPtr__illogicalCallContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "_illogicalCallContext");
			ExecutionContext.NativeFieldInfoPtr__flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "_flags");
			ExecutionContext.NativeFieldInfoPtr__localValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "_localValues");
			ExecutionContext.NativeFieldInfoPtr__localChangeNotifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "_localChangeNotifications");
			ExecutionContext.NativeFieldInfoPtr_s_dummyDefaultEC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "s_dummyDefaultEC");
			ExecutionContext.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "Default");
			ExecutionContext.NativeMethodInfoPtr_get_isNewCapture_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668028);
			ExecutionContext.NativeMethodInfoPtr_set_isNewCapture_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668029);
			ExecutionContext.NativeMethodInfoPtr_get_isFlowSuppressed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668030);
			ExecutionContext.NativeMethodInfoPtr_set_isFlowSuppressed_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668031);
			ExecutionContext.NativeMethodInfoPtr_get_IsPreAllocatedDefault_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668032);
			ExecutionContext.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668033);
			ExecutionContext.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668034);
			ExecutionContext.NativeMethodInfoPtr_SetLocalValue_Internal_Static_Void_IAsyncLocal_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668035);
			ExecutionContext.NativeMethodInfoPtr_OnAsyncLocalContextChanged_Internal_Static_Void_ExecutionContext_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668036);
			ExecutionContext.NativeMethodInfoPtr_get_LogicalCallContext_Internal_get_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668037);
			ExecutionContext.NativeMethodInfoPtr_set_LogicalCallContext_Internal_set_Void_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668038);
			ExecutionContext.NativeMethodInfoPtr_get_IllogicalCallContext_Internal_get_IllogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668039);
			ExecutionContext.NativeMethodInfoPtr_set_IllogicalCallContext_Internal_set_Void_IllogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668040);
			ExecutionContext.NativeMethodInfoPtr_get_SynchronizationContext_Internal_get_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668041);
			ExecutionContext.NativeMethodInfoPtr_set_SynchronizationContext_Internal_set_Void_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668042);
			ExecutionContext.NativeMethodInfoPtr_get_SynchronizationContextNoFlow_Internal_get_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668043);
			ExecutionContext.NativeMethodInfoPtr_set_SynchronizationContextNoFlow_Internal_set_Void_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668044);
			ExecutionContext.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668045);
			ExecutionContext.NativeMethodInfoPtr_Run_Public_Static_Void_ExecutionContext_ContextCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668046);
			ExecutionContext.NativeMethodInfoPtr_Run_Internal_Static_Void_ExecutionContext_ContextCallback_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668047);
			ExecutionContext.NativeMethodInfoPtr_RunInternal_Internal_Static_Void_ExecutionContext_ContextCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668048);
			ExecutionContext.NativeMethodInfoPtr_RunInternal_Internal_Static_Void_ExecutionContext_ContextCallback_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668049);
			ExecutionContext.NativeMethodInfoPtr_EstablishCopyOnWriteScope_Internal_Static_Void_byref_ExecutionContextSwitcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668050);
			ExecutionContext.NativeMethodInfoPtr_EstablishCopyOnWriteScope_Private_Static_Void_Thread_Boolean_byref_ExecutionContextSwitcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668051);
			ExecutionContext.NativeMethodInfoPtr_SetExecutionContext_Internal_Static_ExecutionContextSwitcher_ExecutionContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668052);
			ExecutionContext.NativeMethodInfoPtr_CreateCopy_Public_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668053);
			ExecutionContext.NativeMethodInfoPtr_CreateMutableCopy_Internal_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668054);
			ExecutionContext.NativeMethodInfoPtr_IsFlowSuppressed_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668055);
			ExecutionContext.NativeMethodInfoPtr_Capture_Public_Static_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668056);
			ExecutionContext.NativeMethodInfoPtr_FastCapture_Internal_Static_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668057);
			ExecutionContext.NativeMethodInfoPtr_Capture_Internal_Static_ExecutionContext_byref_StackCrawlMark_CaptureOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668058);
			ExecutionContext.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668059);
			ExecutionContext.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668060);
			ExecutionContext.NativeMethodInfoPtr_IsDefaultFTContext_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100668061);
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001B7B RID: 7035 RVA: 0x000A57FC File Offset: 0x000A39FC
		// (set) Token: 0x06001B7C RID: 7036 RVA: 0x000A5838 File Offset: 0x000A3A38
		public unsafe bool isNewCapture
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_get_isNewCapture_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_set_isNewCapture_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001B7D RID: 7037 RVA: 0x000A5878 File Offset: 0x000A3A78
		// (set) Token: 0x06001B7E RID: 7038 RVA: 0x000A58B4 File Offset: 0x000A3AB4
		public unsafe bool isFlowSuppressed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_get_isFlowSuppressed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_set_isFlowSuppressed_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001B7F RID: 7039 RVA: 0x000A58F4 File Offset: 0x000A3AF4
		public unsafe bool IsPreAllocatedDefault
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1353545, RefRangeEnd = 1353546, XrefRangeStart = 1353545, XrefRangeEnd = 1353545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_get_IsPreAllocatedDefault_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x000A5930 File Offset: 0x000A3B30
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x000A596C File Offset: 0x000A3B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1353546, XrefRangeEnd = 1353547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionContext(bool isPreAllocatedDefault)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isPreAllocatedDefault;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x000A59B4 File Offset: 0x000A3BB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1353588, RefRangeEnd = 1353589, XrefRangeStart = 1353547, XrefRangeEnd = 1353588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLocalValue(IAsyncLocal local, Object newValue, bool needChangeNotifications)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(local);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needChangeNotifications;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_SetLocalValue_Internal_Static_Void_IAsyncLocal_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x000A5A0C File Offset: 0x000A3C0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1353629, RefRangeEnd = 1353631, XrefRangeStart = 1353589, XrefRangeEnd = 1353629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(previous);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(current);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_OnAsyncLocalContextChanged_Internal_Static_Void_ExecutionContext_ExecutionContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06001B84 RID: 7044 RVA: 0x000A5A54 File Offset: 0x000A3C54
		// (set) Token: 0x06001B85 RID: 7045 RVA: 0x000A5A94 File Offset: 0x000A3C94
		public unsafe LogicalCallContext LogicalCallContext
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1353636, RefRangeEnd = 1353645, XrefRangeStart = 1353631, XrefRangeEnd = 1353636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_get_LogicalCallContext_Internal_get_LogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_set_LogicalCallContext_Internal_set_Void_LogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001B86 RID: 7046 RVA: 0x000A5AD8 File Offset: 0x000A3CD8
		// (set) Token: 0x06001B87 RID: 7047 RVA: 0x000A5B18 File Offset: 0x000A3D18
		public unsafe IllogicalCallContext IllogicalCallContext
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1353650, RefRangeEnd = 1353651, XrefRangeStart = 1353645, XrefRangeEnd = 1353650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_get_IllogicalCallContext_Internal_get_IllogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IllogicalCallContext>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_set_IllogicalCallContext_Internal_set_Void_IllogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001B88 RID: 7048 RVA: 0x000A5B5C File Offset: 0x000A3D5C
		// (set) Token: 0x06001B89 RID: 7049 RVA: 0x000A5B9C File Offset: 0x000A3D9C
		public unsafe SynchronizationContext SynchronizationContext
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_get_SynchronizationContext_Internal_get_SynchronizationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_set_SynchronizationContext_Internal_set_Void_SynchronizationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001B8A RID: 7050 RVA: 0x000A5BE0 File Offset: 0x000A3DE0
		// (set) Token: 0x06001B8B RID: 7051 RVA: 0x000A5C20 File Offset: 0x000A3E20
		public unsafe SynchronizationContext SynchronizationContextNoFlow
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_get_SynchronizationContextNoFlow_Internal_get_SynchronizationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_set_SynchronizationContextNoFlow_Internal_set_Void_SynchronizationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x000A5C64 File Offset: 0x000A3E64
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 359432, RefRangeEnd = 359440, XrefRangeStart = 359432, XrefRangeEnd = 359440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x000A5C98 File Offset: 0x000A3E98
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1353658, RefRangeEnd = 1353664, XrefRangeStart = 1353651, XrefRangeEnd = 1353658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Run(ExecutionContext executionContext, ContextCallback callback, Object state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_Run_Public_Static_Void_ExecutionContext_ContextCallback_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x000A5CF4 File Offset: 0x000A3EF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1353668, RefRangeEnd = 1353671, XrefRangeStart = 1353664, XrefRangeEnd = 1353668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Run(ExecutionContext executionContext, ContextCallback callback, Object state, bool preserveSyncCtx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveSyncCtx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_Run_Internal_Static_Void_ExecutionContext_ContextCallback_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x000A5D5C File Offset: 0x000A3F5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1353675, RefRangeEnd = 1353676, XrefRangeStart = 1353671, XrefRangeEnd = 1353675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_RunInternal_Internal_Static_Void_ExecutionContext_ContextCallback_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x000A5DB8 File Offset: 0x000A3FB8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1353702, RefRangeEnd = 1353706, XrefRangeStart = 1353676, XrefRangeEnd = 1353702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state, bool preserveSyncCtx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveSyncCtx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_RunInternal_Internal_Static_Void_ExecutionContext_ContextCallback_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x000A5E20 File Offset: 0x000A4020
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1353716, RefRangeEnd = 1353720, XrefRangeStart = 1353706, XrefRangeEnd = 1353716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(ecsw);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_EstablishCopyOnWriteScope_Internal_Static_Void_byref_ExecutionContextSwitcher_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x000A5E58 File Offset: 0x000A4058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1353720, XrefRangeEnd = 1353726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentThread);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref knownNullWindowsIdentity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(ecsw);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_EstablishCopyOnWriteScope_Private_Static_Void_Thread_Boolean_byref_ExecutionContextSwitcher_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x000A5EB0 File Offset: 0x000A40B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1353743, RefRangeEnd = 1353744, XrefRangeStart = 1353726, XrefRangeEnd = 1353743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveSyncCtx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_SetExecutionContext_Internal_Static_ExecutionContextSwitcher_ExecutionContext_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ExecutionContextSwitcher(intPtr);
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x000A5EFC File Offset: 0x000A40FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1353757, RefRangeEnd = 1353758, XrefRangeStart = 1353744, XrefRangeEnd = 1353757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionContext CreateCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_CreateCopy_Public_ExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x000A5F3C File Offset: 0x000A413C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1353778, RefRangeEnd = 1353780, XrefRangeStart = 1353758, XrefRangeEnd = 1353778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionContext CreateMutableCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_CreateMutableCopy_Internal_ExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x000A5F7C File Offset: 0x000A417C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1353783, RefRangeEnd = 1353786, XrefRangeStart = 1353780, XrefRangeEnd = 1353783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsFlowSuppressed()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_IsFlowSuppressed_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x000A5FAC File Offset: 0x000A41AC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1353790, RefRangeEnd = 1353797, XrefRangeStart = 1353786, XrefRangeEnd = 1353790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ExecutionContext Capture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_Capture_Public_Static_ExecutionContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x000A5FE0 File Offset: 0x000A41E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1353801, RefRangeEnd = 1353802, XrefRangeStart = 1353797, XrefRangeEnd = 1353801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ExecutionContext FastCapture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_FastCapture_Internal_Static_ExecutionContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x000A6014 File Offset: 0x000A4214
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1353806, RefRangeEnd = 1353810, XrefRangeStart = 1353802, XrefRangeEnd = 1353806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ExecutionContext Capture(ref StackCrawlMark stackMark, ExecutionContext.CaptureOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &stackMark;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_Capture_Internal_Static_ExecutionContext_byref_StackCrawlMark_CaptureOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x000A6064 File Offset: 0x000A4264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1353810, XrefRangeEnd = 1353819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x000A60C0 File Offset: 0x000A42C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1353819, XrefRangeEnd = 1353834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionContext(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x000A6124 File Offset: 0x000A4324
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1353836, RefRangeEnd = 1353837, XrefRangeStart = 1353834, XrefRangeEnd = 1353836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDefaultFTContext(bool ignoreSyncCtx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ignoreSyncCtx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_IsDefaultFTContext_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x00008DA7 File Offset: 0x00006FA7
		public ExecutionContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001B9E RID: 7070 RVA: 0x000A6170 File Offset: 0x000A4370
		// (set) Token: 0x06001B9F RID: 7071 RVA: 0x00008DB0 File Offset: 0x00006FB0
		public unsafe SynchronizationContext _syncContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__syncContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__syncContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x000A61A0 File Offset: 0x000A43A0
		// (set) Token: 0x06001BA1 RID: 7073 RVA: 0x00008DCF File Offset: 0x00006FCF
		public unsafe SynchronizationContext _syncContextNoFlow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__syncContextNoFlow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__syncContextNoFlow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x000A61D0 File Offset: 0x000A43D0
		// (set) Token: 0x06001BA3 RID: 7075 RVA: 0x00008DEE File Offset: 0x00006FEE
		public unsafe LogicalCallContext _logicalCallContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__logicalCallContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__logicalCallContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x000A6200 File Offset: 0x000A4400
		// (set) Token: 0x06001BA5 RID: 7077 RVA: 0x00008E0D File Offset: 0x0000700D
		public unsafe IllogicalCallContext _illogicalCallContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__illogicalCallContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IllogicalCallContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__illogicalCallContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x000A6230 File Offset: 0x000A4430
		// (set) Token: 0x06001BA7 RID: 7079 RVA: 0x00008E2C File Offset: 0x0000702C
		public unsafe ExecutionContext.Flags _flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__flags)) = value;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x000A6258 File Offset: 0x000A4458
		// (set) Token: 0x06001BA9 RID: 7081 RVA: 0x00008E47 File Offset: 0x00007047
		public unsafe Dictionary<IAsyncLocal, Object> _localValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__localValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<IAsyncLocal, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__localValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001BAA RID: 7082 RVA: 0x000A6288 File Offset: 0x000A4488
		// (set) Token: 0x06001BAB RID: 7083 RVA: 0x00008E66 File Offset: 0x00007066
		public unsafe List<IAsyncLocal> _localChangeNotifications
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__localChangeNotifications);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IAsyncLocal>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__localChangeNotifications), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001BAC RID: 7084 RVA: 0x000A62B8 File Offset: 0x000A44B8
		// (set) Token: 0x06001BAD RID: 7085 RVA: 0x00008E85 File Offset: 0x00007085
		public unsafe static ExecutionContext s_dummyDefaultEC
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecutionContext.NativeFieldInfoPtr_s_dummyDefaultEC, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecutionContext.NativeFieldInfoPtr_s_dummyDefaultEC, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001BAE RID: 7086 RVA: 0x000A62E0 File Offset: 0x000A44E0
		// (set) Token: 0x06001BAF RID: 7087 RVA: 0x00008E97 File Offset: 0x00007097
		public unsafe static ExecutionContext Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecutionContext.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecutionContext.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001919 RID: 6425
		private static readonly IntPtr NativeFieldInfoPtr__syncContext;

		// Token: 0x0400191A RID: 6426
		private static readonly IntPtr NativeFieldInfoPtr__syncContextNoFlow;

		// Token: 0x0400191B RID: 6427
		private static readonly IntPtr NativeFieldInfoPtr__logicalCallContext;

		// Token: 0x0400191C RID: 6428
		private static readonly IntPtr NativeFieldInfoPtr__illogicalCallContext;

		// Token: 0x0400191D RID: 6429
		private static readonly IntPtr NativeFieldInfoPtr__flags;

		// Token: 0x0400191E RID: 6430
		private static readonly IntPtr NativeFieldInfoPtr__localValues;

		// Token: 0x0400191F RID: 6431
		private static readonly IntPtr NativeFieldInfoPtr__localChangeNotifications;

		// Token: 0x04001920 RID: 6432
		private static readonly IntPtr NativeFieldInfoPtr_s_dummyDefaultEC;

		// Token: 0x04001921 RID: 6433
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04001922 RID: 6434
		private static readonly IntPtr NativeMethodInfoPtr_get_isNewCapture_Internal_get_Boolean_0;

		// Token: 0x04001923 RID: 6435
		private static readonly IntPtr NativeMethodInfoPtr_set_isNewCapture_Internal_set_Void_Boolean_0;

		// Token: 0x04001924 RID: 6436
		private static readonly IntPtr NativeMethodInfoPtr_get_isFlowSuppressed_Internal_get_Boolean_0;

		// Token: 0x04001925 RID: 6437
		private static readonly IntPtr NativeMethodInfoPtr_set_isFlowSuppressed_Internal_set_Void_Boolean_0;

		// Token: 0x04001926 RID: 6438
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPreAllocatedDefault_Internal_get_Boolean_0;

		// Token: 0x04001927 RID: 6439
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001928 RID: 6440
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04001929 RID: 6441
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalValue_Internal_Static_Void_IAsyncLocal_Object_Boolean_0;

		// Token: 0x0400192A RID: 6442
		private static readonly IntPtr NativeMethodInfoPtr_OnAsyncLocalContextChanged_Internal_Static_Void_ExecutionContext_ExecutionContext_0;

		// Token: 0x0400192B RID: 6443
		private static readonly IntPtr NativeMethodInfoPtr_get_LogicalCallContext_Internal_get_LogicalCallContext_0;

		// Token: 0x0400192C RID: 6444
		private static readonly IntPtr NativeMethodInfoPtr_set_LogicalCallContext_Internal_set_Void_LogicalCallContext_0;

		// Token: 0x0400192D RID: 6445
		private static readonly IntPtr NativeMethodInfoPtr_get_IllogicalCallContext_Internal_get_IllogicalCallContext_0;

		// Token: 0x0400192E RID: 6446
		private static readonly IntPtr NativeMethodInfoPtr_set_IllogicalCallContext_Internal_set_Void_IllogicalCallContext_0;

		// Token: 0x0400192F RID: 6447
		private static readonly IntPtr NativeMethodInfoPtr_get_SynchronizationContext_Internal_get_SynchronizationContext_0;

		// Token: 0x04001930 RID: 6448
		private static readonly IntPtr NativeMethodInfoPtr_set_SynchronizationContext_Internal_set_Void_SynchronizationContext_0;

		// Token: 0x04001931 RID: 6449
		private static readonly IntPtr NativeMethodInfoPtr_get_SynchronizationContextNoFlow_Internal_get_SynchronizationContext_0;

		// Token: 0x04001932 RID: 6450
		private static readonly IntPtr NativeMethodInfoPtr_set_SynchronizationContextNoFlow_Internal_set_Void_SynchronizationContext_0;

		// Token: 0x04001933 RID: 6451
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001934 RID: 6452
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Static_Void_ExecutionContext_ContextCallback_Object_0;

		// Token: 0x04001935 RID: 6453
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Static_Void_ExecutionContext_ContextCallback_Object_Boolean_0;

		// Token: 0x04001936 RID: 6454
		private static readonly IntPtr NativeMethodInfoPtr_RunInternal_Internal_Static_Void_ExecutionContext_ContextCallback_Object_0;

		// Token: 0x04001937 RID: 6455
		private static readonly IntPtr NativeMethodInfoPtr_RunInternal_Internal_Static_Void_ExecutionContext_ContextCallback_Object_Boolean_0;

		// Token: 0x04001938 RID: 6456
		private static readonly IntPtr NativeMethodInfoPtr_EstablishCopyOnWriteScope_Internal_Static_Void_byref_ExecutionContextSwitcher_0;

		// Token: 0x04001939 RID: 6457
		private static readonly IntPtr NativeMethodInfoPtr_EstablishCopyOnWriteScope_Private_Static_Void_Thread_Boolean_byref_ExecutionContextSwitcher_0;

		// Token: 0x0400193A RID: 6458
		private static readonly IntPtr NativeMethodInfoPtr_SetExecutionContext_Internal_Static_ExecutionContextSwitcher_ExecutionContext_Boolean_0;

		// Token: 0x0400193B RID: 6459
		private static readonly IntPtr NativeMethodInfoPtr_CreateCopy_Public_ExecutionContext_0;

		// Token: 0x0400193C RID: 6460
		private static readonly IntPtr NativeMethodInfoPtr_CreateMutableCopy_Internal_ExecutionContext_0;

		// Token: 0x0400193D RID: 6461
		private static readonly IntPtr NativeMethodInfoPtr_IsFlowSuppressed_Public_Static_Boolean_0;

		// Token: 0x0400193E RID: 6462
		private static readonly IntPtr NativeMethodInfoPtr_Capture_Public_Static_ExecutionContext_0;

		// Token: 0x0400193F RID: 6463
		private static readonly IntPtr NativeMethodInfoPtr_FastCapture_Internal_Static_ExecutionContext_0;

		// Token: 0x04001940 RID: 6464
		private static readonly IntPtr NativeMethodInfoPtr_Capture_Internal_Static_ExecutionContext_byref_StackCrawlMark_CaptureOptions_0;

		// Token: 0x04001941 RID: 6465
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001942 RID: 6466
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001943 RID: 6467
		private static readonly IntPtr NativeMethodInfoPtr_IsDefaultFTContext_Internal_Boolean_Boolean_0;

		// Token: 0x0200060C RID: 1548
		public enum Flags
		{
			// Token: 0x040048AC RID: 18604
			None,
			// Token: 0x040048AD RID: 18605
			IsNewCapture,
			// Token: 0x040048AE RID: 18606
			IsFlowSuppressed,
			// Token: 0x040048AF RID: 18607
			IsPreAllocatedDefault = 4
		}

		// Token: 0x0200060D RID: 1549
		public sealed class Reader : ValueType
		{
			// Token: 0x06005862 RID: 22626 RVA: 0x0019664C File Offset: 0x0019484C
			// Note: this type is marked as 'beforefieldinit'.
			static Reader()
			{
				Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "Reader");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr);
				ExecutionContext.Reader.NativeFieldInfoPtr_m_ec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, "m_ec");
				ExecutionContext.Reader.NativeMethodInfoPtr__ctor_Public_Void_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100668063);
				ExecutionContext.Reader.NativeMethodInfoPtr_DangerousGetRawExecutionContext_Public_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100668064);
				ExecutionContext.Reader.NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100668065);
				ExecutionContext.Reader.NativeMethodInfoPtr_IsDefaultFTContext_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100668066);
				ExecutionContext.Reader.NativeMethodInfoPtr_get_IsFlowSuppressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100668067);
				ExecutionContext.Reader.NativeMethodInfoPtr_get_SynchronizationContext_Public_get_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100668068);
				ExecutionContext.Reader.NativeMethodInfoPtr_get_SynchronizationContextNoFlow_Public_get_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100668069);
				ExecutionContext.Reader.NativeMethodInfoPtr_get_LogicalCallContext_Public_get_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100668070);
				ExecutionContext.Reader.NativeMethodInfoPtr_HasSameLocalValues_Public_Boolean_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100668071);
			}

			// Token: 0x06005863 RID: 22627 RVA: 0x00196740 File Offset: 0x00194940
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Reader(ExecutionContext ec)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr__ctor_Public_Void_ExecutionContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005864 RID: 22628 RVA: 0x00196790 File Offset: 0x00194990
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExecutionContext DangerousGetRawExecutionContext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_DangerousGetRawExecutionContext_Public_ExecutionContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
			}

			// Token: 0x17001689 RID: 5769
			// (get) Token: 0x06005865 RID: 22629 RVA: 0x001967D4 File Offset: 0x001949D4
			public unsafe bool IsNull
			{
				[CallerCount(13)]
				[CachedScanResults(RefRangeStart = 745863, RefRangeEnd = 745876, XrefRangeStart = 745863, XrefRangeEnd = 745876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005866 RID: 22630 RVA: 0x00196818 File Offset: 0x00194A18
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1353534, RefRangeEnd = 1353535, XrefRangeStart = 1353532, XrefRangeEnd = 1353534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsDefaultFTContext(bool ignoreSyncCtx)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref ignoreSyncCtx;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_IsDefaultFTContext_Public_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700168A RID: 5770
			// (get) Token: 0x06005867 RID: 22631 RVA: 0x00196868 File Offset: 0x00194A68
			public unsafe bool IsFlowSuppressed
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_get_IsFlowSuppressed_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700168B RID: 5771
			// (get) Token: 0x06005868 RID: 22632 RVA: 0x001968AC File Offset: 0x00194AAC
			public unsafe SynchronizationContext SynchronizationContext
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1353535, RefRangeEnd = 1353536, XrefRangeStart = 1353535, XrefRangeEnd = 1353535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_get_SynchronizationContext_Public_get_SynchronizationContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
				}
			}

			// Token: 0x1700168C RID: 5772
			// (get) Token: 0x06005869 RID: 22633 RVA: 0x001968F0 File Offset: 0x00194AF0
			public unsafe SynchronizationContext SynchronizationContextNoFlow
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 1353536, RefRangeEnd = 1353538, XrefRangeStart = 1353536, XrefRangeEnd = 1353536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_get_SynchronizationContextNoFlow_Public_get_SynchronizationContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
				}
			}

			// Token: 0x1700168D RID: 5773
			// (get) Token: 0x0600586A RID: 22634 RVA: 0x00196934 File Offset: 0x00194B34
			public unsafe LogicalCallContext.Reader LogicalCallContext
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 1353541, RefRangeEnd = 1353543, XrefRangeStart = 1353538, XrefRangeEnd = 1353541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_get_LogicalCallContext_Public_get_Reader_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new LogicalCallContext.Reader(intPtr);
				}
			}

			// Token: 0x0600586B RID: 22635 RVA: 0x00196970 File Offset: 0x00194B70
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1353544, RefRangeEnd = 1353545, XrefRangeStart = 1353543, XrefRangeEnd = 1353544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool HasSameLocalValues(ExecutionContext other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_HasSameLocalValues_Public_Boolean_ExecutionContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600586C RID: 22636 RVA: 0x0001F7C0 File Offset: 0x0001D9C0
			public Reader(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600586D RID: 22637 RVA: 0x0001F7C9 File Offset: 0x0001D9C9
			public Reader()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr))
			{
			}

			// Token: 0x17001688 RID: 5768
			// (get) Token: 0x0600586E RID: 22638 RVA: 0x001969C4 File Offset: 0x00194BC4
			// (set) Token: 0x0600586F RID: 22639 RVA: 0x0001F7DB File Offset: 0x0001D9DB
			public unsafe ExecutionContext m_ec
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.Reader.NativeFieldInfoPtr_m_ec);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.Reader.NativeFieldInfoPtr_m_ec), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040048B0 RID: 18608
			private static readonly IntPtr NativeFieldInfoPtr_m_ec;

			// Token: 0x040048B1 RID: 18609
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ExecutionContext_0;

			// Token: 0x040048B2 RID: 18610
			private static readonly IntPtr NativeMethodInfoPtr_DangerousGetRawExecutionContext_Public_ExecutionContext_0;

			// Token: 0x040048B3 RID: 18611
			private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0;

			// Token: 0x040048B4 RID: 18612
			private static readonly IntPtr NativeMethodInfoPtr_IsDefaultFTContext_Public_Boolean_Boolean_0;

			// Token: 0x040048B5 RID: 18613
			private static readonly IntPtr NativeMethodInfoPtr_get_IsFlowSuppressed_Public_get_Boolean_0;

			// Token: 0x040048B6 RID: 18614
			private static readonly IntPtr NativeMethodInfoPtr_get_SynchronizationContext_Public_get_SynchronizationContext_0;

			// Token: 0x040048B7 RID: 18615
			private static readonly IntPtr NativeMethodInfoPtr_get_SynchronizationContextNoFlow_Public_get_SynchronizationContext_0;

			// Token: 0x040048B8 RID: 18616
			private static readonly IntPtr NativeMethodInfoPtr_get_LogicalCallContext_Public_get_Reader_0;

			// Token: 0x040048B9 RID: 18617
			private static readonly IntPtr NativeMethodInfoPtr_HasSameLocalValues_Public_Boolean_ExecutionContext_0;
		}

		// Token: 0x0200060E RID: 1550
		[Flags]
		public enum CaptureOptions
		{
			// Token: 0x040048BB RID: 18619
			None = 0,
			// Token: 0x040048BC RID: 18620
			IgnoreSyncCtx = 1,
			// Token: 0x040048BD RID: 18621
			OptimizeDefaultCase = 2
		}
	}
}

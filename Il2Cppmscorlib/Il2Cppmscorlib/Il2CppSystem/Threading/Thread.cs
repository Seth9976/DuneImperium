using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.ConstrainedExecution;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Security.Principal;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001AE RID: 430
	public sealed class Thread : CriticalFinalizerObject
	{
		// Token: 0x06001C00 RID: 7168 RVA: 0x000A7770 File Offset: 0x000A5970
		// Note: this type is marked as 'beforefieldinit'.
		static Thread()
		{
			Il2CppClassPointerStore<Thread>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Thread");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Thread>.NativeClassPtr);
			Thread.NativeFieldInfoPtr_s_LocalDataStoreMgr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "s_LocalDataStoreMgr");
			Thread.NativeFieldInfoPtr_s_LocalDataStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "s_LocalDataStore");
			Thread.NativeFieldInfoPtr_m_CurrentCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "m_CurrentCulture");
			Thread.NativeFieldInfoPtr_m_CurrentUICulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "m_CurrentUICulture");
			Thread.NativeFieldInfoPtr_s_asyncLocalCurrentCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "s_asyncLocalCurrentCulture");
			Thread.NativeFieldInfoPtr_s_asyncLocalCurrentUICulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "s_asyncLocalCurrentUICulture");
			Thread.NativeFieldInfoPtr_internal_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "internal_thread");
			Thread.NativeFieldInfoPtr_m_ThreadStartArg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "m_ThreadStartArg");
			Thread.NativeFieldInfoPtr_pending_exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "pending_exception");
			Thread.NativeFieldInfoPtr_current_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "current_thread");
			Thread.NativeFieldInfoPtr_m_Delegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "m_Delegate");
			Thread.NativeFieldInfoPtr_m_ExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "m_ExecutionContext");
			Thread.NativeFieldInfoPtr_m_ExecutionContextBelongsToOuterScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "m_ExecutionContextBelongsToOuterScope");
			Thread.NativeFieldInfoPtr_principal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "principal");
			Thread.NativeFieldInfoPtr_principal_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "principal_version");
			Thread.NativeMethodInfoPtr__ctor_Public_Void_ThreadStart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668129);
			Thread.NativeMethodInfoPtr__ctor_Public_Void_ParameterizedThreadStart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668130);
			Thread.NativeMethodInfoPtr__ctor_Public_Void_ParameterizedThreadStart_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668131);
			Thread.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668132);
			Thread.NativeMethodInfoPtr_Start_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668133);
			Thread.NativeMethodInfoPtr_Start_Private_Void_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668134);
			Thread.NativeMethodInfoPtr_GetExecutionContextReader_Internal_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668135);
			Thread.NativeMethodInfoPtr_get_ExecutionContextBelongsToCurrentScope_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668136);
			Thread.NativeMethodInfoPtr_set_ExecutionContextBelongsToCurrentScope_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668137);
			Thread.NativeMethodInfoPtr_GetMutableExecutionContext_Internal_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668138);
			Thread.NativeMethodInfoPtr_SetExecutionContext_Internal_Void_ExecutionContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668139);
			Thread.NativeMethodInfoPtr_SetExecutionContext_Internal_Void_Reader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668140);
			Thread.NativeMethodInfoPtr_Interrupt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668141);
			Thread.NativeMethodInfoPtr_InterruptInternal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668142);
			Thread.NativeMethodInfoPtr_JoinInternal_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668143);
			Thread.NativeMethodInfoPtr_Join_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668144);
			Thread.NativeMethodInfoPtr_SleepInternal_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668145);
			Thread.NativeMethodInfoPtr_Sleep_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668146);
			Thread.NativeMethodInfoPtr_YieldInternal_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668147);
			Thread.NativeMethodInfoPtr_Yield_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668148);
			Thread.NativeMethodInfoPtr_SetStartHelper_Private_Void_Delegate_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668149);
			Thread.NativeMethodInfoPtr_get_CurrentUICulture_Public_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668150);
			Thread.NativeMethodInfoPtr_GetCurrentUICultureNoAppX_Internal_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668151);
			Thread.NativeMethodInfoPtr_get_CurrentCulture_Public_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668152);
			Thread.NativeMethodInfoPtr_GetCurrentCultureNoAppX_Private_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668153);
			Thread.NativeMethodInfoPtr_MemoryBarrier_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668154);
			Thread.NativeMethodInfoPtr_ConstructInternalThread_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668155);
			Thread.NativeMethodInfoPtr_get_Internal_Private_get_InternalThread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668156);
			Thread.NativeMethodInfoPtr_get_CurrentContext_Public_Static_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668157);
			Thread.NativeMethodInfoPtr_GetCurrentThread_icall_Private_Static_Void_byref_Thread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668158);
			Thread.NativeMethodInfoPtr_GetCurrentThread_Private_Static_Thread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668159);
			Thread.NativeMethodInfoPtr_get_CurrentThread_Public_Static_get_Thread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668160);
			Thread.NativeMethodInfoPtr_get_CurrentThreadId_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668161);
			Thread.NativeMethodInfoPtr_GetDomainID_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668162);
			Thread.NativeMethodInfoPtr_Thread_internal_Private_Boolean_MulticastDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668163);
			Thread.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668164);
			Thread.NativeMethodInfoPtr_get_IsThreadPoolThread_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668165);
			Thread.NativeMethodInfoPtr_get_IsThreadPoolThreadInternal_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668166);
			Thread.NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668167);
			Thread.NativeMethodInfoPtr_set_IsBackground_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668168);
			Thread.NativeMethodInfoPtr_SetName_icall_Private_Static_Void_InternalThread_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668169);
			Thread.NativeMethodInfoPtr_SetName_internal_Private_Static_Void_InternalThread_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668170);
			Thread.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668171);
			Thread.NativeMethodInfoPtr_SpinWait_nop_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668172);
			Thread.NativeMethodInfoPtr_SpinWait_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668173);
			Thread.NativeMethodInfoPtr_StartInternal_Private_Void_Object_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668174);
			Thread.NativeMethodInfoPtr_SetState_Private_Static_Void_InternalThread_ThreadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668175);
			Thread.NativeMethodInfoPtr_ClrState_Private_Static_Void_InternalThread_ThreadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668176);
			Thread.NativeMethodInfoPtr_GetState_Private_Static_ThreadState_InternalThread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668177);
			Thread.NativeMethodInfoPtr_SystemMaxStackStize_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668178);
			Thread.NativeMethodInfoPtr_GetProcessDefaultStackSize_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668179);
			Thread.NativeMethodInfoPtr_SetStart_Private_Void_MulticastDelegate_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668180);
			Thread.NativeMethodInfoPtr_get_ManagedThreadId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668181);
			Thread.NativeMethodInfoPtr_BeginCriticalRegion_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668182);
			Thread.NativeMethodInfoPtr_EndCriticalRegion_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668183);
			Thread.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668184);
			Thread.NativeMethodInfoPtr_ValidateThreadState_Private_ThreadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100668185);
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x000A7D40 File Offset: 0x000A5F40
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1355868, RefRangeEnd = 1355873, XrefRangeStart = 1355860, XrefRangeEnd = 1355868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Thread(ThreadStart start)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Thread>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr__ctor_Public_Void_ThreadStart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x000A7D8C File Offset: 0x000A5F8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1355881, RefRangeEnd = 1355882, XrefRangeStart = 1355873, XrefRangeEnd = 1355881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Thread(ParameterizedThreadStart start)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Thread>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr__ctor_Public_Void_ParameterizedThreadStart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x000A7DD8 File Offset: 0x000A5FD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1355898, RefRangeEnd = 1355899, XrefRangeStart = 1355882, XrefRangeEnd = 1355898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Thread(ParameterizedThreadStart start, int maxStackSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Thread>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxStackSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr__ctor_Public_Void_ParameterizedThreadStart_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x000A7E34 File Offset: 0x000A6034
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1355900, RefRangeEnd = 1355906, XrefRangeStart = 1355899, XrefRangeEnd = 1355900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x000A7E68 File Offset: 0x000A6068
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1355910, RefRangeEnd = 1355912, XrefRangeStart = 1355906, XrefRangeEnd = 1355910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start(Object parameter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_Start_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x000A7EAC File Offset: 0x000A60AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1355929, RefRangeEnd = 1355931, XrefRangeStart = 1355912, XrefRangeEnd = 1355929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start(ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &stackMark;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_Start_Private_Void_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x000A7EEC File Offset: 0x000A60EC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1355932, RefRangeEnd = 1355942, XrefRangeStart = 1355931, XrefRangeEnd = 1355932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionContext.Reader GetExecutionContextReader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetExecutionContextReader_Internal_Reader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ExecutionContext.Reader(intPtr);
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001C08 RID: 7176 RVA: 0x000A7F24 File Offset: 0x000A6124
		// (set) Token: 0x06001C09 RID: 7177 RVA: 0x000A7F60 File Offset: 0x000A6160
		public unsafe bool ExecutionContextBelongsToCurrentScope
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1355942, RefRangeEnd = 1355946, XrefRangeStart = 1355942, XrefRangeEnd = 1355942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_ExecutionContextBelongsToCurrentScope_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1355946, RefRangeEnd = 1355949, XrefRangeStart = 1355946, XrefRangeEnd = 1355946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_set_ExecutionContextBelongsToCurrentScope_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x000A7FA0 File Offset: 0x000A61A0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1355952, RefRangeEnd = 1355959, XrefRangeStart = 1355949, XrefRangeEnd = 1355952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionContext GetMutableExecutionContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetMutableExecutionContext_Internal_ExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x000A7FE0 File Offset: 0x000A61E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1355960, RefRangeEnd = 1355962, XrefRangeStart = 1355959, XrefRangeEnd = 1355960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref belongsToCurrentScope;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SetExecutionContext_Internal_Void_ExecutionContext_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x000A8030 File Offset: 0x000A6230
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1355960, RefRangeEnd = 1355962, XrefRangeStart = 1355960, XrefRangeEnd = 1355962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref belongsToCurrentScope;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SetExecutionContext_Internal_Void_Reader_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x000A8088 File Offset: 0x000A6288
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1355963, RefRangeEnd = 1355965, XrefRangeStart = 1355962, XrefRangeEnd = 1355963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_Interrupt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x000A80BC File Offset: 0x000A62BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1355963, RefRangeEnd = 1355965, XrefRangeStart = 1355963, XrefRangeEnd = 1355965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InterruptInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_InterruptInternal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x000A80F0 File Offset: 0x000A62F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355965, XrefRangeEnd = 1355966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool JoinInternal(int millisecondsTimeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_JoinInternal_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x000A813C File Offset: 0x000A633C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1355967, RefRangeEnd = 1355970, XrefRangeStart = 1355966, XrefRangeEnd = 1355967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Join()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_Join_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x000A8170 File Offset: 0x000A6370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355970, XrefRangeEnd = 1355971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SleepInternal(int millisecondsTimeout)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SleepInternal_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x000A81A4 File Offset: 0x000A63A4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1355980, RefRangeEnd = 1355994, XrefRangeStart = 1355971, XrefRangeEnd = 1355980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sleep(int millisecondsTimeout)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_Sleep_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x000A81D8 File Offset: 0x000A63D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1355995, RefRangeEnd = 1355998, XrefRangeStart = 1355994, XrefRangeEnd = 1355995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool YieldInternal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_YieldInternal_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x000A8208 File Offset: 0x000A6408
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1355995, RefRangeEnd = 1355998, XrefRangeStart = 1355995, XrefRangeEnd = 1355998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Yield()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_Yield_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x000A8238 File Offset: 0x000A6438
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1356026, RefRangeEnd = 1356030, XrefRangeStart = 1355998, XrefRangeEnd = 1356026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStartHelper(Delegate start, int maxStackSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxStackSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SetStartHelper_Private_Void_Delegate_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001C16 RID: 7190 RVA: 0x000A8288 File Offset: 0x000A6488
		public unsafe CultureInfo CurrentUICulture
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1356032, RefRangeEnd = 1356033, XrefRangeStart = 1356030, XrefRangeEnd = 1356032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_CurrentUICulture_Public_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x000A82C8 File Offset: 0x000A64C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1356039, RefRangeEnd = 1356041, XrefRangeStart = 1356033, XrefRangeEnd = 1356039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo GetCurrentUICultureNoAppX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetCurrentUICultureNoAppX_Internal_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001C18 RID: 7192 RVA: 0x000A8308 File Offset: 0x000A6508
		public unsafe CultureInfo CurrentCulture
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1356043, RefRangeEnd = 1356054, XrefRangeStart = 1356041, XrefRangeEnd = 1356043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_CurrentCulture_Public_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x000A8348 File Offset: 0x000A6548
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1356060, RefRangeEnd = 1356061, XrefRangeStart = 1356054, XrefRangeEnd = 1356060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo GetCurrentCultureNoAppX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetCurrentCultureNoAppX_Private_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x000A8388 File Offset: 0x000A6588
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1356062, RefRangeEnd = 1356068, XrefRangeStart = 1356061, XrefRangeEnd = 1356062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MemoryBarrier()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_MemoryBarrier_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x000A83B0 File Offset: 0x000A65B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356068, XrefRangeEnd = 1356069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConstructInternalThread()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_ConstructInternalThread_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x000A83E4 File Offset: 0x000A65E4
		public unsafe InternalThread Internal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356069, XrefRangeEnd = 1356070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_Internal_Private_get_InternalThread_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InternalThread>(intPtr3) : null;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001C1D RID: 7197 RVA: 0x000A8424 File Offset: 0x000A6624
		public unsafe static Context CurrentContext
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 1356071, RefRangeEnd = 1356091, XrefRangeStart = 1356070, XrefRangeEnd = 1356071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_CurrentContext_Public_Static_get_Context_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x000A8458 File Offset: 0x000A6658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356091, XrefRangeEnd = 1356092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetCurrentThread_icall(ref Thread thread)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(thread);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetCurrentThread_icall_Private_Static_Void_byref_Thread_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				thread = ((intPtr4 == 0) ? null : new Thread(intPtr4));
			}
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x000A84A4 File Offset: 0x000A66A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356092, XrefRangeEnd = 1356093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Thread GetCurrentThread()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetCurrentThread_Private_Static_Thread_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Thread>(intPtr3) : null;
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x000A84D8 File Offset: 0x000A66D8
		public unsafe static Thread CurrentThread
		{
			[CallerCount(53)]
			[CachedScanResults(RefRangeStart = 1356097, RefRangeEnd = 1356150, XrefRangeStart = 1356093, XrefRangeEnd = 1356097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_CurrentThread_Public_Static_get_Thread_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Thread>(intPtr3) : null;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001C21 RID: 7201 RVA: 0x000A850C File Offset: 0x000A670C
		public unsafe static int CurrentThreadId
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1356154, RefRangeEnd = 1356157, XrefRangeStart = 1356150, XrefRangeEnd = 1356154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_CurrentThreadId_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x000A853C File Offset: 0x000A673C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1356158, RefRangeEnd = 1356164, XrefRangeStart = 1356157, XrefRangeEnd = 1356158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetDomainID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetDomainID_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x000A856C File Offset: 0x000A676C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356164, XrefRangeEnd = 1356165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Thread_internal(MulticastDelegate start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_Thread_internal_Private_Boolean_MulticastDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x000A85BC File Offset: 0x000A67BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356165, XrefRangeEnd = 1356168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001C25 RID: 7205 RVA: 0x000A85F0 File Offset: 0x000A67F0
		public unsafe bool IsThreadPoolThread
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356168, XrefRangeEnd = 1356169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_IsThreadPoolThread_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x000A862C File Offset: 0x000A682C
		public unsafe bool IsThreadPoolThreadInternal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_IsThreadPoolThreadInternal_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x000A8668 File Offset: 0x000A6868
		public unsafe bool IsAlive
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1356171, RefRangeEnd = 1356173, XrefRangeStart = 1356169, XrefRangeEnd = 1356171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700052F RID: 1327
		// (set) Token: 0x06001C28 RID: 7208 RVA: 0x000A86A4 File Offset: 0x000A68A4
		public unsafe bool IsBackground
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1356185, RefRangeEnd = 1356190, XrefRangeStart = 1356173, XrefRangeEnd = 1356185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_set_IsBackground_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x000A86E4 File Offset: 0x000A68E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356190, XrefRangeEnd = 1356191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetName_icall(InternalThread thread, char* name, int nameLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thread);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = name;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SetName_icall_Private_Static_Void_InternalThread_ptr_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x000A8738 File Offset: 0x000A6938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356191, XrefRangeEnd = 1356194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetName_internal(InternalThread thread, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thread);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SetName_internal_Private_Static_Void_InternalThread_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000530 RID: 1328
		// (set) Token: 0x06001C2B RID: 7211 RVA: 0x000A8780 File Offset: 0x000A6980
		public unsafe string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356194, XrefRangeEnd = 1356198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x000A87C4 File Offset: 0x000A69C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356198, XrefRangeEnd = 1356199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SpinWait_nop()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SpinWait_nop_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x000A87EC File Offset: 0x000A69EC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1356200, RefRangeEnd = 1356205, XrefRangeStart = 1356199, XrefRangeEnd = 1356200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SpinWait(int iterations)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iterations;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SpinWait_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x000A8820 File Offset: 0x000A6A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356205, XrefRangeEnd = 1356213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartInternal(Object principal, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(principal);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_StartInternal_Private_Void_Object_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x000A8870 File Offset: 0x000A6A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356213, XrefRangeEnd = 1356214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetState(InternalThread thread, ThreadState set)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thread);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref set;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SetState_Private_Static_Void_InternalThread_ThreadState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x000A88B4 File Offset: 0x000A6AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356214, XrefRangeEnd = 1356215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClrState(InternalThread thread, ThreadState clr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thread);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_ClrState_Private_Static_Void_InternalThread_ThreadState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x000A88F8 File Offset: 0x000A6AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356215, XrefRangeEnd = 1356216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ThreadState GetState(InternalThread thread)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thread);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetState_Private_Static_ThreadState_InternalThread_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x000A893C File Offset: 0x000A6B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356216, XrefRangeEnd = 1356217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SystemMaxStackStize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SystemMaxStackStize_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x000A896C File Offset: 0x000A6B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356217, XrefRangeEnd = 1356223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetProcessDefaultStackSize(int maxStackSize)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxStackSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetProcessDefaultStackSize_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x000A89AC File Offset: 0x000A6BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356223, XrefRangeEnd = 1356225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStart(MulticastDelegate start, int maxStackSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxStackSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SetStart_Private_Void_MulticastDelegate_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001C35 RID: 7221 RVA: 0x000A89FC File Offset: 0x000A6BFC
		public unsafe int ManagedThreadId
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 1356226, RefRangeEnd = 1356247, XrefRangeStart = 1356225, XrefRangeEnd = 1356226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_ManagedThreadId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x000A8A38 File Offset: 0x000A6C38
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1356254, RefRangeEnd = 1356260, XrefRangeStart = 1356247, XrefRangeEnd = 1356254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginCriticalRegion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_BeginCriticalRegion_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x000A8A60 File Offset: 0x000A6C60
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1356267, RefRangeEnd = 1356273, XrefRangeStart = 1356260, XrefRangeEnd = 1356267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndCriticalRegion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_EndCriticalRegion_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x000A8A88 File Offset: 0x000A6C88
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1356226, RefRangeEnd = 1356247, XrefRangeStart = 1356226, XrefRangeEnd = 1356247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x000A8AC4 File Offset: 0x000A6CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356273, XrefRangeEnd = 1356275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadState ValidateThreadState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_ValidateThreadState_Private_ThreadState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x00008FE2 File Offset: 0x000071E2
		public Thread(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001C3B RID: 7227 RVA: 0x000A8B00 File Offset: 0x000A6D00
		// (set) Token: 0x06001C3C RID: 7228 RVA: 0x00008FEB File Offset: 0x000071EB
		public unsafe static LocalDataStoreMgr s_LocalDataStoreMgr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Thread.NativeFieldInfoPtr_s_LocalDataStoreMgr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalDataStoreMgr>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thread.NativeFieldInfoPtr_s_LocalDataStoreMgr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x000A8B28 File Offset: 0x000A6D28
		// (set) Token: 0x06001C3E RID: 7230 RVA: 0x00008FFD File Offset: 0x000071FD
		public unsafe static LocalDataStoreHolder s_LocalDataStore
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Thread.NativeFieldInfoPtr_s_LocalDataStore, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalDataStoreHolder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thread.NativeFieldInfoPtr_s_LocalDataStore, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x000A8B50 File Offset: 0x000A6D50
		// (set) Token: 0x06001C40 RID: 7232 RVA: 0x0000900F File Offset: 0x0000720F
		public unsafe static CultureInfo m_CurrentCulture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Thread.NativeFieldInfoPtr_m_CurrentCulture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thread.NativeFieldInfoPtr_m_CurrentCulture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06001C41 RID: 7233 RVA: 0x000A8B78 File Offset: 0x000A6D78
		// (set) Token: 0x06001C42 RID: 7234 RVA: 0x00009021 File Offset: 0x00007221
		public unsafe static CultureInfo m_CurrentUICulture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Thread.NativeFieldInfoPtr_m_CurrentUICulture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thread.NativeFieldInfoPtr_m_CurrentUICulture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06001C43 RID: 7235 RVA: 0x000A8BA0 File Offset: 0x000A6DA0
		// (set) Token: 0x06001C44 RID: 7236 RVA: 0x00009033 File Offset: 0x00007233
		public unsafe static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Thread.NativeFieldInfoPtr_s_asyncLocalCurrentCulture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncLocal<CultureInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thread.NativeFieldInfoPtr_s_asyncLocalCurrentCulture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001C45 RID: 7237 RVA: 0x000A8BC8 File Offset: 0x000A6DC8
		// (set) Token: 0x06001C46 RID: 7238 RVA: 0x00009045 File Offset: 0x00007245
		public unsafe static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Thread.NativeFieldInfoPtr_s_asyncLocalCurrentUICulture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncLocal<CultureInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thread.NativeFieldInfoPtr_s_asyncLocalCurrentUICulture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001C47 RID: 7239 RVA: 0x000A8BF0 File Offset: 0x000A6DF0
		// (set) Token: 0x06001C48 RID: 7240 RVA: 0x00009057 File Offset: 0x00007257
		public unsafe InternalThread internal_thread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_internal_thread);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InternalThread>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_internal_thread), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x000A8C20 File Offset: 0x000A6E20
		// (set) Token: 0x06001C4A RID: 7242 RVA: 0x00009076 File Offset: 0x00007276
		public unsafe Object m_ThreadStartArg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_m_ThreadStartArg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_m_ThreadStartArg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001C4B RID: 7243 RVA: 0x000A8C50 File Offset: 0x000A6E50
		// (set) Token: 0x06001C4C RID: 7244 RVA: 0x00009095 File Offset: 0x00007295
		public unsafe Object pending_exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_pending_exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_pending_exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001C4D RID: 7245 RVA: 0x000A8C80 File Offset: 0x000A6E80
		// (set) Token: 0x06001C4E RID: 7246 RVA: 0x000090B4 File Offset: 0x000072B4
		public unsafe static Thread current_thread
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Thread.NativeFieldInfoPtr_current_thread, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thread.NativeFieldInfoPtr_current_thread, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001C4F RID: 7247 RVA: 0x000A8CA8 File Offset: 0x000A6EA8
		// (set) Token: 0x06001C50 RID: 7248 RVA: 0x000090C6 File Offset: 0x000072C6
		public unsafe MulticastDelegate m_Delegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_m_Delegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MulticastDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_m_Delegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001C51 RID: 7249 RVA: 0x000A8CD8 File Offset: 0x000A6ED8
		// (set) Token: 0x06001C52 RID: 7250 RVA: 0x000090E5 File Offset: 0x000072E5
		public unsafe ExecutionContext m_ExecutionContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_m_ExecutionContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_m_ExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001C53 RID: 7251 RVA: 0x000A8D08 File Offset: 0x000A6F08
		// (set) Token: 0x06001C54 RID: 7252 RVA: 0x00009104 File Offset: 0x00007304
		public unsafe bool m_ExecutionContextBelongsToOuterScope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_m_ExecutionContextBelongsToOuterScope);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_m_ExecutionContextBelongsToOuterScope)) = value;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001C55 RID: 7253 RVA: 0x000A8D30 File Offset: 0x000A6F30
		// (set) Token: 0x06001C56 RID: 7254 RVA: 0x0000911F File Offset: 0x0000731F
		public unsafe IPrincipal principal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_principal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPrincipal>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_principal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001C57 RID: 7255 RVA: 0x000A8D60 File Offset: 0x000A6F60
		// (set) Token: 0x06001C58 RID: 7256 RVA: 0x0000913E File Offset: 0x0000733E
		public unsafe int principal_version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_principal_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_principal_version)) = value;
			}
		}

		// Token: 0x04001983 RID: 6531
		private static readonly IntPtr NativeFieldInfoPtr_s_LocalDataStoreMgr;

		// Token: 0x04001984 RID: 6532
		private static readonly IntPtr NativeFieldInfoPtr_s_LocalDataStore;

		// Token: 0x04001985 RID: 6533
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentCulture;

		// Token: 0x04001986 RID: 6534
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentUICulture;

		// Token: 0x04001987 RID: 6535
		private static readonly IntPtr NativeFieldInfoPtr_s_asyncLocalCurrentCulture;

		// Token: 0x04001988 RID: 6536
		private static readonly IntPtr NativeFieldInfoPtr_s_asyncLocalCurrentUICulture;

		// Token: 0x04001989 RID: 6537
		private static readonly IntPtr NativeFieldInfoPtr_internal_thread;

		// Token: 0x0400198A RID: 6538
		private static readonly IntPtr NativeFieldInfoPtr_m_ThreadStartArg;

		// Token: 0x0400198B RID: 6539
		private static readonly IntPtr NativeFieldInfoPtr_pending_exception;

		// Token: 0x0400198C RID: 6540
		private static readonly IntPtr NativeFieldInfoPtr_current_thread;

		// Token: 0x0400198D RID: 6541
		private static readonly IntPtr NativeFieldInfoPtr_m_Delegate;

		// Token: 0x0400198E RID: 6542
		private static readonly IntPtr NativeFieldInfoPtr_m_ExecutionContext;

		// Token: 0x0400198F RID: 6543
		private static readonly IntPtr NativeFieldInfoPtr_m_ExecutionContextBelongsToOuterScope;

		// Token: 0x04001990 RID: 6544
		private static readonly IntPtr NativeFieldInfoPtr_principal;

		// Token: 0x04001991 RID: 6545
		private static readonly IntPtr NativeFieldInfoPtr_principal_version;

		// Token: 0x04001992 RID: 6546
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ThreadStart_0;

		// Token: 0x04001993 RID: 6547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ParameterizedThreadStart_0;

		// Token: 0x04001994 RID: 6548
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ParameterizedThreadStart_Int32_0;

		// Token: 0x04001995 RID: 6549
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001996 RID: 6550
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_Object_0;

		// Token: 0x04001997 RID: 6551
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_byref_StackCrawlMark_0;

		// Token: 0x04001998 RID: 6552
		private static readonly IntPtr NativeMethodInfoPtr_GetExecutionContextReader_Internal_Reader_0;

		// Token: 0x04001999 RID: 6553
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutionContextBelongsToCurrentScope_Internal_get_Boolean_0;

		// Token: 0x0400199A RID: 6554
		private static readonly IntPtr NativeMethodInfoPtr_set_ExecutionContextBelongsToCurrentScope_Internal_set_Void_Boolean_0;

		// Token: 0x0400199B RID: 6555
		private static readonly IntPtr NativeMethodInfoPtr_GetMutableExecutionContext_Internal_ExecutionContext_0;

		// Token: 0x0400199C RID: 6556
		private static readonly IntPtr NativeMethodInfoPtr_SetExecutionContext_Internal_Void_ExecutionContext_Boolean_0;

		// Token: 0x0400199D RID: 6557
		private static readonly IntPtr NativeMethodInfoPtr_SetExecutionContext_Internal_Void_Reader_Boolean_0;

		// Token: 0x0400199E RID: 6558
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Void_0;

		// Token: 0x0400199F RID: 6559
		private static readonly IntPtr NativeMethodInfoPtr_InterruptInternal_Private_Void_0;

		// Token: 0x040019A0 RID: 6560
		private static readonly IntPtr NativeMethodInfoPtr_JoinInternal_Private_Boolean_Int32_0;

		// Token: 0x040019A1 RID: 6561
		private static readonly IntPtr NativeMethodInfoPtr_Join_Public_Void_0;

		// Token: 0x040019A2 RID: 6562
		private static readonly IntPtr NativeMethodInfoPtr_SleepInternal_Private_Static_Void_Int32_0;

		// Token: 0x040019A3 RID: 6563
		private static readonly IntPtr NativeMethodInfoPtr_Sleep_Public_Static_Void_Int32_0;

		// Token: 0x040019A4 RID: 6564
		private static readonly IntPtr NativeMethodInfoPtr_YieldInternal_Private_Static_Boolean_0;

		// Token: 0x040019A5 RID: 6565
		private static readonly IntPtr NativeMethodInfoPtr_Yield_Public_Static_Boolean_0;

		// Token: 0x040019A6 RID: 6566
		private static readonly IntPtr NativeMethodInfoPtr_SetStartHelper_Private_Void_Delegate_Int32_0;

		// Token: 0x040019A7 RID: 6567
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentUICulture_Public_get_CultureInfo_0;

		// Token: 0x040019A8 RID: 6568
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentUICultureNoAppX_Internal_CultureInfo_0;

		// Token: 0x040019A9 RID: 6569
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentCulture_Public_get_CultureInfo_0;

		// Token: 0x040019AA RID: 6570
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentCultureNoAppX_Private_CultureInfo_0;

		// Token: 0x040019AB RID: 6571
		private static readonly IntPtr NativeMethodInfoPtr_MemoryBarrier_Public_Static_Void_0;

		// Token: 0x040019AC RID: 6572
		private static readonly IntPtr NativeMethodInfoPtr_ConstructInternalThread_Private_Void_0;

		// Token: 0x040019AD RID: 6573
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Private_get_InternalThread_0;

		// Token: 0x040019AE RID: 6574
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentContext_Public_Static_get_Context_0;

		// Token: 0x040019AF RID: 6575
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentThread_icall_Private_Static_Void_byref_Thread_0;

		// Token: 0x040019B0 RID: 6576
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentThread_Private_Static_Thread_0;

		// Token: 0x040019B1 RID: 6577
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentThread_Public_Static_get_Thread_0;

		// Token: 0x040019B2 RID: 6578
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentThreadId_Internal_Static_get_Int32_0;

		// Token: 0x040019B3 RID: 6579
		private static readonly IntPtr NativeMethodInfoPtr_GetDomainID_Public_Static_Int32_0;

		// Token: 0x040019B4 RID: 6580
		private static readonly IntPtr NativeMethodInfoPtr_Thread_internal_Private_Boolean_MulticastDelegate_0;

		// Token: 0x040019B5 RID: 6581
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040019B6 RID: 6582
		private static readonly IntPtr NativeMethodInfoPtr_get_IsThreadPoolThread_Public_get_Boolean_0;

		// Token: 0x040019B7 RID: 6583
		private static readonly IntPtr NativeMethodInfoPtr_get_IsThreadPoolThreadInternal_Internal_get_Boolean_0;

		// Token: 0x040019B8 RID: 6584
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0;

		// Token: 0x040019B9 RID: 6585
		private static readonly IntPtr NativeMethodInfoPtr_set_IsBackground_Public_set_Void_Boolean_0;

		// Token: 0x040019BA RID: 6586
		private static readonly IntPtr NativeMethodInfoPtr_SetName_icall_Private_Static_Void_InternalThread_ptr_Char_Int32_0;

		// Token: 0x040019BB RID: 6587
		private static readonly IntPtr NativeMethodInfoPtr_SetName_internal_Private_Static_Void_InternalThread_String_0;

		// Token: 0x040019BC RID: 6588
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x040019BD RID: 6589
		private static readonly IntPtr NativeMethodInfoPtr_SpinWait_nop_Private_Static_Void_0;

		// Token: 0x040019BE RID: 6590
		private static readonly IntPtr NativeMethodInfoPtr_SpinWait_Public_Static_Void_Int32_0;

		// Token: 0x040019BF RID: 6591
		private static readonly IntPtr NativeMethodInfoPtr_StartInternal_Private_Void_Object_byref_StackCrawlMark_0;

		// Token: 0x040019C0 RID: 6592
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Private_Static_Void_InternalThread_ThreadState_0;

		// Token: 0x040019C1 RID: 6593
		private static readonly IntPtr NativeMethodInfoPtr_ClrState_Private_Static_Void_InternalThread_ThreadState_0;

		// Token: 0x040019C2 RID: 6594
		private static readonly IntPtr NativeMethodInfoPtr_GetState_Private_Static_ThreadState_InternalThread_0;

		// Token: 0x040019C3 RID: 6595
		private static readonly IntPtr NativeMethodInfoPtr_SystemMaxStackStize_Private_Static_Int32_0;

		// Token: 0x040019C4 RID: 6596
		private static readonly IntPtr NativeMethodInfoPtr_GetProcessDefaultStackSize_Private_Static_Int32_Int32_0;

		// Token: 0x040019C5 RID: 6597
		private static readonly IntPtr NativeMethodInfoPtr_SetStart_Private_Void_MulticastDelegate_Int32_0;

		// Token: 0x040019C6 RID: 6598
		private static readonly IntPtr NativeMethodInfoPtr_get_ManagedThreadId_Public_get_Int32_0;

		// Token: 0x040019C7 RID: 6599
		private static readonly IntPtr NativeMethodInfoPtr_BeginCriticalRegion_Public_Static_Void_0;

		// Token: 0x040019C8 RID: 6600
		private static readonly IntPtr NativeMethodInfoPtr_EndCriticalRegion_Public_Static_Void_0;

		// Token: 0x040019C9 RID: 6601
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040019CA RID: 6602
		private static readonly IntPtr NativeMethodInfoPtr_ValidateThreadState_Private_ThreadState_0;
	}
}

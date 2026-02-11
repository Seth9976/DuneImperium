using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;

namespace UnityEngine
{
	// Token: 0x02000159 RID: 345
	public sealed class UnitySynchronizationContext : SynchronizationContext
	{
		// Token: 0x060019CA RID: 6602 RVA: 0x00079A0C File Offset: 0x00077C0C
		// Note: this type is marked as 'beforefieldinit'.
		static UnitySynchronizationContext()
		{
			Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "UnitySynchronizationContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr);
			UnitySynchronizationContext.NativeFieldInfoPtr_m_AsyncWorkQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, "m_AsyncWorkQueue");
			UnitySynchronizationContext.NativeFieldInfoPtr_m_CurrentFrameWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, "m_CurrentFrameWork");
			UnitySynchronizationContext.NativeFieldInfoPtr_m_MainThreadID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, "m_MainThreadID");
			UnitySynchronizationContext.NativeFieldInfoPtr_m_TrackedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, "m_TrackedCount");
			UnitySynchronizationContext.NativeMethodInfoPtr__ctor_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100666892);
			UnitySynchronizationContext.NativeMethodInfoPtr__ctor_Private_Void_List_1_WorkRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100666893);
			UnitySynchronizationContext.NativeMethodInfoPtr_Send_Public_Virtual_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100666894);
			UnitySynchronizationContext.NativeMethodInfoPtr_OperationStarted_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100666895);
			UnitySynchronizationContext.NativeMethodInfoPtr_OperationCompleted_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100666896);
			UnitySynchronizationContext.NativeMethodInfoPtr_Post_Public_Virtual_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100666897);
			UnitySynchronizationContext.NativeMethodInfoPtr_CreateCopy_Public_Virtual_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100666898);
			UnitySynchronizationContext.NativeMethodInfoPtr_Exec_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100666899);
			UnitySynchronizationContext.NativeMethodInfoPtr_HasPendingTasks_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100666900);
			UnitySynchronizationContext.NativeMethodInfoPtr_InitializeSynchronizationContext_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100666901);
			UnitySynchronizationContext.NativeMethodInfoPtr_ExecuteTasks_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100666902);
			UnitySynchronizationContext.NativeMethodInfoPtr_ExecutePendingTasks_Private_Static_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100666903);
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x00079B7C File Offset: 0x00077D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672910, XrefRangeEnd = 672923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitySynchronizationContext(int mainThreadID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mainThreadID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr__ctor_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x00079BC4 File Offset: 0x00077DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672923, XrefRangeEnd = 672932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitySynchronizationContext(List<UnitySynchronizationContext.WorkRequest> queue, int mainThreadID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(queue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mainThreadID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr__ctor_Private_Void_List_1_WorkRequest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x00079C20 File Offset: 0x00077E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672932, XrefRangeEnd = 672955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Send(SendOrPostCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_Send_Public_Virtual_Void_SendOrPostCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x00079C74 File Offset: 0x00077E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672955, XrefRangeEnd = 672956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OperationStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_OperationStarted_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x00079CA8 File Offset: 0x00077EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672956, XrefRangeEnd = 672957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OperationCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_OperationCompleted_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00079CDC File Offset: 0x00077EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672957, XrefRangeEnd = 672969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Post(SendOrPostCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_Post_Public_Virtual_Void_SendOrPostCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x00079D30 File Offset: 0x00077F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672969, XrefRangeEnd = 672981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SynchronizationContext CreateCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_CreateCopy_Public_Virtual_SynchronizationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x00079D70 File Offset: 0x00077F70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 672999, RefRangeEnd = 673001, XrefRangeStart = 672981, XrefRangeEnd = 672999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exec()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_Exec_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x00079DA4 File Offset: 0x00077FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 673001, XrefRangeEnd = 673002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasPendingTasks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_HasPendingTasks_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x00079DE0 File Offset: 0x00077FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 673002, XrefRangeEnd = 673022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeSynchronizationContext()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_InitializeSynchronizationContext_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x00079E08 File Offset: 0x00078008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 673022, XrefRangeEnd = 673026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecuteTasks()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_ExecuteTasks_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x00079E30 File Offset: 0x00078030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 673026, XrefRangeEnd = 673041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ExecutePendingTasks(long millisecondsTimeout)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_ExecutePendingTasks_Private_Static_Boolean_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x00009EB4 File Offset: 0x000080B4
		public UnitySynchronizationContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060019D8 RID: 6616 RVA: 0x00079E70 File Offset: 0x00078070
		// (set) Token: 0x060019D9 RID: 6617 RVA: 0x00009EBD File Offset: 0x000080BD
		public unsafe List<UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_AsyncWorkQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnitySynchronizationContext.WorkRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_AsyncWorkQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x00079EA0 File Offset: 0x000780A0
		// (set) Token: 0x060019DB RID: 6619 RVA: 0x00009EDC File Offset: 0x000080DC
		public unsafe List<UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_CurrentFrameWork);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnitySynchronizationContext.WorkRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_CurrentFrameWork), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060019DC RID: 6620 RVA: 0x00079ED0 File Offset: 0x000780D0
		// (set) Token: 0x060019DD RID: 6621 RVA: 0x00009EFB File Offset: 0x000080FB
		public unsafe int m_MainThreadID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_MainThreadID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_MainThreadID)) = value;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060019DE RID: 6622 RVA: 0x00079EF8 File Offset: 0x000780F8
		// (set) Token: 0x060019DF RID: 6623 RVA: 0x00009F16 File Offset: 0x00008116
		public unsafe int m_TrackedCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_TrackedCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_TrackedCount)) = value;
			}
		}

		// Token: 0x04001703 RID: 5891
		private static readonly IntPtr NativeFieldInfoPtr_m_AsyncWorkQueue;

		// Token: 0x04001704 RID: 5892
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentFrameWork;

		// Token: 0x04001705 RID: 5893
		private static readonly IntPtr NativeFieldInfoPtr_m_MainThreadID;

		// Token: 0x04001706 RID: 5894
		private static readonly IntPtr NativeFieldInfoPtr_m_TrackedCount;

		// Token: 0x04001707 RID: 5895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_0;

		// Token: 0x04001708 RID: 5896
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_List_1_WorkRequest_Int32_0;

		// Token: 0x04001709 RID: 5897
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Virtual_Void_SendOrPostCallback_Object_0;

		// Token: 0x0400170A RID: 5898
		private static readonly IntPtr NativeMethodInfoPtr_OperationStarted_Public_Virtual_Void_0;

		// Token: 0x0400170B RID: 5899
		private static readonly IntPtr NativeMethodInfoPtr_OperationCompleted_Public_Virtual_Void_0;

		// Token: 0x0400170C RID: 5900
		private static readonly IntPtr NativeMethodInfoPtr_Post_Public_Virtual_Void_SendOrPostCallback_Object_0;

		// Token: 0x0400170D RID: 5901
		private static readonly IntPtr NativeMethodInfoPtr_CreateCopy_Public_Virtual_SynchronizationContext_0;

		// Token: 0x0400170E RID: 5902
		private static readonly IntPtr NativeMethodInfoPtr_Exec_Public_Void_0;

		// Token: 0x0400170F RID: 5903
		private static readonly IntPtr NativeMethodInfoPtr_HasPendingTasks_Private_Boolean_0;

		// Token: 0x04001710 RID: 5904
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSynchronizationContext_Private_Static_Void_0;

		// Token: 0x04001711 RID: 5905
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteTasks_Private_Static_Void_0;

		// Token: 0x04001712 RID: 5906
		private static readonly IntPtr NativeMethodInfoPtr_ExecutePendingTasks_Private_Static_Boolean_Int64_0;

		// Token: 0x04001713 RID: 5907
		public const int kAwqInitialCapacity = 20;

		// Token: 0x02000782 RID: 1922
		public sealed class WorkRequest : ValueType
		{
			// Token: 0x060037A8 RID: 14248 RVA: 0x000BCA38 File Offset: 0x000BAC38
			// Note: this type is marked as 'beforefieldinit'.
			static WorkRequest()
			{
				Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, "WorkRequest");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr);
				UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_DelagateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr, "m_DelagateCallback");
				UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_DelagateState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr, "m_DelagateState");
				UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_WaitHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr, "m_WaitHandle");
				UnitySynchronizationContext.WorkRequest.NativeMethodInfoPtr__ctor_Public_Void_SendOrPostCallback_Object_ManualResetEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr, 100666904);
				UnitySynchronizationContext.WorkRequest.NativeMethodInfoPtr_Invoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr, 100666905);
			}

			// Token: 0x060037A9 RID: 14249 RVA: 0x000BCAC8 File Offset: 0x000BACC8
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 338072, RefRangeEnd = 338082, XrefRangeStart = 338072, XrefRangeEnd = 338082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WorkRequest(SendOrPostCallback callback, Object state, ManualResetEvent waitHandle = null)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(waitHandle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.WorkRequest.NativeMethodInfoPtr__ctor_Public_Void_SendOrPostCallback_Object_ManualResetEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037AA RID: 14250 RVA: 0x000BCB3C File Offset: 0x000BAD3C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 672909, RefRangeEnd = 672910, XrefRangeStart = 672905, XrefRangeEnd = 672909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.WorkRequest.NativeMethodInfoPtr_Invoke_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037AB RID: 14251 RVA: 0x00014015 File Offset: 0x00012215
			public WorkRequest(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060037AC RID: 14252 RVA: 0x0001401E File Offset: 0x0001221E
			public WorkRequest()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr))
			{
			}

			// Token: 0x17000A29 RID: 2601
			// (get) Token: 0x060037AD RID: 14253 RVA: 0x000BCB74 File Offset: 0x000BAD74
			// (set) Token: 0x060037AE RID: 14254 RVA: 0x00014030 File Offset: 0x00012230
			public unsafe SendOrPostCallback m_DelagateCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_DelagateCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendOrPostCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_DelagateCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A2A RID: 2602
			// (get) Token: 0x060037AF RID: 14255 RVA: 0x000BCBA4 File Offset: 0x000BADA4
			// (set) Token: 0x060037B0 RID: 14256 RVA: 0x0001404F File Offset: 0x0001224F
			public unsafe Object m_DelagateState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_DelagateState);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_DelagateState), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A2B RID: 2603
			// (get) Token: 0x060037B1 RID: 14257 RVA: 0x000BCBD4 File Offset: 0x000BADD4
			// (set) Token: 0x060037B2 RID: 14258 RVA: 0x0001406E File Offset: 0x0001226E
			public unsafe ManualResetEvent m_WaitHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_WaitHandle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_WaitHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C9C RID: 11420
			private static readonly IntPtr NativeFieldInfoPtr_m_DelagateCallback;

			// Token: 0x04002C9D RID: 11421
			private static readonly IntPtr NativeFieldInfoPtr_m_DelagateState;

			// Token: 0x04002C9E RID: 11422
			private static readonly IntPtr NativeFieldInfoPtr_m_WaitHandle;

			// Token: 0x04002C9F RID: 11423
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SendOrPostCallback_Object_ManualResetEvent_0;

			// Token: 0x04002CA0 RID: 11424
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_0;
		}
	}
}

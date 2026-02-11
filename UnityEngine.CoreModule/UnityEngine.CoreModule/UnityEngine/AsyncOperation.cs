using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000122 RID: 290
	public class AsyncOperation : YieldInstruction
	{
		// Token: 0x0600174B RID: 5963 RVA: 0x0006EFDC File Offset: 0x0006D1DC
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncOperation()
		{
			Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AsyncOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr);
			AsyncOperation.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, "m_Ptr");
			AsyncOperation.NativeFieldInfoPtr_m_completeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, "m_completeCallback");
			AsyncOperation.NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100666494);
			AsyncOperation.NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100666495);
			AsyncOperation.NativeMethodInfoPtr_get_progress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100666496);
			AsyncOperation.NativeMethodInfoPtr_set_priority_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100666497);
			AsyncOperation.NativeMethodInfoPtr_get_allowSceneActivation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100666498);
			AsyncOperation.NativeMethodInfoPtr_set_allowSceneActivation_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100666499);
			AsyncOperation.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100666500);
			AsyncOperation.NativeMethodInfoPtr_InvokeCompletionEvent_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100666501);
			AsyncOperation.NativeMethodInfoPtr_add_completed_Public_add_Void_Action_1_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100666502);
			AsyncOperation.NativeMethodInfoPtr_remove_completed_Public_rem_Void_Action_1_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100666503);
			AsyncOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100666504);
			AsyncOperation.get_priorityDelegateField = IL2CPP.ResolveICall<AsyncOperation.get_priorityDelegate>("UnityEngine.AsyncOperation::get_priority");
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x0006F120 File Offset: 0x0006D320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660480, XrefRangeEnd = 660482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalDestroy(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x0600174D RID: 5965 RVA: 0x0006F154 File Offset: 0x0006D354
		public unsafe bool isDone
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 660484, RefRangeEnd = 660509, XrefRangeStart = 660482, XrefRangeEnd = 660484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x0006F190 File Offset: 0x0006D390
		public unsafe float progress
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 660511, RefRangeEnd = 660522, XrefRangeStart = 660509, XrefRangeEnd = 660511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_get_progress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x0600175C RID: 5980 RVA: 0x0000931A File Offset: 0x0000751A
		// (set) Token: 0x0600174F RID: 5967 RVA: 0x0006F1CC File Offset: 0x0006D3CC
		public unsafe int priority
		{
			get
			{
				return AsyncOperation.get_priorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 660524, RefRangeEnd = 660526, XrefRangeStart = 660522, XrefRangeEnd = 660524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_set_priority_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001750 RID: 5968 RVA: 0x0006F20C File Offset: 0x0006D40C
		// (set) Token: 0x06001751 RID: 5969 RVA: 0x0006F248 File Offset: 0x0006D448
		public unsafe bool allowSceneActivation
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 660528, RefRangeEnd = 660530, XrefRangeStart = 660526, XrefRangeEnd = 660528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_get_allowSceneActivation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 660532, RefRangeEnd = 660536, XrefRangeStart = 660530, XrefRangeEnd = 660532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_set_allowSceneActivation_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x0006F288 File Offset: 0x0006D488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660536, XrefRangeEnd = 660541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncOperation.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x0006F2C4 File Offset: 0x0006D4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660541, XrefRangeEnd = 660542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeCompletionEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_InvokeCompletionEvent_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x0006F2F8 File Offset: 0x0006D4F8
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 660552, RefRangeEnd = 660573, XrefRangeStart = 660542, XrefRangeEnd = 660552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_completed(Action<AsyncOperation> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_add_completed_Public_add_Void_Action_1_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x0006F33C File Offset: 0x0006D53C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 660583, RefRangeEnd = 660591, XrefRangeStart = 660573, XrefRangeEnd = 660583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_completed(Action<AsyncOperation> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_remove_completed_Public_rem_Void_Action_1_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x0006F380 File Offset: 0x0006D580
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x000092D7 File Offset: 0x000074D7
		public AsyncOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06001758 RID: 5976 RVA: 0x0006F3BC File Offset: 0x0006D5BC
		// (set) Token: 0x06001759 RID: 5977 RVA: 0x000092E0 File Offset: 0x000074E0
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x0600175A RID: 5978 RVA: 0x0006F3E4 File Offset: 0x0006D5E4
		// (set) Token: 0x0600175B RID: 5979 RVA: 0x000092FB File Offset: 0x000074FB
		public unsafe Action<AsyncOperation> m_completeCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_m_completeCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_m_completeCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400151F RID: 5407
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04001520 RID: 5408
		private static readonly IntPtr NativeFieldInfoPtr_m_completeCallback;

		// Token: 0x04001521 RID: 5409
		private static readonly IntPtr NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0;

		// Token: 0x04001522 RID: 5410
		private static readonly IntPtr NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0;

		// Token: 0x04001523 RID: 5411
		private static readonly IntPtr NativeMethodInfoPtr_get_progress_Public_get_Single_0;

		// Token: 0x04001524 RID: 5412
		private static readonly IntPtr NativeMethodInfoPtr_set_priority_Public_set_Void_Int32_0;

		// Token: 0x04001525 RID: 5413
		private static readonly IntPtr NativeMethodInfoPtr_get_allowSceneActivation_Public_get_Boolean_0;

		// Token: 0x04001526 RID: 5414
		private static readonly IntPtr NativeMethodInfoPtr_set_allowSceneActivation_Public_set_Void_Boolean_0;

		// Token: 0x04001527 RID: 5415
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001528 RID: 5416
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCompletionEvent_Internal_Void_0;

		// Token: 0x04001529 RID: 5417
		private static readonly IntPtr NativeMethodInfoPtr_add_completed_Public_add_Void_Action_1_AsyncOperation_0;

		// Token: 0x0400152A RID: 5418
		private static readonly IntPtr NativeMethodInfoPtr_remove_completed_Public_rem_Void_Action_1_AsyncOperation_0;

		// Token: 0x0400152B RID: 5419
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400152C RID: 5420
		private static readonly AsyncOperation.get_priorityDelegate get_priorityDelegateField;

		// Token: 0x02000724 RID: 1828
		// (Invoke) Token: 0x06003715 RID: 14101
		private delegate int get_priorityDelegate(IntPtr @this);
	}
}

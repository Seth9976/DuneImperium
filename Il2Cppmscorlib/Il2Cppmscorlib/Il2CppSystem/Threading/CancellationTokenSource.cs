using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200019B RID: 411
	public class CancellationTokenSource : Object
	{
		// Token: 0x06001AA3 RID: 6819 RVA: 0x000A2724 File Offset: 0x000A0924
		// Note: this type is marked as 'beforefieldinit'.
		static CancellationTokenSource()
		{
			Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "CancellationTokenSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr);
			CancellationTokenSource.NativeFieldInfoPtr_s_canceledSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "s_canceledSource");
			CancellationTokenSource.NativeFieldInfoPtr_s_neverCanceledSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "s_neverCanceledSource");
			CancellationTokenSource.NativeFieldInfoPtr_s_nLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "s_nLists");
			CancellationTokenSource.NativeFieldInfoPtr__kernelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "_kernelEvent");
			CancellationTokenSource.NativeFieldInfoPtr__registeredCallbacksLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "_registeredCallbacksLists");
			CancellationTokenSource.NativeFieldInfoPtr_CannotBeCanceled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "CannotBeCanceled");
			CancellationTokenSource.NativeFieldInfoPtr_NotCanceledState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "NotCanceledState");
			CancellationTokenSource.NativeFieldInfoPtr_NotifyingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "NotifyingState");
			CancellationTokenSource.NativeFieldInfoPtr_NotifyingCompleteState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "NotifyingCompleteState");
			CancellationTokenSource.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "_state");
			CancellationTokenSource.NativeFieldInfoPtr__threadIDExecutingCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "_threadIDExecutingCallbacks");
			CancellationTokenSource.NativeFieldInfoPtr__disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "_disposed");
			CancellationTokenSource.NativeFieldInfoPtr__executingCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "_executingCallback");
			CancellationTokenSource.NativeFieldInfoPtr__timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "_timer");
			CancellationTokenSource.NativeFieldInfoPtr_s_timerCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "s_timerCallback");
			CancellationTokenSource.NativeMethodInfoPtr_get_IsCancellationRequested_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667922);
			CancellationTokenSource.NativeMethodInfoPtr_get_IsCancellationCompleted_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667923);
			CancellationTokenSource.NativeMethodInfoPtr_get_IsDisposed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667924);
			CancellationTokenSource.NativeMethodInfoPtr_get_ThreadIDExecutingCallbacks_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667925);
			CancellationTokenSource.NativeMethodInfoPtr_set_ThreadIDExecutingCallbacks_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667926);
			CancellationTokenSource.NativeMethodInfoPtr_get_Token_Public_get_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667927);
			CancellationTokenSource.NativeMethodInfoPtr_get_ExecutingCallback_Internal_get_CancellationCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667928);
			CancellationTokenSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667929);
			CancellationTokenSource.NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667930);
			CancellationTokenSource.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667931);
			CancellationTokenSource.NativeMethodInfoPtr_InitializeWithTimer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667932);
			CancellationTokenSource.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667933);
			CancellationTokenSource.NativeMethodInfoPtr_Cancel_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667934);
			CancellationTokenSource.NativeMethodInfoPtr_CancelAfter_Public_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667935);
			CancellationTokenSource.NativeMethodInfoPtr_CancelAfter_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667936);
			CancellationTokenSource.NativeMethodInfoPtr_TimerCallbackLogic_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667937);
			CancellationTokenSource.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667938);
			CancellationTokenSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667939);
			CancellationTokenSource.NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667940);
			CancellationTokenSource.NativeMethodInfoPtr_ThrowObjectDisposedException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667941);
			CancellationTokenSource.NativeMethodInfoPtr_InternalRegister_Internal_CancellationTokenRegistration_Action_1_Object_Object_SynchronizationContext_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667942);
			CancellationTokenSource.NativeMethodInfoPtr_NotifyCancellation_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667943);
			CancellationTokenSource.NativeMethodInfoPtr_ExecuteCallbackHandlers_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667944);
			CancellationTokenSource.NativeMethodInfoPtr_CancellationCallbackCoreWork_OnSyncContext_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667945);
			CancellationTokenSource.NativeMethodInfoPtr_CancellationCallbackCoreWork_Private_Void_CancellationCallbackCoreWorkArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667946);
			CancellationTokenSource.NativeMethodInfoPtr_CreateLinkedTokenSource_Public_Static_CancellationTokenSource_CancellationToken_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667947);
			CancellationTokenSource.NativeMethodInfoPtr_CreateLinkedTokenSource_Internal_Static_CancellationTokenSource_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667948);
			CancellationTokenSource.NativeMethodInfoPtr_CreateLinkedTokenSource_Public_Static_CancellationTokenSource_Il2CppReferenceArray_1_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667949);
			CancellationTokenSource.NativeMethodInfoPtr_WaitForCallbackToComplete_Internal_Void_CancellationCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, 100667950);
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x000A2AC4 File Offset: 0x000A0CC4
		public unsafe bool IsCancellationRequested
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1352465, RefRangeEnd = 1352477, XrefRangeStart = 1352464, XrefRangeEnd = 1352465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_get_IsCancellationRequested_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001AA5 RID: 6821 RVA: 0x000A2B00 File Offset: 0x000A0D00
		public unsafe bool IsCancellationCompleted
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352477, XrefRangeEnd = 1352478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_get_IsCancellationCompleted_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06001AA6 RID: 6822 RVA: 0x000A2B3C File Offset: 0x000A0D3C
		public unsafe bool IsDisposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_get_IsDisposed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001AA7 RID: 6823 RVA: 0x000A2B78 File Offset: 0x000A0D78
		// (set) Token: 0x06001AA8 RID: 6824 RVA: 0x000A2BB4 File Offset: 0x000A0DB4
		public unsafe int ThreadIDExecutingCallbacks
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352478, XrefRangeEnd = 1352479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_get_ThreadIDExecutingCallbacks_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352479, XrefRangeEnd = 1352480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_set_ThreadIDExecutingCallbacks_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001AA9 RID: 6825 RVA: 0x000A2BF4 File Offset: 0x000A0DF4
		public unsafe CancellationToken Token
		{
			[CallerCount(32)]
			[CachedScanResults(RefRangeStart = 1352482, RefRangeEnd = 1352514, XrefRangeStart = 1352480, XrefRangeEnd = 1352482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_get_Token_Public_get_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CancellationToken(intPtr);
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06001AAA RID: 6826 RVA: 0x000A2C2C File Offset: 0x000A0E2C
		public unsafe CancellationCallbackInfo ExecutingCallback
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1352515, RefRangeEnd = 1352521, XrefRangeStart = 1352514, XrefRangeEnd = 1352515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_get_ExecutingCallback_Internal_get_CancellationCallbackInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CancellationCallbackInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x000A2C6C File Offset: 0x000A0E6C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1352524, RefRangeEnd = 1352543, XrefRangeStart = 1352521, XrefRangeEnd = 1352524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationTokenSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x000A2CA8 File Offset: 0x000A0EA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1352550, RefRangeEnd = 1352551, XrefRangeStart = 1352543, XrefRangeEnd = 1352550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationTokenSource(TimeSpan delay)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x000A2CF0 File Offset: 0x000A0EF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1352560, RefRangeEnd = 1352562, XrefRangeStart = 1352551, XrefRangeEnd = 1352560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationTokenSource(int millisecondsDelay)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsDelay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x000A2D38 File Offset: 0x000A0F38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1352573, RefRangeEnd = 1352575, XrefRangeStart = 1352562, XrefRangeEnd = 1352573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeWithTimer(int millisecondsDelay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsDelay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_InitializeWithTimer_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x000A2D78 File Offset: 0x000A0F78
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1352580, RefRangeEnd = 1352606, XrefRangeStart = 1352575, XrefRangeEnd = 1352580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x000A2DAC File Offset: 0x000A0FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352606, XrefRangeEnd = 1352611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel(bool throwOnFirstException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref throwOnFirstException;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_Cancel_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x000A2DEC File Offset: 0x000A0FEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1352616, RefRangeEnd = 1352617, XrefRangeStart = 1352611, XrefRangeEnd = 1352616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelAfter(TimeSpan delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_CancelAfter_Public_Void_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x000A2E2C File Offset: 0x000A102C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1352634, RefRangeEnd = 1352637, XrefRangeStart = 1352617, XrefRangeEnd = 1352634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelAfter(int millisecondsDelay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsDelay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_CancelAfter_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x000A2E6C File Offset: 0x000A106C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352637, XrefRangeEnd = 1352642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TimerCallbackLogic(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_TimerCallbackLogic_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x000A2EA4 File Offset: 0x000A10A4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1352646, RefRangeEnd = 1352656, XrefRangeStart = 1352642, XrefRangeEnd = 1352646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x000A2ED8 File Offset: 0x000A10D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1352665, RefRangeEnd = 1352668, XrefRangeStart = 1352656, XrefRangeEnd = 1352665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CancellationTokenSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x000A2F24 File Offset: 0x000A1124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352668, XrefRangeEnd = 1352669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x000A2F58 File Offset: 0x000A1158
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1352675, RefRangeEnd = 1352677, XrefRangeStart = 1352669, XrefRangeEnd = 1352675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowObjectDisposedException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_ThrowObjectDisposedException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x000A2F80 File Offset: 0x000A1180
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1352725, RefRangeEnd = 1352726, XrefRangeStart = 1352677, XrefRangeEnd = 1352725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationTokenRegistration InternalRegister(Action<Object> callback, Object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateForCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetSyncContext);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_InternalRegister_Internal_CancellationTokenRegistration_Action_1_Object_Object_SynchronizationContext_ExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CancellationTokenRegistration(intPtr);
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x000A3000 File Offset: 0x000A1200
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1352736, RefRangeEnd = 1352741, XrefRangeStart = 1352726, XrefRangeEnd = 1352736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyCancellation(bool throwOnFirstException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref throwOnFirstException;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_NotifyCancellation_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x000A3040 File Offset: 0x000A1240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1352794, RefRangeEnd = 1352795, XrefRangeStart = 1352741, XrefRangeEnd = 1352794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteCallbackHandlers(bool throwOnFirstException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref throwOnFirstException;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_ExecuteCallbackHandlers_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x000A3080 File Offset: 0x000A1280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352795, XrefRangeEnd = 1352799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancellationCallbackCoreWork_OnSyncContext(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_CancellationCallbackCoreWork_OnSyncContext_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x000A30C4 File Offset: 0x000A12C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1352807, RefRangeEnd = 1352809, XrefRangeStart = 1352799, XrefRangeEnd = 1352807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_CancellationCallbackCoreWork_Private_Void_CancellationCallbackCoreWorkArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x000A310C File Offset: 0x000A130C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1352846, RefRangeEnd = 1352850, XrefRangeStart = 1352809, XrefRangeEnd = 1352846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token1));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token2));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_CreateLinkedTokenSource_Public_Static_CancellationTokenSource_CancellationToken_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr3) : null;
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x000A316C File Offset: 0x000A136C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1352858, RefRangeEnd = 1352861, XrefRangeStart = 1352850, XrefRangeEnd = 1352858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_CreateLinkedTokenSource_Internal_Static_CancellationTokenSource_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr3) : null;
			}
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x000A31B8 File Offset: 0x000A13B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1352887, RefRangeEnd = 1352888, XrefRangeStart = 1352861, XrefRangeEnd = 1352887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CancellationTokenSource CreateLinkedTokenSource([Optional] Il2CppReferenceArray<CancellationToken> tokens)
		{
			if (tokens == null)
			{
				tokens = new Il2CppStructArray<CancellationToken>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_CreateLinkedTokenSource_Public_Static_CancellationTokenSource_Il2CppReferenceArray_1_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr3) : null;
			}
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x000A320C File Offset: 0x000A140C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352888, XrefRangeEnd = 1352897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callbackInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.NativeMethodInfoPtr_WaitForCallbackToComplete_Internal_Void_CancellationCallbackInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x000087D6 File Offset: 0x000069D6
		public static CancellationTokenSource CreateLinkedTokenSource(params CancellationToken[] tokens)
		{
			return CancellationTokenSource.CreateLinkedTokenSource(new Il2CppReferenceArray<CancellationToken>(tokens));
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x000087E3 File Offset: 0x000069E3
		public CancellationTokenSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x000A3250 File Offset: 0x000A1450
		// (set) Token: 0x06001AC4 RID: 6852 RVA: 0x000087EC File Offset: 0x000069EC
		public unsafe static CancellationTokenSource s_canceledSource
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CancellationTokenSource.NativeFieldInfoPtr_s_canceledSource, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationTokenSource.NativeFieldInfoPtr_s_canceledSource, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x000A3278 File Offset: 0x000A1478
		// (set) Token: 0x06001AC6 RID: 6854 RVA: 0x000087FE File Offset: 0x000069FE
		public unsafe static CancellationTokenSource s_neverCanceledSource
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CancellationTokenSource.NativeFieldInfoPtr_s_neverCanceledSource, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationTokenSource.NativeFieldInfoPtr_s_neverCanceledSource, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06001AC7 RID: 6855 RVA: 0x000A32A0 File Offset: 0x000A14A0
		// (set) Token: 0x06001AC8 RID: 6856 RVA: 0x00008810 File Offset: 0x00006A10
		public unsafe static int s_nLists
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CancellationTokenSource.NativeFieldInfoPtr_s_nLists, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationTokenSource.NativeFieldInfoPtr_s_nLists, (void*)(&value));
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x000A32BC File Offset: 0x000A14BC
		// (set) Token: 0x06001ACA RID: 6858 RVA: 0x0000881E File Offset: 0x00006A1E
		public unsafe ManualResetEvent _kernelEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr__kernelEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr__kernelEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001ACB RID: 6859 RVA: 0x000A32EC File Offset: 0x000A14EC
		// (set) Token: 0x06001ACC RID: 6860 RVA: 0x0000883D File Offset: 0x00006A3D
		public unsafe Il2CppReferenceArray<SparselyPopulatedArray<CancellationCallbackInfo>> _registeredCallbacksLists
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr__registeredCallbacksLists);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SparselyPopulatedArray<CancellationCallbackInfo>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr__registeredCallbacksLists), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001ACD RID: 6861 RVA: 0x000A331C File Offset: 0x000A151C
		// (set) Token: 0x06001ACE RID: 6862 RVA: 0x0000885C File Offset: 0x00006A5C
		public unsafe static int CannotBeCanceled
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CancellationTokenSource.NativeFieldInfoPtr_CannotBeCanceled, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationTokenSource.NativeFieldInfoPtr_CannotBeCanceled, (void*)(&value));
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001ACF RID: 6863 RVA: 0x000A3338 File Offset: 0x000A1538
		// (set) Token: 0x06001AD0 RID: 6864 RVA: 0x0000886A File Offset: 0x00006A6A
		public unsafe static int NotCanceledState
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CancellationTokenSource.NativeFieldInfoPtr_NotCanceledState, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationTokenSource.NativeFieldInfoPtr_NotCanceledState, (void*)(&value));
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x000A3354 File Offset: 0x000A1554
		// (set) Token: 0x06001AD2 RID: 6866 RVA: 0x00008878 File Offset: 0x00006A78
		public unsafe static int NotifyingState
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CancellationTokenSource.NativeFieldInfoPtr_NotifyingState, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationTokenSource.NativeFieldInfoPtr_NotifyingState, (void*)(&value));
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x000A3370 File Offset: 0x000A1570
		// (set) Token: 0x06001AD4 RID: 6868 RVA: 0x00008886 File Offset: 0x00006A86
		public unsafe static int NotifyingCompleteState
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CancellationTokenSource.NativeFieldInfoPtr_NotifyingCompleteState, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationTokenSource.NativeFieldInfoPtr_NotifyingCompleteState, (void*)(&value));
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001AD5 RID: 6869 RVA: 0x000A338C File Offset: 0x000A158C
		// (set) Token: 0x06001AD6 RID: 6870 RVA: 0x00008894 File Offset: 0x00006A94
		public unsafe int _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr__state)) = value;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x000A33B4 File Offset: 0x000A15B4
		// (set) Token: 0x06001AD8 RID: 6872 RVA: 0x000088AF File Offset: 0x00006AAF
		public unsafe int _threadIDExecutingCallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr__threadIDExecutingCallbacks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr__threadIDExecutingCallbacks)) = value;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06001AD9 RID: 6873 RVA: 0x000A33DC File Offset: 0x000A15DC
		// (set) Token: 0x06001ADA RID: 6874 RVA: 0x000088CA File Offset: 0x00006ACA
		public unsafe bool _disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr__disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr__disposed)) = value;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001ADB RID: 6875 RVA: 0x000A3404 File Offset: 0x000A1604
		// (set) Token: 0x06001ADC RID: 6876 RVA: 0x000088E5 File Offset: 0x00006AE5
		public unsafe CancellationCallbackInfo _executingCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr__executingCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationCallbackInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr__executingCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001ADD RID: 6877 RVA: 0x000A3434 File Offset: 0x000A1634
		// (set) Token: 0x06001ADE RID: 6878 RVA: 0x00008904 File Offset: 0x00006B04
		public unsafe Timer _timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr__timer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Timer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.NativeFieldInfoPtr__timer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06001ADF RID: 6879 RVA: 0x000A3464 File Offset: 0x000A1664
		// (set) Token: 0x06001AE0 RID: 6880 RVA: 0x00008923 File Offset: 0x00006B23
		public unsafe static TimerCallback s_timerCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CancellationTokenSource.NativeFieldInfoPtr_s_timerCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationTokenSource.NativeFieldInfoPtr_s_timerCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001891 RID: 6289
		private static readonly IntPtr NativeFieldInfoPtr_s_canceledSource;

		// Token: 0x04001892 RID: 6290
		private static readonly IntPtr NativeFieldInfoPtr_s_neverCanceledSource;

		// Token: 0x04001893 RID: 6291
		private static readonly IntPtr NativeFieldInfoPtr_s_nLists;

		// Token: 0x04001894 RID: 6292
		private static readonly IntPtr NativeFieldInfoPtr__kernelEvent;

		// Token: 0x04001895 RID: 6293
		private static readonly IntPtr NativeFieldInfoPtr__registeredCallbacksLists;

		// Token: 0x04001896 RID: 6294
		private static readonly IntPtr NativeFieldInfoPtr_CannotBeCanceled;

		// Token: 0x04001897 RID: 6295
		private static readonly IntPtr NativeFieldInfoPtr_NotCanceledState;

		// Token: 0x04001898 RID: 6296
		private static readonly IntPtr NativeFieldInfoPtr_NotifyingState;

		// Token: 0x04001899 RID: 6297
		private static readonly IntPtr NativeFieldInfoPtr_NotifyingCompleteState;

		// Token: 0x0400189A RID: 6298
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x0400189B RID: 6299
		private static readonly IntPtr NativeFieldInfoPtr__threadIDExecutingCallbacks;

		// Token: 0x0400189C RID: 6300
		private static readonly IntPtr NativeFieldInfoPtr__disposed;

		// Token: 0x0400189D RID: 6301
		private static readonly IntPtr NativeFieldInfoPtr__executingCallback;

		// Token: 0x0400189E RID: 6302
		private static readonly IntPtr NativeFieldInfoPtr__timer;

		// Token: 0x0400189F RID: 6303
		private static readonly IntPtr NativeFieldInfoPtr_s_timerCallback;

		// Token: 0x040018A0 RID: 6304
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCancellationRequested_Public_get_Boolean_0;

		// Token: 0x040018A1 RID: 6305
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCancellationCompleted_Internal_get_Boolean_0;

		// Token: 0x040018A2 RID: 6306
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDisposed_Internal_get_Boolean_0;

		// Token: 0x040018A3 RID: 6307
		private static readonly IntPtr NativeMethodInfoPtr_get_ThreadIDExecutingCallbacks_Internal_get_Int32_0;

		// Token: 0x040018A4 RID: 6308
		private static readonly IntPtr NativeMethodInfoPtr_set_ThreadIDExecutingCallbacks_Internal_set_Void_Int32_0;

		// Token: 0x040018A5 RID: 6309
		private static readonly IntPtr NativeMethodInfoPtr_get_Token_Public_get_CancellationToken_0;

		// Token: 0x040018A6 RID: 6310
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutingCallback_Internal_get_CancellationCallbackInfo_0;

		// Token: 0x040018A7 RID: 6311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040018A8 RID: 6312
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_0;

		// Token: 0x040018A9 RID: 6313
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040018AA RID: 6314
		private static readonly IntPtr NativeMethodInfoPtr_InitializeWithTimer_Private_Void_Int32_0;

		// Token: 0x040018AB RID: 6315
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		// Token: 0x040018AC RID: 6316
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_Boolean_0;

		// Token: 0x040018AD RID: 6317
		private static readonly IntPtr NativeMethodInfoPtr_CancelAfter_Public_Void_TimeSpan_0;

		// Token: 0x040018AE RID: 6318
		private static readonly IntPtr NativeMethodInfoPtr_CancelAfter_Public_Void_Int32_0;

		// Token: 0x040018AF RID: 6319
		private static readonly IntPtr NativeMethodInfoPtr_TimerCallbackLogic_Private_Static_Void_Object_0;

		// Token: 0x040018B0 RID: 6320
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040018B1 RID: 6321
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x040018B2 RID: 6322
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfDisposed_Internal_Void_0;

		// Token: 0x040018B3 RID: 6323
		private static readonly IntPtr NativeMethodInfoPtr_ThrowObjectDisposedException_Private_Static_Void_0;

		// Token: 0x040018B4 RID: 6324
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegister_Internal_CancellationTokenRegistration_Action_1_Object_Object_SynchronizationContext_ExecutionContext_0;

		// Token: 0x040018B5 RID: 6325
		private static readonly IntPtr NativeMethodInfoPtr_NotifyCancellation_Private_Void_Boolean_0;

		// Token: 0x040018B6 RID: 6326
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteCallbackHandlers_Private_Void_Boolean_0;

		// Token: 0x040018B7 RID: 6327
		private static readonly IntPtr NativeMethodInfoPtr_CancellationCallbackCoreWork_OnSyncContext_Private_Void_Object_0;

		// Token: 0x040018B8 RID: 6328
		private static readonly IntPtr NativeMethodInfoPtr_CancellationCallbackCoreWork_Private_Void_CancellationCallbackCoreWorkArguments_0;

		// Token: 0x040018B9 RID: 6329
		private static readonly IntPtr NativeMethodInfoPtr_CreateLinkedTokenSource_Public_Static_CancellationTokenSource_CancellationToken_CancellationToken_0;

		// Token: 0x040018BA RID: 6330
		private static readonly IntPtr NativeMethodInfoPtr_CreateLinkedTokenSource_Internal_Static_CancellationTokenSource_CancellationToken_0;

		// Token: 0x040018BB RID: 6331
		private static readonly IntPtr NativeMethodInfoPtr_CreateLinkedTokenSource_Public_Static_CancellationTokenSource_Il2CppReferenceArray_1_CancellationToken_0;

		// Token: 0x040018BC RID: 6332
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCallbackToComplete_Internal_Void_CancellationCallbackInfo_0;

		// Token: 0x02000605 RID: 1541
		public sealed class Linked1CancellationTokenSource : CancellationTokenSource
		{
			// Token: 0x06005822 RID: 22562 RVA: 0x00195C08 File Offset: 0x00193E08
			// Note: this type is marked as 'beforefieldinit'.
			static Linked1CancellationTokenSource()
			{
				Il2CppClassPointerStore<CancellationTokenSource.Linked1CancellationTokenSource>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "Linked1CancellationTokenSource");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancellationTokenSource.Linked1CancellationTokenSource>.NativeClassPtr);
				CancellationTokenSource.Linked1CancellationTokenSource.NativeFieldInfoPtr__reg1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource.Linked1CancellationTokenSource>.NativeClassPtr, "_reg1");
				CancellationTokenSource.Linked1CancellationTokenSource.NativeMethodInfoPtr__ctor_Internal_Void_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource.Linked1CancellationTokenSource>.NativeClassPtr, 100667952);
				CancellationTokenSource.Linked1CancellationTokenSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource.Linked1CancellationTokenSource>.NativeClassPtr, 100667953);
			}

			// Token: 0x06005823 RID: 22563 RVA: 0x00195C70 File Offset: 0x00193E70
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1352389, RefRangeEnd = 1352390, XrefRangeStart = 1352371, XrefRangeEnd = 1352389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Linked1CancellationTokenSource(CancellationToken token1)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationTokenSource.Linked1CancellationTokenSource>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token1));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.Linked1CancellationTokenSource.NativeMethodInfoPtr__ctor_Internal_Void_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005824 RID: 22564 RVA: 0x00195CC0 File Offset: 0x00193EC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352390, XrefRangeEnd = 1352392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose(bool disposing)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref disposing;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.Linked1CancellationTokenSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005825 RID: 22565 RVA: 0x0001F4BF File Offset: 0x0001D6BF
			public Linked1CancellationTokenSource(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001676 RID: 5750
			// (get) Token: 0x06005826 RID: 22566 RVA: 0x00195D00 File Offset: 0x00193F00
			// (set) Token: 0x06005827 RID: 22567 RVA: 0x0001F4C8 File Offset: 0x0001D6C8
			public CancellationTokenRegistration _reg1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.Linked1CancellationTokenSource.NativeFieldInfoPtr__reg1);
					return new CancellationTokenRegistration(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.Linked1CancellationTokenSource.NativeFieldInfoPtr__reg1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400488D RID: 18573
			private static readonly IntPtr NativeFieldInfoPtr__reg1;

			// Token: 0x0400488E RID: 18574
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CancellationToken_0;

			// Token: 0x0400488F RID: 18575
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
		}

		// Token: 0x02000606 RID: 1542
		public sealed class Linked2CancellationTokenSource : CancellationTokenSource
		{
			// Token: 0x06005828 RID: 22568 RVA: 0x00195D30 File Offset: 0x00193F30
			// Note: this type is marked as 'beforefieldinit'.
			static Linked2CancellationTokenSource()
			{
				Il2CppClassPointerStore<CancellationTokenSource.Linked2CancellationTokenSource>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "Linked2CancellationTokenSource");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancellationTokenSource.Linked2CancellationTokenSource>.NativeClassPtr);
				CancellationTokenSource.Linked2CancellationTokenSource.NativeFieldInfoPtr__reg1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource.Linked2CancellationTokenSource>.NativeClassPtr, "_reg1");
				CancellationTokenSource.Linked2CancellationTokenSource.NativeFieldInfoPtr__reg2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource.Linked2CancellationTokenSource>.NativeClassPtr, "_reg2");
				CancellationTokenSource.Linked2CancellationTokenSource.NativeMethodInfoPtr__ctor_Internal_Void_CancellationToken_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource.Linked2CancellationTokenSource>.NativeClassPtr, 100667954);
				CancellationTokenSource.Linked2CancellationTokenSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource.Linked2CancellationTokenSource>.NativeClassPtr, 100667955);
			}

			// Token: 0x06005829 RID: 22569 RVA: 0x00195DAC File Offset: 0x00193FAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352392, XrefRangeEnd = 1352416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Linked2CancellationTokenSource(CancellationToken token1, CancellationToken token2)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationTokenSource.Linked2CancellationTokenSource>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token1));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token2));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.Linked2CancellationTokenSource.NativeMethodInfoPtr__ctor_Internal_Void_CancellationToken_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600582A RID: 22570 RVA: 0x00195E14 File Offset: 0x00194014
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352416, XrefRangeEnd = 1352419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose(bool disposing)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref disposing;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.Linked2CancellationTokenSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600582B RID: 22571 RVA: 0x0001F4F6 File Offset: 0x0001D6F6
			public Linked2CancellationTokenSource(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001677 RID: 5751
			// (get) Token: 0x0600582C RID: 22572 RVA: 0x00195E54 File Offset: 0x00194054
			// (set) Token: 0x0600582D RID: 22573 RVA: 0x0001F4FF File Offset: 0x0001D6FF
			public CancellationTokenRegistration _reg1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.Linked2CancellationTokenSource.NativeFieldInfoPtr__reg1);
					return new CancellationTokenRegistration(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.Linked2CancellationTokenSource.NativeFieldInfoPtr__reg1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001678 RID: 5752
			// (get) Token: 0x0600582E RID: 22574 RVA: 0x00195E84 File Offset: 0x00194084
			// (set) Token: 0x0600582F RID: 22575 RVA: 0x0001F52D File Offset: 0x0001D72D
			public CancellationTokenRegistration _reg2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.Linked2CancellationTokenSource.NativeFieldInfoPtr__reg2);
					return new CancellationTokenRegistration(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.Linked2CancellationTokenSource.NativeFieldInfoPtr__reg2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04004890 RID: 18576
			private static readonly IntPtr NativeFieldInfoPtr__reg1;

			// Token: 0x04004891 RID: 18577
			private static readonly IntPtr NativeFieldInfoPtr__reg2;

			// Token: 0x04004892 RID: 18578
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CancellationToken_CancellationToken_0;

			// Token: 0x04004893 RID: 18579
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
		}

		// Token: 0x02000607 RID: 1543
		public sealed class LinkedNCancellationTokenSource : CancellationTokenSource
		{
			// Token: 0x06005830 RID: 22576 RVA: 0x00195EB4 File Offset: 0x001940B4
			// Note: this type is marked as 'beforefieldinit'.
			static LinkedNCancellationTokenSource()
			{
				Il2CppClassPointerStore<CancellationTokenSource.LinkedNCancellationTokenSource>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CancellationTokenSource>.NativeClassPtr, "LinkedNCancellationTokenSource");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancellationTokenSource.LinkedNCancellationTokenSource>.NativeClassPtr);
				CancellationTokenSource.LinkedNCancellationTokenSource.NativeFieldInfoPtr_s_linkedTokenCancelDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource.LinkedNCancellationTokenSource>.NativeClassPtr, "s_linkedTokenCancelDelegate");
				CancellationTokenSource.LinkedNCancellationTokenSource.NativeFieldInfoPtr__linkingRegistrations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource.LinkedNCancellationTokenSource>.NativeClassPtr, "_linkingRegistrations");
				CancellationTokenSource.LinkedNCancellationTokenSource.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource.LinkedNCancellationTokenSource>.NativeClassPtr, 100667956);
				CancellationTokenSource.LinkedNCancellationTokenSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource.LinkedNCancellationTokenSource>.NativeClassPtr, 100667957);
			}

			// Token: 0x06005831 RID: 22577 RVA: 0x00195F30 File Offset: 0x00194130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352438, XrefRangeEnd = 1352460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LinkedNCancellationTokenSource([Optional] Il2CppReferenceArray<CancellationToken> tokens)
			{
				if (tokens == null)
				{
					tokens = new Il2CppStructArray<CancellationToken>(0L);
				}
				this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationTokenSource.LinkedNCancellationTokenSource>.NativeClassPtr));
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.LinkedNCancellationTokenSource.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005832 RID: 22578 RVA: 0x00195F88 File Offset: 0x00194188
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352460, XrefRangeEnd = 1352464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose(bool disposing)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref disposing;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.LinkedNCancellationTokenSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005833 RID: 22579 RVA: 0x0001F55B File Offset: 0x0001D75B
			public LinkedNCancellationTokenSource(params CancellationToken[] tokens)
				: this(new Il2CppReferenceArray<CancellationToken>(tokens))
			{
			}

			// Token: 0x06005834 RID: 22580 RVA: 0x0001F569 File Offset: 0x0001D769
			public LinkedNCancellationTokenSource(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001679 RID: 5753
			// (get) Token: 0x06005835 RID: 22581 RVA: 0x00195FC8 File Offset: 0x001941C8
			// (set) Token: 0x06005836 RID: 22582 RVA: 0x0001F572 File Offset: 0x0001D772
			public unsafe static Action<Object> s_linkedTokenCancelDelegate
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CancellationTokenSource.LinkedNCancellationTokenSource.NativeFieldInfoPtr_s_linkedTokenCancelDelegate, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CancellationTokenSource.LinkedNCancellationTokenSource.NativeFieldInfoPtr_s_linkedTokenCancelDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700167A RID: 5754
			// (get) Token: 0x06005837 RID: 22583 RVA: 0x00195FF0 File Offset: 0x001941F0
			// (set) Token: 0x06005838 RID: 22584 RVA: 0x0001F584 File Offset: 0x0001D784
			public unsafe Il2CppReferenceArray<CancellationTokenRegistration> _linkingRegistrations
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.LinkedNCancellationTokenSource.NativeFieldInfoPtr__linkingRegistrations);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CancellationTokenRegistration>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationTokenSource.LinkedNCancellationTokenSource.NativeFieldInfoPtr__linkingRegistrations), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004894 RID: 18580
			private static readonly IntPtr NativeFieldInfoPtr_s_linkedTokenCancelDelegate;

			// Token: 0x04004895 RID: 18581
			private static readonly IntPtr NativeFieldInfoPtr__linkingRegistrations;

			// Token: 0x04004896 RID: 18582
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_CancellationToken_0;

			// Token: 0x04004897 RID: 18583
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

			// Token: 0x0200078E RID: 1934
			[ObfuscatedName("System.Threading.CancellationTokenSource+LinkedNCancellationTokenSource+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x06006313 RID: 25363 RVA: 0x001B9F68 File Offset: 0x001B8168
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<CancellationTokenSource.LinkedNCancellationTokenSource.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CancellationTokenSource.LinkedNCancellationTokenSource>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancellationTokenSource.LinkedNCancellationTokenSource.__c>.NativeClassPtr);
					CancellationTokenSource.LinkedNCancellationTokenSource.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationTokenSource.LinkedNCancellationTokenSource.__c>.NativeClassPtr, "<>9");
					CancellationTokenSource.LinkedNCancellationTokenSource.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource.LinkedNCancellationTokenSource.__c>.NativeClassPtr, 100667960);
					CancellationTokenSource.LinkedNCancellationTokenSource.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationTokenSource.LinkedNCancellationTokenSource.__c>.NativeClassPtr, 100667961);
				}

				// Token: 0x06006314 RID: 25364 RVA: 0x001B9FD0 File Offset: 0x001B81D0
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationTokenSource.LinkedNCancellationTokenSource.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.LinkedNCancellationTokenSource.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06006315 RID: 25365 RVA: 0x001BA00C File Offset: 0x001B820C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352419, XrefRangeEnd = 1352438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void __cctor_b__4_0(Object s)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationTokenSource.LinkedNCancellationTokenSource.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06006316 RID: 25366 RVA: 0x000251A6 File Offset: 0x000233A6
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17001995 RID: 6549
				// (get) Token: 0x06006317 RID: 25367 RVA: 0x001BA050 File Offset: 0x001B8250
				// (set) Token: 0x06006318 RID: 25368 RVA: 0x000251AF File Offset: 0x000233AF
				public unsafe static CancellationTokenSource.LinkedNCancellationTokenSource.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(CancellationTokenSource.LinkedNCancellationTokenSource.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource.LinkedNCancellationTokenSource.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(CancellationTokenSource.LinkedNCancellationTokenSource.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040050EC RID: 20716
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x040050ED RID: 20717
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040050EE RID: 20718
				private static readonly IntPtr NativeMethodInfoPtr___cctor_b__4_0_Internal_Void_Object_0;
			}
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net
{
	// Token: 0x0200018D RID: 397
	public class ContextAwareResult : LazyAsyncResult
	{
		// Token: 0x0600183D RID: 6205 RVA: 0x0007B3A8 File Offset: 0x000795A8
		// Note: this type is marked as 'beforefieldinit'.
		static ContextAwareResult()
		{
			Il2CppClassPointerStore<ContextAwareResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ContextAwareResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextAwareResult>.NativeClassPtr);
			ContextAwareResult.NativeFieldInfoPtr__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextAwareResult>.NativeClassPtr, "_context");
			ContextAwareResult.NativeFieldInfoPtr__lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextAwareResult>.NativeClassPtr, "_lock");
			ContextAwareResult.NativeFieldInfoPtr__flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextAwareResult>.NativeClassPtr, "_flags");
			ContextAwareResult.NativeMethodInfoPtr_SafeCaptureIdentity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextAwareResult>.NativeClassPtr, 100667123);
			ContextAwareResult.NativeMethodInfoPtr_CleanupInternal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextAwareResult>.NativeClassPtr, 100667124);
			ContextAwareResult.NativeMethodInfoPtr__ctor_Internal_Void_Object_Object_AsyncCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextAwareResult>.NativeClassPtr, 100667125);
			ContextAwareResult.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_Boolean_Object_Object_AsyncCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextAwareResult>.NativeClassPtr, 100667126);
			ContextAwareResult.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_Boolean_Boolean_Object_Object_AsyncCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextAwareResult>.NativeClassPtr, 100667127);
			ContextAwareResult.NativeMethodInfoPtr_StartPostingAsyncOp_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextAwareResult>.NativeClassPtr, 100667128);
			ContextAwareResult.NativeMethodInfoPtr_StartPostingAsyncOp_Internal_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextAwareResult>.NativeClassPtr, 100667129);
			ContextAwareResult.NativeMethodInfoPtr_FinishPostingAsyncOp_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextAwareResult>.NativeClassPtr, 100667130);
			ContextAwareResult.NativeMethodInfoPtr_Cleanup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextAwareResult>.NativeClassPtr, 100667131);
			ContextAwareResult.NativeMethodInfoPtr_CaptureOrComplete_Private_Boolean_byref_ExecutionContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextAwareResult>.NativeClassPtr, 100667132);
			ContextAwareResult.NativeMethodInfoPtr_Complete_Protected_Virtual_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextAwareResult>.NativeClassPtr, 100667133);
			ContextAwareResult.NativeMethodInfoPtr_CompleteCallback_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextAwareResult>.NativeClassPtr, 100667134);
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x0007B504 File Offset: 0x00079704
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SafeCaptureIdentity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextAwareResult.NativeMethodInfoPtr_SafeCaptureIdentity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x0007B538 File Offset: 0x00079738
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextAwareResult.NativeMethodInfoPtr_CleanupInternal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x0007B56C File Offset: 0x0007976C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470605, XrefRangeEnd = 470606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextAwareResult(Object myObject, Object myState, AsyncCallback myCallBack)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextAwareResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(myObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(myState);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(myCallBack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextAwareResult.NativeMethodInfoPtr__ctor_Internal_Void_Object_Object_AsyncCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x0007B5DC File Offset: 0x000797DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470606, XrefRangeEnd = 470607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextAwareResult(bool captureIdentity, bool forceCaptureContext, Object myObject, Object myState, AsyncCallback myCallBack)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextAwareResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref captureIdentity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceCaptureContext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(myObject);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(myState);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(myCallBack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextAwareResult.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_Boolean_Object_Object_AsyncCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x0007B66C File Offset: 0x0007986C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470607, XrefRangeEnd = 470608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextAwareResult(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, Object myObject, Object myState, AsyncCallback myCallBack)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextAwareResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref captureIdentity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceCaptureContext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threadSafeContextCopy;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(myObject);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(myState);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(myCallBack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextAwareResult.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_Boolean_Boolean_Object_Object_AsyncCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x0007B708 File Offset: 0x00079908
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 470622, RefRangeEnd = 470625, XrefRangeStart = 470608, XrefRangeEnd = 470622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object StartPostingAsyncOp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextAwareResult.NativeMethodInfoPtr_StartPostingAsyncOp_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x0007B748 File Offset: 0x00079948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470625, XrefRangeEnd = 470640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object StartPostingAsyncOp(bool lockCapture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lockCapture;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextAwareResult.NativeMethodInfoPtr_StartPostingAsyncOp_Internal_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x0007B794 File Offset: 0x00079994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470640, XrefRangeEnd = 470641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FinishPostingAsyncOp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextAwareResult.NativeMethodInfoPtr_FinishPostingAsyncOp_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x0007B7D0 File Offset: 0x000799D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470641, XrefRangeEnd = 470655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContextAwareResult.NativeMethodInfoPtr_Cleanup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x0007B80C File Offset: 0x00079A0C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 470701, RefRangeEnd = 470705, XrefRangeStart = 470655, XrefRangeEnd = 470701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CaptureOrComplete(ref ExecutionContext cachedContext, bool returnContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(cachedContext);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnContext;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ContextAwareResult.NativeMethodInfoPtr_CaptureOrComplete_Private_Boolean_byref_ExecutionContext_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			cachedContext = ((intPtr4 == 0) ? null : new ExecutionContext(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x0007B880 File Offset: 0x00079A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470705, XrefRangeEnd = 470757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Complete(IntPtr userToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userToken;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContextAwareResult.NativeMethodInfoPtr_Complete_Protected_Virtual_Void_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x0007B8CC File Offset: 0x00079ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470757, XrefRangeEnd = 470774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteCallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextAwareResult.NativeMethodInfoPtr_CompleteCallback_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x0000A716 File Offset: 0x00008916
		public ContextAwareResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x0600184B RID: 6219 RVA: 0x0007B900 File Offset: 0x00079B00
		// (set) Token: 0x0600184C RID: 6220 RVA: 0x0000A71F File Offset: 0x0000891F
		public unsafe ExecutionContext _context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextAwareResult.NativeFieldInfoPtr__context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextAwareResult.NativeFieldInfoPtr__context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x0007B930 File Offset: 0x00079B30
		// (set) Token: 0x0600184E RID: 6222 RVA: 0x0000A73E File Offset: 0x0000893E
		public unsafe Object _lock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextAwareResult.NativeFieldInfoPtr__lock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextAwareResult.NativeFieldInfoPtr__lock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x0600184F RID: 6223 RVA: 0x0007B960 File Offset: 0x00079B60
		// (set) Token: 0x06001850 RID: 6224 RVA: 0x0000A75D File Offset: 0x0000895D
		public unsafe ContextAwareResult.StateFlags _flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextAwareResult.NativeFieldInfoPtr__flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextAwareResult.NativeFieldInfoPtr__flags)) = value;
			}
		}

		// Token: 0x040012DD RID: 4829
		private static readonly IntPtr NativeFieldInfoPtr__context;

		// Token: 0x040012DE RID: 4830
		private static readonly IntPtr NativeFieldInfoPtr__lock;

		// Token: 0x040012DF RID: 4831
		private static readonly IntPtr NativeFieldInfoPtr__flags;

		// Token: 0x040012E0 RID: 4832
		private static readonly IntPtr NativeMethodInfoPtr_SafeCaptureIdentity_Private_Void_0;

		// Token: 0x040012E1 RID: 4833
		private static readonly IntPtr NativeMethodInfoPtr_CleanupInternal_Private_Void_0;

		// Token: 0x040012E2 RID: 4834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_Object_AsyncCallback_0;

		// Token: 0x040012E3 RID: 4835
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_Boolean_Object_Object_AsyncCallback_0;

		// Token: 0x040012E4 RID: 4836
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_Boolean_Boolean_Object_Object_AsyncCallback_0;

		// Token: 0x040012E5 RID: 4837
		private static readonly IntPtr NativeMethodInfoPtr_StartPostingAsyncOp_Internal_Object_0;

		// Token: 0x040012E6 RID: 4838
		private static readonly IntPtr NativeMethodInfoPtr_StartPostingAsyncOp_Internal_Object_Boolean_0;

		// Token: 0x040012E7 RID: 4839
		private static readonly IntPtr NativeMethodInfoPtr_FinishPostingAsyncOp_Internal_Boolean_0;

		// Token: 0x040012E8 RID: 4840
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Protected_Virtual_Void_0;

		// Token: 0x040012E9 RID: 4841
		private static readonly IntPtr NativeMethodInfoPtr_CaptureOrComplete_Private_Boolean_byref_ExecutionContext_Boolean_0;

		// Token: 0x040012EA RID: 4842
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Protected_Virtual_Void_IntPtr_0;

		// Token: 0x040012EB RID: 4843
		private static readonly IntPtr NativeMethodInfoPtr_CompleteCallback_Private_Void_0;

		// Token: 0x0200030F RID: 783
		[Flags]
		public enum StateFlags : byte
		{
			// Token: 0x04002477 RID: 9335
			None = 0,
			// Token: 0x04002478 RID: 9336
			CaptureIdentity = 1,
			// Token: 0x04002479 RID: 9337
			CaptureContext = 2,
			// Token: 0x0400247A RID: 9338
			ThreadSafeContextCopy = 4,
			// Token: 0x0400247B RID: 9339
			PostBlockStarted = 8,
			// Token: 0x0400247C RID: 9340
			PostBlockFinished = 16
		}

		// Token: 0x02000310 RID: 784
		[ObfuscatedName("System.Net.ContextAwareResult+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002E80 RID: 11904 RVA: 0x000CBF78 File Offset: 0x000CA178
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ContextAwareResult.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContextAwareResult>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextAwareResult.__c>.NativeClassPtr);
				ContextAwareResult.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextAwareResult.__c>.NativeClassPtr, "<>9");
				ContextAwareResult.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextAwareResult.__c>.NativeClassPtr, "<>9__17_0");
				ContextAwareResult.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextAwareResult.__c>.NativeClassPtr, 100667136);
				ContextAwareResult.__c.NativeMethodInfoPtr__Complete_b__17_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextAwareResult.__c>.NativeClassPtr, 100667137);
			}

			// Token: 0x06002E81 RID: 11905 RVA: 0x000CBFF4 File Offset: 0x000CA1F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextAwareResult.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextAwareResult.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E82 RID: 11906 RVA: 0x000CC030 File Offset: 0x000CA230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470585, XrefRangeEnd = 470605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Complete_b__17_0(Object s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextAwareResult.__c.NativeMethodInfoPtr__Complete_b__17_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002E83 RID: 11907 RVA: 0x00014C50 File Offset: 0x00012E50
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E91 RID: 3729
			// (get) Token: 0x06002E84 RID: 11908 RVA: 0x000CC074 File Offset: 0x000CA274
			// (set) Token: 0x06002E85 RID: 11909 RVA: 0x00014C59 File Offset: 0x00012E59
			public unsafe static ContextAwareResult.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ContextAwareResult.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextAwareResult.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ContextAwareResult.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E92 RID: 3730
			// (get) Token: 0x06002E86 RID: 11910 RVA: 0x000CC09C File Offset: 0x000CA29C
			// (set) Token: 0x06002E87 RID: 11911 RVA: 0x00014C6B File Offset: 0x00012E6B
			public unsafe static ContextCallback __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ContextAwareResult.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ContextAwareResult.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400247D RID: 9341
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400247E RID: 9342
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x0400247F RID: 9343
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002480 RID: 9344
			private static readonly IntPtr NativeMethodInfoPtr__Complete_b__17_0_Internal_Void_Object_0;
		}
	}
}

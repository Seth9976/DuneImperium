using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200019D RID: 413
	public class CancellationCallbackInfo : Object
	{
		// Token: 0x06001AE9 RID: 6889 RVA: 0x000A35B0 File Offset: 0x000A17B0
		// Note: this type is marked as 'beforefieldinit'.
		static CancellationCallbackInfo()
		{
			Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "CancellationCallbackInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr);
			CancellationCallbackInfo.NativeFieldInfoPtr_Callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, "Callback");
			CancellationCallbackInfo.NativeFieldInfoPtr_StateForCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, "StateForCallback");
			CancellationCallbackInfo.NativeFieldInfoPtr_TargetExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, "TargetExecutionContext");
			CancellationCallbackInfo.NativeFieldInfoPtr_CancellationTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, "CancellationTokenSource");
			CancellationCallbackInfo.NativeFieldInfoPtr_s_executionContextCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, "s_executionContextCallback");
			CancellationCallbackInfo.NativeMethodInfoPtr__ctor_Internal_Void_Action_1_Object_Object_ExecutionContext_CancellationTokenSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, 100667963);
			CancellationCallbackInfo.NativeMethodInfoPtr_ExecuteCallback_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, 100667964);
			CancellationCallbackInfo.NativeMethodInfoPtr_ExecutionContextCallback_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, 100667965);
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x000A3680 File Offset: 0x000A1880
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1352908, RefRangeEnd = 1352909, XrefRangeStart = 1352903, XrefRangeEnd = 1352908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationCallbackInfo(Action<Object> callback, Object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateForCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetExecutionContext);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cancellationTokenSource);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationCallbackInfo.NativeMethodInfoPtr__ctor_Internal_Void_Action_1_Object_Object_ExecutionContext_CancellationTokenSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x000A3704 File Offset: 0x000A1904
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1352940, RefRangeEnd = 1352941, XrefRangeStart = 1352909, XrefRangeEnd = 1352940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteCallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationCallbackInfo.NativeMethodInfoPtr_ExecuteCallback_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x000A3738 File Offset: 0x000A1938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352941, XrefRangeEnd = 1352945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecutionContextCallback(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationCallbackInfo.NativeMethodInfoPtr_ExecutionContextCallback_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x0000898A File Offset: 0x00006B8A
		public CancellationCallbackInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001AEE RID: 6894 RVA: 0x000A3770 File Offset: 0x000A1970
		// (set) Token: 0x06001AEF RID: 6895 RVA: 0x00008993 File Offset: 0x00006B93
		public unsafe Action<Object> Callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_Callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_Callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x000A37A0 File Offset: 0x000A19A0
		// (set) Token: 0x06001AF1 RID: 6897 RVA: 0x000089B2 File Offset: 0x00006BB2
		public unsafe Object StateForCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_StateForCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_StateForCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001AF2 RID: 6898 RVA: 0x000A37D0 File Offset: 0x000A19D0
		// (set) Token: 0x06001AF3 RID: 6899 RVA: 0x000089D1 File Offset: 0x00006BD1
		public unsafe ExecutionContext TargetExecutionContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_TargetExecutionContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_TargetExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x000A3800 File Offset: 0x000A1A00
		// (set) Token: 0x06001AF5 RID: 6901 RVA: 0x000089F0 File Offset: 0x00006BF0
		public unsafe CancellationTokenSource CancellationTokenSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_CancellationTokenSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.NativeFieldInfoPtr_CancellationTokenSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001AF6 RID: 6902 RVA: 0x000A3830 File Offset: 0x000A1A30
		// (set) Token: 0x06001AF7 RID: 6903 RVA: 0x00008A0F File Offset: 0x00006C0F
		public unsafe static ContextCallback s_executionContextCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CancellationCallbackInfo.NativeFieldInfoPtr_s_executionContextCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationCallbackInfo.NativeFieldInfoPtr_s_executionContextCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018C0 RID: 6336
		private static readonly IntPtr NativeFieldInfoPtr_Callback;

		// Token: 0x040018C1 RID: 6337
		private static readonly IntPtr NativeFieldInfoPtr_StateForCallback;

		// Token: 0x040018C2 RID: 6338
		private static readonly IntPtr NativeFieldInfoPtr_TargetExecutionContext;

		// Token: 0x040018C3 RID: 6339
		private static readonly IntPtr NativeFieldInfoPtr_CancellationTokenSource;

		// Token: 0x040018C4 RID: 6340
		private static readonly IntPtr NativeFieldInfoPtr_s_executionContextCallback;

		// Token: 0x040018C5 RID: 6341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Action_1_Object_Object_ExecutionContext_CancellationTokenSource_0;

		// Token: 0x040018C6 RID: 6342
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteCallback_Internal_Void_0;

		// Token: 0x040018C7 RID: 6343
		private static readonly IntPtr NativeMethodInfoPtr_ExecutionContextCallback_Private_Static_Void_Object_0;

		// Token: 0x02000608 RID: 1544
		public sealed class WithSyncContext : CancellationCallbackInfo
		{
			// Token: 0x06005839 RID: 22585 RVA: 0x00196020 File Offset: 0x00194220
			// Note: this type is marked as 'beforefieldinit'.
			static WithSyncContext()
			{
				Il2CppClassPointerStore<CancellationCallbackInfo.WithSyncContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CancellationCallbackInfo>.NativeClassPtr, "WithSyncContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancellationCallbackInfo.WithSyncContext>.NativeClassPtr);
				CancellationCallbackInfo.WithSyncContext.NativeFieldInfoPtr_TargetSyncContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackInfo.WithSyncContext>.NativeClassPtr, "TargetSyncContext");
				CancellationCallbackInfo.WithSyncContext.NativeMethodInfoPtr__ctor_Internal_Void_Action_1_Object_Object_ExecutionContext_CancellationTokenSource_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationCallbackInfo.WithSyncContext>.NativeClassPtr, 100667966);
			}

			// Token: 0x0600583A RID: 22586 RVA: 0x00196074 File Offset: 0x00194274
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352897, XrefRangeEnd = 1352903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WithSyncContext(Action<Object> callback, Object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource, SynchronizationContext targetSyncContext)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationCallbackInfo.WithSyncContext>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateForCallback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetExecutionContext);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cancellationTokenSource);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetSyncContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationCallbackInfo.WithSyncContext.NativeMethodInfoPtr__ctor_Internal_Void_Action_1_Object_Object_ExecutionContext_CancellationTokenSource_SynchronizationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600583B RID: 22587 RVA: 0x0001F5A3 File Offset: 0x0001D7A3
			public WithSyncContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700167B RID: 5755
			// (get) Token: 0x0600583C RID: 22588 RVA: 0x0019610C File Offset: 0x0019430C
			// (set) Token: 0x0600583D RID: 22589 RVA: 0x0001F5AC File Offset: 0x0001D7AC
			public unsafe SynchronizationContext TargetSyncContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.WithSyncContext.NativeFieldInfoPtr_TargetSyncContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackInfo.WithSyncContext.NativeFieldInfoPtr_TargetSyncContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004898 RID: 18584
			private static readonly IntPtr NativeFieldInfoPtr_TargetSyncContext;

			// Token: 0x04004899 RID: 18585
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Action_1_Object_Object_ExecutionContext_CancellationTokenSource_SynchronizationContext_0;
		}
	}
}

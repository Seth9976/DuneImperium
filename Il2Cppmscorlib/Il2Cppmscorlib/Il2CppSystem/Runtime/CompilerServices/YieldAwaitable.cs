using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003D4 RID: 980
	[StructLayout(2)]
	public struct YieldAwaitable
	{
		// Token: 0x060039EB RID: 14827 RVA: 0x00015832 File Offset: 0x00013A32
		// Note: this type is marked as 'beforefieldinit'.
		static YieldAwaitable()
		{
			Il2CppClassPointerStore<YieldAwaitable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "YieldAwaitable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YieldAwaitable>.NativeClassPtr);
			YieldAwaitable.NativeMethodInfoPtr_GetAwaiter_Public_YieldAwaiter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldAwaitable>.NativeClassPtr, 100671943);
		}

		// Token: 0x060039EC RID: 14828 RVA: 0x00117B74 File Offset: 0x00115D74
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe YieldAwaitable.YieldAwaiter GetAwaiter()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YieldAwaitable.NativeMethodInfoPtr_GetAwaiter_Public_YieldAwaiter_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039ED RID: 14829 RVA: 0x0001586B File Offset: 0x00013A6B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<YieldAwaitable>.NativeClassPtr, ref this));
		}

		// Token: 0x04002EF3 RID: 12019
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_YieldAwaiter_0;

		// Token: 0x0200069D RID: 1693
		[StructLayout(2)]
		public struct YieldAwaiter : INotifyCompletion
		{
			// Token: 0x06005C1E RID: 23582 RVA: 0x001A244C File Offset: 0x001A064C
			// Note: this type is marked as 'beforefieldinit'.
			static YieldAwaiter()
			{
				Il2CppClassPointerStore<YieldAwaitable.YieldAwaiter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YieldAwaitable>.NativeClassPtr, "YieldAwaiter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YieldAwaitable.YieldAwaiter>.NativeClassPtr);
				YieldAwaitable.YieldAwaiter.NativeFieldInfoPtr_s_waitCallbackRunAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldAwaitable.YieldAwaiter>.NativeClassPtr, "s_waitCallbackRunAction");
				YieldAwaitable.YieldAwaiter.NativeFieldInfoPtr_s_sendOrPostCallbackRunAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldAwaitable.YieldAwaiter>.NativeClassPtr, "s_sendOrPostCallbackRunAction");
				YieldAwaitable.YieldAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldAwaitable.YieldAwaiter>.NativeClassPtr, 100671944);
				YieldAwaitable.YieldAwaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldAwaitable.YieldAwaiter>.NativeClassPtr, 100671945);
				YieldAwaitable.YieldAwaiter.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldAwaitable.YieldAwaiter>.NativeClassPtr, 100671946);
				YieldAwaitable.YieldAwaiter.NativeMethodInfoPtr_QueueContinuation_Private_Static_Void_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldAwaitable.YieldAwaiter>.NativeClassPtr, 100671947);
				YieldAwaitable.YieldAwaiter.NativeMethodInfoPtr_RunAction_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldAwaitable.YieldAwaiter>.NativeClassPtr, 100671948);
				YieldAwaitable.YieldAwaiter.NativeMethodInfoPtr_GetResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldAwaitable.YieldAwaiter>.NativeClassPtr, 100671949);
			}

			// Token: 0x17001792 RID: 6034
			// (get) Token: 0x06005C1F RID: 23583 RVA: 0x001A2518 File Offset: 0x001A0718
			public unsafe bool IsCompleted
			{
				[CallerCount(184)]
				[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YieldAwaitable.YieldAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005C20 RID: 23584 RVA: 0x001A2548 File Offset: 0x001A0748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395745, XrefRangeEnd = 1395749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnCompleted(Action continuation)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YieldAwaitable.YieldAwaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005C21 RID: 23585 RVA: 0x001A2580 File Offset: 0x001A0780
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395749, XrefRangeEnd = 1395771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UnsafeOnCompleted(Action continuation)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YieldAwaitable.YieldAwaiter.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005C22 RID: 23586 RVA: 0x001A25B8 File Offset: 0x001A07B8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1395786, RefRangeEnd = 1395788, XrefRangeStart = 1395771, XrefRangeEnd = 1395786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void QueueContinuation(Action continuation, bool flowContext)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flowContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YieldAwaitable.YieldAwaiter.NativeMethodInfoPtr_QueueContinuation_Private_Static_Void_Action_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C23 RID: 23587 RVA: 0x001A25FC File Offset: 0x001A07FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395788, XrefRangeEnd = 1395792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void RunAction(Object state)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YieldAwaitable.YieldAwaiter.NativeMethodInfoPtr_RunAction_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005C24 RID: 23588 RVA: 0x001A2634 File Offset: 0x001A0834
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GetResult()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YieldAwaitable.YieldAwaiter.NativeMethodInfoPtr_GetResult_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C25 RID: 23589 RVA: 0x000216C2 File Offset: 0x0001F8C2
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<YieldAwaitable.YieldAwaiter>.NativeClassPtr, ref this));
			}

			// Token: 0x17001790 RID: 6032
			// (get) Token: 0x06005C26 RID: 23590 RVA: 0x001A265C File Offset: 0x001A085C
			// (set) Token: 0x06005C27 RID: 23591 RVA: 0x000216D4 File Offset: 0x0001F8D4
			public unsafe static WaitCallback s_waitCallbackRunAction
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YieldAwaitable.YieldAwaiter.NativeFieldInfoPtr_s_waitCallbackRunAction, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YieldAwaitable.YieldAwaiter.NativeFieldInfoPtr_s_waitCallbackRunAction, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001791 RID: 6033
			// (get) Token: 0x06005C28 RID: 23592 RVA: 0x001A2684 File Offset: 0x001A0884
			// (set) Token: 0x06005C29 RID: 23593 RVA: 0x000216E6 File Offset: 0x0001F8E6
			public unsafe static SendOrPostCallback s_sendOrPostCallbackRunAction
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YieldAwaitable.YieldAwaiter.NativeFieldInfoPtr_s_sendOrPostCallbackRunAction, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendOrPostCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YieldAwaitable.YieldAwaiter.NativeFieldInfoPtr_s_sendOrPostCallbackRunAction, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x06005C2A RID: 23594 RVA: 0x000216F8 File Offset: 0x0001F8F8
			public void OnCompleted(Action continuation)
			{
				this.OnCompleted(continuation);
			}

			// Token: 0x04004AE5 RID: 19173
			private static readonly IntPtr NativeFieldInfoPtr_s_waitCallbackRunAction;

			// Token: 0x04004AE6 RID: 19174
			private static readonly IntPtr NativeFieldInfoPtr_s_sendOrPostCallbackRunAction;

			// Token: 0x04004AE7 RID: 19175
			private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

			// Token: 0x04004AE8 RID: 19176
			private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0;

			// Token: 0x04004AE9 RID: 19177
			private static readonly IntPtr NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0;

			// Token: 0x04004AEA RID: 19178
			private static readonly IntPtr NativeMethodInfoPtr_QueueContinuation_Private_Static_Void_Action_Boolean_0;

			// Token: 0x04004AEB RID: 19179
			private static readonly IntPtr NativeMethodInfoPtr_RunAction_Private_Static_Void_Object_0;

			// Token: 0x04004AEC RID: 19180
			private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_Void_0;
		}
	}
}

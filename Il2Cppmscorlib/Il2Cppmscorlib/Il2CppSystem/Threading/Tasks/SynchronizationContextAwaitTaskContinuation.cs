using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001E2 RID: 482
	public sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation
	{
		// Token: 0x06001F95 RID: 8085 RVA: 0x000B5B70 File Offset: 0x000B3D70
		// Note: this type is marked as 'beforefieldinit'.
		static SynchronizationContextAwaitTaskContinuation()
		{
			Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "SynchronizationContextAwaitTaskContinuation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr);
			SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_s_postCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr, "s_postCallback");
			SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_s_postActionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr, "s_postActionCallback");
			SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_m_syncContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr, "m_syncContext");
			SynchronizationContextAwaitTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_SynchronizationContext_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr, 100668665);
			SynchronizationContextAwaitTaskContinuation.NativeMethodInfoPtr_Run_Internal_Virtual_Final_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr, 100668666);
			SynchronizationContextAwaitTaskContinuation.NativeMethodInfoPtr_PostAction_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr, 100668667);
			SynchronizationContextAwaitTaskContinuation.NativeMethodInfoPtr_GetPostActionCallback_Private_Static_ContextCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr, 100668668);
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x000B5C2C File Offset: 0x000B3E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361392, XrefRangeEnd = 1361394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SynchronizationContextAwaitTaskContinuation(SynchronizationContext context, Action action, bool flowExecutionContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flowExecutionContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContextAwaitTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_SynchronizationContext_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x000B5C98 File Offset: 0x000B3E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361394, XrefRangeEnd = 1361424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Run(Task ignored, bool canInlineContinuationTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ignored);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canInlineContinuationTask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContextAwaitTaskContinuation.NativeMethodInfoPtr_Run_Internal_Virtual_Final_Void_Task_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x000B5CE8 File Offset: 0x000B3EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361424, XrefRangeEnd = 1361430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PostAction(Object state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContextAwaitTaskContinuation.NativeMethodInfoPtr_PostAction_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x000B5D20 File Offset: 0x000B3F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361430, XrefRangeEnd = 1361445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ContextCallback GetPostActionCallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContextAwaitTaskContinuation.NativeMethodInfoPtr_GetPostActionCallback_Private_Static_ContextCallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr3) : null;
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x0000A41B File Offset: 0x0000861B
		public SynchronizationContextAwaitTaskContinuation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x000B5D54 File Offset: 0x000B3F54
		// (set) Token: 0x06001F9C RID: 8092 RVA: 0x0000A424 File Offset: 0x00008624
		public unsafe static SendOrPostCallback s_postCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_s_postCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendOrPostCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_s_postCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x000B5D7C File Offset: 0x000B3F7C
		// (set) Token: 0x06001F9E RID: 8094 RVA: 0x0000A436 File Offset: 0x00008636
		public unsafe static ContextCallback s_postActionCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_s_postActionCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_s_postActionCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x000B5DA4 File Offset: 0x000B3FA4
		// (set) Token: 0x06001FA0 RID: 8096 RVA: 0x0000A448 File Offset: 0x00008648
		public unsafe SynchronizationContext m_syncContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_m_syncContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SynchronizationContextAwaitTaskContinuation.NativeFieldInfoPtr_m_syncContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C27 RID: 7207
		private static readonly IntPtr NativeFieldInfoPtr_s_postCallback;

		// Token: 0x04001C28 RID: 7208
		private static readonly IntPtr NativeFieldInfoPtr_s_postActionCallback;

		// Token: 0x04001C29 RID: 7209
		private static readonly IntPtr NativeFieldInfoPtr_m_syncContext;

		// Token: 0x04001C2A RID: 7210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SynchronizationContext_Action_Boolean_0;

		// Token: 0x04001C2B RID: 7211
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Virtual_Final_Void_Task_Boolean_0;

		// Token: 0x04001C2C RID: 7212
		private static readonly IntPtr NativeMethodInfoPtr_PostAction_Private_Static_Void_Object_0;

		// Token: 0x04001C2D RID: 7213
		private static readonly IntPtr NativeMethodInfoPtr_GetPostActionCallback_Private_Static_ContextCallback_0;

		// Token: 0x02000640 RID: 1600
		[ObfuscatedName("System.Threading.Tasks.SynchronizationContextAwaitTaskContinuation+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600597C RID: 22908 RVA: 0x0019A180 File Offset: 0x00198380
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation.__c>.NativeClassPtr);
				SynchronizationContextAwaitTaskContinuation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation.__c>.NativeClassPtr, "<>9");
				SynchronizationContextAwaitTaskContinuation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation.__c>.NativeClassPtr, 100668671);
				SynchronizationContextAwaitTaskContinuation.__c.NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation.__c>.NativeClassPtr, 100668672);
			}

			// Token: 0x0600597D RID: 22909 RVA: 0x0019A1E8 File Offset: 0x001983E8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SynchronizationContextAwaitTaskContinuation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContextAwaitTaskContinuation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600597E RID: 22910 RVA: 0x0019A224 File Offset: 0x00198424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361346, XrefRangeEnd = 1361392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__7_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContextAwaitTaskContinuation.__c.NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600597F RID: 22911 RVA: 0x0002007D File Offset: 0x0001E27D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016D0 RID: 5840
			// (get) Token: 0x06005980 RID: 22912 RVA: 0x0019A268 File Offset: 0x00198468
			// (set) Token: 0x06005981 RID: 22913 RVA: 0x00020086 File Offset: 0x0001E286
			public unsafe static SynchronizationContextAwaitTaskContinuation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SynchronizationContextAwaitTaskContinuation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SynchronizationContextAwaitTaskContinuation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SynchronizationContextAwaitTaskContinuation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400495D RID: 18781
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400495E RID: 18782
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400495F RID: 18783
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_Object_0;
		}
	}
}

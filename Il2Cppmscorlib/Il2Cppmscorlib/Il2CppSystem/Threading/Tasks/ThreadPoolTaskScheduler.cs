using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001E9 RID: 489
	public sealed class ThreadPoolTaskScheduler : TaskScheduler
	{
		// Token: 0x0600200C RID: 8204 RVA: 0x000B7AD8 File Offset: 0x000B5CD8
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadPoolTaskScheduler()
		{
			Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "ThreadPoolTaskScheduler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr);
			ThreadPoolTaskScheduler.NativeFieldInfoPtr_s_longRunningThreadWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr, "s_longRunningThreadWork");
			ThreadPoolTaskScheduler.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr, 100668734);
			ThreadPoolTaskScheduler.NativeMethodInfoPtr_QueueTask_FamOrAssem_Virtual_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr, 100668735);
			ThreadPoolTaskScheduler.NativeMethodInfoPtr_TryExecuteTaskInline_Protected_Virtual_Boolean_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr, 100668736);
			ThreadPoolTaskScheduler.NativeMethodInfoPtr_TryDequeue_FamOrAssem_Virtual_Boolean_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr, 100668737);
			ThreadPoolTaskScheduler.NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr, 100668738);
			ThreadPoolTaskScheduler.NativeMethodInfoPtr_get_RequiresAtomicStartTransition_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr, 100668739);
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x000B7B94 File Offset: 0x000B5D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361981, XrefRangeEnd = 1361985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadPoolTaskScheduler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolTaskScheduler.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x000B7BD0 File Offset: 0x000B5DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361985, XrefRangeEnd = 1362026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void QueueTask(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolTaskScheduler.NativeMethodInfoPtr_QueueTask_FamOrAssem_Virtual_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x000B7C14 File Offset: 0x000B5E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1362026, XrefRangeEnd = 1362027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref taskWasPreviouslyQueued;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolTaskScheduler.NativeMethodInfoPtr_TryExecuteTaskInline_Protected_Virtual_Boolean_Task_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x000B7C70 File Offset: 0x000B5E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1362027, XrefRangeEnd = 1362028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryDequeue(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolTaskScheduler.NativeMethodInfoPtr_TryDequeue_FamOrAssem_Virtual_Boolean_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x000B7CC0 File Offset: 0x000B5EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NotifyWorkItemProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolTaskScheduler.NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06002012 RID: 8210 RVA: 0x000B7CF4 File Offset: 0x000B5EF4
		public unsafe override bool RequiresAtomicStartTransition
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolTaskScheduler.NativeMethodInfoPtr_get_RequiresAtomicStartTransition_Internal_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x0000A6C0 File Offset: 0x000088C0
		public ThreadPoolTaskScheduler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06002014 RID: 8212 RVA: 0x000B7D30 File Offset: 0x000B5F30
		// (set) Token: 0x06002015 RID: 8213 RVA: 0x0000A6C9 File Offset: 0x000088C9
		public unsafe static ParameterizedThreadStart s_longRunningThreadWork
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolTaskScheduler.NativeFieldInfoPtr_s_longRunningThreadWork, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParameterizedThreadStart>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolTaskScheduler.NativeFieldInfoPtr_s_longRunningThreadWork, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C78 RID: 7288
		private static readonly IntPtr NativeFieldInfoPtr_s_longRunningThreadWork;

		// Token: 0x04001C79 RID: 7289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001C7A RID: 7290
		private static readonly IntPtr NativeMethodInfoPtr_QueueTask_FamOrAssem_Virtual_Void_Task_0;

		// Token: 0x04001C7B RID: 7291
		private static readonly IntPtr NativeMethodInfoPtr_TryExecuteTaskInline_Protected_Virtual_Boolean_Task_Boolean_0;

		// Token: 0x04001C7C RID: 7292
		private static readonly IntPtr NativeMethodInfoPtr_TryDequeue_FamOrAssem_Virtual_Boolean_Task_0;

		// Token: 0x04001C7D RID: 7293
		private static readonly IntPtr NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Virtual_Void_0;

		// Token: 0x04001C7E RID: 7294
		private static readonly IntPtr NativeMethodInfoPtr_get_RequiresAtomicStartTransition_Internal_Virtual_get_Boolean_0;

		// Token: 0x0200064A RID: 1610
		[ObfuscatedName("System.Threading.Tasks.ThreadPoolTaskScheduler+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005999 RID: 22937 RVA: 0x0019A76C File Offset: 0x0019896C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ThreadPoolTaskScheduler.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPoolTaskScheduler.__c>.NativeClassPtr);
				ThreadPoolTaskScheduler.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolTaskScheduler.__c>.NativeClassPtr, "<>9");
				ThreadPoolTaskScheduler.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolTaskScheduler.__c>.NativeClassPtr, 100668742);
				ThreadPoolTaskScheduler.__c.NativeMethodInfoPtr___cctor_b__10_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolTaskScheduler.__c>.NativeClassPtr, 100668743);
			}

			// Token: 0x0600599A RID: 22938 RVA: 0x0019A7D4 File Offset: 0x001989D4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadPoolTaskScheduler.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolTaskScheduler.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600599B RID: 22939 RVA: 0x0019A810 File Offset: 0x00198A10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361976, XrefRangeEnd = 1361981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__10_0(Object s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolTaskScheduler.__c.NativeMethodInfoPtr___cctor_b__10_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600599C RID: 22940 RVA: 0x00020116 File Offset: 0x0001E316
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016D5 RID: 5845
			// (get) Token: 0x0600599D RID: 22941 RVA: 0x0019A854 File Offset: 0x00198A54
			// (set) Token: 0x0600599E RID: 22942 RVA: 0x0002011F File Offset: 0x0001E31F
			public unsafe static ThreadPoolTaskScheduler.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ThreadPoolTaskScheduler.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolTaskScheduler.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ThreadPoolTaskScheduler.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400496E RID: 18798
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400496F RID: 18799
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004970 RID: 18800
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__10_0_Internal_Void_Object_0;
		}
	}
}

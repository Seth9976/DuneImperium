using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001CD RID: 461
	public sealed class ForceAsyncAwaiter : ValueType, INotifyCompletion
	{
		// Token: 0x06001E29 RID: 7721 RVA: 0x000AF438 File Offset: 0x000AD638
		// Note: this type is marked as 'beforefieldinit'.
		static ForceAsyncAwaiter()
		{
			Il2CppClassPointerStore<ForceAsyncAwaiter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "ForceAsyncAwaiter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForceAsyncAwaiter>.NativeClassPtr);
			ForceAsyncAwaiter.NativeFieldInfoPtr__task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceAsyncAwaiter>.NativeClassPtr, "_task");
			ForceAsyncAwaiter.NativeMethodInfoPtr__ctor_Internal_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceAsyncAwaiter>.NativeClassPtr, 100668426);
			ForceAsyncAwaiter.NativeMethodInfoPtr_GetAwaiter_Public_ForceAsyncAwaiter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceAsyncAwaiter>.NativeClassPtr, 100668427);
			ForceAsyncAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceAsyncAwaiter>.NativeClassPtr, 100668428);
			ForceAsyncAwaiter.NativeMethodInfoPtr_GetResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceAsyncAwaiter>.NativeClassPtr, 100668429);
			ForceAsyncAwaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceAsyncAwaiter>.NativeClassPtr, 100668430);
			ForceAsyncAwaiter.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceAsyncAwaiter>.NativeClassPtr, 100668431);
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x000AF4F4 File Offset: 0x000AD6F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForceAsyncAwaiter(Task task)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForceAsyncAwaiter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceAsyncAwaiter.NativeMethodInfoPtr__ctor_Internal_Void_Task_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x000AF544 File Offset: 0x000AD744
		[CallerCount(99)]
		[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForceAsyncAwaiter GetAwaiter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceAsyncAwaiter.NativeMethodInfoPtr_GetAwaiter_Public_ForceAsyncAwaiter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ForceAsyncAwaiter(intPtr);
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x000AF580 File Offset: 0x000AD780
		public unsafe bool IsCompleted
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceAsyncAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x000AF5C4 File Offset: 0x000AD7C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1358198, RefRangeEnd = 1358200, XrefRangeStart = 1358196, XrefRangeEnd = 1358198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceAsyncAwaiter.NativeMethodInfoPtr_GetResult_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x000AF5FC File Offset: 0x000AD7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358200, XrefRangeEnd = 1358202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCompleted(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceAsyncAwaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x000AF644 File Offset: 0x000AD844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358202, XrefRangeEnd = 1358204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnsafeOnCompleted(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceAsyncAwaiter.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x00009E13 File Offset: 0x00008013
		public ForceAsyncAwaiter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x00009E1C File Offset: 0x0000801C
		public ForceAsyncAwaiter()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForceAsyncAwaiter>.NativeClassPtr))
		{
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001E32 RID: 7730 RVA: 0x000AF68C File Offset: 0x000AD88C
		// (set) Token: 0x06001E33 RID: 7731 RVA: 0x00009E2E File Offset: 0x0000802E
		public unsafe Task _task
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceAsyncAwaiter.NativeFieldInfoPtr__task);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceAsyncAwaiter.NativeFieldInfoPtr__task), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x00009E4D File Offset: 0x0000804D
		public void OnCompleted(Action continuation)
		{
			this.OnCompleted(continuation);
		}

		// Token: 0x04001AF2 RID: 6898
		private static readonly IntPtr NativeFieldInfoPtr__task;

		// Token: 0x04001AF3 RID: 6899
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_0;

		// Token: 0x04001AF4 RID: 6900
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_ForceAsyncAwaiter_0;

		// Token: 0x04001AF5 RID: 6901
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

		// Token: 0x04001AF6 RID: 6902
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_Void_0;

		// Token: 0x04001AF7 RID: 6903
		private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04001AF8 RID: 6904
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0;
	}
}

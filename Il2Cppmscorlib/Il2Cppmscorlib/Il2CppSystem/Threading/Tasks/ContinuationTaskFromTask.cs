using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001DD RID: 477
	public sealed class ContinuationTaskFromTask : Task
	{
		// Token: 0x06001F74 RID: 8052 RVA: 0x000B53A4 File Offset: 0x000B35A4
		// Note: this type is marked as 'beforefieldinit'.
		static ContinuationTaskFromTask()
		{
			Il2CppClassPointerStore<ContinuationTaskFromTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "ContinuationTaskFromTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinuationTaskFromTask>.NativeClassPtr);
			ContinuationTaskFromTask.NativeFieldInfoPtr_m_antecedent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinuationTaskFromTask>.NativeClassPtr, "m_antecedent");
			ContinuationTaskFromTask.NativeMethodInfoPtr__ctor_Public_Void_Task_Delegate_Object_TaskCreationOptions_InternalTaskOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinuationTaskFromTask>.NativeClassPtr, 100668654);
			ContinuationTaskFromTask.NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinuationTaskFromTask>.NativeClassPtr, 100668655);
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x000B5410 File Offset: 0x000B3610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361261, XrefRangeEnd = 1361275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContinuationTaskFromTask(Task antecedent, Delegate action, Object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinuationTaskFromTask>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(antecedent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinuationTaskFromTask.NativeMethodInfoPtr__ctor_Public_Void_Task_Delegate_Object_TaskCreationOptions_InternalTaskOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x000B549C File Offset: 0x000B369C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361275, XrefRangeEnd = 1361284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InnerInvoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinuationTaskFromTask.NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x0000A338 File Offset: 0x00008538
		public ContinuationTaskFromTask(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001F78 RID: 8056 RVA: 0x000B54D0 File Offset: 0x000B36D0
		// (set) Token: 0x06001F79 RID: 8057 RVA: 0x0000A341 File Offset: 0x00008541
		public unsafe Task m_antecedent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinuationTaskFromTask.NativeFieldInfoPtr_m_antecedent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinuationTaskFromTask.NativeFieldInfoPtr_m_antecedent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C16 RID: 7190
		private static readonly IntPtr NativeFieldInfoPtr_m_antecedent;

		// Token: 0x04001C17 RID: 7191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Task_Delegate_Object_TaskCreationOptions_InternalTaskOptions_0;

		// Token: 0x04001C18 RID: 7192
		private static readonly IntPtr NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0;
	}
}

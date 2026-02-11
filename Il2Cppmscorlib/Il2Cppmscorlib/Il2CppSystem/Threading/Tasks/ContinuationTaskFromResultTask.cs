using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001DE RID: 478
	public sealed class ContinuationTaskFromResultTask<TAntecedentResult> : Task
	{
		// Token: 0x06001F7A RID: 8058 RVA: 0x000B5500 File Offset: 0x000B3700
		// Note: this type is marked as 'beforefieldinit'.
		static ContinuationTaskFromResultTask()
		{
			Il2CppClassPointerStore<ContinuationTaskFromResultTask<TAntecedentResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "ContinuationTaskFromResultTask`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAntecedentResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinuationTaskFromResultTask<TAntecedentResult>>.NativeClassPtr);
			ContinuationTaskFromResultTask<TAntecedentResult>.NativeFieldInfoPtr_m_antecedent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinuationTaskFromResultTask<TAntecedentResult>>.NativeClassPtr, "m_antecedent");
			ContinuationTaskFromResultTask<TAntecedentResult>.NativeMethodInfoPtr__ctor_Public_Void_Task_1_TAntecedentResult_Delegate_Object_TaskCreationOptions_InternalTaskOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinuationTaskFromResultTask<TAntecedentResult>>.NativeClassPtr, 100668656);
			ContinuationTaskFromResultTask<TAntecedentResult>.NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinuationTaskFromResultTask<TAntecedentResult>>.NativeClassPtr, 100668657);
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x000B55A8 File Offset: 0x000B37A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1361290, RefRangeEnd = 1361292, XrefRangeStart = 1361284, XrefRangeEnd = 1361290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContinuationTaskFromResultTask(Task<TAntecedentResult> antecedent, Delegate action, Object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinuationTaskFromResultTask<TAntecedentResult>>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinuationTaskFromResultTask<TAntecedentResult>.NativeMethodInfoPtr__ctor_Public_Void_Task_1_TAntecedentResult_Delegate_Object_TaskCreationOptions_InternalTaskOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x000B5634 File Offset: 0x000B3834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361292, XrefRangeEnd = 1361298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InnerInvoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinuationTaskFromResultTask<TAntecedentResult>.NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x0000A360 File Offset: 0x00008560
		public ContinuationTaskFromResultTask(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001F7E RID: 8062 RVA: 0x000B5668 File Offset: 0x000B3868
		// (set) Token: 0x06001F7F RID: 8063 RVA: 0x0000A369 File Offset: 0x00008569
		public unsafe Task<TAntecedentResult> m_antecedent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinuationTaskFromResultTask<TAntecedentResult>.NativeFieldInfoPtr_m_antecedent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TAntecedentResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinuationTaskFromResultTask<TAntecedentResult>.NativeFieldInfoPtr_m_antecedent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C19 RID: 7193
		private static readonly IntPtr NativeFieldInfoPtr_m_antecedent;

		// Token: 0x04001C1A RID: 7194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Task_1_TAntecedentResult_Delegate_Object_TaskCreationOptions_InternalTaskOptions_0;

		// Token: 0x04001C1B RID: 7195
		private static readonly IntPtr NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001DF RID: 479
	public sealed class ContinuationResultTaskFromResultTask<TAntecedentResult, TResult> : Task<TResult>
	{
		// Token: 0x06001F80 RID: 8064 RVA: 0x000B5698 File Offset: 0x000B3898
		// Note: this type is marked as 'beforefieldinit'.
		static ContinuationResultTaskFromResultTask()
		{
			Il2CppClassPointerStore<ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "ContinuationResultTaskFromResultTask`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAntecedentResult>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>>.NativeClassPtr);
			ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>.NativeFieldInfoPtr_m_antecedent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>>.NativeClassPtr, "m_antecedent");
			ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Task_1_TAntecedentResult_Delegate_Object_TaskCreationOptions_InternalTaskOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>>.NativeClassPtr, 100668658);
			ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>.NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>>.NativeClassPtr, 100668659);
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x000B5754 File Offset: 0x000B3954
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1361310, RefRangeEnd = 1361312, XrefRangeStart = 1361298, XrefRangeEnd = 1361310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContinuationResultTaskFromResultTask(Task<TAntecedentResult> antecedent, Delegate function, Object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(antecedent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(function);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Task_1_TAntecedentResult_Delegate_Object_TaskCreationOptions_InternalTaskOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x000B57E0 File Offset: 0x000B39E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361312, XrefRangeEnd = 1361318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InnerInvoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>.NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x0000A388 File Offset: 0x00008588
		public ContinuationResultTaskFromResultTask(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001F84 RID: 8068 RVA: 0x000B5814 File Offset: 0x000B3A14
		// (set) Token: 0x06001F85 RID: 8069 RVA: 0x0000A391 File Offset: 0x00008591
		public unsafe Task<TAntecedentResult> m_antecedent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>.NativeFieldInfoPtr_m_antecedent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TAntecedentResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinuationResultTaskFromResultTask<TAntecedentResult, TResult>.NativeFieldInfoPtr_m_antecedent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C1C RID: 7196
		private static readonly IntPtr NativeFieldInfoPtr_m_antecedent;

		// Token: 0x04001C1D RID: 7197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Task_1_TAntecedentResult_Delegate_Object_TaskCreationOptions_InternalTaskOptions_0;

		// Token: 0x04001C1E RID: 7198
		private static readonly IntPtr NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0;
	}
}

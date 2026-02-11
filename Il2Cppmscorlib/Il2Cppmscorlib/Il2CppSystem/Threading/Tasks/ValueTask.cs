using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks.Sources;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001CA RID: 458
	public sealed class ValueTask : ValueType
	{
		// Token: 0x06001DF1 RID: 7665 RVA: 0x000AE520 File Offset: 0x000AC720
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTask()
		{
			Il2CppClassPointerStore<ValueTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "ValueTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTask>.NativeClassPtr);
			ValueTask.NativeFieldInfoPtr_s_canceledTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, "s_canceledTask");
			ValueTask.NativeFieldInfoPtr__obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, "_obj");
			ValueTask.NativeFieldInfoPtr__token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, "_token");
			ValueTask.NativeFieldInfoPtr__continueOnCapturedContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, "_continueOnCapturedContext");
			ValueTask.NativeMethodInfoPtr_get_CompletedTask_Internal_Static_get_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, 100668385);
			ValueTask.NativeMethodInfoPtr__ctor_Public_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, 100668386);
			ValueTask.NativeMethodInfoPtr__ctor_Public_Void_IValueTaskSource_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, 100668387);
			ValueTask.NativeMethodInfoPtr__ctor_Private_Void_Object_Int16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, 100668388);
			ValueTask.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, 100668389);
			ValueTask.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, 100668390);
			ValueTask.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, 100668391);
			ValueTask.NativeMethodInfoPtr_AsTask_Public_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, 100668392);
			ValueTask.NativeMethodInfoPtr_GetTaskForValueTaskSource_Private_Task_IValueTaskSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, 100668393);
			ValueTask.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, 100668394);
			ValueTask.NativeMethodInfoPtr_get_IsCompletedSuccessfully_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, 100668395);
			ValueTask.NativeMethodInfoPtr_ThrowIfCompletedUnsuccessfully_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, 100668396);
			ValueTask.NativeMethodInfoPtr_GetAwaiter_Public_ValueTaskAwaiter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, 100668397);
			ValueTask.NativeMethodInfoPtr_ConfigureAwait_Public_ConfiguredValueTaskAwaitable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, 100668398);
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x000AE6B8 File Offset: 0x000AC8B8
		public unsafe static Task CompletedTask
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1358051, RefRangeEnd = 1358052, XrefRangeStart = 1358043, XrefRangeEnd = 1358051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask.NativeMethodInfoPtr_get_CompletedTask_Internal_Static_get_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x000AE6EC File Offset: 0x000AC8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358052, XrefRangeEnd = 1358054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTask(Task task)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTask>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask.NativeMethodInfoPtr__ctor_Public_Void_Task_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x000AE73C File Offset: 0x000AC93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358054, XrefRangeEnd = 1358056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTask(IValueTaskSource source, short token)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTask>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref token;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask.NativeMethodInfoPtr__ctor_Public_Void_IValueTaskSource_Int16_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x000AE79C File Offset: 0x000AC99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358056, XrefRangeEnd = 1358057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTask(Object obj, short token, bool continueOnCapturedContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTask>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref token;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continueOnCapturedContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask.NativeMethodInfoPtr__ctor_Private_Void_Object_Int16_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x000AE808 File Offset: 0x000ACA08
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x000AE84C File Offset: 0x000ACA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358057, XrefRangeEnd = 1358062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x000AE8A0 File Offset: 0x000ACAA0
		[CallerCount(0)]
		public unsafe bool Equals(ValueTask other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTask_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x000AE8F8 File Offset: 0x000ACAF8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1358068, RefRangeEnd = 1358072, XrefRangeStart = 1358062, XrefRangeEnd = 1358068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task AsTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask.NativeMethodInfoPtr_AsTask_Public_Task_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x000AE93C File Offset: 0x000ACB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358072, XrefRangeEnd = 1358090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task GetTaskForValueTaskSource(IValueTaskSource t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask.NativeMethodInfoPtr_GetTaskForValueTaskSource_Private_Task_IValueTaskSource_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001DFB RID: 7675 RVA: 0x000AE994 File Offset: 0x000ACB94
		public unsafe bool IsCompleted
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358090, XrefRangeEnd = 1358097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001DFC RID: 7676 RVA: 0x000AE9D8 File Offset: 0x000ACBD8
		public unsafe bool IsCompletedSuccessfully
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358097, XrefRangeEnd = 1358101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask.NativeMethodInfoPtr_get_IsCompletedSuccessfully_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x000AEA1C File Offset: 0x000ACC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358101, XrefRangeEnd = 1358107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfCompletedUnsuccessfully()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask.NativeMethodInfoPtr_ThrowIfCompletedUnsuccessfully_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x000AEA54 File Offset: 0x000ACC54
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1358108, RefRangeEnd = 1358113, XrefRangeStart = 1358107, XrefRangeEnd = 1358108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTaskAwaiter GetAwaiter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask.NativeMethodInfoPtr_GetAwaiter_Public_ValueTaskAwaiter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTaskAwaiter(intPtr);
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x000AEA90 File Offset: 0x000ACC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358113, XrefRangeEnd = 1358115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfiguredValueTaskAwaitable ConfigureAwait(bool continueOnCapturedContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref continueOnCapturedContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask.NativeMethodInfoPtr_ConfigureAwait_Public_ConfiguredValueTaskAwaitable_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ConfiguredValueTaskAwaitable(intPtr);
			}
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x00009CCD File Offset: 0x00007ECD
		public ValueTask(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x00009CD6 File Offset: 0x00007ED6
		public ValueTask()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTask>.NativeClassPtr))
		{
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001E02 RID: 7682 RVA: 0x000AEADC File Offset: 0x000ACCDC
		// (set) Token: 0x06001E03 RID: 7683 RVA: 0x00009CE8 File Offset: 0x00007EE8
		public unsafe static Task s_canceledTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ValueTask.NativeFieldInfoPtr_s_canceledTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValueTask.NativeFieldInfoPtr_s_canceledTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001E04 RID: 7684 RVA: 0x000AEB04 File Offset: 0x000ACD04
		// (set) Token: 0x06001E05 RID: 7685 RVA: 0x00009CFA File Offset: 0x00007EFA
		public unsafe Object _obj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTask.NativeFieldInfoPtr__obj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTask.NativeFieldInfoPtr__obj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x000AEB34 File Offset: 0x000ACD34
		// (set) Token: 0x06001E07 RID: 7687 RVA: 0x00009D19 File Offset: 0x00007F19
		public unsafe short _token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTask.NativeFieldInfoPtr__token);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTask.NativeFieldInfoPtr__token)) = value;
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001E08 RID: 7688 RVA: 0x000AEB5C File Offset: 0x000ACD5C
		// (set) Token: 0x06001E09 RID: 7689 RVA: 0x00009D34 File Offset: 0x00007F34
		public unsafe bool _continueOnCapturedContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTask.NativeFieldInfoPtr__continueOnCapturedContext);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTask.NativeFieldInfoPtr__continueOnCapturedContext)) = value;
			}
		}

		// Token: 0x04001ACB RID: 6859
		private static readonly IntPtr NativeFieldInfoPtr_s_canceledTask;

		// Token: 0x04001ACC RID: 6860
		private static readonly IntPtr NativeFieldInfoPtr__obj;

		// Token: 0x04001ACD RID: 6861
		private static readonly IntPtr NativeFieldInfoPtr__token;

		// Token: 0x04001ACE RID: 6862
		private static readonly IntPtr NativeFieldInfoPtr__continueOnCapturedContext;

		// Token: 0x04001ACF RID: 6863
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedTask_Internal_Static_get_Task_0;

		// Token: 0x04001AD0 RID: 6864
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Task_0;

		// Token: 0x04001AD1 RID: 6865
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IValueTaskSource_Int16_0;

		// Token: 0x04001AD2 RID: 6866
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Object_Int16_Boolean_0;

		// Token: 0x04001AD3 RID: 6867
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001AD4 RID: 6868
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001AD5 RID: 6869
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTask_0;

		// Token: 0x04001AD6 RID: 6870
		private static readonly IntPtr NativeMethodInfoPtr_AsTask_Public_Task_0;

		// Token: 0x04001AD7 RID: 6871
		private static readonly IntPtr NativeMethodInfoPtr_GetTaskForValueTaskSource_Private_Task_IValueTaskSource_0;

		// Token: 0x04001AD8 RID: 6872
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

		// Token: 0x04001AD9 RID: 6873
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompletedSuccessfully_Public_get_Boolean_0;

		// Token: 0x04001ADA RID: 6874
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfCompletedUnsuccessfully_Internal_Void_0;

		// Token: 0x04001ADB RID: 6875
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_ValueTaskAwaiter_0;

		// Token: 0x04001ADC RID: 6876
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureAwait_Public_ConfiguredValueTaskAwaitable_Boolean_0;

		// Token: 0x02000623 RID: 1571
		public sealed class ValueTaskSourceAsTask : Task<VoidTaskResult>
		{
			// Token: 0x060058F5 RID: 22773 RVA: 0x001984BC File Offset: 0x001966BC
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTaskSourceAsTask()
			{
				Il2CppClassPointerStore<ValueTask.ValueTaskSourceAsTask>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, "ValueTaskSourceAsTask");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTask.ValueTaskSourceAsTask>.NativeClassPtr);
				ValueTask.ValueTaskSourceAsTask.NativeFieldInfoPtr_s_completionAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTask.ValueTaskSourceAsTask>.NativeClassPtr, "s_completionAction");
				ValueTask.ValueTaskSourceAsTask.NativeFieldInfoPtr__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTask.ValueTaskSourceAsTask>.NativeClassPtr, "_source");
				ValueTask.ValueTaskSourceAsTask.NativeFieldInfoPtr__token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTask.ValueTaskSourceAsTask>.NativeClassPtr, "_token");
				ValueTask.ValueTaskSourceAsTask.NativeMethodInfoPtr__ctor_Public_Void_IValueTaskSource_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask.ValueTaskSourceAsTask>.NativeClassPtr, 100668400);
			}

			// Token: 0x060058F6 RID: 22774 RVA: 0x00198538 File Offset: 0x00196738
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358032, XrefRangeEnd = 1358043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTaskSourceAsTask(IValueTaskSource source, short token)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTask.ValueTaskSourceAsTask>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask.ValueTaskSourceAsTask.NativeMethodInfoPtr__ctor_Public_Void_IValueTaskSource_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058F7 RID: 22775 RVA: 0x0001FC66 File Offset: 0x0001DE66
			public ValueTaskSourceAsTask(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016AD RID: 5805
			// (get) Token: 0x060058F8 RID: 22776 RVA: 0x00198594 File Offset: 0x00196794
			// (set) Token: 0x060058F9 RID: 22777 RVA: 0x0001FC6F File Offset: 0x0001DE6F
			public unsafe static Action<Object> s_completionAction
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ValueTask.ValueTaskSourceAsTask.NativeFieldInfoPtr_s_completionAction, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ValueTask.ValueTaskSourceAsTask.NativeFieldInfoPtr_s_completionAction, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016AE RID: 5806
			// (get) Token: 0x060058FA RID: 22778 RVA: 0x001985BC File Offset: 0x001967BC
			// (set) Token: 0x060058FB RID: 22779 RVA: 0x0001FC81 File Offset: 0x0001DE81
			public unsafe IValueTaskSource _source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTask.ValueTaskSourceAsTask.NativeFieldInfoPtr__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IValueTaskSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTask.ValueTaskSourceAsTask.NativeFieldInfoPtr__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016AF RID: 5807
			// (get) Token: 0x060058FC RID: 22780 RVA: 0x001985EC File Offset: 0x001967EC
			// (set) Token: 0x060058FD RID: 22781 RVA: 0x0001FCA0 File Offset: 0x0001DEA0
			public unsafe short _token
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTask.ValueTaskSourceAsTask.NativeFieldInfoPtr__token);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTask.ValueTaskSourceAsTask.NativeFieldInfoPtr__token)) = value;
				}
			}

			// Token: 0x0400490E RID: 18702
			private static readonly IntPtr NativeFieldInfoPtr_s_completionAction;

			// Token: 0x0400490F RID: 18703
			private static readonly IntPtr NativeFieldInfoPtr__source;

			// Token: 0x04004910 RID: 18704
			private static readonly IntPtr NativeFieldInfoPtr__token;

			// Token: 0x04004911 RID: 18705
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IValueTaskSource_Int16_0;

			// Token: 0x0200078F RID: 1935
			[ObfuscatedName("System.Threading.Tasks.ValueTask+ValueTaskSourceAsTask+<>c")]
			[Serializable]
			public new sealed class __c : Object
			{
				// Token: 0x06006319 RID: 25369 RVA: 0x001BA078 File Offset: 0x001B8278
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<ValueTask.ValueTaskSourceAsTask.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValueTask.ValueTaskSourceAsTask>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTask.ValueTaskSourceAsTask.__c>.NativeClassPtr);
					ValueTask.ValueTaskSourceAsTask.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTask.ValueTaskSourceAsTask.__c>.NativeClassPtr, "<>9");
					ValueTask.ValueTaskSourceAsTask.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask.ValueTaskSourceAsTask.__c>.NativeClassPtr, 100668403);
					ValueTask.ValueTaskSourceAsTask.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask.ValueTaskSourceAsTask.__c>.NativeClassPtr, 100668404);
				}

				// Token: 0x0600631A RID: 25370 RVA: 0x001BA0E0 File Offset: 0x001B82E0
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTask.ValueTaskSourceAsTask.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask.ValueTaskSourceAsTask.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600631B RID: 25371 RVA: 0x001BA11C File Offset: 0x001B831C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358014, XrefRangeEnd = 1358032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void __cctor_b__4_0(Object state)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask.ValueTaskSourceAsTask.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600631C RID: 25372 RVA: 0x000251C1 File Offset: 0x000233C1
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17001996 RID: 6550
				// (get) Token: 0x0600631D RID: 25373 RVA: 0x001BA160 File Offset: 0x001B8360
				// (set) Token: 0x0600631E RID: 25374 RVA: 0x000251CA File Offset: 0x000233CA
				public unsafe static ValueTask.ValueTaskSourceAsTask.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(ValueTask.ValueTaskSourceAsTask.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueTask.ValueTaskSourceAsTask.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(ValueTask.ValueTaskSourceAsTask.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040050EF RID: 20719
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x040050F0 RID: 20720
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040050F1 RID: 20721
				private static readonly IntPtr NativeMethodInfoPtr___cctor_b__4_0_Internal_Void_Object_0;
			}
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks.Sources;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001CB RID: 459
	public sealed class ValueTask<TResult> : ValueType
	{
		// Token: 0x06001E0A RID: 7690 RVA: 0x000AEB84 File Offset: 0x000ACD84
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTask()
		{
			Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "ValueTask`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr);
			ValueTask<TResult>.NativeFieldInfoPtr_s_canceledTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, "s_canceledTask");
			ValueTask<TResult>.NativeFieldInfoPtr__obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, "_obj");
			ValueTask<TResult>.NativeFieldInfoPtr__result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, "_result");
			ValueTask<TResult>.NativeFieldInfoPtr__token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, "_token");
			ValueTask<TResult>.NativeFieldInfoPtr__continueOnCapturedContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, "_continueOnCapturedContext");
			ValueTask<TResult>.NativeMethodInfoPtr__ctor_Public_Void_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, 100668405);
			ValueTask<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Task_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, 100668406);
			ValueTask<TResult>.NativeMethodInfoPtr__ctor_Public_Void_IValueTaskSource_1_TResult_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, 100668407);
			ValueTask<TResult>.NativeMethodInfoPtr__ctor_Private_Void_Object_TResult_Int16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, 100668408);
			ValueTask<TResult>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, 100668409);
			ValueTask<TResult>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, 100668410);
			ValueTask<TResult>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTask_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, 100668411);
			ValueTask<TResult>.NativeMethodInfoPtr_AsTask_Public_Task_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, 100668412);
			ValueTask<TResult>.NativeMethodInfoPtr_GetTaskForValueTaskSource_Private_Task_1_TResult_IValueTaskSource_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, 100668413);
			ValueTask<TResult>.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, 100668414);
			ValueTask<TResult>.NativeMethodInfoPtr_get_IsCompletedSuccessfully_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, 100668415);
			ValueTask<TResult>.NativeMethodInfoPtr_get_Result_Public_get_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, 100668416);
			ValueTask<TResult>.NativeMethodInfoPtr_GetAwaiter_Public_ValueTaskAwaiter_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, 100668417);
			ValueTask<TResult>.NativeMethodInfoPtr_ConfigureAwait_Public_ConfiguredValueTaskAwaitable_1_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, 100668418);
			ValueTask<TResult>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, 100668419);
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x000AED80 File Offset: 0x000ACF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358136, XrefRangeEnd = 1358137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTask(TResult result)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TResult).IsValueType)
				{
					TResult tresult = result;
					intPtr = ((tresult is string) ? IL2CPP.ManagedStringToIl2Cpp(tresult as string) : IL2CPP.Il2CppObjectBaseToPtr(tresult as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref result;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ValueTask<TResult>.NativeMethodInfoPtr__ctor_Public_Void_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x000AEE08 File Offset: 0x000AD008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358137, XrefRangeEnd = 1358139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTask(Task<TResult> task)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Task_1_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x000AEE58 File Offset: 0x000AD058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358139, XrefRangeEnd = 1358141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTask(IValueTaskSource<TResult> source, short token)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref token;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask<TResult>.NativeMethodInfoPtr__ctor_Public_Void_IValueTaskSource_1_TResult_Int16_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x000AEEB8 File Offset: 0x000AD0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358141, XrefRangeEnd = 1358142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTask(Object obj, TResult result, short token, bool continueOnCapturedContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TResult).IsValueType)
			{
				TResult tresult = result;
				intPtr = ((tresult is string) ? IL2CPP.ManagedStringToIl2Cpp(tresult as string) : IL2CPP.Il2CppObjectBaseToPtr(tresult as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref result;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref token;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continueOnCapturedContext;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ValueTask<TResult>.NativeMethodInfoPtr__ctor_Private_Void_Object_TResult_Int16_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x000AEF6C File Offset: 0x000AD16C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask<TResult>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x000AEFB0 File Offset: 0x000AD1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358142, XrefRangeEnd = 1358149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask<TResult>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x000AF004 File Offset: 0x000AD204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358149, XrefRangeEnd = 1358151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ValueTask<TResult> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask<TResult>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTask_1_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x000AF05C File Offset: 0x000AD25C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1358153, RefRangeEnd = 1358156, XrefRangeStart = 1358151, XrefRangeEnd = 1358153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TResult> AsTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask<TResult>.NativeMethodInfoPtr_AsTask_Public_Task_1_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x000AF0A0 File Offset: 0x000AD2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358156, XrefRangeEnd = 1358170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TResult> GetTaskForValueTaskSource(IValueTaskSource<TResult> t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask<TResult>.NativeMethodInfoPtr_GetTaskForValueTaskSource_Private_Task_1_TResult_IValueTaskSource_1_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001E14 RID: 7700 RVA: 0x000AF0F8 File Offset: 0x000AD2F8
		public unsafe bool IsCompleted
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358170, XrefRangeEnd = 1358176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask<TResult>.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001E15 RID: 7701 RVA: 0x000AF13C File Offset: 0x000AD33C
		public unsafe bool IsCompletedSuccessfully
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358176, XrefRangeEnd = 1358182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask<TResult>.NativeMethodInfoPtr_get_IsCompletedSuccessfully_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001E16 RID: 7702 RVA: 0x000AF180 File Offset: 0x000AD380
		public unsafe TResult Result
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358182, XrefRangeEnd = 1358186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask<TResult>.NativeMethodInfoPtr_get_Result_Public_get_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x000AF1C0 File Offset: 0x000AD3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358186, XrefRangeEnd = 1358188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTaskAwaiter<TResult> GetAwaiter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask<TResult>.NativeMethodInfoPtr_GetAwaiter_Public_ValueTaskAwaiter_1_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTaskAwaiter<TResult>(intPtr);
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x000AF1FC File Offset: 0x000AD3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358188, XrefRangeEnd = 1358192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfiguredValueTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref continueOnCapturedContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask<TResult>.NativeMethodInfoPtr_ConfigureAwait_Public_ConfiguredValueTaskAwaitable_1_TResult_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ConfiguredValueTaskAwaitable<TResult>(intPtr);
			}
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x000AF248 File Offset: 0x000AD448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358192, XrefRangeEnd = 1358196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask<TResult>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x00009D4F File Offset: 0x00007F4F
		public ValueTask(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x00009D58 File Offset: 0x00007F58
		public ValueTask()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr))
		{
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001E1C RID: 7708 RVA: 0x000AF284 File Offset: 0x000AD484
		// (set) Token: 0x06001E1D RID: 7709 RVA: 0x00009D6A File Offset: 0x00007F6A
		public unsafe static Task<TResult> s_canceledTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ValueTask<TResult>.NativeFieldInfoPtr_s_canceledTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValueTask<TResult>.NativeFieldInfoPtr_s_canceledTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001E1E RID: 7710 RVA: 0x000AF2AC File Offset: 0x000AD4AC
		// (set) Token: 0x06001E1F RID: 7711 RVA: 0x00009D7C File Offset: 0x00007F7C
		public unsafe Object _obj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTask<TResult>.NativeFieldInfoPtr__obj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTask<TResult>.NativeFieldInfoPtr__obj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001E20 RID: 7712 RVA: 0x000AF2DC File Offset: 0x000AD4DC
		// (set) Token: 0x06001E21 RID: 7713 RVA: 0x000AF304 File Offset: 0x000AD504
		public unsafe TResult _result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTask<TResult>.NativeFieldInfoPtr__result);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTask<TResult>.NativeFieldInfoPtr__result);
				Type typeFromHandle = typeof(TResult);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001E22 RID: 7714 RVA: 0x000AF3AC File Offset: 0x000AD5AC
		// (set) Token: 0x06001E23 RID: 7715 RVA: 0x00009D9B File Offset: 0x00007F9B
		public unsafe short _token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTask<TResult>.NativeFieldInfoPtr__token);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTask<TResult>.NativeFieldInfoPtr__token)) = value;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001E24 RID: 7716 RVA: 0x000AF3D4 File Offset: 0x000AD5D4
		// (set) Token: 0x06001E25 RID: 7717 RVA: 0x00009DB6 File Offset: 0x00007FB6
		public unsafe bool _continueOnCapturedContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTask<TResult>.NativeFieldInfoPtr__continueOnCapturedContext);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTask<TResult>.NativeFieldInfoPtr__continueOnCapturedContext)) = value;
			}
		}

		// Token: 0x04001ADD RID: 6877
		private static readonly IntPtr NativeFieldInfoPtr_s_canceledTask;

		// Token: 0x04001ADE RID: 6878
		private static readonly IntPtr NativeFieldInfoPtr__obj;

		// Token: 0x04001ADF RID: 6879
		private static readonly IntPtr NativeFieldInfoPtr__result;

		// Token: 0x04001AE0 RID: 6880
		private static readonly IntPtr NativeFieldInfoPtr__token;

		// Token: 0x04001AE1 RID: 6881
		private static readonly IntPtr NativeFieldInfoPtr__continueOnCapturedContext;

		// Token: 0x04001AE2 RID: 6882
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TResult_0;

		// Token: 0x04001AE3 RID: 6883
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Task_1_TResult_0;

		// Token: 0x04001AE4 RID: 6884
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IValueTaskSource_1_TResult_Int16_0;

		// Token: 0x04001AE5 RID: 6885
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Object_TResult_Int16_Boolean_0;

		// Token: 0x04001AE6 RID: 6886
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001AE7 RID: 6887
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001AE8 RID: 6888
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTask_1_TResult_0;

		// Token: 0x04001AE9 RID: 6889
		private static readonly IntPtr NativeMethodInfoPtr_AsTask_Public_Task_1_TResult_0;

		// Token: 0x04001AEA RID: 6890
		private static readonly IntPtr NativeMethodInfoPtr_GetTaskForValueTaskSource_Private_Task_1_TResult_IValueTaskSource_1_TResult_0;

		// Token: 0x04001AEB RID: 6891
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

		// Token: 0x04001AEC RID: 6892
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompletedSuccessfully_Public_get_Boolean_0;

		// Token: 0x04001AED RID: 6893
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_TResult_0;

		// Token: 0x04001AEE RID: 6894
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_ValueTaskAwaiter_1_TResult_0;

		// Token: 0x04001AEF RID: 6895
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureAwait_Public_ConfiguredValueTaskAwaitable_1_TResult_Boolean_0;

		// Token: 0x04001AF0 RID: 6896
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x02000624 RID: 1572
		public sealed class ValueTaskSourceAsTask : Task<TResult>
		{
			// Token: 0x060058FE RID: 22782 RVA: 0x00198614 File Offset: 0x00196814
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTaskSourceAsTask()
			{
				Il2CppClassPointerStore<ValueTask<TResult>.ValueTaskSourceAsTask>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, "ValueTaskSourceAsTask"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTask<TResult>.ValueTaskSourceAsTask>.NativeClassPtr);
				ValueTask<TResult>.ValueTaskSourceAsTask.NativeFieldInfoPtr_s_completionAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTask<TResult>.ValueTaskSourceAsTask>.NativeClassPtr, "s_completionAction");
				ValueTask<TResult>.ValueTaskSourceAsTask.NativeFieldInfoPtr__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTask<TResult>.ValueTaskSourceAsTask>.NativeClassPtr, "_source");
				ValueTask<TResult>.ValueTaskSourceAsTask.NativeFieldInfoPtr__token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTask<TResult>.ValueTaskSourceAsTask>.NativeClassPtr, "_token");
				ValueTask<TResult>.ValueTaskSourceAsTask.NativeMethodInfoPtr__ctor_Public_Void_IValueTaskSource_1_TResult_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask<TResult>.ValueTaskSourceAsTask>.NativeClassPtr, 100668420);
			}

			// Token: 0x060058FF RID: 22783 RVA: 0x001986CC File Offset: 0x001968CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358129, XrefRangeEnd = 1358136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTaskSourceAsTask(IValueTaskSource<TResult> source, short token)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTask<TResult>.ValueTaskSourceAsTask>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask<TResult>.ValueTaskSourceAsTask.NativeMethodInfoPtr__ctor_Public_Void_IValueTaskSource_1_TResult_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005900 RID: 22784 RVA: 0x0001FCBB File Offset: 0x0001DEBB
			public ValueTaskSourceAsTask(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016B0 RID: 5808
			// (get) Token: 0x06005901 RID: 22785 RVA: 0x00198728 File Offset: 0x00196928
			// (set) Token: 0x06005902 RID: 22786 RVA: 0x0001FCC4 File Offset: 0x0001DEC4
			public unsafe static Action<Object> s_completionAction
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ValueTask<TResult>.ValueTaskSourceAsTask.NativeFieldInfoPtr_s_completionAction, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ValueTask<TResult>.ValueTaskSourceAsTask.NativeFieldInfoPtr_s_completionAction, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016B1 RID: 5809
			// (get) Token: 0x06005903 RID: 22787 RVA: 0x00198750 File Offset: 0x00196950
			// (set) Token: 0x06005904 RID: 22788 RVA: 0x0001FCD6 File Offset: 0x0001DED6
			public unsafe IValueTaskSource<TResult> _source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTask<TResult>.ValueTaskSourceAsTask.NativeFieldInfoPtr__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IValueTaskSource<TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTask<TResult>.ValueTaskSourceAsTask.NativeFieldInfoPtr__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016B2 RID: 5810
			// (get) Token: 0x06005905 RID: 22789 RVA: 0x00198780 File Offset: 0x00196980
			// (set) Token: 0x06005906 RID: 22790 RVA: 0x0001FCF5 File Offset: 0x0001DEF5
			public unsafe short _token
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTask<TResult>.ValueTaskSourceAsTask.NativeFieldInfoPtr__token);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTask<TResult>.ValueTaskSourceAsTask.NativeFieldInfoPtr__token)) = value;
				}
			}

			// Token: 0x04004912 RID: 18706
			private static readonly IntPtr NativeFieldInfoPtr_s_completionAction;

			// Token: 0x04004913 RID: 18707
			private static readonly IntPtr NativeFieldInfoPtr__source;

			// Token: 0x04004914 RID: 18708
			private static readonly IntPtr NativeFieldInfoPtr__token;

			// Token: 0x04004915 RID: 18709
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IValueTaskSource_1_TResult_Int16_0;

			// Token: 0x02000790 RID: 1936
			[ObfuscatedName("System.Threading.Tasks.ValueTask`1+ValueTaskSourceAsTask+<>c")]
			[Serializable]
			public new sealed class __c : Object
			{
				// Token: 0x0600631F RID: 25375 RVA: 0x001BA188 File Offset: 0x001B8388
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<ValueTask<TResult>.ValueTaskSourceAsTask.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValueTask<TResult>.ValueTaskSourceAsTask>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTask<TResult>.ValueTaskSourceAsTask.__c>.NativeClassPtr);
					ValueTask<TResult>.ValueTaskSourceAsTask.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTask<TResult>.ValueTaskSourceAsTask.__c>.NativeClassPtr, "<>9");
					ValueTask<TResult>.ValueTaskSourceAsTask.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask<TResult>.ValueTaskSourceAsTask.__c>.NativeClassPtr, 100668423);
					ValueTask<TResult>.ValueTaskSourceAsTask.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTask<TResult>.ValueTaskSourceAsTask.__c>.NativeClassPtr, 100668424);
				}

				// Token: 0x06006320 RID: 25376 RVA: 0x001BA22C File Offset: 0x001B842C
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTask<TResult>.ValueTaskSourceAsTask.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask<TResult>.ValueTaskSourceAsTask.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06006321 RID: 25377 RVA: 0x001BA268 File Offset: 0x001B8468
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1358115, XrefRangeEnd = 1358129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void __cctor_b__4_0(Object state)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTask<TResult>.ValueTaskSourceAsTask.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06006322 RID: 25378 RVA: 0x000251DC File Offset: 0x000233DC
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17001997 RID: 6551
				// (get) Token: 0x06006323 RID: 25379 RVA: 0x001BA2AC File Offset: 0x001B84AC
				// (set) Token: 0x06006324 RID: 25380 RVA: 0x000251E5 File Offset: 0x000233E5
				public unsafe static ValueTask<TResult>.ValueTaskSourceAsTask.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(ValueTask<TResult>.ValueTaskSourceAsTask.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueTask<TResult>.ValueTaskSourceAsTask.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(ValueTask<TResult>.ValueTaskSourceAsTask.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040050F2 RID: 20722
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x040050F3 RID: 20723
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040050F4 RID: 20724
				private static readonly IntPtr NativeMethodInfoPtr___cctor_b__4_0_Internal_Void_Object_0;
			}
		}
	}
}

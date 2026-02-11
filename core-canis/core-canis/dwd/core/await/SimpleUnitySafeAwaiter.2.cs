using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.await
{
	// Token: 0x02000208 RID: 520
	public class SimpleUnitySafeAwaiter<T> : Object
	{
		// Token: 0x06001CB3 RID: 7347 RVA: 0x0008555C File Offset: 0x0008375C
		// Note: this type is marked as 'beforefieldinit'.
		static SimpleUnitySafeAwaiter()
		{
			Il2CppClassPointerStore<SimpleUnitySafeAwaiter<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.await", "SimpleUnitySafeAwaiter`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleUnitySafeAwaiter<T>>.NativeClassPtr);
			SimpleUnitySafeAwaiter<T>.NativeFieldInfoPtr__IsCompleted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleUnitySafeAwaiter<T>>.NativeClassPtr, "<IsCompleted>k__BackingField");
			SimpleUnitySafeAwaiter<T>.NativeFieldInfoPtr_exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleUnitySafeAwaiter<T>>.NativeClassPtr, "exception");
			SimpleUnitySafeAwaiter<T>.NativeFieldInfoPtr__continuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleUnitySafeAwaiter<T>>.NativeClassPtr, "_continuation");
			SimpleUnitySafeAwaiter<T>.NativeFieldInfoPtr__result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleUnitySafeAwaiter<T>>.NativeClassPtr, "_result");
			SimpleUnitySafeAwaiter<T>.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleUnitySafeAwaiter<T>>.NativeClassPtr, 100667918);
			SimpleUnitySafeAwaiter<T>.NativeMethodInfoPtr_set_IsCompleted_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleUnitySafeAwaiter<T>>.NativeClassPtr, 100667919);
			SimpleUnitySafeAwaiter<T>.NativeMethodInfoPtr_GetResult_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleUnitySafeAwaiter<T>>.NativeClassPtr, 100667920);
			SimpleUnitySafeAwaiter<T>.NativeMethodInfoPtr_Complete_Public_Void_T_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleUnitySafeAwaiter<T>>.NativeClassPtr, 100667921);
			SimpleUnitySafeAwaiter<T>.NativeMethodInfoPtr_System_Runtime_CompilerServices_INotifyCompletion_OnCompleted_Private_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleUnitySafeAwaiter<T>>.NativeClassPtr, 100667922);
			SimpleUnitySafeAwaiter<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleUnitySafeAwaiter<T>>.NativeClassPtr, 100667923);
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x00085690 File Offset: 0x00083890
		// (set) Token: 0x06001CB5 RID: 7349 RVA: 0x000856CC File Offset: 0x000838CC
		public unsafe bool IsCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleUnitySafeAwaiter<T>.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleUnitySafeAwaiter<T>.NativeMethodInfoPtr_set_IsCompleted_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x0008570C File Offset: 0x0008390C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 885918, RefRangeEnd = 885925, XrefRangeStart = 885918, XrefRangeEnd = 885918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleUnitySafeAwaiter<T>.NativeMethodInfoPtr_GetResult_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x00085748 File Offset: 0x00083948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885925, XrefRangeEnd = 885928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(T result, Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = result;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref result;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SimpleUnitySafeAwaiter<T>.NativeMethodInfoPtr_Complete_Public_Void_T_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x000857D4 File Offset: 0x000839D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_CompilerServices_INotifyCompletion_OnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleUnitySafeAwaiter<T>.NativeMethodInfoPtr_System_Runtime_CompilerServices_INotifyCompletion_OnCompleted_Private_Virtual_Final_New_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x00085818 File Offset: 0x00083A18
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleUnitySafeAwaiter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleUnitySafeAwaiter<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleUnitySafeAwaiter<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x0000C4C9 File Offset: 0x0000A6C9
		public SimpleUnitySafeAwaiter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06001CBB RID: 7355 RVA: 0x00085854 File Offset: 0x00083A54
		// (set) Token: 0x06001CBC RID: 7356 RVA: 0x0000C4D2 File Offset: 0x0000A6D2
		public unsafe bool _IsCompleted_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleUnitySafeAwaiter<T>.NativeFieldInfoPtr__IsCompleted_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleUnitySafeAwaiter<T>.NativeFieldInfoPtr__IsCompleted_k__BackingField)) = value;
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06001CBD RID: 7357 RVA: 0x0008587C File Offset: 0x00083A7C
		// (set) Token: 0x06001CBE RID: 7358 RVA: 0x0000C4ED File Offset: 0x0000A6ED
		public unsafe Exception exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleUnitySafeAwaiter<T>.NativeFieldInfoPtr_exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleUnitySafeAwaiter<T>.NativeFieldInfoPtr_exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06001CBF RID: 7359 RVA: 0x000858AC File Offset: 0x00083AAC
		// (set) Token: 0x06001CC0 RID: 7360 RVA: 0x0000C50C File Offset: 0x0000A70C
		public unsafe Action _continuation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleUnitySafeAwaiter<T>.NativeFieldInfoPtr__continuation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleUnitySafeAwaiter<T>.NativeFieldInfoPtr__continuation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x000858DC File Offset: 0x00083ADC
		// (set) Token: 0x06001CC2 RID: 7362 RVA: 0x00085904 File Offset: 0x00083B04
		public unsafe T _result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleUnitySafeAwaiter<T>.NativeFieldInfoPtr__result);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleUnitySafeAwaiter<T>.NativeFieldInfoPtr__result);
				Type typeFromHandle = typeof(T);
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

		// Token: 0x04001420 RID: 5152
		private static readonly IntPtr NativeFieldInfoPtr__IsCompleted_k__BackingField;

		// Token: 0x04001421 RID: 5153
		private static readonly IntPtr NativeFieldInfoPtr_exception;

		// Token: 0x04001422 RID: 5154
		private static readonly IntPtr NativeFieldInfoPtr__continuation;

		// Token: 0x04001423 RID: 5155
		private static readonly IntPtr NativeFieldInfoPtr__result;

		// Token: 0x04001424 RID: 5156
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

		// Token: 0x04001425 RID: 5157
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCompleted_Private_set_Void_Boolean_0;

		// Token: 0x04001426 RID: 5158
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_T_0;

		// Token: 0x04001427 RID: 5159
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_T_Exception_0;

		// Token: 0x04001428 RID: 5160
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_CompilerServices_INotifyCompletion_OnCompleted_Private_Virtual_Final_New_Void_Action_0;

		// Token: 0x04001429 RID: 5161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

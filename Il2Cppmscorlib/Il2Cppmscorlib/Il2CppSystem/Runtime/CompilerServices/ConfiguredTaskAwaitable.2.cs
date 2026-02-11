using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003CD RID: 973
	public sealed class ConfiguredTaskAwaitable<TResult> : ValueType
	{
		// Token: 0x06003996 RID: 14742 RVA: 0x00116688 File Offset: 0x00114888
		// Note: this type is marked as 'beforefieldinit'.
		static ConfiguredTaskAwaitable()
		{
			Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "ConfiguredTaskAwaitable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>>.NativeClassPtr);
			ConfiguredTaskAwaitable<TResult>.NativeFieldInfoPtr_m_configuredTaskAwaiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>>.NativeClassPtr, "m_configuredTaskAwaiter");
			ConfiguredTaskAwaitable<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Task_1_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>>.NativeClassPtr, 100671886);
			ConfiguredTaskAwaitable<TResult>.NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredTaskAwaiter_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>>.NativeClassPtr, 100671887);
		}

		// Token: 0x06003997 RID: 14743 RVA: 0x00116730 File Offset: 0x00114930
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1394121, RefRangeEnd = 1394122, XrefRangeStart = 1394118, XrefRangeEnd = 1394121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfiguredTaskAwaitable(Task<TResult> task, bool continueOnCapturedContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continueOnCapturedContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Task_1_TResult_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003998 RID: 14744 RVA: 0x00116790 File Offset: 0x00114990
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 599686, RefRangeEnd = 599697, XrefRangeStart = 599686, XrefRangeEnd = 599697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter GetAwaiter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable<TResult>.NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredTaskAwaiter_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter(intPtr);
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x000155B3 File Offset: 0x000137B3
		public ConfiguredTaskAwaitable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600399A RID: 14746 RVA: 0x000155BC File Offset: 0x000137BC
		public ConfiguredTaskAwaitable()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>>.NativeClassPtr))
		{
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x0600399B RID: 14747 RVA: 0x001167CC File Offset: 0x001149CC
		// (set) Token: 0x0600399C RID: 14748 RVA: 0x000155CE File Offset: 0x000137CE
		public ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter m_configuredTaskAwaiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable<TResult>.NativeFieldInfoPtr_m_configuredTaskAwaiter);
				return new ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable<TResult>.NativeFieldInfoPtr_m_configuredTaskAwaiter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04002EBF RID: 11967
		private static readonly IntPtr NativeFieldInfoPtr_m_configuredTaskAwaiter;

		// Token: 0x04002EC0 RID: 11968
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_1_TResult_Boolean_0;

		// Token: 0x04002EC1 RID: 11969
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredTaskAwaiter_TResult_0;

		// Token: 0x0200068F RID: 1679
		public sealed class ConfiguredTaskAwaiter : ValueType, INotifyCompletion
		{
			// Token: 0x06005BE0 RID: 23520 RVA: 0x001A1760 File Offset: 0x0019F960
			// Note: this type is marked as 'beforefieldinit'.
			static ConfiguredTaskAwaiter()
			{
				Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>>.NativeClassPtr, "ConfiguredTaskAwaiter"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr);
				ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr, "m_task");
				ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_continueOnCapturedContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr, "m_continueOnCapturedContext");
				ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeMethodInfoPtr__ctor_Internal_Void_Task_1_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr, 100671888);
				ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr, 100671889);
				ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr, 100671890);
				ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr, 100671891);
				ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeMethodInfoPtr_GetResult_Public_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr, 100671892);
			}

			// Token: 0x06005BE1 RID: 23521 RVA: 0x001A1854 File Offset: 0x0019FA54
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 906460, RefRangeEnd = 906466, XrefRangeStart = 906460, XrefRangeEnd = 906466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConfiguredTaskAwaiter(Task<TResult> task, bool continueOnCapturedContext)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continueOnCapturedContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeMethodInfoPtr__ctor_Internal_Void_Task_1_TResult_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001784 RID: 6020
			// (get) Token: 0x06005BE2 RID: 23522 RVA: 0x001A18B4 File Offset: 0x0019FAB4
			public unsafe bool IsCompleted
			{
				[CallerCount(604)]
				[CachedScanResults(RefRangeStart = 1393084, RefRangeEnd = 1393688, XrefRangeStart = 1393084, XrefRangeEnd = 1393688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005BE3 RID: 23523 RVA: 0x001A18F8 File Offset: 0x0019FAF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1394114, XrefRangeEnd = 1394115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnCompleted(Action continuation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005BE4 RID: 23524 RVA: 0x001A1940 File Offset: 0x0019FB40
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1394116, RefRangeEnd = 1394118, XrefRangeStart = 1394115, XrefRangeEnd = 1394116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UnsafeOnCompleted(Action continuation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005BE5 RID: 23525 RVA: 0x001A1988 File Offset: 0x0019FB88
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1394096, RefRangeEnd = 1394097, XrefRangeStart = 1394096, XrefRangeEnd = 1394097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TResult GetResult()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeMethodInfoPtr_GetResult_Public_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}

			// Token: 0x06005BE6 RID: 23526 RVA: 0x0002151A File Offset: 0x0001F71A
			public ConfiguredTaskAwaiter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005BE7 RID: 23527 RVA: 0x00021523 File Offset: 0x0001F723
			public ConfiguredTaskAwaiter()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter>.NativeClassPtr))
			{
			}

			// Token: 0x17001782 RID: 6018
			// (get) Token: 0x06005BE8 RID: 23528 RVA: 0x001A19C8 File Offset: 0x0019FBC8
			// (set) Token: 0x06005BE9 RID: 23529 RVA: 0x00021535 File Offset: 0x0001F735
			public unsafe Task<TResult> m_task
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_task);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_task), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001783 RID: 6019
			// (get) Token: 0x06005BEA RID: 23530 RVA: 0x001A19F8 File Offset: 0x0019FBF8
			// (set) Token: 0x06005BEB RID: 23531 RVA: 0x00021554 File Offset: 0x0001F754
			public unsafe bool m_continueOnCapturedContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_continueOnCapturedContext);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_continueOnCapturedContext)) = value;
				}
			}

			// Token: 0x06005BEC RID: 23532 RVA: 0x0002156F File Offset: 0x0001F76F
			public void OnCompleted(Action continuation)
			{
				this.OnCompleted(continuation);
			}

			// Token: 0x04004AC0 RID: 19136
			private static readonly IntPtr NativeFieldInfoPtr_m_task;

			// Token: 0x04004AC1 RID: 19137
			private static readonly IntPtr NativeFieldInfoPtr_m_continueOnCapturedContext;

			// Token: 0x04004AC2 RID: 19138
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_1_TResult_Boolean_0;

			// Token: 0x04004AC3 RID: 19139
			private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

			// Token: 0x04004AC4 RID: 19140
			private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0;

			// Token: 0x04004AC5 RID: 19141
			private static readonly IntPtr NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0;

			// Token: 0x04004AC6 RID: 19142
			private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_TResult_0;
		}
	}
}

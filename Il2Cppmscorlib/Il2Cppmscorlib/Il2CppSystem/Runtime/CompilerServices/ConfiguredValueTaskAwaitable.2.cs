using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003B0 RID: 944
	public sealed class ConfiguredValueTaskAwaitable<TResult> : ValueType
	{
		// Token: 0x060038F1 RID: 14577 RVA: 0x001148AC File Offset: 0x00112AAC
		// Note: this type is marked as 'beforefieldinit'.
		static ConfiguredValueTaskAwaitable()
		{
			Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "ConfiguredValueTaskAwaitable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<TResult>>.NativeClassPtr);
			ConfiguredValueTaskAwaitable<TResult>.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<TResult>>.NativeClassPtr, "_value");
			ConfiguredValueTaskAwaitable<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_ValueTask_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<TResult>>.NativeClassPtr, 100671800);
			ConfiguredValueTaskAwaitable<TResult>.NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredValueTaskAwaiter_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<TResult>>.NativeClassPtr, 100671801);
		}

		// Token: 0x060038F2 RID: 14578 RVA: 0x00114954 File Offset: 0x00112B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfiguredValueTaskAwaitable(ValueTask<TResult> value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<TResult>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredValueTaskAwaitable<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_ValueTask_1_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060038F3 RID: 14579 RVA: 0x001149AC File Offset: 0x00112BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter GetAwaiter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredValueTaskAwaitable<TResult>.NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredValueTaskAwaiter_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter(intPtr);
		}

		// Token: 0x060038F4 RID: 14580 RVA: 0x00014F73 File Offset: 0x00013173
		public ConfiguredValueTaskAwaitable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060038F5 RID: 14581 RVA: 0x00014F7C File Offset: 0x0001317C
		public ConfiguredValueTaskAwaitable()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<TResult>>.NativeClassPtr))
		{
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x060038F6 RID: 14582 RVA: 0x001149E8 File Offset: 0x00112BE8
		// (set) Token: 0x060038F7 RID: 14583 RVA: 0x00014F8E File Offset: 0x0001318E
		public ValueTask<TResult> _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredValueTaskAwaitable<TResult>.NativeFieldInfoPtr__value);
				return new ValueTask<TResult>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredValueTaskAwaitable<TResult>.NativeFieldInfoPtr__value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04002E6F RID: 11887
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x04002E70 RID: 11888
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ValueTask_1_TResult_0;

		// Token: 0x04002E71 RID: 11889
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredValueTaskAwaiter_TResult_0;

		// Token: 0x0200068A RID: 1674
		public sealed class ConfiguredValueTaskAwaiter : ValueType, INotifyCompletion
		{
			// Token: 0x06005BAE RID: 23470 RVA: 0x001A0D40 File Offset: 0x0019EF40
			// Note: this type is marked as 'beforefieldinit'.
			static ConfiguredValueTaskAwaiter()
			{
				Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<TResult>>.NativeClassPtr, "ConfiguredValueTaskAwaiter"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter>.NativeClassPtr);
				ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter>.NativeClassPtr, "_value");
				ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter.NativeMethodInfoPtr__ctor_Internal_Void_ValueTask_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter>.NativeClassPtr, 100671802);
				ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter>.NativeClassPtr, 100671803);
				ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter.NativeMethodInfoPtr_GetResult_Public_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter>.NativeClassPtr, 100671804);
				ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter>.NativeClassPtr, 100671805);
				ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter>.NativeClassPtr, 100671806);
			}

			// Token: 0x06005BAF RID: 23471 RVA: 0x001A0E20 File Offset: 0x0019F020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConfiguredValueTaskAwaiter(ValueTask<TResult> value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter.NativeMethodInfoPtr__ctor_Internal_Void_ValueTask_1_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001777 RID: 6007
			// (get) Token: 0x06005BB0 RID: 23472 RVA: 0x001A0E78 File Offset: 0x0019F078
			public unsafe bool IsCompleted
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392832, XrefRangeEnd = 1392890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005BB1 RID: 23473 RVA: 0x001A0EBC File Offset: 0x0019F0BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392890, XrefRangeEnd = 1392901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TResult GetResult()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter.NativeMethodInfoPtr_GetResult_Public_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}

			// Token: 0x06005BB2 RID: 23474 RVA: 0x001A0EFC File Offset: 0x0019F0FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392901, XrefRangeEnd = 1392912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnCompleted(Action continuation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005BB3 RID: 23475 RVA: 0x001A0F44 File Offset: 0x0019F144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392912, XrefRangeEnd = 1392923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UnsafeOnCompleted(Action continuation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005BB4 RID: 23476 RVA: 0x000213B7 File Offset: 0x0001F5B7
			public ConfiguredValueTaskAwaiter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005BB5 RID: 23477 RVA: 0x000213C0 File Offset: 0x0001F5C0
			public ConfiguredValueTaskAwaiter()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter>.NativeClassPtr))
			{
			}

			// Token: 0x17001776 RID: 6006
			// (get) Token: 0x06005BB6 RID: 23478 RVA: 0x001A0F8C File Offset: 0x0019F18C
			// (set) Token: 0x06005BB7 RID: 23479 RVA: 0x000213D2 File Offset: 0x0001F5D2
			public ValueTask<TResult> _value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter.NativeFieldInfoPtr__value);
					return new ValueTask<TResult>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter.NativeFieldInfoPtr__value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x06005BB8 RID: 23480 RVA: 0x00021400 File Offset: 0x0001F600
			public void OnCompleted(Action continuation)
			{
				this.OnCompleted(continuation);
			}

			// Token: 0x04004AA4 RID: 19108
			private static readonly IntPtr NativeFieldInfoPtr__value;

			// Token: 0x04004AA5 RID: 19109
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ValueTask_1_TResult_0;

			// Token: 0x04004AA6 RID: 19110
			private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

			// Token: 0x04004AA7 RID: 19111
			private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_TResult_0;

			// Token: 0x04004AA8 RID: 19112
			private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0;

			// Token: 0x04004AA9 RID: 19113
			private static readonly IntPtr NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0;
		}
	}
}

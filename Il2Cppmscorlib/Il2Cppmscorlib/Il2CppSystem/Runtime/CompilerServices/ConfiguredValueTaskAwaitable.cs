using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003AF RID: 943
	public sealed class ConfiguredValueTaskAwaitable : ValueType
	{
		// Token: 0x060038EA RID: 14570 RVA: 0x0011477C File Offset: 0x0011297C
		// Note: this type is marked as 'beforefieldinit'.
		static ConfiguredValueTaskAwaitable()
		{
			Il2CppClassPointerStore<ConfiguredValueTaskAwaitable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "ConfiguredValueTaskAwaitable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable>.NativeClassPtr);
			ConfiguredValueTaskAwaitable.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable>.NativeClassPtr, "_value");
			ConfiguredValueTaskAwaitable.NativeMethodInfoPtr__ctor_Internal_Void_ValueTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable>.NativeClassPtr, 100671793);
			ConfiguredValueTaskAwaitable.NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredValueTaskAwaiter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable>.NativeClassPtr, 100671794);
		}

		// Token: 0x060038EB RID: 14571 RVA: 0x001147E8 File Offset: 0x001129E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfiguredValueTaskAwaitable(ValueTask value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredValueTaskAwaitable.NativeMethodInfoPtr__ctor_Internal_Void_ValueTask_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060038EC RID: 14572 RVA: 0x00114840 File Offset: 0x00112A40
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1358108, RefRangeEnd = 1358113, XrefRangeStart = 1358108, XrefRangeEnd = 1358113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter GetAwaiter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredValueTaskAwaitable.NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredValueTaskAwaiter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter(intPtr);
		}

		// Token: 0x060038ED RID: 14573 RVA: 0x00014F2A File Offset: 0x0001312A
		public ConfiguredValueTaskAwaitable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x00014F33 File Offset: 0x00013133
		public ConfiguredValueTaskAwaitable()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable>.NativeClassPtr))
		{
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x060038EF RID: 14575 RVA: 0x0011487C File Offset: 0x00112A7C
		// (set) Token: 0x060038F0 RID: 14576 RVA: 0x00014F45 File Offset: 0x00013145
		public ValueTask _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredValueTaskAwaitable.NativeFieldInfoPtr__value);
				return new ValueTask(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredValueTaskAwaitable.NativeFieldInfoPtr__value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04002E6C RID: 11884
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x04002E6D RID: 11885
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ValueTask_0;

		// Token: 0x04002E6E RID: 11886
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredValueTaskAwaiter_0;

		// Token: 0x02000689 RID: 1673
		public sealed class ConfiguredValueTaskAwaiter : ValueType, INotifyCompletion
		{
			// Token: 0x06005BA3 RID: 23459 RVA: 0x001A0B08 File Offset: 0x0019ED08
			// Note: this type is marked as 'beforefieldinit'.
			static ConfiguredValueTaskAwaiter()
			{
				Il2CppClassPointerStore<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable>.NativeClassPtr, "ConfiguredValueTaskAwaiter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>.NativeClassPtr);
				ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>.NativeClassPtr, "_value");
				ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter.NativeMethodInfoPtr__ctor_Internal_Void_ValueTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>.NativeClassPtr, 100671795);
				ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>.NativeClassPtr, 100671796);
				ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter.NativeMethodInfoPtr_GetResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>.NativeClassPtr, 100671797);
				ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>.NativeClassPtr, 100671798);
				ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>.NativeClassPtr, 100671799);
			}

			// Token: 0x06005BA4 RID: 23460 RVA: 0x001A0BAC File Offset: 0x0019EDAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392794, XrefRangeEnd = 1392802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConfiguredValueTaskAwaiter(ValueTask value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter.NativeMethodInfoPtr__ctor_Internal_Void_ValueTask_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001775 RID: 6005
			// (get) Token: 0x06005BA5 RID: 23461 RVA: 0x001A0C04 File Offset: 0x0019EE04
			public unsafe bool IsCompleted
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392802, XrefRangeEnd = 1392806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005BA6 RID: 23462 RVA: 0x001A0C48 File Offset: 0x0019EE48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392806, XrefRangeEnd = 1392810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GetResult()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter.NativeMethodInfoPtr_GetResult_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005BA7 RID: 23463 RVA: 0x001A0C80 File Offset: 0x0019EE80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392810, XrefRangeEnd = 1392821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnCompleted(Action continuation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005BA8 RID: 23464 RVA: 0x001A0CC8 File Offset: 0x0019EEC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392821, XrefRangeEnd = 1392832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UnsafeOnCompleted(Action continuation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005BA9 RID: 23465 RVA: 0x00021360 File Offset: 0x0001F560
			public ConfiguredValueTaskAwaiter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005BAA RID: 23466 RVA: 0x00021369 File Offset: 0x0001F569
			public ConfiguredValueTaskAwaiter()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>.NativeClassPtr))
			{
			}

			// Token: 0x17001774 RID: 6004
			// (get) Token: 0x06005BAB RID: 23467 RVA: 0x001A0D10 File Offset: 0x0019EF10
			// (set) Token: 0x06005BAC RID: 23468 RVA: 0x0002137B File Offset: 0x0001F57B
			public ValueTask _value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter.NativeFieldInfoPtr__value);
					return new ValueTask(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter.NativeFieldInfoPtr__value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x06005BAD RID: 23469 RVA: 0x000213A9 File Offset: 0x0001F5A9
			public void OnCompleted(Action continuation)
			{
				this.OnCompleted(continuation);
			}

			// Token: 0x04004A9E RID: 19102
			private static readonly IntPtr NativeFieldInfoPtr__value;

			// Token: 0x04004A9F RID: 19103
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ValueTask_0;

			// Token: 0x04004AA0 RID: 19104
			private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

			// Token: 0x04004AA1 RID: 19105
			private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_Void_0;

			// Token: 0x04004AA2 RID: 19106
			private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0;

			// Token: 0x04004AA3 RID: 19107
			private static readonly IntPtr NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0;
		}
	}
}

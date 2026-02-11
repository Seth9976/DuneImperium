using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003C8 RID: 968
	public sealed class ValueTaskAwaiter : ValueType, INotifyCompletion
	{
		// Token: 0x0600395C RID: 14684 RVA: 0x001159E4 File Offset: 0x00113BE4
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTaskAwaiter()
		{
			Il2CppClassPointerStore<ValueTaskAwaiter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "ValueTaskAwaiter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTaskAwaiter>.NativeClassPtr);
			ValueTaskAwaiter.NativeFieldInfoPtr_s_invokeActionDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTaskAwaiter>.NativeClassPtr, "s_invokeActionDelegate");
			ValueTaskAwaiter.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTaskAwaiter>.NativeClassPtr, "_value");
			ValueTaskAwaiter.NativeMethodInfoPtr__ctor_Internal_Void_ValueTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTaskAwaiter>.NativeClassPtr, 100671848);
			ValueTaskAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTaskAwaiter>.NativeClassPtr, 100671849);
			ValueTaskAwaiter.NativeMethodInfoPtr_GetResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTaskAwaiter>.NativeClassPtr, 100671850);
			ValueTaskAwaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTaskAwaiter>.NativeClassPtr, 100671851);
			ValueTaskAwaiter.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTaskAwaiter>.NativeClassPtr, 100671852);
		}

		// Token: 0x0600395D RID: 14685 RVA: 0x00115AA0 File Offset: 0x00113CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTaskAwaiter(ValueTask value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTaskAwaiter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTaskAwaiter.NativeMethodInfoPtr__ctor_Internal_Void_ValueTask_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x0600395E RID: 14686 RVA: 0x00115AF8 File Offset: 0x00113CF8
		public unsafe bool IsCompleted
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1393007, XrefRangeEnd = 1393011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTaskAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600395F RID: 14687 RVA: 0x00115B3C File Offset: 0x00113D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1393011, XrefRangeEnd = 1393015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTaskAwaiter.NativeMethodInfoPtr_GetResult_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003960 RID: 14688 RVA: 0x00115B74 File Offset: 0x00113D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1393015, XrefRangeEnd = 1393026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTaskAwaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003961 RID: 14689 RVA: 0x00115BBC File Offset: 0x00113DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1393026, XrefRangeEnd = 1393037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnsafeOnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTaskAwaiter.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003962 RID: 14690 RVA: 0x0001541A File Offset: 0x0001361A
		public ValueTaskAwaiter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06003963 RID: 14691 RVA: 0x00015423 File Offset: 0x00013623
		public ValueTaskAwaiter()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTaskAwaiter>.NativeClassPtr))
		{
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x06003964 RID: 14692 RVA: 0x00115C04 File Offset: 0x00113E04
		// (set) Token: 0x06003965 RID: 14693 RVA: 0x00015435 File Offset: 0x00013635
		public unsafe static Action<Object> s_invokeActionDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ValueTaskAwaiter.NativeFieldInfoPtr_s_invokeActionDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValueTaskAwaiter.NativeFieldInfoPtr_s_invokeActionDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x06003966 RID: 14694 RVA: 0x00115C2C File Offset: 0x00113E2C
		// (set) Token: 0x06003967 RID: 14695 RVA: 0x00015447 File Offset: 0x00013647
		public ValueTask _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTaskAwaiter.NativeFieldInfoPtr__value);
				return new ValueTask(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTaskAwaiter.NativeFieldInfoPtr__value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x06003968 RID: 14696 RVA: 0x00015475 File Offset: 0x00013675
		public void OnCompleted(Action continuation)
		{
			this.OnCompleted(continuation);
		}

		// Token: 0x04002E9E RID: 11934
		private static readonly IntPtr NativeFieldInfoPtr_s_invokeActionDelegate;

		// Token: 0x04002E9F RID: 11935
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x04002EA0 RID: 11936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ValueTask_0;

		// Token: 0x04002EA1 RID: 11937
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

		// Token: 0x04002EA2 RID: 11938
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_Void_0;

		// Token: 0x04002EA3 RID: 11939
		private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04002EA4 RID: 11940
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x0200068C RID: 1676
		[ObfuscatedName("System.Runtime.CompilerServices.ValueTaskAwaiter+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005BC5 RID: 23493 RVA: 0x001A1288 File Offset: 0x0019F488
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ValueTaskAwaiter.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValueTaskAwaiter>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTaskAwaiter.__c>.NativeClassPtr);
				ValueTaskAwaiter.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTaskAwaiter.__c>.NativeClassPtr, "<>9");
				ValueTaskAwaiter.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTaskAwaiter.__c>.NativeClassPtr, 100671855);
				ValueTaskAwaiter.__c.NativeMethodInfoPtr___cctor_b__9_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTaskAwaiter.__c>.NativeClassPtr, 100671856);
			}

			// Token: 0x06005BC6 RID: 23494 RVA: 0x001A12F0 File Offset: 0x0019F4F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTaskAwaiter.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTaskAwaiter.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005BC7 RID: 23495 RVA: 0x001A132C File Offset: 0x0019F52C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1393004, XrefRangeEnd = 1393007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__9_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTaskAwaiter.__c.NativeMethodInfoPtr___cctor_b__9_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005BC8 RID: 23496 RVA: 0x00021455 File Offset: 0x0001F655
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700177C RID: 6012
			// (get) Token: 0x06005BC9 RID: 23497 RVA: 0x001A1370 File Offset: 0x0019F570
			// (set) Token: 0x06005BCA RID: 23498 RVA: 0x0002145E File Offset: 0x0001F65E
			public unsafe static ValueTaskAwaiter.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ValueTaskAwaiter.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueTaskAwaiter.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ValueTaskAwaiter.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004AB2 RID: 19122
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004AB3 RID: 19123
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004AB4 RID: 19124
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__9_0_Internal_Void_Object_0;
		}
	}
}

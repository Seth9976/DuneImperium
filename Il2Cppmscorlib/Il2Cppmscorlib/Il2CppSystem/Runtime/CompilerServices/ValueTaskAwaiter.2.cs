using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003C9 RID: 969
	public sealed class ValueTaskAwaiter<TResult> : ValueType, INotifyCompletion
	{
		// Token: 0x06003969 RID: 14697 RVA: 0x00115C5C File Offset: 0x00113E5C
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTaskAwaiter()
		{
			Il2CppClassPointerStore<ValueTaskAwaiter<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "ValueTaskAwaiter`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTaskAwaiter<TResult>>.NativeClassPtr);
			ValueTaskAwaiter<TResult>.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTaskAwaiter<TResult>>.NativeClassPtr, "_value");
			ValueTaskAwaiter<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_ValueTask_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTaskAwaiter<TResult>>.NativeClassPtr, 100671857);
			ValueTaskAwaiter<TResult>.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTaskAwaiter<TResult>>.NativeClassPtr, 100671858);
			ValueTaskAwaiter<TResult>.NativeMethodInfoPtr_GetResult_Public_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTaskAwaiter<TResult>>.NativeClassPtr, 100671859);
			ValueTaskAwaiter<TResult>.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTaskAwaiter<TResult>>.NativeClassPtr, 100671860);
			ValueTaskAwaiter<TResult>.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTaskAwaiter<TResult>>.NativeClassPtr, 100671861);
		}

		// Token: 0x0600396A RID: 14698 RVA: 0x00115D40 File Offset: 0x00113F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTaskAwaiter(ValueTask<TResult> value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTaskAwaiter<TResult>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTaskAwaiter<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_ValueTask_1_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x0600396B RID: 14699 RVA: 0x00115D98 File Offset: 0x00113F98
		public unsafe bool IsCompleted
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTaskAwaiter<TResult>.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600396C RID: 14700 RVA: 0x00115DDC File Offset: 0x00113FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TResult GetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTaskAwaiter<TResult>.NativeMethodInfoPtr_GetResult_Public_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
		}

		// Token: 0x0600396D RID: 14701 RVA: 0x00115E1C File Offset: 0x0011401C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1393037, XrefRangeEnd = 1393048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTaskAwaiter<TResult>.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600396E RID: 14702 RVA: 0x00115E64 File Offset: 0x00114064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1393048, XrefRangeEnd = 1393059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnsafeOnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTaskAwaiter<TResult>.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600396F RID: 14703 RVA: 0x00015483 File Offset: 0x00013683
		public ValueTaskAwaiter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06003970 RID: 14704 RVA: 0x0001548C File Offset: 0x0001368C
		public ValueTaskAwaiter()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTaskAwaiter<TResult>>.NativeClassPtr))
		{
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x06003971 RID: 14705 RVA: 0x00115EAC File Offset: 0x001140AC
		// (set) Token: 0x06003972 RID: 14706 RVA: 0x0001549E File Offset: 0x0001369E
		public ValueTask<TResult> _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTaskAwaiter<TResult>.NativeFieldInfoPtr__value);
				return new ValueTask<TResult>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTaskAwaiter<TResult>.NativeFieldInfoPtr__value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTask<TResult>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x06003973 RID: 14707 RVA: 0x000154CC File Offset: 0x000136CC
		public void OnCompleted(Action continuation)
		{
			this.OnCompleted(continuation);
		}

		// Token: 0x04002EA5 RID: 11941
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x04002EA6 RID: 11942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ValueTask_1_TResult_0;

		// Token: 0x04002EA7 RID: 11943
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

		// Token: 0x04002EA8 RID: 11944
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_TResult_0;

		// Token: 0x04002EA9 RID: 11945
		private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04002EAA RID: 11946
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0;
	}
}

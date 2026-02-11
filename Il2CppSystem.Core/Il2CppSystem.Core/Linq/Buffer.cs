using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq
{
	// Token: 0x02000024 RID: 36
	public sealed class Buffer<TElement> : ValueType
	{
		// Token: 0x06000177 RID: 375 RVA: 0x00016824 File Offset: 0x00014A24
		// Note: this type is marked as 'beforefieldinit'.
		static Buffer()
		{
			Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "Buffer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr);
			Buffer<TElement>.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr, "items");
			Buffer<TElement>.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr, "count");
			Buffer<TElement>.NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr, 100663793);
			Buffer<TElement>.NativeMethodInfoPtr_ToArray_Internal_Il2CppArrayBase_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr, 100663794);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000168E0 File Offset: 0x00014AE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1006623, RefRangeEnd = 1006624, XrefRangeStart = 1006583, XrefRangeEnd = 1006623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Buffer(IEnumerable<TElement> source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer<TElement>.NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_TElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00016930 File Offset: 0x00014B30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1006628, RefRangeEnd = 1006629, XrefRangeStart = 1006624, XrefRangeEnd = 1006628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<TElement> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer<TElement>.NativeMethodInfoPtr_ToArray_Internal_Il2CppArrayBase_1_TElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<TElement>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000025CA File Offset: 0x000007CA
		public Buffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000025D3 File Offset: 0x000007D3
		public Buffer()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr))
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0001696C File Offset: 0x00014B6C
		// (set) Token: 0x0600017D RID: 381 RVA: 0x000025E5 File Offset: 0x000007E5
		public unsafe Il2CppArrayBase<TElement> items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Buffer<TElement>.NativeFieldInfoPtr_items);
				return Il2CppArrayBase<TElement>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Buffer<TElement>.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00016994 File Offset: 0x00014B94
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00002604 File Offset: 0x00000804
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Buffer<TElement>.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Buffer<TElement>.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_TElement_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Internal_Il2CppArrayBase_1_TElement_0;
	}
}

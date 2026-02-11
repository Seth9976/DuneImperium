using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200006D RID: 109
	public class ThreadSafeStore<TKey, TValue> : Object
	{
		// Token: 0x06000978 RID: 2424 RVA: 0x0003E478 File Offset: 0x0003C678
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadSafeStore()
		{
			Il2CppClassPointerStore<ThreadSafeStore<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "ThreadSafeStore`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadSafeStore<TKey, TValue>>.NativeClassPtr);
			ThreadSafeStore<TKey, TValue>.NativeFieldInfoPtr__concurrentStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeStore<TKey, TValue>>.NativeClassPtr, "_concurrentStore");
			ThreadSafeStore<TKey, TValue>.NativeFieldInfoPtr__creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeStore<TKey, TValue>>.NativeClassPtr, "_creator");
			ThreadSafeStore<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Func_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeStore<TKey, TValue>>.NativeClassPtr, 100665118);
			ThreadSafeStore<TKey, TValue>.NativeMethodInfoPtr_Get_Public_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeStore<TKey, TValue>>.NativeClassPtr, 100665119);
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0003E548 File Offset: 0x0003C748
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 746437, RefRangeEnd = 746439, XrefRangeStart = 746419, XrefRangeEnd = 746437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadSafeStore(Func<TKey, TValue> creator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadSafeStore<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(creator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeStore<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Func_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0003E594 File Offset: 0x0003C794
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 746440, RefRangeEnd = 746447, XrefRangeStart = 746439, XrefRangeEnd = 746440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TValue Get(TKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ThreadSafeStore<TKey, TValue>.NativeMethodInfoPtr_Get_Public_TValue_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
			}
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00004E66 File Offset: 0x00003066
		public ThreadSafeStore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x0003E614 File Offset: 0x0003C814
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x00004E6F File Offset: 0x0000306F
		public unsafe ConcurrentDictionary<TKey, TValue> _concurrentStore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeStore<TKey, TValue>.NativeFieldInfoPtr__concurrentStore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<TKey, TValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeStore<TKey, TValue>.NativeFieldInfoPtr__concurrentStore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x0003E644 File Offset: 0x0003C844
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x00004E8E File Offset: 0x0000308E
		public unsafe Func<TKey, TValue> _creator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeStore<TKey, TValue>.NativeFieldInfoPtr__creator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TKey, TValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeStore<TKey, TValue>.NativeFieldInfoPtr__creator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeFieldInfoPtr__concurrentStore;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeFieldInfoPtr__creator;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_2_TKey_TValue_0;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_TValue_TKey_0;
	}
}

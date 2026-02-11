using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq
{
	// Token: 0x0200001F RID: 31
	public class GroupedEnumerable<TSource, TKey, TElement> : Object
	{
		// Token: 0x0600013F RID: 319 RVA: 0x00015A50 File Offset: 0x00013C50
		// Note: this type is marked as 'beforefieldinit'.
		static GroupedEnumerable()
		{
			Il2CppClassPointerStore<GroupedEnumerable<TSource, TKey, TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "GroupedEnumerable`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GroupedEnumerable<TSource, TKey, TElement>>.NativeClassPtr);
			GroupedEnumerable<TSource, TKey, TElement>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupedEnumerable<TSource, TKey, TElement>>.NativeClassPtr, "source");
			GroupedEnumerable<TSource, TKey, TElement>.NativeFieldInfoPtr_keySelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupedEnumerable<TSource, TKey, TElement>>.NativeClassPtr, "keySelector");
			GroupedEnumerable<TSource, TKey, TElement>.NativeFieldInfoPtr_elementSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupedEnumerable<TSource, TKey, TElement>>.NativeClassPtr, "elementSelector");
			GroupedEnumerable<TSource, TKey, TElement>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupedEnumerable<TSource, TKey, TElement>>.NativeClassPtr, "comparer");
			GroupedEnumerable<TSource, TKey, TElement>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupedEnumerable<TSource, TKey, TElement>>.NativeClassPtr, 100663769);
			GroupedEnumerable<TSource, TKey, TElement>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_IGrouping_2_TKey_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupedEnumerable<TSource, TKey, TElement>>.NativeClassPtr, 100663770);
			GroupedEnumerable<TSource, TKey, TElement>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupedEnumerable<TSource, TKey, TElement>>.NativeClassPtr, 100663771);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00015B6C File Offset: 0x00013D6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1006503, RefRangeEnd = 1006504, XrefRangeStart = 1006474, XrefRangeEnd = 1006503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GroupedEnumerable(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GroupedEnumerable<TSource, TKey, TElement>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementSelector);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupedEnumerable<TSource, TKey, TElement>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00015BF0 File Offset: 0x00013DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006504, XrefRangeEnd = 1006510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupedEnumerable<TSource, TKey, TElement>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_IGrouping_2_TKey_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IGrouping<TKey, TElement>>>(intPtr3) : null;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00015C30 File Offset: 0x00013E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006510, XrefRangeEnd = 1006525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupedEnumerable<TSource, TKey, TElement>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000023F3 File Offset: 0x000005F3
		public GroupedEnumerable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00015C70 File Offset: 0x00013E70
		// (set) Token: 0x06000145 RID: 325 RVA: 0x000023FC File Offset: 0x000005FC
		public unsafe IEnumerable<TSource> source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupedEnumerable<TSource, TKey, TElement>.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupedEnumerable<TSource, TKey, TElement>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00015CA0 File Offset: 0x00013EA0
		// (set) Token: 0x06000147 RID: 327 RVA: 0x0000241B File Offset: 0x0000061B
		public unsafe Func<TSource, TKey> keySelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupedEnumerable<TSource, TKey, TElement>.NativeFieldInfoPtr_keySelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, TKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupedEnumerable<TSource, TKey, TElement>.NativeFieldInfoPtr_keySelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00015CD0 File Offset: 0x00013ED0
		// (set) Token: 0x06000149 RID: 329 RVA: 0x0000243A File Offset: 0x0000063A
		public unsafe Func<TSource, TElement> elementSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupedEnumerable<TSource, TKey, TElement>.NativeFieldInfoPtr_elementSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, TElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupedEnumerable<TSource, TKey, TElement>.NativeFieldInfoPtr_elementSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00015D00 File Offset: 0x00013F00
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00002459 File Offset: 0x00000659
		public unsafe IEqualityComparer<TKey> comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupedEnumerable<TSource, TKey, TElement>.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupedEnumerable<TSource, TKey, TElement>.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeFieldInfoPtr_keySelector;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeFieldInfoPtr_elementSelector;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_IGrouping_2_TKey_TElement_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
	}
}

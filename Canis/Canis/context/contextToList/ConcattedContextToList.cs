using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.context.contextToList
{
	// Token: 0x02000130 RID: 304
	[Serializable]
	public class ConcattedContextToList<T> : ContextToList<T>
	{
		// Token: 0x06000DE9 RID: 3561 RVA: 0x00054958 File Offset: 0x00052B58
		// Note: this type is marked as 'beforefieldinit'.
		static ConcattedContextToList()
		{
			Il2CppClassPointerStore<ConcattedContextToList<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.contextToList", "ConcattedContextToList`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcattedContextToList<T>>.NativeClassPtr);
			ConcattedContextToList<T>.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcattedContextToList<T>>.NativeClassPtr, "first");
			ConcattedContextToList<T>.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcattedContextToList<T>>.NativeClassPtr, "second");
			ConcattedContextToList<T>.NativeMethodInfoPtr__ctor_Public_Void_ContextToList_1_T_ContextToList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcattedContextToList<T>>.NativeClassPtr, 100666369);
			ConcattedContextToList<T>.NativeMethodInfoPtr_Evaluate_Public_Virtual_IEnumerable_1_T_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcattedContextToList<T>>.NativeClassPtr, 100666370);
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00054A14 File Offset: 0x00052C14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 577102, RefRangeEnd = 577103, XrefRangeStart = 577099, XrefRangeEnd = 577102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConcattedContextToList(ContextToList<T> first, ContextToList<T> second)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcattedContextToList<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcattedContextToList<T>.NativeMethodInfoPtr__ctor_Public_Void_ContextToList_1_T_ContextToList_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00054A74 File Offset: 0x00052C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577103, XrefRangeEnd = 577107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<T> Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConcattedContextToList<T>.NativeMethodInfoPtr_Evaluate_Public_Virtual_IEnumerable_1_T_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x0000710A File Offset: 0x0000530A
		public ConcattedContextToList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000DED RID: 3565 RVA: 0x00054AD0 File Offset: 0x00052CD0
		// (set) Token: 0x06000DEE RID: 3566 RVA: 0x00007113 File Offset: 0x00005313
		public unsafe ContextToList<T> first
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcattedContextToList<T>.NativeFieldInfoPtr_first);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextToList<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcattedContextToList<T>.NativeFieldInfoPtr_first), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000DEF RID: 3567 RVA: 0x00054B00 File Offset: 0x00052D00
		// (set) Token: 0x06000DF0 RID: 3568 RVA: 0x00007132 File Offset: 0x00005332
		public unsafe ContextToList<T> second
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcattedContextToList<T>.NativeFieldInfoPtr_second);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextToList<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcattedContextToList<T>.NativeFieldInfoPtr_second), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeFieldInfoPtr_first;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeFieldInfoPtr_second;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ContextToList_1_T_ContextToList_1_T_0;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_IEnumerable_1_T_Context_0;
	}
}

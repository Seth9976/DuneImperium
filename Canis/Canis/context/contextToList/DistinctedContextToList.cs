using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.context.contextToList
{
	// Token: 0x0200012F RID: 303
	[Serializable]
	public class DistinctedContextToList<T> : ContextToList<T>
	{
		// Token: 0x06000DE3 RID: 3555 RVA: 0x000547D8 File Offset: 0x000529D8
		// Note: this type is marked as 'beforefieldinit'.
		static DistinctedContextToList()
		{
			Il2CppClassPointerStore<DistinctedContextToList<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.contextToList", "DistinctedContextToList`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DistinctedContextToList<T>>.NativeClassPtr);
			DistinctedContextToList<T>.NativeFieldInfoPtr_ctl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistinctedContextToList<T>>.NativeClassPtr, "ctl");
			DistinctedContextToList<T>.NativeMethodInfoPtr__ctor_Public_Void_ContextToList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistinctedContextToList<T>>.NativeClassPtr, 100666367);
			DistinctedContextToList<T>.NativeMethodInfoPtr_Evaluate_Public_Virtual_IEnumerable_1_T_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistinctedContextToList<T>>.NativeClassPtr, 100666368);
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x00054880 File Offset: 0x00052A80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 577094, RefRangeEnd = 577097, XrefRangeStart = 577090, XrefRangeEnd = 577094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DistinctedContextToList(ContextToList<T> ctl)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DistinctedContextToList<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistinctedContextToList<T>.NativeMethodInfoPtr__ctor_Public_Void_ContextToList_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x000548CC File Offset: 0x00052ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577097, XrefRangeEnd = 577099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<T> Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DistinctedContextToList<T>.NativeMethodInfoPtr_Evaluate_Public_Virtual_IEnumerable_1_T_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x000070E2 File Offset: 0x000052E2
		public DistinctedContextToList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x00054928 File Offset: 0x00052B28
		// (set) Token: 0x06000DE8 RID: 3560 RVA: 0x000070EB File Offset: 0x000052EB
		public unsafe ContextToList<T> ctl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistinctedContextToList<T>.NativeFieldInfoPtr_ctl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextToList<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistinctedContextToList<T>.NativeFieldInfoPtr_ctl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeFieldInfoPtr_ctl;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ContextToList_1_T_0;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_IEnumerable_1_T_Context_0;
	}
}

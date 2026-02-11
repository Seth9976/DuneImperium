using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.context.contextToList
{
	// Token: 0x0200012E RID: 302
	public class ContextToList<T> : ContextToList
	{
		// Token: 0x06000DDB RID: 3547 RVA: 0x0005452C File Offset: 0x0005272C
		// Note: this type is marked as 'beforefieldinit'.
		static ContextToList()
		{
			Il2CppClassPointerStore<ContextToList<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.contextToList", "ContextToList`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextToList<T>>.NativeClassPtr);
			ContextToList<T>.NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_IEnumerable_1_T_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToList<T>>.NativeClassPtr, 100666361);
			ContextToList<T>.NativeMethodInfoPtr_ErasedEvaluate_Public_Virtual_IEnumerable_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToList<T>>.NativeClassPtr, 100666362);
			ContextToList<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Func_2_Context_IEnumerable_1_T_ContextToList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToList<T>>.NativeClassPtr, 100666363);
			ContextToList<T>.NativeMethodInfoPtr_Distinct_Public_ContextToList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToList<T>>.NativeClassPtr, 100666364);
			ContextToList<T>.NativeMethodInfoPtr_Concat_Public_ContextToList_1_T_ContextToList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToList<T>>.NativeClassPtr, 100666365);
			ContextToList<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToList<T>>.NativeClassPtr, 100666366);
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00054610 File Offset: 0x00052810
		[CallerCount(0)]
		public unsafe virtual IEnumerable<T> Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContextToList<T>.NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_IEnumerable_1_T_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x0005466C File Offset: 0x0005286C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577074, XrefRangeEnd = 577079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable ErasedEvaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContextToList<T>.NativeMethodInfoPtr_ErasedEvaluate_Public_Virtual_IEnumerable_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable>(intPtr3) : null;
			}
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x000546C8 File Offset: 0x000528C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577079, XrefRangeEnd = 577084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Func<Context, IEnumerable<T>>(ContextToList<T> cti)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cti);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextToList<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Func_2_Context_IEnumerable_1_T_ContextToList_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Context, IEnumerable<T>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x0005470C File Offset: 0x0005290C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577084, XrefRangeEnd = 577087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextToList<T> Distinct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextToList<T>.NativeMethodInfoPtr_Distinct_Public_ContextToList_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContextToList<T>>(intPtr3) : null;
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x0005474C File Offset: 0x0005294C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577087, XrefRangeEnd = 577090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextToList<T> Concat(ContextToList<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextToList<T>.NativeMethodInfoPtr_Concat_Public_ContextToList_1_T_ContextToList_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContextToList<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x0005479C File Offset: 0x0005299C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextToList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextToList<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextToList<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x000070D9 File Offset: 0x000052D9
		public ContextToList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_IEnumerable_1_T_Context_0;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeMethodInfoPtr_ErasedEvaluate_Public_Virtual_IEnumerable_Context_0;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Func_2_Context_IEnumerable_1_T_ContextToList_1_T_0;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeMethodInfoPtr_Distinct_Public_ContextToList_1_T_0;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_ContextToList_1_T_ContextToList_1_T_0;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

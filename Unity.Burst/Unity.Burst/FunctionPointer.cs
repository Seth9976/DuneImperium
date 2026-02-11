using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Burst
{
	// Token: 0x02000014 RID: 20
	public sealed class FunctionPointer<T> : ValueType
	{
		// Token: 0x060001D0 RID: 464 RVA: 0x00008FA4 File Offset: 0x000071A4
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionPointer()
		{
			Il2CppClassPointerStore<FunctionPointer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst", "FunctionPointer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionPointer<T>>.NativeClassPtr);
			FunctionPointer<T>.NativeFieldInfoPtr__ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionPointer<T>>.NativeClassPtr, "_ptr");
			FunctionPointer<T>.NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionPointer<T>>.NativeClassPtr, 100663509);
			FunctionPointer<T>.NativeMethodInfoPtr_CheckIsCreated_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionPointer<T>>.NativeClassPtr, 100663510);
			FunctionPointer<T>.NativeMethodInfoPtr_get_Invoke_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionPointer<T>>.NativeClassPtr, 100663511);
			FunctionPointer<T>.NativeMethodInfoPtr_get_IsCreated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionPointer<T>>.NativeClassPtr, 100663512);
			FunctionPointer<T>.NativeMethodInfoPtr_Unity_Burst_IFunctionPointer_FromIntPtr_Private_Virtual_Final_New_IFunctionPointer_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionPointer<T>>.NativeClassPtr, 100663513);
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00009088 File Offset: 0x00007288
		public unsafe IntPtr Value
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionPointer<T>.NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000090CC File Offset: 0x000072CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052369, XrefRangeEnd = 1052371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckIsCreated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionPointer<T>.NativeMethodInfoPtr_CheckIsCreated_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00009104 File Offset: 0x00007304
		public unsafe T Invoke
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052371, XrefRangeEnd = 1052384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionPointer<T>.NativeMethodInfoPtr_get_Invoke_Public_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00009144 File Offset: 0x00007344
		public unsafe bool IsCreated
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 1052393, RefRangeEnd = 1052416, XrefRangeStart = 1052384, XrefRangeEnd = 1052393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionPointer<T>.NativeMethodInfoPtr_get_IsCreated_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00009188 File Offset: 0x00007388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052416, XrefRangeEnd = 1052419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IFunctionPointer Unity_Burst_IFunctionPointer_FromIntPtr(IntPtr ptr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionPointer<T>.NativeMethodInfoPtr_Unity_Burst_IFunctionPointer_FromIntPtr_Private_Virtual_Final_New_IFunctionPointer_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFunctionPointer>(intPtr3) : null;
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002BE8 File Offset: 0x00000DE8
		public FunctionPointer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002BF1 File Offset: 0x00000DF1
		public FunctionPointer()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionPointer<T>>.NativeClassPtr))
		{
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x000091DC File Offset: 0x000073DC
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00002C03 File Offset: 0x00000E03
		public unsafe IntPtr _ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionPointer<T>.NativeFieldInfoPtr__ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionPointer<T>.NativeFieldInfoPtr__ptr)) = value;
			}
		}

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeFieldInfoPtr__ptr;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_CheckIsCreated_Private_Void_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_get_Invoke_Public_get_T_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCreated_Public_get_Boolean_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_Unity_Burst_IFunctionPointer_FromIntPtr_Private_Virtual_Final_New_IFunctionPointer_IntPtr_0;
	}
}

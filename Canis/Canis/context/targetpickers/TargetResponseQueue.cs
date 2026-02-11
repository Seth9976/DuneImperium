using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Networking.selection.targetresponse;

namespace Canis.context.targetpickers
{
	// Token: 0x02000128 RID: 296
	public class TargetResponseQueue : Object
	{
		// Token: 0x06000DBB RID: 3515 RVA: 0x00053E04 File Offset: 0x00052004
		// Note: this type is marked as 'beforefieldinit'.
		static TargetResponseQueue()
		{
			Il2CppClassPointerStore<TargetResponseQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.targetpickers", "TargetResponseQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetResponseQueue>.NativeClassPtr);
			TargetResponseQueue.NativeFieldInfoPtr_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetResponseQueue>.NativeClassPtr, "queue");
			TargetResponseQueue.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetResponseQueue>.NativeClassPtr, 100666346);
			TargetResponseQueue.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetResponseQueue>.NativeClassPtr, 100666347);
			TargetResponseQueue.NativeMethodInfoPtr__ctor_Public_Void_TargetResponseQueue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetResponseQueue>.NativeClassPtr, 100666348);
			TargetResponseQueue.NativeMethodInfoPtr_Dequeue_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetResponseQueue>.NativeClassPtr, 100666349);
			TargetResponseQueue.NativeMethodInfoPtr_Peek_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetResponseQueue>.NativeClassPtr, 100666350);
			TargetResponseQueue.NativeMethodInfoPtr_HasNext_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetResponseQueue>.NativeClassPtr, 100666351);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00053EC0 File Offset: 0x000520C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576938, XrefRangeEnd = 576946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetResponseQueue(IEnumerable<TargetResponse> responses)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetResponseQueue>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(responses);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetResponseQueue.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00053F0C File Offset: 0x0005210C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 576961, RefRangeEnd = 576969, XrefRangeStart = 576946, XrefRangeEnd = 576961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetResponseQueue([Optional] Il2CppReferenceArray<TargetResponse> responses)
		{
			if (responses == null)
			{
				responses = new Il2CppReferenceArray<TargetResponse>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetResponseQueue>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(responses);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetResponseQueue.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00053F64 File Offset: 0x00052164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576969, XrefRangeEnd = 576978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetResponseQueue(TargetResponseQueue other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetResponseQueue>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetResponseQueue.NativeMethodInfoPtr__ctor_Public_Void_TargetResponseQueue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00053FB0 File Offset: 0x000521B0
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 576983, RefRangeEnd = 577018, XrefRangeStart = 576978, XrefRangeEnd = 576983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Dequeue<T>() where T : TargetResponse
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetResponseQueue.MethodInfoStoreGeneric_Dequeue_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00053FEC File Offset: 0x000521EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 577023, RefRangeEnd = 577026, XrefRangeStart = 577018, XrefRangeEnd = 577023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Peek<T>() where T : TargetResponse
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetResponseQueue.MethodInfoStoreGeneric_Peek_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00054028 File Offset: 0x00052228
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 577030, RefRangeEnd = 577065, XrefRangeStart = 577026, XrefRangeEnd = 577030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetResponseQueue.NativeMethodInfoPtr_HasNext_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00007028 File Offset: 0x00005228
		public TargetResponseQueue(params TargetResponse[] responses)
			: this(new Il2CppReferenceArray<TargetResponse>(responses))
		{
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00007036 File Offset: 0x00005236
		public TargetResponseQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x00054064 File Offset: 0x00052264
		// (set) Token: 0x06000DC5 RID: 3525 RVA: 0x0000703F File Offset: 0x0000523F
		public unsafe Queue<TargetResponse> queue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetResponseQueue.NativeFieldInfoPtr_queue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<TargetResponse>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetResponseQueue.NativeFieldInfoPtr_queue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeFieldInfoPtr_queue;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TargetResponse_0;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_TargetResponse_0;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TargetResponseQueue_0;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeMethodInfoPtr_Dequeue_Public_T_0;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_T_0;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeMethodInfoPtr_HasNext_Public_Boolean_0;

		// Token: 0x0200038D RID: 909
		private sealed class MethodInfoStoreGeneric_Dequeue_Public_T_0<T>
		{
			// Token: 0x040017AF RID: 6063
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TargetResponseQueue.NativeMethodInfoPtr_Dequeue_Public_T_0, Il2CppClassPointerStore<TargetResponseQueue>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200038E RID: 910
		private sealed class MethodInfoStoreGeneric_Peek_Public_T_0<T>
		{
			// Token: 0x040017B0 RID: 6064
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TargetResponseQueue.NativeMethodInfoPtr_Peek_Public_T_0, Il2CppClassPointerStore<TargetResponseQueue>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

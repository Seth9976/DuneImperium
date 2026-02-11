using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000152 RID: 338
	public class TrackedReference : Object
	{
		// Token: 0x06001947 RID: 6471 RVA: 0x00076938 File Offset: 0x00074B38
		// Note: this type is marked as 'beforefieldinit'.
		static TrackedReference()
		{
			Il2CppClassPointerStore<TrackedReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TrackedReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedReference>.NativeClassPtr);
			TrackedReference.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedReference>.NativeClassPtr, "m_Ptr");
			TrackedReference.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedReference>.NativeClassPtr, 100666782);
			TrackedReference.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TrackedReference_TrackedReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedReference>.NativeClassPtr, 100666783);
			TrackedReference.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TrackedReference_TrackedReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedReference>.NativeClassPtr, 100666784);
			TrackedReference.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedReference>.NativeClassPtr, 100666785);
			TrackedReference.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedReference>.NativeClassPtr, 100666786);
			TrackedReference.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_TrackedReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedReference>.NativeClassPtr, 100666787);
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x000769F4 File Offset: 0x00074BF4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackedReference()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedReference>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedReference.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x00076A30 File Offset: 0x00074C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667414, XrefRangeEnd = 667415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(TrackedReference x, TrackedReference y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedReference.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TrackedReference_TrackedReference_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00076A84 File Offset: 0x00074C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667415, XrefRangeEnd = 667416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(TrackedReference x, TrackedReference y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedReference.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TrackedReference_TrackedReference_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00076AD8 File Offset: 0x00074CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667416, XrefRangeEnd = 667421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedReference.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x00076B30 File Offset: 0x00074D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667421, XrefRangeEnd = 667422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedReference.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x00076B78 File Offset: 0x00074D78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 667423, RefRangeEnd = 667424, XrefRangeStart = 667422, XrefRangeEnd = 667423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator bool(TrackedReference exists)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exists);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedReference.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_TrackedReference_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x00009D88 File Offset: 0x00007F88
		public TrackedReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x0600194F RID: 6479 RVA: 0x00076BBC File Offset: 0x00074DBC
		// (set) Token: 0x06001950 RID: 6480 RVA: 0x00009D91 File Offset: 0x00007F91
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedReference.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedReference.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x04001681 RID: 5761
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04001682 RID: 5762
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001683 RID: 5763
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TrackedReference_TrackedReference_0;

		// Token: 0x04001684 RID: 5764
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TrackedReference_TrackedReference_0;

		// Token: 0x04001685 RID: 5765
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001686 RID: 5766
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001687 RID: 5767
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_TrackedReference_0;
	}
}

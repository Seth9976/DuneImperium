using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000023 RID: 35
	[StructLayout(2)]
	public struct HighlightState
	{
		// Token: 0x06000324 RID: 804 RVA: 0x00014258 File Offset: 0x00012458
		// Note: this type is marked as 'beforefieldinit'.
		static HighlightState()
		{
			Il2CppClassPointerStore<HighlightState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "HighlightState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HighlightState>.NativeClassPtr);
			HighlightState.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, "color");
			HighlightState.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, "padding");
			HighlightState.NativeMethodInfoPtr__ctor_Public_Void_Color32_TMP_Offset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, 100663613);
			HighlightState.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HighlightState_HighlightState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, 100663614);
			HighlightState.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HighlightState_HighlightState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, 100663615);
			HighlightState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, 100663616);
			HighlightState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, 100663617);
			HighlightState.NativeMethodInfoPtr_Equals_Public_Boolean_HighlightState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, 100663618);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00014328 File Offset: 0x00012528
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1038077, RefRangeEnd = 1038087, XrefRangeStart = 1038077, XrefRangeEnd = 1038077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HighlightState(Color32 color, TMP_Offset padding)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padding;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightState.NativeMethodInfoPtr__ctor_Public_Void_Color32_TMP_Offset_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00014368 File Offset: 0x00012568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038087, XrefRangeEnd = 1038089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HighlightState lhs, HighlightState rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightState.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HighlightState_HighlightState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x000143B4 File Offset: 0x000125B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1038091, RefRangeEnd = 1038093, XrefRangeStart = 1038089, XrefRangeEnd = 1038091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HighlightState lhs, HighlightState rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightState.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HighlightState_HighlightState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00014400 File Offset: 0x00012600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038093, XrefRangeEnd = 1038097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00014430 File Offset: 0x00012630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038097, XrefRangeEnd = 1038101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(global::Il2CppSystem.Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00014474 File Offset: 0x00012674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038101, XrefRangeEnd = 1038107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(HighlightState other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightState.NativeMethodInfoPtr_Equals_Public_Boolean_HighlightState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000382A File Offset: 0x00001A2A
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, ref this));
		}

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeFieldInfoPtr_padding;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color32_TMP_Offset_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HighlightState_HighlightState_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HighlightState_HighlightState_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_HighlightState_0;

		// Token: 0x04000268 RID: 616
		[FieldOffset(0)]
		public Color32 color;

		// Token: 0x04000269 RID: 617
		[FieldOffset(4)]
		public TMP_Offset padding;
	}
}

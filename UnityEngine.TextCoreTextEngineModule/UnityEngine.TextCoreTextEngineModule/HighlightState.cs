using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200002A RID: 42
	[StructLayout(2)]
	public struct HighlightState
	{
		// Token: 0x0600046A RID: 1130 RVA: 0x0001374C File Offset: 0x0001194C
		// Note: this type is marked as 'beforefieldinit'.
		static HighlightState()
		{
			Il2CppClassPointerStore<HighlightState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "HighlightState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HighlightState>.NativeClassPtr);
			HighlightState.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, "color");
			HighlightState.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, "padding");
			HighlightState.NativeMethodInfoPtr__ctor_Public_Void_Color32_Offset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, 100663595);
			HighlightState.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HighlightState_HighlightState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, 100663596);
			HighlightState.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HighlightState_HighlightState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, 100663597);
			HighlightState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, 100663598);
			HighlightState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, 100663599);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00013808 File Offset: 0x00011A08
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1038077, RefRangeEnd = 1038087, XrefRangeStart = 1038077, XrefRangeEnd = 1038087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HighlightState(Color32 color, Offset padding)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padding;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightState.NativeMethodInfoPtr__ctor_Public_Void_Color32_Offset_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00013848 File Offset: 0x00011A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104543, XrefRangeEnd = 1104546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600046D RID: 1133 RVA: 0x00013894 File Offset: 0x00011A94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1104549, RefRangeEnd = 1104550, XrefRangeStart = 1104546, XrefRangeEnd = 1104549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600046E RID: 1134 RVA: 0x000138E0 File Offset: 0x00011AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104550, XrefRangeEnd = 1104554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00013910 File Offset: 0x00011B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104554, XrefRangeEnd = 1104558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
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

		// Token: 0x06000470 RID: 1136 RVA: 0x00004C81 File Offset: 0x00002E81
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, ref this));
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00013954 File Offset: 0x00011B54
		public bool Equals(HighlightState other)
		{
			return base.Equals(other);
		}

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeFieldInfoPtr_padding;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color32_Offset_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HighlightState_HighlightState_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HighlightState_HighlightState_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000371 RID: 881
		[FieldOffset(0)]
		public Color32 color;

		// Token: 0x04000372 RID: 882
		[FieldOffset(4)]
		public Offset padding;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200019A RID: 410
	[StructLayout(2)]
	public struct StyleFloat
	{
		// Token: 0x060021E3 RID: 8675 RVA: 0x00098B5C File Offset: 0x00096D5C
		// Note: this type is marked as 'beforefieldinit'.
		static StyleFloat()
		{
			Il2CppClassPointerStore<StyleFloat>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleFloat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleFloat>.NativeClassPtr);
			StyleFloat.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleFloat>.NativeClassPtr, "m_Value");
			StyleFloat.NativeFieldInfoPtr_m_Keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleFloat>.NativeClassPtr, "m_Keyword");
			StyleFloat.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFloat>.NativeClassPtr, 100668299);
			StyleFloat.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFloat>.NativeClassPtr, 100668300);
			StyleFloat.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFloat>.NativeClassPtr, 100668301);
			StyleFloat.NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFloat>.NativeClassPtr, 100668302);
			StyleFloat.NativeMethodInfoPtr__ctor_Internal_Void_Single_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFloat>.NativeClassPtr, 100668303);
			StyleFloat.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleFloat_StyleFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFloat>.NativeClassPtr, 100668304);
			StyleFloat.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleFloat_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFloat>.NativeClassPtr, 100668305);
			StyleFloat.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleFloat_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFloat>.NativeClassPtr, 100668306);
			StyleFloat.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFloat>.NativeClassPtr, 100668307);
			StyleFloat.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFloat>.NativeClassPtr, 100668308);
			StyleFloat.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFloat>.NativeClassPtr, 100668309);
			StyleFloat.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFloat>.NativeClassPtr, 100668310);
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x060021E4 RID: 8676 RVA: 0x00098CA4 File Offset: 0x00096EA4
		// (set) Token: 0x060021F1 RID: 8689 RVA: 0x0000E258 File Offset: 0x0000C458
		public unsafe float value
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 335476, RefRangeEnd = 335490, XrefRangeStart = 335476, XrefRangeEnd = 335476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFloat.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x060021E5 RID: 8677 RVA: 0x00098CD4 File Offset: 0x00096ED4
		// (set) Token: 0x060021F2 RID: 8690 RVA: 0x0000E269 File Offset: 0x0000C469
		public unsafe StyleKeyword keyword
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 283125, RefRangeEnd = 283150, XrefRangeStart = 283125, XrefRangeEnd = 283150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFloat.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Keyword = value;
			}
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x00098D04 File Offset: 0x00096F04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 335490, RefRangeEnd = 335492, XrefRangeStart = 335490, XrefRangeEnd = 335490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleFloat(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFloat.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x00098D38 File Offset: 0x00096F38
		[CallerCount(0)]
		public unsafe StyleFloat(StyleKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFloat.NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x00098D6C File Offset: 0x00096F6C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 286583, RefRangeEnd = 286597, XrefRangeStart = 286583, XrefRangeEnd = 286597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleFloat(float v, StyleKeyword keyword)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyword;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFloat.NativeMethodInfoPtr__ctor_Internal_Void_Single_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x00098DAC File Offset: 0x00096FAC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 335492, RefRangeEnd = 335496, XrefRangeStart = 335492, XrefRangeEnd = 335492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(StyleFloat lhs, StyleFloat rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFloat.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleFloat_StyleFloat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x00098DF8 File Offset: 0x00096FF8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 335496, RefRangeEnd = 335504, XrefRangeStart = 335496, XrefRangeEnd = 335496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator StyleFloat(StyleKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFloat.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleFloat_StyleKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x00098E38 File Offset: 0x00097038
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 323518, RefRangeEnd = 323546, XrefRangeStart = 323518, XrefRangeEnd = 323546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator StyleFloat(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFloat.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleFloat_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x00098E78 File Offset: 0x00097078
		[CallerCount(0)]
		public unsafe bool Equals(StyleFloat other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFloat.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleFloat_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x00098EB8 File Offset: 0x000970B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335504, XrefRangeEnd = 335507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFloat.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x00098EFC File Offset: 0x000970FC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 323589, RefRangeEnd = 323599, XrefRangeStart = 323589, XrefRangeEnd = 323599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFloat.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x00098F2C File Offset: 0x0009712C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335507, XrefRangeEnd = 335513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFloat.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x0000E246 File Offset: 0x0000C446
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleFloat>.NativeClassPtr, ref this));
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x00098F58 File Offset: 0x00097158
		public static bool operator !=(StyleFloat lhs, StyleFloat rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x040017CB RID: 6091
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x040017CC RID: 6092
		private static readonly IntPtr NativeFieldInfoPtr_m_Keyword;

		// Token: 0x040017CD RID: 6093
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x040017CE RID: 6094
		private static readonly IntPtr NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0;

		// Token: 0x040017CF RID: 6095
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x040017D0 RID: 6096
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0;

		// Token: 0x040017D1 RID: 6097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Single_StyleKeyword_0;

		// Token: 0x040017D2 RID: 6098
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleFloat_StyleFloat_0;

		// Token: 0x040017D3 RID: 6099
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_StyleFloat_StyleKeyword_0;

		// Token: 0x040017D4 RID: 6100
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_StyleFloat_Single_0;

		// Token: 0x040017D5 RID: 6101
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleFloat_0;

		// Token: 0x040017D6 RID: 6102
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040017D7 RID: 6103
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040017D8 RID: 6104
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040017D9 RID: 6105
		[FieldOffset(0)]
		public float m_Value;

		// Token: 0x040017DA RID: 6106
		[FieldOffset(4)]
		public StyleKeyword m_Keyword;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001A1 RID: 417
	[StructLayout(2)]
	public struct StyleTranslate
	{
		// Token: 0x06002261 RID: 8801 RVA: 0x0009A870 File Offset: 0x00098A70
		// Note: this type is marked as 'beforefieldinit'.
		static StyleTranslate()
		{
			Il2CppClassPointerStore<StyleTranslate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleTranslate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleTranslate>.NativeClassPtr);
			StyleTranslate.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleTranslate>.NativeClassPtr, "m_Value");
			StyleTranslate.NativeFieldInfoPtr_m_Keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleTranslate>.NativeClassPtr, "m_Keyword");
			StyleTranslate.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Translate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTranslate>.NativeClassPtr, 100668373);
			StyleTranslate.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTranslate>.NativeClassPtr, 100668374);
			StyleTranslate.NativeMethodInfoPtr__ctor_Public_Void_Translate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTranslate>.NativeClassPtr, 100668375);
			StyleTranslate.NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTranslate>.NativeClassPtr, 100668376);
			StyleTranslate.NativeMethodInfoPtr__ctor_Internal_Void_Translate_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTranslate>.NativeClassPtr, 100668377);
			StyleTranslate.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleTranslate_StyleTranslate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTranslate>.NativeClassPtr, 100668378);
			StyleTranslate.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleTranslate_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTranslate>.NativeClassPtr, 100668379);
			StyleTranslate.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleTranslate_Translate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTranslate>.NativeClassPtr, 100668380);
			StyleTranslate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleTranslate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTranslate>.NativeClassPtr, 100668381);
			StyleTranslate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTranslate>.NativeClassPtr, 100668382);
			StyleTranslate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTranslate>.NativeClassPtr, 100668383);
			StyleTranslate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTranslate>.NativeClassPtr, 100668384);
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06002262 RID: 8802 RVA: 0x0009A9B8 File Offset: 0x00098BB8
		// (set) Token: 0x0600226F RID: 8815 RVA: 0x0000E40D File Offset: 0x0000C60D
		public unsafe Translate value
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 335794, RefRangeEnd = 335800, XrefRangeStart = 335794, XrefRangeEnd = 335794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTranslate.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Translate_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06002263 RID: 8803 RVA: 0x0009A9E8 File Offset: 0x00098BE8
		// (set) Token: 0x06002270 RID: 8816 RVA: 0x0000E41E File Offset: 0x0000C61E
		public unsafe StyleKeyword keyword
		{
			[CallerCount(66)]
			[CachedScanResults(RefRangeStart = 320372, RefRangeEnd = 320438, XrefRangeStart = 320372, XrefRangeEnd = 320438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTranslate.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Keyword = value;
			}
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x0009AA18 File Offset: 0x00098C18
		[CallerCount(0)]
		public unsafe StyleTranslate(Translate v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTranslate.NativeMethodInfoPtr__ctor_Public_Void_Translate_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x0009AA4C File Offset: 0x00098C4C
		[CallerCount(0)]
		public unsafe StyleTranslate(StyleKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTranslate.NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x0009AA80 File Offset: 0x00098C80
		[CallerCount(0)]
		public unsafe StyleTranslate(Translate v, StyleKeyword keyword)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyword;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTranslate.NativeMethodInfoPtr__ctor_Internal_Void_Translate_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x0009AAC0 File Offset: 0x00098CC0
		[CallerCount(0)]
		public unsafe static bool operator ==(StyleTranslate lhs, StyleTranslate rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTranslate.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleTranslate_StyleTranslate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x0009AB0C File Offset: 0x00098D0C
		[CallerCount(0)]
		public unsafe static implicit operator StyleTranslate(StyleKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTranslate.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleTranslate_StyleKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x0009AB4C File Offset: 0x00098D4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335800, RefRangeEnd = 335801, XrefRangeStart = 335800, XrefRangeEnd = 335800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator StyleTranslate(Translate v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTranslate.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleTranslate_Translate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x0009AB8C File Offset: 0x00098D8C
		[CallerCount(0)]
		public unsafe bool Equals(StyleTranslate other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTranslate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleTranslate_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x0009ABCC File Offset: 0x00098DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335801, XrefRangeEnd = 335805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTranslate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x0009AC10 File Offset: 0x00098E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335805, XrefRangeEnd = 335806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTranslate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x0009AC40 File Offset: 0x00098E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335806, XrefRangeEnd = 335812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTranslate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x0000E3FB File Offset: 0x0000C5FB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleTranslate>.NativeClassPtr, ref this));
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x0009AC6C File Offset: 0x00098E6C
		public static bool operator !=(StyleTranslate lhs, StyleTranslate rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x0400182D RID: 6189
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x0400182E RID: 6190
		private static readonly IntPtr NativeFieldInfoPtr_m_Keyword;

		// Token: 0x0400182F RID: 6191
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Translate_0;

		// Token: 0x04001830 RID: 6192
		private static readonly IntPtr NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0;

		// Token: 0x04001831 RID: 6193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Translate_0;

		// Token: 0x04001832 RID: 6194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0;

		// Token: 0x04001833 RID: 6195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Translate_StyleKeyword_0;

		// Token: 0x04001834 RID: 6196
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleTranslate_StyleTranslate_0;

		// Token: 0x04001835 RID: 6197
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_StyleTranslate_StyleKeyword_0;

		// Token: 0x04001836 RID: 6198
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_StyleTranslate_Translate_0;

		// Token: 0x04001837 RID: 6199
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleTranslate_0;

		// Token: 0x04001838 RID: 6200
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001839 RID: 6201
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400183A RID: 6202
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400183B RID: 6203
		[FieldOffset(0)]
		public Translate m_Value;

		// Token: 0x0400183C RID: 6204
		[FieldOffset(24)]
		public StyleKeyword m_Keyword;
	}
}

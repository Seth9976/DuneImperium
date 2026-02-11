using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000197 RID: 407
	public sealed class StyleCursor : ValueType
	{
		// Token: 0x060021A5 RID: 8613 RVA: 0x00097AFC File Offset: 0x00095CFC
		// Note: this type is marked as 'beforefieldinit'.
		static StyleCursor()
		{
			Il2CppClassPointerStore<StyleCursor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleCursor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr);
			StyleCursor.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, "m_Value");
			StyleCursor.NativeFieldInfoPtr_m_Keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, "m_Keyword");
			StyleCursor.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Cursor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, 100668259);
			StyleCursor.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, 100668260);
			StyleCursor.NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, 100668261);
			StyleCursor.NativeMethodInfoPtr__ctor_Internal_Void_Cursor_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, 100668262);
			StyleCursor.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleCursor_StyleCursor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, 100668263);
			StyleCursor.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleCursor_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, 100668264);
			StyleCursor.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleCursor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, 100668265);
			StyleCursor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, 100668266);
			StyleCursor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, 100668267);
			StyleCursor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, 100668268);
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x060021A6 RID: 8614 RVA: 0x00097C1C File Offset: 0x00095E1C
		// (set) Token: 0x060021B6 RID: 8630 RVA: 0x0000E178 File Offset: 0x0000C378
		public unsafe Cursor value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 334659, RefRangeEnd = 334660, XrefRangeStart = 334659, XrefRangeEnd = 334659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleCursor.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Cursor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Cursor(intPtr);
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x060021A7 RID: 8615 RVA: 0x00097C58 File Offset: 0x00095E58
		// (set) Token: 0x060021B7 RID: 8631 RVA: 0x0000E189 File Offset: 0x0000C389
		public unsafe StyleKeyword keyword
		{
			[CallerCount(66)]
			[CachedScanResults(RefRangeStart = 320372, RefRangeEnd = 320438, XrefRangeStart = 320372, XrefRangeEnd = 320438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleCursor.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Keyword = value;
			}
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x00097C9C File Offset: 0x00095E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334660, XrefRangeEnd = 334661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleCursor(StyleKeyword keyword)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleCursor.NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x00097CE8 File Offset: 0x00095EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334661, XrefRangeEnd = 334662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleCursor(Cursor v, StyleKeyword keyword)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(v));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyword;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleCursor.NativeMethodInfoPtr__ctor_Internal_Void_Cursor_StyleKeyword_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x00097D4C File Offset: 0x00095F4C
		[CallerCount(0)]
		public unsafe static bool operator ==(StyleCursor lhs, StyleCursor rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lhs));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleCursor.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleCursor_StyleCursor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x00097DAC File Offset: 0x00095FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334662, XrefRangeEnd = 334663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator StyleCursor(StyleKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleCursor.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleCursor_StyleKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new StyleCursor(intPtr);
			}
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x00097DE4 File Offset: 0x00095FE4
		[CallerCount(0)]
		public unsafe bool Equals(StyleCursor other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleCursor.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleCursor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x00097E3C File Offset: 0x0009603C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334663, XrefRangeEnd = 334667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleCursor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x00097E90 File Offset: 0x00096090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334667, XrefRangeEnd = 334668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleCursor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x00097ED4 File Offset: 0x000960D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334668, XrefRangeEnd = 334674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleCursor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x0000E114 File Offset: 0x0000C314
		public StyleCursor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x0000E11D File Offset: 0x0000C31D
		public StyleCursor()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr))
		{
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x060021B2 RID: 8626 RVA: 0x00097F10 File Offset: 0x00096110
		// (set) Token: 0x060021B3 RID: 8627 RVA: 0x0000E12F File Offset: 0x0000C32F
		public Cursor m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleCursor.NativeFieldInfoPtr_m_Value);
				return new Cursor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Cursor>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleCursor.NativeFieldInfoPtr_m_Value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Cursor>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x060021B4 RID: 8628 RVA: 0x00097F40 File Offset: 0x00096140
		// (set) Token: 0x060021B5 RID: 8629 RVA: 0x0000E15D File Offset: 0x0000C35D
		public unsafe StyleKeyword m_Keyword
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleCursor.NativeFieldInfoPtr_m_Keyword);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleCursor.NativeFieldInfoPtr_m_Keyword)) = value;
			}
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x00097F68 File Offset: 0x00096168
		public static bool operator !=(StyleCursor lhs, StyleCursor rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x00097F84 File Offset: 0x00096184
		public static implicit operator StyleCursor(Cursor v)
		{
			return new StyleCursor(v);
		}

		// Token: 0x040017A4 RID: 6052
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x040017A5 RID: 6053
		private static readonly IntPtr NativeFieldInfoPtr_m_Keyword;

		// Token: 0x040017A6 RID: 6054
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Cursor_0;

		// Token: 0x040017A7 RID: 6055
		private static readonly IntPtr NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0;

		// Token: 0x040017A8 RID: 6056
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0;

		// Token: 0x040017A9 RID: 6057
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Cursor_StyleKeyword_0;

		// Token: 0x040017AA RID: 6058
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleCursor_StyleCursor_0;

		// Token: 0x040017AB RID: 6059
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_StyleCursor_StyleKeyword_0;

		// Token: 0x040017AC RID: 6060
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleCursor_0;

		// Token: 0x040017AD RID: 6061
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040017AE RID: 6062
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040017AF RID: 6063
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}

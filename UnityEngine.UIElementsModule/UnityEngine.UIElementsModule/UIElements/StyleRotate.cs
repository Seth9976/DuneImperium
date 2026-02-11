using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200019F RID: 415
	[StructLayout(2)]
	public struct StyleRotate
	{
		// Token: 0x06002240 RID: 8768 RVA: 0x0009A128 File Offset: 0x00098328
		// Note: this type is marked as 'beforefieldinit'.
		static StyleRotate()
		{
			Il2CppClassPointerStore<StyleRotate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleRotate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleRotate>.NativeClassPtr);
			StyleRotate.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleRotate>.NativeClassPtr, "m_Value");
			StyleRotate.NativeFieldInfoPtr_m_Keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleRotate>.NativeClassPtr, "m_Keyword");
			StyleRotate.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Rotate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleRotate>.NativeClassPtr, 100668353);
			StyleRotate.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleRotate>.NativeClassPtr, 100668354);
			StyleRotate.NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleRotate>.NativeClassPtr, 100668355);
			StyleRotate.NativeMethodInfoPtr__ctor_Internal_Void_Rotate_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleRotate>.NativeClassPtr, 100668356);
			StyleRotate.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleRotate_StyleRotate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleRotate>.NativeClassPtr, 100668357);
			StyleRotate.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleRotate_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleRotate>.NativeClassPtr, 100668358);
			StyleRotate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleRotate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleRotate>.NativeClassPtr, 100668359);
			StyleRotate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleRotate>.NativeClassPtr, 100668360);
			StyleRotate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleRotate>.NativeClassPtr, 100668361);
			StyleRotate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleRotate>.NativeClassPtr, 100668362);
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06002241 RID: 8769 RVA: 0x0009A248 File Offset: 0x00098448
		// (set) Token: 0x0600224C RID: 8780 RVA: 0x0000E3B3 File Offset: 0x0000C5B3
		public unsafe Rotate value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 335768, RefRangeEnd = 335769, XrefRangeStart = 335765, XrefRangeEnd = 335768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleRotate.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Rotate_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x0009A278 File Offset: 0x00098478
		// (set) Token: 0x0600224D RID: 8781 RVA: 0x0000E3C4 File Offset: 0x0000C5C4
		public unsafe StyleKeyword keyword
		{
			[CallerCount(66)]
			[CachedScanResults(RefRangeStart = 320372, RefRangeEnd = 320438, XrefRangeStart = 320372, XrefRangeEnd = 320438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleRotate.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Keyword = value;
			}
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x0009A2A8 File Offset: 0x000984A8
		[CallerCount(0)]
		public unsafe StyleRotate(StyleKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleRotate.NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x0009A2DC File Offset: 0x000984DC
		[CallerCount(0)]
		public unsafe StyleRotate(Rotate v, StyleKeyword keyword)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyword;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleRotate.NativeMethodInfoPtr__ctor_Internal_Void_Rotate_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x0009A31C File Offset: 0x0009851C
		[CallerCount(0)]
		public unsafe static bool operator ==(StyleRotate lhs, StyleRotate rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleRotate.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleRotate_StyleRotate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x0009A368 File Offset: 0x00098568
		[CallerCount(0)]
		public unsafe static implicit operator StyleRotate(StyleKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleRotate.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleRotate_StyleKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x0009A3A8 File Offset: 0x000985A8
		[CallerCount(0)]
		public unsafe bool Equals(StyleRotate other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleRotate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleRotate_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x0009A3E8 File Offset: 0x000985E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335769, XrefRangeEnd = 335773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleRotate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x0009A42C File Offset: 0x0009862C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335773, XrefRangeEnd = 335774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleRotate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x0009A45C File Offset: 0x0009865C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335774, XrefRangeEnd = 335780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleRotate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600224B RID: 8779 RVA: 0x0000E3A1 File Offset: 0x0000C5A1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleRotate>.NativeClassPtr, ref this));
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x0009A488 File Offset: 0x00098688
		public static bool operator !=(StyleRotate lhs, StyleRotate rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x0009A4A4 File Offset: 0x000986A4
		public static implicit operator StyleRotate(Rotate v)
		{
			return new StyleRotate(v);
		}

		// Token: 0x04001811 RID: 6161
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x04001812 RID: 6162
		private static readonly IntPtr NativeFieldInfoPtr_m_Keyword;

		// Token: 0x04001813 RID: 6163
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Rotate_0;

		// Token: 0x04001814 RID: 6164
		private static readonly IntPtr NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0;

		// Token: 0x04001815 RID: 6165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0;

		// Token: 0x04001816 RID: 6166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Rotate_StyleKeyword_0;

		// Token: 0x04001817 RID: 6167
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleRotate_StyleRotate_0;

		// Token: 0x04001818 RID: 6168
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_StyleRotate_StyleKeyword_0;

		// Token: 0x04001819 RID: 6169
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleRotate_0;

		// Token: 0x0400181A RID: 6170
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400181B RID: 6171
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400181C RID: 6172
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400181D RID: 6173
		[FieldOffset(0)]
		public Rotate m_Value;

		// Token: 0x0400181E RID: 6174
		[FieldOffset(24)]
		public StyleKeyword m_Keyword;
	}
}

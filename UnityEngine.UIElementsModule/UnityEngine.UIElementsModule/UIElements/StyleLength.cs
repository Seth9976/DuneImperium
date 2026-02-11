using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200019E RID: 414
	[StructLayout(2)]
	public struct StyleLength
	{
		// Token: 0x0600222D RID: 8749 RVA: 0x00099BC8 File Offset: 0x00097DC8
		// Note: this type is marked as 'beforefieldinit'.
		static StyleLength()
		{
			Il2CppClassPointerStore<StyleLength>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleLength");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleLength>.NativeClassPtr);
			StyleLength.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleLength>.NativeClassPtr, "m_Value");
			StyleLength.NativeFieldInfoPtr_m_Keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleLength>.NativeClassPtr, "m_Keyword");
			StyleLength.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleLength>.NativeClassPtr, 100668339);
			StyleLength.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleLength>.NativeClassPtr, 100668340);
			StyleLength.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleLength>.NativeClassPtr, 100668341);
			StyleLength.NativeMethodInfoPtr__ctor_Public_Void_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleLength>.NativeClassPtr, 100668342);
			StyleLength.NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleLength>.NativeClassPtr, 100668343);
			StyleLength.NativeMethodInfoPtr__ctor_Internal_Void_Length_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleLength>.NativeClassPtr, 100668344);
			StyleLength.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleLength_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleLength>.NativeClassPtr, 100668345);
			StyleLength.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleLength_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleLength>.NativeClassPtr, 100668346);
			StyleLength.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleLength_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleLength>.NativeClassPtr, 100668347);
			StyleLength.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleLength_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleLength>.NativeClassPtr, 100668348);
			StyleLength.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleLength>.NativeClassPtr, 100668349);
			StyleLength.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleLength>.NativeClassPtr, 100668350);
			StyleLength.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleLength>.NativeClassPtr, 100668351);
			StyleLength.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleLength>.NativeClassPtr, 100668352);
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x0600222E RID: 8750 RVA: 0x00099D38 File Offset: 0x00097F38
		// (set) Token: 0x0600223D RID: 8765 RVA: 0x0009A060 File Offset: 0x00098260
		public unsafe Length value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 335591, RefRangeEnd = 335592, XrefRangeStart = 335591, XrefRangeEnd = 335591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleLength.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Length_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = value.IsAuto();
				if (flag)
				{
					this.m_Keyword = StyleKeyword.Auto;
				}
				else
				{
					bool flag2 = value.IsNone();
					if (flag2)
					{
						this.m_Keyword = StyleKeyword.None;
					}
					else
					{
						this.m_Keyword = StyleKeyword.Undefined;
					}
				}
				this.m_Value = value;
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x0600222F RID: 8751 RVA: 0x00099D68 File Offset: 0x00097F68
		// (set) Token: 0x0600223E RID: 8766 RVA: 0x0009A0A4 File Offset: 0x000982A4
		public unsafe StyleKeyword keyword
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 335516, RefRangeEnd = 335543, XrefRangeStart = 335516, XrefRangeEnd = 335543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleLength.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Keyword = value;
				bool flag = this.m_Keyword == StyleKeyword.Auto;
				if (flag)
				{
					this.m_Value = Length.Auto();
				}
				else
				{
					bool flag2 = this.m_Keyword == StyleKeyword.None;
					if (flag2)
					{
						this.m_Value = Length.None();
					}
					else
					{
						bool flag3 = this.m_Keyword > StyleKeyword.Undefined;
						if (flag3)
						{
							this.m_Value = default(Length);
						}
					}
				}
			}
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x00099D98 File Offset: 0x00097F98
		[CallerCount(0)]
		public unsafe StyleLength(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleLength.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x00099DCC File Offset: 0x00097FCC
		[CallerCount(0)]
		public unsafe StyleLength(Length v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleLength.NativeMethodInfoPtr__ctor_Public_Void_Length_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002232 RID: 8754 RVA: 0x00099E00 File Offset: 0x00098000
		[CallerCount(0)]
		public unsafe StyleLength(StyleKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleLength.NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002233 RID: 8755 RVA: 0x00099E34 File Offset: 0x00098034
		[CallerCount(0)]
		public unsafe StyleLength(Length v, StyleKeyword keyword)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyword;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleLength.NativeMethodInfoPtr__ctor_Internal_Void_Length_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002234 RID: 8756 RVA: 0x00099E74 File Offset: 0x00098074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335592, RefRangeEnd = 335593, XrefRangeStart = 335592, XrefRangeEnd = 335592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(StyleLength lhs, StyleLength rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleLength.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleLength_StyleLength_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002235 RID: 8757 RVA: 0x00099EC0 File Offset: 0x000980C0
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 335593, RefRangeEnd = 335617, XrefRangeStart = 335593, XrefRangeEnd = 335593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator StyleLength(StyleKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleLength.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleLength_StyleKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x00099F00 File Offset: 0x00098100
		[CallerCount(133)]
		[CachedScanResults(RefRangeStart = 335618, RefRangeEnd = 335751, XrefRangeStart = 335617, XrefRangeEnd = 335618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator StyleLength(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleLength.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleLength_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x00099F40 File Offset: 0x00098140
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 335752, RefRangeEnd = 335755, XrefRangeStart = 335751, XrefRangeEnd = 335752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator StyleLength(Length v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleLength.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleLength_Length_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x00099F80 File Offset: 0x00098180
		[CallerCount(0)]
		public unsafe bool Equals(StyleLength other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleLength.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleLength_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x00099FC0 File Offset: 0x000981C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335755, XrefRangeEnd = 335758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleLength.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x0009A004 File Offset: 0x00098204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335758, XrefRangeEnd = 335759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleLength.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x0009A034 File Offset: 0x00098234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335759, XrefRangeEnd = 335765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleLength.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x0000E38F File Offset: 0x0000C58F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleLength>.NativeClassPtr, ref this));
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x0009A10C File Offset: 0x0009830C
		public static bool operator !=(StyleLength lhs, StyleLength rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x040017FF RID: 6143
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x04001800 RID: 6144
		private static readonly IntPtr NativeFieldInfoPtr_m_Keyword;

		// Token: 0x04001801 RID: 6145
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Length_0;

		// Token: 0x04001802 RID: 6146
		private static readonly IntPtr NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0;

		// Token: 0x04001803 RID: 6147
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04001804 RID: 6148
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Length_0;

		// Token: 0x04001805 RID: 6149
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0;

		// Token: 0x04001806 RID: 6150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Length_StyleKeyword_0;

		// Token: 0x04001807 RID: 6151
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleLength_StyleLength_0;

		// Token: 0x04001808 RID: 6152
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_StyleLength_StyleKeyword_0;

		// Token: 0x04001809 RID: 6153
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_StyleLength_Single_0;

		// Token: 0x0400180A RID: 6154
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_StyleLength_Length_0;

		// Token: 0x0400180B RID: 6155
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleLength_0;

		// Token: 0x0400180C RID: 6156
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400180D RID: 6157
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400180E RID: 6158
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400180F RID: 6159
		[FieldOffset(0)]
		public Length m_Value;

		// Token: 0x04001810 RID: 6160
		[FieldOffset(8)]
		public StyleKeyword m_Keyword;
	}
}

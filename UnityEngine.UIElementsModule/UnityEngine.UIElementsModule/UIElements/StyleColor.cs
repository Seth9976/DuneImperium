using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000196 RID: 406
	[StructLayout(2)]
	public struct StyleColor
	{
		// Token: 0x06002193 RID: 8595 RVA: 0x00097728 File Offset: 0x00095928
		// Note: this type is marked as 'beforefieldinit'.
		static StyleColor()
		{
			Il2CppClassPointerStore<StyleColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleColor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleColor>.NativeClassPtr);
			StyleColor.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleColor>.NativeClassPtr, "m_Value");
			StyleColor.NativeFieldInfoPtr_m_Keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleColor>.NativeClassPtr, "m_Keyword");
			StyleColor.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleColor>.NativeClassPtr, 100668249);
			StyleColor.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleColor>.NativeClassPtr, 100668250);
			StyleColor.NativeMethodInfoPtr__ctor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleColor>.NativeClassPtr, 100668251);
			StyleColor.NativeMethodInfoPtr__ctor_Internal_Void_Color_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleColor>.NativeClassPtr, 100668252);
			StyleColor.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleColor_StyleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleColor>.NativeClassPtr, 100668253);
			StyleColor.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleColor_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleColor>.NativeClassPtr, 100668254);
			StyleColor.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleColor>.NativeClassPtr, 100668255);
			StyleColor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleColor>.NativeClassPtr, 100668256);
			StyleColor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleColor>.NativeClassPtr, 100668257);
			StyleColor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleColor>.NativeClassPtr, 100668258);
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06002194 RID: 8596 RVA: 0x00097848 File Offset: 0x00095A48
		// (set) Token: 0x0600219F RID: 8607 RVA: 0x0000E0F9 File Offset: 0x0000C2F9
		public unsafe Color value
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 334598, RefRangeEnd = 334600, XrefRangeStart = 334598, XrefRangeEnd = 334598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleColor.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Color_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06002195 RID: 8597 RVA: 0x00097878 File Offset: 0x00095A78
		// (set) Token: 0x060021A0 RID: 8608 RVA: 0x0000E10A File Offset: 0x0000C30A
		public unsafe StyleKeyword keyword
		{
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 334600, RefRangeEnd = 334642, XrefRangeStart = 334600, XrefRangeEnd = 334600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleColor.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Keyword = value;
			}
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x000978A8 File Offset: 0x00095AA8
		[CallerCount(0)]
		public unsafe StyleColor(Color v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleColor.NativeMethodInfoPtr__ctor_Public_Void_Color_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x000978DC File Offset: 0x00095ADC
		[CallerCount(0)]
		public unsafe StyleColor(Color v, StyleKeyword keyword)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyword;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleColor.NativeMethodInfoPtr__ctor_Internal_Void_Color_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x0009791C File Offset: 0x00095B1C
		[CallerCount(0)]
		public unsafe static bool operator ==(StyleColor lhs, StyleColor rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleColor.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleColor_StyleColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x00097968 File Offset: 0x00095B68
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 334642, RefRangeEnd = 334649, XrefRangeStart = 334642, XrefRangeEnd = 334642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator StyleColor(Color v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleColor.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleColor_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x000979A8 File Offset: 0x00095BA8
		[CallerCount(0)]
		public unsafe bool Equals(StyleColor other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleColor.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleColor_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x000979E8 File Offset: 0x00095BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334649, XrefRangeEnd = 334652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleColor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x00097A2C File Offset: 0x00095C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334652, XrefRangeEnd = 334653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleColor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x00097A5C File Offset: 0x00095C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334653, XrefRangeEnd = 334659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleColor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x0000E0E7 File Offset: 0x0000C2E7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleColor>.NativeClassPtr, ref this));
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x00097A88 File Offset: 0x00095C88
		public static bool operator !=(StyleColor lhs, StyleColor rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x00097AA4 File Offset: 0x00095CA4
		public static bool operator ==(StyleColor lhs, Color rhs)
		{
			StyleColor styleColor = new StyleColor(rhs);
			return lhs == styleColor;
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x00097AC8 File Offset: 0x00095CC8
		public static bool operator !=(StyleColor lhs, Color rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x00097AE4 File Offset: 0x00095CE4
		public static implicit operator StyleColor(StyleKeyword keyword)
		{
			return new StyleColor(keyword);
		}

		// Token: 0x04001796 RID: 6038
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x04001797 RID: 6039
		private static readonly IntPtr NativeFieldInfoPtr_m_Keyword;

		// Token: 0x04001798 RID: 6040
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Color_0;

		// Token: 0x04001799 RID: 6041
		private static readonly IntPtr NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0;

		// Token: 0x0400179A RID: 6042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_0;

		// Token: 0x0400179B RID: 6043
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Color_StyleKeyword_0;

		// Token: 0x0400179C RID: 6044
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleColor_StyleColor_0;

		// Token: 0x0400179D RID: 6045
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_StyleColor_Color_0;

		// Token: 0x0400179E RID: 6046
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleColor_0;

		// Token: 0x0400179F RID: 6047
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040017A0 RID: 6048
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040017A1 RID: 6049
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040017A2 RID: 6050
		[FieldOffset(0)]
		public Color m_Value;

		// Token: 0x040017A3 RID: 6051
		[FieldOffset(16)]
		public StyleKeyword m_Keyword;
	}
}

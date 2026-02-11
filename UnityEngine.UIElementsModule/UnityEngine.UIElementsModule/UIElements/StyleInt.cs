using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200019D RID: 413
	[StructLayout(2)]
	public struct StyleInt
	{
		// Token: 0x0600221D RID: 8733 RVA: 0x00099834 File Offset: 0x00097A34
		// Note: this type is marked as 'beforefieldinit'.
		static StyleInt()
		{
			Il2CppClassPointerStore<StyleInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleInt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleInt>.NativeClassPtr);
			StyleInt.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleInt>.NativeClassPtr, "m_Value");
			StyleInt.NativeFieldInfoPtr_m_Keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleInt>.NativeClassPtr, "m_Keyword");
			StyleInt.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleInt>.NativeClassPtr, 100668329);
			StyleInt.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleInt>.NativeClassPtr, 100668330);
			StyleInt.NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleInt>.NativeClassPtr, 100668331);
			StyleInt.NativeMethodInfoPtr__ctor_Internal_Void_Int32_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleInt>.NativeClassPtr, 100668332);
			StyleInt.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleInt_StyleInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleInt>.NativeClassPtr, 100668333);
			StyleInt.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleInt_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleInt>.NativeClassPtr, 100668334);
			StyleInt.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleInt>.NativeClassPtr, 100668335);
			StyleInt.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleInt>.NativeClassPtr, 100668336);
			StyleInt.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleInt>.NativeClassPtr, 100668337);
			StyleInt.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleInt>.NativeClassPtr, 100668338);
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x0600221E RID: 8734 RVA: 0x00099954 File Offset: 0x00097B54
		// (set) Token: 0x06002229 RID: 8745 RVA: 0x0000E374 File Offset: 0x0000C574
		public unsafe int value
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 335396, RefRangeEnd = 335399, XrefRangeStart = 335396, XrefRangeEnd = 335399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleInt.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x0600221F RID: 8735 RVA: 0x00099984 File Offset: 0x00097B84
		// (set) Token: 0x0600222A RID: 8746 RVA: 0x0000E385 File Offset: 0x0000C585
		public unsafe StyleKeyword keyword
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 283125, RefRangeEnd = 283150, XrefRangeStart = 283125, XrefRangeEnd = 283150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleInt.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Keyword = value;
			}
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x000999B4 File Offset: 0x00097BB4
		[CallerCount(0)]
		public unsafe StyleInt(StyleKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleInt.NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x000999E8 File Offset: 0x00097BE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 335401, RefRangeEnd = 335403, XrefRangeStart = 335401, XrefRangeEnd = 335403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleInt(int v, StyleKeyword keyword)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyword;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleInt.NativeMethodInfoPtr__ctor_Internal_Void_Int32_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x00099A28 File Offset: 0x00097C28
		[CallerCount(0)]
		public unsafe static bool operator ==(StyleInt lhs, StyleInt rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleInt.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleInt_StyleInt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002223 RID: 8739 RVA: 0x00099A74 File Offset: 0x00097C74
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 335496, RefRangeEnd = 335504, XrefRangeStart = 335496, XrefRangeEnd = 335504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator StyleInt(StyleKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleInt.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleInt_StyleKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x00099AB4 File Offset: 0x00097CB4
		[CallerCount(0)]
		public unsafe bool Equals(StyleInt other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleInt.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleInt_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x00099AF4 File Offset: 0x00097CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335582, XrefRangeEnd = 335585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleInt.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x00099B38 File Offset: 0x00097D38
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleInt.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x00099B68 File Offset: 0x00097D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335585, XrefRangeEnd = 335591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleInt.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x0000E362 File Offset: 0x0000C562
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleInt>.NativeClassPtr, ref this));
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x00099B94 File Offset: 0x00097D94
		public static bool operator !=(StyleInt lhs, StyleInt rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x00099BB0 File Offset: 0x00097DB0
		public static implicit operator StyleInt(int v)
		{
			return new StyleInt(v);
		}

		// Token: 0x040017F1 RID: 6129
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x040017F2 RID: 6130
		private static readonly IntPtr NativeFieldInfoPtr_m_Keyword;

		// Token: 0x040017F3 RID: 6131
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040017F4 RID: 6132
		private static readonly IntPtr NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0;

		// Token: 0x040017F5 RID: 6133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0;

		// Token: 0x040017F6 RID: 6134
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_StyleKeyword_0;

		// Token: 0x040017F7 RID: 6135
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleInt_StyleInt_0;

		// Token: 0x040017F8 RID: 6136
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_StyleInt_StyleKeyword_0;

		// Token: 0x040017F9 RID: 6137
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleInt_0;

		// Token: 0x040017FA RID: 6138
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040017FB RID: 6139
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040017FC RID: 6140
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040017FD RID: 6141
		[FieldOffset(0)]
		public int m_Value;

		// Token: 0x040017FE RID: 6142
		[FieldOffset(4)]
		public StyleKeyword m_Keyword;
	}
}

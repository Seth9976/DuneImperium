using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001A2 RID: 418
	[StructLayout(2)]
	public struct StyleTextShadow
	{
		// Token: 0x06002272 RID: 8818 RVA: 0x0009AC88 File Offset: 0x00098E88
		// Note: this type is marked as 'beforefieldinit'.
		static StyleTextShadow()
		{
			Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleTextShadow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr);
			StyleTextShadow.NativeFieldInfoPtr_m_Keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr, "m_Keyword");
			StyleTextShadow.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr, "m_Value");
			StyleTextShadow.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_TextShadow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr, 100668385);
			StyleTextShadow.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr, 100668386);
			StyleTextShadow.NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr, 100668387);
			StyleTextShadow.NativeMethodInfoPtr__ctor_Internal_Void_TextShadow_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr, 100668388);
			StyleTextShadow.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleTextShadow_StyleTextShadow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr, 100668389);
			StyleTextShadow.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleTextShadow_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr, 100668390);
			StyleTextShadow.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleTextShadow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr, 100668391);
			StyleTextShadow.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr, 100668392);
			StyleTextShadow.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr, 100668393);
			StyleTextShadow.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr, 100668394);
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06002273 RID: 8819 RVA: 0x0009ADA8 File Offset: 0x00098FA8
		// (set) Token: 0x0600227E RID: 8830 RVA: 0x0000E43A File Offset: 0x0000C63A
		public unsafe TextShadow value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 335812, RefRangeEnd = 335813, XrefRangeStart = 335812, XrefRangeEnd = 335812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTextShadow.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_TextShadow_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06002274 RID: 8820 RVA: 0x0009ADD8 File Offset: 0x00098FD8
		// (set) Token: 0x0600227F RID: 8831 RVA: 0x0000E44B File Offset: 0x0000C64B
		public unsafe StyleKeyword keyword
		{
			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTextShadow.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Keyword = value;
			}
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x0009AE08 File Offset: 0x00099008
		[CallerCount(0)]
		public unsafe StyleTextShadow(StyleKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTextShadow.NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x0009AE3C File Offset: 0x0009903C
		[CallerCount(0)]
		public unsafe StyleTextShadow(TextShadow v, StyleKeyword keyword)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyword;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTextShadow.NativeMethodInfoPtr__ctor_Internal_Void_TextShadow_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x0009AE7C File Offset: 0x0009907C
		[CallerCount(0)]
		public unsafe static bool operator ==(StyleTextShadow lhs, StyleTextShadow rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTextShadow.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleTextShadow_StyleTextShadow_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x0009AEC8 File Offset: 0x000990C8
		[CallerCount(0)]
		public unsafe static implicit operator StyleTextShadow(StyleKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTextShadow.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleTextShadow_StyleKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x0009AF08 File Offset: 0x00099108
		[CallerCount(0)]
		public unsafe bool Equals(StyleTextShadow other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTextShadow.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleTextShadow_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x0009AF48 File Offset: 0x00099148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335813, XrefRangeEnd = 335817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTextShadow.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x0009AF8C File Offset: 0x0009918C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335817, XrefRangeEnd = 335819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTextShadow.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x0009AFBC File Offset: 0x000991BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335819, XrefRangeEnd = 335825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTextShadow.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x0000E428 File Offset: 0x0000C628
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr, ref this));
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x0009AFE8 File Offset: 0x000991E8
		public static bool operator !=(StyleTextShadow lhs, StyleTextShadow rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x0009B004 File Offset: 0x00099204
		public static implicit operator StyleTextShadow(TextShadow v)
		{
			return new StyleTextShadow(v);
		}

		// Token: 0x0400183D RID: 6205
		private static readonly IntPtr NativeFieldInfoPtr_m_Keyword;

		// Token: 0x0400183E RID: 6206
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x0400183F RID: 6207
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_TextShadow_0;

		// Token: 0x04001840 RID: 6208
		private static readonly IntPtr NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0;

		// Token: 0x04001841 RID: 6209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0;

		// Token: 0x04001842 RID: 6210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TextShadow_StyleKeyword_0;

		// Token: 0x04001843 RID: 6211
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleTextShadow_StyleTextShadow_0;

		// Token: 0x04001844 RID: 6212
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_StyleTextShadow_StyleKeyword_0;

		// Token: 0x04001845 RID: 6213
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleTextShadow_0;

		// Token: 0x04001846 RID: 6214
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001847 RID: 6215
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001848 RID: 6216
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001849 RID: 6217
		[FieldOffset(0)]
		public StyleKeyword m_Keyword;

		// Token: 0x0400184A RID: 6218
		[FieldOffset(4)]
		public TextShadow m_Value;
	}
}

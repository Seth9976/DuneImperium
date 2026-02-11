using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001A0 RID: 416
	[StructLayout(2)]
	public struct StyleScale
	{
		// Token: 0x06002250 RID: 8784 RVA: 0x0009A4BC File Offset: 0x000986BC
		// Note: this type is marked as 'beforefieldinit'.
		static StyleScale()
		{
			Il2CppClassPointerStore<StyleScale>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleScale");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleScale>.NativeClassPtr);
			StyleScale.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleScale>.NativeClassPtr, "m_Value");
			StyleScale.NativeFieldInfoPtr_m_Keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleScale>.NativeClassPtr, "m_Keyword");
			StyleScale.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Scale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleScale>.NativeClassPtr, 100668363);
			StyleScale.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleScale>.NativeClassPtr, 100668364);
			StyleScale.NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleScale>.NativeClassPtr, 100668365);
			StyleScale.NativeMethodInfoPtr__ctor_Internal_Void_Scale_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleScale>.NativeClassPtr, 100668366);
			StyleScale.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleScale_StyleScale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleScale>.NativeClassPtr, 100668367);
			StyleScale.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleScale_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleScale>.NativeClassPtr, 100668368);
			StyleScale.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleScale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleScale>.NativeClassPtr, 100668369);
			StyleScale.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleScale>.NativeClassPtr, 100668370);
			StyleScale.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleScale>.NativeClassPtr, 100668371);
			StyleScale.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleScale>.NativeClassPtr, 100668372);
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06002251 RID: 8785 RVA: 0x0009A5DC File Offset: 0x000987DC
		// (set) Token: 0x0600225C RID: 8796 RVA: 0x0000E3E0 File Offset: 0x0000C5E0
		public unsafe Scale value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 335781, RefRangeEnd = 335782, XrefRangeStart = 335780, XrefRangeEnd = 335781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleScale.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Scale_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06002252 RID: 8786 RVA: 0x0009A60C File Offset: 0x0009880C
		// (set) Token: 0x0600225D RID: 8797 RVA: 0x0000E3F1 File Offset: 0x0000C5F1
		public unsafe StyleKeyword keyword
		{
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 334600, RefRangeEnd = 334642, XrefRangeStart = 334600, XrefRangeEnd = 334642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleScale.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Keyword = value;
			}
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x0009A63C File Offset: 0x0009883C
		[CallerCount(0)]
		public unsafe StyleScale(StyleKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleScale.NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x0009A670 File Offset: 0x00098870
		[CallerCount(0)]
		public unsafe StyleScale(Scale v, StyleKeyword keyword)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyword;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleScale.NativeMethodInfoPtr__ctor_Internal_Void_Scale_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x0009A6B0 File Offset: 0x000988B0
		[CallerCount(0)]
		public unsafe static bool operator ==(StyleScale lhs, StyleScale rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleScale.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleScale_StyleScale_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x0009A6FC File Offset: 0x000988FC
		[CallerCount(0)]
		public unsafe static implicit operator StyleScale(StyleKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleScale.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleScale_StyleKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x0009A73C File Offset: 0x0009893C
		[CallerCount(0)]
		public unsafe bool Equals(StyleScale other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleScale.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleScale_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x0009A77C File Offset: 0x0009897C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335782, XrefRangeEnd = 335785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleScale.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x0009A7C0 File Offset: 0x000989C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335785, XrefRangeEnd = 335788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleScale.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x0009A7F0 File Offset: 0x000989F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335788, XrefRangeEnd = 335794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleScale.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x0000E3CE File Offset: 0x0000C5CE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleScale>.NativeClassPtr, ref this));
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x0009A81C File Offset: 0x00098A1C
		public static implicit operator StyleScale(Vector2 scale)
		{
			return new Scale(scale);
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x0009A83C File Offset: 0x00098A3C
		public static bool operator !=(StyleScale lhs, StyleScale rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x0009A858 File Offset: 0x00098A58
		public static implicit operator StyleScale(Scale v)
		{
			return new StyleScale(v);
		}

		// Token: 0x0400181F RID: 6175
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x04001820 RID: 6176
		private static readonly IntPtr NativeFieldInfoPtr_m_Keyword;

		// Token: 0x04001821 RID: 6177
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Scale_0;

		// Token: 0x04001822 RID: 6178
		private static readonly IntPtr NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0;

		// Token: 0x04001823 RID: 6179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0;

		// Token: 0x04001824 RID: 6180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Scale_StyleKeyword_0;

		// Token: 0x04001825 RID: 6181
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleScale_StyleScale_0;

		// Token: 0x04001826 RID: 6182
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_StyleScale_StyleKeyword_0;

		// Token: 0x04001827 RID: 6183
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleScale_0;

		// Token: 0x04001828 RID: 6184
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001829 RID: 6185
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400182A RID: 6186
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400182B RID: 6187
		[FieldOffset(0)]
		public Scale m_Value;

		// Token: 0x0400182C RID: 6188
		[FieldOffset(16)]
		public StyleKeyword m_Keyword;
	}
}

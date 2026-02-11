using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000195 RID: 405
	[StructLayout(2)]
	public struct StyleBackgroundSize
	{
		// Token: 0x06002183 RID: 8579 RVA: 0x00097394 File Offset: 0x00095594
		// Note: this type is marked as 'beforefieldinit'.
		static StyleBackgroundSize()
		{
			Il2CppClassPointerStore<StyleBackgroundSize>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleBackgroundSize");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleBackgroundSize>.NativeClassPtr);
			StyleBackgroundSize.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleBackgroundSize>.NativeClassPtr, "m_Value");
			StyleBackgroundSize.NativeFieldInfoPtr_m_Keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleBackgroundSize>.NativeClassPtr, "m_Keyword");
			StyleBackgroundSize.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_BackgroundSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleBackgroundSize>.NativeClassPtr, 100668239);
			StyleBackgroundSize.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleBackgroundSize>.NativeClassPtr, 100668240);
			StyleBackgroundSize.NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleBackgroundSize>.NativeClassPtr, 100668241);
			StyleBackgroundSize.NativeMethodInfoPtr__ctor_Internal_Void_BackgroundSize_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleBackgroundSize>.NativeClassPtr, 100668242);
			StyleBackgroundSize.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleBackgroundSize_StyleBackgroundSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleBackgroundSize>.NativeClassPtr, 100668243);
			StyleBackgroundSize.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleBackgroundSize_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleBackgroundSize>.NativeClassPtr, 100668244);
			StyleBackgroundSize.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleBackgroundSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleBackgroundSize>.NativeClassPtr, 100668245);
			StyleBackgroundSize.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleBackgroundSize>.NativeClassPtr, 100668246);
			StyleBackgroundSize.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleBackgroundSize>.NativeClassPtr, 100668247);
			StyleBackgroundSize.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleBackgroundSize>.NativeClassPtr, 100668248);
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06002184 RID: 8580 RVA: 0x000974B4 File Offset: 0x000956B4
		// (set) Token: 0x0600218F RID: 8591 RVA: 0x0000E0CC File Offset: 0x0000C2CC
		public unsafe BackgroundSize value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 334565, RefRangeEnd = 334566, XrefRangeStart = 334565, XrefRangeEnd = 334565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleBackgroundSize.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_BackgroundSize_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06002185 RID: 8581 RVA: 0x000974E4 File Offset: 0x000956E4
		// (set) Token: 0x06002190 RID: 8592 RVA: 0x0000E0DD File Offset: 0x0000C2DD
		public unsafe StyleKeyword keyword
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 334566, RefRangeEnd = 334587, XrefRangeStart = 334566, XrefRangeEnd = 334566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleBackgroundSize.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Keyword = value;
			}
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x00097514 File Offset: 0x00095714
		[CallerCount(0)]
		public unsafe StyleBackgroundSize(StyleKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleBackgroundSize.NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x00097548 File Offset: 0x00095748
		[CallerCount(0)]
		public unsafe StyleBackgroundSize(BackgroundSize v, StyleKeyword keyword)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyword;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleBackgroundSize.NativeMethodInfoPtr__ctor_Internal_Void_BackgroundSize_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x00097588 File Offset: 0x00095788
		[CallerCount(0)]
		public unsafe static bool operator ==(StyleBackgroundSize lhs, StyleBackgroundSize rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleBackgroundSize.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleBackgroundSize_StyleBackgroundSize_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x000975D4 File Offset: 0x000957D4
		[CallerCount(0)]
		public unsafe static implicit operator StyleBackgroundSize(StyleKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleBackgroundSize.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleBackgroundSize_StyleKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x00097614 File Offset: 0x00095814
		[CallerCount(0)]
		public unsafe bool Equals(StyleBackgroundSize other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleBackgroundSize.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleBackgroundSize_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x00097654 File Offset: 0x00095854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334587, XrefRangeEnd = 334591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleBackgroundSize.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x00097698 File Offset: 0x00095898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334591, XrefRangeEnd = 334592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleBackgroundSize.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x000976C8 File Offset: 0x000958C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334592, XrefRangeEnd = 334598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleBackgroundSize.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x0000E0BA File Offset: 0x0000C2BA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleBackgroundSize>.NativeClassPtr, ref this));
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x000976F4 File Offset: 0x000958F4
		public static bool operator !=(StyleBackgroundSize lhs, StyleBackgroundSize rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x00097710 File Offset: 0x00095910
		public static implicit operator StyleBackgroundSize(BackgroundSize v)
		{
			return new StyleBackgroundSize(v);
		}

		// Token: 0x04001788 RID: 6024
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x04001789 RID: 6025
		private static readonly IntPtr NativeFieldInfoPtr_m_Keyword;

		// Token: 0x0400178A RID: 6026
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_BackgroundSize_0;

		// Token: 0x0400178B RID: 6027
		private static readonly IntPtr NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0;

		// Token: 0x0400178C RID: 6028
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0;

		// Token: 0x0400178D RID: 6029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BackgroundSize_StyleKeyword_0;

		// Token: 0x0400178E RID: 6030
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleBackgroundSize_StyleBackgroundSize_0;

		// Token: 0x0400178F RID: 6031
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_StyleBackgroundSize_StyleKeyword_0;

		// Token: 0x04001790 RID: 6032
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleBackgroundSize_0;

		// Token: 0x04001791 RID: 6033
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001792 RID: 6034
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001793 RID: 6035
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001794 RID: 6036
		[FieldOffset(0)]
		public BackgroundSize m_Value;

		// Token: 0x04001795 RID: 6037
		[FieldOffset(20)]
		public StyleKeyword m_Keyword;
	}
}

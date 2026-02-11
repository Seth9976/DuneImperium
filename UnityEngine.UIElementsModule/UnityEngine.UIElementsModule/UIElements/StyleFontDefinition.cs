using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200019C RID: 412
	public sealed class StyleFontDefinition : ValueType
	{
		// Token: 0x06002209 RID: 8713 RVA: 0x00099420 File Offset: 0x00097620
		// Note: this type is marked as 'beforefieldinit'.
		static StyleFontDefinition()
		{
			Il2CppClassPointerStore<StyleFontDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleFontDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleFontDefinition>.NativeClassPtr);
			StyleFontDefinition.NativeFieldInfoPtr_m_Keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleFontDefinition>.NativeClassPtr, "m_Keyword");
			StyleFontDefinition.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleFontDefinition>.NativeClassPtr, "m_Value");
			StyleFontDefinition.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_FontDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFontDefinition>.NativeClassPtr, 100668321);
			StyleFontDefinition.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFontDefinition>.NativeClassPtr, 100668322);
			StyleFontDefinition.NativeMethodInfoPtr__ctor_Public_Void_FontDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFontDefinition>.NativeClassPtr, 100668323);
			StyleFontDefinition.NativeMethodInfoPtr__ctor_Internal_Void_FontDefinition_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFontDefinition>.NativeClassPtr, 100668324);
			StyleFontDefinition.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleFontDefinition_FontDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFontDefinition>.NativeClassPtr, 100668325);
			StyleFontDefinition.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleFontDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFontDefinition>.NativeClassPtr, 100668326);
			StyleFontDefinition.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFontDefinition>.NativeClassPtr, 100668327);
			StyleFontDefinition.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFontDefinition>.NativeClassPtr, 100668328);
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x0600220A RID: 8714 RVA: 0x00099518 File Offset: 0x00097718
		// (set) Token: 0x06002218 RID: 8728 RVA: 0x0000E347 File Offset: 0x0000C547
		public unsafe FontDefinition value
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 335567, RefRangeEnd = 335573, XrefRangeStart = 335567, XrefRangeEnd = 335567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFontDefinition.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_FontDefinition_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new FontDefinition(intPtr);
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x0600220B RID: 8715 RVA: 0x00099554 File Offset: 0x00097754
		// (set) Token: 0x06002219 RID: 8729 RVA: 0x0000E358 File Offset: 0x0000C558
		public unsafe StyleKeyword keyword
		{
			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFontDefinition.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Keyword = value;
			}
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x00099598 File Offset: 0x00097798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335573, XrefRangeEnd = 335574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleFontDefinition(FontDefinition f)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleFontDefinition>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(f));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFontDefinition.NativeMethodInfoPtr__ctor_Public_Void_FontDefinition_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x000995F0 File Offset: 0x000977F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335574, XrefRangeEnd = 335575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleFontDefinition(FontDefinition f, StyleKeyword keyword)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleFontDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(f));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyword;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFontDefinition.NativeMethodInfoPtr__ctor_Internal_Void_FontDefinition_StyleKeyword_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x00099654 File Offset: 0x00097854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335576, RefRangeEnd = 335577, XrefRangeStart = 335575, XrefRangeEnd = 335576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator StyleFontDefinition(FontDefinition f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(f));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFontDefinition.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleFontDefinition_FontDefinition_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new StyleFontDefinition(intPtr);
			}
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x00099698 File Offset: 0x00097898
		[CallerCount(0)]
		public unsafe bool Equals(StyleFontDefinition other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFontDefinition.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleFontDefinition_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x000996F0 File Offset: 0x000978F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335577, XrefRangeEnd = 335581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFontDefinition.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x00099744 File Offset: 0x00097944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335581, XrefRangeEnd = 335582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFontDefinition.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x0000E2E3 File Offset: 0x0000C4E3
		public StyleFontDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x0000E2EC File Offset: 0x0000C4EC
		public StyleFontDefinition()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleFontDefinition>.NativeClassPtr))
		{
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06002214 RID: 8724 RVA: 0x00099788 File Offset: 0x00097988
		// (set) Token: 0x06002215 RID: 8725 RVA: 0x0000E2FE File Offset: 0x0000C4FE
		public unsafe StyleKeyword m_Keyword
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleFontDefinition.NativeFieldInfoPtr_m_Keyword);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleFontDefinition.NativeFieldInfoPtr_m_Keyword)) = value;
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x000997B0 File Offset: 0x000979B0
		// (set) Token: 0x06002217 RID: 8727 RVA: 0x0000E319 File Offset: 0x0000C519
		public FontDefinition m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleFontDefinition.NativeFieldInfoPtr_m_Value);
				return new FontDefinition(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FontDefinition>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleFontDefinition.NativeFieldInfoPtr_m_Value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FontDefinition>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x000997E0 File Offset: 0x000979E0
		public static implicit operator StyleFontDefinition(StyleKeyword keyword)
		{
			return new StyleFontDefinition(keyword);
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x000997F8 File Offset: 0x000979F8
		public static bool operator ==(StyleFontDefinition left, StyleFontDefinition right)
		{
			return left.Equals(right);
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x00099814 File Offset: 0x00097A14
		public static bool operator !=(StyleFontDefinition left, StyleFontDefinition right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040017E7 RID: 6119
		private static readonly IntPtr NativeFieldInfoPtr_m_Keyword;

		// Token: 0x040017E8 RID: 6120
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x040017E9 RID: 6121
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_FontDefinition_0;

		// Token: 0x040017EA RID: 6122
		private static readonly IntPtr NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0;

		// Token: 0x040017EB RID: 6123
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FontDefinition_0;

		// Token: 0x040017EC RID: 6124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_FontDefinition_StyleKeyword_0;

		// Token: 0x040017ED RID: 6125
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_StyleFontDefinition_FontDefinition_0;

		// Token: 0x040017EE RID: 6126
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleFontDefinition_0;

		// Token: 0x040017EF RID: 6127
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040017F0 RID: 6128
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}

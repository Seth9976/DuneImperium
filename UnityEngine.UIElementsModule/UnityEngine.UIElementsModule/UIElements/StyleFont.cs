using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200019B RID: 411
	public sealed class StyleFont : ValueType
	{
		// Token: 0x060021F4 RID: 8692 RVA: 0x00098F74 File Offset: 0x00097174
		// Note: this type is marked as 'beforefieldinit'.
		static StyleFont()
		{
			Il2CppClassPointerStore<StyleFont>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleFont");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleFont>.NativeClassPtr);
			StyleFont.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleFont>.NativeClassPtr, "m_Value");
			StyleFont.NativeFieldInfoPtr_m_Keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleFont>.NativeClassPtr, "m_Keyword");
			StyleFont.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFont>.NativeClassPtr, 100668311);
			StyleFont.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFont>.NativeClassPtr, 100668312);
			StyleFont.NativeMethodInfoPtr__ctor_Public_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFont>.NativeClassPtr, 100668313);
			StyleFont.NativeMethodInfoPtr__ctor_Internal_Void_Font_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFont>.NativeClassPtr, 100668314);
			StyleFont.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleFont_StyleFont_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFont>.NativeClassPtr, 100668315);
			StyleFont.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleFont_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFont>.NativeClassPtr, 100668316);
			StyleFont.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleFont_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFont>.NativeClassPtr, 100668317);
			StyleFont.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFont>.NativeClassPtr, 100668318);
			StyleFont.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFont>.NativeClassPtr, 100668319);
			StyleFont.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleFont>.NativeClassPtr, 100668320);
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x060021F5 RID: 8693 RVA: 0x00099094 File Offset: 0x00097294
		// (set) Token: 0x06002205 RID: 8709 RVA: 0x0000E2C8 File Offset: 0x0000C4C8
		public unsafe Font value
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 335513, RefRangeEnd = 335516, XrefRangeStart = 335513, XrefRangeEnd = 335513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFont.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Font_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Font>(intPtr3) : null;
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x060021F6 RID: 8694 RVA: 0x000990D8 File Offset: 0x000972D8
		// (set) Token: 0x06002206 RID: 8710 RVA: 0x0000E2D9 File Offset: 0x0000C4D9
		public unsafe StyleKeyword keyword
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 335516, RefRangeEnd = 335543, XrefRangeStart = 335516, XrefRangeEnd = 335516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFont.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Keyword = value;
			}
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x0009911C File Offset: 0x0009731C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335543, XrefRangeEnd = 335544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleFont(Font v)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleFont>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFont.NativeMethodInfoPtr__ctor_Public_Void_Font_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x0009916C File Offset: 0x0009736C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335544, XrefRangeEnd = 335545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleFont(Font v, StyleKeyword keyword)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleFont>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyword;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFont.NativeMethodInfoPtr__ctor_Internal_Void_Font_StyleKeyword_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x000991CC File Offset: 0x000973CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335545, XrefRangeEnd = 335546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(StyleFont lhs, StyleFont rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lhs));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFont.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleFont_StyleFont_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x0009922C File Offset: 0x0009742C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335547, RefRangeEnd = 335548, XrefRangeStart = 335546, XrefRangeEnd = 335547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator StyleFont(Font v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFont.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleFont_Font_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new StyleFont(intPtr);
			}
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x00099268 File Offset: 0x00097468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335548, XrefRangeEnd = 335549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(StyleFont other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFont.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleFont_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x000992C0 File Offset: 0x000974C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335549, XrefRangeEnd = 335556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFont.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x00099314 File Offset: 0x00097514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335556, XrefRangeEnd = 335561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFont.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x00099358 File Offset: 0x00097558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335561, XrefRangeEnd = 335567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleFont.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x0000E273 File Offset: 0x0000C473
		public StyleFont(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x0000E27C File Offset: 0x0000C47C
		public StyleFont()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleFont>.NativeClassPtr))
		{
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06002201 RID: 8705 RVA: 0x00099394 File Offset: 0x00097594
		// (set) Token: 0x06002202 RID: 8706 RVA: 0x0000E28E File Offset: 0x0000C48E
		public unsafe Font m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleFont.NativeFieldInfoPtr_m_Value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleFont.NativeFieldInfoPtr_m_Value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06002203 RID: 8707 RVA: 0x000993C4 File Offset: 0x000975C4
		// (set) Token: 0x06002204 RID: 8708 RVA: 0x0000E2AD File Offset: 0x0000C4AD
		public unsafe StyleKeyword m_Keyword
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleFont.NativeFieldInfoPtr_m_Keyword);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleFont.NativeFieldInfoPtr_m_Keyword)) = value;
			}
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x000993EC File Offset: 0x000975EC
		public static bool operator !=(StyleFont lhs, StyleFont rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x00099408 File Offset: 0x00097608
		public static implicit operator StyleFont(StyleKeyword keyword)
		{
			return new StyleFont(keyword);
		}

		// Token: 0x040017DB RID: 6107
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x040017DC RID: 6108
		private static readonly IntPtr NativeFieldInfoPtr_m_Keyword;

		// Token: 0x040017DD RID: 6109
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Font_0;

		// Token: 0x040017DE RID: 6110
		private static readonly IntPtr NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0;

		// Token: 0x040017DF RID: 6111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Font_0;

		// Token: 0x040017E0 RID: 6112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Font_StyleKeyword_0;

		// Token: 0x040017E1 RID: 6113
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleFont_StyleFont_0;

		// Token: 0x040017E2 RID: 6114
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_StyleFont_Font_0;

		// Token: 0x040017E3 RID: 6115
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleFont_0;

		// Token: 0x040017E4 RID: 6116
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040017E5 RID: 6117
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040017E6 RID: 6118
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}

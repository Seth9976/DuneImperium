using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001A3 RID: 419
	[StructLayout(2)]
	public struct StyleTransformOrigin
	{
		// Token: 0x06002282 RID: 8834 RVA: 0x0009B01C File Offset: 0x0009921C
		// Note: this type is marked as 'beforefieldinit'.
		static StyleTransformOrigin()
		{
			Il2CppClassPointerStore<StyleTransformOrigin>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleTransformOrigin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleTransformOrigin>.NativeClassPtr);
			StyleTransformOrigin.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleTransformOrigin>.NativeClassPtr, "m_Value");
			StyleTransformOrigin.NativeFieldInfoPtr_m_Keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleTransformOrigin>.NativeClassPtr, "m_Keyword");
			StyleTransformOrigin.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_TransformOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTransformOrigin>.NativeClassPtr, 100668395);
			StyleTransformOrigin.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTransformOrigin>.NativeClassPtr, 100668396);
			StyleTransformOrigin.NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTransformOrigin>.NativeClassPtr, 100668397);
			StyleTransformOrigin.NativeMethodInfoPtr__ctor_Internal_Void_TransformOrigin_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTransformOrigin>.NativeClassPtr, 100668398);
			StyleTransformOrigin.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleTransformOrigin_StyleTransformOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTransformOrigin>.NativeClassPtr, 100668399);
			StyleTransformOrigin.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleTransformOrigin_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTransformOrigin>.NativeClassPtr, 100668400);
			StyleTransformOrigin.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleTransformOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTransformOrigin>.NativeClassPtr, 100668401);
			StyleTransformOrigin.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTransformOrigin>.NativeClassPtr, 100668402);
			StyleTransformOrigin.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTransformOrigin>.NativeClassPtr, 100668403);
			StyleTransformOrigin.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTransformOrigin>.NativeClassPtr, 100668404);
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06002283 RID: 8835 RVA: 0x0009B13C File Offset: 0x0009933C
		// (set) Token: 0x0600228E RID: 8846 RVA: 0x0000E467 File Offset: 0x0000C667
		public unsafe TransformOrigin value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 335825, RefRangeEnd = 335826, XrefRangeStart = 335825, XrefRangeEnd = 335825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTransformOrigin.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_TransformOrigin_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06002284 RID: 8836 RVA: 0x0009B16C File Offset: 0x0009936C
		// (set) Token: 0x0600228F RID: 8847 RVA: 0x0000E478 File Offset: 0x0000C678
		public unsafe StyleKeyword keyword
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 334566, RefRangeEnd = 334587, XrefRangeStart = 334566, XrefRangeEnd = 334587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTransformOrigin.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Keyword = value;
			}
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x0009B19C File Offset: 0x0009939C
		[CallerCount(0)]
		public unsafe StyleTransformOrigin(StyleKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTransformOrigin.NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x0009B1D0 File Offset: 0x000993D0
		[CallerCount(0)]
		public unsafe StyleTransformOrigin(TransformOrigin v, StyleKeyword keyword)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyword;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTransformOrigin.NativeMethodInfoPtr__ctor_Internal_Void_TransformOrigin_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002287 RID: 8839 RVA: 0x0009B210 File Offset: 0x00099410
		[CallerCount(0)]
		public unsafe static bool operator ==(StyleTransformOrigin lhs, StyleTransformOrigin rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTransformOrigin.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleTransformOrigin_StyleTransformOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002288 RID: 8840 RVA: 0x0009B25C File Offset: 0x0009945C
		[CallerCount(0)]
		public unsafe static implicit operator StyleTransformOrigin(StyleKeyword keyword)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyword;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTransformOrigin.NativeMethodInfoPtr_op_Implicit_Public_Static_StyleTransformOrigin_StyleKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x0009B29C File Offset: 0x0009949C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335826, RefRangeEnd = 335827, XrefRangeStart = 335826, XrefRangeEnd = 335826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(StyleTransformOrigin other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTransformOrigin.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleTransformOrigin_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x0009B2DC File Offset: 0x000994DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335827, XrefRangeEnd = 335831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTransformOrigin.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x0009B320 File Offset: 0x00099520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335831, XrefRangeEnd = 335832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTransformOrigin.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x0009B350 File Offset: 0x00099550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335832, XrefRangeEnd = 335838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTransformOrigin.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x0000E455 File Offset: 0x0000C655
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleTransformOrigin>.NativeClassPtr, ref this));
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x0009B37C File Offset: 0x0009957C
		public static bool operator !=(StyleTransformOrigin lhs, StyleTransformOrigin rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x0009B398 File Offset: 0x00099598
		public static implicit operator StyleTransformOrigin(TransformOrigin v)
		{
			return new StyleTransformOrigin(v);
		}

		// Token: 0x0400184B RID: 6219
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x0400184C RID: 6220
		private static readonly IntPtr NativeFieldInfoPtr_m_Keyword;

		// Token: 0x0400184D RID: 6221
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_TransformOrigin_0;

		// Token: 0x0400184E RID: 6222
		private static readonly IntPtr NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0;

		// Token: 0x0400184F RID: 6223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StyleKeyword_0;

		// Token: 0x04001850 RID: 6224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TransformOrigin_StyleKeyword_0;

		// Token: 0x04001851 RID: 6225
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleTransformOrigin_StyleTransformOrigin_0;

		// Token: 0x04001852 RID: 6226
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_StyleTransformOrigin_StyleKeyword_0;

		// Token: 0x04001853 RID: 6227
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleTransformOrigin_0;

		// Token: 0x04001854 RID: 6228
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001855 RID: 6229
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001856 RID: 6230
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001857 RID: 6231
		[FieldOffset(0)]
		public TransformOrigin m_Value;

		// Token: 0x04001858 RID: 6232
		[FieldOffset(20)]
		public StyleKeyword m_Keyword;
	}
}

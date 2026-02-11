using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001C7 RID: 455
	[Serializable]
	public sealed class StyleSelectorPart : ValueType
	{
		// Token: 0x060023B2 RID: 9138 RVA: 0x000A0B40 File Offset: 0x0009ED40
		// Note: this type is marked as 'beforefieldinit'.
		static StyleSelectorPart()
		{
			Il2CppClassPointerStore<StyleSelectorPart>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleSelectorPart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleSelectorPart>.NativeClassPtr);
			StyleSelectorPart.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSelectorPart>.NativeClassPtr, "m_Value");
			StyleSelectorPart.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSelectorPart>.NativeClassPtr, "m_Type");
			StyleSelectorPart.NativeFieldInfoPtr_tempData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSelectorPart>.NativeClassPtr, "tempData");
			StyleSelectorPart.NativeMethodInfoPtr_get_value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelectorPart>.NativeClassPtr, 100668727);
			StyleSelectorPart.NativeMethodInfoPtr_get_type_Public_get_StyleSelectorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelectorPart>.NativeClassPtr, 100668728);
			StyleSelectorPart.NativeMethodInfoPtr_set_type_Internal_set_Void_StyleSelectorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelectorPart>.NativeClassPtr, 100668729);
			StyleSelectorPart.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelectorPart>.NativeClassPtr, 100668730);
			StyleSelectorPart.NativeMethodInfoPtr_CreateClass_Public_Static_StyleSelectorPart_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelectorPart>.NativeClassPtr, 100668731);
			StyleSelectorPart.NativeMethodInfoPtr_CreateId_Public_Static_StyleSelectorPart_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelectorPart>.NativeClassPtr, 100668732);
			StyleSelectorPart.NativeMethodInfoPtr_CreatePredicate_Public_Static_StyleSelectorPart_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelectorPart>.NativeClassPtr, 100668733);
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x060023B3 RID: 9139 RVA: 0x000A0C38 File Offset: 0x0009EE38
		// (set) Token: 0x060023C2 RID: 9154 RVA: 0x0000EAEC File Offset: 0x0000CCEC
		public unsafe string value
		{
			[CallerCount(128)]
			[CachedScanResults(RefRangeStart = 323623, RefRangeEnd = 323751, XrefRangeStart = 323623, XrefRangeEnd = 323751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelectorPart.NativeMethodInfoPtr_get_value_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				this.m_Value = value;
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x060023B4 RID: 9140 RVA: 0x000A0C74 File Offset: 0x0009EE74
		// (set) Token: 0x060023B5 RID: 9141 RVA: 0x000A0CB8 File Offset: 0x0009EEB8
		public unsafe StyleSelectorType type
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 335516, RefRangeEnd = 335543, XrefRangeStart = 335516, XrefRangeEnd = 335543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelectorPart.NativeMethodInfoPtr_get_type_Public_get_StyleSelectorType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 310301, RefRangeEnd = 310309, XrefRangeStart = 310301, XrefRangeEnd = 310309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelectorPart.NativeMethodInfoPtr_set_type_Internal_set_Void_StyleSelectorType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x000A0CFC File Offset: 0x0009EEFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337703, RefRangeEnd = 337704, XrefRangeStart = 337690, XrefRangeEnd = 337703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelectorPart.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x000A0D38 File Offset: 0x0009EF38
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 337705, RefRangeEnd = 337711, XrefRangeStart = 337704, XrefRangeEnd = 337705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StyleSelectorPart CreateClass(string className)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelectorPart.NativeMethodInfoPtr_CreateClass_Public_Static_StyleSelectorPart_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new StyleSelectorPart(intPtr);
			}
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x000A0D74 File Offset: 0x0009EF74
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 337712, RefRangeEnd = 337718, XrefRangeStart = 337711, XrefRangeEnd = 337712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StyleSelectorPart CreateId(string Id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelectorPart.NativeMethodInfoPtr_CreateId_Public_Static_StyleSelectorPart_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new StyleSelectorPart(intPtr);
			}
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x000A0DB0 File Offset: 0x0009EFB0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 337719, RefRangeEnd = 337724, XrefRangeStart = 337718, XrefRangeEnd = 337719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StyleSelectorPart CreatePredicate(Object predicate)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelectorPart.NativeMethodInfoPtr_CreatePredicate_Public_Static_StyleSelectorPart_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new StyleSelectorPart(intPtr);
			}
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x0000EA78 File Offset: 0x0000CC78
		public StyleSelectorPart(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x0000EA81 File Offset: 0x0000CC81
		public StyleSelectorPart()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleSelectorPart>.NativeClassPtr))
		{
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x060023BC RID: 9148 RVA: 0x000A0DEC File Offset: 0x0009EFEC
		// (set) Token: 0x060023BD RID: 9149 RVA: 0x0000EA93 File Offset: 0x0000CC93
		public unsafe string m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelectorPart.NativeFieldInfoPtr_m_Value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelectorPart.NativeFieldInfoPtr_m_Value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x060023BE RID: 9150 RVA: 0x000A0E14 File Offset: 0x0009F014
		// (set) Token: 0x060023BF RID: 9151 RVA: 0x0000EAB2 File Offset: 0x0000CCB2
		public unsafe StyleSelectorType m_Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelectorPart.NativeFieldInfoPtr_m_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelectorPart.NativeFieldInfoPtr_m_Type)) = value;
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x060023C0 RID: 9152 RVA: 0x000A0E3C File Offset: 0x0009F03C
		// (set) Token: 0x060023C1 RID: 9153 RVA: 0x0000EACD File Offset: 0x0000CCCD
		public unsafe Object tempData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelectorPart.NativeFieldInfoPtr_tempData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelectorPart.NativeFieldInfoPtr_tempData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x000A0E6C File Offset: 0x0009F06C
		public static StyleSelectorPart CreatePseudoClass(string className)
		{
			StyleSelectorPart styleSelectorPart = null;
			styleSelectorPart.m_Type = StyleSelectorType.PseudoClass;
			styleSelectorPart.m_Value = className;
			return styleSelectorPart;
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x000A0E98 File Offset: 0x0009F098
		public static StyleSelectorPart CreateType(Type t)
		{
			StyleSelectorPart styleSelectorPart = null;
			styleSelectorPart.m_Type = StyleSelectorType.Type;
			styleSelectorPart.m_Value = t.Name;
			return styleSelectorPart;
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x000A0EC8 File Offset: 0x0009F0C8
		public static StyleSelectorPart CreateType(string typeName)
		{
			StyleSelectorPart styleSelectorPart = null;
			styleSelectorPart.m_Type = StyleSelectorType.Type;
			styleSelectorPart.m_Value = typeName;
			return styleSelectorPart;
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x000A0EF4 File Offset: 0x0009F0F4
		public static StyleSelectorPart CreateWildCard()
		{
			StyleSelectorPart styleSelectorPart = null;
			styleSelectorPart.m_Type = StyleSelectorType.Wildcard;
			return styleSelectorPart;
		}

		// Token: 0x04001989 RID: 6537
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x0400198A RID: 6538
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x0400198B RID: 6539
		private static readonly IntPtr NativeFieldInfoPtr_tempData;

		// Token: 0x0400198C RID: 6540
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_String_0;

		// Token: 0x0400198D RID: 6541
		private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_StyleSelectorType_0;

		// Token: 0x0400198E RID: 6542
		private static readonly IntPtr NativeMethodInfoPtr_set_type_Internal_set_Void_StyleSelectorType_0;

		// Token: 0x0400198F RID: 6543
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001990 RID: 6544
		private static readonly IntPtr NativeMethodInfoPtr_CreateClass_Public_Static_StyleSelectorPart_String_0;

		// Token: 0x04001991 RID: 6545
		private static readonly IntPtr NativeMethodInfoPtr_CreateId_Public_Static_StyleSelectorPart_String_0;

		// Token: 0x04001992 RID: 6546
		private static readonly IntPtr NativeMethodInfoPtr_CreatePredicate_Public_Static_StyleSelectorPart_Object_0;
	}
}

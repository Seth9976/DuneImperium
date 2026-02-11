using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001C6 RID: 454
	[Serializable]
	public class StyleSelector : Object
	{
		// Token: 0x060023A2 RID: 9122 RVA: 0x000A0820 File Offset: 0x0009EA20
		// Note: this type is marked as 'beforefieldinit'.
		static StyleSelector()
		{
			Il2CppClassPointerStore<StyleSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleSelector>.NativeClassPtr);
			StyleSelector.NativeFieldInfoPtr_m_Parts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSelector>.NativeClassPtr, "m_Parts");
			StyleSelector.NativeFieldInfoPtr_m_PreviousRelationship = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSelector>.NativeClassPtr, "m_PreviousRelationship");
			StyleSelector.NativeFieldInfoPtr_pseudoStateMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSelector>.NativeClassPtr, "pseudoStateMask");
			StyleSelector.NativeFieldInfoPtr_negatedPseudoStateMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSelector>.NativeClassPtr, "negatedPseudoStateMask");
			StyleSelector.NativeMethodInfoPtr_get_parts_Public_get_Il2CppReferenceArray_1_StyleSelectorPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelector>.NativeClassPtr, 100668718);
			StyleSelector.NativeMethodInfoPtr_set_parts_Internal_set_Void_Il2CppReferenceArray_1_StyleSelectorPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelector>.NativeClassPtr, 100668719);
			StyleSelector.NativeMethodInfoPtr_get_previousRelationship_Public_get_StyleSelectorRelationship_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelector>.NativeClassPtr, 100668720);
			StyleSelector.NativeMethodInfoPtr_set_previousRelationship_Internal_set_Void_StyleSelectorRelationship_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelector>.NativeClassPtr, 100668721);
			StyleSelector.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelector>.NativeClassPtr, 100668722);
			StyleSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelector>.NativeClassPtr, 100668723);
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x060023A3 RID: 9123 RVA: 0x000A0918 File Offset: 0x0009EB18
		// (set) Token: 0x060023A4 RID: 9124 RVA: 0x000A0958 File Offset: 0x0009EB58
		public unsafe Il2CppReferenceArray<StyleSelectorPart> parts
		{
			[CallerCount(169)]
			[CachedScanResults(RefRangeStart = 282426, RefRangeEnd = 282595, XrefRangeStart = 282426, XrefRangeEnd = 282595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelector.NativeMethodInfoPtr_get_parts_Public_get_Il2CppReferenceArray_1_StyleSelectorPart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleSelectorPart>>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelector.NativeMethodInfoPtr_set_parts_Internal_set_Void_Il2CppReferenceArray_1_StyleSelectorPart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x060023A5 RID: 9125 RVA: 0x000A099C File Offset: 0x0009EB9C
		// (set) Token: 0x060023A6 RID: 9126 RVA: 0x000A09D8 File Offset: 0x0009EBD8
		public unsafe StyleSelectorRelationship previousRelationship
		{
			[CallerCount(66)]
			[CachedScanResults(RefRangeStart = 320372, RefRangeEnd = 320438, XrefRangeStart = 320372, XrefRangeEnd = 320438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelector.NativeMethodInfoPtr_get_previousRelationship_Public_get_StyleSelectorRelationship_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelector.NativeMethodInfoPtr_set_previousRelationship_Internal_set_Void_StyleSelectorRelationship_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x000A0A18 File Offset: 0x0009EC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337664, XrefRangeEnd = 337688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StyleSelector.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x000A0A5C File Offset: 0x0009EC5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337689, RefRangeEnd = 337690, XrefRangeStart = 337688, XrefRangeEnd = 337689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleSelector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x0000E9FF File Offset: 0x0000CBFF
		public StyleSelector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x060023AA RID: 9130 RVA: 0x000A0A98 File Offset: 0x0009EC98
		// (set) Token: 0x060023AB RID: 9131 RVA: 0x0000EA08 File Offset: 0x0000CC08
		public unsafe Il2CppReferenceArray<StyleSelectorPart> m_Parts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelector.NativeFieldInfoPtr_m_Parts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleSelectorPart>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelector.NativeFieldInfoPtr_m_Parts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x060023AC RID: 9132 RVA: 0x000A0AC8 File Offset: 0x0009ECC8
		// (set) Token: 0x060023AD RID: 9133 RVA: 0x0000EA27 File Offset: 0x0000CC27
		public unsafe StyleSelectorRelationship m_PreviousRelationship
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelector.NativeFieldInfoPtr_m_PreviousRelationship);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelector.NativeFieldInfoPtr_m_PreviousRelationship)) = value;
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x060023AE RID: 9134 RVA: 0x000A0AF0 File Offset: 0x0009ECF0
		// (set) Token: 0x060023AF RID: 9135 RVA: 0x0000EA42 File Offset: 0x0000CC42
		public unsafe int pseudoStateMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelector.NativeFieldInfoPtr_pseudoStateMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelector.NativeFieldInfoPtr_pseudoStateMask)) = value;
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x060023B0 RID: 9136 RVA: 0x000A0B18 File Offset: 0x0009ED18
		// (set) Token: 0x060023B1 RID: 9137 RVA: 0x0000EA5D File Offset: 0x0000CC5D
		public unsafe int negatedPseudoStateMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelector.NativeFieldInfoPtr_negatedPseudoStateMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelector.NativeFieldInfoPtr_negatedPseudoStateMask)) = value;
			}
		}

		// Token: 0x0400197F RID: 6527
		private static readonly IntPtr NativeFieldInfoPtr_m_Parts;

		// Token: 0x04001980 RID: 6528
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousRelationship;

		// Token: 0x04001981 RID: 6529
		private static readonly IntPtr NativeFieldInfoPtr_pseudoStateMask;

		// Token: 0x04001982 RID: 6530
		private static readonly IntPtr NativeFieldInfoPtr_negatedPseudoStateMask;

		// Token: 0x04001983 RID: 6531
		private static readonly IntPtr NativeMethodInfoPtr_get_parts_Public_get_Il2CppReferenceArray_1_StyleSelectorPart_0;

		// Token: 0x04001984 RID: 6532
		private static readonly IntPtr NativeMethodInfoPtr_set_parts_Internal_set_Void_Il2CppReferenceArray_1_StyleSelectorPart_0;

		// Token: 0x04001985 RID: 6533
		private static readonly IntPtr NativeMethodInfoPtr_get_previousRelationship_Public_get_StyleSelectorRelationship_0;

		// Token: 0x04001986 RID: 6534
		private static readonly IntPtr NativeMethodInfoPtr_set_previousRelationship_Internal_set_Void_StyleSelectorRelationship_0;

		// Token: 0x04001987 RID: 6535
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001988 RID: 6536
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020004DE RID: 1246
		[ObfuscatedName("UnityEngine.UIElements.StyleSelector+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003F0B RID: 16139 RVA: 0x000FB8E8 File Offset: 0x000F9AE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StyleSelector.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StyleSelector>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleSelector.__c>.NativeClassPtr);
				StyleSelector.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSelector.__c>.NativeClassPtr, "<>9");
				StyleSelector.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSelector.__c>.NativeClassPtr, "<>9__10_0");
				StyleSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelector.__c>.NativeClassPtr, 100668725);
				StyleSelector.__c.NativeMethodInfoPtr__ToString_b__10_0_Internal_String_StyleSelectorPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelector.__c>.NativeClassPtr, 100668726);
			}

			// Token: 0x06003F0C RID: 16140 RVA: 0x000FB964 File Offset: 0x000F9B64
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleSelector.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F0D RID: 16141 RVA: 0x000FB9A0 File Offset: 0x000F9BA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337663, XrefRangeEnd = 337664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__10_0(StyleSelectorPart p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(p));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelector.__c.NativeMethodInfoPtr__ToString_b__10_0_Internal_String_StyleSelectorPart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06003F0E RID: 16142 RVA: 0x0001A693 File Offset: 0x00018893
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012F2 RID: 4850
			// (get) Token: 0x06003F0F RID: 16143 RVA: 0x000FB9F0 File Offset: 0x000F9BF0
			// (set) Token: 0x06003F10 RID: 16144 RVA: 0x0001A69C File Offset: 0x0001889C
			public unsafe static StyleSelector.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StyleSelector.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleSelector.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StyleSelector.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012F3 RID: 4851
			// (get) Token: 0x06003F11 RID: 16145 RVA: 0x000FBA18 File Offset: 0x000F9C18
			// (set) Token: 0x06003F12 RID: 16146 RVA: 0x0001A6AE File Offset: 0x000188AE
			public unsafe static Func<StyleSelectorPart, string> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StyleSelector.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<StyleSelectorPart, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StyleSelector.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C97 RID: 11415
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002C98 RID: 11416
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04002C99 RID: 11417
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C9A RID: 11418
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__10_0_Internal_String_StyleSelectorPart_0;
		}

		// Token: 0x020004DF RID: 1247
		[Serializable]
		public sealed class <>c
		{
		}
	}
}

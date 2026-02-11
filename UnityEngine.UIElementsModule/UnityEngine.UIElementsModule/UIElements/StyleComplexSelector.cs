using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020001C3 RID: 451
	[Serializable]
	public class StyleComplexSelector : Object
	{
		// Token: 0x06002360 RID: 9056 RVA: 0x0009FD48 File Offset: 0x0009DF48
		// Note: this type is marked as 'beforefieldinit'.
		static StyleComplexSelector()
		{
			Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleComplexSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr);
			StyleComplexSelector.NativeFieldInfoPtr_ancestorHashes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, "ancestorHashes");
			StyleComplexSelector.NativeFieldInfoPtr_m_Specificity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, "m_Specificity");
			StyleComplexSelector.NativeFieldInfoPtr__rule_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, "<rule>k__BackingField");
			StyleComplexSelector.NativeFieldInfoPtr_m_isSimple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, "m_isSimple");
			StyleComplexSelector.NativeFieldInfoPtr_m_Selectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, "m_Selectors");
			StyleComplexSelector.NativeFieldInfoPtr_ruleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, "ruleIndex");
			StyleComplexSelector.NativeFieldInfoPtr_nextInTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, "nextInTable");
			StyleComplexSelector.NativeFieldInfoPtr_orderInStyleSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, "orderInStyleSheet");
			StyleComplexSelector.NativeFieldInfoPtr_s_PseudoStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, "s_PseudoStates");
			StyleComplexSelector.NativeFieldInfoPtr_m_HashList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, "m_HashList");
			StyleComplexSelector.NativeMethodInfoPtr_get_specificity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, 100668694);
			StyleComplexSelector.NativeMethodInfoPtr_get_rule_Public_get_StyleRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, 100668695);
			StyleComplexSelector.NativeMethodInfoPtr_set_rule_Internal_set_Void_StyleRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, 100668696);
			StyleComplexSelector.NativeMethodInfoPtr_get_isSimple_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, 100668697);
			StyleComplexSelector.NativeMethodInfoPtr_get_selectors_Public_get_Il2CppReferenceArray_1_StyleSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, 100668698);
			StyleComplexSelector.NativeMethodInfoPtr_set_selectors_Internal_set_Void_Il2CppReferenceArray_1_StyleSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, 100668699);
			StyleComplexSelector.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, 100668700);
			StyleComplexSelector.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, 100668701);
			StyleComplexSelector.NativeMethodInfoPtr_CachePseudoStateMasks_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, 100668702);
			StyleComplexSelector.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, 100668703);
			StyleComplexSelector.NativeMethodInfoPtr_StyleSelectorPartCompare_Private_Static_Int32_StyleSelectorPart_StyleSelectorPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, 100668704);
			StyleComplexSelector.NativeMethodInfoPtr_CalculateHashes_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, 100668705);
			StyleComplexSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, 100668706);
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06002361 RID: 9057 RVA: 0x0009FF44 File Offset: 0x0009E144
		// (set) Token: 0x06002383 RID: 9091 RVA: 0x0000E8D7 File Offset: 0x0000CAD7
		public unsafe int specificity
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 337415, RefRangeEnd = 337422, XrefRangeStart = 337415, XrefRangeEnd = 337415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleComplexSelector.NativeMethodInfoPtr_get_specificity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Specificity = value;
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06002362 RID: 9058 RVA: 0x0009FF80 File Offset: 0x0009E180
		// (set) Token: 0x06002363 RID: 9059 RVA: 0x0009FFC0 File Offset: 0x0009E1C0
		public unsafe StyleRule rule
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleComplexSelector.NativeMethodInfoPtr_get_rule_Public_get_StyleRule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StyleRule>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleComplexSelector.NativeMethodInfoPtr_set_rule_Internal_set_Void_StyleRule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06002364 RID: 9060 RVA: 0x000A0004 File Offset: 0x0009E204
		public unsafe bool isSimple
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 337422, RefRangeEnd = 337423, XrefRangeStart = 337422, XrefRangeEnd = 337422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleComplexSelector.NativeMethodInfoPtr_get_isSimple_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06002365 RID: 9061 RVA: 0x000A0040 File Offset: 0x0009E240
		// (set) Token: 0x06002366 RID: 9062 RVA: 0x000A0080 File Offset: 0x0009E280
		public unsafe Il2CppReferenceArray<StyleSelector> selectors
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 285338, RefRangeEnd = 285365, XrefRangeStart = 285338, XrefRangeEnd = 285365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleComplexSelector.NativeMethodInfoPtr_get_selectors_Public_get_Il2CppReferenceArray_1_StyleSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleSelector>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 337424, RefRangeEnd = 337425, XrefRangeStart = 337423, XrefRangeEnd = 337424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleComplexSelector.NativeMethodInfoPtr_set_selectors_Internal_set_Void_Il2CppReferenceArray_1_StyleSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x000A00C4 File Offset: 0x0009E2C4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleComplexSelector.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002368 RID: 9064 RVA: 0x000A00F8 File Offset: 0x0009E2F8
		[CallerCount(0)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StyleComplexSelector.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x000A0134 File Offset: 0x0009E334
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337507, RefRangeEnd = 337508, XrefRangeStart = 337425, XrefRangeEnd = 337507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CachePseudoStateMasks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleComplexSelector.NativeMethodInfoPtr_CachePseudoStateMasks_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600236A RID: 9066 RVA: 0x000A0168 File Offset: 0x0009E368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337508, XrefRangeEnd = 337545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StyleComplexSelector.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600236B RID: 9067 RVA: 0x000A01AC File Offset: 0x0009E3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337545, XrefRangeEnd = 337546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int StyleSelectorPartCompare(StyleSelectorPart x, StyleSelectorPart y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleComplexSelector.NativeMethodInfoPtr_StyleSelectorPartCompare_Private_Static_Int32_StyleSelectorPart_StyleSelectorPart_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x000A020C File Offset: 0x0009E40C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337627, RefRangeEnd = 337628, XrefRangeStart = 337546, XrefRangeEnd = 337627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateHashes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleComplexSelector.NativeMethodInfoPtr_CalculateHashes_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600236D RID: 9069 RVA: 0x000A0240 File Offset: 0x0009E440
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleComplexSelector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleComplexSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600236E RID: 9070 RVA: 0x0000E7C6 File Offset: 0x0000C9C6
		public StyleComplexSelector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x0600236F RID: 9071 RVA: 0x000A027C File Offset: 0x0009E47C
		// (set) Token: 0x06002370 RID: 9072 RVA: 0x0000E7CF File Offset: 0x0000C9CF
		public unsafe Hashes ancestorHashes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr_ancestorHashes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr_ancestorHashes)) = value;
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06002371 RID: 9073 RVA: 0x000A02A4 File Offset: 0x0009E4A4
		// (set) Token: 0x06002372 RID: 9074 RVA: 0x0000E7EA File Offset: 0x0000C9EA
		public unsafe int m_Specificity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr_m_Specificity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr_m_Specificity)) = value;
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06002373 RID: 9075 RVA: 0x000A02CC File Offset: 0x0009E4CC
		// (set) Token: 0x06002374 RID: 9076 RVA: 0x0000E805 File Offset: 0x0000CA05
		public unsafe StyleRule _rule_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr__rule_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleRule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr__rule_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06002375 RID: 9077 RVA: 0x000A02FC File Offset: 0x0009E4FC
		// (set) Token: 0x06002376 RID: 9078 RVA: 0x0000E824 File Offset: 0x0000CA24
		public unsafe bool m_isSimple
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr_m_isSimple);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr_m_isSimple)) = value;
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06002377 RID: 9079 RVA: 0x000A0324 File Offset: 0x0009E524
		// (set) Token: 0x06002378 RID: 9080 RVA: 0x0000E83F File Offset: 0x0000CA3F
		public unsafe Il2CppReferenceArray<StyleSelector> m_Selectors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr_m_Selectors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleSelector>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr_m_Selectors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06002379 RID: 9081 RVA: 0x000A0354 File Offset: 0x0009E554
		// (set) Token: 0x0600237A RID: 9082 RVA: 0x0000E85E File Offset: 0x0000CA5E
		public unsafe int ruleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr_ruleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr_ruleIndex)) = value;
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x0600237B RID: 9083 RVA: 0x000A037C File Offset: 0x0009E57C
		// (set) Token: 0x0600237C RID: 9084 RVA: 0x0000E879 File Offset: 0x0000CA79
		public unsafe StyleComplexSelector nextInTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr_nextInTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleComplexSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr_nextInTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x0600237D RID: 9085 RVA: 0x000A03AC File Offset: 0x0009E5AC
		// (set) Token: 0x0600237E RID: 9086 RVA: 0x0000E898 File Offset: 0x0000CA98
		public unsafe int orderInStyleSheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr_orderInStyleSheet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleComplexSelector.NativeFieldInfoPtr_orderInStyleSheet)) = value;
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x0600237F RID: 9087 RVA: 0x000A03D4 File Offset: 0x0009E5D4
		// (set) Token: 0x06002380 RID: 9088 RVA: 0x0000E8B3 File Offset: 0x0000CAB3
		public unsafe static Dictionary<string, StyleComplexSelector.PseudoStateData> s_PseudoStates
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StyleComplexSelector.NativeFieldInfoPtr_s_PseudoStates, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, StyleComplexSelector.PseudoStateData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StyleComplexSelector.NativeFieldInfoPtr_s_PseudoStates, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06002381 RID: 9089 RVA: 0x000A03FC File Offset: 0x0009E5FC
		// (set) Token: 0x06002382 RID: 9090 RVA: 0x0000E8C5 File Offset: 0x0000CAC5
		public unsafe static List<StyleSelectorPart> m_HashList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StyleComplexSelector.NativeFieldInfoPtr_m_HashList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StyleSelectorPart>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StyleComplexSelector.NativeFieldInfoPtr_m_HashList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400195B RID: 6491
		private static readonly IntPtr NativeFieldInfoPtr_ancestorHashes;

		// Token: 0x0400195C RID: 6492
		private static readonly IntPtr NativeFieldInfoPtr_m_Specificity;

		// Token: 0x0400195D RID: 6493
		private static readonly IntPtr NativeFieldInfoPtr__rule_k__BackingField;

		// Token: 0x0400195E RID: 6494
		private static readonly IntPtr NativeFieldInfoPtr_m_isSimple;

		// Token: 0x0400195F RID: 6495
		private static readonly IntPtr NativeFieldInfoPtr_m_Selectors;

		// Token: 0x04001960 RID: 6496
		private static readonly IntPtr NativeFieldInfoPtr_ruleIndex;

		// Token: 0x04001961 RID: 6497
		private static readonly IntPtr NativeFieldInfoPtr_nextInTable;

		// Token: 0x04001962 RID: 6498
		private static readonly IntPtr NativeFieldInfoPtr_orderInStyleSheet;

		// Token: 0x04001963 RID: 6499
		private static readonly IntPtr NativeFieldInfoPtr_s_PseudoStates;

		// Token: 0x04001964 RID: 6500
		private static readonly IntPtr NativeFieldInfoPtr_m_HashList;

		// Token: 0x04001965 RID: 6501
		private static readonly IntPtr NativeMethodInfoPtr_get_specificity_Public_get_Int32_0;

		// Token: 0x04001966 RID: 6502
		private static readonly IntPtr NativeMethodInfoPtr_get_rule_Public_get_StyleRule_0;

		// Token: 0x04001967 RID: 6503
		private static readonly IntPtr NativeMethodInfoPtr_set_rule_Internal_set_Void_StyleRule_0;

		// Token: 0x04001968 RID: 6504
		private static readonly IntPtr NativeMethodInfoPtr_get_isSimple_Public_get_Boolean_0;

		// Token: 0x04001969 RID: 6505
		private static readonly IntPtr NativeMethodInfoPtr_get_selectors_Public_get_Il2CppReferenceArray_1_StyleSelector_0;

		// Token: 0x0400196A RID: 6506
		private static readonly IntPtr NativeMethodInfoPtr_set_selectors_Internal_set_Void_Il2CppReferenceArray_1_StyleSelector_0;

		// Token: 0x0400196B RID: 6507
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400196C RID: 6508
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_New_Void_0;

		// Token: 0x0400196D RID: 6509
		private static readonly IntPtr NativeMethodInfoPtr_CachePseudoStateMasks_Internal_Void_0;

		// Token: 0x0400196E RID: 6510
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400196F RID: 6511
		private static readonly IntPtr NativeMethodInfoPtr_StyleSelectorPartCompare_Private_Static_Int32_StyleSelectorPart_StyleSelectorPart_0;

		// Token: 0x04001970 RID: 6512
		private static readonly IntPtr NativeMethodInfoPtr_CalculateHashes_Internal_Void_0;

		// Token: 0x04001971 RID: 6513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020004DB RID: 1243
		[StructLayout(2)]
		public struct PseudoStateData
		{
			// Token: 0x06003EFD RID: 16125 RVA: 0x000FB64C File Offset: 0x000F984C
			// Note: this type is marked as 'beforefieldinit'.
			static PseudoStateData()
			{
				Il2CppClassPointerStore<StyleComplexSelector.PseudoStateData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, "PseudoStateData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleComplexSelector.PseudoStateData>.NativeClassPtr);
				StyleComplexSelector.PseudoStateData.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector.PseudoStateData>.NativeClassPtr, "state");
				StyleComplexSelector.PseudoStateData.NativeFieldInfoPtr_negate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector.PseudoStateData>.NativeClassPtr, "negate");
				StyleComplexSelector.PseudoStateData.NativeMethodInfoPtr__ctor_Public_Void_PseudoStates_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector.PseudoStateData>.NativeClassPtr, 100668708);
			}

			// Token: 0x06003EFE RID: 16126 RVA: 0x000FB6B4 File Offset: 0x000F98B4
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 337402, RefRangeEnd = 337414, XrefRangeStart = 337402, XrefRangeEnd = 337402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PseudoStateData(PseudoStates state, bool negate)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref state;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref negate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleComplexSelector.PseudoStateData.NativeMethodInfoPtr__ctor_Public_Void_PseudoStates_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003EFF RID: 16127 RVA: 0x0001A642 File Offset: 0x00018842
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleComplexSelector.PseudoStateData>.NativeClassPtr, ref this));
			}

			// Token: 0x04002C8C RID: 11404
			private static readonly IntPtr NativeFieldInfoPtr_state;

			// Token: 0x04002C8D RID: 11405
			private static readonly IntPtr NativeFieldInfoPtr_negate;

			// Token: 0x04002C8E RID: 11406
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PseudoStates_Boolean_0;

			// Token: 0x04002C8F RID: 11407
			[FieldOffset(0)]
			public readonly PseudoStates state;

			// Token: 0x04002C90 RID: 11408
			[FieldOffset(4)]
			[MarshalAs(4)]
			public readonly bool negate;
		}

		// Token: 0x020004DC RID: 1244
		[ObfuscatedName("UnityEngine.UIElements.StyleComplexSelector+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003F00 RID: 16128 RVA: 0x000FB6F4 File Offset: 0x000F98F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StyleComplexSelector.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StyleComplexSelector>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleComplexSelector.__c>.NativeClassPtr);
				StyleComplexSelector.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector.__c>.NativeClassPtr, "<>9");
				StyleComplexSelector.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector.__c>.NativeClassPtr, "<>9__24_0");
				StyleComplexSelector.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleComplexSelector.__c>.NativeClassPtr, "<>9__27_0");
				StyleComplexSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector.__c>.NativeClassPtr, 100668710);
				StyleComplexSelector.__c.NativeMethodInfoPtr__ToString_b__24_0_Internal_String_StyleSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector.__c>.NativeClassPtr, 100668711);
				StyleComplexSelector.__c.NativeMethodInfoPtr__CalculateHashes_b__27_0_Internal_Boolean_StyleSelectorPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleComplexSelector.__c>.NativeClassPtr, 100668712);
			}

			// Token: 0x06003F01 RID: 16129 RVA: 0x000FB798 File Offset: 0x000F9998
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleComplexSelector.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleComplexSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F02 RID: 16130 RVA: 0x000FB7D4 File Offset: 0x000F99D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337414, XrefRangeEnd = 337415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__24_0(StyleSelector x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleComplexSelector.__c.NativeMethodInfoPtr__ToString_b__24_0_Internal_String_StyleSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06003F03 RID: 16131 RVA: 0x000FB81C File Offset: 0x000F9A1C
			[CallerCount(0)]
			public unsafe bool _CalculateHashes_b__27_0(StyleSelectorPart p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(p));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleComplexSelector.__c.NativeMethodInfoPtr__CalculateHashes_b__27_0_Internal_Boolean_StyleSelectorPart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003F04 RID: 16132 RVA: 0x0001A654 File Offset: 0x00018854
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012EF RID: 4847
			// (get) Token: 0x06003F05 RID: 16133 RVA: 0x000FB870 File Offset: 0x000F9A70
			// (set) Token: 0x06003F06 RID: 16134 RVA: 0x0001A65D File Offset: 0x0001885D
			public unsafe static StyleComplexSelector.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StyleComplexSelector.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleComplexSelector.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StyleComplexSelector.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012F0 RID: 4848
			// (get) Token: 0x06003F07 RID: 16135 RVA: 0x000FB898 File Offset: 0x000F9A98
			// (set) Token: 0x06003F08 RID: 16136 RVA: 0x0001A66F File Offset: 0x0001886F
			public unsafe static Func<StyleSelector, string> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StyleComplexSelector.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<StyleSelector, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StyleComplexSelector.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012F1 RID: 4849
			// (get) Token: 0x06003F09 RID: 16137 RVA: 0x000FB8C0 File Offset: 0x000F9AC0
			// (set) Token: 0x06003F0A RID: 16138 RVA: 0x0001A681 File Offset: 0x00018881
			public unsafe static Predicate<StyleSelectorPart> __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StyleComplexSelector.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<StyleSelectorPart>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StyleComplexSelector.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C91 RID: 11409
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002C92 RID: 11410
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x04002C93 RID: 11411
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x04002C94 RID: 11412
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C95 RID: 11413
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__24_0_Internal_String_StyleSelector_0;

			// Token: 0x04002C96 RID: 11414
			private static readonly IntPtr NativeMethodInfoPtr__CalculateHashes_b__27_0_Internal_Boolean_StyleSelectorPart_0;
		}

		// Token: 0x020004DD RID: 1245
		[Serializable]
		public sealed class <>c
		{
		}
	}
}

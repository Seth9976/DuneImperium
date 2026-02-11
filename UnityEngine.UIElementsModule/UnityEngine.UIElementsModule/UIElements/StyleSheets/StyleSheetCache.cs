using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x0200028C RID: 652
	public static class StyleSheetCache : Object
	{
		// Token: 0x060030CB RID: 12491 RVA: 0x000CF318 File Offset: 0x000CD518
		// Note: this type is marked as 'beforefieldinit'.
		static StyleSheetCache()
		{
			Il2CppClassPointerStore<StyleSheetCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "StyleSheetCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleSheetCache>.NativeClassPtr);
			StyleSheetCache.NativeFieldInfoPtr_s_Comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheetCache>.NativeClassPtr, "s_Comparer");
			StyleSheetCache.NativeFieldInfoPtr_s_RulePropertyIdsCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheetCache>.NativeClassPtr, "s_RulePropertyIdsCache");
			StyleSheetCache.NativeMethodInfoPtr_GetPropertyIds_Internal_Static_Il2CppStructArray_1_StylePropertyId_StyleSheet_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheetCache>.NativeClassPtr, 100670376);
			StyleSheetCache.NativeMethodInfoPtr_GetPropertyIds_Internal_Static_Il2CppStructArray_1_StylePropertyId_StyleRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheetCache>.NativeClassPtr, 100670377);
			StyleSheetCache.NativeMethodInfoPtr_GetPropertyId_Private_Static_StylePropertyId_StyleRule_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheetCache>.NativeClassPtr, 100670378);
		}

		// Token: 0x060030CC RID: 12492 RVA: 0x000CF3AC File Offset: 0x000CD5AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358626, RefRangeEnd = 358627, XrefRangeStart = 358603, XrefRangeEnd = 358626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<StylePropertyId> GetPropertyIds(StyleSheet sheet, int ruleIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sheet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ruleIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheetCache.NativeMethodInfoPtr_GetPropertyIds_Internal_Static_Il2CppStructArray_1_StylePropertyId_StyleSheet_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<StylePropertyId>>(intPtr3) : null;
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x000CF400 File Offset: 0x000CD600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358636, RefRangeEnd = 358637, XrefRangeStart = 358627, XrefRangeEnd = 358636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<StylePropertyId> GetPropertyIds(StyleRule rule)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rule);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheetCache.NativeMethodInfoPtr_GetPropertyIds_Internal_Static_Il2CppStructArray_1_StylePropertyId_StyleRule_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<StylePropertyId>>(intPtr3) : null;
			}
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x000CF444 File Offset: 0x000CD644
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 358646, RefRangeEnd = 358648, XrefRangeStart = 358637, XrefRangeEnd = 358646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StylePropertyId GetPropertyId(StyleRule rule, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rule);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheetCache.NativeMethodInfoPtr_GetPropertyId_Private_Static_StylePropertyId_StyleRule_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x00013F06 File Offset: 0x00012106
		public StyleSheetCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x060030D0 RID: 12496 RVA: 0x000CF494 File Offset: 0x000CD694
		// (set) Token: 0x060030D1 RID: 12497 RVA: 0x00013F0F File Offset: 0x0001210F
		public unsafe static StyleSheetCache.SheetHandleKeyComparer s_Comparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StyleSheetCache.NativeFieldInfoPtr_s_Comparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleSheetCache.SheetHandleKeyComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StyleSheetCache.NativeFieldInfoPtr_s_Comparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x060030D2 RID: 12498 RVA: 0x000CF4BC File Offset: 0x000CD6BC
		// (set) Token: 0x060030D3 RID: 12499 RVA: 0x00013F21 File Offset: 0x00012121
		public unsafe static Dictionary<StyleSheetCache.SheetHandleKey, Il2CppStructArray<StylePropertyId>> s_RulePropertyIdsCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StyleSheetCache.NativeFieldInfoPtr_s_RulePropertyIdsCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StyleSheetCache.SheetHandleKey, Il2CppStructArray<StylePropertyId>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StyleSheetCache.NativeFieldInfoPtr_s_RulePropertyIdsCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060030D4 RID: 12500 RVA: 0x00013F33 File Offset: 0x00012133
		public static void ClearCaches()
		{
			StyleSheetCache.s_RulePropertyIdsCache.Clear();
		}

		// Token: 0x0400239F RID: 9119
		private static readonly IntPtr NativeFieldInfoPtr_s_Comparer;

		// Token: 0x040023A0 RID: 9120
		private static readonly IntPtr NativeFieldInfoPtr_s_RulePropertyIdsCache;

		// Token: 0x040023A1 RID: 9121
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyIds_Internal_Static_Il2CppStructArray_1_StylePropertyId_StyleSheet_Int32_0;

		// Token: 0x040023A2 RID: 9122
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyIds_Internal_Static_Il2CppStructArray_1_StylePropertyId_StyleRule_0;

		// Token: 0x040023A3 RID: 9123
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyId_Private_Static_StylePropertyId_StyleRule_Int32_0;

		// Token: 0x02000567 RID: 1383
		[StructLayout(2)]
		public struct SheetHandleKey
		{
			// Token: 0x06004244 RID: 16964 RVA: 0x001042D0 File Offset: 0x001024D0
			// Note: this type is marked as 'beforefieldinit'.
			static SheetHandleKey()
			{
				Il2CppClassPointerStore<StyleSheetCache.SheetHandleKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StyleSheetCache>.NativeClassPtr, "SheetHandleKey");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleSheetCache.SheetHandleKey>.NativeClassPtr);
				StyleSheetCache.SheetHandleKey.NativeFieldInfoPtr_sheetInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheetCache.SheetHandleKey>.NativeClassPtr, "sheetInstanceID");
				StyleSheetCache.SheetHandleKey.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheetCache.SheetHandleKey>.NativeClassPtr, "index");
				StyleSheetCache.SheetHandleKey.NativeMethodInfoPtr__ctor_Public_Void_StyleSheet_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheetCache.SheetHandleKey>.NativeClassPtr, 100670380);
			}

			// Token: 0x06004245 RID: 16965 RVA: 0x00104338 File Offset: 0x00102538
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358600, XrefRangeEnd = 358601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SheetHandleKey(StyleSheet sheet, int index)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sheet);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheetCache.SheetHandleKey.NativeMethodInfoPtr__ctor_Public_Void_StyleSheet_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004246 RID: 16966 RVA: 0x0001C51B File Offset: 0x0001A71B
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleSheetCache.SheetHandleKey>.NativeClassPtr, ref this));
			}

			// Token: 0x04002E75 RID: 11893
			private static readonly IntPtr NativeFieldInfoPtr_sheetInstanceID;

			// Token: 0x04002E76 RID: 11894
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04002E77 RID: 11895
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StyleSheet_Int32_0;

			// Token: 0x04002E78 RID: 11896
			[FieldOffset(0)]
			public readonly int sheetInstanceID;

			// Token: 0x04002E79 RID: 11897
			[FieldOffset(4)]
			public readonly int index;
		}

		// Token: 0x02000568 RID: 1384
		public class SheetHandleKeyComparer : Object
		{
			// Token: 0x06004247 RID: 16967 RVA: 0x0010437C File Offset: 0x0010257C
			// Note: this type is marked as 'beforefieldinit'.
			static SheetHandleKeyComparer()
			{
				Il2CppClassPointerStore<StyleSheetCache.SheetHandleKeyComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StyleSheetCache>.NativeClassPtr, "SheetHandleKeyComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleSheetCache.SheetHandleKeyComparer>.NativeClassPtr);
				StyleSheetCache.SheetHandleKeyComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SheetHandleKey_SheetHandleKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheetCache.SheetHandleKeyComparer>.NativeClassPtr, 100670381);
				StyleSheetCache.SheetHandleKeyComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_SheetHandleKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheetCache.SheetHandleKeyComparer>.NativeClassPtr, 100670382);
				StyleSheetCache.SheetHandleKeyComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheetCache.SheetHandleKeyComparer>.NativeClassPtr, 100670383);
			}

			// Token: 0x06004248 RID: 16968 RVA: 0x001043E4 File Offset: 0x001025E4
			[CallerCount(0)]
			public unsafe virtual bool Equals(StyleSheetCache.SheetHandleKey x, StyleSheetCache.SheetHandleKey y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheetCache.SheetHandleKeyComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SheetHandleKey_SheetHandleKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004249 RID: 16969 RVA: 0x0010443C File Offset: 0x0010263C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358601, XrefRangeEnd = 358603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int GetHashCode(StyleSheetCache.SheetHandleKey key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref key;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheetCache.SheetHandleKeyComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_SheetHandleKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600424A RID: 16970 RVA: 0x00104488 File Offset: 0x00102688
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SheetHandleKeyComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleSheetCache.SheetHandleKeyComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheetCache.SheetHandleKeyComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600424B RID: 16971 RVA: 0x0001C52D File Offset: 0x0001A72D
			public SheetHandleKeyComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002E7A RID: 11898
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SheetHandleKey_SheetHandleKey_0;

			// Token: 0x04002E7B RID: 11899
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_SheetHandleKey_0;

			// Token: 0x04002E7C RID: 11900
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

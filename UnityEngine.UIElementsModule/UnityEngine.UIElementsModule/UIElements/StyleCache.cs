using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000238 RID: 568
	public static class StyleCache : Object
	{
		// Token: 0x060029EC RID: 10732 RVA: 0x000B6E80 File Offset: 0x000B5080
		// Note: this type is marked as 'beforefieldinit'.
		static StyleCache()
		{
			Il2CppClassPointerStore<StyleCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleCache>.NativeClassPtr);
			StyleCache.NativeFieldInfoPtr_s_ComputedStyleCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleCache>.NativeClassPtr, "s_ComputedStyleCache");
			StyleCache.NativeFieldInfoPtr_s_StyleVariableContextCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleCache>.NativeClassPtr, "s_StyleVariableContextCache");
			StyleCache.NativeFieldInfoPtr_s_ComputedTransitionsCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleCache>.NativeClassPtr, "s_ComputedTransitionsCache");
			StyleCache.NativeMethodInfoPtr_TryGetValue_Public_Static_Boolean_Int64_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleCache>.NativeClassPtr, 100669579);
			StyleCache.NativeMethodInfoPtr_SetValue_Public_Static_Void_Int64_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleCache>.NativeClassPtr, 100669580);
			StyleCache.NativeMethodInfoPtr_TryGetValue_Public_Static_Boolean_Int32_byref_StyleVariableContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleCache>.NativeClassPtr, 100669581);
			StyleCache.NativeMethodInfoPtr_SetValue_Public_Static_Void_Int32_StyleVariableContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleCache>.NativeClassPtr, 100669582);
			StyleCache.NativeMethodInfoPtr_TryGetValue_Public_Static_Boolean_Int32_byref_Il2CppReferenceArray_1_ComputedTransitionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleCache>.NativeClassPtr, 100669583);
			StyleCache.NativeMethodInfoPtr_SetValue_Public_Static_Void_Int32_Il2CppReferenceArray_1_ComputedTransitionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleCache>.NativeClassPtr, 100669584);
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x000B6F64 File Offset: 0x000B5164
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347000, RefRangeEnd = 347001, XrefRangeStart = 346964, XrefRangeEnd = 347000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetValue(long hash, out ComputedStyle data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StyleCache.NativeMethodInfoPtr_TryGetValue_Public_Static_Boolean_Int64_byref_ComputedStyle_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : new ComputedStyle(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x000B6FC4 File Offset: 0x000B51C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347001, XrefRangeEnd = 347008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetValue(long hash, ref ComputedStyle data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleCache.NativeMethodInfoPtr_SetValue_Public_Static_Void_Int64_byref_ComputedStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029EF RID: 10735 RVA: 0x000B700C File Offset: 0x000B520C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347008, XrefRangeEnd = 347016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetValue(int hash, out StyleVariableContext data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StyleCache.NativeMethodInfoPtr_TryGetValue_Public_Static_Boolean_Int32_byref_StyleVariableContext_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : new StyleVariableContext(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060029F0 RID: 10736 RVA: 0x000B706C File Offset: 0x000B526C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347016, XrefRangeEnd = 347024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetValue(int hash, StyleVariableContext data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleCache.NativeMethodInfoPtr_SetValue_Public_Static_Void_Int32_StyleVariableContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x000B70B0 File Offset: 0x000B52B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 347032, RefRangeEnd = 347034, XrefRangeStart = 347024, XrefRangeEnd = 347032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetValue(int hash, out Il2CppReferenceArray<ComputedTransitionProperty> data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StyleCache.NativeMethodInfoPtr_TryGetValue_Public_Static_Boolean_Int32_byref_Il2CppReferenceArray_1_ComputedTransitionProperty_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<ComputedTransitionProperty>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x000B7110 File Offset: 0x000B5310
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 347042, RefRangeEnd = 347044, XrefRangeStart = 347034, XrefRangeEnd = 347042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetValue(int hash, Il2CppReferenceArray<ComputedTransitionProperty> data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleCache.NativeMethodInfoPtr_SetValue_Public_Static_Void_Int32_Il2CppReferenceArray_1_ComputedTransitionProperty_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029F3 RID: 10739 RVA: 0x00010DD8 File Offset: 0x0000EFD8
		public StyleCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x060029F4 RID: 10740 RVA: 0x000B7154 File Offset: 0x000B5354
		// (set) Token: 0x060029F5 RID: 10741 RVA: 0x00010DE1 File Offset: 0x0000EFE1
		public unsafe static Dictionary<long, ComputedStyle> s_ComputedStyleCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StyleCache.NativeFieldInfoPtr_s_ComputedStyleCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<long, ComputedStyle>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StyleCache.NativeFieldInfoPtr_s_ComputedStyleCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x060029F6 RID: 10742 RVA: 0x000B717C File Offset: 0x000B537C
		// (set) Token: 0x060029F7 RID: 10743 RVA: 0x00010DF3 File Offset: 0x0000EFF3
		public unsafe static Dictionary<int, StyleVariableContext> s_StyleVariableContextCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StyleCache.NativeFieldInfoPtr_s_StyleVariableContextCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, StyleVariableContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StyleCache.NativeFieldInfoPtr_s_StyleVariableContextCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x060029F8 RID: 10744 RVA: 0x000B71A4 File Offset: 0x000B53A4
		// (set) Token: 0x060029F9 RID: 10745 RVA: 0x00010E05 File Offset: 0x0000F005
		public unsafe static Dictionary<int, Il2CppReferenceArray<ComputedTransitionProperty>> s_ComputedTransitionsCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StyleCache.NativeFieldInfoPtr_s_ComputedTransitionsCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<ComputedTransitionProperty>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StyleCache.NativeFieldInfoPtr_s_ComputedTransitionsCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x000B71CC File Offset: 0x000B53CC
		public static void ClearStyleCache()
		{
			Dictionary<long, ComputedStyle>.Enumerator enumerator = StyleCache.s_ComputedStyleCache.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<long, ComputedStyle> keyValuePair = enumerator.Current;
					ComputedStyle value = keyValuePair.Value;
					value.Release();
				}
			}
			finally
			{
				enumerator.Dispose();
			}
			StyleCache.s_ComputedStyleCache.Clear();
			StyleCache.s_StyleVariableContextCache.Clear();
			StyleCache.s_ComputedTransitionsCache.Clear();
		}

		// Token: 0x04001DD5 RID: 7637
		private static readonly IntPtr NativeFieldInfoPtr_s_ComputedStyleCache;

		// Token: 0x04001DD6 RID: 7638
		private static readonly IntPtr NativeFieldInfoPtr_s_StyleVariableContextCache;

		// Token: 0x04001DD7 RID: 7639
		private static readonly IntPtr NativeFieldInfoPtr_s_ComputedTransitionsCache;

		// Token: 0x04001DD8 RID: 7640
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Static_Boolean_Int64_byref_ComputedStyle_0;

		// Token: 0x04001DD9 RID: 7641
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Static_Void_Int64_byref_ComputedStyle_0;

		// Token: 0x04001DDA RID: 7642
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Static_Boolean_Int32_byref_StyleVariableContext_0;

		// Token: 0x04001DDB RID: 7643
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Static_Void_Int32_StyleVariableContext_0;

		// Token: 0x04001DDC RID: 7644
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Static_Boolean_Int32_byref_Il2CppReferenceArray_1_ComputedTransitionProperty_0;

		// Token: 0x04001DDD RID: 7645
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Static_Void_Int32_Il2CppReferenceArray_1_ComputedTransitionProperty_0;
	}
}

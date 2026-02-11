using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x02000280 RID: 640
	public static class StylePropertyCache : Object
	{
		// Token: 0x06003024 RID: 12324 RVA: 0x000CC998 File Offset: 0x000CAB98
		// Note: this type is marked as 'beforefieldinit'.
		static StylePropertyCache()
		{
			Il2CppClassPointerStore<StylePropertyCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "StylePropertyCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyCache>.NativeClassPtr);
			StylePropertyCache.NativeFieldInfoPtr_s_PropertySyntaxCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyCache>.NativeClassPtr, "s_PropertySyntaxCache");
			StylePropertyCache.NativeFieldInfoPtr_s_NonTerminalValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyCache>.NativeClassPtr, "s_NonTerminalValues");
			StylePropertyCache.NativeMethodInfoPtr_TryGetSyntax_Public_Static_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyCache>.NativeClassPtr, 100670295);
			StylePropertyCache.NativeMethodInfoPtr_TryGetNonTerminalValue_Public_Static_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyCache>.NativeClassPtr, 100670296);
		}

		// Token: 0x06003025 RID: 12325 RVA: 0x000CCA18 File Offset: 0x000CAC18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 357053, RefRangeEnd = 357055, XrefRangeStart = 356489, XrefRangeEnd = 357053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetSyntax(string name, out string syntax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StylePropertyCache.NativeMethodInfoPtr_TryGetSyntax_Public_Static_Boolean_String_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			syntax = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003026 RID: 12326 RVA: 0x000CCA74 File Offset: 0x000CAC74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 357063, RefRangeEnd = 357064, XrefRangeStart = 357055, XrefRangeEnd = 357063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetNonTerminalValue(string name, out string syntax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StylePropertyCache.NativeMethodInfoPtr_TryGetNonTerminalValue_Public_Static_Boolean_String_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			syntax = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003027 RID: 12327 RVA: 0x00013B0D File Offset: 0x00011D0D
		public StylePropertyCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06003028 RID: 12328 RVA: 0x000CCAD0 File Offset: 0x000CACD0
		// (set) Token: 0x06003029 RID: 12329 RVA: 0x00013B16 File Offset: 0x00011D16
		public unsafe static Dictionary<string, string> s_PropertySyntaxCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StylePropertyCache.NativeFieldInfoPtr_s_PropertySyntaxCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StylePropertyCache.NativeFieldInfoPtr_s_PropertySyntaxCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x0600302A RID: 12330 RVA: 0x000CCAF8 File Offset: 0x000CACF8
		// (set) Token: 0x0600302B RID: 12331 RVA: 0x00013B28 File Offset: 0x00011D28
		public unsafe static Dictionary<string, string> s_NonTerminalValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StylePropertyCache.NativeFieldInfoPtr_s_NonTerminalValues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StylePropertyCache.NativeFieldInfoPtr_s_NonTerminalValues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600302C RID: 12332 RVA: 0x000CCB20 File Offset: 0x000CAD20
		public static string FindClosestPropertyName(string name)
		{
			float num = float.MaxValue;
			string text = null;
			Dictionary<string, string>.KeyCollection.Enumerator enumerator = StylePropertyCache.s_PropertySyntaxCache.Keys.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string text2 = enumerator.Current;
					float num2 = 1f;
					bool flag = text2.Contains(name);
					if (flag)
					{
						num2 = 0.1f;
					}
					float num3 = (float)StringUtils.LevenshteinDistance(name, text2) * num2;
					bool flag2 = num3 < num;
					if (flag2)
					{
						num = num3;
						text = text2;
					}
				}
			}
			finally
			{
				enumerator.Dispose();
			}
			return text;
		}

		// Token: 0x040022B3 RID: 8883
		private static readonly IntPtr NativeFieldInfoPtr_s_PropertySyntaxCache;

		// Token: 0x040022B4 RID: 8884
		private static readonly IntPtr NativeFieldInfoPtr_s_NonTerminalValues;

		// Token: 0x040022B5 RID: 8885
		private static readonly IntPtr NativeMethodInfoPtr_TryGetSyntax_Public_Static_Boolean_String_byref_String_0;

		// Token: 0x040022B6 RID: 8886
		private static readonly IntPtr NativeMethodInfoPtr_TryGetNonTerminalValue_Public_Static_Boolean_String_byref_String_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000037 RID: 55
	public class TextResourceManager : Object
	{
		// Token: 0x060005B5 RID: 1461 RVA: 0x0001853C File Offset: 0x0001673C
		// Note: this type is marked as 'beforefieldinit'.
		static TextResourceManager()
		{
			Il2CppClassPointerStore<TextResourceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextResourceManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextResourceManager>.NativeClassPtr);
			TextResourceManager.NativeFieldInfoPtr_s_FontAssetReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextResourceManager>.NativeClassPtr, "s_FontAssetReferences");
			TextResourceManager.NativeFieldInfoPtr_s_FontAssetNameReferenceLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextResourceManager>.NativeClassPtr, "s_FontAssetNameReferenceLookup");
			TextResourceManager.NativeFieldInfoPtr_s_FontAssetFamilyNameAndStyleReferenceLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextResourceManager>.NativeClassPtr, "s_FontAssetFamilyNameAndStyleReferenceLookup");
			TextResourceManager.NativeFieldInfoPtr_s_FontAssetRemovalList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextResourceManager>.NativeClassPtr, "s_FontAssetRemovalList");
			TextResourceManager.NativeFieldInfoPtr_k_RegularStyleHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextResourceManager>.NativeClassPtr, "k_RegularStyleHashCode");
			TextResourceManager.NativeMethodInfoPtr_AddFontAsset_Internal_Static_Void_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextResourceManager>.NativeClassPtr, 100663699);
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x000185E4 File Offset: 0x000167E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105673, RefRangeEnd = 1105674, XrefRangeStart = 1105609, XrefRangeEnd = 1105673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddFontAsset(FontAsset fontAsset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextResourceManager.NativeMethodInfoPtr_AddFontAsset_Internal_Static_Void_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0000589B File Offset: 0x00003A9B
		public TextResourceManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x0001861C File Offset: 0x0001681C
		// (set) Token: 0x060005B9 RID: 1465 RVA: 0x000058A4 File Offset: 0x00003AA4
		public unsafe static Dictionary<int, TextResourceManager.FontAssetRef> s_FontAssetReferences
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextResourceManager.NativeFieldInfoPtr_s_FontAssetReferences, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TextResourceManager.FontAssetRef>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextResourceManager.NativeFieldInfoPtr_s_FontAssetReferences, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x00018644 File Offset: 0x00016844
		// (set) Token: 0x060005BB RID: 1467 RVA: 0x000058B6 File Offset: 0x00003AB6
		public unsafe static Dictionary<int, FontAsset> s_FontAssetNameReferenceLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextResourceManager.NativeFieldInfoPtr_s_FontAssetNameReferenceLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, FontAsset>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextResourceManager.NativeFieldInfoPtr_s_FontAssetNameReferenceLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x0001866C File Offset: 0x0001686C
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x000058C8 File Offset: 0x00003AC8
		public unsafe static Dictionary<long, FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextResourceManager.NativeFieldInfoPtr_s_FontAssetFamilyNameAndStyleReferenceLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<long, FontAsset>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextResourceManager.NativeFieldInfoPtr_s_FontAssetFamilyNameAndStyleReferenceLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x00018694 File Offset: 0x00016894
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x000058DA File Offset: 0x00003ADA
		public unsafe static List<int> s_FontAssetRemovalList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextResourceManager.NativeFieldInfoPtr_s_FontAssetRemovalList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextResourceManager.NativeFieldInfoPtr_s_FontAssetRemovalList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x000186BC File Offset: 0x000168BC
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x000058EC File Offset: 0x00003AEC
		public unsafe static int k_RegularStyleHashCode
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextResourceManager.NativeFieldInfoPtr_k_RegularStyleHashCode, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextResourceManager.NativeFieldInfoPtr_k_RegularStyleHashCode, (void*)(&value));
			}
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x000186D8 File Offset: 0x000168D8
		public static void RemoveFontAsset(FontAsset fontAsset)
		{
			int instanceID = fontAsset.instanceID;
			TextResourceManager.FontAssetRef fontAssetRef;
			bool flag = TextResourceManager.s_FontAssetReferences.TryGetValue(instanceID, out fontAssetRef);
			if (flag)
			{
				TextResourceManager.s_FontAssetNameReferenceLookup.Remove(fontAssetRef.nameHashCode);
				TextResourceManager.s_FontAssetFamilyNameAndStyleReferenceLookup.Remove(fontAssetRef.familyNameAndStyleHashCode);
				TextResourceManager.s_FontAssetReferences.Remove(instanceID);
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00018730 File Offset: 0x00016930
		public static bool TryGetFontAssetByName(int nameHashcode, out FontAsset fontAsset)
		{
			fontAsset = null;
			return TextResourceManager.s_FontAssetNameReferenceLookup.TryGetValue(nameHashcode, out fontAsset);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00018754 File Offset: 0x00016954
		public static bool TryGetFontAssetByFamilyName(int familyNameHashCode, int styleNameHashCode, out FontAsset fontAsset)
		{
			fontAsset = null;
			bool flag = styleNameHashCode == 0;
			if (flag)
			{
				styleNameHashCode = TextResourceManager.k_RegularStyleHashCode;
			}
			long num = ((long)styleNameHashCode << 32) | (long)((ulong)familyNameHashCode);
			return TextResourceManager.s_FontAssetFamilyNameAndStyleReferenceLookup.TryGetValue(num, out fontAsset);
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00018790 File Offset: 0x00016990
		public static void RebuildFontAssetCache()
		{
			Dictionary<int, TextResourceManager.FontAssetRef>.Enumerator enumerator = TextResourceManager.s_FontAssetReferences.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<int, TextResourceManager.FontAssetRef> keyValuePair = enumerator.Current;
					TextResourceManager.FontAssetRef value = keyValuePair.Value;
					FontAsset fontAsset = value.fontAsset;
					bool flag = fontAsset == null;
					if (flag)
					{
						TextResourceManager.s_FontAssetNameReferenceLookup.Remove(value.nameHashCode);
						TextResourceManager.s_FontAssetFamilyNameAndStyleReferenceLookup.Remove(value.familyNameAndStyleHashCode);
						TextResourceManager.s_FontAssetRemovalList.Add(keyValuePair.Key);
					}
					else
					{
						fontAsset.InitializeCharacterLookupDictionary();
						fontAsset.AddSynthesizedCharactersAndFaceMetrics();
					}
				}
			}
			finally
			{
				enumerator.Dispose();
			}
			for (int i = 0; i < TextResourceManager.s_FontAssetRemovalList.Count; i++)
			{
				TextResourceManager.s_FontAssetReferences.Remove(TextResourceManager.s_FontAssetRemovalList[i]);
			}
			TextResourceManager.s_FontAssetRemovalList.Clear();
			TextEventManager.ON_FONT_PROPERTY_CHANGED(true, null);
		}

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeFieldInfoPtr_s_FontAssetReferences;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeFieldInfoPtr_s_FontAssetNameReferenceLookup;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeFieldInfoPtr_s_FontAssetFamilyNameAndStyleReferenceLookup;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeFieldInfoPtr_s_FontAssetRemovalList;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeFieldInfoPtr_k_RegularStyleHashCode;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeMethodInfoPtr_AddFontAsset_Internal_Static_Void_FontAsset_0;

		// Token: 0x02000051 RID: 81
		public sealed class FontAssetRef : ValueType
		{
			// Token: 0x06000760 RID: 1888 RVA: 0x0001C8C8 File Offset: 0x0001AAC8
			// Note: this type is marked as 'beforefieldinit'.
			static FontAssetRef()
			{
				Il2CppClassPointerStore<TextResourceManager.FontAssetRef>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextResourceManager>.NativeClassPtr, "FontAssetRef");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextResourceManager.FontAssetRef>.NativeClassPtr);
				TextResourceManager.FontAssetRef.NativeFieldInfoPtr_nameHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextResourceManager.FontAssetRef>.NativeClassPtr, "nameHashCode");
				TextResourceManager.FontAssetRef.NativeFieldInfoPtr_familyNameHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextResourceManager.FontAssetRef>.NativeClassPtr, "familyNameHashCode");
				TextResourceManager.FontAssetRef.NativeFieldInfoPtr_styleNameHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextResourceManager.FontAssetRef>.NativeClassPtr, "styleNameHashCode");
				TextResourceManager.FontAssetRef.NativeFieldInfoPtr_familyNameAndStyleHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextResourceManager.FontAssetRef>.NativeClassPtr, "familyNameAndStyleHashCode");
				TextResourceManager.FontAssetRef.NativeFieldInfoPtr_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextResourceManager.FontAssetRef>.NativeClassPtr, "fontAsset");
				TextResourceManager.FontAssetRef.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextResourceManager.FontAssetRef>.NativeClassPtr, 100663701);
			}

			// Token: 0x06000761 RID: 1889 RVA: 0x0001C96C File Offset: 0x0001AB6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1105608, XrefRangeEnd = 1105609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FontAssetRef(int nameHashCode, int familyNameHashCode, int styleNameHashCode, FontAsset fontAsset)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextResourceManager.FontAssetRef>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref nameHashCode;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref familyNameHashCode;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styleNameHashCode;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextResourceManager.FontAssetRef.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_FontAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000762 RID: 1890 RVA: 0x000064F0 File Offset: 0x000046F0
			public FontAssetRef(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000763 RID: 1891 RVA: 0x000064F9 File Offset: 0x000046F9
			public FontAssetRef()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextResourceManager.FontAssetRef>.NativeClassPtr))
			{
			}

			// Token: 0x170002C4 RID: 708
			// (get) Token: 0x06000764 RID: 1892 RVA: 0x0001C9E8 File Offset: 0x0001ABE8
			// (set) Token: 0x06000765 RID: 1893 RVA: 0x0000650B File Offset: 0x0000470B
			public unsafe int nameHashCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextResourceManager.FontAssetRef.NativeFieldInfoPtr_nameHashCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextResourceManager.FontAssetRef.NativeFieldInfoPtr_nameHashCode)) = value;
				}
			}

			// Token: 0x170002C5 RID: 709
			// (get) Token: 0x06000766 RID: 1894 RVA: 0x0001CA10 File Offset: 0x0001AC10
			// (set) Token: 0x06000767 RID: 1895 RVA: 0x00006526 File Offset: 0x00004726
			public unsafe int familyNameHashCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextResourceManager.FontAssetRef.NativeFieldInfoPtr_familyNameHashCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextResourceManager.FontAssetRef.NativeFieldInfoPtr_familyNameHashCode)) = value;
				}
			}

			// Token: 0x170002C6 RID: 710
			// (get) Token: 0x06000768 RID: 1896 RVA: 0x0001CA38 File Offset: 0x0001AC38
			// (set) Token: 0x06000769 RID: 1897 RVA: 0x00006541 File Offset: 0x00004741
			public unsafe int styleNameHashCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextResourceManager.FontAssetRef.NativeFieldInfoPtr_styleNameHashCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextResourceManager.FontAssetRef.NativeFieldInfoPtr_styleNameHashCode)) = value;
				}
			}

			// Token: 0x170002C7 RID: 711
			// (get) Token: 0x0600076A RID: 1898 RVA: 0x0001CA60 File Offset: 0x0001AC60
			// (set) Token: 0x0600076B RID: 1899 RVA: 0x0000655C File Offset: 0x0000475C
			public unsafe long familyNameAndStyleHashCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextResourceManager.FontAssetRef.NativeFieldInfoPtr_familyNameAndStyleHashCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextResourceManager.FontAssetRef.NativeFieldInfoPtr_familyNameAndStyleHashCode)) = value;
				}
			}

			// Token: 0x170002C8 RID: 712
			// (get) Token: 0x0600076C RID: 1900 RVA: 0x0001CA88 File Offset: 0x0001AC88
			// (set) Token: 0x0600076D RID: 1901 RVA: 0x00006577 File Offset: 0x00004777
			public unsafe FontAsset fontAsset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextResourceManager.FontAssetRef.NativeFieldInfoPtr_fontAsset);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextResourceManager.FontAssetRef.NativeFieldInfoPtr_fontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005FC RID: 1532
			private static readonly IntPtr NativeFieldInfoPtr_nameHashCode;

			// Token: 0x040005FD RID: 1533
			private static readonly IntPtr NativeFieldInfoPtr_familyNameHashCode;

			// Token: 0x040005FE RID: 1534
			private static readonly IntPtr NativeFieldInfoPtr_styleNameHashCode;

			// Token: 0x040005FF RID: 1535
			private static readonly IntPtr NativeFieldInfoPtr_familyNameAndStyleHashCode;

			// Token: 0x04000600 RID: 1536
			private static readonly IntPtr NativeFieldInfoPtr_fontAsset;

			// Token: 0x04000601 RID: 1537
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_FontAsset_0;
		}
	}
}

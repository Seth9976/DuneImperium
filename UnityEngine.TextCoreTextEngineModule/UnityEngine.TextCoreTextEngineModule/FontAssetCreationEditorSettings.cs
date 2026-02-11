using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000006 RID: 6
	[Serializable]
	public sealed class FontAssetCreationEditorSettings : ValueType
	{
		// Token: 0x06000014 RID: 20 RVA: 0x000069F0 File Offset: 0x00004BF0
		// Note: this type is marked as 'beforefieldinit'.
		static FontAssetCreationEditorSettings()
		{
			Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "FontAssetCreationEditorSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr);
			FontAssetCreationEditorSettings.NativeFieldInfoPtr_sourceFontFileGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "sourceFontFileGUID");
			FontAssetCreationEditorSettings.NativeFieldInfoPtr_faceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "faceIndex");
			FontAssetCreationEditorSettings.NativeFieldInfoPtr_pointSizeSamplingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "pointSizeSamplingMode");
			FontAssetCreationEditorSettings.NativeFieldInfoPtr_pointSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "pointSize");
			FontAssetCreationEditorSettings.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "padding");
			FontAssetCreationEditorSettings.NativeFieldInfoPtr_paddingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "paddingMode");
			FontAssetCreationEditorSettings.NativeFieldInfoPtr_packingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "packingMode");
			FontAssetCreationEditorSettings.NativeFieldInfoPtr_atlasWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "atlasWidth");
			FontAssetCreationEditorSettings.NativeFieldInfoPtr_atlasHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "atlasHeight");
			FontAssetCreationEditorSettings.NativeFieldInfoPtr_characterSetSelectionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "characterSetSelectionMode");
			FontAssetCreationEditorSettings.NativeFieldInfoPtr_characterSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "characterSequence");
			FontAssetCreationEditorSettings.NativeFieldInfoPtr_referencedFontAssetGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "referencedFontAssetGUID");
			FontAssetCreationEditorSettings.NativeFieldInfoPtr_referencedTextAssetGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "referencedTextAssetGUID");
			FontAssetCreationEditorSettings.NativeFieldInfoPtr_fontStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "fontStyle");
			FontAssetCreationEditorSettings.NativeFieldInfoPtr_fontStyleModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "fontStyleModifier");
			FontAssetCreationEditorSettings.NativeFieldInfoPtr_renderMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "renderMode");
			FontAssetCreationEditorSettings.NativeFieldInfoPtr_includeFontFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "includeFontFeatures");
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000020BB File Offset: 0x000002BB
		public FontAssetCreationEditorSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020C4 File Offset: 0x000002C4
		public FontAssetCreationEditorSettings()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr))
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00006B74 File Offset: 0x00004D74
		// (set) Token: 0x06000018 RID: 24 RVA: 0x000020D6 File Offset: 0x000002D6
		public unsafe string sourceFontFileGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_sourceFontFileGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_sourceFontFileGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00006B9C File Offset: 0x00004D9C
		// (set) Token: 0x0600001A RID: 26 RVA: 0x000020F5 File Offset: 0x000002F5
		public unsafe int faceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_faceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_faceIndex)) = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00006BC4 File Offset: 0x00004DC4
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00002110 File Offset: 0x00000310
		public unsafe int pointSizeSamplingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_pointSizeSamplingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_pointSizeSamplingMode)) = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00006BEC File Offset: 0x00004DEC
		// (set) Token: 0x0600001E RID: 30 RVA: 0x0000212B File Offset: 0x0000032B
		public unsafe int pointSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_pointSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_pointSize)) = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00006C14 File Offset: 0x00004E14
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002146 File Offset: 0x00000346
		public unsafe int padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_padding)) = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00006C3C File Offset: 0x00004E3C
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002161 File Offset: 0x00000361
		public unsafe int paddingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_paddingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_paddingMode)) = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00006C64 File Offset: 0x00004E64
		// (set) Token: 0x06000024 RID: 36 RVA: 0x0000217C File Offset: 0x0000037C
		public unsafe int packingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_packingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_packingMode)) = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00006C8C File Offset: 0x00004E8C
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002197 File Offset: 0x00000397
		public unsafe int atlasWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_atlasWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_atlasWidth)) = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00006CB4 File Offset: 0x00004EB4
		// (set) Token: 0x06000028 RID: 40 RVA: 0x000021B2 File Offset: 0x000003B2
		public unsafe int atlasHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_atlasHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_atlasHeight)) = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00006CDC File Offset: 0x00004EDC
		// (set) Token: 0x0600002A RID: 42 RVA: 0x000021CD File Offset: 0x000003CD
		public unsafe int characterSetSelectionMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_characterSetSelectionMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_characterSetSelectionMode)) = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00006D04 File Offset: 0x00004F04
		// (set) Token: 0x0600002C RID: 44 RVA: 0x000021E8 File Offset: 0x000003E8
		public unsafe string characterSequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_characterSequence);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_characterSequence), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00006D2C File Offset: 0x00004F2C
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00002207 File Offset: 0x00000407
		public unsafe string referencedFontAssetGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_referencedFontAssetGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_referencedFontAssetGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00006D54 File Offset: 0x00004F54
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002226 File Offset: 0x00000426
		public unsafe string referencedTextAssetGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_referencedTextAssetGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_referencedTextAssetGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00006D7C File Offset: 0x00004F7C
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00002245 File Offset: 0x00000445
		public unsafe int fontStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_fontStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_fontStyle)) = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00006DA4 File Offset: 0x00004FA4
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00002260 File Offset: 0x00000460
		public unsafe float fontStyleModifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_fontStyleModifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_fontStyleModifier)) = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00006DCC File Offset: 0x00004FCC
		// (set) Token: 0x06000036 RID: 54 RVA: 0x0000227B File Offset: 0x0000047B
		public unsafe int renderMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_renderMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_renderMode)) = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00006DF4 File Offset: 0x00004FF4
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00002296 File Offset: 0x00000496
		public unsafe bool includeFontFeatures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_includeFontFeatures);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontAssetCreationEditorSettings.NativeFieldInfoPtr_includeFontFeatures)) = value;
			}
		}

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_sourceFontFileGUID;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_faceIndex;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_pointSizeSamplingMode;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_pointSize;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_padding;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_paddingMode;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_packingMode;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_atlasWidth;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_atlasHeight;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr_characterSetSelectionMode;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr_characterSequence;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr_referencedFontAssetGUID;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr_referencedTextAssetGUID;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr_fontStyle;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr_fontStyleModifier;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_renderMode;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_includeFontFeatures;
	}
}

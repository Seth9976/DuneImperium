using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	public sealed class TextGenerationSettings : ValueType
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000027CC File Offset: 0x000009CC
		// Note: this type is marked as 'beforefieldinit'.
		static TextGenerationSettings()
		{
			Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextRenderingModule.dll", "UnityEngine", "TextGenerationSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr);
			TextGenerationSettings.NativeFieldInfoPtr_font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "font");
			TextGenerationSettings.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "color");
			TextGenerationSettings.NativeFieldInfoPtr_fontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "fontSize");
			TextGenerationSettings.NativeFieldInfoPtr_lineSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "lineSpacing");
			TextGenerationSettings.NativeFieldInfoPtr_richText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "richText");
			TextGenerationSettings.NativeFieldInfoPtr_scaleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "scaleFactor");
			TextGenerationSettings.NativeFieldInfoPtr_fontStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "fontStyle");
			TextGenerationSettings.NativeFieldInfoPtr_textAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "textAnchor");
			TextGenerationSettings.NativeFieldInfoPtr_alignByGeometry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "alignByGeometry");
			TextGenerationSettings.NativeFieldInfoPtr_resizeTextForBestFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "resizeTextForBestFit");
			TextGenerationSettings.NativeFieldInfoPtr_resizeTextMinSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "resizeTextMinSize");
			TextGenerationSettings.NativeFieldInfoPtr_resizeTextMaxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "resizeTextMaxSize");
			TextGenerationSettings.NativeFieldInfoPtr_updateBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "updateBounds");
			TextGenerationSettings.NativeFieldInfoPtr_verticalOverflow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "verticalOverflow");
			TextGenerationSettings.NativeFieldInfoPtr_horizontalOverflow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "horizontalOverflow");
			TextGenerationSettings.NativeFieldInfoPtr_generationExtents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "generationExtents");
			TextGenerationSettings.NativeFieldInfoPtr_pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "pivot");
			TextGenerationSettings.NativeFieldInfoPtr_generateOutOfBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "generateOutOfBounds");
			TextGenerationSettings.NativeMethodInfoPtr_CompareColors_Private_Boolean_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, 100663297);
			TextGenerationSettings.NativeMethodInfoPtr_CompareVector2_Private_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, 100663298);
			TextGenerationSettings.NativeMethodInfoPtr_Equals_Public_Boolean_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, 100663299);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000029A0 File Offset: 0x00000BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261933, XrefRangeEnd = 1261937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompareColors(Color left, Color right)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerationSettings.NativeMethodInfoPtr_CompareColors_Private_Boolean_Color_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000029FC File Offset: 0x00000BFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1261938, RefRangeEnd = 1261940, XrefRangeStart = 1261937, XrefRangeEnd = 1261938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompareVector2(Vector2 left, Vector2 right)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerationSettings.NativeMethodInfoPtr_CompareVector2_Private_Boolean_Vector2_Vector2_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002A58 File Offset: 0x00000C58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1261953, RefRangeEnd = 1261954, XrefRangeStart = 1261940, XrefRangeEnd = 1261953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(TextGenerationSettings other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerationSettings.NativeMethodInfoPtr_Equals_Public_Boolean_TextGenerationSettings_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		public TextGenerationSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002059 File Offset: 0x00000259
		public TextGenerationSettings()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr))
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002AB0 File Offset: 0x00000CB0
		// (set) Token: 0x06000008 RID: 8 RVA: 0x0000206B File Offset: 0x0000026B
		public unsafe Font font
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_font);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_font), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002AE0 File Offset: 0x00000CE0
		// (set) Token: 0x0600000A RID: 10 RVA: 0x0000208A File Offset: 0x0000028A
		public unsafe Color color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_color)) = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002B08 File Offset: 0x00000D08
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000020A5 File Offset: 0x000002A5
		public unsafe int fontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_fontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_fontSize)) = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002B30 File Offset: 0x00000D30
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000020C0 File Offset: 0x000002C0
		public unsafe float lineSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_lineSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_lineSpacing)) = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002B58 File Offset: 0x00000D58
		// (set) Token: 0x06000010 RID: 16 RVA: 0x000020DB File Offset: 0x000002DB
		public unsafe bool richText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_richText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_richText)) = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002B80 File Offset: 0x00000D80
		// (set) Token: 0x06000012 RID: 18 RVA: 0x000020F6 File Offset: 0x000002F6
		public unsafe float scaleFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_scaleFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_scaleFactor)) = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002BA8 File Offset: 0x00000DA8
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002111 File Offset: 0x00000311
		public unsafe FontStyle fontStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_fontStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_fontStyle)) = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002BD0 File Offset: 0x00000DD0
		// (set) Token: 0x06000016 RID: 22 RVA: 0x0000212C File Offset: 0x0000032C
		public unsafe TextAnchor textAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_textAnchor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_textAnchor)) = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002BF8 File Offset: 0x00000DF8
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002147 File Offset: 0x00000347
		public unsafe bool alignByGeometry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_alignByGeometry);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_alignByGeometry)) = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002C20 File Offset: 0x00000E20
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002162 File Offset: 0x00000362
		public unsafe bool resizeTextForBestFit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_resizeTextForBestFit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_resizeTextForBestFit)) = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002C48 File Offset: 0x00000E48
		// (set) Token: 0x0600001C RID: 28 RVA: 0x0000217D File Offset: 0x0000037D
		public unsafe int resizeTextMinSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_resizeTextMinSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_resizeTextMinSize)) = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002C70 File Offset: 0x00000E70
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002198 File Offset: 0x00000398
		public unsafe int resizeTextMaxSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_resizeTextMaxSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_resizeTextMaxSize)) = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002C98 File Offset: 0x00000E98
		// (set) Token: 0x06000020 RID: 32 RVA: 0x000021B3 File Offset: 0x000003B3
		public unsafe bool updateBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_updateBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_updateBounds)) = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002CC0 File Offset: 0x00000EC0
		// (set) Token: 0x06000022 RID: 34 RVA: 0x000021CE File Offset: 0x000003CE
		public unsafe VerticalWrapMode verticalOverflow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_verticalOverflow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_verticalOverflow)) = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002CE8 File Offset: 0x00000EE8
		// (set) Token: 0x06000024 RID: 36 RVA: 0x000021E9 File Offset: 0x000003E9
		public unsafe HorizontalWrapMode horizontalOverflow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_horizontalOverflow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_horizontalOverflow)) = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002D10 File Offset: 0x00000F10
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002204 File Offset: 0x00000404
		public unsafe Vector2 generationExtents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_generationExtents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_generationExtents)) = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002D38 File Offset: 0x00000F38
		// (set) Token: 0x06000028 RID: 40 RVA: 0x0000221F File Offset: 0x0000041F
		public unsafe Vector2 pivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_pivot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_pivot)) = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002D60 File Offset: 0x00000F60
		// (set) Token: 0x0600002A RID: 42 RVA: 0x0000223A File Offset: 0x0000043A
		public unsafe bool generateOutOfBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_generateOutOfBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_generateOutOfBounds)) = value;
			}
		}

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_font;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_fontSize;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_lineSpacing;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr_richText;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_scaleFactor;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_fontStyle;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_textAnchor;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_alignByGeometry;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_resizeTextForBestFit;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_resizeTextMinSize;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_resizeTextMaxSize;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_updateBounds;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_verticalOverflow;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_horizontalOverflow;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_generationExtents;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr_pivot;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr_generateOutOfBounds;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_CompareColors_Private_Boolean_Color_Color_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_CompareVector2_Private_Boolean_Vector2_Vector2_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_TextGenerationSettings_0;
	}
}

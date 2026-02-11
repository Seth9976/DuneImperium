using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x02000010 RID: 16
	[Serializable]
	public class FontData : Object
	{
		// Token: 0x06000115 RID: 277 RVA: 0x0000B598 File Offset: 0x00009798
		// Note: this type is marked as 'beforefieldinit'.
		static FontData()
		{
			Il2CppClassPointerStore<FontData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "FontData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontData>.NativeClassPtr);
			FontData.NativeFieldInfoPtr_m_Font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontData>.NativeClassPtr, "m_Font");
			FontData.NativeFieldInfoPtr_m_FontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontData>.NativeClassPtr, "m_FontSize");
			FontData.NativeFieldInfoPtr_m_FontStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontData>.NativeClassPtr, "m_FontStyle");
			FontData.NativeFieldInfoPtr_m_BestFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontData>.NativeClassPtr, "m_BestFit");
			FontData.NativeFieldInfoPtr_m_MinSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontData>.NativeClassPtr, "m_MinSize");
			FontData.NativeFieldInfoPtr_m_MaxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontData>.NativeClassPtr, "m_MaxSize");
			FontData.NativeFieldInfoPtr_m_Alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontData>.NativeClassPtr, "m_Alignment");
			FontData.NativeFieldInfoPtr_m_AlignByGeometry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontData>.NativeClassPtr, "m_AlignByGeometry");
			FontData.NativeFieldInfoPtr_m_RichText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontData>.NativeClassPtr, "m_RichText");
			FontData.NativeFieldInfoPtr_m_HorizontalOverflow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontData>.NativeClassPtr, "m_HorizontalOverflow");
			FontData.NativeFieldInfoPtr_m_VerticalOverflow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontData>.NativeClassPtr, "m_VerticalOverflow");
			FontData.NativeFieldInfoPtr_m_LineSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontData>.NativeClassPtr, "m_LineSpacing");
			FontData.NativeMethodInfoPtr_get_defaultFontData_Public_Static_get_FontData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663491);
			FontData.NativeMethodInfoPtr_get_font_Public_get_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663492);
			FontData.NativeMethodInfoPtr_set_font_Public_set_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663493);
			FontData.NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663494);
			FontData.NativeMethodInfoPtr_set_fontSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663495);
			FontData.NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663496);
			FontData.NativeMethodInfoPtr_set_fontStyle_Public_set_Void_FontStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663497);
			FontData.NativeMethodInfoPtr_get_bestFit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663498);
			FontData.NativeMethodInfoPtr_set_bestFit_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663499);
			FontData.NativeMethodInfoPtr_get_minSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663500);
			FontData.NativeMethodInfoPtr_set_minSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663501);
			FontData.NativeMethodInfoPtr_get_maxSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663502);
			FontData.NativeMethodInfoPtr_set_maxSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663503);
			FontData.NativeMethodInfoPtr_get_alignment_Public_get_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663504);
			FontData.NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663505);
			FontData.NativeMethodInfoPtr_get_alignByGeometry_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663506);
			FontData.NativeMethodInfoPtr_set_alignByGeometry_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663507);
			FontData.NativeMethodInfoPtr_get_richText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663508);
			FontData.NativeMethodInfoPtr_set_richText_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663509);
			FontData.NativeMethodInfoPtr_get_horizontalOverflow_Public_get_HorizontalWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663510);
			FontData.NativeMethodInfoPtr_set_horizontalOverflow_Public_set_Void_HorizontalWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663511);
			FontData.NativeMethodInfoPtr_get_verticalOverflow_Public_get_VerticalWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663512);
			FontData.NativeMethodInfoPtr_set_verticalOverflow_Public_set_Void_VerticalWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663513);
			FontData.NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663514);
			FontData.NativeMethodInfoPtr_set_lineSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663515);
			FontData.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663516);
			FontData.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663517);
			FontData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontData>.NativeClassPtr, 100663518);
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0000B8E8 File Offset: 0x00009AE8
		public unsafe static FontData defaultFontData
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1083488, RefRangeEnd = 1083489, XrefRangeStart = 1083484, XrefRangeEnd = 1083488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_defaultFontData_Public_Static_get_FontData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FontData>(intPtr3) : null;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000B91C File Offset: 0x00009B1C
		// (set) Token: 0x06000118 RID: 280 RVA: 0x0000B95C File Offset: 0x00009B5C
		public unsafe Font font
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_font_Public_get_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Font>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_set_font_Public_set_Void_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		// (set) Token: 0x0600011A RID: 282 RVA: 0x0000B9DC File Offset: 0x00009BDC
		public unsafe int fontSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_set_fontSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0000BA1C File Offset: 0x00009C1C
		// (set) Token: 0x0600011C RID: 284 RVA: 0x0000BA58 File Offset: 0x00009C58
		public unsafe FontStyle fontStyle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_set_fontStyle_Public_set_Void_FontStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0000BA98 File Offset: 0x00009C98
		// (set) Token: 0x0600011E RID: 286 RVA: 0x0000BAD4 File Offset: 0x00009CD4
		public unsafe bool bestFit
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_bestFit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_set_bestFit_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0000BB14 File Offset: 0x00009D14
		// (set) Token: 0x06000120 RID: 288 RVA: 0x0000BB50 File Offset: 0x00009D50
		public unsafe int minSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_minSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_set_minSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0000BB90 File Offset: 0x00009D90
		// (set) Token: 0x06000122 RID: 290 RVA: 0x0000BBCC File Offset: 0x00009DCC
		public unsafe int maxSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_maxSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_set_maxSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0000BC0C File Offset: 0x00009E0C
		// (set) Token: 0x06000124 RID: 292 RVA: 0x0000BC48 File Offset: 0x00009E48
		public unsafe TextAnchor alignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_alignment_Public_get_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0000BC88 File Offset: 0x00009E88
		// (set) Token: 0x06000126 RID: 294 RVA: 0x0000BCC4 File Offset: 0x00009EC4
		public unsafe bool alignByGeometry
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_alignByGeometry_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_set_alignByGeometry_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0000BD04 File Offset: 0x00009F04
		// (set) Token: 0x06000128 RID: 296 RVA: 0x0000BD40 File Offset: 0x00009F40
		public unsafe bool richText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_richText_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 483221, RefRangeEnd = 483222, XrefRangeStart = 483221, XrefRangeEnd = 483222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_set_richText_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0000BD80 File Offset: 0x00009F80
		// (set) Token: 0x0600012A RID: 298 RVA: 0x0000BDBC File Offset: 0x00009FBC
		public unsafe HorizontalWrapMode horizontalOverflow
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 134006, RefRangeEnd = 134007, XrefRangeStart = 134006, XrefRangeEnd = 134007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_horizontalOverflow_Public_get_HorizontalWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_set_horizontalOverflow_Public_set_Void_HorizontalWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0000BDFC File Offset: 0x00009FFC
		// (set) Token: 0x0600012C RID: 300 RVA: 0x0000BE38 File Offset: 0x0000A038
		public unsafe VerticalWrapMode verticalOverflow
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_verticalOverflow_Public_get_VerticalWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 170594, RefRangeEnd = 170603, XrefRangeStart = 170594, XrefRangeEnd = 170603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_set_verticalOverflow_Public_set_Void_VerticalWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000BE78 File Offset: 0x0000A078
		// (set) Token: 0x0600012E RID: 302 RVA: 0x0000BEB4 File Offset: 0x0000A0B4
		public unsafe float lineSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 604707, RefRangeEnd = 604708, XrefRangeStart = 604707, XrefRangeEnd = 604708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_set_lineSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000BEF4 File Offset: 0x0000A0F4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000BF28 File Offset: 0x0000A128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083489, XrefRangeEnd = 1083491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000BF5C File Offset: 0x0000A15C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FontData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002604 File Offset: 0x00000804
		public FontData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000BF98 File Offset: 0x0000A198
		// (set) Token: 0x06000134 RID: 308 RVA: 0x0000260D File Offset: 0x0000080D
		public unsafe Font m_Font
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_Font);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_Font), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0000BFC8 File Offset: 0x0000A1C8
		// (set) Token: 0x06000136 RID: 310 RVA: 0x0000262C File Offset: 0x0000082C
		public unsafe int m_FontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_FontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_FontSize)) = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0000BFF0 File Offset: 0x0000A1F0
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00002647 File Offset: 0x00000847
		public unsafe FontStyle m_FontStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_FontStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_FontStyle)) = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0000C018 File Offset: 0x0000A218
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00002662 File Offset: 0x00000862
		public unsafe bool m_BestFit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_BestFit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_BestFit)) = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0000C040 File Offset: 0x0000A240
		// (set) Token: 0x0600013C RID: 316 RVA: 0x0000267D File Offset: 0x0000087D
		public unsafe int m_MinSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_MinSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_MinSize)) = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0000C068 File Offset: 0x0000A268
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00002698 File Offset: 0x00000898
		public unsafe int m_MaxSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_MaxSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_MaxSize)) = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000C090 File Offset: 0x0000A290
		// (set) Token: 0x06000140 RID: 320 RVA: 0x000026B3 File Offset: 0x000008B3
		public unsafe TextAnchor m_Alignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_Alignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_Alignment)) = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0000C0B8 File Offset: 0x0000A2B8
		// (set) Token: 0x06000142 RID: 322 RVA: 0x000026CE File Offset: 0x000008CE
		public unsafe bool m_AlignByGeometry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_AlignByGeometry);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_AlignByGeometry)) = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0000C0E0 File Offset: 0x0000A2E0
		// (set) Token: 0x06000144 RID: 324 RVA: 0x000026E9 File Offset: 0x000008E9
		public unsafe bool m_RichText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_RichText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_RichText)) = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0000C108 File Offset: 0x0000A308
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00002704 File Offset: 0x00000904
		public unsafe HorizontalWrapMode m_HorizontalOverflow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_HorizontalOverflow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_HorizontalOverflow)) = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0000C130 File Offset: 0x0000A330
		// (set) Token: 0x06000148 RID: 328 RVA: 0x0000271F File Offset: 0x0000091F
		public unsafe VerticalWrapMode m_VerticalOverflow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_VerticalOverflow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_VerticalOverflow)) = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000149 RID: 329 RVA: 0x0000C158 File Offset: 0x0000A358
		// (set) Token: 0x0600014A RID: 330 RVA: 0x0000273A File Offset: 0x0000093A
		public unsafe float m_LineSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_LineSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontData.NativeFieldInfoPtr_m_LineSpacing)) = value;
			}
		}

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeFieldInfoPtr_m_Font;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_m_FontSize;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_m_FontStyle;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_m_BestFit;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr_m_MinSize;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxSize;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeFieldInfoPtr_m_Alignment;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeFieldInfoPtr_m_AlignByGeometry;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeFieldInfoPtr_m_RichText;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalOverflow;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalOverflow;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeFieldInfoPtr_m_LineSpacing;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultFontData_Public_Static_get_FontData_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_get_font_Public_get_Font_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_set_font_Public_set_Void_Font_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_set_fontSize_Public_set_Void_Int32_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyle_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_set_fontStyle_Public_set_Void_FontStyle_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_get_bestFit_Public_get_Boolean_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_set_bestFit_Public_set_Void_Boolean_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_get_minSize_Public_get_Int32_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_set_minSize_Public_set_Void_Int32_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_get_maxSize_Public_get_Int32_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_set_maxSize_Public_set_Void_Int32_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_get_alignment_Public_get_TextAnchor_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAnchor_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_get_alignByGeometry_Public_get_Boolean_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_set_alignByGeometry_Public_set_Void_Boolean_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_get_richText_Public_get_Boolean_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_set_richText_Public_set_Void_Boolean_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalOverflow_Public_get_HorizontalWrapMode_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalOverflow_Public_set_Void_HorizontalWrapMode_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalOverflow_Public_get_VerticalWrapMode_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalOverflow_Public_set_Void_VerticalWrapMode_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_set_lineSpacing_Public_set_Void_Single_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

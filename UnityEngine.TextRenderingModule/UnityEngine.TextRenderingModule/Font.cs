using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	public sealed class Font : Object
	{
		// Token: 0x06000095 RID: 149 RVA: 0x000047D8 File Offset: 0x000029D8
		// Note: this type is marked as 'beforefieldinit'.
		static Font()
		{
			Il2CppClassPointerStore<Font>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextRenderingModule.dll", "UnityEngine", "Font");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Font>.NativeClassPtr);
			Font.NativeFieldInfoPtr_textureRebuilt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Font>.NativeClassPtr, "textureRebuilt");
			Font.NativeFieldInfoPtr_m_FontTextureRebuildCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Font>.NativeClassPtr, "m_FontTextureRebuildCallback");
			Font.NativeMethodInfoPtr_add_textureRebuilt_Public_Static_add_Void_Action_1_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663332);
			Font.NativeMethodInfoPtr_remove_textureRebuilt_Public_Static_rem_Void_Action_1_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663333);
			Font.NativeMethodInfoPtr_add_m_FontTextureRebuildCallback_Private_add_Void_FontTextureRebuildCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663334);
			Font.NativeMethodInfoPtr_remove_m_FontTextureRebuildCallback_Private_rem_Void_FontTextureRebuildCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663335);
			Font.NativeMethodInfoPtr_get_material_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663336);
			Font.NativeMethodInfoPtr_set_material_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663337);
			Font.NativeMethodInfoPtr_get_fontNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663338);
			Font.NativeMethodInfoPtr_set_fontNames_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663339);
			Font.NativeMethodInfoPtr_get_dynamic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663340);
			Font.NativeMethodInfoPtr_get_ascent_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663341);
			Font.NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663342);
			Font.NativeMethodInfoPtr_get_characterInfo_Public_get_Il2CppStructArray_1_CharacterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663343);
			Font.NativeMethodInfoPtr_set_characterInfo_Public_set_Void_Il2CppStructArray_1_CharacterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663344);
			Font.NativeMethodInfoPtr_get_lineHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663345);
			Font.NativeMethodInfoPtr_get_textureRebuildCallback_Public_get_FontTextureRebuildCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663346);
			Font.NativeMethodInfoPtr_set_textureRebuildCallback_Public_set_Void_FontTextureRebuildCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663347);
			Font.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663348);
			Font.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663349);
			Font.NativeMethodInfoPtr__ctor_Private_Void_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663350);
			Font.NativeMethodInfoPtr_CreateDynamicFontFromOSFont_Public_Static_Font_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663351);
			Font.NativeMethodInfoPtr_CreateDynamicFontFromOSFont_Public_Static_Font_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663352);
			Font.NativeMethodInfoPtr_InvokeTextureRebuilt_Internal_Internal_Static_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663353);
			Font.NativeMethodInfoPtr_GetMaxVertsForString_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663354);
			Font.NativeMethodInfoPtr_GetDefault_Internal_Static_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663355);
			Font.NativeMethodInfoPtr_HasCharacter_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663356);
			Font.NativeMethodInfoPtr_HasCharacter_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663357);
			Font.NativeMethodInfoPtr_GetOSInstalledFontNames_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663358);
			Font.NativeMethodInfoPtr_GetPathsToOSFonts_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663359);
			Font.NativeMethodInfoPtr_Internal_CreateFont_Private_Static_Void_Font_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663360);
			Font.NativeMethodInfoPtr_Internal_CreateFontFromPath_Private_Static_Void_Font_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663361);
			Font.NativeMethodInfoPtr_Internal_CreateDynamicFont_Private_Static_Void_Font_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663362);
			Font.NativeMethodInfoPtr_GetCharacterInfo_Public_Boolean_Char_byref_CharacterInfo_Int32_FontStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663363);
			Font.NativeMethodInfoPtr_GetCharacterInfo_Public_Boolean_Char_byref_CharacterInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663364);
			Font.NativeMethodInfoPtr_GetCharacterInfo_Public_Boolean_Char_byref_CharacterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663365);
			Font.NativeMethodInfoPtr_RequestCharactersInTexture_Public_Void_String_Int32_FontStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663366);
			Font.NativeMethodInfoPtr_RequestCharactersInTexture_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663367);
			Font.NativeMethodInfoPtr_RequestCharactersInTexture_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663368);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00004B14 File Offset: 0x00002D14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1262207, RefRangeEnd = 1262208, XrefRangeStart = 1262198, XrefRangeEnd = 1262207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_textureRebuilt(Action<Font> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_add_textureRebuilt_Public_Static_add_Void_Action_1_Font_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00004B4C File Offset: 0x00002D4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1262217, RefRangeEnd = 1262218, XrefRangeStart = 1262208, XrefRangeEnd = 1262217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_textureRebuilt(Action<Font> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_remove_textureRebuilt_Public_Static_rem_Void_Action_1_Font_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00004B84 File Offset: 0x00002D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262218, XrefRangeEnd = 1262222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_m_FontTextureRebuildCallback(Font.FontTextureRebuildCallback value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_add_m_FontTextureRebuildCallback_Private_add_Void_FontTextureRebuildCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00004BC8 File Offset: 0x00002DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262222, XrefRangeEnd = 1262226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_m_FontTextureRebuildCallback(Font.FontTextureRebuildCallback value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_remove_m_FontTextureRebuildCallback_Private_rem_Void_FontTextureRebuildCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00004C0C File Offset: 0x00002E0C
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00004C4C File Offset: 0x00002E4C
		public unsafe Material material
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1262228, RefRangeEnd = 1262231, XrefRangeStart = 1262226, XrefRangeEnd = 1262228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_get_material_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262231, XrefRangeEnd = 1262233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_set_material_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00004C90 File Offset: 0x00002E90
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00004CD0 File Offset: 0x00002ED0
		public unsafe Il2CppStringArray fontNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262233, XrefRangeEnd = 1262235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_get_fontNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262235, XrefRangeEnd = 1262237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_set_fontNames_Public_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00004D14 File Offset: 0x00002F14
		public unsafe bool dynamic
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1262239, RefRangeEnd = 1262241, XrefRangeStart = 1262237, XrefRangeEnd = 1262239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_get_dynamic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00004D50 File Offset: 0x00002F50
		public unsafe int ascent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262241, XrefRangeEnd = 1262243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_get_ascent_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00004D8C File Offset: 0x00002F8C
		public unsafe int fontSize
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1262245, RefRangeEnd = 1262247, XrefRangeStart = 1262243, XrefRangeEnd = 1262245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00004DC8 File Offset: 0x00002FC8
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00004E08 File Offset: 0x00003008
		public unsafe Il2CppStructArray<CharacterInfo> characterInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262247, XrefRangeEnd = 1262249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_get_characterInfo_Public_get_Il2CppStructArray_1_CharacterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<CharacterInfo>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262249, XrefRangeEnd = 1262251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_set_characterInfo_Public_set_Void_Il2CppStructArray_1_CharacterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00004E4C File Offset: 0x0000304C
		public unsafe int lineHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262251, XrefRangeEnd = 1262253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_get_lineHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00004E88 File Offset: 0x00003088
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00004EC8 File Offset: 0x000030C8
		public unsafe Font.FontTextureRebuildCallback textureRebuildCallback
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 318167, RefRangeEnd = 318212, XrefRangeStart = 318167, XrefRangeEnd = 318212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_get_textureRebuildCallback_Public_get_FontTextureRebuildCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Font.FontTextureRebuildCallback>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_set_textureRebuildCallback_Public_set_Void_FontTextureRebuildCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00004F0C File Offset: 0x0000310C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262253, XrefRangeEnd = 1262259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Font()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Font>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00004F48 File Offset: 0x00003148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262259, XrefRangeEnd = 1262272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Font(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Font>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00004F94 File Offset: 0x00003194
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1262278, RefRangeEnd = 1262280, XrefRangeStart = 1262272, XrefRangeEnd = 1262278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Font(Il2CppStringArray names, int size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Font>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(names);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr__ctor_Private_Void_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004FF0 File Offset: 0x000031F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262280, XrefRangeEnd = 1262288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Font CreateDynamicFontFromOSFont(string fontname, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fontname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_CreateDynamicFontFromOSFont_Public_Static_Font_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Font>(intPtr3) : null;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00005044 File Offset: 0x00003244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262288, XrefRangeEnd = 1262292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Font CreateDynamicFontFromOSFont(Il2CppStringArray fontnames, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontnames);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_CreateDynamicFontFromOSFont_Public_Static_Font_Il2CppStringArray_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Font>(intPtr3) : null;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00005098 File Offset: 0x00003298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262292, XrefRangeEnd = 1262294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeTextureRebuilt_Internal(Font font)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_InvokeTextureRebuilt_Internal_Internal_Static_Void_Font_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000050D0 File Offset: 0x000032D0
		[CallerCount(0)]
		public unsafe static int GetMaxVertsForString(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_GetMaxVertsForString_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00005114 File Offset: 0x00003314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262294, XrefRangeEnd = 1262296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Font GetDefault()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_GetDefault_Internal_Static_Font_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Font>(intPtr3) : null;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00005148 File Offset: 0x00003348
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1262298, RefRangeEnd = 1262299, XrefRangeStart = 1262296, XrefRangeEnd = 1262298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCharacter(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_HasCharacter_Public_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00005194 File Offset: 0x00003394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262299, XrefRangeEnd = 1262301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCharacter(int c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_HasCharacter_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000051E0 File Offset: 0x000033E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262301, XrefRangeEnd = 1262303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetOSInstalledFontNames()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_GetOSInstalledFontNames_Public_Static_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00005214 File Offset: 0x00003414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262303, XrefRangeEnd = 1262305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetPathsToOSFonts()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_GetPathsToOSFonts_Public_Static_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00005248 File Offset: 0x00003448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262305, XrefRangeEnd = 1262307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CreateFont(Font self, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_Internal_CreateFont_Private_Static_Void_Font_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00005290 File Offset: 0x00003490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262307, XrefRangeEnd = 1262309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CreateFontFromPath(Font self, string fontPath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fontPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_Internal_CreateFontFromPath_Private_Static_Void_Font_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000052D8 File Offset: 0x000034D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262309, XrefRangeEnd = 1262311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CreateDynamicFont(Font self, Il2CppStringArray _names, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_names);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_Internal_CreateDynamicFont_Private_Static_Void_Font_Il2CppStringArray_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00005330 File Offset: 0x00003530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262311, XrefRangeEnd = 1262313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetCharacterInfo(char ch, out CharacterInfo info, int size, FontStyle style)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &info;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_GetCharacterInfo_Public_Boolean_Char_byref_CharacterInfo_Int32_FontStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000053A4 File Offset: 0x000035A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262313, XrefRangeEnd = 1262315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetCharacterInfo(char ch, out CharacterInfo info, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &info;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_GetCharacterInfo_Public_Boolean_Char_byref_CharacterInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000540C File Offset: 0x0000360C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262315, XrefRangeEnd = 1262317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetCharacterInfo(char ch, out CharacterInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_GetCharacterInfo_Public_Boolean_Char_byref_CharacterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00005464 File Offset: 0x00003664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262317, XrefRangeEnd = 1262319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestCharactersInTexture(string characters, int size, FontStyle style)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(characters);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_RequestCharactersInTexture_Public_Void_String_Int32_FontStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000054C4 File Offset: 0x000036C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262319, XrefRangeEnd = 1262321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestCharactersInTexture(string characters, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(characters);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_RequestCharactersInTexture_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00005514 File Offset: 0x00003714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262321, XrefRangeEnd = 1262323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestCharactersInTexture(string characters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(characters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_RequestCharactersInTexture_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000024FC File Offset: 0x000006FC
		public Font(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00005558 File Offset: 0x00003758
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00002505 File Offset: 0x00000705
		public unsafe static Action<Font> textureRebuilt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Font.NativeFieldInfoPtr_textureRebuilt, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Font>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Font.NativeFieldInfoPtr_textureRebuilt, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00005580 File Offset: 0x00003780
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00002517 File Offset: 0x00000717
		public unsafe Font.FontTextureRebuildCallback m_FontTextureRebuildCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Font.NativeFieldInfoPtr_m_FontTextureRebuildCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font.FontTextureRebuildCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Font.NativeFieldInfoPtr_m_FontTextureRebuildCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr_textureRebuilt;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeFieldInfoPtr_m_FontTextureRebuildCallback;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_add_textureRebuilt_Public_Static_add_Void_Action_1_Font_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_remove_textureRebuilt_Public_Static_rem_Void_Action_1_Font_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_add_m_FontTextureRebuildCallback_Private_add_Void_FontTextureRebuildCallback_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_remove_m_FontTextureRebuildCallback_Private_rem_Void_FontTextureRebuildCallback_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_get_material_Public_get_Material_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_set_material_Public_set_Void_Material_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_get_fontNames_Public_get_Il2CppStringArray_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_set_fontNames_Public_set_Void_Il2CppStringArray_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_get_dynamic_Public_get_Boolean_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_get_ascent_Public_get_Int32_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_get_characterInfo_Public_get_Il2CppStructArray_1_CharacterInfo_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_set_characterInfo_Public_set_Void_Il2CppStructArray_1_CharacterInfo_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_get_lineHeight_Public_get_Int32_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_get_textureRebuildCallback_Public_get_FontTextureRebuildCallback_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_set_textureRebuildCallback_Public_set_Void_FontTextureRebuildCallback_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Il2CppStringArray_Int32_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_CreateDynamicFontFromOSFont_Public_Static_Font_String_Int32_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_CreateDynamicFontFromOSFont_Public_Static_Font_Il2CppStringArray_Int32_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_InvokeTextureRebuilt_Internal_Internal_Static_Void_Font_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxVertsForString_Public_Static_Int32_String_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_GetDefault_Internal_Static_Font_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_HasCharacter_Public_Boolean_Char_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_HasCharacter_Private_Boolean_Int32_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_GetOSInstalledFontNames_Public_Static_Il2CppStringArray_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_GetPathsToOSFonts_Public_Static_Il2CppStringArray_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreateFont_Private_Static_Void_Font_String_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreateFontFromPath_Private_Static_Void_Font_String_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreateDynamicFont_Private_Static_Void_Font_Il2CppStringArray_Int32_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterInfo_Public_Boolean_Char_byref_CharacterInfo_Int32_FontStyle_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterInfo_Public_Boolean_Char_byref_CharacterInfo_Int32_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterInfo_Public_Boolean_Char_byref_CharacterInfo_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_RequestCharactersInTexture_Public_Void_String_Int32_FontStyle_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_RequestCharactersInTexture_Public_Void_String_Int32_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_RequestCharactersInTexture_Public_Void_String_0;

		// Token: 0x02000016 RID: 22
		public sealed class FontTextureRebuildCallback : MulticastDelegate
		{
			// Token: 0x060000FE RID: 254 RVA: 0x0000275C File Offset: 0x0000095C
			// Note: this type is marked as 'beforefieldinit'.
			static FontTextureRebuildCallback()
			{
				Il2CppClassPointerStore<Font.FontTextureRebuildCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Font>.NativeClassPtr, "FontTextureRebuildCallback");
				Font.FontTextureRebuildCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font.FontTextureRebuildCallback>.NativeClassPtr, 100663369);
				Font.FontTextureRebuildCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font.FontTextureRebuildCallback>.NativeClassPtr, 100663370);
			}

			// Token: 0x060000FF RID: 255 RVA: 0x00005904 File Offset: 0x00003B04
			[CallerCount(288)]
			[CachedScanResults(RefRangeStart = 320972, RefRangeEnd = 321260, XrefRangeStart = 320972, XrefRangeEnd = 321260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FontTextureRebuildCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Font.FontTextureRebuildCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.FontTextureRebuildCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000100 RID: 256 RVA: 0x00005960 File Offset: 0x00003B60
			[CallerCount(0)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.FontTextureRebuildCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000101 RID: 257 RVA: 0x0000279A File Offset: 0x0000099A
			public FontTextureRebuildCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000102 RID: 258 RVA: 0x000027A3 File Offset: 0x000009A3
			public static implicit operator Font.FontTextureRebuildCallback(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<Font.FontTextureRebuildCallback>(A_0);
			}

			// Token: 0x06000103 RID: 259 RVA: 0x000027AB File Offset: 0x000009AB
			public static Font.FontTextureRebuildCallback operator +(Font.FontTextureRebuildCallback A_0, Font.FontTextureRebuildCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Font.FontTextureRebuildCallback>();
			}

			// Token: 0x06000104 RID: 260 RVA: 0x000027B9 File Offset: 0x000009B9
			public static Font.FontTextureRebuildCallback operator -(Font.FontTextureRebuildCallback A_0, Font.FontTextureRebuildCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Font.FontTextureRebuildCallback>();
				}
				return delegate2;
			}

			// Token: 0x040000CF RID: 207
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040000D0 RID: 208
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
		}
	}
}

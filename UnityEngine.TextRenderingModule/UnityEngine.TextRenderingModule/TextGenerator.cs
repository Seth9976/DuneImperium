using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	public sealed class TextGenerator : Object
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00002D88 File Offset: 0x00000F88
		// Note: this type is marked as 'beforefieldinit'.
		static TextGenerator()
		{
			Il2CppClassPointerStore<TextGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextRenderingModule.dll", "UnityEngine", "TextGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr);
			TextGenerator.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_Ptr");
			TextGenerator.NativeFieldInfoPtr_m_LastString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LastString");
			TextGenerator.NativeFieldInfoPtr_m_LastSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LastSettings");
			TextGenerator.NativeFieldInfoPtr_m_HasGenerated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_HasGenerated");
			TextGenerator.NativeFieldInfoPtr_m_LastValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LastValid");
			TextGenerator.NativeFieldInfoPtr_m_Verts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_Verts");
			TextGenerator.NativeFieldInfoPtr_m_Characters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_Characters");
			TextGenerator.NativeFieldInfoPtr_m_Lines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_Lines");
			TextGenerator.NativeFieldInfoPtr_m_CachedVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_CachedVerts");
			TextGenerator.NativeFieldInfoPtr_m_CachedCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_CachedCharacters");
			TextGenerator.NativeFieldInfoPtr_m_CachedLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_CachedLines");
			TextGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663300);
			TextGenerator.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663301);
			TextGenerator.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663302);
			TextGenerator.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663303);
			TextGenerator.NativeMethodInfoPtr_get_characterCountVisible_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663304);
			TextGenerator.NativeMethodInfoPtr_ValidatedSettings_Private_TextGenerationSettings_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663305);
			TextGenerator.NativeMethodInfoPtr_Invalidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663306);
			TextGenerator.NativeMethodInfoPtr_GetCharacters_Public_Void_List_1_UICharInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663307);
			TextGenerator.NativeMethodInfoPtr_GetLines_Public_Void_List_1_UILineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663308);
			TextGenerator.NativeMethodInfoPtr_GetVertices_Public_Void_List_1_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663309);
			TextGenerator.NativeMethodInfoPtr_GetPreferredWidth_Public_Single_String_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663310);
			TextGenerator.NativeMethodInfoPtr_GetPreferredHeight_Public_Single_String_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663311);
			TextGenerator.NativeMethodInfoPtr_PopulateWithErrors_Public_Boolean_String_TextGenerationSettings_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663312);
			TextGenerator.NativeMethodInfoPtr_Populate_Public_Boolean_String_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663313);
			TextGenerator.NativeMethodInfoPtr_PopulateWithError_Private_TextGenerationError_String_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663314);
			TextGenerator.NativeMethodInfoPtr_PopulateAlways_Private_TextGenerationError_String_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663315);
			TextGenerator.NativeMethodInfoPtr_get_verts_Public_get_IList_1_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663316);
			TextGenerator.NativeMethodInfoPtr_get_characters_Public_get_IList_1_UICharInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663317);
			TextGenerator.NativeMethodInfoPtr_get_lines_Public_get_IList_1_UILineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663318);
			TextGenerator.NativeMethodInfoPtr_get_rectExtents_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663319);
			TextGenerator.NativeMethodInfoPtr_get_characterCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663320);
			TextGenerator.NativeMethodInfoPtr_get_lineCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663321);
			TextGenerator.NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663322);
			TextGenerator.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663323);
			TextGenerator.NativeMethodInfoPtr_Populate_Internal_Internal_Boolean_String_Font_Color_Int32_Single_Single_FontStyle_Boolean_Boolean_Int32_Int32_Int32_Int32_Boolean_TextAnchor_Single_Single_Single_Single_Boolean_Boolean_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663324);
			TextGenerator.NativeMethodInfoPtr_Populate_Internal_Internal_Boolean_String_Font_Color_Int32_Single_Single_FontStyle_Boolean_Boolean_Int32_Int32_VerticalWrapMode_HorizontalWrapMode_Boolean_TextAnchor_Vector2_Vector2_Boolean_Boolean_byref_TextGenerationError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663325);
			TextGenerator.NativeMethodInfoPtr_GetVerticesInternal_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663326);
			TextGenerator.NativeMethodInfoPtr_GetCharactersInternal_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663327);
			TextGenerator.NativeMethodInfoPtr_GetLinesInternal_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663328);
			TextGenerator.NativeMethodInfoPtr_get_rectExtents_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663329);
			TextGenerator.NativeMethodInfoPtr_Populate_Internal_Injected_Private_Boolean_String_Font_byref_Color_Int32_Single_Single_FontStyle_Boolean_Boolean_Int32_Int32_Int32_Int32_Boolean_TextAnchor_Single_Single_Single_Single_Boolean_Boolean_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663330);
			TextGenerator.get_vertexCountDelegateField = IL2CPP.ResolveICall<TextGenerator.get_vertexCountDelegate>("UnityEngine.TextGenerator::get_vertexCount");
			TextGenerator.get_fontSizeUsedForBestFitDelegateField = IL2CPP.ResolveICall<TextGenerator.get_fontSizeUsedForBestFitDelegate>("UnityEngine.TextGenerator::get_fontSizeUsedForBestFit");
			TextGenerator.GetVerticesArrayDelegateField = IL2CPP.ResolveICall<TextGenerator.GetVerticesArrayDelegate>("UnityEngine.TextGenerator::GetVerticesArray");
			TextGenerator.GetCharactersArrayDelegateField = IL2CPP.ResolveICall<TextGenerator.GetCharactersArrayDelegate>("UnityEngine.TextGenerator::GetCharactersArray");
			TextGenerator.GetLinesArrayDelegateField = IL2CPP.ResolveICall<TextGenerator.GetLinesArrayDelegate>("UnityEngine.TextGenerator::GetLinesArray");
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000314C File Offset: 0x0000134C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1261978, RefRangeEnd = 1261981, XrefRangeStart = 1261954, XrefRangeEnd = 1261978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextGenerator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003188 File Offset: 0x00001388
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1262005, RefRangeEnd = 1262006, XrefRangeStart = 1261981, XrefRangeEnd = 1262005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextGenerator(int initialCapacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialCapacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000031D0 File Offset: 0x000013D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262006, XrefRangeEnd = 1262014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003204 File Offset: 0x00001404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262014, XrefRangeEnd = 1262017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00003238 File Offset: 0x00001438
		public unsafe int characterCountVisible
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1262019, RefRangeEnd = 1262026, XrefRangeStart = 1262017, XrefRangeEnd = 1262019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_get_characterCountVisible_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003274 File Offset: 0x00001474
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1262060, RefRangeEnd = 1262062, XrefRangeStart = 1262026, XrefRangeEnd = 1262060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextGenerationSettings ValidatedSettings(TextGenerationSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(settings));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_ValidatedSettings_Private_TextGenerationSettings_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TextGenerationSettings(intPtr);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000032C4 File Offset: 0x000014C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1262062, RefRangeEnd = 1262064, XrefRangeStart = 1262062, XrefRangeEnd = 1262062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invalidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_Invalidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000032F8 File Offset: 0x000014F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262064, XrefRangeEnd = 1262066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetCharacters(List<UICharInfo> characters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(characters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_GetCharacters_Public_Void_List_1_UICharInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000333C File Offset: 0x0000153C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262066, XrefRangeEnd = 1262068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetLines(List<UILineInfo> lines)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lines);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_GetLines_Public_Void_List_1_UILineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003380 File Offset: 0x00001580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262068, XrefRangeEnd = 1262070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetVertices(List<UIVertex> vertices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_GetVertices_Public_Void_List_1_UIVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000033C4 File Offset: 0x000015C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1262073, RefRangeEnd = 1262075, XrefRangeStart = 1262070, XrefRangeEnd = 1262073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPreferredWidth(string str, TextGenerationSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(settings));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_GetPreferredWidth_Public_Single_String_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003428 File Offset: 0x00001628
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1262078, RefRangeEnd = 1262080, XrefRangeStart = 1262075, XrefRangeEnd = 1262078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPreferredHeight(string str, TextGenerationSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(settings));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_GetPreferredHeight_Public_Single_String_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000348C File Offset: 0x0000168C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1262102, RefRangeEnd = 1262104, XrefRangeStart = 1262080, XrefRangeEnd = 1262102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(settings));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_PopulateWithErrors_Public_Boolean_String_TextGenerationSettings_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003504 File Offset: 0x00001704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262104, XrefRangeEnd = 1262105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Populate(string str, TextGenerationSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(settings));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_Populate_Public_Boolean_String_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003568 File Offset: 0x00001768
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1262118, RefRangeEnd = 1262122, XrefRangeStart = 1262105, XrefRangeEnd = 1262118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextGenerationError PopulateWithError(string str, TextGenerationSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(settings));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_PopulateWithError_Private_TextGenerationError_String_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000035CC File Offset: 0x000017CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262122, XrefRangeEnd = 1262132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextGenerationError PopulateAlways(string str, TextGenerationSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(settings));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_PopulateAlways_Private_TextGenerationError_String_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00003630 File Offset: 0x00001830
		public unsafe IList<UIVertex> verts
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1262134, RefRangeEnd = 1262135, XrefRangeStart = 1262132, XrefRangeEnd = 1262134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_get_verts_Public_get_IList_1_UIVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<UIVertex>>(intPtr3) : null;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00003670 File Offset: 0x00001870
		public unsafe IList<UICharInfo> characters
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1262137, RefRangeEnd = 1262148, XrefRangeStart = 1262135, XrefRangeEnd = 1262137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_get_characters_Public_get_IList_1_UICharInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<UICharInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000036B0 File Offset: 0x000018B0
		public unsafe IList<UILineInfo> lines
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 1262150, RefRangeEnd = 1262166, XrefRangeStart = 1262148, XrefRangeEnd = 1262150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_get_lines_Public_get_IList_1_UILineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<UILineInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000036F0 File Offset: 0x000018F0
		public unsafe Rect rectExtents
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1262168, RefRangeEnd = 1262169, XrefRangeStart = 1262166, XrefRangeEnd = 1262168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_get_rectExtents_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0000372C File Offset: 0x0000192C
		public unsafe int characterCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1262171, RefRangeEnd = 1262172, XrefRangeStart = 1262169, XrefRangeEnd = 1262171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_get_characterCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00003768 File Offset: 0x00001968
		public unsafe int lineCount
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1262174, RefRangeEnd = 1262181, XrefRangeStart = 1262172, XrefRangeEnd = 1262174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_get_lineCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000037A4 File Offset: 0x000019A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262181, XrefRangeEnd = 1262183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Internal_Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000037D4 File Offset: 0x000019D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262183, XrefRangeEnd = 1262185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Destroy(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003808 File Offset: 0x00001A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262185, XrefRangeEnd = 1262187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)22) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(font);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fontSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleFactor;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineSpacing;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref richText;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resizeTextForBestFit;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resizeTextMinSize;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resizeTextMaxSize;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref verticalOverFlow;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref horizontalOverflow;
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateBounds;
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchor;
			ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extentsX;
			ptr[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extentsY;
			ptr[checked(unchecked((UIntPtr)17) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivotX;
			ptr[checked(unchecked((UIntPtr)18) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivotY;
			ptr[checked(unchecked((UIntPtr)19) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref generateOutOfBounds;
			ptr[checked(unchecked((UIntPtr)20) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignByGeometry;
			ptr[checked(unchecked((UIntPtr)21) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_Populate_Internal_Internal_Boolean_String_Font_Color_Int32_Single_Single_FontStyle_Boolean_Boolean_Int32_Int32_Int32_Int32_Boolean_TextAnchor_Single_Single_Single_Single_Boolean_Boolean_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003990 File Offset: 0x00001B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262187, XrefRangeEnd = 1262194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)20) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(font);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fontSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleFactor;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineSpacing;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref richText;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resizeTextForBestFit;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resizeTextMinSize;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resizeTextMaxSize;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref verticalOverFlow;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref horizontalOverflow;
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateBounds;
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchor;
			ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extents;
			ptr[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)17) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref generateOutOfBounds;
			ptr[checked(unchecked((UIntPtr)18) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignByGeometry;
			ptr[checked(unchecked((UIntPtr)19) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_Populate_Internal_Internal_Boolean_String_Font_Color_Int32_Single_Single_FontStyle_Boolean_Boolean_Int32_Int32_VerticalWrapMode_HorizontalWrapMode_Boolean_TextAnchor_Vector2_Vector2_Boolean_Boolean_byref_TextGenerationError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003AF8 File Offset: 0x00001CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetVerticesInternal(Object vertices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_GetVerticesInternal_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003B3C File Offset: 0x00001D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetCharactersInternal(Object characters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(characters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_GetCharactersInternal_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003B80 File Offset: 0x00001D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetLinesInternal(Object lines)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lines);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_GetLinesInternal_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003BC4 File Offset: 0x00001DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262194, XrefRangeEnd = 1262196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_rectExtents_Injected(out Rect ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_get_rectExtents_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003C04 File Offset: 0x00001E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262196, XrefRangeEnd = 1262198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Populate_Internal_Injected(string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)22) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(font);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &color;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fontSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleFactor;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineSpacing;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref richText;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resizeTextForBestFit;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resizeTextMinSize;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resizeTextMaxSize;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref verticalOverFlow;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref horizontalOverflow;
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateBounds;
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchor;
			ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extentsX;
			ptr[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extentsY;
			ptr[checked(unchecked((UIntPtr)17) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivotX;
			ptr[checked(unchecked((UIntPtr)18) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivotY;
			ptr[checked(unchecked((UIntPtr)19) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref generateOutOfBounds;
			ptr[checked(unchecked((UIntPtr)20) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignByGeometry;
			ptr[checked(unchecked((UIntPtr)21) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_Populate_Internal_Injected_Private_Boolean_String_Font_byref_Color_Int32_Single_Single_FontStyle_Boolean_Boolean_Int32_Int32_Int32_Int32_Boolean_TextAnchor_Single_Single_Single_Single_Boolean_Boolean_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002255 File Offset: 0x00000455
		public TextGenerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00003D8C File Offset: 0x00001F8C
		// (set) Token: 0x0600004D RID: 77 RVA: 0x0000225E File Offset: 0x0000045E
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00003DB4 File Offset: 0x00001FB4
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00002279 File Offset: 0x00000479
		public unsafe string m_LastString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LastString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LastString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00003DDC File Offset: 0x00001FDC
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00002298 File Offset: 0x00000498
		public TextGenerationSettings m_LastSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LastSettings);
				return new TextGenerationSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LastSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00003E0C File Offset: 0x0000200C
		// (set) Token: 0x06000053 RID: 83 RVA: 0x000022C6 File Offset: 0x000004C6
		public unsafe bool m_HasGenerated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_HasGenerated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_HasGenerated)) = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00003E34 File Offset: 0x00002034
		// (set) Token: 0x06000055 RID: 85 RVA: 0x000022E1 File Offset: 0x000004E1
		public unsafe TextGenerationError m_LastValid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LastValid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LastValid)) = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00003E5C File Offset: 0x0000205C
		// (set) Token: 0x06000057 RID: 87 RVA: 0x000022FC File Offset: 0x000004FC
		public unsafe List<UIVertex> m_Verts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_Verts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIVertex>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_Verts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00003E8C File Offset: 0x0000208C
		// (set) Token: 0x06000059 RID: 89 RVA: 0x0000231B File Offset: 0x0000051B
		public unsafe List<UICharInfo> m_Characters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_Characters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UICharInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_Characters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00003EBC File Offset: 0x000020BC
		// (set) Token: 0x0600005B RID: 91 RVA: 0x0000233A File Offset: 0x0000053A
		public unsafe List<UILineInfo> m_Lines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_Lines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UILineInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_Lines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00003EEC File Offset: 0x000020EC
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00002359 File Offset: 0x00000559
		public unsafe bool m_CachedVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_CachedVerts);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_CachedVerts)) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00003F14 File Offset: 0x00002114
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00002374 File Offset: 0x00000574
		public unsafe bool m_CachedCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_CachedCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_CachedCharacters)) = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00003F3C File Offset: 0x0000213C
		// (set) Token: 0x06000061 RID: 97 RVA: 0x0000238F File Offset: 0x0000058F
		public unsafe bool m_CachedLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_CachedLines);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_CachedLines)) = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000023AA File Offset: 0x000005AA
		public int vertexCount
		{
			get
			{
				return TextGenerator.get_vertexCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000023BC File Offset: 0x000005BC
		public int fontSizeUsedForBestFit
		{
			get
			{
				return TextGenerator.get_fontSizeUsedForBestFitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003F64 File Offset: 0x00002164
		public Il2CppStructArray<UIVertex> GetVerticesArray()
		{
			IntPtr intPtr = TextGenerator.GetVerticesArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<UIVertex>>(intPtr2) : null;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00003F90 File Offset: 0x00002190
		public Il2CppStructArray<UICharInfo> GetCharactersArray()
		{
			IntPtr intPtr = TextGenerator.GetCharactersArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<UICharInfo>>(intPtr2) : null;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003FBC File Offset: 0x000021BC
		public Il2CppStructArray<UILineInfo> GetLinesArray()
		{
			IntPtr intPtr = TextGenerator.GetLinesArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<UILineInfo>>(intPtr2) : null;
		}

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_m_LastString;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_m_LastSettings;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_m_HasGenerated;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_m_LastValid;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_m_Verts;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_m_Characters;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr_m_Lines;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedVerts;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedCharacters;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedLines;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_get_characterCountVisible_Public_get_Int32_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_ValidatedSettings_Private_TextGenerationSettings_TextGenerationSettings_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_Invalidate_Public_Void_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacters_Public_Void_List_1_UICharInfo_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_GetLines_Public_Void_List_1_UILineInfo_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_GetVertices_Public_Void_List_1_UIVertex_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredWidth_Public_Single_String_TextGenerationSettings_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredHeight_Public_Single_String_TextGenerationSettings_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_PopulateWithErrors_Public_Boolean_String_TextGenerationSettings_GameObject_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_Populate_Public_Boolean_String_TextGenerationSettings_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_PopulateWithError_Private_TextGenerationError_String_TextGenerationSettings_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_PopulateAlways_Private_TextGenerationError_String_TextGenerationSettings_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_get_verts_Public_get_IList_1_UIVertex_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_get_characters_Public_get_IList_1_UICharInfo_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_get_lines_Public_get_IList_1_UILineInfo_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_get_rectExtents_Public_get_Rect_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_get_characterCount_Public_get_Int32_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_get_lineCount_Public_get_Int32_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_Populate_Internal_Internal_Boolean_String_Font_Color_Int32_Single_Single_FontStyle_Boolean_Boolean_Int32_Int32_Int32_Int32_Boolean_TextAnchor_Single_Single_Single_Single_Boolean_Boolean_byref_UInt32_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_Populate_Internal_Internal_Boolean_String_Font_Color_Int32_Single_Single_FontStyle_Boolean_Boolean_Int32_Int32_VerticalWrapMode_HorizontalWrapMode_Boolean_TextAnchor_Vector2_Vector2_Boolean_Boolean_byref_TextGenerationError_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_GetVerticesInternal_Private_Void_Object_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_GetCharactersInternal_Private_Void_Object_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_GetLinesInternal_Private_Void_Object_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_get_rectExtents_Injected_Private_Void_byref_Rect_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_Populate_Internal_Injected_Private_Boolean_String_Font_byref_Color_Int32_Single_Single_FontStyle_Boolean_Boolean_Int32_Int32_Int32_Int32_Boolean_TextAnchor_Single_Single_Single_Single_Boolean_Boolean_byref_UInt32_0;

		// Token: 0x0400004A RID: 74
		private static readonly TextGenerator.get_vertexCountDelegate get_vertexCountDelegateField;

		// Token: 0x0400004B RID: 75
		private static readonly TextGenerator.get_fontSizeUsedForBestFitDelegate get_fontSizeUsedForBestFitDelegateField;

		// Token: 0x0400004C RID: 76
		private static readonly TextGenerator.GetVerticesArrayDelegate GetVerticesArrayDelegateField;

		// Token: 0x0400004D RID: 77
		private static readonly TextGenerator.GetCharactersArrayDelegate GetCharactersArrayDelegateField;

		// Token: 0x0400004E RID: 78
		private static readonly TextGenerator.GetLinesArrayDelegate GetLinesArrayDelegateField;

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x060000F5 RID: 245
		private delegate int get_vertexCountDelegate(IntPtr @this);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x060000F7 RID: 247
		private delegate int get_fontSizeUsedForBestFitDelegate(IntPtr @this);

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x060000F9 RID: 249
		private delegate IntPtr GetVerticesArrayDelegate(IntPtr @this);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x060000FB RID: 251
		private delegate IntPtr GetCharactersArrayDelegate(IntPtr @this);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x060000FD RID: 253
		private delegate IntPtr GetLinesArrayDelegate(IntPtr @this);
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200002D RID: 45
	public class TextHandle : Object
	{
		// Token: 0x06000531 RID: 1329 RVA: 0x0001661C File Offset: 0x0001481C
		// Note: this type is marked as 'beforefieldinit'.
		static TextHandle()
		{
			Il2CppClassPointerStore<TextHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextHandle>.NativeClassPtr);
			TextHandle.NativeFieldInfoPtr_m_PreferredSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, "m_PreferredSize");
			TextHandle.NativeFieldInfoPtr_m_TextInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, "m_TextInfo");
			TextHandle.NativeFieldInfoPtr_m_LayoutTextInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, "m_LayoutTextInfo");
			TextHandle.NativeFieldInfoPtr_m_PreviousGenerationSettingsHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, "m_PreviousGenerationSettingsHash");
			TextHandle.NativeFieldInfoPtr_textGenerationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, "textGenerationSettings");
			TextHandle.NativeFieldInfoPtr_s_LayoutSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, "s_LayoutSettings");
			TextHandle.NativeFieldInfoPtr_isDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, "isDirty");
			TextHandle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663647);
			TextHandle.NativeMethodInfoPtr_get_textInfo_Internal_get_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663648);
			TextHandle.NativeMethodInfoPtr_get_layoutTextInfo_Internal_Static_get_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663649);
			TextHandle.NativeMethodInfoPtr_IsDirty_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663650);
			TextHandle.NativeMethodInfoPtr_GetCursorPositionFromStringIndexUsingCharacterHeight_Public_Vector2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663651);
			TextHandle.NativeMethodInfoPtr_GetCursorPositionFromStringIndexUsingLineHeight_Public_Vector2_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663652);
			TextHandle.NativeMethodInfoPtr_GetCursorIndexFromPosition_Public_Int32_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663653);
			TextHandle.NativeMethodInfoPtr_LineDownCharacterPosition_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663654);
			TextHandle.NativeMethodInfoPtr_LineUpCharacterPosition_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663655);
			TextHandle.NativeMethodInfoPtr_FindNearestLine_Public_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663656);
			TextHandle.NativeMethodInfoPtr_FindNearestCharacterOnLine_Public_Int32_Vector2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663657);
			TextHandle.NativeMethodInfoPtr_FindIntersectingLink_Public_Int32_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663658);
			TextHandle.NativeMethodInfoPtr_PointIntersectRectangle_Private_Static_Boolean_Vector3_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663659);
			TextHandle.NativeMethodInfoPtr_DistanceToLine_Private_Static_Single_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663660);
			TextHandle.NativeMethodInfoPtr_GetLineNumber_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663661);
			TextHandle.NativeMethodInfoPtr_GetLineHeight_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663662);
			TextHandle.NativeMethodInfoPtr_GetLineHeightFromCharacterIndex_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663663);
			TextHandle.NativeMethodInfoPtr_GetCharacterHeightFromIndex_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663664);
			TextHandle.NativeMethodInfoPtr_IsElided_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663665);
			TextHandle.NativeMethodInfoPtr_Substring_Public_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663666);
			TextHandle.NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663667);
			TextHandle.NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663668);
			TextHandle.NativeMethodInfoPtr_ComputeTextWidth_Protected_Single_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663669);
			TextHandle.NativeMethodInfoPtr_ComputeTextHeight_Protected_Single_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663670);
			TextHandle.NativeMethodInfoPtr_UpdatePreferredValues_Protected_Void_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663671);
			TextHandle.NativeMethodInfoPtr_Update_Protected_TextInfo_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandle>.NativeClassPtr, 100663672);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x000168E0 File Offset: 0x00014AE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105089, RefRangeEnd = 1105090, XrefRangeStart = 1105083, XrefRangeEnd = 1105089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextHandle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextHandle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x0001691C File Offset: 0x00014B1C
		public unsafe TextInfo textInfo
		{
			[CallerCount(78)]
			[CachedScanResults(RefRangeStart = 1105095, RefRangeEnd = 1105173, XrefRangeStart = 1105090, XrefRangeEnd = 1105095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_get_textInfo_Internal_get_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x0001695C File Offset: 0x00014B5C
		public unsafe static TextInfo layoutTextInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1105173, XrefRangeEnd = 1105189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_get_layoutTextInfo_Internal_Static_get_TextInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00016990 File Offset: 0x00014B90
		[CallerCount(0)]
		public unsafe bool IsDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_IsDirty_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x000169CC File Offset: 0x00014BCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105202, RefRangeEnd = 1105203, XrefRangeStart = 1105189, XrefRangeEnd = 1105202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, bool inverseYAxis = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inverseYAxis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_GetCursorPositionFromStringIndexUsingCharacterHeight_Public_Vector2_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00016A24 File Offset: 0x00014C24
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1105217, RefRangeEnd = 1105224, XrefRangeStart = 1105203, XrefRangeEnd = 1105217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, bool useXAdvance = false, bool inverseYAxis = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useXAdvance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inverseYAxis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_GetCursorPositionFromStringIndexUsingLineHeight_Public_Vector2_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00016A8C File Offset: 0x00014C8C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1105241, RefRangeEnd = 1105245, XrefRangeStart = 1105224, XrefRangeEnd = 1105241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCursorIndexFromPosition(Vector2 position, bool inverseYAxis = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inverseYAxis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_GetCursorIndexFromPosition_Public_Int32_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00016AE4 File Offset: 0x00014CE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1105263, RefRangeEnd = 1105266, XrefRangeStart = 1105245, XrefRangeEnd = 1105263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LineDownCharacterPosition(int originalPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref originalPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_LineDownCharacterPosition_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00016B30 File Offset: 0x00014D30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1105286, RefRangeEnd = 1105289, XrefRangeStart = 1105266, XrefRangeEnd = 1105286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LineUpCharacterPosition(int originalPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref originalPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_LineUpCharacterPosition_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00016B7C File Offset: 0x00014D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1105289, XrefRangeEnd = 1105300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindNearestLine(Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_FindNearestLine_Public_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00016BC8 File Offset: 0x00014DC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105326, RefRangeEnd = 1105327, XrefRangeStart = 1105300, XrefRangeEnd = 1105326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindNearestCharacterOnLine(Vector2 position, int line, bool visibleOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visibleOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_FindNearestCharacterOnLine_Public_Int32_Vector2_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00016C30 File Offset: 0x00014E30
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1105357, RefRangeEnd = 1105362, XrefRangeStart = 1105327, XrefRangeEnd = 1105357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindIntersectingLink(Vector3 position, bool inverseYAxis = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inverseYAxis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_FindIntersectingLink_Public_Int32_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00016C88 File Offset: 0x00014E88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1105363, RefRangeEnd = 1105366, XrefRangeStart = 1105362, XrefRangeEnd = 1105363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_PointIntersectRectangle_Private_Static_Boolean_Vector3_Vector3_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00016D00 File Offset: 0x00014F00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1105366, RefRangeEnd = 1105370, XrefRangeStart = 1105366, XrefRangeEnd = 1105366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_DistanceToLine_Private_Static_Single_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00016D5C File Offset: 0x00014F5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1105378, RefRangeEnd = 1105380, XrefRangeStart = 1105370, XrefRangeEnd = 1105378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLineNumber(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_GetLineNumber_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00016DA8 File Offset: 0x00014FA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105388, RefRangeEnd = 1105389, XrefRangeStart = 1105380, XrefRangeEnd = 1105388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetLineHeight(int lineNumber)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lineNumber;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_GetLineHeight_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00016DF4 File Offset: 0x00014FF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105405, RefRangeEnd = 1105406, XrefRangeStart = 1105389, XrefRangeEnd = 1105405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetLineHeightFromCharacterIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_GetLineHeightFromCharacterIndex_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00016E40 File Offset: 0x00015040
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105414, RefRangeEnd = 1105415, XrefRangeStart = 1105406, XrefRangeEnd = 1105414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetCharacterHeightFromIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_GetCharacterHeightFromIndex_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00016E8C File Offset: 0x0001508C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105422, RefRangeEnd = 1105423, XrefRangeStart = 1105415, XrefRangeEnd = 1105422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsElided()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_IsElided_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00016EC8 File Offset: 0x000150C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105442, RefRangeEnd = 1105443, XrefRangeStart = 1105423, XrefRangeEnd = 1105442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Substring(int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_Substring_Public_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00016F1C File Offset: 0x0001511C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1105455, RefRangeEnd = 1105460, XrefRangeStart = 1105443, XrefRangeEnd = 1105455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(char value, int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00016F74 File Offset: 0x00015174
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1105466, RefRangeEnd = 1105470, XrefRangeStart = 1105460, XrefRangeEnd = 1105466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(char value, int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00016FCC File Offset: 0x000151CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105471, RefRangeEnd = 1105472, XrefRangeStart = 1105470, XrefRangeEnd = 1105471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ComputeTextWidth(TextGenerationSettings tgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tgs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_ComputeTextWidth_Protected_Single_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0001701C File Offset: 0x0001521C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105473, RefRangeEnd = 1105474, XrefRangeStart = 1105472, XrefRangeEnd = 1105473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ComputeTextHeight(TextGenerationSettings tgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tgs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_ComputeTextHeight_Protected_Single_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0001706C File Offset: 0x0001526C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1105494, RefRangeEnd = 1105496, XrefRangeStart = 1105474, XrefRangeEnd = 1105494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePreferredValues(TextGenerationSettings tgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tgs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_UpdatePreferredValues_Protected_Void_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x000170B0 File Offset: 0x000152B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105510, RefRangeEnd = 1105511, XrefRangeStart = 1105496, XrefRangeEnd = 1105510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextInfo Update(TextGenerationSettings tgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tgs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextHandle.NativeMethodInfoPtr_Update_Protected_TextInfo_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00005502 File Offset: 0x00003702
		public TextHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x00017100 File Offset: 0x00015300
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x0000550B File Offset: 0x0000370B
		public unsafe Vector2 m_PreferredSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextHandle.NativeFieldInfoPtr_m_PreferredSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextHandle.NativeFieldInfoPtr_m_PreferredSize)) = value;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00017128 File Offset: 0x00015328
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x00005526 File Offset: 0x00003726
		public unsafe TextInfo m_TextInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextHandle.NativeFieldInfoPtr_m_TextInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextHandle.NativeFieldInfoPtr_m_TextInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x00017158 File Offset: 0x00015358
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x00005545 File Offset: 0x00003745
		public unsafe static TextInfo m_LayoutTextInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextHandle.NativeFieldInfoPtr_m_LayoutTextInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextHandle.NativeFieldInfoPtr_m_LayoutTextInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00017180 File Offset: 0x00015380
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x00005557 File Offset: 0x00003757
		public unsafe int m_PreviousGenerationSettingsHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextHandle.NativeFieldInfoPtr_m_PreviousGenerationSettingsHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextHandle.NativeFieldInfoPtr_m_PreviousGenerationSettingsHash)) = value;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x000171A8 File Offset: 0x000153A8
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x00005572 File Offset: 0x00003772
		public unsafe TextGenerationSettings textGenerationSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextHandle.NativeFieldInfoPtr_textGenerationSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextGenerationSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextHandle.NativeFieldInfoPtr_textGenerationSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x000171D8 File Offset: 0x000153D8
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x00005591 File Offset: 0x00003791
		public unsafe static TextGenerationSettings s_LayoutSettings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextHandle.NativeFieldInfoPtr_s_LayoutSettings, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextGenerationSettings>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextHandle.NativeFieldInfoPtr_s_LayoutSettings, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x00017200 File Offset: 0x00015400
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x000055A3 File Offset: 0x000037A3
		public unsafe bool isDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextHandle.NativeFieldInfoPtr_isDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextHandle.NativeFieldInfoPtr_isDirty)) = value;
			}
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00017228 File Offset: 0x00015428
		public bool IsTextInfoAllocated()
		{
			return this.m_TextInfo != null;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x000055BE File Offset: 0x000037BE
		public void SetDirty()
		{
			this.isDirty = true;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00017244 File Offset: 0x00015444
		public int FindWordIndex(int cursorIndex)
		{
			for (int i = 0; i < this.textInfo.wordCount; i++)
			{
				WordInfo wordInfo = this.textInfo.wordInfo[i];
				bool flag = wordInfo.firstCharacterIndex <= cursorIndex && wordInfo.lastCharacterIndex >= cursorIndex;
				if (flag)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x000172A8 File Offset: 0x000154A8
		public TextInfo Update(string newText)
		{
			this.textGenerationSettings.text = newText;
			return this.Update(this.textGenerationSettings);
		}

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeFieldInfoPtr_m_PreferredSize;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeFieldInfoPtr_m_TextInfo;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeFieldInfoPtr_m_LayoutTextInfo;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousGenerationSettingsHash;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeFieldInfoPtr_textGenerationSettings;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeFieldInfoPtr_s_LayoutSettings;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeFieldInfoPtr_isDirty;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_get_textInfo_Internal_get_TextInfo_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutTextInfo_Internal_Static_get_TextInfo_0;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_IsDirty_Public_Boolean_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_GetCursorPositionFromStringIndexUsingCharacterHeight_Public_Vector2_Int32_Boolean_0;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr_GetCursorPositionFromStringIndexUsingLineHeight_Public_Vector2_Int32_Boolean_Boolean_0;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr_GetCursorIndexFromPosition_Public_Int32_Vector2_Boolean_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr_LineDownCharacterPosition_Public_Int32_Int32_0;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeMethodInfoPtr_LineUpCharacterPosition_Public_Int32_Int32_0;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeMethodInfoPtr_FindNearestLine_Public_Int32_Vector2_0;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeMethodInfoPtr_FindNearestCharacterOnLine_Public_Int32_Vector2_Int32_Boolean_0;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeMethodInfoPtr_FindIntersectingLink_Public_Int32_Vector3_Boolean_0;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeMethodInfoPtr_PointIntersectRectangle_Private_Static_Boolean_Vector3_Vector3_Vector3_Vector3_Vector3_0;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeMethodInfoPtr_DistanceToLine_Private_Static_Single_Vector3_Vector3_Vector3_0;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeMethodInfoPtr_GetLineNumber_Public_Int32_Int32_0;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr_GetLineHeight_Public_Single_Int32_0;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeMethodInfoPtr_GetLineHeightFromCharacterIndex_Public_Single_Int32_0;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterHeightFromIndex_Public_Single_Int32_0;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeMethodInfoPtr_IsElided_Public_Boolean_0;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeMethodInfoPtr_Substring_Public_String_Int32_Int32_0;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_0;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_0;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeMethodInfoPtr_ComputeTextWidth_Protected_Single_TextGenerationSettings_0;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeMethodInfoPtr_ComputeTextHeight_Protected_Single_TextGenerationSettings_0;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePreferredValues_Protected_Void_TextGenerationSettings_0;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_TextInfo_TextGenerationSettings_0;
	}
}

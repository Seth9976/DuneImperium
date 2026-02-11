using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000071 RID: 113
	public static class TMP_TextUtilities : global::Il2CppSystem.Object
	{
		// Token: 0x06000E16 RID: 3606 RVA: 0x00039220 File Offset: 0x00037420
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_TextUtilities()
		{
			Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_TextUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr);
			TMP_TextUtilities.NativeFieldInfoPtr_m_rectWorldCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, "m_rectWorldCorners");
			TMP_TextUtilities.NativeFieldInfoPtr_k_lookupStringL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, "k_lookupStringL");
			TMP_TextUtilities.NativeFieldInfoPtr_k_lookupStringU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, "k_lookupStringU");
			TMP_TextUtilities.NativeMethodInfoPtr_GetCursorIndexFromPosition_Public_Static_Int32_TMP_Text_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664858);
			TMP_TextUtilities.NativeMethodInfoPtr_GetCursorIndexFromPosition_Public_Static_Int32_TMP_Text_Vector3_Camera_byref_CaretPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664859);
			TMP_TextUtilities.NativeMethodInfoPtr_FindNearestLine_Public_Static_Int32_TMP_Text_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664860);
			TMP_TextUtilities.NativeMethodInfoPtr_FindNearestCharacterOnLine_Public_Static_Int32_TMP_Text_Vector3_Int32_Camera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664861);
			TMP_TextUtilities.NativeMethodInfoPtr_IsIntersectingRectTransform_Public_Static_Boolean_RectTransform_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664862);
			TMP_TextUtilities.NativeMethodInfoPtr_FindIntersectingCharacter_Public_Static_Int32_TMP_Text_Vector3_Camera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664863);
			TMP_TextUtilities.NativeMethodInfoPtr_FindNearestCharacter_Public_Static_Int32_TMP_Text_Vector3_Camera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664864);
			TMP_TextUtilities.NativeMethodInfoPtr_FindIntersectingWord_Public_Static_Int32_TMP_Text_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664865);
			TMP_TextUtilities.NativeMethodInfoPtr_FindNearestWord_Public_Static_Int32_TMP_Text_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664866);
			TMP_TextUtilities.NativeMethodInfoPtr_FindIntersectingLine_Public_Static_Int32_TMP_Text_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664867);
			TMP_TextUtilities.NativeMethodInfoPtr_FindIntersectingLink_Public_Static_Int32_TMP_Text_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664868);
			TMP_TextUtilities.NativeMethodInfoPtr_FindNearestLink_Public_Static_Int32_TMP_Text_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664869);
			TMP_TextUtilities.NativeMethodInfoPtr_PointIntersectRectangle_Private_Static_Boolean_Vector3_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664870);
			TMP_TextUtilities.NativeMethodInfoPtr_ScreenPointToWorldPointInRectangle_Public_Static_Boolean_Transform_Vector2_Camera_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664871);
			TMP_TextUtilities.NativeMethodInfoPtr_IntersectLinePlane_Private_Static_Boolean_LineSegment_Vector3_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664872);
			TMP_TextUtilities.NativeMethodInfoPtr_DistanceToLine_Public_Static_Single_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664873);
			TMP_TextUtilities.NativeMethodInfoPtr_ToLowerFast_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664874);
			TMP_TextUtilities.NativeMethodInfoPtr_ToUpperFast_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664875);
			TMP_TextUtilities.NativeMethodInfoPtr_ToUpperASCIIFast_Internal_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664876);
			TMP_TextUtilities.NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664877);
			TMP_TextUtilities.NativeMethodInfoPtr_GetSimpleHashCode_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664878);
			TMP_TextUtilities.NativeMethodInfoPtr_GetSimpleHashCodeLowercase_Public_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664879);
			TMP_TextUtilities.NativeMethodInfoPtr_HexToInt_Public_Static_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664880);
			TMP_TextUtilities.NativeMethodInfoPtr_StringHexToInt_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664881);
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x0003946C File Offset: 0x0003766C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049710, XrefRangeEnd = 1049719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textComponent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_GetCursorIndexFromPosition_Public_Static_Int32_TMP_Text_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x000394D0 File Offset: 0x000376D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1049731, RefRangeEnd = 1049732, XrefRangeStart = 1049719, XrefRangeEnd = 1049731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textComponent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cursor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_GetCursorIndexFromPosition_Public_Static_Int32_TMP_Text_Vector3_Camera_byref_CaretPosition_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00039540 File Offset: 0x00037740
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1049740, RefRangeEnd = 1049741, XrefRangeStart = 1049732, XrefRangeEnd = 1049740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindNearestLine_Public_Static_Int32_TMP_Text_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x000395A4 File Offset: 0x000377A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1049761, RefRangeEnd = 1049762, XrefRangeStart = 1049741, XrefRangeEnd = 1049761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visibleOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindNearestCharacterOnLine_Public_Static_Int32_TMP_Text_Vector3_Int32_Camera_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00039624 File Offset: 0x00037824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049762, XrefRangeEnd = 1049769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_IsIntersectingRectTransform_Public_Static_Boolean_RectTransform_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00039688 File Offset: 0x00037888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049769, XrefRangeEnd = 1049783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visibleOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindIntersectingCharacter_Public_Static_Int32_TMP_Text_Vector3_Camera_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x000396F8 File Offset: 0x000378F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1049804, RefRangeEnd = 1049805, XrefRangeStart = 1049783, XrefRangeEnd = 1049804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visibleOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindNearestCharacter_Public_Static_Int32_TMP_Text_Vector3_Camera_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00039768 File Offset: 0x00037968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049805, XrefRangeEnd = 1049838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindIntersectingWord_Public_Static_Int32_TMP_Text_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x000397CC File Offset: 0x000379CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049838, XrefRangeEnd = 1049887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindNearestWord_Public_Static_Int32_TMP_Text_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00039830 File Offset: 0x00037A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049887, XrefRangeEnd = 1049895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindIntersectingLine_Public_Static_Int32_TMP_Text_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00039894 File Offset: 0x00037A94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1049924, RefRangeEnd = 1049925, XrefRangeStart = 1049895, XrefRangeEnd = 1049924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindIntersectingLink_Public_Static_Int32_TMP_Text_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x000398F8 File Offset: 0x00037AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049925, XrefRangeEnd = 1049973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindNearestLink_Public_Static_Int32_TMP_Text_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x0003995C File Offset: 0x00037B5C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1049974, RefRangeEnd = 1049985, XrefRangeStart = 1049973, XrefRangeEnd = 1049974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_PointIntersectRectangle_Private_Static_Boolean_Vector3_Vector3_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x000399D4 File Offset: 0x00037BD4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1050007, RefRangeEnd = 1050019, XrefRangeStart = 1049985, XrefRangeEnd = 1050007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &worldPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_ScreenPointToWorldPointInRectangle_Public_Static_Boolean_Transform_Vector2_Camera_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00039A44 File Offset: 0x00037C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050019, XrefRangeEnd = 1050025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IntersectLinePlane(TMP_TextUtilities.LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref line;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normal;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &intersectingPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_IntersectLinePlane_Private_Static_Boolean_LineSegment_Vector3_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x00039AAC File Offset: 0x00037CAC
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 1050025, RefRangeEnd = 1050053, XrefRangeStart = 1050025, XrefRangeEnd = 1050025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_DistanceToLine_Public_Static_Single_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x00039B08 File Offset: 0x00037D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050053, XrefRangeEnd = 1050056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToLowerFast(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_ToLowerFast_Public_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x00039B48 File Offset: 0x00037D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050056, XrefRangeEnd = 1050059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToUpperFast(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_ToUpperFast_Public_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00039B88 File Offset: 0x00037D88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1050062, RefRangeEnd = 1050065, XrefRangeStart = 1050059, XrefRangeEnd = 1050062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUpperASCIIFast(uint c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_ToUpperASCIIFast_Internal_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x00039BC8 File Offset: 0x00037DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050065, XrefRangeEnd = 1050073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHashCode(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x00039C0C File Offset: 0x00037E0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1049626, RefRangeEnd = 1049628, XrefRangeStart = 1049626, XrefRangeEnd = 1049628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSimpleHashCode(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_GetSimpleHashCode_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x00039C50 File Offset: 0x00037E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050073, XrefRangeEnd = 1050081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetSimpleHashCodeLowercase(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_GetSimpleHashCodeLowercase_Public_Static_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x00039C94 File Offset: 0x00037E94
		[CallerCount(0)]
		public unsafe static int HexToInt(char hex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_HexToInt_Public_Static_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x00039CD4 File Offset: 0x00037ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050081, XrefRangeEnd = 1050102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int StringHexToInt(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_StringHexToInt_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x00008A97 File Offset: 0x00006C97
		public TMP_TextUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x00039D18 File Offset: 0x00037F18
		// (set) Token: 0x06000E31 RID: 3633 RVA: 0x00008AA0 File Offset: 0x00006CA0
		public unsafe static Il2CppStructArray<Vector3> m_rectWorldCorners
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_TextUtilities.NativeFieldInfoPtr_m_rectWorldCorners, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_TextUtilities.NativeFieldInfoPtr_m_rectWorldCorners, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x00039D40 File Offset: 0x00037F40
		// (set) Token: 0x06000E33 RID: 3635 RVA: 0x00008AB2 File Offset: 0x00006CB2
		public unsafe static string k_lookupStringL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_TextUtilities.NativeFieldInfoPtr_k_lookupStringL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_TextUtilities.NativeFieldInfoPtr_k_lookupStringL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x00039D60 File Offset: 0x00037F60
		// (set) Token: 0x06000E35 RID: 3637 RVA: 0x00008AC4 File Offset: 0x00006CC4
		public unsafe static string k_lookupStringU
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_TextUtilities.NativeFieldInfoPtr_k_lookupStringU, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_TextUtilities.NativeFieldInfoPtr_k_lookupStringU, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeFieldInfoPtr_m_rectWorldCorners;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeFieldInfoPtr_k_lookupStringL;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeFieldInfoPtr_k_lookupStringU;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeMethodInfoPtr_GetCursorIndexFromPosition_Public_Static_Int32_TMP_Text_Vector3_Camera_0;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeMethodInfoPtr_GetCursorIndexFromPosition_Public_Static_Int32_TMP_Text_Vector3_Camera_byref_CaretPosition_0;

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeMethodInfoPtr_FindNearestLine_Public_Static_Int32_TMP_Text_Vector3_Camera_0;

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeMethodInfoPtr_FindNearestCharacterOnLine_Public_Static_Int32_TMP_Text_Vector3_Int32_Camera_Boolean_0;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeMethodInfoPtr_IsIntersectingRectTransform_Public_Static_Boolean_RectTransform_Vector3_Camera_0;

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeMethodInfoPtr_FindIntersectingCharacter_Public_Static_Int32_TMP_Text_Vector3_Camera_Boolean_0;

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeMethodInfoPtr_FindNearestCharacter_Public_Static_Int32_TMP_Text_Vector3_Camera_Boolean_0;

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeMethodInfoPtr_FindIntersectingWord_Public_Static_Int32_TMP_Text_Vector3_Camera_0;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeMethodInfoPtr_FindNearestWord_Public_Static_Int32_TMP_Text_Vector3_Camera_0;

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeMethodInfoPtr_FindIntersectingLine_Public_Static_Int32_TMP_Text_Vector3_Camera_0;

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeMethodInfoPtr_FindIntersectingLink_Public_Static_Int32_TMP_Text_Vector3_Camera_0;

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeMethodInfoPtr_FindNearestLink_Public_Static_Int32_TMP_Text_Vector3_Camera_0;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeMethodInfoPtr_PointIntersectRectangle_Private_Static_Boolean_Vector3_Vector3_Vector3_Vector3_Vector3_0;

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToWorldPointInRectangle_Public_Static_Boolean_Transform_Vector2_Camera_byref_Vector3_0;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeMethodInfoPtr_IntersectLinePlane_Private_Static_Boolean_LineSegment_Vector3_Vector3_byref_Vector3_0;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeMethodInfoPtr_DistanceToLine_Public_Static_Single_Vector3_Vector3_Vector3_0;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeMethodInfoPtr_ToLowerFast_Public_Static_Char_Char_0;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperFast_Public_Static_Char_Char_0;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperASCIIFast_Internal_Static_UInt32_UInt32_0;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_String_0;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr_GetSimpleHashCode_Public_Static_Int32_String_0;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeMethodInfoPtr_GetSimpleHashCodeLowercase_Public_Static_UInt32_String_0;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeMethodInfoPtr_HexToInt_Public_Static_Int32_Char_0;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeMethodInfoPtr_StringHexToInt_Public_Static_Int32_String_0;

		// Token: 0x020000B3 RID: 179
		[StructLayout(2)]
		public struct LineSegment
		{
			// Token: 0x0600102C RID: 4140 RVA: 0x0003F808 File Offset: 0x0003DA08
			// Note: this type is marked as 'beforefieldinit'.
			static LineSegment()
			{
				Il2CppClassPointerStore<TMP_TextUtilities.LineSegment>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, "LineSegment");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_TextUtilities.LineSegment>.NativeClassPtr);
				TMP_TextUtilities.LineSegment.NativeFieldInfoPtr_Point1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextUtilities.LineSegment>.NativeClassPtr, "Point1");
				TMP_TextUtilities.LineSegment.NativeFieldInfoPtr_Point2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextUtilities.LineSegment>.NativeClassPtr, "Point2");
				TMP_TextUtilities.LineSegment.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities.LineSegment>.NativeClassPtr, 100664883);
			}

			// Token: 0x0600102D RID: 4141 RVA: 0x0003F870 File Offset: 0x0003DA70
			[CallerCount(0)]
			public unsafe LineSegment(Vector3 p1, Vector3 p2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref p1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.LineSegment.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600102E RID: 4142 RVA: 0x00009BA2 File Offset: 0x00007DA2
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextUtilities.LineSegment>.NativeClassPtr, ref this));
			}

			// Token: 0x04000CA5 RID: 3237
			private static readonly IntPtr NativeFieldInfoPtr_Point1;

			// Token: 0x04000CA6 RID: 3238
			private static readonly IntPtr NativeFieldInfoPtr_Point2;

			// Token: 0x04000CA7 RID: 3239
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0;

			// Token: 0x04000CA8 RID: 3240
			[FieldOffset(0)]
			public Vector3 Point1;

			// Token: 0x04000CA9 RID: 3241
			[FieldOffset(12)]
			public Vector3 Point2;
		}
	}
}

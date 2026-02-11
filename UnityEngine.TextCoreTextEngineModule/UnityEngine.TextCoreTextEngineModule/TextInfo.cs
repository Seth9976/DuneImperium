using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000030 RID: 48
	public class TextInfo : Object
	{
		// Token: 0x06000563 RID: 1379 RVA: 0x000173D4 File Offset: 0x000155D4
		// Note: this type is marked as 'beforefieldinit'.
		static TextInfo()
		{
			Il2CppClassPointerStore<TextInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextInfo>.NativeClassPtr);
			TextInfo.NativeFieldInfoPtr_s_InfinityVectorPositive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "s_InfinityVectorPositive");
			TextInfo.NativeFieldInfoPtr_s_InfinityVectorNegative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "s_InfinityVectorNegative");
			TextInfo.NativeFieldInfoPtr_characterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "characterCount");
			TextInfo.NativeFieldInfoPtr_spriteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "spriteCount");
			TextInfo.NativeFieldInfoPtr_spaceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "spaceCount");
			TextInfo.NativeFieldInfoPtr_wordCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "wordCount");
			TextInfo.NativeFieldInfoPtr_linkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "linkCount");
			TextInfo.NativeFieldInfoPtr_lineCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "lineCount");
			TextInfo.NativeFieldInfoPtr_pageCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "pageCount");
			TextInfo.NativeFieldInfoPtr_materialCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "materialCount");
			TextInfo.NativeFieldInfoPtr_textElementInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "textElementInfo");
			TextInfo.NativeFieldInfoPtr_wordInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "wordInfo");
			TextInfo.NativeFieldInfoPtr_linkInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "linkInfo");
			TextInfo.NativeFieldInfoPtr_lineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "lineInfo");
			TextInfo.NativeFieldInfoPtr_pageInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "pageInfo");
			TextInfo.NativeFieldInfoPtr_meshInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "meshInfo");
			TextInfo.NativeFieldInfoPtr_isDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "isDirty");
			TextInfo.NativeFieldInfoPtr_hasMultipleColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "hasMultipleColors");
			TextInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100663674);
			TextInfo.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100663675);
			TextInfo.NativeMethodInfoPtr_ClearMeshInfo_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100663676);
			TextInfo.NativeMethodInfoPtr_ClearLineInfo_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100663677);
			TextInfo.NativeMethodInfoPtr_ClearPageInfo_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100663678);
			TextInfo.NativeMethodInfoPtr_Resize_Internal_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100663679);
			TextInfo.NativeMethodInfoPtr_Resize_Internal_Static_Void_byref_Il2CppArrayBase_1_T_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100663680);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000175F8 File Offset: 0x000157F8
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 1105536, RefRangeEnd = 1105565, XrefRangeStart = 1105511, XrefRangeEnd = 1105536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00017634 File Offset: 0x00015834
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105566, RefRangeEnd = 1105567, XrefRangeStart = 1105565, XrefRangeEnd = 1105566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00017668 File Offset: 0x00015868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105572, RefRangeEnd = 1105573, XrefRangeStart = 1105567, XrefRangeEnd = 1105572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearMeshInfo(bool updateMesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateMesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_ClearMeshInfo_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000176A8 File Offset: 0x000158A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105585, RefRangeEnd = 1105586, XrefRangeStart = 1105573, XrefRangeEnd = 1105585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearLineInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_ClearLineInfo_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000176DC File Offset: 0x000158DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1105590, RefRangeEnd = 1105591, XrefRangeStart = 1105586, XrefRangeEnd = 1105590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPageInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_ClearPageInfo_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00017710 File Offset: 0x00015910
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1049578, RefRangeEnd = 1049586, XrefRangeStart = 1049578, XrefRangeEnd = 1049586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Resize<T>(ref Il2CppArrayBase<T> array, int size)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TextInfo.MethodInfoStoreGeneric_Resize_Internal_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0001776C File Offset: 0x0001596C
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1049590, RefRangeEnd = 1049608, XrefRangeStart = 1049590, XrefRangeEnd = 1049608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Resize<T>(ref Il2CppArrayBase<T> array, int size, bool isBlockAllocated)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBlockAllocated;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TextInfo.MethodInfoStoreGeneric_Resize_Internal_Static_Void_byref_Il2CppArrayBase_1_T_Int32_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x000055EC File Offset: 0x000037EC
		public TextInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x000177D4 File Offset: 0x000159D4
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x000055F5 File Offset: 0x000037F5
		public unsafe static Vector2 s_InfinityVectorPositive
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TextInfo.NativeFieldInfoPtr_s_InfinityVectorPositive, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextInfo.NativeFieldInfoPtr_s_InfinityVectorPositive, (void*)(&value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x000177F0 File Offset: 0x000159F0
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x00005603 File Offset: 0x00003803
		public unsafe static Vector2 s_InfinityVectorNegative
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TextInfo.NativeFieldInfoPtr_s_InfinityVectorNegative, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextInfo.NativeFieldInfoPtr_s_InfinityVectorNegative, (void*)(&value));
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x0001780C File Offset: 0x00015A0C
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x00005611 File Offset: 0x00003811
		public unsafe int characterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_characterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_characterCount)) = value;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x00017834 File Offset: 0x00015A34
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x0000562C File Offset: 0x0000382C
		public unsafe int spriteCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_spriteCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_spriteCount)) = value;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x0001785C File Offset: 0x00015A5C
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x00005647 File Offset: 0x00003847
		public unsafe int spaceCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_spaceCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_spaceCount)) = value;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x00017884 File Offset: 0x00015A84
		// (set) Token: 0x06000577 RID: 1399 RVA: 0x00005662 File Offset: 0x00003862
		public unsafe int wordCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_wordCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_wordCount)) = value;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x000178AC File Offset: 0x00015AAC
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x0000567D File Offset: 0x0000387D
		public unsafe int linkCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_linkCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_linkCount)) = value;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x000178D4 File Offset: 0x00015AD4
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x00005698 File Offset: 0x00003898
		public unsafe int lineCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_lineCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_lineCount)) = value;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x000178FC File Offset: 0x00015AFC
		// (set) Token: 0x0600057D RID: 1405 RVA: 0x000056B3 File Offset: 0x000038B3
		public unsafe int pageCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_pageCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_pageCount)) = value;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x00017924 File Offset: 0x00015B24
		// (set) Token: 0x0600057F RID: 1407 RVA: 0x000056CE File Offset: 0x000038CE
		public unsafe int materialCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_materialCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_materialCount)) = value;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x0001794C File Offset: 0x00015B4C
		// (set) Token: 0x06000581 RID: 1409 RVA: 0x000056E9 File Offset: 0x000038E9
		public unsafe Il2CppReferenceArray<TextElementInfo> textElementInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_textElementInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextElementInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_textElementInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x0001797C File Offset: 0x00015B7C
		// (set) Token: 0x06000583 RID: 1411 RVA: 0x00005708 File Offset: 0x00003908
		public unsafe Il2CppStructArray<WordInfo> wordInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_wordInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<WordInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_wordInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x000179AC File Offset: 0x00015BAC
		// (set) Token: 0x06000585 RID: 1413 RVA: 0x00005727 File Offset: 0x00003927
		public unsafe Il2CppReferenceArray<LinkInfo> linkInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_linkInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LinkInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_linkInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x000179DC File Offset: 0x00015BDC
		// (set) Token: 0x06000587 RID: 1415 RVA: 0x00005746 File Offset: 0x00003946
		public unsafe Il2CppStructArray<LineInfo> lineInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_lineInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<LineInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_lineInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x00017A0C File Offset: 0x00015C0C
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x00005765 File Offset: 0x00003965
		public unsafe Il2CppStructArray<PageInfo> pageInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_pageInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PageInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_pageInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00017A3C File Offset: 0x00015C3C
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x00005784 File Offset: 0x00003984
		public unsafe Il2CppReferenceArray<MeshInfo> meshInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_meshInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_meshInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x00017A6C File Offset: 0x00015C6C
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x000057A3 File Offset: 0x000039A3
		public unsafe bool isDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_isDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_isDirty)) = value;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x00017A94 File Offset: 0x00015C94
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x000057BE File Offset: 0x000039BE
		public unsafe bool hasMultipleColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_hasMultipleColors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_hasMultipleColors)) = value;
			}
		}

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeFieldInfoPtr_s_InfinityVectorPositive;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeFieldInfoPtr_s_InfinityVectorNegative;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeFieldInfoPtr_characterCount;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeFieldInfoPtr_spriteCount;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeFieldInfoPtr_spaceCount;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeFieldInfoPtr_wordCount;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeFieldInfoPtr_linkCount;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeFieldInfoPtr_lineCount;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeFieldInfoPtr_pageCount;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeFieldInfoPtr_materialCount;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeFieldInfoPtr_textElementInfo;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeFieldInfoPtr_wordInfo;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeFieldInfoPtr_linkInfo;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeFieldInfoPtr_lineInfo;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeFieldInfoPtr_pageInfo;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeFieldInfoPtr_meshInfo;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeFieldInfoPtr_isDirty;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeFieldInfoPtr_hasMultipleColors;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_ClearMeshInfo_Internal_Void_Boolean_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr_ClearLineInfo_Internal_Void_0;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeMethodInfoPtr_ClearPageInfo_Internal_Void_0;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Internal_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Internal_Static_Void_byref_Il2CppArrayBase_1_T_Int32_Boolean_0;

		// Token: 0x0200004F RID: 79
		private sealed class MethodInfoStoreGeneric_Resize_Internal_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x040005FA RID: 1530
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TextInfo.NativeMethodInfoPtr_Resize_Internal_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<TextInfo>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000050 RID: 80
		private sealed class MethodInfoStoreGeneric_Resize_Internal_Static_Void_byref_Il2CppArrayBase_1_T_Int32_Boolean_0<T>
		{
			// Token: 0x040005FB RID: 1531
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TextInfo.NativeMethodInfoPtr_Resize_Internal_Static_Void_byref_Il2CppArrayBase_1_T_Int32_Boolean_0, Il2CppClassPointerStore<TextInfo>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

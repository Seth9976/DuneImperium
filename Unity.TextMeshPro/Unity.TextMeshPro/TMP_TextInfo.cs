using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200006B RID: 107
	[Serializable]
	public class TMP_TextInfo : global::Il2CppSystem.Object
	{
		// Token: 0x06000DA5 RID: 3493 RVA: 0x0003786C File Offset: 0x00035A6C
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_TextInfo()
		{
			Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_TextInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr);
			TMP_TextInfo.NativeFieldInfoPtr_k_InfinityVectorPositive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "k_InfinityVectorPositive");
			TMP_TextInfo.NativeFieldInfoPtr_k_InfinityVectorNegative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "k_InfinityVectorNegative");
			TMP_TextInfo.NativeFieldInfoPtr_textComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "textComponent");
			TMP_TextInfo.NativeFieldInfoPtr_characterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "characterCount");
			TMP_TextInfo.NativeFieldInfoPtr_spriteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "spriteCount");
			TMP_TextInfo.NativeFieldInfoPtr_spaceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "spaceCount");
			TMP_TextInfo.NativeFieldInfoPtr_wordCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "wordCount");
			TMP_TextInfo.NativeFieldInfoPtr_linkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "linkCount");
			TMP_TextInfo.NativeFieldInfoPtr_lineCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "lineCount");
			TMP_TextInfo.NativeFieldInfoPtr_pageCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "pageCount");
			TMP_TextInfo.NativeFieldInfoPtr_materialCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "materialCount");
			TMP_TextInfo.NativeFieldInfoPtr_characterInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "characterInfo");
			TMP_TextInfo.NativeFieldInfoPtr_wordInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "wordInfo");
			TMP_TextInfo.NativeFieldInfoPtr_linkInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "linkInfo");
			TMP_TextInfo.NativeFieldInfoPtr_lineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "lineInfo");
			TMP_TextInfo.NativeFieldInfoPtr_pageInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "pageInfo");
			TMP_TextInfo.NativeFieldInfoPtr_meshInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "meshInfo");
			TMP_TextInfo.NativeFieldInfoPtr_m_CachedMeshInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "m_CachedMeshInfo");
			TMP_TextInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664810);
			TMP_TextInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664811);
			TMP_TextInfo.NativeMethodInfoPtr__ctor_Public_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664812);
			TMP_TextInfo.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664813);
			TMP_TextInfo.NativeMethodInfoPtr_ClearAllData_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664814);
			TMP_TextInfo.NativeMethodInfoPtr_ClearMeshInfo_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664815);
			TMP_TextInfo.NativeMethodInfoPtr_ClearAllMeshInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664816);
			TMP_TextInfo.NativeMethodInfoPtr_ResetVertexLayout_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664817);
			TMP_TextInfo.NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Il2CppReferenceArray_1_MaterialReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664818);
			TMP_TextInfo.NativeMethodInfoPtr_ClearLineInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664819);
			TMP_TextInfo.NativeMethodInfoPtr_ClearPageInfo_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664820);
			TMP_TextInfo.NativeMethodInfoPtr_CopyMeshInfoVertexData_Public_Il2CppReferenceArray_1_TMP_MeshInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664821);
			TMP_TextInfo.NativeMethodInfoPtr_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664822);
			TMP_TextInfo.NativeMethodInfoPtr_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664823);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00037B1C File Offset: 0x00035D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049386, XrefRangeEnd = 1049411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00037B58 File Offset: 0x00035D58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1049436, RefRangeEnd = 1049438, XrefRangeStart = 1049411, XrefRangeEnd = 1049436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextInfo(int characterCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref characterCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00037BA0 File Offset: 0x00035DA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1049465, RefRangeEnd = 1049467, XrefRangeStart = 1049438, XrefRangeEnd = 1049465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextInfo(TMP_Text textComponent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr__ctor_Public_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00037BEC File Offset: 0x00035DEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1049468, RefRangeEnd = 1049471, XrefRangeStart = 1049467, XrefRangeEnd = 1049468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00037C20 File Offset: 0x00035E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049471, XrefRangeEnd = 1049495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAllData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_ClearAllData_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00037C54 File Offset: 0x00035E54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1049500, RefRangeEnd = 1049501, XrefRangeStart = 1049495, XrefRangeEnd = 1049500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearMeshInfo(bool updateMesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateMesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_ClearMeshInfo_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00037C94 File Offset: 0x00035E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049501, XrefRangeEnd = 1049506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAllMeshInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_ClearAllMeshInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00037CC8 File Offset: 0x00035EC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1049511, RefRangeEnd = 1049512, XrefRangeStart = 1049506, XrefRangeEnd = 1049511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetVertexLayout(bool isVolumetric)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVolumetric;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_ResetVertexLayout_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00037D08 File Offset: 0x00035F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049512, XrefRangeEnd = 1049517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearUnusedVertices(Il2CppReferenceArray<MaterialReference> materials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(materials);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Il2CppReferenceArray_1_MaterialReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00037D4C File Offset: 0x00035F4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1049528, RefRangeEnd = 1049530, XrefRangeStart = 1049517, XrefRangeEnd = 1049528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearLineInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_ClearLineInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00037D80 File Offset: 0x00035F80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1049534, RefRangeEnd = 1049536, XrefRangeStart = 1049530, XrefRangeEnd = 1049534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPageInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_ClearPageInfo_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00037DB4 File Offset: 0x00035FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049536, XrefRangeEnd = 1049574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<TMP_MeshInfo> CopyMeshInfoVertexData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_CopyMeshInfoVertexData_Public_Il2CppReferenceArray_1_TMP_MeshInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_MeshInfo>>(intPtr3) : null;
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00037DF4 File Offset: 0x00035FF4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1049578, RefRangeEnd = 1049586, XrefRangeStart = 1049574, XrefRangeEnd = 1049578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.MethodInfoStoreGeneric_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00037E50 File Offset: 0x00036050
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1049590, RefRangeEnd = 1049608, XrefRangeStart = 1049586, XrefRangeEnd = 1049590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.MethodInfoStoreGeneric_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x0000878B File Offset: 0x0000698B
		public TMP_TextInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x00037EB8 File Offset: 0x000360B8
		// (set) Token: 0x06000DB6 RID: 3510 RVA: 0x00008794 File Offset: 0x00006994
		public unsafe static Vector2 k_InfinityVectorPositive
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_TextInfo.NativeFieldInfoPtr_k_InfinityVectorPositive, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_TextInfo.NativeFieldInfoPtr_k_InfinityVectorPositive, (void*)(&value));
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x00037ED4 File Offset: 0x000360D4
		// (set) Token: 0x06000DB8 RID: 3512 RVA: 0x000087A2 File Offset: 0x000069A2
		public unsafe static Vector2 k_InfinityVectorNegative
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_TextInfo.NativeFieldInfoPtr_k_InfinityVectorNegative, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_TextInfo.NativeFieldInfoPtr_k_InfinityVectorNegative, (void*)(&value));
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x00037EF0 File Offset: 0x000360F0
		// (set) Token: 0x06000DBA RID: 3514 RVA: 0x000087B0 File Offset: 0x000069B0
		public unsafe TMP_Text textComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_textComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_textComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000DBB RID: 3515 RVA: 0x00037F20 File Offset: 0x00036120
		// (set) Token: 0x06000DBC RID: 3516 RVA: 0x000087CF File Offset: 0x000069CF
		public unsafe int characterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_characterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_characterCount)) = value;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000DBD RID: 3517 RVA: 0x00037F48 File Offset: 0x00036148
		// (set) Token: 0x06000DBE RID: 3518 RVA: 0x000087EA File Offset: 0x000069EA
		public unsafe int spriteCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_spriteCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_spriteCount)) = value;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000DBF RID: 3519 RVA: 0x00037F70 File Offset: 0x00036170
		// (set) Token: 0x06000DC0 RID: 3520 RVA: 0x00008805 File Offset: 0x00006A05
		public unsafe int spaceCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_spaceCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_spaceCount)) = value;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x00037F98 File Offset: 0x00036198
		// (set) Token: 0x06000DC2 RID: 3522 RVA: 0x00008820 File Offset: 0x00006A20
		public unsafe int wordCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_wordCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_wordCount)) = value;
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x00037FC0 File Offset: 0x000361C0
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x0000883B File Offset: 0x00006A3B
		public unsafe int linkCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_linkCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_linkCount)) = value;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x00037FE8 File Offset: 0x000361E8
		// (set) Token: 0x06000DC6 RID: 3526 RVA: 0x00008856 File Offset: 0x00006A56
		public unsafe int lineCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_lineCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_lineCount)) = value;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x00038010 File Offset: 0x00036210
		// (set) Token: 0x06000DC8 RID: 3528 RVA: 0x00008871 File Offset: 0x00006A71
		public unsafe int pageCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_pageCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_pageCount)) = value;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x00038038 File Offset: 0x00036238
		// (set) Token: 0x06000DCA RID: 3530 RVA: 0x0000888C File Offset: 0x00006A8C
		public unsafe int materialCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_materialCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_materialCount)) = value;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x00038060 File Offset: 0x00036260
		// (set) Token: 0x06000DCC RID: 3532 RVA: 0x000088A7 File Offset: 0x00006AA7
		public unsafe Il2CppReferenceArray<TMP_CharacterInfo> characterInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_characterInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_CharacterInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_characterInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x00038090 File Offset: 0x00036290
		// (set) Token: 0x06000DCE RID: 3534 RVA: 0x000088C6 File Offset: 0x00006AC6
		public unsafe Il2CppReferenceArray<TMP_WordInfo> wordInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_wordInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_WordInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_wordInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x000380C0 File Offset: 0x000362C0
		// (set) Token: 0x06000DD0 RID: 3536 RVA: 0x000088E5 File Offset: 0x00006AE5
		public unsafe Il2CppReferenceArray<TMP_LinkInfo> linkInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_linkInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_LinkInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_linkInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x000380F0 File Offset: 0x000362F0
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x00008904 File Offset: 0x00006B04
		public unsafe Il2CppStructArray<TMP_LineInfo> lineInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_lineInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TMP_LineInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_lineInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x00038120 File Offset: 0x00036320
		// (set) Token: 0x06000DD4 RID: 3540 RVA: 0x00008923 File Offset: 0x00006B23
		public unsafe Il2CppStructArray<TMP_PageInfo> pageInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_pageInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TMP_PageInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_pageInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x00038150 File Offset: 0x00036350
		// (set) Token: 0x06000DD6 RID: 3542 RVA: 0x00008942 File Offset: 0x00006B42
		public unsafe Il2CppReferenceArray<TMP_MeshInfo> meshInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_meshInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_MeshInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_meshInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x00038180 File Offset: 0x00036380
		// (set) Token: 0x06000DD8 RID: 3544 RVA: 0x00008961 File Offset: 0x00006B61
		public unsafe Il2CppReferenceArray<TMP_MeshInfo> m_CachedMeshInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_m_CachedMeshInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_MeshInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_m_CachedMeshInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeFieldInfoPtr_k_InfinityVectorPositive;

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeFieldInfoPtr_k_InfinityVectorNegative;

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeFieldInfoPtr_textComponent;

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeFieldInfoPtr_characterCount;

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeFieldInfoPtr_spriteCount;

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeFieldInfoPtr_spaceCount;

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeFieldInfoPtr_wordCount;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeFieldInfoPtr_linkCount;

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeFieldInfoPtr_lineCount;

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeFieldInfoPtr_pageCount;

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeFieldInfoPtr_materialCount;

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeFieldInfoPtr_characterInfo;

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeFieldInfoPtr_wordInfo;

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeFieldInfoPtr_linkInfo;

		// Token: 0x04000AD7 RID: 2775
		private static readonly IntPtr NativeFieldInfoPtr_lineInfo;

		// Token: 0x04000AD8 RID: 2776
		private static readonly IntPtr NativeFieldInfoPtr_pageInfo;

		// Token: 0x04000AD9 RID: 2777
		private static readonly IntPtr NativeFieldInfoPtr_meshInfo;

		// Token: 0x04000ADA RID: 2778
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedMeshInfo;

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000ADC RID: 2780
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x04000ADD RID: 2781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TMP_Text_0;

		// Token: 0x04000ADE RID: 2782
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000ADF RID: 2783
		private static readonly IntPtr NativeMethodInfoPtr_ClearAllData_Internal_Void_0;

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeMethodInfoPtr_ClearMeshInfo_Public_Void_Boolean_0;

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeMethodInfoPtr_ClearAllMeshInfo_Public_Void_0;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeMethodInfoPtr_ResetVertexLayout_Public_Void_Boolean_0;

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Il2CppReferenceArray_1_MaterialReference_0;

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeMethodInfoPtr_ClearLineInfo_Public_Void_0;

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeMethodInfoPtr_ClearPageInfo_Internal_Void_0;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeMethodInfoPtr_CopyMeshInfoVertexData_Public_Il2CppReferenceArray_1_TMP_MeshInfo_0;

		// Token: 0x04000AE7 RID: 2791
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04000AE8 RID: 2792
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_Boolean_0;

		// Token: 0x020000B1 RID: 177
		private sealed class MethodInfoStoreGeneric_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x04000CA3 RID: 3235
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TMP_TextInfo.NativeMethodInfoPtr_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000B2 RID: 178
		private sealed class MethodInfoStoreGeneric_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_Boolean_0<T>
		{
			// Token: 0x04000CA4 RID: 3236
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TMP_TextInfo.NativeMethodInfoPtr_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_Boolean_0, Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

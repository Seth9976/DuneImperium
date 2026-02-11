using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	// Token: 0x0200003D RID: 61
	[Serializable]
	public class TMP_GlyphPairAdjustmentRecord : Object
	{
		// Token: 0x060005E7 RID: 1511 RVA: 0x0001D2AC File Offset: 0x0001B4AC
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_GlyphPairAdjustmentRecord()
		{
			Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_GlyphPairAdjustmentRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr);
			TMP_GlyphPairAdjustmentRecord.NativeFieldInfoPtr_m_FirstAdjustmentRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, "m_FirstAdjustmentRecord");
			TMP_GlyphPairAdjustmentRecord.NativeFieldInfoPtr_m_SecondAdjustmentRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, "m_SecondAdjustmentRecord");
			TMP_GlyphPairAdjustmentRecord.NativeFieldInfoPtr_m_FeatureLookupFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, "m_FeatureLookupFlags");
			TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr_get_firstAdjustmentRecord_Public_get_TMP_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, 100663930);
			TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr_set_firstAdjustmentRecord_Public_set_Void_TMP_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, 100663931);
			TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr_get_secondAdjustmentRecord_Public_get_TMP_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, 100663932);
			TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr_set_secondAdjustmentRecord_Public_set_Void_TMP_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, 100663933);
			TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr_get_featureLookupFlags_Public_get_FontFeatureLookupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, 100663934);
			TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr_set_featureLookupFlags_Public_set_Void_FontFeatureLookupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, 100663935);
			TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr__ctor_Public_Void_TMP_GlyphAdjustmentRecord_TMP_GlyphAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, 100663936);
			TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr__ctor_Internal_Void_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr, 100663937);
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x0001D3B8 File Offset: 0x0001B5B8
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x0001D3F4 File Offset: 0x0001B5F4
		public unsafe TMP_GlyphAdjustmentRecord firstAdjustmentRecord
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr_get_firstAdjustmentRecord_Public_get_TMP_GlyphAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr_set_firstAdjustmentRecord_Public_set_Void_TMP_GlyphAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x0001D434 File Offset: 0x0001B634
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x0001D470 File Offset: 0x0001B670
		public unsafe TMP_GlyphAdjustmentRecord secondAdjustmentRecord
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr_get_secondAdjustmentRecord_Public_get_TMP_GlyphAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr_set_secondAdjustmentRecord_Public_set_Void_TMP_GlyphAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x0001D4B0 File Offset: 0x0001B6B0
		// (set) Token: 0x060005ED RID: 1517 RVA: 0x0001D4EC File Offset: 0x0001B6EC
		public unsafe FontFeatureLookupFlags featureLookupFlags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr_get_featureLookupFlags_Public_get_FontFeatureLookupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr_set_featureLookupFlags_Public_set_Void_FontFeatureLookupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0001D52C File Offset: 0x0001B72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041483, XrefRangeEnd = 1041484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_GlyphPairAdjustmentRecord(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref firstAdjustmentRecord;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondAdjustmentRecord;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr__ctor_Public_Void_TMP_GlyphAdjustmentRecord_TMP_GlyphAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x0001D584 File Offset: 0x0001B784
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1041499, RefRangeEnd = 1041501, XrefRangeStart = 1041484, XrefRangeEnd = 1041499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_GlyphPairAdjustmentRecord(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_GlyphPairAdjustmentRecord>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref glyphPairAdjustmentRecord;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphPairAdjustmentRecord.NativeMethodInfoPtr__ctor_Internal_Void_GlyphPairAdjustmentRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00004E7A File Offset: 0x0000307A
		public TMP_GlyphPairAdjustmentRecord(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x0001D5CC File Offset: 0x0001B7CC
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x00004E83 File Offset: 0x00003083
		public unsafe TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_GlyphPairAdjustmentRecord.NativeFieldInfoPtr_m_FirstAdjustmentRecord);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_GlyphPairAdjustmentRecord.NativeFieldInfoPtr_m_FirstAdjustmentRecord)) = value;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x0001D5F4 File Offset: 0x0001B7F4
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x00004E9E File Offset: 0x0000309E
		public unsafe TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_GlyphPairAdjustmentRecord.NativeFieldInfoPtr_m_SecondAdjustmentRecord);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_GlyphPairAdjustmentRecord.NativeFieldInfoPtr_m_SecondAdjustmentRecord)) = value;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x0001D61C File Offset: 0x0001B81C
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x00004EB9 File Offset: 0x000030B9
		public unsafe FontFeatureLookupFlags m_FeatureLookupFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_GlyphPairAdjustmentRecord.NativeFieldInfoPtr_m_FeatureLookupFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_GlyphPairAdjustmentRecord.NativeFieldInfoPtr_m_FeatureLookupFlags)) = value;
			}
		}

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstAdjustmentRecord;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeFieldInfoPtr_m_SecondAdjustmentRecord;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeFieldInfoPtr_m_FeatureLookupFlags;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr_get_firstAdjustmentRecord_Public_get_TMP_GlyphAdjustmentRecord_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr_set_firstAdjustmentRecord_Public_set_Void_TMP_GlyphAdjustmentRecord_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr_get_secondAdjustmentRecord_Public_get_TMP_GlyphAdjustmentRecord_0;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr_set_secondAdjustmentRecord_Public_set_Void_TMP_GlyphAdjustmentRecord_0;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr_get_featureLookupFlags_Public_get_FontFeatureLookupFlags_0;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr_set_featureLookupFlags_Public_set_Void_FontFeatureLookupFlags_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TMP_GlyphAdjustmentRecord_TMP_GlyphAdjustmentRecord_0;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_GlyphPairAdjustmentRecord_0;
	}
}

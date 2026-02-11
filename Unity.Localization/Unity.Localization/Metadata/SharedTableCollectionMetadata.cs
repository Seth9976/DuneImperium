using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Localization.Metadata
{
	// Token: 0x020000DC RID: 220
	[Serializable]
	public class SharedTableCollectionMetadata : Object
	{
		// Token: 0x06000B22 RID: 2850 RVA: 0x000333E0 File Offset: 0x000315E0
		// Note: this type is marked as 'beforefieldinit'.
		static SharedTableCollectionMetadata()
		{
			Il2CppClassPointerStore<SharedTableCollectionMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Metadata", "SharedTableCollectionMetadata");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedTableCollectionMetadata>.NativeClassPtr);
			SharedTableCollectionMetadata.NativeFieldInfoPtr_m_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedTableCollectionMetadata>.NativeClassPtr, "m_Entries");
			SharedTableCollectionMetadata.NativeFieldInfoPtr__EntriesLookup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedTableCollectionMetadata>.NativeClassPtr, "<EntriesLookup>k__BackingField");
			SharedTableCollectionMetadata.NativeMethodInfoPtr_get_EntriesLookup_Public_get_Dictionary_2_Int64_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableCollectionMetadata>.NativeClassPtr, 100665144);
			SharedTableCollectionMetadata.NativeMethodInfoPtr_set_EntriesLookup_Public_set_Void_Dictionary_2_Int64_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableCollectionMetadata>.NativeClassPtr, 100665145);
			SharedTableCollectionMetadata.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableCollectionMetadata>.NativeClassPtr, 100665146);
			SharedTableCollectionMetadata.NativeMethodInfoPtr_Contains_Public_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableCollectionMetadata>.NativeClassPtr, 100665147);
			SharedTableCollectionMetadata.NativeMethodInfoPtr_Contains_Public_Boolean_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableCollectionMetadata>.NativeClassPtr, 100665148);
			SharedTableCollectionMetadata.NativeMethodInfoPtr_AddEntry_Public_Void_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableCollectionMetadata>.NativeClassPtr, 100665149);
			SharedTableCollectionMetadata.NativeMethodInfoPtr_RemoveEntry_Public_Void_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableCollectionMetadata>.NativeClassPtr, 100665150);
			SharedTableCollectionMetadata.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableCollectionMetadata>.NativeClassPtr, 100665151);
			SharedTableCollectionMetadata.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableCollectionMetadata>.NativeClassPtr, 100665152);
			SharedTableCollectionMetadata.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableCollectionMetadata>.NativeClassPtr, 100665153);
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x00033500 File Offset: 0x00031700
		// (set) Token: 0x06000B24 RID: 2852 RVA: 0x00033540 File Offset: 0x00031740
		public unsafe Dictionary<long, HashSet<string>> EntriesLookup
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableCollectionMetadata.NativeMethodInfoPtr_get_EntriesLookup_Public_get_Dictionary_2_Int64_HashSet_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<long, HashSet<string>>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableCollectionMetadata.NativeMethodInfoPtr_set_EntriesLookup_Public_set_Void_Dictionary_2_Int64_HashSet_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x00033584 File Offset: 0x00031784
		public unsafe bool IsEmpty
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1079170, RefRangeEnd = 1079171, XrefRangeStart = 1079167, XrefRangeEnd = 1079170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableCollectionMetadata.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x000335C0 File Offset: 0x000317C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1079175, RefRangeEnd = 1079176, XrefRangeStart = 1079171, XrefRangeEnd = 1079175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(long keyId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableCollectionMetadata.NativeMethodInfoPtr_Contains_Public_Boolean_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x0003360C File Offset: 0x0003180C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079176, XrefRangeEnd = 1079180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(long keyId, string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableCollectionMetadata.NativeMethodInfoPtr_Contains_Public_Boolean_Int64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00033668 File Offset: 0x00031868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1079195, RefRangeEnd = 1079196, XrefRangeStart = 1079180, XrefRangeEnd = 1079195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddEntry(long keyId, string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableCollectionMetadata.NativeMethodInfoPtr_AddEntry_Public_Void_Int64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x000336B8 File Offset: 0x000318B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1079206, RefRangeEnd = 1079207, XrefRangeStart = 1079196, XrefRangeEnd = 1079206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveEntry(long keyId, string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableCollectionMetadata.NativeMethodInfoPtr_RemoveEntry_Public_Void_Int64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00033708 File Offset: 0x00031908
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1079245, RefRangeEnd = 1079246, XrefRangeStart = 1079207, XrefRangeEnd = 1079245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SharedTableCollectionMetadata.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00033744 File Offset: 0x00031944
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1079276, RefRangeEnd = 1079277, XrefRangeStart = 1079246, XrefRangeEnd = 1079276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SharedTableCollectionMetadata.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00033780 File Offset: 0x00031980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SharedTableCollectionMetadata()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedTableCollectionMetadata>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableCollectionMetadata.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00006A16 File Offset: 0x00004C16
		public SharedTableCollectionMetadata(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x000337BC File Offset: 0x000319BC
		// (set) Token: 0x06000B2F RID: 2863 RVA: 0x00006A1F File Offset: 0x00004C1F
		public unsafe List<SharedTableCollectionMetadata.Item> m_Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableCollectionMetadata.NativeFieldInfoPtr_m_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SharedTableCollectionMetadata.Item>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableCollectionMetadata.NativeFieldInfoPtr_m_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x000337EC File Offset: 0x000319EC
		// (set) Token: 0x06000B31 RID: 2865 RVA: 0x00006A3E File Offset: 0x00004C3E
		public unsafe Dictionary<long, HashSet<string>> _EntriesLookup_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableCollectionMetadata.NativeFieldInfoPtr__EntriesLookup_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<long, HashSet<string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableCollectionMetadata.NativeFieldInfoPtr__EntriesLookup_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeFieldInfoPtr_m_Entries;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeFieldInfoPtr__EntriesLookup_k__BackingField;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr_get_EntriesLookup_Public_get_Dictionary_2_Int64_HashSet_1_String_0;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeMethodInfoPtr_set_EntriesLookup_Public_set_Void_Dictionary_2_Int64_HashSet_1_String_0;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Int64_0;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Int64_String_0;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr_AddEntry_Public_Void_Int64_String_0;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEntry_Public_Void_Int64_String_0;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_New_Void_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_New_Void_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0200017D RID: 381
		[Serializable]
		public class Item : Object
		{
			// Token: 0x06000FB5 RID: 4021 RVA: 0x00042F1C File Offset: 0x0004111C
			// Note: this type is marked as 'beforefieldinit'.
			static Item()
			{
				Il2CppClassPointerStore<SharedTableCollectionMetadata.Item>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SharedTableCollectionMetadata>.NativeClassPtr, "Item");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedTableCollectionMetadata.Item>.NativeClassPtr);
				SharedTableCollectionMetadata.Item.NativeFieldInfoPtr_m_KeyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedTableCollectionMetadata.Item>.NativeClassPtr, "m_KeyId");
				SharedTableCollectionMetadata.Item.NativeFieldInfoPtr_m_TableCodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedTableCollectionMetadata.Item>.NativeClassPtr, "m_TableCodes");
				SharedTableCollectionMetadata.Item.NativeMethodInfoPtr_get_KeyId_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableCollectionMetadata.Item>.NativeClassPtr, 100665154);
				SharedTableCollectionMetadata.Item.NativeMethodInfoPtr_set_KeyId_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableCollectionMetadata.Item>.NativeClassPtr, 100665155);
				SharedTableCollectionMetadata.Item.NativeMethodInfoPtr_get_Tables_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableCollectionMetadata.Item>.NativeClassPtr, 100665156);
				SharedTableCollectionMetadata.Item.NativeMethodInfoPtr_set_Tables_Public_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableCollectionMetadata.Item>.NativeClassPtr, 100665157);
				SharedTableCollectionMetadata.Item.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableCollectionMetadata.Item>.NativeClassPtr, 100665158);
			}

			// Token: 0x17000434 RID: 1076
			// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x00042FD4 File Offset: 0x000411D4
			// (set) Token: 0x06000FB7 RID: 4023 RVA: 0x00043010 File Offset: 0x00041210
			public unsafe long KeyId
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableCollectionMetadata.Item.NativeMethodInfoPtr_get_KeyId_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableCollectionMetadata.Item.NativeMethodInfoPtr_set_KeyId_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000435 RID: 1077
			// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x00043050 File Offset: 0x00041250
			// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x00043090 File Offset: 0x00041290
			public unsafe List<string> Tables
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableCollectionMetadata.Item.NativeMethodInfoPtr_get_Tables_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableCollectionMetadata.Item.NativeMethodInfoPtr_set_Tables_Public_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000FBA RID: 4026 RVA: 0x000430D4 File Offset: 0x000412D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079159, XrefRangeEnd = 1079167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Item()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedTableCollectionMetadata.Item>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableCollectionMetadata.Item.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FBB RID: 4027 RVA: 0x00008890 File Offset: 0x00006A90
			public Item(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000432 RID: 1074
			// (get) Token: 0x06000FBC RID: 4028 RVA: 0x00043110 File Offset: 0x00041310
			// (set) Token: 0x06000FBD RID: 4029 RVA: 0x00008899 File Offset: 0x00006A99
			public unsafe long m_KeyId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableCollectionMetadata.Item.NativeFieldInfoPtr_m_KeyId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableCollectionMetadata.Item.NativeFieldInfoPtr_m_KeyId)) = value;
				}
			}

			// Token: 0x17000433 RID: 1075
			// (get) Token: 0x06000FBE RID: 4030 RVA: 0x00043138 File Offset: 0x00041338
			// (set) Token: 0x06000FBF RID: 4031 RVA: 0x000088B4 File Offset: 0x00006AB4
			public unsafe List<string> m_TableCodes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableCollectionMetadata.Item.NativeFieldInfoPtr_m_TableCodes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableCollectionMetadata.Item.NativeFieldInfoPtr_m_TableCodes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000ACB RID: 2763
			private static readonly IntPtr NativeFieldInfoPtr_m_KeyId;

			// Token: 0x04000ACC RID: 2764
			private static readonly IntPtr NativeFieldInfoPtr_m_TableCodes;

			// Token: 0x04000ACD RID: 2765
			private static readonly IntPtr NativeMethodInfoPtr_get_KeyId_Public_get_Int64_0;

			// Token: 0x04000ACE RID: 2766
			private static readonly IntPtr NativeMethodInfoPtr_set_KeyId_Public_set_Void_Int64_0;

			// Token: 0x04000ACF RID: 2767
			private static readonly IntPtr NativeMethodInfoPtr_get_Tables_Public_get_List_1_String_0;

			// Token: 0x04000AD0 RID: 2768
			private static readonly IntPtr NativeMethodInfoPtr_set_Tables_Public_set_Void_List_1_String_0;

			// Token: 0x04000AD1 RID: 2769
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

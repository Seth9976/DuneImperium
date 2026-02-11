using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.Tables;

namespace UnityEngine.Localization.Metadata
{
	// Token: 0x020000DD RID: 221
	public class SharedTableEntryMetadata : Object
	{
		// Token: 0x06000B32 RID: 2866 RVA: 0x0003381C File Offset: 0x00031A1C
		// Note: this type is marked as 'beforefieldinit'.
		static SharedTableEntryMetadata()
		{
			Il2CppClassPointerStore<SharedTableEntryMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Metadata", "SharedTableEntryMetadata");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedTableEntryMetadata>.NativeClassPtr);
			SharedTableEntryMetadata.NativeFieldInfoPtr_m_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedTableEntryMetadata>.NativeClassPtr, "m_Entries");
			SharedTableEntryMetadata.NativeFieldInfoPtr_m_SharedEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedTableEntryMetadata>.NativeClassPtr, "m_SharedEntries");
			SharedTableEntryMetadata.NativeFieldInfoPtr_m_EntriesLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedTableEntryMetadata>.NativeClassPtr, "m_EntriesLookup");
			SharedTableEntryMetadata.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableEntryMetadata>.NativeClassPtr, 100665159);
			SharedTableEntryMetadata.NativeMethodInfoPtr_IsRegistered_Internal_Boolean_TableEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableEntryMetadata>.NativeClassPtr, 100665160);
			SharedTableEntryMetadata.NativeMethodInfoPtr_Register_Internal_Void_TableEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableEntryMetadata>.NativeClassPtr, 100665161);
			SharedTableEntryMetadata.NativeMethodInfoPtr_Unregister_Internal_Void_TableEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableEntryMetadata>.NativeClassPtr, 100665162);
			SharedTableEntryMetadata.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableEntryMetadata>.NativeClassPtr, 100665163);
			SharedTableEntryMetadata.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableEntryMetadata>.NativeClassPtr, 100665164);
			SharedTableEntryMetadata.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableEntryMetadata>.NativeClassPtr, 100665165);
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x00033914 File Offset: 0x00031B14
		public unsafe int Count
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1079278, RefRangeEnd = 1079280, XrefRangeStart = 1079277, XrefRangeEnd = 1079278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableEntryMetadata.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00033950 File Offset: 0x00031B50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1079284, RefRangeEnd = 1079287, XrefRangeStart = 1079280, XrefRangeEnd = 1079284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRegistered(TableEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableEntryMetadata.NativeMethodInfoPtr_IsRegistered_Internal_Boolean_TableEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x000339A0 File Offset: 0x00031BA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1079291, RefRangeEnd = 1079293, XrefRangeStart = 1079287, XrefRangeEnd = 1079291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Register(TableEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableEntryMetadata.NativeMethodInfoPtr_Register_Internal_Void_TableEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x000339E4 File Offset: 0x00031BE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1079297, RefRangeEnd = 1079300, XrefRangeStart = 1079293, XrefRangeEnd = 1079297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unregister(TableEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableEntryMetadata.NativeMethodInfoPtr_Unregister_Internal_Void_TableEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00033A28 File Offset: 0x00031C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079300, XrefRangeEnd = 1079320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableEntryMetadata.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00033A5C File Offset: 0x00031C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079320, XrefRangeEnd = 1079367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableEntryMetadata.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00033A90 File Offset: 0x00031C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079367, XrefRangeEnd = 1079382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SharedTableEntryMetadata()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedTableEntryMetadata>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableEntryMetadata.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00006A5D File Offset: 0x00004C5D
		public SharedTableEntryMetadata(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x00033ACC File Offset: 0x00031CCC
		// (set) Token: 0x06000B3C RID: 2876 RVA: 0x00006A66 File Offset: 0x00004C66
		public unsafe List<long> m_Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableEntryMetadata.NativeFieldInfoPtr_m_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableEntryMetadata.NativeFieldInfoPtr_m_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x00033AFC File Offset: 0x00031CFC
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x00006A85 File Offset: 0x00004C85
		public unsafe List<SharedTableEntryMetadata.Entry> m_SharedEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableEntryMetadata.NativeFieldInfoPtr_m_SharedEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SharedTableEntryMetadata.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableEntryMetadata.NativeFieldInfoPtr_m_SharedEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x00033B2C File Offset: 0x00031D2C
		// (set) Token: 0x06000B40 RID: 2880 RVA: 0x00006AA4 File Offset: 0x00004CA4
		public unsafe HashSet<long> m_EntriesLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableEntryMetadata.NativeFieldInfoPtr_m_EntriesLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableEntryMetadata.NativeFieldInfoPtr_m_EntriesLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeFieldInfoPtr_m_Entries;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeFieldInfoPtr_m_SharedEntries;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeFieldInfoPtr_m_EntriesLookup;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Internal_get_Int32_0;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr_IsRegistered_Internal_Boolean_TableEntry_0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr_Register_Internal_Void_TableEntry_0;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Internal_Void_TableEntry_0;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0200017E RID: 382
		[Serializable]
		[StructLayout(2)]
		public struct Entry
		{
			// Token: 0x06000FC0 RID: 4032 RVA: 0x000088D3 File Offset: 0x00006AD3
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<SharedTableEntryMetadata.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SharedTableEntryMetadata>.NativeClassPtr, "Entry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedTableEntryMetadata.Entry>.NativeClassPtr);
				SharedTableEntryMetadata.Entry.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedTableEntryMetadata.Entry>.NativeClassPtr, "id");
			}

			// Token: 0x06000FC1 RID: 4033 RVA: 0x00008907 File Offset: 0x00006B07
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SharedTableEntryMetadata.Entry>.NativeClassPtr, ref this));
			}

			// Token: 0x04000AD2 RID: 2770
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04000AD3 RID: 2771
			[FieldOffset(0)]
			public long id;
		}
	}
}

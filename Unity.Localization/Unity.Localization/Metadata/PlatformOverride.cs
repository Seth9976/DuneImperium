using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.Tables;

namespace UnityEngine.Localization.Metadata
{
	// Token: 0x020000DA RID: 218
	[Serializable]
	public class PlatformOverride : Object
	{
		// Token: 0x06000B0C RID: 2828 RVA: 0x00032DE4 File Offset: 0x00030FE4
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformOverride()
		{
			Il2CppClassPointerStore<PlatformOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Metadata", "PlatformOverride");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformOverride>.NativeClassPtr);
			PlatformOverride.NativeFieldInfoPtr_m_PlatformOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformOverride>.NativeClassPtr, "m_PlatformOverrides");
			PlatformOverride.NativeFieldInfoPtr_m_PlayerPlatformOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformOverride>.NativeClassPtr, "m_PlayerPlatformOverride");
			PlatformOverride.NativeMethodInfoPtr_AddPlatformTableOverride_Public_Void_RuntimePlatform_TableReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformOverride>.NativeClassPtr, 100665130);
			PlatformOverride.NativeMethodInfoPtr_AddPlatformEntryOverride_Public_Void_RuntimePlatform_TableEntryReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformOverride>.NativeClassPtr, 100665131);
			PlatformOverride.NativeMethodInfoPtr_AddPlatformOverride_Public_Void_RuntimePlatform_TableReference_TableEntryReference_EntryOverrideType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformOverride>.NativeClassPtr, 100665132);
			PlatformOverride.NativeMethodInfoPtr_RemovePlatformOverride_Public_Boolean_RuntimePlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformOverride>.NativeClassPtr, 100665133);
			PlatformOverride.NativeMethodInfoPtr_GetOverride_Public_Virtual_Final_New_EntryOverrideType_byref_TableReference_byref_TableEntryReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformOverride>.NativeClassPtr, 100665134);
			PlatformOverride.NativeMethodInfoPtr_GetOverride_Public_EntryOverrideType_byref_TableReference_byref_TableEntryReference_RuntimePlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformOverride>.NativeClassPtr, 100665135);
			PlatformOverride.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformOverride>.NativeClassPtr, 100665136);
			PlatformOverride.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformOverride>.NativeClassPtr, 100665137);
			PlatformOverride.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformOverride>.NativeClassPtr, 100665138);
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00032EF0 File Offset: 0x000310F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079096, XrefRangeEnd = 1079097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlatformTableOverride(RuntimePlatform platform, TableReference table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(table));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformOverride.NativeMethodInfoPtr_AddPlatformTableOverride_Public_Void_RuntimePlatform_TableReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00032F48 File Offset: 0x00031148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079097, XrefRangeEnd = 1079098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlatformEntryOverride(RuntimePlatform platform, TableEntryReference entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(entry));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformOverride.NativeMethodInfoPtr_AddPlatformEntryOverride_Public_Void_RuntimePlatform_TableEntryReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00032FA0 File Offset: 0x000311A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1079118, RefRangeEnd = 1079120, XrefRangeStart = 1079098, XrefRangeEnd = 1079118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlatformOverride(RuntimePlatform platform, TableReference table, TableEntryReference entry, EntryOverrideType entryOverrideType = EntryOverrideType.TableAndEntry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(table));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(entry));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entryOverrideType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformOverride.NativeMethodInfoPtr_AddPlatformOverride_Public_Void_RuntimePlatform_TableReference_TableEntryReference_EntryOverrideType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0003301C File Offset: 0x0003121C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079120, XrefRangeEnd = 1079128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RemovePlatformOverride(RuntimePlatform platform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformOverride.NativeMethodInfoPtr_RemovePlatformOverride_Public_Boolean_RuntimePlatform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00033068 File Offset: 0x00031268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079128, XrefRangeEnd = 1079130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EntryOverrideType GetOverride(out TableReference tableReference, out TableEntryReference tableEntryReference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(PlatformOverride.NativeMethodInfoPtr_GetOverride_Public_Virtual_Final_New_EntryOverrideType_byref_TableReference_byref_TableEntryReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			tableReference = ((intPtr5 == 0) ? null : new TableReference(intPtr5));
			IntPtr intPtr6 = intPtr2;
			tableEntryReference = ((intPtr6 == 0) ? null : new TableEntryReference(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x000330EC File Offset: 0x000312EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079130, XrefRangeEnd = 1079139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntryOverrideType GetOverride(out TableReference tableReference, out TableEntryReference tableEntryReference, RuntimePlatform platform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref platform;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(PlatformOverride.NativeMethodInfoPtr_GetOverride_Public_EntryOverrideType_byref_TableReference_byref_TableEntryReference_RuntimePlatform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			tableReference = ((intPtr5 == 0) ? null : new TableReference(intPtr5));
			IntPtr intPtr6 = intPtr2;
			tableEntryReference = ((intPtr6 == 0) ? null : new TableEntryReference(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0003317C File Offset: 0x0003137C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformOverride.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x000331B0 File Offset: 0x000313B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079139, XrefRangeEnd = 1079151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformOverride.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x000331E4 File Offset: 0x000313E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079151, XrefRangeEnd = 1079159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformOverride()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformOverride>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformOverride.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x000069AB File Offset: 0x00004BAB
		public PlatformOverride(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x00033220 File Offset: 0x00031420
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x000069B4 File Offset: 0x00004BB4
		public unsafe List<PlatformOverride.PlatformOverrideData> m_PlatformOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformOverride.NativeFieldInfoPtr_m_PlatformOverrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlatformOverride.PlatformOverrideData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformOverride.NativeFieldInfoPtr_m_PlatformOverrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x00033250 File Offset: 0x00031450
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x000069D3 File Offset: 0x00004BD3
		public unsafe PlatformOverride.PlatformOverrideData m_PlayerPlatformOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformOverride.NativeFieldInfoPtr_m_PlayerPlatformOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformOverride.PlatformOverrideData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformOverride.NativeFieldInfoPtr_m_PlayerPlatformOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeFieldInfoPtr_m_PlatformOverrides;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayerPlatformOverride;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeMethodInfoPtr_AddPlatformTableOverride_Public_Void_RuntimePlatform_TableReference_0;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeMethodInfoPtr_AddPlatformEntryOverride_Public_Void_RuntimePlatform_TableEntryReference_0;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr_AddPlatformOverride_Public_Void_RuntimePlatform_TableReference_TableEntryReference_EntryOverrideType_0;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeMethodInfoPtr_RemovePlatformOverride_Public_Boolean_RuntimePlatform_0;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeMethodInfoPtr_GetOverride_Public_Virtual_Final_New_EntryOverrideType_byref_TableReference_byref_TableEntryReference_0;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeMethodInfoPtr_GetOverride_Public_EntryOverrideType_byref_TableReference_byref_TableEntryReference_RuntimePlatform_0;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200017B RID: 379
		[Serializable]
		public class PlatformOverrideData : Object
		{
			// Token: 0x06000FA9 RID: 4009 RVA: 0x00042D48 File Offset: 0x00040F48
			// Note: this type is marked as 'beforefieldinit'.
			static PlatformOverrideData()
			{
				Il2CppClassPointerStore<PlatformOverride.PlatformOverrideData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformOverride>.NativeClassPtr, "PlatformOverrideData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformOverride.PlatformOverrideData>.NativeClassPtr);
				PlatformOverride.PlatformOverrideData.NativeFieldInfoPtr_platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformOverride.PlatformOverrideData>.NativeClassPtr, "platform");
				PlatformOverride.PlatformOverrideData.NativeFieldInfoPtr_entryOverrideType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformOverride.PlatformOverrideData>.NativeClassPtr, "entryOverrideType");
				PlatformOverride.PlatformOverrideData.NativeFieldInfoPtr_tableReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformOverride.PlatformOverrideData>.NativeClassPtr, "tableReference");
				PlatformOverride.PlatformOverrideData.NativeFieldInfoPtr_tableEntryReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformOverride.PlatformOverrideData>.NativeClassPtr, "tableEntryReference");
				PlatformOverride.PlatformOverrideData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformOverride.PlatformOverrideData>.NativeClassPtr, 100665139);
				PlatformOverride.PlatformOverrideData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformOverride.PlatformOverrideData>.NativeClassPtr, 100665140);
			}

			// Token: 0x06000FAA RID: 4010 RVA: 0x00042DEC File Offset: 0x00040FEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079086, XrefRangeEnd = 1079096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformOverride.PlatformOverrideData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06000FAB RID: 4011 RVA: 0x00042E30 File Offset: 0x00041030
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlatformOverrideData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformOverride.PlatformOverrideData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformOverride.PlatformOverrideData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FAC RID: 4012 RVA: 0x000087F5 File Offset: 0x000069F5
			public PlatformOverrideData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700042E RID: 1070
			// (get) Token: 0x06000FAD RID: 4013 RVA: 0x00042E6C File Offset: 0x0004106C
			// (set) Token: 0x06000FAE RID: 4014 RVA: 0x000087FE File Offset: 0x000069FE
			public unsafe RuntimePlatform platform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformOverride.PlatformOverrideData.NativeFieldInfoPtr_platform);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformOverride.PlatformOverrideData.NativeFieldInfoPtr_platform)) = value;
				}
			}

			// Token: 0x1700042F RID: 1071
			// (get) Token: 0x06000FAF RID: 4015 RVA: 0x00042E94 File Offset: 0x00041094
			// (set) Token: 0x06000FB0 RID: 4016 RVA: 0x00008819 File Offset: 0x00006A19
			public unsafe EntryOverrideType entryOverrideType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformOverride.PlatformOverrideData.NativeFieldInfoPtr_entryOverrideType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformOverride.PlatformOverrideData.NativeFieldInfoPtr_entryOverrideType)) = value;
				}
			}

			// Token: 0x17000430 RID: 1072
			// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x00042EBC File Offset: 0x000410BC
			// (set) Token: 0x06000FB2 RID: 4018 RVA: 0x00008834 File Offset: 0x00006A34
			public TableReference tableReference
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformOverride.PlatformOverrideData.NativeFieldInfoPtr_tableReference);
					return new TableReference(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TableReference>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformOverride.PlatformOverrideData.NativeFieldInfoPtr_tableReference), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TableReference>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000431 RID: 1073
			// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x00042EEC File Offset: 0x000410EC
			// (set) Token: 0x06000FB4 RID: 4020 RVA: 0x00008862 File Offset: 0x00006A62
			public TableEntryReference tableEntryReference
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformOverride.PlatformOverrideData.NativeFieldInfoPtr_tableEntryReference);
					return new TableEntryReference(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformOverride.PlatformOverrideData.NativeFieldInfoPtr_tableEntryReference), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000AC2 RID: 2754
			private static readonly IntPtr NativeFieldInfoPtr_platform;

			// Token: 0x04000AC3 RID: 2755
			private static readonly IntPtr NativeFieldInfoPtr_entryOverrideType;

			// Token: 0x04000AC4 RID: 2756
			private static readonly IntPtr NativeFieldInfoPtr_tableReference;

			// Token: 0x04000AC5 RID: 2757
			private static readonly IntPtr NativeFieldInfoPtr_tableEntryReference;

			// Token: 0x04000AC6 RID: 2758
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x04000AC7 RID: 2759
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

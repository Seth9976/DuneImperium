using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.prefabs.implementations.byflavor
{
	// Token: 0x02000114 RID: 276
	public class PrefabByFlavorLookup : PrefabLookup<PrefabFlavorsMetaData, PrefabByFlavorMetadata>
	{
		// Token: 0x06000FA6 RID: 4006 RVA: 0x00051A38 File Offset: 0x0004FC38
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabByFlavorLookup()
		{
			Il2CppClassPointerStore<PrefabByFlavorLookup>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.prefabs.implementations.byflavor", "PrefabByFlavorLookup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabByFlavorLookup>.NativeClassPtr);
			PrefabByFlavorLookup.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabByFlavorLookup>.NativeClassPtr, "entries");
			PrefabByFlavorLookup.NativeMethodInfoPtr_get_baseEntries_Protected_Virtual_get_IEnumerable_1_PrefabLookupEntry_1_PrefabFlavorsMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabByFlavorLookup>.NativeClassPtr, 100665565);
			PrefabByFlavorLookup.NativeMethodInfoPtr_SetEntries_Public_Virtual_Void_IEnumerable_1_KeyValuePair_2_PrefabByFlavorMetadata_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabByFlavorLookup>.NativeClassPtr, 100665566);
			PrefabByFlavorLookup.NativeMethodInfoPtr_get_EntryCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabByFlavorLookup>.NativeClassPtr, 100665567);
			PrefabByFlavorLookup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabByFlavorLookup>.NativeClassPtr, 100665568);
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x00051ACC File Offset: 0x0004FCCC
		public unsafe override IEnumerable<PrefabLookupEntry<PrefabFlavorsMetaData>> baseEntries
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabByFlavorLookup.NativeMethodInfoPtr_get_baseEntries_Protected_Virtual_get_IEnumerable_1_PrefabLookupEntry_1_PrefabFlavorsMetaData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PrefabLookupEntry<PrefabFlavorsMetaData>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x00051B18 File Offset: 0x0004FD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868565, XrefRangeEnd = 868648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetEntries(IEnumerable<KeyValuePair<PrefabByFlavorMetadata, string>> newEntries)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newEntries);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabByFlavorLookup.NativeMethodInfoPtr_SetEntries_Public_Virtual_Void_IEnumerable_1_KeyValuePair_2_PrefabByFlavorMetadata_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x00051B68 File Offset: 0x0004FD68
		public unsafe override int EntryCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868648, XrefRangeEnd = 868649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabByFlavorLookup.NativeMethodInfoPtr_get_EntryCount_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00051BB0 File Offset: 0x0004FDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868649, XrefRangeEnd = 868659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabByFlavorLookup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabByFlavorLookup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabByFlavorLookup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x000075AE File Offset: 0x000057AE
		public PrefabByFlavorLookup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x00051BEC File Offset: 0x0004FDEC
		// (set) Token: 0x06000FAD RID: 4013 RVA: 0x000075B7 File Offset: 0x000057B7
		public unsafe List<PrefabByFlavorLookup.Entry> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabByFlavorLookup.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PrefabByFlavorLookup.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabByFlavorLookup.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeMethodInfoPtr_get_baseEntries_Protected_Virtual_get_IEnumerable_1_PrefabLookupEntry_1_PrefabFlavorsMetaData_0;

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeMethodInfoPtr_SetEntries_Public_Virtual_Void_IEnumerable_1_KeyValuePair_2_PrefabByFlavorMetadata_String_0;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeMethodInfoPtr_get_EntryCount_Public_Virtual_get_Int32_0;

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002C1 RID: 705
		[Serializable]
		public class Entry : PrefabLookupEntry<PrefabFlavorsMetaData>
		{
			// Token: 0x060020F3 RID: 8435 RVA: 0x00094340 File Offset: 0x00092540
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<PrefabByFlavorLookup.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabByFlavorLookup>.NativeClassPtr, "Entry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabByFlavorLookup.Entry>.NativeClassPtr);
				PrefabByFlavorLookup.Entry.NativeMethodInfoPtr__ctor_Public_Void_PrefabLookupEntry_1_PrefabFlavorsMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabByFlavorLookup.Entry>.NativeClassPtr, 100665569);
				PrefabByFlavorLookup.Entry.NativeMethodInfoPtr__ctor_Public_Void_PrefabFlavorsMetaData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabByFlavorLookup.Entry>.NativeClassPtr, 100665570);
			}

			// Token: 0x060020F4 RID: 8436 RVA: 0x00094394 File Offset: 0x00092594
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868549, XrefRangeEnd = 868552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry(PrefabLookupEntry<PrefabFlavorsMetaData> other)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabByFlavorLookup.Entry>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabByFlavorLookup.Entry.NativeMethodInfoPtr__ctor_Public_Void_PrefabLookupEntry_1_PrefabFlavorsMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020F5 RID: 8437 RVA: 0x000943E0 File Offset: 0x000925E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868552, XrefRangeEnd = 868555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry(PrefabFlavorsMetaData metadata, string resourcePath)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabByFlavorLookup.Entry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(metadata));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(resourcePath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabByFlavorLookup.Entry.NativeMethodInfoPtr__ctor_Public_Void_PrefabFlavorsMetaData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020F6 RID: 8438 RVA: 0x0000E169 File Offset: 0x0000C369
			public Entry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040016E2 RID: 5858
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PrefabLookupEntry_1_PrefabFlavorsMetaData_0;

			// Token: 0x040016E3 RID: 5859
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PrefabFlavorsMetaData_String_0;
		}

		// Token: 0x020002C2 RID: 706
		[ObfuscatedName("dwd.core.prefabs.implementations.byflavor.PrefabByFlavorLookup+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060020F7 RID: 8439 RVA: 0x00094444 File Offset: 0x00092644
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PrefabByFlavorLookup.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabByFlavorLookup>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabByFlavorLookup.__c>.NativeClassPtr);
				PrefabByFlavorLookup.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabByFlavorLookup.__c>.NativeClassPtr, "<>9");
				PrefabByFlavorLookup.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabByFlavorLookup.__c>.NativeClassPtr, "<>9__3_0");
				PrefabByFlavorLookup.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabByFlavorLookup.__c>.NativeClassPtr, "<>9__3_1");
				PrefabByFlavorLookup.__c.NativeFieldInfoPtr___9__3_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabByFlavorLookup.__c>.NativeClassPtr, "<>9__3_2");
				PrefabByFlavorLookup.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabByFlavorLookup.__c>.NativeClassPtr, 100665572);
				PrefabByFlavorLookup.__c.NativeMethodInfoPtr__SetEntries_b__3_0_Internal_Int32_KeyValuePair_2_PrefabByFlavorMetadata_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabByFlavorLookup.__c>.NativeClassPtr, 100665573);
				PrefabByFlavorLookup.__c.NativeMethodInfoPtr__SetEntries_b__3_1_Internal_String_KeyValuePair_2_PrefabByFlavorMetadata_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabByFlavorLookup.__c>.NativeClassPtr, 100665574);
				PrefabByFlavorLookup.__c.NativeMethodInfoPtr__SetEntries_b__3_2_Internal_String_KeyValuePair_2_PrefabByFlavorMetadata_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabByFlavorLookup.__c>.NativeClassPtr, 100665575);
			}

			// Token: 0x060020F8 RID: 8440 RVA: 0x00094510 File Offset: 0x00092710
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabByFlavorLookup.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabByFlavorLookup.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020F9 RID: 8441 RVA: 0x0009454C File Offset: 0x0009274C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868555, XrefRangeEnd = 868557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SetEntries_b__3_0(KeyValuePair<PrefabByFlavorMetadata, string> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabByFlavorLookup.__c.NativeMethodInfoPtr__SetEntries_b__3_0_Internal_Int32_KeyValuePair_2_PrefabByFlavorMetadata_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060020FA RID: 8442 RVA: 0x000945A0 File Offset: 0x000927A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868557, XrefRangeEnd = 868558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _SetEntries_b__3_1(KeyValuePair<PrefabByFlavorMetadata, string> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabByFlavorLookup.__c.NativeMethodInfoPtr__SetEntries_b__3_1_Internal_String_KeyValuePair_2_PrefabByFlavorMetadata_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060020FB RID: 8443 RVA: 0x000945F0 File Offset: 0x000927F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868558, XrefRangeEnd = 868565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _SetEntries_b__3_2(KeyValuePair<PrefabByFlavorMetadata, string> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabByFlavorLookup.__c.NativeMethodInfoPtr__SetEntries_b__3_2_Internal_String_KeyValuePair_2_PrefabByFlavorMetadata_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060020FC RID: 8444 RVA: 0x0000E172 File Offset: 0x0000C372
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008FA RID: 2298
			// (get) Token: 0x060020FD RID: 8445 RVA: 0x00094640 File Offset: 0x00092840
			// (set) Token: 0x060020FE RID: 8446 RVA: 0x0000E17B File Offset: 0x0000C37B
			public unsafe static PrefabByFlavorLookup.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PrefabByFlavorLookup.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabByFlavorLookup.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PrefabByFlavorLookup.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008FB RID: 2299
			// (get) Token: 0x060020FF RID: 8447 RVA: 0x00094668 File Offset: 0x00092868
			// (set) Token: 0x06002100 RID: 8448 RVA: 0x0000E18D File Offset: 0x0000C38D
			public unsafe static Func<KeyValuePair<PrefabByFlavorMetadata, string>, int> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PrefabByFlavorLookup.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<PrefabByFlavorMetadata, string>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PrefabByFlavorLookup.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008FC RID: 2300
			// (get) Token: 0x06002101 RID: 8449 RVA: 0x00094690 File Offset: 0x00092890
			// (set) Token: 0x06002102 RID: 8450 RVA: 0x0000E19F File Offset: 0x0000C39F
			public unsafe static Func<KeyValuePair<PrefabByFlavorMetadata, string>, string> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PrefabByFlavorLookup.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<PrefabByFlavorMetadata, string>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PrefabByFlavorLookup.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008FD RID: 2301
			// (get) Token: 0x06002103 RID: 8451 RVA: 0x000946B8 File Offset: 0x000928B8
			// (set) Token: 0x06002104 RID: 8452 RVA: 0x0000E1B1 File Offset: 0x0000C3B1
			public unsafe static Func<KeyValuePair<PrefabByFlavorMetadata, string>, string> __9__3_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PrefabByFlavorLookup.__c.NativeFieldInfoPtr___9__3_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<PrefabByFlavorMetadata, string>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PrefabByFlavorLookup.__c.NativeFieldInfoPtr___9__3_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016E4 RID: 5860
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040016E5 RID: 5861
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040016E6 RID: 5862
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x040016E7 RID: 5863
			private static readonly IntPtr NativeFieldInfoPtr___9__3_2;

			// Token: 0x040016E8 RID: 5864
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016E9 RID: 5865
			private static readonly IntPtr NativeMethodInfoPtr__SetEntries_b__3_0_Internal_Int32_KeyValuePair_2_PrefabByFlavorMetadata_String_0;

			// Token: 0x040016EA RID: 5866
			private static readonly IntPtr NativeMethodInfoPtr__SetEntries_b__3_1_Internal_String_KeyValuePair_2_PrefabByFlavorMetadata_String_0;

			// Token: 0x040016EB RID: 5867
			private static readonly IntPtr NativeMethodInfoPtr__SetEntries_b__3_2_Internal_String_KeyValuePair_2_PrefabByFlavorMetadata_String_0;
		}
	}
}

using System;
using CanisData.generation.generators;
using CanisData.generation.templates;
using CanisData.parsers;
using CanisData.parsers.cell;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.generation.builders.archetypes;

namespace worm.canis.data.parsers
{
	// Token: 0x02000007 RID: 7
	public class ArchetypeSheetParser : SheetParser
	{
		// Token: 0x06000017 RID: 23 RVA: 0x000029A0 File Offset: 0x00000BA0
		// Note: this type is marked as 'beforefieldinit'.
		static ArchetypeSheetParser()
		{
			Il2CppClassPointerStore<ArchetypeSheetParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-data.dll", "worm.canis.data.parsers", "ArchetypeSheetParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeSheetParser>.NativeClassPtr);
			ArchetypeSheetParser.NativeFieldInfoPtr_cellParsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeSheetParser>.NativeClassPtr, "cellParsers");
			ArchetypeSheetParser.NativeFieldInfoPtr_setName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeSheetParser>.NativeClassPtr, "setName");
			ArchetypeSheetParser.NativeFieldInfoPtr_directiveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeSheetParser>.NativeClassPtr, "directiveName");
			ArchetypeSheetParser.NativeMethodInfoPtr_get_CellParsers_Public_Virtual_get_IEnumerable_1_ICellParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeSheetParser>.NativeClassPtr, 100663305);
			ArchetypeSheetParser.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeSheetParser>.NativeClassPtr, 100663306);
			ArchetypeSheetParser.NativeMethodInfoPtr_MakeGenerator_Public_Virtual_ScriptGenerator_String_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeSheetParser>.NativeClassPtr, 100663307);
			ArchetypeSheetParser.NativeMethodInfoPtr_SpaceSetup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeSheetParser>.NativeClassPtr, 100663308);
			ArchetypeSheetParser.NativeMethodInfoPtr_ImperiumSetup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeSheetParser>.NativeClassPtr, 100663309);
			ArchetypeSheetParser.NativeMethodInfoPtr_IntrigueSetup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeSheetParser>.NativeClassPtr, 100663310);
			ArchetypeSheetParser.NativeMethodInfoPtr_ConflictSetup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeSheetParser>.NativeClassPtr, 100663311);
			ArchetypeSheetParser.NativeMethodInfoPtr_LeaderSetup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeSheetParser>.NativeClassPtr, 100663312);
			ArchetypeSheetParser.NativeMethodInfoPtr_HagalSetup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeSheetParser>.NativeClassPtr, 100663313);
			ArchetypeSheetParser.NativeMethodInfoPtr_TechTileSetup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeSheetParser>.NativeClassPtr, 100663314);
			ArchetypeSheetParser.NativeMethodInfoPtr_TleilaxuSetup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeSheetParser>.NativeClassPtr, 100663315);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002AE8 File Offset: 0x00000CE8
		public unsafe override IEnumerable<ICellParser> CellParsers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeSheetParser.NativeMethodInfoPtr_get_CellParsers_Public_Virtual_get_IEnumerable_1_ICellParser_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ICellParser>>(intPtr3) : null;
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002B34 File Offset: 0x00000D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241706, XrefRangeEnd = 1241709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypeSheetParser(string outputDirectory, string setName, string directiveName = "")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeSheetParser>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(outputDirectory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(setName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(directiveName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeSheetParser.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002BA4 File Offset: 0x00000DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241709, XrefRangeEnd = 1241806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ScriptGenerator MakeGenerator(string tabName, Dictionary<string, string> rowData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tabName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rowData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeSheetParser.NativeMethodInfoPtr_MakeGenerator_Public_Virtual_ScriptGenerator_String_Dictionary_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptGenerator>(intPtr3) : null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002C14 File Offset: 0x00000E14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1242219, RefRangeEnd = 1242220, XrefRangeStart = 1241806, XrefRangeEnd = 1242219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpaceSetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeSheetParser.NativeMethodInfoPtr_SpaceSetup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002C48 File Offset: 0x00000E48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1242700, RefRangeEnd = 1242701, XrefRangeStart = 1242220, XrefRangeEnd = 1242700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImperiumSetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeSheetParser.NativeMethodInfoPtr_ImperiumSetup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002C7C File Offset: 0x00000E7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1242984, RefRangeEnd = 1242985, XrefRangeStart = 1242701, XrefRangeEnd = 1242984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IntrigueSetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeSheetParser.NativeMethodInfoPtr_IntrigueSetup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002CB0 File Offset: 0x00000EB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1243158, RefRangeEnd = 1243159, XrefRangeStart = 1242985, XrefRangeEnd = 1243158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConflictSetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeSheetParser.NativeMethodInfoPtr_ConflictSetup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002CE4 File Offset: 0x00000EE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1243298, RefRangeEnd = 1243299, XrefRangeStart = 1243159, XrefRangeEnd = 1243298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LeaderSetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeSheetParser.NativeMethodInfoPtr_LeaderSetup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002D18 File Offset: 0x00000F18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1243662, RefRangeEnd = 1243663, XrefRangeStart = 1243299, XrefRangeEnd = 1243662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HagalSetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeSheetParser.NativeMethodInfoPtr_HagalSetup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002D4C File Offset: 0x00000F4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1243875, RefRangeEnd = 1243876, XrefRangeStart = 1243663, XrefRangeEnd = 1243875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TechTileSetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeSheetParser.NativeMethodInfoPtr_TechTileSetup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002D80 File Offset: 0x00000F80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1244324, RefRangeEnd = 1244325, XrefRangeStart = 1243876, XrefRangeEnd = 1244324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TleilaxuSetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeSheetParser.NativeMethodInfoPtr_TleilaxuSetup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000020F0 File Offset: 0x000002F0
		public ArchetypeSheetParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002DB4 File Offset: 0x00000FB4
		// (set) Token: 0x06000025 RID: 37 RVA: 0x000020F9 File Offset: 0x000002F9
		public unsafe List<ICellParser> cellParsers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeSheetParser.NativeFieldInfoPtr_cellParsers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ICellParser>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeSheetParser.NativeFieldInfoPtr_cellParsers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002DE4 File Offset: 0x00000FE4
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002118 File Offset: 0x00000318
		public unsafe string setName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeSheetParser.NativeFieldInfoPtr_setName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeSheetParser.NativeFieldInfoPtr_setName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002E0C File Offset: 0x0000100C
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002137 File Offset: 0x00000337
		public unsafe string directiveName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeSheetParser.NativeFieldInfoPtr_directiveName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeSheetParser.NativeFieldInfoPtr_directiveName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_cellParsers;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_setName;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_directiveName;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_get_CellParsers_Public_Virtual_get_IEnumerable_1_ICellParser_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_MakeGenerator_Public_Virtual_ScriptGenerator_String_Dictionary_2_String_String_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_SpaceSetup_Private_Void_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_ImperiumSetup_Private_Void_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_IntrigueSetup_Private_Void_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_ConflictSetup_Private_Void_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_LeaderSetup_Private_Void_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_HagalSetup_Private_Void_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_TechTileSetup_Private_Void_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_TleilaxuSetup_Private_Void_0;

		// Token: 0x0200000F RID: 15
		[ObfuscatedName("worm.canis.data.parsers.ArchetypeSheetParser+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06000099 RID: 153 RVA: 0x0000455C File Offset: 0x0000275C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ArchetypeSheetParser.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArchetypeSheetParser>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeSheetParser.__c>.NativeClassPtr);
				ArchetypeSheetParser.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeSheetParser.__c>.NativeClassPtr, "<>9");
				ArchetypeSheetParser.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeSheetParser.__c>.NativeClassPtr, "<>9__6_1");
				ArchetypeSheetParser.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeSheetParser.__c>.NativeClassPtr, 100663317);
				ArchetypeSheetParser.__c.NativeMethodInfoPtr__MakeGenerator_b__6_1_Internal_ITransformsBuilder_1_ArchetypeScriptBuilder_ArchetypeScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeSheetParser.__c>.NativeClassPtr, 100663318);
			}

			// Token: 0x0600009A RID: 154 RVA: 0x000045D8 File Offset: 0x000027D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeSheetParser.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeSheetParser.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600009B RID: 155 RVA: 0x00004614 File Offset: 0x00002814
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241699, XrefRangeEnd = 1241703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ITransformsBuilder<ArchetypeScriptBuilder> _MakeGenerator_b__6_1(ArchetypeScriptBuilder builder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeSheetParser.__c.NativeMethodInfoPtr__MakeGenerator_b__6_1_Internal_ITransformsBuilder_1_ArchetypeScriptBuilder_ArchetypeScriptBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITransformsBuilder<ArchetypeScriptBuilder>>(intPtr3) : null;
				}
			}

			// Token: 0x0600009C RID: 156 RVA: 0x00002457 File Offset: 0x00000657
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x0600009D RID: 157 RVA: 0x00004664 File Offset: 0x00002864
			// (set) Token: 0x0600009E RID: 158 RVA: 0x00002460 File Offset: 0x00000660
			public unsafe static ArchetypeSheetParser.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ArchetypeSheetParser.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeSheetParser.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ArchetypeSheetParser.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x0600009F RID: 159 RVA: 0x0000468C File Offset: 0x0000288C
			// (set) Token: 0x060000A0 RID: 160 RVA: 0x00002472 File Offset: 0x00000672
			public unsafe static MakeTemplateInstance<ArchetypeScriptBuilder> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ArchetypeSheetParser.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MakeTemplateInstance<ArchetypeScriptBuilder>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ArchetypeSheetParser.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400005F RID: 95
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000060 RID: 96
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x04000061 RID: 97
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000062 RID: 98
			private static readonly IntPtr NativeMethodInfoPtr__MakeGenerator_b__6_1_Internal_ITransformsBuilder_1_ArchetypeScriptBuilder_ArchetypeScriptBuilder_0;
		}

		// Token: 0x02000010 RID: 16
		[ObfuscatedName("worm.canis.data.parsers.ArchetypeSheetParser+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x060000A1 RID: 161 RVA: 0x000046B4 File Offset: 0x000028B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<ArchetypeSheetParser.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArchetypeSheetParser>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeSheetParser.__c__DisplayClass6_0>.NativeClassPtr);
				ArchetypeSheetParser.__c__DisplayClass6_0.NativeFieldInfoPtr_nameSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeSheetParser.__c__DisplayClass6_0>.NativeClassPtr, "nameSpace");
				ArchetypeSheetParser.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeSheetParser.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				ArchetypeSheetParser.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeSheetParser.__c__DisplayClass6_0>.NativeClassPtr, 100663319);
				ArchetypeSheetParser.__c__DisplayClass6_0.NativeMethodInfoPtr_Method_Internal_ArchetypeScriptBuilder_ArchetypeScriptBuilder_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeSheetParser.__c__DisplayClass6_0>.NativeClassPtr, 100663320);
			}

			// Token: 0x060000A2 RID: 162 RVA: 0x00004730 File Offset: 0x00002930
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeSheetParser.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeSheetParser.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000A3 RID: 163 RVA: 0x0000476C File Offset: 0x0000296C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241703, XrefRangeEnd = 1241706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeScriptBuilder Method_Internal_ArchetypeScriptBuilder_ArchetypeScriptBuilder_PDM_0(ArchetypeScriptBuilder builder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeSheetParser.__c__DisplayClass6_0.NativeMethodInfoPtr_Method_Internal_ArchetypeScriptBuilder_ArchetypeScriptBuilder_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeScriptBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x060000A4 RID: 164 RVA: 0x00002484 File Offset: 0x00000684
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x060000A5 RID: 165 RVA: 0x000047BC File Offset: 0x000029BC
			// (set) Token: 0x060000A6 RID: 166 RVA: 0x0000248D File Offset: 0x0000068D
			public unsafe string nameSpace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeSheetParser.__c__DisplayClass6_0.NativeFieldInfoPtr_nameSpace);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeSheetParser.__c__DisplayClass6_0.NativeFieldInfoPtr_nameSpace), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x060000A7 RID: 167 RVA: 0x000047E4 File Offset: 0x000029E4
			// (set) Token: 0x060000A8 RID: 168 RVA: 0x000024AC File Offset: 0x000006AC
			public unsafe ArchetypeSheetParser __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeSheetParser.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeSheetParser>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeSheetParser.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000063 RID: 99
			private static readonly IntPtr NativeFieldInfoPtr_nameSpace;

			// Token: 0x04000064 RID: 100
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000065 RID: 101
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000066 RID: 102
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_ArchetypeScriptBuilder_ArchetypeScriptBuilder_PDM_0;
		}
	}
}

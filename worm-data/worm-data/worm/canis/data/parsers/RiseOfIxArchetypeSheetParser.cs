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
	// Token: 0x02000008 RID: 8
	public class RiseOfIxArchetypeSheetParser : SheetParser
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00002E34 File Offset: 0x00001034
		// Note: this type is marked as 'beforefieldinit'.
		static RiseOfIxArchetypeSheetParser()
		{
			Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-data.dll", "worm.canis.data.parsers", "RiseOfIxArchetypeSheetParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser>.NativeClassPtr);
			RiseOfIxArchetypeSheetParser.NativeFieldInfoPtr_cellParsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser>.NativeClassPtr, "cellParsers");
			RiseOfIxArchetypeSheetParser.NativeMethodInfoPtr_get_CellParsers_Public_Virtual_get_IEnumerable_1_ICellParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser>.NativeClassPtr, 100663321);
			RiseOfIxArchetypeSheetParser.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser>.NativeClassPtr, 100663322);
			RiseOfIxArchetypeSheetParser.NativeMethodInfoPtr_MakeGenerator_Public_Virtual_ScriptGenerator_String_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser>.NativeClassPtr, 100663323);
			RiseOfIxArchetypeSheetParser.NativeMethodInfoPtr_SpaceSetup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser>.NativeClassPtr, 100663324);
			RiseOfIxArchetypeSheetParser.NativeMethodInfoPtr_ImperiumSetup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser>.NativeClassPtr, 100663325);
			RiseOfIxArchetypeSheetParser.NativeMethodInfoPtr_IntrigueSetup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser>.NativeClassPtr, 100663326);
			RiseOfIxArchetypeSheetParser.NativeMethodInfoPtr_ConflictSetup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser>.NativeClassPtr, 100663327);
			RiseOfIxArchetypeSheetParser.NativeMethodInfoPtr_LeaderSetup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser>.NativeClassPtr, 100663328);
			RiseOfIxArchetypeSheetParser.NativeMethodInfoPtr_HagalSetup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser>.NativeClassPtr, 100663329);
			RiseOfIxArchetypeSheetParser.NativeMethodInfoPtr_TechTileSetup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser>.NativeClassPtr, 100663330);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002F40 File Offset: 0x00001140
		public unsafe override IEnumerable<ICellParser> CellParsers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RiseOfIxArchetypeSheetParser.NativeMethodInfoPtr_get_CellParsers_Public_Virtual_get_IEnumerable_1_ICellParser_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ICellParser>>(intPtr3) : null;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002F8C File Offset: 0x0000118C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244330, XrefRangeEnd = 1244331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RiseOfIxArchetypeSheetParser(string outputDirectory)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(outputDirectory);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RiseOfIxArchetypeSheetParser.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002FD8 File Offset: 0x000011D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244331, XrefRangeEnd = 1244422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RiseOfIxArchetypeSheetParser.NativeMethodInfoPtr_MakeGenerator_Public_Virtual_ScriptGenerator_String_Dictionary_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptGenerator>(intPtr3) : null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003048 File Offset: 0x00001248
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1244819, RefRangeEnd = 1244820, XrefRangeStart = 1244422, XrefRangeEnd = 1244819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpaceSetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RiseOfIxArchetypeSheetParser.NativeMethodInfoPtr_SpaceSetup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000307C File Offset: 0x0000127C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1245251, RefRangeEnd = 1245252, XrefRangeStart = 1244820, XrefRangeEnd = 1245251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImperiumSetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RiseOfIxArchetypeSheetParser.NativeMethodInfoPtr_ImperiumSetup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000030B0 File Offset: 0x000012B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1245496, RefRangeEnd = 1245497, XrefRangeStart = 1245252, XrefRangeEnd = 1245496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IntrigueSetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RiseOfIxArchetypeSheetParser.NativeMethodInfoPtr_IntrigueSetup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000030E4 File Offset: 0x000012E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1245655, RefRangeEnd = 1245656, XrefRangeStart = 1245497, XrefRangeEnd = 1245655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConflictSetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RiseOfIxArchetypeSheetParser.NativeMethodInfoPtr_ConflictSetup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003118 File Offset: 0x00001318
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1245768, RefRangeEnd = 1245769, XrefRangeStart = 1245656, XrefRangeEnd = 1245768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LeaderSetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RiseOfIxArchetypeSheetParser.NativeMethodInfoPtr_LeaderSetup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000314C File Offset: 0x0000134C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1246043, RefRangeEnd = 1246044, XrefRangeStart = 1245769, XrefRangeEnd = 1246043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HagalSetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RiseOfIxArchetypeSheetParser.NativeMethodInfoPtr_HagalSetup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003180 File Offset: 0x00001380
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1246231, RefRangeEnd = 1246232, XrefRangeStart = 1246044, XrefRangeEnd = 1246231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TechTileSetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RiseOfIxArchetypeSheetParser.NativeMethodInfoPtr_TechTileSetup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002156 File Offset: 0x00000356
		public RiseOfIxArchetypeSheetParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000031B4 File Offset: 0x000013B4
		// (set) Token: 0x06000037 RID: 55 RVA: 0x0000215F File Offset: 0x0000035F
		public unsafe List<ICellParser> cellParsers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RiseOfIxArchetypeSheetParser.NativeFieldInfoPtr_cellParsers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ICellParser>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RiseOfIxArchetypeSheetParser.NativeFieldInfoPtr_cellParsers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_cellParsers;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_get_CellParsers_Public_Virtual_get_IEnumerable_1_ICellParser_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_MakeGenerator_Public_Virtual_ScriptGenerator_String_Dictionary_2_String_String_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_SpaceSetup_Private_Void_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_ImperiumSetup_Private_Void_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_IntrigueSetup_Private_Void_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_ConflictSetup_Private_Void_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_LeaderSetup_Private_Void_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_HagalSetup_Private_Void_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_TechTileSetup_Private_Void_0;

		// Token: 0x02000011 RID: 17
		[ObfuscatedName("worm.canis.data.parsers.RiseOfIxArchetypeSheetParser+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x060000A9 RID: 169 RVA: 0x00004814 File Offset: 0x00002A14
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser.__c>.NativeClassPtr);
				RiseOfIxArchetypeSheetParser.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser.__c>.NativeClassPtr, "<>9");
				RiseOfIxArchetypeSheetParser.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser.__c>.NativeClassPtr, "<>9__4_1");
				RiseOfIxArchetypeSheetParser.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser.__c>.NativeClassPtr, 100663332);
				RiseOfIxArchetypeSheetParser.__c.NativeMethodInfoPtr__MakeGenerator_b__4_1_Internal_ITransformsBuilder_1_ArchetypeScriptBuilder_ArchetypeScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser.__c>.NativeClassPtr, 100663333);
			}

			// Token: 0x060000AA RID: 170 RVA: 0x00004890 File Offset: 0x00002A90
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RiseOfIxArchetypeSheetParser.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000AB RID: 171 RVA: 0x000048CC File Offset: 0x00002ACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244325, XrefRangeEnd = 1244329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ITransformsBuilder<ArchetypeScriptBuilder> _MakeGenerator_b__4_1(ArchetypeScriptBuilder builder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RiseOfIxArchetypeSheetParser.__c.NativeMethodInfoPtr__MakeGenerator_b__4_1_Internal_ITransformsBuilder_1_ArchetypeScriptBuilder_ArchetypeScriptBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITransformsBuilder<ArchetypeScriptBuilder>>(intPtr3) : null;
				}
			}

			// Token: 0x060000AC RID: 172 RVA: 0x000024CB File Offset: 0x000006CB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x060000AD RID: 173 RVA: 0x0000491C File Offset: 0x00002B1C
			// (set) Token: 0x060000AE RID: 174 RVA: 0x000024D4 File Offset: 0x000006D4
			public unsafe static RiseOfIxArchetypeSheetParser.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RiseOfIxArchetypeSheetParser.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RiseOfIxArchetypeSheetParser.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RiseOfIxArchetypeSheetParser.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x060000AF RID: 175 RVA: 0x00004944 File Offset: 0x00002B44
			// (set) Token: 0x060000B0 RID: 176 RVA: 0x000024E6 File Offset: 0x000006E6
			public unsafe static MakeTemplateInstance<ArchetypeScriptBuilder> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RiseOfIxArchetypeSheetParser.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MakeTemplateInstance<ArchetypeScriptBuilder>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RiseOfIxArchetypeSheetParser.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000067 RID: 103
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000068 RID: 104
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x04000069 RID: 105
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400006A RID: 106
			private static readonly IntPtr NativeMethodInfoPtr__MakeGenerator_b__4_1_Internal_ITransformsBuilder_1_ArchetypeScriptBuilder_ArchetypeScriptBuilder_0;
		}

		// Token: 0x02000012 RID: 18
		[ObfuscatedName("worm.canis.data.parsers.RiseOfIxArchetypeSheetParser+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x060000B1 RID: 177 RVA: 0x0000496C File Offset: 0x00002B6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser.__c__DisplayClass4_0>.NativeClassPtr);
				RiseOfIxArchetypeSheetParser.__c__DisplayClass4_0.NativeFieldInfoPtr_nameSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser.__c__DisplayClass4_0>.NativeClassPtr, "nameSpace");
				RiseOfIxArchetypeSheetParser.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser.__c__DisplayClass4_0>.NativeClassPtr, 100663334);
				RiseOfIxArchetypeSheetParser.__c__DisplayClass4_0.NativeMethodInfoPtr_Method_Internal_ArchetypeScriptBuilder_ArchetypeScriptBuilder_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser.__c__DisplayClass4_0>.NativeClassPtr, 100663335);
			}

			// Token: 0x060000B2 RID: 178 RVA: 0x000049D4 File Offset: 0x00002BD4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RiseOfIxArchetypeSheetParser.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RiseOfIxArchetypeSheetParser.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000B3 RID: 179 RVA: 0x00004A10 File Offset: 0x00002C10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244329, XrefRangeEnd = 1244330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeScriptBuilder Method_Internal_ArchetypeScriptBuilder_ArchetypeScriptBuilder_PDM_0(ArchetypeScriptBuilder builder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RiseOfIxArchetypeSheetParser.__c__DisplayClass4_0.NativeMethodInfoPtr_Method_Internal_ArchetypeScriptBuilder_ArchetypeScriptBuilder_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeScriptBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x060000B4 RID: 180 RVA: 0x000024F8 File Offset: 0x000006F8
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x060000B5 RID: 181 RVA: 0x00004A60 File Offset: 0x00002C60
			// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002501 File Offset: 0x00000701
			public unsafe string nameSpace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RiseOfIxArchetypeSheetParser.__c__DisplayClass4_0.NativeFieldInfoPtr_nameSpace);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RiseOfIxArchetypeSheetParser.__c__DisplayClass4_0.NativeFieldInfoPtr_nameSpace), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400006B RID: 107
			private static readonly IntPtr NativeFieldInfoPtr_nameSpace;

			// Token: 0x0400006C RID: 108
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400006D RID: 109
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_ArchetypeScriptBuilder_ArchetypeScriptBuilder_PDM_0;
		}
	}
}

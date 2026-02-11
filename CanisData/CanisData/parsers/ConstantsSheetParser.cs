using System;
using CanisData.generation.generators;
using CanisData.parsers.cell;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace CanisData.parsers
{
	// Token: 0x0200000A RID: 10
	public class ConstantsSheetParser : SheetParser
	{
		// Token: 0x0600002B RID: 43 RVA: 0x0000401C File Offset: 0x0000221C
		// Note: this type is marked as 'beforefieldinit'.
		static ConstantsSheetParser()
		{
			Il2CppClassPointerStore<ConstantsSheetParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.parsers", "ConstantsSheetParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstantsSheetParser>.NativeClassPtr);
			ConstantsSheetParser.NativeFieldInfoPtr_projectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsSheetParser>.NativeClassPtr, "projectName");
			ConstantsSheetParser.NativeFieldInfoPtr_constantsGenerators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsSheetParser>.NativeClassPtr, "constantsGenerators");
			ConstantsSheetParser.NativeFieldInfoPtr__cellParsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsSheetParser>.NativeClassPtr, "_cellParsers");
			ConstantsSheetParser.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsSheetParser>.NativeClassPtr, 100663314);
			ConstantsSheetParser.NativeMethodInfoPtr_get_CellParsers_Public_Virtual_get_IEnumerable_1_ICellParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsSheetParser>.NativeClassPtr, 100663315);
			ConstantsSheetParser.NativeMethodInfoPtr_SanitizeName_Protected_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsSheetParser>.NativeClassPtr, 100663316);
			ConstantsSheetParser.NativeMethodInfoPtr_MakeGenerator_Public_Virtual_ScriptGenerator_String_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsSheetParser>.NativeClassPtr, 100663317);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000040D8 File Offset: 0x000022D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221995, XrefRangeEnd = 1222011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstantsSheetParser(string outputDirectory, string projectName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstantsSheetParser>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(outputDirectory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(projectName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsSheetParser.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00004138 File Offset: 0x00002338
		public unsafe override IEnumerable<ICellParser> CellParsers
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstantsSheetParser.NativeMethodInfoPtr_get_CellParsers_Public_Virtual_get_IEnumerable_1_ICellParser_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ICellParser>>(intPtr3) : null;
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004184 File Offset: 0x00002384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222011, XrefRangeEnd = 1222045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string SanitizeName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstantsSheetParser.NativeMethodInfoPtr_SanitizeName_Protected_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000041D8 File Offset: 0x000023D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222045, XrefRangeEnd = 1222089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstantsSheetParser.NativeMethodInfoPtr_MakeGenerator_Public_Virtual_ScriptGenerator_String_Dictionary_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptGenerator>(intPtr3) : null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000021CD File Offset: 0x000003CD
		public ConstantsSheetParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00004248 File Offset: 0x00002448
		// (set) Token: 0x06000032 RID: 50 RVA: 0x000021D6 File Offset: 0x000003D6
		public unsafe string projectName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsSheetParser.NativeFieldInfoPtr_projectName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsSheetParser.NativeFieldInfoPtr_projectName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00004270 File Offset: 0x00002470
		// (set) Token: 0x06000034 RID: 52 RVA: 0x000021F5 File Offset: 0x000003F5
		public unsafe Dictionary<string, ConstantsScriptGenerator> constantsGenerators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsSheetParser.NativeFieldInfoPtr_constantsGenerators);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ConstantsScriptGenerator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsSheetParser.NativeFieldInfoPtr_constantsGenerators), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000042A0 File Offset: 0x000024A0
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00002214 File Offset: 0x00000414
		public unsafe List<ICellParser> _cellParsers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsSheetParser.NativeFieldInfoPtr__cellParsers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ICellParser>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsSheetParser.NativeFieldInfoPtr__cellParsers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_projectName;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_constantsGenerators;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr__cellParsers;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_get_CellParsers_Public_Virtual_get_IEnumerable_1_ICellParser_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_SanitizeName_Protected_Virtual_String_String_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_MakeGenerator_Public_Virtual_ScriptGenerator_String_Dictionary_2_String_String_0;

		// Token: 0x02000031 RID: 49
		[ObfuscatedName("CanisData.parsers.ConstantsSheetParser+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x060001F4 RID: 500 RVA: 0x0000A700 File Offset: 0x00008900
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ConstantsSheetParser.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstantsSheetParser>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstantsSheetParser.__c>.NativeClassPtr);
				ConstantsSheetParser.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsSheetParser.__c>.NativeClassPtr, "<>9");
				ConstantsSheetParser.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsSheetParser.__c>.NativeClassPtr, "<>9__6_0");
				ConstantsSheetParser.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsSheetParser.__c>.NativeClassPtr, 100663319);
				ConstantsSheetParser.__c.NativeMethodInfoPtr__SanitizeName_b__6_0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsSheetParser.__c>.NativeClassPtr, 100663320);
			}

			// Token: 0x060001F5 RID: 501 RVA: 0x0000A77C File Offset: 0x0000897C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstantsSheetParser.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsSheetParser.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001F6 RID: 502 RVA: 0x0000A7B8 File Offset: 0x000089B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221987, XrefRangeEnd = 1221995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _SanitizeName_b__6_0(string part)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(part);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsSheetParser.__c.NativeMethodInfoPtr__SanitizeName_b__6_0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060001F7 RID: 503 RVA: 0x0000301D File Offset: 0x0000121D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000A800 File Offset: 0x00008A00
			// (set) Token: 0x060001F9 RID: 505 RVA: 0x00003026 File Offset: 0x00001226
			public unsafe static ConstantsSheetParser.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConstantsSheetParser.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstantsSheetParser.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConstantsSheetParser.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x060001FA RID: 506 RVA: 0x0000A828 File Offset: 0x00008A28
			// (set) Token: 0x060001FB RID: 507 RVA: 0x00003038 File Offset: 0x00001238
			public unsafe static Func<string, string> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConstantsSheetParser.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConstantsSheetParser.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400012C RID: 300
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400012D RID: 301
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400012E RID: 302
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400012F RID: 303
			private static readonly IntPtr NativeMethodInfoPtr__SanitizeName_b__6_0_Internal_String_String_0;
		}
	}
}

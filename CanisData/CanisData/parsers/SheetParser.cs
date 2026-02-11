using System;
using System.Runtime.InteropServices;
using CanisData.generation.builders;
using CanisData.generation.generators;
using CanisData.parsers.cell;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Text;
using Il2CppSystem.Threading.Tasks;

namespace CanisData.parsers
{
	// Token: 0x0200000D RID: 13
	public class SheetParser : Object
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00004560 File Offset: 0x00002760
		// Note: this type is marked as 'beforefieldinit'.
		static SheetParser()
		{
			Il2CppClassPointerStore<SheetParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.parsers", "SheetParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SheetParser>.NativeClassPtr);
			SheetParser.NativeFieldInfoPtr_credential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetParser>.NativeClassPtr, "credential");
			SheetParser.NativeFieldInfoPtr_OutputDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetParser>.NativeClassPtr, "OutputDirectory");
			SheetParser.NativeMethodInfoPtr_get_CellParsers_Public_Abstract_Virtual_New_get_IEnumerable_1_ICellParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetParser>.NativeClassPtr, 100663325);
			SheetParser.NativeMethodInfoPtr_MakeGenerator_Public_Abstract_Virtual_New_ScriptGenerator_String_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetParser>.NativeClassPtr, 100663326);
			SheetParser.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetParser>.NativeClassPtr, 100663327);
			SheetParser.NativeMethodInfoPtr_GetExcelColumnName_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetParser>.NativeClassPtr, 100663328);
			SheetParser.NativeMethodInfoPtr_SanitizeName_Protected_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetParser>.NativeClassPtr, 100663329);
			SheetParser.NativeMethodInfoPtr_ParseSheet_Public_Task_1_IEnumerable_1_ParserArtifact_StringBuilder_String_ErrorTolerance_Boolean_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetParser>.NativeClassPtr, 100663330);
			SheetParser.NativeMethodInfoPtr_ParseSheetTab_Private_IEnumerable_1_ParserArtifact_StringBuilder_String_IList_1_IList_1_Object_ErrorTolerance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetParser>.NativeClassPtr, 100663331);
			SheetParser.NativeMethodInfoPtr_MakeHeaderMap_Private_Dictionary_2_String_Int32_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetParser>.NativeClassPtr, 100663332);
			SheetParser.NativeMethodInfoPtr_ParseRow_Private_ScriptBuilder_StringBuilder_ScriptGenerator_Dictionary_2_String_String_ErrorTolerance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetParser>.NativeClassPtr, 100663333);
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000042 RID: 66 RVA: 0x0000466C File Offset: 0x0000286C
		public unsafe virtual IEnumerable<ICellParser> CellParsers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetParser.NativeMethodInfoPtr_get_CellParsers_Public_Abstract_Virtual_New_get_IEnumerable_1_ICellParser_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ICellParser>>(intPtr3) : null;
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000046B8 File Offset: 0x000028B8
		[CallerCount(0)]
		public unsafe virtual ScriptGenerator MakeGenerator(string tabName, Dictionary<string, string> rowData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetParser.NativeMethodInfoPtr_MakeGenerator_Public_Abstract_Virtual_New_ScriptGenerator_String_Dictionary_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptGenerator>(intPtr3) : null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00004728 File Offset: 0x00002928
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1222341, RefRangeEnd = 1222345, XrefRangeStart = 1222316, XrefRangeEnd = 1222341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SheetParser(string outputDirectory)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SheetParser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(outputDirectory);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SheetParser.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004774 File Offset: 0x00002974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222345, XrefRangeEnd = 1222356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetExcelColumnName(int columnNumber)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref columnNumber;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SheetParser.NativeMethodInfoPtr_GetExcelColumnName_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000047B8 File Offset: 0x000029B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222356, XrefRangeEnd = 1222370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string SanitizeName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SheetParser.NativeMethodInfoPtr_SanitizeName_Protected_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000480C File Offset: 0x00002A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222370, XrefRangeEnd = 1222387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<IEnumerable<ParserArtifact>> ParseSheet(StringBuilder processOutput, string spreadsheetID, ErrorTolerance errorTolerance = ErrorTolerance.ErrorFailsBuild, bool includeTest = false, [Optional] Il2CppStringArray ignoredTabs)
		{
			if (ignoredTabs == null)
			{
				ignoredTabs = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(processOutput);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errorTolerance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeTest;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ignoredTabs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SheetParser.NativeMethodInfoPtr_ParseSheet_Public_Task_1_IEnumerable_1_ParserArtifact_StringBuilder_String_ErrorTolerance_Boolean_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<IEnumerable<ParserArtifact>>>(intPtr3) : null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000048AC File Offset: 0x00002AAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1222452, RefRangeEnd = 1222453, XrefRangeStart = 1222387, XrefRangeEnd = 1222452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ParserArtifact> ParseSheetTab(StringBuilder processOutput, string tabName, IList<IList<Object>> tabData, ErrorTolerance errorTolerance = ErrorTolerance.ErrorFailsBuild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(processOutput);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tabName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tabData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errorTolerance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SheetParser.NativeMethodInfoPtr_ParseSheetTab_Private_IEnumerable_1_ParserArtifact_StringBuilder_String_IList_1_IList_1_Object_ErrorTolerance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ParserArtifact>>(intPtr3) : null;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00004930 File Offset: 0x00002B30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1222480, RefRangeEnd = 1222481, XrefRangeStart = 1222453, XrefRangeEnd = 1222480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<string, int> MakeHeaderMap(IEnumerable<Object> headerRow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(headerRow);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SheetParser.NativeMethodInfoPtr_MakeHeaderMap_Private_Dictionary_2_String_Int32_IEnumerable_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr3) : null;
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004980 File Offset: 0x00002B80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1222512, RefRangeEnd = 1222513, XrefRangeStart = 1222481, XrefRangeEnd = 1222512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptBuilder ParseRow(StringBuilder processOutput, ScriptGenerator generator, Dictionary<string, string> rowData, ErrorTolerance errorTolerance = ErrorTolerance.ErrorFailsBuild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(processOutput);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generator);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rowData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errorTolerance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SheetParser.NativeMethodInfoPtr_ParseRow_Private_ScriptBuilder_StringBuilder_ScriptGenerator_Dictionary_2_String_String_ErrorTolerance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptBuilder>(intPtr3) : null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000227A File Offset: 0x0000047A
		public Task<IEnumerable<ParserArtifact>> ParseSheet(StringBuilder processOutput, string spreadsheetID, [Optional] ErrorTolerance errorTolerance, [Optional] bool includeTest, params string[] ignoredTabs)
		{
			return this.ParseSheet(processOutput, spreadsheetID, errorTolerance, includeTest, new Il2CppStringArray(ignoredTabs));
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000228E File Offset: 0x0000048E
		public SheetParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00004A04 File Offset: 0x00002C04
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00002297 File Offset: 0x00000497
		public unsafe ServiceAccountCredential credential
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser.NativeFieldInfoPtr_credential);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServiceAccountCredential>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser.NativeFieldInfoPtr_credential), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00004A34 File Offset: 0x00002C34
		// (set) Token: 0x06000050 RID: 80 RVA: 0x000022B6 File Offset: 0x000004B6
		public unsafe string OutputDirectory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser.NativeFieldInfoPtr_OutputDirectory);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser.NativeFieldInfoPtr_OutputDirectory), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_credential;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_OutputDirectory;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_get_CellParsers_Public_Abstract_Virtual_New_get_IEnumerable_1_ICellParser_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_MakeGenerator_Public_Abstract_Virtual_New_ScriptGenerator_String_Dictionary_2_String_String_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_GetExcelColumnName_Private_String_Int32_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_SanitizeName_Protected_Virtual_New_String_String_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_ParseSheet_Public_Task_1_IEnumerable_1_ParserArtifact_StringBuilder_String_ErrorTolerance_Boolean_Il2CppStringArray_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_ParseSheetTab_Private_IEnumerable_1_ParserArtifact_StringBuilder_String_IList_1_IList_1_Object_ErrorTolerance_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_MakeHeaderMap_Private_Dictionary_2_String_Int32_IEnumerable_1_Object_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_ParseRow_Private_ScriptBuilder_StringBuilder_ScriptGenerator_Dictionary_2_String_String_ErrorTolerance_0;

		// Token: 0x02000032 RID: 50
		[ObfuscatedName("CanisData.parsers.SheetParser+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060001FC RID: 508 RVA: 0x0000A850 File Offset: 0x00008A50
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SheetParser.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SheetParser>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SheetParser.__c>.NativeClassPtr);
				SheetParser.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetParser.__c>.NativeClassPtr, "<>9");
				SheetParser.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetParser.__c>.NativeClassPtr, "<>9__9_0");
				SheetParser.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetParser.__c>.NativeClassPtr, 100663335);
				SheetParser.__c.NativeMethodInfoPtr__ParseSheetTab_b__9_0_Internal_String_KeyValuePair_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetParser.__c>.NativeClassPtr, 100663336);
			}

			// Token: 0x060001FD RID: 509 RVA: 0x0000A8CC File Offset: 0x00008ACC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SheetParser.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SheetParser.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001FE RID: 510 RVA: 0x0000A908 File Offset: 0x00008B08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222126, XrefRangeEnd = 1222127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ParseSheetTab_b__9_0(KeyValuePair<string, int> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SheetParser.__c.NativeMethodInfoPtr__ParseSheetTab_b__9_0_Internal_String_KeyValuePair_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060001FF RID: 511 RVA: 0x0000304A File Offset: 0x0000124A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x06000200 RID: 512 RVA: 0x0000A958 File Offset: 0x00008B58
			// (set) Token: 0x06000201 RID: 513 RVA: 0x00003053 File Offset: 0x00001253
			public unsafe static SheetParser.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SheetParser.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SheetParser.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SheetParser.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x06000202 RID: 514 RVA: 0x0000A980 File Offset: 0x00008B80
			// (set) Token: 0x06000203 RID: 515 RVA: 0x00003065 File Offset: 0x00001265
			public unsafe static Func<KeyValuePair<string, int>, string> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SheetParser.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, int>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SheetParser.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000130 RID: 304
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000131 RID: 305
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04000132 RID: 306
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000133 RID: 307
			private static readonly IntPtr NativeMethodInfoPtr__ParseSheetTab_b__9_0_Internal_String_KeyValuePair_2_String_Int32_0;
		}

		// Token: 0x02000033 RID: 51
		[ObfuscatedName("CanisData.parsers.SheetParser+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x06000204 RID: 516 RVA: 0x0000A9A8 File Offset: 0x00008BA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<SheetParser.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SheetParser>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SheetParser.__c__DisplayClass8_0>.NativeClassPtr);
				SheetParser.__c__DisplayClass8_0.NativeFieldInfoPtr_ignoredTabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetParser.__c__DisplayClass8_0>.NativeClassPtr, "ignoredTabs");
				SheetParser.__c__DisplayClass8_0.NativeFieldInfoPtr_includeTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetParser.__c__DisplayClass8_0>.NativeClassPtr, "includeTest");
				SheetParser.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetParser.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				SheetParser.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetParser.__c__DisplayClass8_0>.NativeClassPtr, 100663337);
				SheetParser.__c__DisplayClass8_0.NativeMethodInfoPtr__ParseSheet_b__0_Internal_Boolean_Sheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetParser.__c__DisplayClass8_0>.NativeClassPtr, 100663338);
				SheetParser.__c__DisplayClass8_0.NativeMethodInfoPtr__ParseSheet_b__1_Internal_String_Sheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetParser.__c__DisplayClass8_0>.NativeClassPtr, 100663339);
			}

			// Token: 0x06000205 RID: 517 RVA: 0x0000AA4C File Offset: 0x00008C4C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SheetParser.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SheetParser.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000206 RID: 518 RVA: 0x0000AA88 File Offset: 0x00008C88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222127, XrefRangeEnd = 1222132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ParseSheet_b__0(Sheet s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SheetParser.__c__DisplayClass8_0.NativeMethodInfoPtr__ParseSheet_b__0_Internal_Boolean_Sheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000207 RID: 519 RVA: 0x0000AAD8 File Offset: 0x00008CD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222132, XrefRangeEnd = 1222150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ParseSheet_b__1(Sheet s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SheetParser.__c__DisplayClass8_0.NativeMethodInfoPtr__ParseSheet_b__1_Internal_String_Sheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000208 RID: 520 RVA: 0x00003077 File Offset: 0x00001277
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x06000209 RID: 521 RVA: 0x0000AB20 File Offset: 0x00008D20
			// (set) Token: 0x0600020A RID: 522 RVA: 0x00003080 File Offset: 0x00001280
			public unsafe Il2CppStringArray ignoredTabs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser.__c__DisplayClass8_0.NativeFieldInfoPtr_ignoredTabs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser.__c__DisplayClass8_0.NativeFieldInfoPtr_ignoredTabs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x0600020B RID: 523 RVA: 0x0000AB50 File Offset: 0x00008D50
			// (set) Token: 0x0600020C RID: 524 RVA: 0x0000309F File Offset: 0x0000129F
			public unsafe bool includeTest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser.__c__DisplayClass8_0.NativeFieldInfoPtr_includeTest);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser.__c__DisplayClass8_0.NativeFieldInfoPtr_includeTest)) = value;
				}
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x0600020D RID: 525 RVA: 0x0000AB78 File Offset: 0x00008D78
			// (set) Token: 0x0600020E RID: 526 RVA: 0x000030BA File Offset: 0x000012BA
			public unsafe SheetParser __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SheetParser>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000134 RID: 308
			private static readonly IntPtr NativeFieldInfoPtr_ignoredTabs;

			// Token: 0x04000135 RID: 309
			private static readonly IntPtr NativeFieldInfoPtr_includeTest;

			// Token: 0x04000136 RID: 310
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000137 RID: 311
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000138 RID: 312
			private static readonly IntPtr NativeMethodInfoPtr__ParseSheet_b__0_Internal_Boolean_Sheet_0;

			// Token: 0x04000139 RID: 313
			private static readonly IntPtr NativeMethodInfoPtr__ParseSheet_b__1_Internal_String_Sheet_0;
		}

		// Token: 0x02000034 RID: 52
		[ObfuscatedName("CanisData.parsers.SheetParser+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x0600020F RID: 527 RVA: 0x0000ABA8 File Offset: 0x00008DA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<SheetParser.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SheetParser>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SheetParser.__c__DisplayClass9_0>.NativeClassPtr);
				SheetParser.__c__DisplayClass9_0.NativeFieldInfoPtr_rowData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetParser.__c__DisplayClass9_0>.NativeClassPtr, "rowData");
				SheetParser.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetParser.__c__DisplayClass9_0>.NativeClassPtr, 100663340);
				SheetParser.__c__DisplayClass9_0.NativeMethodInfoPtr__ParseSheetTab_b__1_Internal_String_KeyValuePair_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetParser.__c__DisplayClass9_0>.NativeClassPtr, 100663341);
			}

			// Token: 0x06000210 RID: 528 RVA: 0x0000AC10 File Offset: 0x00008E10
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SheetParser.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SheetParser.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000211 RID: 529 RVA: 0x0000AC4C File Offset: 0x00008E4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222150, XrefRangeEnd = 1222162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ParseSheetTab_b__1(KeyValuePair<string, int> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SheetParser.__c__DisplayClass9_0.NativeMethodInfoPtr__ParseSheetTab_b__1_Internal_String_KeyValuePair_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000212 RID: 530 RVA: 0x000030D9 File Offset: 0x000012D9
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x06000213 RID: 531 RVA: 0x0000AC9C File Offset: 0x00008E9C
			// (set) Token: 0x06000214 RID: 532 RVA: 0x000030E2 File Offset: 0x000012E2
			public unsafe IList<Object> rowData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser.__c__DisplayClass9_0.NativeFieldInfoPtr_rowData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser.__c__DisplayClass9_0.NativeFieldInfoPtr_rowData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400013A RID: 314
			private static readonly IntPtr NativeFieldInfoPtr_rowData;

			// Token: 0x0400013B RID: 315
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400013C RID: 316
			private static readonly IntPtr NativeMethodInfoPtr__ParseSheetTab_b__1_Internal_String_KeyValuePair_2_String_Int32_0;
		}

		// Token: 0x02000035 RID: 53
		[ObfuscatedName("CanisData.parsers.SheetParser+<ParseSheet>d__8")]
		public sealed class _ParseSheet_d__8 : ValueType
		{
			// Token: 0x06000215 RID: 533 RVA: 0x0000ACCC File Offset: 0x00008ECC
			// Note: this type is marked as 'beforefieldinit'.
			static _ParseSheet_d__8()
			{
				Il2CppClassPointerStore<SheetParser._ParseSheet_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SheetParser>.NativeClassPtr, "<ParseSheet>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SheetParser._ParseSheet_d__8>.NativeClassPtr);
				SheetParser._ParseSheet_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetParser._ParseSheet_d__8>.NativeClassPtr, "<>1__state");
				SheetParser._ParseSheet_d__8.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetParser._ParseSheet_d__8>.NativeClassPtr, "<>t__builder");
				SheetParser._ParseSheet_d__8.NativeFieldInfoPtr_ignoredTabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetParser._ParseSheet_d__8>.NativeClassPtr, "ignoredTabs");
				SheetParser._ParseSheet_d__8.NativeFieldInfoPtr_includeTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetParser._ParseSheet_d__8>.NativeClassPtr, "includeTest");
				SheetParser._ParseSheet_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetParser._ParseSheet_d__8>.NativeClassPtr, "<>4__this");
				SheetParser._ParseSheet_d__8.NativeFieldInfoPtr_spreadsheetID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetParser._ParseSheet_d__8>.NativeClassPtr, "spreadsheetID");
				SheetParser._ParseSheet_d__8.NativeFieldInfoPtr_processOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetParser._ParseSheet_d__8>.NativeClassPtr, "processOutput");
				SheetParser._ParseSheet_d__8.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetParser._ParseSheet_d__8>.NativeClassPtr, "<>8__1");
				SheetParser._ParseSheet_d__8.NativeFieldInfoPtr_errorTolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetParser._ParseSheet_d__8>.NativeClassPtr, "errorTolerance");
				SheetParser._ParseSheet_d__8.NativeFieldInfoPtr__service_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetParser._ParseSheet_d__8>.NativeClassPtr, "<service>5__2");
				SheetParser._ParseSheet_d__8.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetParser._ParseSheet_d__8>.NativeClassPtr, "<>u__1");
				SheetParser._ParseSheet_d__8.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SheetParser._ParseSheet_d__8>.NativeClassPtr, "<>u__2");
				SheetParser._ParseSheet_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetParser._ParseSheet_d__8>.NativeClassPtr, 100663342);
				SheetParser._ParseSheet_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SheetParser._ParseSheet_d__8>.NativeClassPtr, 100663343);
			}

			// Token: 0x06000216 RID: 534 RVA: 0x0000AE10 File Offset: 0x00009010
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222162, XrefRangeEnd = 1222310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SheetParser._ParseSheet_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000217 RID: 535 RVA: 0x0000AE48 File Offset: 0x00009048
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222310, XrefRangeEnd = 1222316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SheetParser._ParseSheet_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000218 RID: 536 RVA: 0x00003101 File Offset: 0x00001301
			public _ParseSheet_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000219 RID: 537 RVA: 0x0000310A File Offset: 0x0000130A
			public _ParseSheet_d__8()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SheetParser._ParseSheet_d__8>.NativeClassPtr))
			{
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x0600021A RID: 538 RVA: 0x0000AE90 File Offset: 0x00009090
			// (set) Token: 0x0600021B RID: 539 RVA: 0x0000311C File Offset: 0x0000131C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser._ParseSheet_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser._ParseSheet_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x0600021C RID: 540 RVA: 0x0000AEB8 File Offset: 0x000090B8
			// (set) Token: 0x0600021D RID: 541 RVA: 0x00003137 File Offset: 0x00001337
			public AsyncTaskMethodBuilder<IEnumerable<ParserArtifact>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser._ParseSheet_d__8.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<IEnumerable<ParserArtifact>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<IEnumerable<ParserArtifact>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser._ParseSheet_d__8.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<IEnumerable<ParserArtifact>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x0600021E RID: 542 RVA: 0x0000AEE8 File Offset: 0x000090E8
			// (set) Token: 0x0600021F RID: 543 RVA: 0x00003165 File Offset: 0x00001365
			public unsafe Il2CppStringArray ignoredTabs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser._ParseSheet_d__8.NativeFieldInfoPtr_ignoredTabs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser._ParseSheet_d__8.NativeFieldInfoPtr_ignoredTabs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x06000220 RID: 544 RVA: 0x0000AF18 File Offset: 0x00009118
			// (set) Token: 0x06000221 RID: 545 RVA: 0x00003184 File Offset: 0x00001384
			public unsafe bool includeTest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser._ParseSheet_d__8.NativeFieldInfoPtr_includeTest);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser._ParseSheet_d__8.NativeFieldInfoPtr_includeTest)) = value;
				}
			}

			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x06000222 RID: 546 RVA: 0x0000AF40 File Offset: 0x00009140
			// (set) Token: 0x06000223 RID: 547 RVA: 0x0000319F File Offset: 0x0000139F
			public unsafe SheetParser __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser._ParseSheet_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SheetParser>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser._ParseSheet_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x06000224 RID: 548 RVA: 0x0000AF70 File Offset: 0x00009170
			// (set) Token: 0x06000225 RID: 549 RVA: 0x000031BE File Offset: 0x000013BE
			public unsafe string spreadsheetID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser._ParseSheet_d__8.NativeFieldInfoPtr_spreadsheetID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser._ParseSheet_d__8.NativeFieldInfoPtr_spreadsheetID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x06000226 RID: 550 RVA: 0x0000AF98 File Offset: 0x00009198
			// (set) Token: 0x06000227 RID: 551 RVA: 0x000031DD File Offset: 0x000013DD
			public unsafe StringBuilder processOutput
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser._ParseSheet_d__8.NativeFieldInfoPtr_processOutput);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser._ParseSheet_d__8.NativeFieldInfoPtr_processOutput), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x06000228 RID: 552 RVA: 0x0000AFC8 File Offset: 0x000091C8
			// (set) Token: 0x06000229 RID: 553 RVA: 0x000031FC File Offset: 0x000013FC
			public unsafe SheetParser.__c__DisplayClass8_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser._ParseSheet_d__8.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SheetParser.__c__DisplayClass8_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser._ParseSheet_d__8.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x0600022A RID: 554 RVA: 0x0000AFF8 File Offset: 0x000091F8
			// (set) Token: 0x0600022B RID: 555 RVA: 0x0000321B File Offset: 0x0000141B
			public unsafe ErrorTolerance errorTolerance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser._ParseSheet_d__8.NativeFieldInfoPtr_errorTolerance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser._ParseSheet_d__8.NativeFieldInfoPtr_errorTolerance)) = value;
				}
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x0600022C RID: 556 RVA: 0x0000B020 File Offset: 0x00009220
			// (set) Token: 0x0600022D RID: 557 RVA: 0x00003236 File Offset: 0x00001436
			public unsafe SheetsService _service_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser._ParseSheet_d__8.NativeFieldInfoPtr__service_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SheetsService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser._ParseSheet_d__8.NativeFieldInfoPtr__service_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000AA RID: 170
			// (get) Token: 0x0600022E RID: 558 RVA: 0x0000B050 File Offset: 0x00009250
			// (set) Token: 0x0600022F RID: 559 RVA: 0x00003255 File Offset: 0x00001455
			public TaskAwaiter<Spreadsheet> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser._ParseSheet_d__8.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Spreadsheet>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Spreadsheet>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser._ParseSheet_d__8.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Spreadsheet>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x06000230 RID: 560 RVA: 0x0000B080 File Offset: 0x00009280
			// (set) Token: 0x06000231 RID: 561 RVA: 0x00003283 File Offset: 0x00001483
			public TaskAwaiter<BatchGetValuesResponse> __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser._ParseSheet_d__8.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter<BatchGetValuesResponse>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<BatchGetValuesResponse>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SheetParser._ParseSheet_d__8.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<BatchGetValuesResponse>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400013D RID: 317
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400013E RID: 318
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400013F RID: 319
			private static readonly IntPtr NativeFieldInfoPtr_ignoredTabs;

			// Token: 0x04000140 RID: 320
			private static readonly IntPtr NativeFieldInfoPtr_includeTest;

			// Token: 0x04000141 RID: 321
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000142 RID: 322
			private static readonly IntPtr NativeFieldInfoPtr_spreadsheetID;

			// Token: 0x04000143 RID: 323
			private static readonly IntPtr NativeFieldInfoPtr_processOutput;

			// Token: 0x04000144 RID: 324
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04000145 RID: 325
			private static readonly IntPtr NativeFieldInfoPtr_errorTolerance;

			// Token: 0x04000146 RID: 326
			private static readonly IntPtr NativeFieldInfoPtr__service_5__2;

			// Token: 0x04000147 RID: 327
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000148 RID: 328
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04000149 RID: 329
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400014A RID: 330
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}

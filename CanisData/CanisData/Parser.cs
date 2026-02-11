using System;
using System.Runtime.InteropServices;
using CanisData.parsers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Text;
using Il2CppSystem.Threading.Tasks;

namespace CanisData
{
	// Token: 0x02000008 RID: 8
	public class Parser : Object
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00003B60 File Offset: 0x00001D60
		// Note: this type is marked as 'beforefieldinit'.
		static Parser()
		{
			Il2CppClassPointerStore<Parser>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData", "Parser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser>.NativeClassPtr);
			Parser.NativeFieldInfoPtr_processOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "processOutput");
			Parser.NativeFieldInfoPtr_BaseOutputDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "BaseOutputDirectory");
			Parser.NativeMethodInfoPtr_get_LineEndings_Protected_Virtual_New_get_LineEndings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100663304);
			Parser.NativeMethodInfoPtr_get_ProcessOutput_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100663305);
			Parser.NativeMethodInfoPtr__ctor_Protected_Void_String_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100663306);
			Parser.NativeMethodInfoPtr_FindParser_Protected_Abstract_Virtual_New_SheetParser_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100663307);
			Parser.NativeMethodInfoPtr_Run_Public_Virtual_New_Task_String_String_ErrorTolerance_Boolean_Boolean_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100663308);
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00003C1C File Offset: 0x00001E1C
		public unsafe virtual LineEndings LineEndings
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Parser.NativeMethodInfoPtr_get_LineEndings_Protected_Virtual_New_get_LineEndings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00003C64 File Offset: 0x00001E64
		public unsafe string ProcessOutput
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 549125, RefRangeEnd = 549132, XrefRangeStart = 549125, XrefRangeEnd = 549132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_get_ProcessOutput_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003C9C File Offset: 0x00001E9C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 558839, RefRangeEnd = 558843, XrefRangeStart = 558839, XrefRangeEnd = 558843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Parser(string baseOutputDirectory, StringBuilder processOutput)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Parser>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseOutputDirectory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(processOutput);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr__ctor_Protected_Void_String_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003CFC File Offset: 0x00001EFC
		[CallerCount(0)]
		public unsafe virtual SheetParser FindParser(string parserName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(parserName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Parser.NativeMethodInfoPtr_FindParser_Protected_Abstract_Virtual_New_SheetParser_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SheetParser>(intPtr3) : null;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003D58 File Offset: 0x00001F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221974, XrefRangeEnd = 1221987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task Run(string parserName, string spreadsheetID, ErrorTolerance errorTolerance = ErrorTolerance.ErrorFailsBuild, bool includeTest = false, bool preview = false, [Optional] Il2CppStringArray ignoredTabs)
		{
			if (ignoredTabs == null)
			{
				ignoredTabs = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(parserName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spreadsheetID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errorTolerance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeTest;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preview;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ignoredTabs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Parser.NativeMethodInfoPtr_Run_Public_Virtual_New_Task_String_String_ErrorTolerance_Boolean_Boolean_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002129 File Offset: 0x00000329
		public virtual Task Run(string parserName, string spreadsheetID, [Optional] ErrorTolerance errorTolerance, [Optional] bool includeTest, [Optional] bool preview, params string[] ignoredTabs)
		{
			return this.Run(parserName, spreadsheetID, errorTolerance, includeTest, preview, new Il2CppStringArray(ignoredTabs));
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000213F File Offset: 0x0000033F
		public Parser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00003E10 File Offset: 0x00002010
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002148 File Offset: 0x00000348
		public unsafe StringBuilder processOutput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_processOutput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_processOutput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00003E40 File Offset: 0x00002040
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002167 File Offset: 0x00000367
		public unsafe string BaseOutputDirectory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_BaseOutputDirectory);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_BaseOutputDirectory), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_processOutput;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_BaseOutputDirectory;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_get_LineEndings_Protected_Virtual_New_get_LineEndings_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessOutput_Public_get_String_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_StringBuilder_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_FindParser_Protected_Abstract_Virtual_New_SheetParser_String_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_New_Task_String_String_ErrorTolerance_Boolean_Boolean_Il2CppStringArray_0;

		// Token: 0x02000030 RID: 48
		[ObfuscatedName("CanisData.Parser+<Run>d__8")]
		public sealed class _Run_d__8 : ValueType
		{
			// Token: 0x060001D1 RID: 465 RVA: 0x0000A260 File Offset: 0x00008460
			// Note: this type is marked as 'beforefieldinit'.
			static _Run_d__8()
			{
				Il2CppClassPointerStore<Parser._Run_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Parser>.NativeClassPtr, "<Run>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser._Run_d__8>.NativeClassPtr);
				Parser._Run_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser._Run_d__8>.NativeClassPtr, "<>1__state");
				Parser._Run_d__8.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser._Run_d__8>.NativeClassPtr, "<>t__builder");
				Parser._Run_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser._Run_d__8>.NativeClassPtr, "<>4__this");
				Parser._Run_d__8.NativeFieldInfoPtr_parserName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser._Run_d__8>.NativeClassPtr, "parserName");
				Parser._Run_d__8.NativeFieldInfoPtr_spreadsheetID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser._Run_d__8>.NativeClassPtr, "spreadsheetID");
				Parser._Run_d__8.NativeFieldInfoPtr_errorTolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser._Run_d__8>.NativeClassPtr, "errorTolerance");
				Parser._Run_d__8.NativeFieldInfoPtr_includeTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser._Run_d__8>.NativeClassPtr, "includeTest");
				Parser._Run_d__8.NativeFieldInfoPtr_ignoredTabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser._Run_d__8>.NativeClassPtr, "ignoredTabs");
				Parser._Run_d__8.NativeFieldInfoPtr_preview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser._Run_d__8>.NativeClassPtr, "preview");
				Parser._Run_d__8.NativeFieldInfoPtr__parser_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser._Run_d__8>.NativeClassPtr, "<parser>5__2");
				Parser._Run_d__8.NativeFieldInfoPtr__encoding_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser._Run_d__8>.NativeClassPtr, "<encoding>5__3");
				Parser._Run_d__8.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser._Run_d__8>.NativeClassPtr, "<>u__1");
				Parser._Run_d__8.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser._Run_d__8>.NativeClassPtr, "<>7__wrap3");
				Parser._Run_d__8.NativeFieldInfoPtr__fileStream_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser._Run_d__8>.NativeClassPtr, "<fileStream>5__5");
				Parser._Run_d__8.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser._Run_d__8>.NativeClassPtr, "<>u__2");
				Parser._Run_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser._Run_d__8>.NativeClassPtr, 100663309);
				Parser._Run_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser._Run_d__8>.NativeClassPtr, 100663310);
			}

			// Token: 0x060001D2 RID: 466 RVA: 0x0000A3E0 File Offset: 0x000085E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221856, XrefRangeEnd = 1221970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser._Run_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001D3 RID: 467 RVA: 0x0000A418 File Offset: 0x00008618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221970, XrefRangeEnd = 1221974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser._Run_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060001D4 RID: 468 RVA: 0x00002E14 File Offset: 0x00001014
			public _Run_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060001D5 RID: 469 RVA: 0x00002E1D File Offset: 0x0000101D
			public _Run_d__8()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Parser._Run_d__8>.NativeClassPtr))
			{
			}

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000A460 File Offset: 0x00008660
			// (set) Token: 0x060001D7 RID: 471 RVA: 0x00002E2F File Offset: 0x0000102F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x060001D8 RID: 472 RVA: 0x0000A488 File Offset: 0x00008688
			// (set) Token: 0x060001D9 RID: 473 RVA: 0x00002E4A File Offset: 0x0000104A
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x060001DA RID: 474 RVA: 0x0000A4B8 File Offset: 0x000086B8
			// (set) Token: 0x060001DB RID: 475 RVA: 0x00002E78 File Offset: 0x00001078
			public unsafe Parser __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Parser>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700008C RID: 140
			// (get) Token: 0x060001DC RID: 476 RVA: 0x0000A4E8 File Offset: 0x000086E8
			// (set) Token: 0x060001DD RID: 477 RVA: 0x00002E97 File Offset: 0x00001097
			public unsafe string parserName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr_parserName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr_parserName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x060001DE RID: 478 RVA: 0x0000A510 File Offset: 0x00008710
			// (set) Token: 0x060001DF RID: 479 RVA: 0x00002EB6 File Offset: 0x000010B6
			public unsafe string spreadsheetID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr_spreadsheetID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr_spreadsheetID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000A538 File Offset: 0x00008738
			// (set) Token: 0x060001E1 RID: 481 RVA: 0x00002ED5 File Offset: 0x000010D5
			public unsafe ErrorTolerance errorTolerance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr_errorTolerance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr_errorTolerance)) = value;
				}
			}

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x060001E2 RID: 482 RVA: 0x0000A560 File Offset: 0x00008760
			// (set) Token: 0x060001E3 RID: 483 RVA: 0x00002EF0 File Offset: 0x000010F0
			public unsafe bool includeTest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr_includeTest);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr_includeTest)) = value;
				}
			}

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000A588 File Offset: 0x00008788
			// (set) Token: 0x060001E5 RID: 485 RVA: 0x00002F0B File Offset: 0x0000110B
			public unsafe Il2CppStringArray ignoredTabs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr_ignoredTabs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr_ignoredTabs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x060001E6 RID: 486 RVA: 0x0000A5B8 File Offset: 0x000087B8
			// (set) Token: 0x060001E7 RID: 487 RVA: 0x00002F2A File Offset: 0x0000112A
			public unsafe bool preview
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr_preview);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr_preview)) = value;
				}
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x060001E8 RID: 488 RVA: 0x0000A5E0 File Offset: 0x000087E0
			// (set) Token: 0x060001E9 RID: 489 RVA: 0x00002F45 File Offset: 0x00001145
			public unsafe SheetParser _parser_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr__parser_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SheetParser>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr__parser_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x060001EA RID: 490 RVA: 0x0000A610 File Offset: 0x00008810
			// (set) Token: 0x060001EB RID: 491 RVA: 0x00002F64 File Offset: 0x00001164
			public unsafe UTF8Encoding _encoding_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr__encoding_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UTF8Encoding>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr__encoding_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x060001EC RID: 492 RVA: 0x0000A640 File Offset: 0x00008840
			// (set) Token: 0x060001ED RID: 493 RVA: 0x00002F83 File Offset: 0x00001183
			public TaskAwaiter<IEnumerable<ParserArtifact>> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<IEnumerable<ParserArtifact>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<IEnumerable<ParserArtifact>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<IEnumerable<ParserArtifact>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x060001EE RID: 494 RVA: 0x0000A670 File Offset: 0x00008870
			// (set) Token: 0x060001EF RID: 495 RVA: 0x00002FB1 File Offset: 0x000011B1
			public unsafe IEnumerator<ParserArtifact> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<ParserArtifact>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000A6A0 File Offset: 0x000088A0
			// (set) Token: 0x060001F1 RID: 497 RVA: 0x00002FD0 File Offset: 0x000011D0
			public unsafe FileStream _fileStream_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr__fileStream_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr__fileStream_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x060001F2 RID: 498 RVA: 0x0000A6D0 File Offset: 0x000088D0
			// (set) Token: 0x060001F3 RID: 499 RVA: 0x00002FEF File Offset: 0x000011EF
			public TaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser._Run_d__8.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400011B RID: 283
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400011C RID: 284
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400011D RID: 285
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400011E RID: 286
			private static readonly IntPtr NativeFieldInfoPtr_parserName;

			// Token: 0x0400011F RID: 287
			private static readonly IntPtr NativeFieldInfoPtr_spreadsheetID;

			// Token: 0x04000120 RID: 288
			private static readonly IntPtr NativeFieldInfoPtr_errorTolerance;

			// Token: 0x04000121 RID: 289
			private static readonly IntPtr NativeFieldInfoPtr_includeTest;

			// Token: 0x04000122 RID: 290
			private static readonly IntPtr NativeFieldInfoPtr_ignoredTabs;

			// Token: 0x04000123 RID: 291
			private static readonly IntPtr NativeFieldInfoPtr_preview;

			// Token: 0x04000124 RID: 292
			private static readonly IntPtr NativeFieldInfoPtr__parser_5__2;

			// Token: 0x04000125 RID: 293
			private static readonly IntPtr NativeFieldInfoPtr__encoding_5__3;

			// Token: 0x04000126 RID: 294
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000127 RID: 295
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04000128 RID: 296
			private static readonly IntPtr NativeFieldInfoPtr__fileStream_5__5;

			// Token: 0x04000129 RID: 297
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400012A RID: 298
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400012B RID: 299
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}

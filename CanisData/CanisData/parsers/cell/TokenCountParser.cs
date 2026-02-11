using System;
using CanisData.generation.builders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text.RegularExpressions;

namespace CanisData.parsers.cell
{
	// Token: 0x02000020 RID: 32
	public class TokenCountParser : Object
	{
		// Token: 0x0600010F RID: 271 RVA: 0x000078C0 File Offset: 0x00005AC0
		// Note: this type is marked as 'beforefieldinit'.
		static TokenCountParser()
		{
			Il2CppClassPointerStore<TokenCountParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.parsers.cell", "TokenCountParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenCountParser>.NativeClassPtr);
			TokenCountParser.NativeFieldInfoPtr_columnName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenCountParser>.NativeClassPtr, "columnName");
			TokenCountParser.NativeFieldInfoPtr_tokenMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenCountParser>.NativeClassPtr, "tokenMap");
			TokenCountParser.NativeFieldInfoPtr_skipList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenCountParser>.NativeClassPtr, "skipList");
			TokenCountParser.NativeFieldInfoPtr_forceValueMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenCountParser>.NativeClassPtr, "forceValueMap");
			TokenCountParser.NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenCountParser>.NativeClassPtr, 100663430);
			TokenCountParser.NativeMethodInfoPtr__ctor_Public_Void_String_Dictionary_2_String_String_List_1_String_Dictionary_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenCountParser>.NativeClassPtr, 100663431);
			TokenCountParser.NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenCountParser>.NativeClassPtr, 100663432);
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0000797C File Offset: 0x00005B7C
		public unsafe virtual string ColumnName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenCountParser.NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000079B4 File Offset: 0x00005BB4
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1223716, RefRangeEnd = 1223731, XrefRangeStart = 1223699, XrefRangeEnd = 1223716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenCountParser(string columnName, Dictionary<string, string> tokenMap, List<string> skipList = null, Dictionary<string, int> forceValueMap = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenCountParser>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(columnName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tokenMap);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(skipList);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(forceValueMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenCountParser.NativeMethodInfoPtr__ctor_Public_Void_String_Dictionary_2_String_String_List_1_String_Dictionary_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00007A38 File Offset: 0x00005C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223731, XrefRangeEnd = 1223892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Parse(string cell, ref ScriptBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cell);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TokenCountParser.NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			builder = ((intPtr4 == 0) ? null : new ScriptBuilder(intPtr4));
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000028A8 File Offset: 0x00000AA8
		public TokenCountParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00007AA4 File Offset: 0x00005CA4
		// (set) Token: 0x06000115 RID: 277 RVA: 0x000028B1 File Offset: 0x00000AB1
		public unsafe string columnName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenCountParser.NativeFieldInfoPtr_columnName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenCountParser.NativeFieldInfoPtr_columnName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00007ACC File Offset: 0x00005CCC
		// (set) Token: 0x06000117 RID: 279 RVA: 0x000028D0 File Offset: 0x00000AD0
		public unsafe Dictionary<string, string> tokenMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenCountParser.NativeFieldInfoPtr_tokenMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenCountParser.NativeFieldInfoPtr_tokenMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00007AFC File Offset: 0x00005CFC
		// (set) Token: 0x06000119 RID: 281 RVA: 0x000028EF File Offset: 0x00000AEF
		public unsafe List<string> skipList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenCountParser.NativeFieldInfoPtr_skipList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenCountParser.NativeFieldInfoPtr_skipList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00007B2C File Offset: 0x00005D2C
		// (set) Token: 0x0600011B RID: 283 RVA: 0x0000290E File Offset: 0x00000B0E
		public unsafe Dictionary<string, int> forceValueMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenCountParser.NativeFieldInfoPtr_forceValueMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenCountParser.NativeFieldInfoPtr_forceValueMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeFieldInfoPtr_columnName;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeFieldInfoPtr_tokenMap;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeFieldInfoPtr_skipList;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeFieldInfoPtr_forceValueMap;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Dictionary_2_String_String_List_1_String_Dictionary_2_String_Int32_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0;

		// Token: 0x0200003F RID: 63
		[ObfuscatedName("CanisData.parsers.cell.TokenCountParser+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600028C RID: 652 RVA: 0x0000BF60 File Offset: 0x0000A160
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TokenCountParser.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TokenCountParser>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenCountParser.__c>.NativeClassPtr);
				TokenCountParser.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenCountParser.__c>.NativeClassPtr, "<>9");
				TokenCountParser.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenCountParser.__c>.NativeClassPtr, "<>9__7_0");
				TokenCountParser.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenCountParser.__c>.NativeClassPtr, 100663434);
				TokenCountParser.__c.NativeMethodInfoPtr__Parse_b__7_0_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenCountParser.__c>.NativeClassPtr, 100663435);
			}

			// Token: 0x0600028D RID: 653 RVA: 0x0000BFDC File Offset: 0x0000A1DC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenCountParser.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenCountParser.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600028E RID: 654 RVA: 0x0000C018 File Offset: 0x0000A218
			[CallerCount(0)]
			public unsafe int _Parse_b__7_0(string s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenCountParser.__c.NativeMethodInfoPtr__Parse_b__7_0_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600028F RID: 655 RVA: 0x0000361D File Offset: 0x0000181D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x06000290 RID: 656 RVA: 0x0000C068 File Offset: 0x0000A268
			// (set) Token: 0x06000291 RID: 657 RVA: 0x00003626 File Offset: 0x00001826
			public unsafe static TokenCountParser.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TokenCountParser.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenCountParser.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TokenCountParser.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C8 RID: 200
			// (get) Token: 0x06000292 RID: 658 RVA: 0x0000C090 File Offset: 0x0000A290
			// (set) Token: 0x06000293 RID: 659 RVA: 0x00003638 File Offset: 0x00001838
			public unsafe static Func<string, int> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TokenCountParser.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TokenCountParser.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000178 RID: 376
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000179 RID: 377
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x0400017A RID: 378
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400017B RID: 379
			private static readonly IntPtr NativeMethodInfoPtr__Parse_b__7_0_Internal_Int32_String_0;
		}

		// Token: 0x02000040 RID: 64
		[ObfuscatedName("CanisData.parsers.cell.TokenCountParser+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x06000294 RID: 660 RVA: 0x0000C0B8 File Offset: 0x0000A2B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<TokenCountParser.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TokenCountParser>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenCountParser.__c__DisplayClass7_0>.NativeClassPtr);
				TokenCountParser.__c__DisplayClass7_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenCountParser.__c__DisplayClass7_0>.NativeClassPtr, "match");
				TokenCountParser.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenCountParser.__c__DisplayClass7_0>.NativeClassPtr, 100663436);
				TokenCountParser.__c__DisplayClass7_0.NativeMethodInfoPtr__Parse_b__1_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenCountParser.__c__DisplayClass7_0>.NativeClassPtr, 100663437);
			}

			// Token: 0x06000295 RID: 661 RVA: 0x0000C120 File Offset: 0x0000A320
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenCountParser.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenCountParser.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000296 RID: 662 RVA: 0x0000C15C File Offset: 0x0000A35C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223696, XrefRangeEnd = 1223699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Parse_b__1(string s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenCountParser.__c__DisplayClass7_0.NativeMethodInfoPtr__Parse_b__1_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000297 RID: 663 RVA: 0x0000364A File Offset: 0x0000184A
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000C9 RID: 201
			// (get) Token: 0x06000298 RID: 664 RVA: 0x0000C1AC File Offset: 0x0000A3AC
			// (set) Token: 0x06000299 RID: 665 RVA: 0x00003653 File Offset: 0x00001853
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenCountParser.__c__DisplayClass7_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenCountParser.__c__DisplayClass7_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400017C RID: 380
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x0400017D RID: 381
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400017E RID: 382
			private static readonly IntPtr NativeMethodInfoPtr__Parse_b__1_Internal_Boolean_String_0;
		}
	}
}

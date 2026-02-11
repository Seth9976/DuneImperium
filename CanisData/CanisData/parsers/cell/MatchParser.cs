using System;
using CanisData.generation.builders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace CanisData.parsers.cell
{
	// Token: 0x0200001C RID: 28
	public class MatchParser : Object
	{
		// Token: 0x060000E5 RID: 229 RVA: 0x00007024 File Offset: 0x00005224
		// Note: this type is marked as 'beforefieldinit'.
		static MatchParser()
		{
			Il2CppClassPointerStore<MatchParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.parsers.cell", "MatchParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchParser>.NativeClassPtr);
			MatchParser.NativeFieldInfoPtr_columnName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchParser>.NativeClassPtr, "columnName");
			MatchParser.NativeFieldInfoPtr_matchMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchParser>.NativeClassPtr, "matchMap");
			MatchParser.NativeFieldInfoPtr_skipList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchParser>.NativeClassPtr, "skipList");
			MatchParser.NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchParser>.NativeClassPtr, 100663413);
			MatchParser.NativeMethodInfoPtr__ctor_Public_Void_String_Dictionary_2_String_Il2CppStringArray_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchParser>.NativeClassPtr, 100663414);
			MatchParser.NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchParser>.NativeClassPtr, 100663415);
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x000070CC File Offset: 0x000052CC
		public unsafe virtual string ColumnName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchParser.NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00007104 File Offset: 0x00005304
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1223518, RefRangeEnd = 1223524, XrefRangeStart = 1223508, XrefRangeEnd = 1223518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchParser(string columnName, Dictionary<string, Il2CppStringArray> matchMap, List<string> skipList = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchParser>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(columnName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matchMap);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(skipList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchParser.NativeMethodInfoPtr__ctor_Public_Void_String_Dictionary_2_String_Il2CppStringArray_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00007174 File Offset: 0x00005374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223524, XrefRangeEnd = 1223587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MatchParser.NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			builder = ((intPtr4 == 0) ? null : new ScriptBuilder(intPtr4));
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000272F File Offset: 0x0000092F
		public MatchParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000EA RID: 234 RVA: 0x000071E0 File Offset: 0x000053E0
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00002738 File Offset: 0x00000938
		public unsafe string columnName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchParser.NativeFieldInfoPtr_columnName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchParser.NativeFieldInfoPtr_columnName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00007208 File Offset: 0x00005408
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00002757 File Offset: 0x00000957
		public unsafe Dictionary<string, Il2CppStringArray> matchMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchParser.NativeFieldInfoPtr_matchMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppStringArray>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchParser.NativeFieldInfoPtr_matchMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00007238 File Offset: 0x00005438
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00002776 File Offset: 0x00000976
		public unsafe List<string> skipList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchParser.NativeFieldInfoPtr_skipList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchParser.NativeFieldInfoPtr_skipList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeFieldInfoPtr_columnName;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeFieldInfoPtr_matchMap;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeFieldInfoPtr_skipList;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Dictionary_2_String_Il2CppStringArray_List_1_String_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0;

		// Token: 0x0200003D RID: 61
		[ObfuscatedName("CanisData.parsers.cell.MatchParser+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600027E RID: 638 RVA: 0x0000BCEC File Offset: 0x00009EEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MatchParser.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MatchParser>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchParser.__c>.NativeClassPtr);
				MatchParser.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchParser.__c>.NativeClassPtr, "<>9");
				MatchParser.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchParser.__c>.NativeClassPtr, "<>9__6_0");
				MatchParser.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchParser.__c>.NativeClassPtr, 100663417);
				MatchParser.__c.NativeMethodInfoPtr__Parse_b__6_0_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchParser.__c>.NativeClassPtr, 100663418);
			}

			// Token: 0x0600027F RID: 639 RVA: 0x0000BD68 File Offset: 0x00009F68
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchParser.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchParser.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000280 RID: 640 RVA: 0x0000BDA4 File Offset: 0x00009FA4
			[CallerCount(0)]
			public unsafe int _Parse_b__6_0(string s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchParser.__c.NativeMethodInfoPtr__Parse_b__6_0_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000281 RID: 641 RVA: 0x000035C8 File Offset: 0x000017C8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x06000282 RID: 642 RVA: 0x0000BDF4 File Offset: 0x00009FF4
			// (set) Token: 0x06000283 RID: 643 RVA: 0x000035D1 File Offset: 0x000017D1
			public unsafe static MatchParser.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MatchParser.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchParser.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MatchParser.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x06000284 RID: 644 RVA: 0x0000BE1C File Offset: 0x0000A01C
			// (set) Token: 0x06000285 RID: 645 RVA: 0x000035E3 File Offset: 0x000017E3
			public unsafe static Func<string, int> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MatchParser.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MatchParser.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000171 RID: 369
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000172 RID: 370
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04000173 RID: 371
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000174 RID: 372
			private static readonly IntPtr NativeMethodInfoPtr__Parse_b__6_0_Internal_Int32_String_0;
		}

		// Token: 0x0200003E RID: 62
		[ObfuscatedName("CanisData.parsers.cell.MatchParser+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06000286 RID: 646 RVA: 0x0000BE44 File Offset: 0x0000A044
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<MatchParser.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MatchParser>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchParser.__c__DisplayClass6_0>.NativeClassPtr);
				MatchParser.__c__DisplayClass6_0.NativeFieldInfoPtr_sanitizedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchParser.__c__DisplayClass6_0>.NativeClassPtr, "sanitizedValue");
				MatchParser.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchParser.__c__DisplayClass6_0>.NativeClassPtr, 100663419);
				MatchParser.__c__DisplayClass6_0.NativeMethodInfoPtr__Parse_b__1_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchParser.__c__DisplayClass6_0>.NativeClassPtr, 100663420);
			}

			// Token: 0x06000287 RID: 647 RVA: 0x0000BEAC File Offset: 0x0000A0AC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchParser.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchParser.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000288 RID: 648 RVA: 0x0000BEE8 File Offset: 0x0000A0E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223506, XrefRangeEnd = 1223508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Parse_b__1(string s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchParser.__c__DisplayClass6_0.NativeMethodInfoPtr__Parse_b__1_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000289 RID: 649 RVA: 0x000035F5 File Offset: 0x000017F5
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000C6 RID: 198
			// (get) Token: 0x0600028A RID: 650 RVA: 0x0000BF38 File Offset: 0x0000A138
			// (set) Token: 0x0600028B RID: 651 RVA: 0x000035FE File Offset: 0x000017FE
			public unsafe string sanitizedValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchParser.__c__DisplayClass6_0.NativeFieldInfoPtr_sanitizedValue);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchParser.__c__DisplayClass6_0.NativeFieldInfoPtr_sanitizedValue), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000175 RID: 373
			private static readonly IntPtr NativeFieldInfoPtr_sanitizedValue;

			// Token: 0x04000176 RID: 374
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000177 RID: 375
			private static readonly IntPtr NativeMethodInfoPtr__Parse_b__1_Internal_Boolean_String_0;
		}
	}
}

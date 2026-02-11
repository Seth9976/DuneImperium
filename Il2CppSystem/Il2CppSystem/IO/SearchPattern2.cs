using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x02000187 RID: 391
	public class SearchPattern2 : Object
	{
		// Token: 0x060017C2 RID: 6082 RVA: 0x00078D2C File Offset: 0x00076F2C
		// Note: this type is marked as 'beforefieldinit'.
		static SearchPattern2()
		{
			Il2CppClassPointerStore<SearchPattern2>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.IO", "SearchPattern2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SearchPattern2>.NativeClassPtr);
			SearchPattern2.NativeFieldInfoPtr_ops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchPattern2>.NativeClassPtr, "ops");
			SearchPattern2.NativeFieldInfoPtr_ignore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchPattern2>.NativeClassPtr, "ignore");
			SearchPattern2.NativeFieldInfoPtr_hasWildcard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchPattern2>.NativeClassPtr, "hasWildcard");
			SearchPattern2.NativeFieldInfoPtr_pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchPattern2>.NativeClassPtr, "pattern");
			SearchPattern2.NativeFieldInfoPtr_WildcardChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchPattern2>.NativeClassPtr, "WildcardChars");
			SearchPattern2.NativeFieldInfoPtr_InvalidChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchPattern2>.NativeClassPtr, "InvalidChars");
			SearchPattern2.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchPattern2>.NativeClassPtr, 100667031);
			SearchPattern2.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchPattern2>.NativeClassPtr, 100667032);
			SearchPattern2.NativeMethodInfoPtr_get_HasWildcard_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchPattern2>.NativeClassPtr, 100667033);
			SearchPattern2.NativeMethodInfoPtr_Compile_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchPattern2>.NativeClassPtr, 100667034);
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x00078E24 File Offset: 0x00077024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470055, XrefRangeEnd = 470058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SearchPattern2(string pattern)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SearchPattern2>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchPattern2.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x00078E70 File Offset: 0x00077070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470058, XrefRangeEnd = 470061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SearchPattern2(string pattern, bool ignore)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SearchPattern2>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchPattern2.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x060017C5 RID: 6085 RVA: 0x00078ECC File Offset: 0x000770CC
		public unsafe bool HasWildcard
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchPattern2.NativeMethodInfoPtr_get_HasWildcard_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x00078F08 File Offset: 0x00077108
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 470096, RefRangeEnd = 470100, XrefRangeStart = 470061, XrefRangeEnd = 470096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Compile(string pattern)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchPattern2.NativeMethodInfoPtr_Compile_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x0000A4DB File Offset: 0x000086DB
		public SearchPattern2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x00078F4C File Offset: 0x0007714C
		// (set) Token: 0x060017C9 RID: 6089 RVA: 0x0000A4E4 File Offset: 0x000086E4
		public unsafe SearchPattern2.Op ops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchPattern2.NativeFieldInfoPtr_ops);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SearchPattern2.Op>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchPattern2.NativeFieldInfoPtr_ops), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x00078F7C File Offset: 0x0007717C
		// (set) Token: 0x060017CB RID: 6091 RVA: 0x0000A503 File Offset: 0x00008703
		public unsafe bool ignore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchPattern2.NativeFieldInfoPtr_ignore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchPattern2.NativeFieldInfoPtr_ignore)) = value;
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x00078FA4 File Offset: 0x000771A4
		// (set) Token: 0x060017CD RID: 6093 RVA: 0x0000A51E File Offset: 0x0000871E
		public unsafe bool hasWildcard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchPattern2.NativeFieldInfoPtr_hasWildcard);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchPattern2.NativeFieldInfoPtr_hasWildcard)) = value;
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x00078FCC File Offset: 0x000771CC
		// (set) Token: 0x060017CF RID: 6095 RVA: 0x0000A539 File Offset: 0x00008739
		public unsafe string pattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchPattern2.NativeFieldInfoPtr_pattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchPattern2.NativeFieldInfoPtr_pattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x00078FF4 File Offset: 0x000771F4
		// (set) Token: 0x060017D1 RID: 6097 RVA: 0x0000A558 File Offset: 0x00008758
		public unsafe static Il2CppStructArray<char> WildcardChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SearchPattern2.NativeFieldInfoPtr_WildcardChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SearchPattern2.NativeFieldInfoPtr_WildcardChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x060017D2 RID: 6098 RVA: 0x0007901C File Offset: 0x0007721C
		// (set) Token: 0x060017D3 RID: 6099 RVA: 0x0000A56A File Offset: 0x0000876A
		public unsafe static Il2CppStructArray<char> InvalidChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SearchPattern2.NativeFieldInfoPtr_InvalidChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SearchPattern2.NativeFieldInfoPtr_InvalidChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001274 RID: 4724
		private static readonly IntPtr NativeFieldInfoPtr_ops;

		// Token: 0x04001275 RID: 4725
		private static readonly IntPtr NativeFieldInfoPtr_ignore;

		// Token: 0x04001276 RID: 4726
		private static readonly IntPtr NativeFieldInfoPtr_hasWildcard;

		// Token: 0x04001277 RID: 4727
		private static readonly IntPtr NativeFieldInfoPtr_pattern;

		// Token: 0x04001278 RID: 4728
		private static readonly IntPtr NativeFieldInfoPtr_WildcardChars;

		// Token: 0x04001279 RID: 4729
		private static readonly IntPtr NativeFieldInfoPtr_InvalidChars;

		// Token: 0x0400127A RID: 4730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400127B RID: 4731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x0400127C RID: 4732
		private static readonly IntPtr NativeMethodInfoPtr_get_HasWildcard_Public_get_Boolean_0;

		// Token: 0x0400127D RID: 4733
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Private_Void_String_0;

		// Token: 0x02000309 RID: 777
		public class Op : Object
		{
			// Token: 0x06002E59 RID: 11865 RVA: 0x000CB82C File Offset: 0x000C9A2C
			// Note: this type is marked as 'beforefieldinit'.
			static Op()
			{
				Il2CppClassPointerStore<SearchPattern2.Op>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SearchPattern2>.NativeClassPtr, "Op");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SearchPattern2.Op>.NativeClassPtr);
				SearchPattern2.Op.NativeFieldInfoPtr_Code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchPattern2.Op>.NativeClassPtr, "Code");
				SearchPattern2.Op.NativeFieldInfoPtr_Argument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchPattern2.Op>.NativeClassPtr, "Argument");
				SearchPattern2.Op.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchPattern2.Op>.NativeClassPtr, "Next");
				SearchPattern2.Op.NativeMethodInfoPtr__ctor_Public_Void_OpCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchPattern2.Op>.NativeClassPtr, 100667036);
			}

			// Token: 0x06002E5A RID: 11866 RVA: 0x000CB8A8 File Offset: 0x000C9AA8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 470052, RefRangeEnd = 470055, XrefRangeStart = 470049, XrefRangeEnd = 470052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Op(SearchPattern2.OpCode code)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SearchPattern2.Op>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref code;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchPattern2.Op.NativeMethodInfoPtr__ctor_Public_Void_OpCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002E5B RID: 11867 RVA: 0x00014B17 File Offset: 0x00012D17
			public Op(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E8D RID: 3725
			// (get) Token: 0x06002E5C RID: 11868 RVA: 0x000CB8F0 File Offset: 0x000C9AF0
			// (set) Token: 0x06002E5D RID: 11869 RVA: 0x00014B20 File Offset: 0x00012D20
			public unsafe SearchPattern2.OpCode Code
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchPattern2.Op.NativeFieldInfoPtr_Code);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchPattern2.Op.NativeFieldInfoPtr_Code)) = value;
				}
			}

			// Token: 0x17000E8E RID: 3726
			// (get) Token: 0x06002E5E RID: 11870 RVA: 0x000CB918 File Offset: 0x000C9B18
			// (set) Token: 0x06002E5F RID: 11871 RVA: 0x00014B3B File Offset: 0x00012D3B
			public unsafe string Argument
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchPattern2.Op.NativeFieldInfoPtr_Argument);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchPattern2.Op.NativeFieldInfoPtr_Argument), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000E8F RID: 3727
			// (get) Token: 0x06002E60 RID: 11872 RVA: 0x000CB940 File Offset: 0x000C9B40
			// (set) Token: 0x06002E61 RID: 11873 RVA: 0x00014B5A File Offset: 0x00012D5A
			public unsafe SearchPattern2.Op Next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchPattern2.Op.NativeFieldInfoPtr_Next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SearchPattern2.Op>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchPattern2.Op.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400245F RID: 9311
			private static readonly IntPtr NativeFieldInfoPtr_Code;

			// Token: 0x04002460 RID: 9312
			private static readonly IntPtr NativeFieldInfoPtr_Argument;

			// Token: 0x04002461 RID: 9313
			private static readonly IntPtr NativeFieldInfoPtr_Next;

			// Token: 0x04002462 RID: 9314
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_OpCode_0;
		}

		// Token: 0x0200030A RID: 778
		public enum OpCode
		{
			// Token: 0x04002464 RID: 9316
			ExactString,
			// Token: 0x04002465 RID: 9317
			AnyChar,
			// Token: 0x04002466 RID: 9318
			AnyString,
			// Token: 0x04002467 RID: 9319
			End,
			// Token: 0x04002468 RID: 9320
			True
		}
	}
}

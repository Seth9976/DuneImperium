using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000086 RID: 134
	public class NameTable : XmlNameTable
	{
		// Token: 0x06000F6E RID: 3950 RVA: 0x000599F4 File Offset: 0x00057BF4
		// Note: this type is marked as 'beforefieldinit'.
		static NameTable()
		{
			Il2CppClassPointerStore<NameTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "NameTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameTable>.NativeClassPtr);
			NameTable.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameTable>.NativeClassPtr, "entries");
			NameTable.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameTable>.NativeClassPtr, "count");
			NameTable.NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameTable>.NativeClassPtr, "mask");
			NameTable.NativeFieldInfoPtr_hashCodeRandomizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameTable>.NativeClassPtr, "hashCodeRandomizer");
			NameTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTable>.NativeClassPtr, 100665837);
			NameTable.NativeMethodInfoPtr_Add_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTable>.NativeClassPtr, 100665838);
			NameTable.NativeMethodInfoPtr_Add_Public_Virtual_String_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTable>.NativeClassPtr, 100665839);
			NameTable.NativeMethodInfoPtr_Get_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTable>.NativeClassPtr, 100665840);
			NameTable.NativeMethodInfoPtr_AddEntry_Private_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTable>.NativeClassPtr, 100665841);
			NameTable.NativeMethodInfoPtr_Grow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTable>.NativeClassPtr, 100665842);
			NameTable.NativeMethodInfoPtr_TextEquals_Private_Static_Boolean_String_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTable>.NativeClassPtr, 100665843);
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00059B00 File Offset: 0x00057D00
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 376302, RefRangeEnd = 376317, XrefRangeStart = 376296, XrefRangeEnd = 376302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00059B3C File Offset: 0x00057D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376317, XrefRangeEnd = 376322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string Add(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameTable.NativeMethodInfoPtr_Add_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x00059B90 File Offset: 0x00057D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376322, XrefRangeEnd = 376327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string Add(Il2CppStructArray<char> key, int start, int len)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameTable.NativeMethodInfoPtr_Add_Public_Virtual_String_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00059C00 File Offset: 0x00057E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376327, XrefRangeEnd = 376331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string Get(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameTable.NativeMethodInfoPtr_Get_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00059C54 File Offset: 0x00057E54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 376347, RefRangeEnd = 376349, XrefRangeStart = 376331, XrefRangeEnd = 376347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string AddEntry(string str, int hashCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameTable.NativeMethodInfoPtr_AddEntry_Private_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00059CAC File Offset: 0x00057EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376349, XrefRangeEnd = 376357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Grow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameTable.NativeMethodInfoPtr_Grow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00059CE0 File Offset: 0x00057EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376357, XrefRangeEnd = 376359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TextEquals(string str1, Il2CppStructArray<char> str2, int str2Start, int str2Length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(str2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref str2Start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref str2Length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameTable.NativeMethodInfoPtr_TextEquals_Private_Static_Boolean_String_Il2CppStructArray_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00006FE0 File Offset: 0x000051E0
		public NameTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000F77 RID: 3959 RVA: 0x00059D50 File Offset: 0x00057F50
		// (set) Token: 0x06000F78 RID: 3960 RVA: 0x00006FE9 File Offset: 0x000051E9
		public unsafe Il2CppReferenceArray<NameTable.Entry> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NameTable.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x00059D80 File Offset: 0x00057F80
		// (set) Token: 0x06000F7A RID: 3962 RVA: 0x00007008 File Offset: 0x00005208
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x00059DA8 File Offset: 0x00057FA8
		// (set) Token: 0x06000F7C RID: 3964 RVA: 0x00007023 File Offset: 0x00005223
		public unsafe int mask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.NativeFieldInfoPtr_mask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.NativeFieldInfoPtr_mask)) = value;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000F7D RID: 3965 RVA: 0x00059DD0 File Offset: 0x00057FD0
		// (set) Token: 0x06000F7E RID: 3966 RVA: 0x0000703E File Offset: 0x0000523E
		public unsafe int hashCodeRandomizer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.NativeFieldInfoPtr_hashCodeRandomizer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.NativeFieldInfoPtr_hashCodeRandomizer)) = value;
			}
		}

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeFieldInfoPtr_mask;

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeFieldInfoPtr_hashCodeRandomizer;

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_String_String_0;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_String_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_String_String_0;

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeMethodInfoPtr_AddEntry_Private_String_String_Int32_0;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeMethodInfoPtr_Grow_Private_Void_0;

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeMethodInfoPtr_TextEquals_Private_Static_Boolean_String_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x0200023E RID: 574
		public class Entry : Object
		{
			// Token: 0x06003071 RID: 12401 RVA: 0x000DA5E4 File Offset: 0x000D87E4
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<NameTable.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NameTable>.NativeClassPtr, "Entry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameTable.Entry>.NativeClassPtr);
				NameTable.Entry.NativeFieldInfoPtr_str = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameTable.Entry>.NativeClassPtr, "str");
				NameTable.Entry.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameTable.Entry>.NativeClassPtr, "hashCode");
				NameTable.Entry.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameTable.Entry>.NativeClassPtr, "next");
				NameTable.Entry.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTable.Entry>.NativeClassPtr, 100665844);
			}

			// Token: 0x06003072 RID: 12402 RVA: 0x000DA660 File Offset: 0x000D8860
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 376295, RefRangeEnd = 376296, XrefRangeStart = 376292, XrefRangeEnd = 376295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry(string str, int hashCode, NameTable.Entry next)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameTable.Entry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameTable.Entry.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003073 RID: 12403 RVA: 0x000144A8 File Offset: 0x000126A8
			public Entry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700104C RID: 4172
			// (get) Token: 0x06003074 RID: 12404 RVA: 0x000DA6CC File Offset: 0x000D88CC
			// (set) Token: 0x06003075 RID: 12405 RVA: 0x000144B1 File Offset: 0x000126B1
			public unsafe string str
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.Entry.NativeFieldInfoPtr_str);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.Entry.NativeFieldInfoPtr_str), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700104D RID: 4173
			// (get) Token: 0x06003076 RID: 12406 RVA: 0x000DA6F4 File Offset: 0x000D88F4
			// (set) Token: 0x06003077 RID: 12407 RVA: 0x000144D0 File Offset: 0x000126D0
			public unsafe int hashCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.Entry.NativeFieldInfoPtr_hashCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.Entry.NativeFieldInfoPtr_hashCode)) = value;
				}
			}

			// Token: 0x1700104E RID: 4174
			// (get) Token: 0x06003078 RID: 12408 RVA: 0x000DA71C File Offset: 0x000D891C
			// (set) Token: 0x06003079 RID: 12409 RVA: 0x000144EB File Offset: 0x000126EB
			public unsafe NameTable.Entry next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.Entry.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NameTable.Entry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.Entry.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400255F RID: 9567
			private static readonly IntPtr NativeFieldInfoPtr_str;

			// Token: 0x04002560 RID: 9568
			private static readonly IntPtr NativeFieldInfoPtr_hashCode;

			// Token: 0x04002561 RID: 9569
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x04002562 RID: 9570
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Entry_0;
		}
	}
}

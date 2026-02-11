using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json
{
	// Token: 0x0200000F RID: 15
	public class DefaultJsonNameTable : JsonNameTable
	{
		// Token: 0x06000027 RID: 39 RVA: 0x0001241C File Offset: 0x0001061C
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultJsonNameTable()
		{
			Il2CppClassPointerStore<DefaultJsonNameTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "DefaultJsonNameTable");
			DefaultJsonNameTable.NativeFieldInfoPtr_HashCodeRandomizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultJsonNameTable>.NativeClassPtr, "HashCodeRandomizer");
			DefaultJsonNameTable.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultJsonNameTable>.NativeClassPtr, "_count");
			DefaultJsonNameTable.NativeFieldInfoPtr__entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultJsonNameTable>.NativeClassPtr, "_entries");
			DefaultJsonNameTable.NativeFieldInfoPtr__mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultJsonNameTable>.NativeClassPtr, "_mask");
			DefaultJsonNameTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultJsonNameTable>.NativeClassPtr, 100663310);
			DefaultJsonNameTable.NativeMethodInfoPtr_Get_Public_Virtual_String_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultJsonNameTable>.NativeClassPtr, 100663311);
			DefaultJsonNameTable.NativeMethodInfoPtr_Add_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultJsonNameTable>.NativeClassPtr, 100663312);
			DefaultJsonNameTable.NativeMethodInfoPtr_AddEntry_Private_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultJsonNameTable>.NativeClassPtr, 100663313);
			DefaultJsonNameTable.NativeMethodInfoPtr_Grow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultJsonNameTable>.NativeClassPtr, 100663314);
			DefaultJsonNameTable.NativeMethodInfoPtr_TextEquals_Private_Static_Boolean_String_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultJsonNameTable>.NativeClassPtr, 100663315);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0001250C File Offset: 0x0001070C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 726943, RefRangeEnd = 726944, XrefRangeStart = 726938, XrefRangeEnd = 726943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultJsonNameTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultJsonNameTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultJsonNameTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00012548 File Offset: 0x00010748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726944, XrefRangeEnd = 726954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string Get(Il2CppStructArray<char> key, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultJsonNameTable.NativeMethodInfoPtr_Get_Public_Virtual_String_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000125B8 File Offset: 0x000107B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 726963, RefRangeEnd = 726964, XrefRangeStart = 726954, XrefRangeEnd = 726963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Add(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultJsonNameTable.NativeMethodInfoPtr_Add_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00012600 File Offset: 0x00010800
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 726981, RefRangeEnd = 726982, XrefRangeStart = 726964, XrefRangeEnd = 726981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultJsonNameTable.NativeMethodInfoPtr_AddEntry_Private_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00012658 File Offset: 0x00010858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726982, XrefRangeEnd = 726991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Grow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultJsonNameTable.NativeMethodInfoPtr_Grow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0001268C File Offset: 0x0001088C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultJsonNameTable.NativeMethodInfoPtr_TextEquals_Private_Static_Boolean_String_Il2CppStructArray_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000222E File Offset: 0x0000042E
		public DefaultJsonNameTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000126FC File Offset: 0x000108FC
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002237 File Offset: 0x00000437
		public unsafe static int HashCodeRandomizer
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DefaultJsonNameTable.NativeFieldInfoPtr_HashCodeRandomizer, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultJsonNameTable.NativeFieldInfoPtr_HashCodeRandomizer, (void*)(&value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00012718 File Offset: 0x00010918
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00002245 File Offset: 0x00000445
		public unsafe int _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultJsonNameTable.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultJsonNameTable.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00012740 File Offset: 0x00010940
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00002260 File Offset: 0x00000460
		public unsafe Il2CppReferenceArray<DefaultJsonNameTable.Entry> _entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultJsonNameTable.NativeFieldInfoPtr__entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DefaultJsonNameTable.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultJsonNameTable.NativeFieldInfoPtr__entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00012770 File Offset: 0x00010970
		// (set) Token: 0x06000036 RID: 54 RVA: 0x0000227F File Offset: 0x0000047F
		public unsafe int _mask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultJsonNameTable.NativeFieldInfoPtr__mask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultJsonNameTable.NativeFieldInfoPtr__mask)) = value;
			}
		}

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr_HashCodeRandomizer;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr__entries;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr__mask;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_String_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_String_String_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_AddEntry_Private_String_String_Int32_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_Grow_Private_Void_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_TextEquals_Private_Static_Boolean_String_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x02000112 RID: 274
		public class Entry : Object
		{
			// Token: 0x06001676 RID: 5750 RVA: 0x000783A4 File Offset: 0x000765A4
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<DefaultJsonNameTable.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultJsonNameTable>.NativeClassPtr, "Entry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultJsonNameTable.Entry>.NativeClassPtr);
				DefaultJsonNameTable.Entry.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultJsonNameTable.Entry>.NativeClassPtr, "Value");
				DefaultJsonNameTable.Entry.NativeFieldInfoPtr_HashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultJsonNameTable.Entry>.NativeClassPtr, "HashCode");
				DefaultJsonNameTable.Entry.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultJsonNameTable.Entry>.NativeClassPtr, "Next");
				DefaultJsonNameTable.Entry.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultJsonNameTable.Entry>.NativeClassPtr, 100663316);
			}

			// Token: 0x06001677 RID: 5751 RVA: 0x00078420 File Offset: 0x00076620
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 376295, RefRangeEnd = 376296, XrefRangeStart = 376295, XrefRangeEnd = 376296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry(string value, int hashCode, DefaultJsonNameTable.Entry next)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultJsonNameTable.Entry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultJsonNameTable.Entry.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001678 RID: 5752 RVA: 0x00008C1C File Offset: 0x00006E1C
			public Entry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005E6 RID: 1510
			// (get) Token: 0x06001679 RID: 5753 RVA: 0x0007848C File Offset: 0x0007668C
			// (set) Token: 0x0600167A RID: 5754 RVA: 0x00008C25 File Offset: 0x00006E25
			public unsafe string Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultJsonNameTable.Entry.NativeFieldInfoPtr_Value);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultJsonNameTable.Entry.NativeFieldInfoPtr_Value), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170005E7 RID: 1511
			// (get) Token: 0x0600167B RID: 5755 RVA: 0x000784B4 File Offset: 0x000766B4
			// (set) Token: 0x0600167C RID: 5756 RVA: 0x00008C44 File Offset: 0x00006E44
			public unsafe int HashCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultJsonNameTable.Entry.NativeFieldInfoPtr_HashCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultJsonNameTable.Entry.NativeFieldInfoPtr_HashCode)) = value;
				}
			}

			// Token: 0x170005E8 RID: 1512
			// (get) Token: 0x0600167D RID: 5757 RVA: 0x000784DC File Offset: 0x000766DC
			// (set) Token: 0x0600167E RID: 5758 RVA: 0x00008C5F File Offset: 0x00006E5F
			public unsafe DefaultJsonNameTable.Entry Next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultJsonNameTable.Entry.NativeFieldInfoPtr_Next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultJsonNameTable.Entry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultJsonNameTable.Entry.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400121B RID: 4635
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x0400121C RID: 4636
			private static readonly IntPtr NativeFieldInfoPtr_HashCode;

			// Token: 0x0400121D RID: 4637
			private static readonly IntPtr NativeFieldInfoPtr_Next;

			// Token: 0x0400121E RID: 4638
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Entry_0;
		}
	}
}

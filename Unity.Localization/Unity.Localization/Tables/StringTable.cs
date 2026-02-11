using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Localization.Tables
{
	// Token: 0x0200002B RID: 43
	public class StringTable : DetailedLocalizationTable<StringTableEntry>
	{
		// Token: 0x060002A2 RID: 674 RVA: 0x000138E8 File Offset: 0x00011AE8
		// Note: this type is marked as 'beforefieldinit'.
		static StringTable()
		{
			Il2CppClassPointerStore<StringTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Tables", "StringTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringTable>.NativeClassPtr);
			StringTable.NativeMethodInfoPtr_GenerateCharacterSet_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTable>.NativeClassPtr, 100663780);
			StringTable.NativeMethodInfoPtr_CollectLiteralCharacters_Internal_IEnumerable_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTable>.NativeClassPtr, 100663781);
			StringTable.NativeMethodInfoPtr_CreateTableEntry_Public_Virtual_StringTableEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTable>.NativeClassPtr, 100663782);
			StringTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTable>.NativeClassPtr, 100663783);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00013968 File Offset: 0x00011B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067809, XrefRangeEnd = 1067834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GenerateCharacterSet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTable.NativeMethodInfoPtr_GenerateCharacterSet_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x000139A0 File Offset: 0x00011BA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1067887, RefRangeEnd = 1067888, XrefRangeStart = 1067834, XrefRangeEnd = 1067887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<char> CollectLiteralCharacters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTable.NativeMethodInfoPtr_CollectLiteralCharacters_Internal_IEnumerable_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<char>>(intPtr3) : null;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x000139E0 File Offset: 0x00011BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067888, XrefRangeEnd = 1067903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StringTableEntry CreateTableEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringTable.NativeMethodInfoPtr_CreateTableEntry_Public_Virtual_StringTableEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringTableEntry>(intPtr3) : null;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00013A2C File Offset: 0x00011C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067903, XrefRangeEnd = 1067906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002F0D File Offset: 0x0000110D
		public StringTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_GenerateCharacterSet_Public_String_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr_CollectLiteralCharacters_Internal_IEnumerable_1_Char_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_CreateTableEntry_Public_Virtual_StringTableEntry_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000129 RID: 297
		[ObfuscatedName("UnityEngine.Localization.Tables.StringTable+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06000D3B RID: 3387 RVA: 0x0003AE00 File Offset: 0x00039000
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StringTable.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StringTable>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringTable.__c>.NativeClassPtr);
				StringTable.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringTable.__c>.NativeClassPtr, "<>9");
				StringTable.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringTable.__c>.NativeClassPtr, "<>9__0_0");
				StringTable.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTable.__c>.NativeClassPtr, 100663785);
				StringTable.__c.NativeMethodInfoPtr__GenerateCharacterSet_b__0_0_Internal_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTable.__c>.NativeClassPtr, 100663786);
			}

			// Token: 0x06000D3C RID: 3388 RVA: 0x0003AE7C File Offset: 0x0003907C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringTable.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTable.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D3D RID: 3389 RVA: 0x0003AEB8 File Offset: 0x000390B8
			[CallerCount(0)]
			public unsafe char _GenerateCharacterSet_b__0_0(char c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref c;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTable.__c.NativeMethodInfoPtr__GenerateCharacterSet_b__0_0_Internal_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000D3E RID: 3390 RVA: 0x000078F1 File Offset: 0x00005AF1
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000392 RID: 914
			// (get) Token: 0x06000D3F RID: 3391 RVA: 0x0003AF04 File Offset: 0x00039104
			// (set) Token: 0x06000D40 RID: 3392 RVA: 0x000078FA File Offset: 0x00005AFA
			public unsafe static StringTable.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StringTable.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringTable.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StringTable.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000393 RID: 915
			// (get) Token: 0x06000D41 RID: 3393 RVA: 0x0003AF2C File Offset: 0x0003912C
			// (set) Token: 0x06000D42 RID: 3394 RVA: 0x0000790C File Offset: 0x00005B0C
			public unsafe static Func<char, char> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StringTable.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<char, char>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StringTable.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400092D RID: 2349
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400092E RID: 2350
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x0400092F RID: 2351
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000930 RID: 2352
			private static readonly IntPtr NativeMethodInfoPtr__GenerateCharacterSet_b__0_0_Internal_Char_Char_0;
		}
	}
}

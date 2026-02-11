using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;

namespace UnityEngine.Localization
{
	// Token: 0x02000015 RID: 21
	[Serializable]
	public class LocalizedStringTable : LocalizedTable<StringTable, StringTableEntry>
	{
		// Token: 0x06000125 RID: 293 RVA: 0x0000D734 File Offset: 0x0000B934
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedStringTable()
		{
			Il2CppClassPointerStore<LocalizedStringTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "LocalizedStringTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedStringTable>.NativeClassPtr);
			LocalizedStringTable.NativeMethodInfoPtr_get_Database_Protected_Virtual_get_LocalizedDatabase_2_StringTable_StringTableEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringTable>.NativeClassPtr, 100663530);
			LocalizedStringTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringTable>.NativeClassPtr, 100663531);
			LocalizedStringTable.NativeMethodInfoPtr__ctor_Public_Void_TableReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringTable>.NativeClassPtr, 100663532);
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000126 RID: 294 RVA: 0x0000D7A0 File Offset: 0x0000B9A0
		public unsafe override LocalizedDatabase<StringTable, StringTableEntry> Database
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066245, XrefRangeEnd = 1066246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedStringTable.NativeMethodInfoPtr_get_Database_Protected_Virtual_get_LocalizedDatabase_2_StringTable_StringTableEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedDatabase<StringTable, StringTableEntry>>(intPtr3) : null;
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000D7EC File Offset: 0x0000B9EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066246, XrefRangeEnd = 1066249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedStringTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedStringTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000D828 File Offset: 0x0000BA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066249, XrefRangeEnd = 1066255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedStringTable(TableReference tableReference)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedStringTable>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringTable.NativeMethodInfoPtr__ctor_Public_Void_TableReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000027BE File Offset: 0x000009BE
		public LocalizedStringTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_get_Database_Protected_Virtual_get_LocalizedDatabase_2_StringTable_StringTableEntry_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TableReference_0;
	}
}

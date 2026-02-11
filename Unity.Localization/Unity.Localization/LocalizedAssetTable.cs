using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;

namespace UnityEngine.Localization
{
	// Token: 0x02000012 RID: 18
	[Serializable]
	public class LocalizedAssetTable : LocalizedTable<AssetTable, AssetTableEntry>
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x0000B904 File Offset: 0x00009B04
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedAssetTable()
		{
			Il2CppClassPointerStore<LocalizedAssetTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "LocalizedAssetTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedAssetTable>.NativeClassPtr);
			LocalizedAssetTable.NativeMethodInfoPtr_get_Database_Protected_Virtual_get_LocalizedDatabase_2_AssetTable_AssetTableEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetTable>.NativeClassPtr, 100663428);
			LocalizedAssetTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetTable>.NativeClassPtr, 100663429);
			LocalizedAssetTable.NativeMethodInfoPtr__ctor_Public_Void_TableReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetTable>.NativeClassPtr, 100663430);
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0000B970 File Offset: 0x00009B70
		public unsafe override LocalizedDatabase<AssetTable, AssetTableEntry> Database
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065557, XrefRangeEnd = 1065558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedAssetTable.NativeMethodInfoPtr_get_Database_Protected_Virtual_get_LocalizedDatabase_2_AssetTable_AssetTableEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedDatabase<AssetTable, AssetTableEntry>>(intPtr3) : null;
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000B9BC File Offset: 0x00009BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065558, XrefRangeEnd = 1065561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedAssetTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedAssetTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAssetTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000B9F8 File Offset: 0x00009BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065561, XrefRangeEnd = 1065567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedAssetTable(TableReference tableReference)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedAssetTable>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAssetTable.NativeMethodInfoPtr__ctor_Public_Void_TableReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002529 File Offset: 0x00000729
		public LocalizedAssetTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_get_Database_Protected_Virtual_get_LocalizedDatabase_2_AssetTable_AssetTableEntry_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TableReference_0;
	}
}

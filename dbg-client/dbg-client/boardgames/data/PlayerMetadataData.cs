using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.data
{
	// Token: 0x0200018C RID: 396
	public class PlayerMetadataData : DataComponent
	{
		// Token: 0x06001185 RID: 4485 RVA: 0x0005531C File Offset: 0x0005351C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerMetadataData()
		{
			Il2CppClassPointerStore<PlayerMetadataData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "PlayerMetadataData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMetadataData>.NativeClassPtr);
			PlayerMetadataData.NativeFieldInfoPtr__Metadata_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMetadataData>.NativeClassPtr, "<Metadata>k__BackingField");
			PlayerMetadataData.NativeMethodInfoPtr_get_Metadata_Public_get_IReadOnlyDictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMetadataData>.NativeClassPtr, 100665755);
			PlayerMetadataData.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyDictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMetadataData>.NativeClassPtr, 100665756);
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001186 RID: 4486 RVA: 0x00055388 File Offset: 0x00053588
		public unsafe IReadOnlyDictionary<string, string> Metadata
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMetadataData.NativeMethodInfoPtr_get_Metadata_Public_get_IReadOnlyDictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x000553C8 File Offset: 0x000535C8
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerMetadataData(IReadOnlyDictionary<string, string> metadata)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMetadataData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(metadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMetadataData.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyDictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x0000A664 File Offset: 0x00008864
		public PlayerMetadataData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x00055414 File Offset: 0x00053614
		// (set) Token: 0x0600118A RID: 4490 RVA: 0x0000A66D File Offset: 0x0000886D
		public unsafe IReadOnlyDictionary<string, string> _Metadata_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMetadataData.NativeFieldInfoPtr__Metadata_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMetadataData.NativeFieldInfoPtr__Metadata_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AB4 RID: 2740
		private static readonly IntPtr NativeFieldInfoPtr__Metadata_k__BackingField;

		// Token: 0x04000AB5 RID: 2741
		private static readonly IntPtr NativeMethodInfoPtr_get_Metadata_Public_get_IReadOnlyDictionary_2_String_String_0;

		// Token: 0x04000AB6 RID: 2742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyDictionary_2_String_String_0;
	}
}

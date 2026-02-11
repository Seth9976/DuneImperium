using System;
using boardgames.utils;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.data
{
	// Token: 0x0200017F RID: 383
	public class ChallengeDifficultyData : VersionedDataComponent
	{
		// Token: 0x060010D1 RID: 4305 RVA: 0x00052AF4 File Offset: 0x00050CF4
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengeDifficultyData()
		{
			Il2CppClassPointerStore<ChallengeDifficultyData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "ChallengeDifficultyData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeDifficultyData>.NativeClassPtr);
			ChallengeDifficultyData.NativeFieldInfoPtr_Difficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeDifficultyData>.NativeClassPtr, "Difficulty");
			ChallengeDifficultyData.NativeMethodInfoPtr__ctor_Public_Void_ChallengeDifficulties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeDifficultyData>.NativeClassPtr, 100665654);
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x00052B4C File Offset: 0x00050D4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 514331, RefRangeEnd = 514333, XrefRangeStart = 514330, XrefRangeEnd = 514331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChallengeDifficultyData(DBGConstants.ChallengeDifficulties difficulty)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeDifficultyData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref difficulty;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeDifficultyData.NativeMethodInfoPtr__ctor_Public_Void_ChallengeDifficulties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x0000A1CB File Offset: 0x000083CB
		public ChallengeDifficultyData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x060010D4 RID: 4308 RVA: 0x00052B94 File Offset: 0x00050D94
		// (set) Token: 0x060010D5 RID: 4309 RVA: 0x0000A1D4 File Offset: 0x000083D4
		public unsafe DBGConstants.ChallengeDifficulties Difficulty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeDifficultyData.NativeFieldInfoPtr_Difficulty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeDifficultyData.NativeFieldInfoPtr_Difficulty)) = value;
			}
		}

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeFieldInfoPtr_Difficulty;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ChallengeDifficulties_0;
	}
}

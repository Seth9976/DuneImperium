using System;
using dbgclient.dataProviders;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using worm.canis.match;

namespace worm.dataProviders
{
	// Token: 0x02000292 RID: 658
	public class WormDailyChallengeProvider : DailyChallengeProvider<WormMatchInitData>
	{
		// Token: 0x06001AA9 RID: 6825 RVA: 0x0006A408 File Offset: 0x00068608
		// Note: this type is marked as 'beforefieldinit'.
		static WormDailyChallengeProvider()
		{
			Il2CppClassPointerStore<WormDailyChallengeProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.dataProviders", "WormDailyChallengeProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDailyChallengeProvider>.NativeClassPtr);
			WormDailyChallengeProvider.NativeMethodInfoPtr_GetPromptData_Public_Virtual_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDailyChallengeProvider>.NativeClassPtr, 100667210);
			WormDailyChallengeProvider.NativeMethodInfoPtr_MakeInitialPlayerMetadata_Public_Virtual_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDailyChallengeProvider>.NativeClassPtr, 100667211);
			WormDailyChallengeProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDailyChallengeProvider>.NativeClassPtr, 100667212);
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x0006A474 File Offset: 0x00068674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723889, XrefRangeEnd = 723940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DataComposition GetPromptData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDailyChallengeProvider.NativeMethodInfoPtr_GetPromptData_Public_Virtual_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x0006A4C0 File Offset: 0x000686C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723940, XrefRangeEnd = 723961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Dictionary<string, string> MakeInitialPlayerMetadata()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDailyChallengeProvider.NativeMethodInfoPtr_MakeInitialPlayerMetadata_Public_Virtual_Dictionary_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x0006A50C File Offset: 0x0006870C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723961, XrefRangeEnd = 723964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormDailyChallengeProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDailyChallengeProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDailyChallengeProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x0000F814 File Offset: 0x0000DA14
		public WormDailyChallengeProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F69 RID: 3945
		private static readonly IntPtr NativeMethodInfoPtr_GetPromptData_Public_Virtual_DataComposition_0;

		// Token: 0x04000F6A RID: 3946
		private static readonly IntPtr NativeMethodInfoPtr_MakeInitialPlayerMetadata_Public_Virtual_Dictionary_2_String_String_0;

		// Token: 0x04000F6B RID: 3947
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

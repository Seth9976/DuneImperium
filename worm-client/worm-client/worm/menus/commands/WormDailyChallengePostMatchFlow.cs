using System;
using boardgames.match.data;
using boardgames.menus.commands;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.menus.commands
{
	// Token: 0x020000A6 RID: 166
	public class WormDailyChallengePostMatchFlow : RunDailyChallengePostMatchFlow
	{
		// Token: 0x06000674 RID: 1652 RVA: 0x0002C4A0 File Offset: 0x0002A6A0
		// Note: this type is marked as 'beforefieldinit'.
		static WormDailyChallengePostMatchFlow()
		{
			Il2CppClassPointerStore<WormDailyChallengePostMatchFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.commands", "WormDailyChallengePostMatchFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDailyChallengePostMatchFlow>.NativeClassPtr);
			WormDailyChallengePostMatchFlow.NativeMethodInfoPtr__ctor_Public_Void_GameOptionsData_Dictionary_2_LocalizableTextVariables_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDailyChallengePostMatchFlow>.NativeClassPtr, 100664199);
			WormDailyChallengePostMatchFlow.NativeMethodInfoPtr_GetScore_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDailyChallengePostMatchFlow>.NativeClassPtr, 100664200);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0002C4F8 File Offset: 0x0002A6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696313, XrefRangeEnd = 696314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormDailyChallengePostMatchFlow(GameOptionsData gameOptions, Dictionary<LocalizableTextVariables, int> dailyChallengeScore)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDailyChallengePostMatchFlow>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameOptions);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dailyChallengeScore);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDailyChallengePostMatchFlow.NativeMethodInfoPtr__ctor_Public_Void_GameOptionsData_Dictionary_2_LocalizableTextVariables_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0002C558 File Offset: 0x0002A758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696314, XrefRangeEnd = 696329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetScore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDailyChallengePostMatchFlow.NativeMethodInfoPtr_GetScore_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x000053C6 File Offset: 0x000035C6
		public WormDailyChallengePostMatchFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameOptionsData_Dictionary_2_LocalizableTextVariables_Int32_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr_GetScore_Protected_Virtual_Int32_0;
	}
}

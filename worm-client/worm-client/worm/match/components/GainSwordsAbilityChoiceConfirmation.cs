using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.match.components
{
	// Token: 0x020001B1 RID: 433
	public class GainSwordsAbilityChoiceConfirmation : AbilityChoiceConfirmation
	{
		// Token: 0x0600131E RID: 4894 RVA: 0x0005220C File Offset: 0x0005040C
		// Note: this type is marked as 'beforefieldinit'.
		static GainSwordsAbilityChoiceConfirmation()
		{
			Il2CppClassPointerStore<GainSwordsAbilityChoiceConfirmation>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "GainSwordsAbilityChoiceConfirmation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainSwordsAbilityChoiceConfirmation>.NativeClassPtr);
			GainSwordsAbilityChoiceConfirmation.NativeMethodInfoPtr_get_ConfirmationPromptText_Public_Virtual_get_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSwordsAbilityChoiceConfirmation>.NativeClassPtr, 100665914);
			GainSwordsAbilityChoiceConfirmation.NativeMethodInfoPtr_RequiresConfirmation_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSwordsAbilityChoiceConfirmation>.NativeClassPtr, 100665915);
			GainSwordsAbilityChoiceConfirmation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSwordsAbilityChoiceConfirmation>.NativeClassPtr, 100665916);
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x0600131F RID: 4895 RVA: 0x00052278 File Offset: 0x00050478
		public unsafe override LocalizedString ConfirmationPromptText
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712752, XrefRangeEnd = 712755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainSwordsAbilityChoiceConfirmation.NativeMethodInfoPtr_get_ConfirmationPromptText_Public_Virtual_get_LocalizedString_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr3) : null;
			}
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x000522C4 File Offset: 0x000504C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712755, XrefRangeEnd = 712768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool RequiresConfirmation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainSwordsAbilityChoiceConfirmation.NativeMethodInfoPtr_RequiresConfirmation_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x0005230C File Offset: 0x0005050C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainSwordsAbilityChoiceConfirmation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainSwordsAbilityChoiceConfirmation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSwordsAbilityChoiceConfirmation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x0000BE1F File Offset: 0x0000A01F
		public GainSwordsAbilityChoiceConfirmation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfirmationPromptText_Public_Virtual_get_LocalizedString_0;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeMethodInfoPtr_RequiresConfirmation_Public_Virtual_Boolean_0;

		// Token: 0x04000B14 RID: 2836
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

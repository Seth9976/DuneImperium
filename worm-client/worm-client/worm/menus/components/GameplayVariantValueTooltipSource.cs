using System;
using boardgames.menus.behaviours;
using boardgames.menus.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.menus.components
{
	// Token: 0x0200009A RID: 154
	public class GameplayVariantValueTooltipSource : ConfigureGameOptionValueTooltipSource
	{
		// Token: 0x0600060F RID: 1551 RVA: 0x0002B294 File Offset: 0x00029494
		// Note: this type is marked as 'beforefieldinit'.
		static GameplayVariantValueTooltipSource()
		{
			Il2CppClassPointerStore<GameplayVariantValueTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.components", "GameplayVariantValueTooltipSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayVariantValueTooltipSource>.NativeClassPtr);
			GameplayVariantValueTooltipSource.NativeFieldInfoPtr_immoOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayVariantValueTooltipSource>.NativeClassPtr, "immoOption");
			GameplayVariantValueTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Protected_Virtual_String_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayVariantValueTooltipSource>.NativeClassPtr, 100664162);
			GameplayVariantValueTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayVariantValueTooltipSource>.NativeClassPtr, 100664163);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0002B300 File Offset: 0x00029500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695989, XrefRangeEnd = 696012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetLocalizedTooltip(IConfigureGameOptions.Option gameOption)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameOption);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameplayVariantValueTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Protected_Virtual_String_Option_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0002B354 File Offset: 0x00029554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696012, XrefRangeEnd = 696013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameplayVariantValueTooltipSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayVariantValueTooltipSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayVariantValueTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00005094 File Offset: 0x00003294
		public GameplayVariantValueTooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x0002B390 File Offset: 0x00029590
		// (set) Token: 0x06000614 RID: 1556 RVA: 0x0000509D File Offset: 0x0000329D
		public unsafe IConfigureGameOptions.Option immoOption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayVariantValueTooltipSource.NativeFieldInfoPtr_immoOption);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigureGameOptions.Option>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayVariantValueTooltipSource.NativeFieldInfoPtr_immoOption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeFieldInfoPtr_immoOption;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Protected_Virtual_String_Option_0;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

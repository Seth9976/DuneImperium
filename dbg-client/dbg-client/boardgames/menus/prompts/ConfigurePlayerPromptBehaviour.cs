using System;
using dwd.core.data.composition;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.menus.prompts
{
	// Token: 0x020001CA RID: 458
	public class ConfigurePlayerPromptBehaviour : PromptBehaviour<ConfigurePlayerPrompt>
	{
		// Token: 0x060014D3 RID: 5331 RVA: 0x00061180 File Offset: 0x0005F380
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigurePlayerPromptBehaviour()
		{
			Il2CppClassPointerStore<ConfigurePlayerPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "ConfigurePlayerPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurePlayerPromptBehaviour>.NativeClassPtr);
			ConfigurePlayerPromptBehaviour.NativeMethodInfoPtr_Event_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerPromptBehaviour>.NativeClassPtr, 100666365);
			ConfigurePlayerPromptBehaviour.NativeMethodInfoPtr_Event_Confirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerPromptBehaviour>.NativeClassPtr, 100666366);
			ConfigurePlayerPromptBehaviour.NativeMethodInfoPtr_Event_SelectAvatar_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerPromptBehaviour>.NativeClassPtr, 100666367);
			ConfigurePlayerPromptBehaviour.NativeMethodInfoPtr_Event_SelectColor_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerPromptBehaviour>.NativeClassPtr, 100666368);
			ConfigurePlayerPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurePlayerPromptBehaviour>.NativeClassPtr, 100666369);
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x00061214 File Offset: 0x0005F414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521474, XrefRangeEnd = 521483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerPromptBehaviour.NativeMethodInfoPtr_Event_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00061248 File Offset: 0x0005F448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521483, XrefRangeEnd = 521496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Confirm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerPromptBehaviour.NativeMethodInfoPtr_Event_Confirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x0006127C File Offset: 0x0005F47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521496, XrefRangeEnd = 521507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SelectAvatar(DataComposition dataComposition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataComposition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerPromptBehaviour.NativeMethodInfoPtr_Event_SelectAvatar_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x000612C0 File Offset: 0x0005F4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521507, XrefRangeEnd = 521518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SelectColor(DataComposition dataComposition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataComposition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerPromptBehaviour.NativeMethodInfoPtr_Event_SelectColor_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x00061304 File Offset: 0x0005F504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 521518, XrefRangeEnd = 521521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigurePlayerPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurePlayerPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurePlayerPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x0000BC54 File Offset: 0x00009E54
		public ConfigurePlayerPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeMethodInfoPtr_Event_Close_Public_Void_0;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeMethodInfoPtr_Event_Confirm_Public_Void_0;

		// Token: 0x04000CEB RID: 3307
		private static readonly IntPtr NativeMethodInfoPtr_Event_SelectAvatar_Public_Void_DataComposition_0;

		// Token: 0x04000CEC RID: 3308
		private static readonly IntPtr NativeMethodInfoPtr_Event_SelectColor_Public_Void_DataComposition_0;

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

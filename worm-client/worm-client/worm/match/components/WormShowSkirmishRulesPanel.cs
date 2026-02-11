using System;
using boardgames.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.components
{
	// Token: 0x02000216 RID: 534
	public class WormShowSkirmishRulesPanel : WormShowRulesPanel
	{
		// Token: 0x06001786 RID: 6022 RVA: 0x0005F744 File Offset: 0x0005D944
		// Note: this type is marked as 'beforefieldinit'.
		static WormShowSkirmishRulesPanel()
		{
			Il2CppClassPointerStore<WormShowSkirmishRulesPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormShowSkirmishRulesPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowSkirmishRulesPanel>.NativeClassPtr);
			WormShowSkirmishRulesPanel.NativeMethodInfoPtr_InitMatchData_Protected_Virtual_Boolean_GameOptionsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowSkirmishRulesPanel>.NativeClassPtr, 100666573);
			WormShowSkirmishRulesPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowSkirmishRulesPanel>.NativeClassPtr, 100666574);
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x0005F79C File Offset: 0x0005D99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717526, XrefRangeEnd = 717563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool InitMatchData(GameOptionsData matchData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormShowSkirmishRulesPanel.NativeMethodInfoPtr_InitMatchData_Protected_Virtual_Boolean_GameOptionsData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x0005F7F4 File Offset: 0x0005D9F4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormShowSkirmishRulesPanel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowSkirmishRulesPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowSkirmishRulesPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x0000E0D7 File Offset: 0x0000C2D7
		public WormShowSkirmishRulesPanel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DA4 RID: 3492
		private static readonly IntPtr NativeMethodInfoPtr_InitMatchData_Protected_Virtual_Boolean_GameOptionsData_0;

		// Token: 0x04000DA5 RID: 3493
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using boardgames.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.components
{
	// Token: 0x02000214 RID: 532
	public class WormShowGoTo11RulesPanel : WormShowRulesPanel
	{
		// Token: 0x06001777 RID: 6007 RVA: 0x0005F400 File Offset: 0x0005D600
		// Note: this type is marked as 'beforefieldinit'.
		static WormShowGoTo11RulesPanel()
		{
			Il2CppClassPointerStore<WormShowGoTo11RulesPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormShowGoTo11RulesPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowGoTo11RulesPanel>.NativeClassPtr);
			WormShowGoTo11RulesPanel.NativeMethodInfoPtr_InitMatchData_Protected_Virtual_Boolean_GameOptionsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowGoTo11RulesPanel>.NativeClassPtr, 100666560);
			WormShowGoTo11RulesPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowGoTo11RulesPanel>.NativeClassPtr, 100666561);
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x0005F458 File Offset: 0x0005D658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717483, XrefRangeEnd = 717489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool InitMatchData(GameOptionsData matchData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormShowGoTo11RulesPanel.NativeMethodInfoPtr_InitMatchData_Protected_Virtual_Boolean_GameOptionsData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x0005F4B0 File Offset: 0x0005D6B0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormShowGoTo11RulesPanel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowGoTo11RulesPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowGoTo11RulesPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x0000E087 File Offset: 0x0000C287
		public WormShowGoTo11RulesPanel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeMethodInfoPtr_InitMatchData_Protected_Virtual_Boolean_GameOptionsData_0;

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

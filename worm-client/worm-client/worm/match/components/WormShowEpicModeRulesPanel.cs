using System;
using boardgames.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.components
{
	// Token: 0x02000212 RID: 530
	public class WormShowEpicModeRulesPanel : WormShowRulesPanel
	{
		// Token: 0x0600176F RID: 5999 RVA: 0x0005F228 File Offset: 0x0005D428
		// Note: this type is marked as 'beforefieldinit'.
		static WormShowEpicModeRulesPanel()
		{
			Il2CppClassPointerStore<WormShowEpicModeRulesPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormShowEpicModeRulesPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowEpicModeRulesPanel>.NativeClassPtr);
			WormShowEpicModeRulesPanel.NativeMethodInfoPtr_InitMatchData_Protected_Virtual_Boolean_GameOptionsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEpicModeRulesPanel>.NativeClassPtr, 100666556);
			WormShowEpicModeRulesPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEpicModeRulesPanel>.NativeClassPtr, 100666557);
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x0005F280 File Offset: 0x0005D480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717414, XrefRangeEnd = 717437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool InitMatchData(GameOptionsData matchData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormShowEpicModeRulesPanel.NativeMethodInfoPtr_InitMatchData_Protected_Virtual_Boolean_GameOptionsData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x0005F2D8 File Offset: 0x0005D4D8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormShowEpicModeRulesPanel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowEpicModeRulesPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEpicModeRulesPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x0000E075 File Offset: 0x0000C275
		public WormShowEpicModeRulesPanel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeMethodInfoPtr_InitMatchData_Protected_Virtual_Boolean_GameOptionsData_0;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

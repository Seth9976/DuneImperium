using System;
using boardgames.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.components
{
	// Token: 0x02000213 RID: 531
	public class WormShowEventRulesPanel : WormShowRulesPanel
	{
		// Token: 0x06001773 RID: 6003 RVA: 0x0005F314 File Offset: 0x0005D514
		// Note: this type is marked as 'beforefieldinit'.
		static WormShowEventRulesPanel()
		{
			Il2CppClassPointerStore<WormShowEventRulesPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormShowEventRulesPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowEventRulesPanel>.NativeClassPtr);
			WormShowEventRulesPanel.NativeMethodInfoPtr_InitMatchData_Protected_Virtual_Boolean_GameOptionsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEventRulesPanel>.NativeClassPtr, 100666558);
			WormShowEventRulesPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowEventRulesPanel>.NativeClassPtr, 100666559);
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x0005F36C File Offset: 0x0005D56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717437, XrefRangeEnd = 717483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool InitMatchData(GameOptionsData matchData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormShowEventRulesPanel.NativeMethodInfoPtr_InitMatchData_Protected_Virtual_Boolean_GameOptionsData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x0005F3C4 File Offset: 0x0005D5C4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormShowEventRulesPanel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowEventRulesPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowEventRulesPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x0000E07E File Offset: 0x0000C27E
		public WormShowEventRulesPanel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeMethodInfoPtr_InitMatchData_Protected_Virtual_Boolean_GameOptionsData_0;

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

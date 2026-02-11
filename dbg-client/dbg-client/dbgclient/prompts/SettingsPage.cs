using System;
using boardgames.prompt.behaviours;
using boardgames.prompts;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dbgclient.prompts
{
	// Token: 0x02000092 RID: 146
	public class SettingsPage : TabulatedPromptPage
	{
		// Token: 0x060005BF RID: 1471 RVA: 0x0002FE28 File Offset: 0x0002E028
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsPage()
		{
			Il2CppClassPointerStore<SettingsPage>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.prompts", "SettingsPage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsPage>.NativeClassPtr);
			SettingsPage.NativeFieldInfoPtr_tabType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPage>.NativeClassPtr, "tabType");
			SettingsPage.NativeFieldInfoPtr_settingsPromptBehavior = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPage>.NativeClassPtr, "settingsPromptBehavior");
			SettingsPage.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPage>.NativeClassPtr, 100664196);
			SettingsPage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPage>.NativeClassPtr, 100664197);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0002FEA8 File Offset: 0x0002E0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502402, XrefRangeEnd = 502420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPage.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0002FEDC File Offset: 0x0002E0DC
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsPage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsPage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x000048EE File Offset: 0x00002AEE
		public SettingsPage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x0002FF18 File Offset: 0x0002E118
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x000048F7 File Offset: 0x00002AF7
		public unsafe SettingsPromptTab tabType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPage.NativeFieldInfoPtr_tabType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPage.NativeFieldInfoPtr_tabType)) = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x0002FF40 File Offset: 0x0002E140
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x00004912 File Offset: 0x00002B12
		public unsafe SettingsPromptBehaviour settingsPromptBehavior
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPage.NativeFieldInfoPtr_settingsPromptBehavior);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingsPromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPage.NativeFieldInfoPtr_settingsPromptBehavior), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeFieldInfoPtr_tabType;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeFieldInfoPtr_settingsPromptBehavior;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

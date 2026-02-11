using System;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm
{
	// Token: 0x02000059 RID: 89
	public class WormModalScopes : ModalScopes
	{
		// Token: 0x06000395 RID: 917 RVA: 0x00024350 File Offset: 0x00022550
		// Note: this type is marked as 'beforefieldinit'.
		static WormModalScopes()
		{
			Il2CppClassPointerStore<WormModalScopes>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormModalScopes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormModalScopes>.NativeClassPtr);
			WormModalScopes.NativeFieldInfoPtr_ImperiumRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormModalScopes>.NativeClassPtr, "ImperiumRow");
			WormModalScopes.NativeFieldInfoPtr_LeaderSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormModalScopes>.NativeClassPtr, "LeaderSelection");
			WormModalScopes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormModalScopes>.NativeClassPtr, 100663898);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x000243BC File Offset: 0x000225BC
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormModalScopes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormModalScopes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormModalScopes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00003974 File Offset: 0x00001B74
		public WormModalScopes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000398 RID: 920 RVA: 0x000243F8 File Offset: 0x000225F8
		// (set) Token: 0x06000399 RID: 921 RVA: 0x0000397D File Offset: 0x00001B7D
		public unsafe ModalScope ImperiumRow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormModalScopes.NativeFieldInfoPtr_ImperiumRow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormModalScopes.NativeFieldInfoPtr_ImperiumRow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00024428 File Offset: 0x00022628
		// (set) Token: 0x0600039B RID: 923 RVA: 0x0000399C File Offset: 0x00001B9C
		public unsafe ModalScope LeaderSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormModalScopes.NativeFieldInfoPtr_LeaderSelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormModalScopes.NativeFieldInfoPtr_LeaderSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeFieldInfoPtr_ImperiumRow;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeFieldInfoPtr_LeaderSelection;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

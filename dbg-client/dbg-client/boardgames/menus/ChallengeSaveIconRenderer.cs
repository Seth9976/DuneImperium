using System;
using Canis;
using dwd.core.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.menus
{
	// Token: 0x020001A0 RID: 416
	public class ChallengeSaveIconRenderer : VersionedSubscriber<SelectedData<MatchInitData>>
	{
		// Token: 0x06001268 RID: 4712 RVA: 0x00058864 File Offset: 0x00056A64
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengeSaveIconRenderer()
		{
			Il2CppClassPointerStore<ChallengeSaveIconRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus", "ChallengeSaveIconRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeSaveIconRenderer>.NativeClassPtr);
			ChallengeSaveIconRenderer.NativeFieldInfoPtr_saveIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeSaveIconRenderer>.NativeClassPtr, "saveIcon");
			ChallengeSaveIconRenderer.NativeMethodInfoPtr_hasSavedGame_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeSaveIconRenderer>.NativeClassPtr, 100665972);
			ChallengeSaveIconRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeSaveIconRenderer>.NativeClassPtr, 100665973);
			ChallengeSaveIconRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeSaveIconRenderer>.NativeClassPtr, 100665974);
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x000588E4 File Offset: 0x00056AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516929, XrefRangeEnd = 516939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool hasSavedGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeSaveIconRenderer.NativeMethodInfoPtr_hasSavedGame_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x00058920 File Offset: 0x00056B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516939, XrefRangeEnd = 516952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChallengeSaveIconRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x0005895C File Offset: 0x00056B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516952, XrefRangeEnd = 516955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChallengeSaveIconRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeSaveIconRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeSaveIconRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x0000ABCE File Offset: 0x00008DCE
		public ChallengeSaveIconRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x00058998 File Offset: 0x00056B98
		// (set) Token: 0x0600126E RID: 4718 RVA: 0x0000ABD7 File Offset: 0x00008DD7
		public unsafe GameObject saveIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeSaveIconRenderer.NativeFieldInfoPtr_saveIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeSaveIconRenderer.NativeFieldInfoPtr_saveIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeFieldInfoPtr_saveIcon;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeMethodInfoPtr_hasSavedGame_Protected_Boolean_0;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

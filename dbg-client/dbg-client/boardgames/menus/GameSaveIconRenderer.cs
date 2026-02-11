using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.menus
{
	// Token: 0x020001A3 RID: 419
	public class GameSaveIconRenderer : VersionedSubscriber<SerializedMatchComponent>
	{
		// Token: 0x060012B8 RID: 4792 RVA: 0x00059D84 File Offset: 0x00057F84
		// Note: this type is marked as 'beforefieldinit'.
		static GameSaveIconRenderer()
		{
			Il2CppClassPointerStore<GameSaveIconRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus", "GameSaveIconRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameSaveIconRenderer>.NativeClassPtr);
			GameSaveIconRenderer.NativeFieldInfoPtr_saveIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSaveIconRenderer>.NativeClassPtr, "saveIcon");
			GameSaveIconRenderer.NativeMethodInfoPtr_hasSavedGame_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSaveIconRenderer>.NativeClassPtr, 100666043);
			GameSaveIconRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSaveIconRenderer>.NativeClassPtr, 100666044);
			GameSaveIconRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSaveIconRenderer>.NativeClassPtr, 100666045);
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x00059E04 File Offset: 0x00058004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518234, XrefRangeEnd = 518238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool hasSavedGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSaveIconRenderer.NativeMethodInfoPtr_hasSavedGame_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x00059E40 File Offset: 0x00058040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518238, XrefRangeEnd = 518244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameSaveIconRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x00059E7C File Offset: 0x0005807C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518244, XrefRangeEnd = 518247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSaveIconRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameSaveIconRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSaveIconRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x0000AD78 File Offset: 0x00008F78
		public GameSaveIconRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060012BD RID: 4797 RVA: 0x00059EB8 File Offset: 0x000580B8
		// (set) Token: 0x060012BE RID: 4798 RVA: 0x0000AD81 File Offset: 0x00008F81
		public unsafe GameObject saveIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSaveIconRenderer.NativeFieldInfoPtr_saveIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSaveIconRenderer.NativeFieldInfoPtr_saveIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeFieldInfoPtr_saveIcon;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeMethodInfoPtr_hasSavedGame_Protected_Boolean_0;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

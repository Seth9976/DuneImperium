using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.dataRenderers
{
	// Token: 0x02000150 RID: 336
	public class LobbyGameInGameRenderer : VersionedSubscriber<PendingGameData>
	{
		// Token: 0x06000F2B RID: 3883 RVA: 0x0004DE68 File Offset: 0x0004C068
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyGameInGameRenderer()
		{
			Il2CppClassPointerStore<LobbyGameInGameRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "LobbyGameInGameRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyGameInGameRenderer>.NativeClassPtr);
			LobbyGameInGameRenderer.NativeFieldInfoPtr_inGameHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameInGameRenderer>.NativeClassPtr, "inGameHighlight");
			LobbyGameInGameRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyGameInGameRenderer>.NativeClassPtr, 100665492);
			LobbyGameInGameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyGameInGameRenderer>.NativeClassPtr, 100665493);
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x0004DED4 File Offset: 0x0004C0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513107, XrefRangeEnd = 513113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LobbyGameInGameRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x0004DF10 File Offset: 0x0004C110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513113, XrefRangeEnd = 513116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyGameInGameRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyGameInGameRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyGameInGameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x00009493 File Offset: 0x00007693
		public LobbyGameInGameRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x0004DF4C File Offset: 0x0004C14C
		// (set) Token: 0x06000F30 RID: 3888 RVA: 0x0000949C File Offset: 0x0000769C
		public unsafe GameObject inGameHighlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGameInGameRenderer.NativeFieldInfoPtr_inGameHighlight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGameInGameRenderer.NativeFieldInfoPtr_inGameHighlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeFieldInfoPtr_inGameHighlight;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.dataRenderers
{
	// Token: 0x02000151 RID: 337
	public class LobbyGameOptionsRenderer : VersionedSubscriber<DBGMatchConfigData>
	{
		// Token: 0x06000F31 RID: 3889 RVA: 0x0004DF7C File Offset: 0x0004C17C
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyGameOptionsRenderer()
		{
			Il2CppClassPointerStore<LobbyGameOptionsRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "LobbyGameOptionsRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyGameOptionsRenderer>.NativeClassPtr);
			LobbyGameOptionsRenderer.NativeFieldInfoPtr_liveTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameOptionsRenderer>.NativeClassPtr, "liveTimer");
			LobbyGameOptionsRenderer.NativeFieldInfoPtr_casualTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameOptionsRenderer>.NativeClassPtr, "casualTimer");
			LobbyGameOptionsRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyGameOptionsRenderer>.NativeClassPtr, 100665494);
			LobbyGameOptionsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyGameOptionsRenderer>.NativeClassPtr, 100665495);
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x0004DFFC File Offset: 0x0004C1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513116, XrefRangeEnd = 513129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LobbyGameOptionsRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x0004E038 File Offset: 0x0004C238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513129, XrefRangeEnd = 513132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyGameOptionsRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyGameOptionsRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyGameOptionsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x000094BB File Offset: 0x000076BB
		public LobbyGameOptionsRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x0004E074 File Offset: 0x0004C274
		// (set) Token: 0x06000F36 RID: 3894 RVA: 0x000094C4 File Offset: 0x000076C4
		public unsafe GameObject liveTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGameOptionsRenderer.NativeFieldInfoPtr_liveTimer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGameOptionsRenderer.NativeFieldInfoPtr_liveTimer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x0004E0A4 File Offset: 0x0004C2A4
		// (set) Token: 0x06000F38 RID: 3896 RVA: 0x000094E3 File Offset: 0x000076E3
		public unsafe GameObject casualTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGameOptionsRenderer.NativeFieldInfoPtr_casualTimer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGameOptionsRenderer.NativeFieldInfoPtr_casualTimer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeFieldInfoPtr_liveTimer;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeFieldInfoPtr_casualTimer;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

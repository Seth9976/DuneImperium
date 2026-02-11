using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Networking.game
{
	// Token: 0x020000AD RID: 173
	public class DWDPlayerSession : Object
	{
		// Token: 0x060005A8 RID: 1448 RVA: 0x00014F78 File Offset: 0x00013178
		// Note: this type is marked as 'beforefieldinit'.
		static DWDPlayerSession()
		{
			Il2CppClassPointerStore<DWDPlayerSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.game", "DWDPlayerSession");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DWDPlayerSession>.NativeClassPtr);
			DWDPlayerSession.NativeFieldInfoPtr_PlayerSessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDPlayerSession>.NativeClassPtr, "PlayerSessionId");
			DWDPlayerSession.NativeFieldInfoPtr_GameSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDPlayerSession>.NativeClassPtr, "GameSession");
			DWDPlayerSession.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDPlayerSession>.NativeClassPtr, 100663650);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00014FE4 File Offset: 0x000131E4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DWDPlayerSession()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DWDPlayerSession>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDPlayerSession.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x000057ED File Offset: 0x000039ED
		public DWDPlayerSession(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x00015020 File Offset: 0x00013220
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x000057F6 File Offset: 0x000039F6
		public unsafe string PlayerSessionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPlayerSession.NativeFieldInfoPtr_PlayerSessionId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPlayerSession.NativeFieldInfoPtr_PlayerSessionId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x00015048 File Offset: 0x00013248
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x00005815 File Offset: 0x00003A15
		public unsafe DWDGameSession GameSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPlayerSession.NativeFieldInfoPtr_GameSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DWDGameSession>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDPlayerSession.NativeFieldInfoPtr_GameSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeFieldInfoPtr_PlayerSessionId;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeFieldInfoPtr_GameSession;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

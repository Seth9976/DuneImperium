using System;
using dwd.core.platform.authentication;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Networking.game
{
	// Token: 0x020000AF RID: 175
	public class URLPayload : Object
	{
		// Token: 0x060005CF RID: 1487 RVA: 0x00015544 File Offset: 0x00013744
		// Note: this type is marked as 'beforefieldinit'.
		static URLPayload()
		{
			Il2CppClassPointerStore<URLPayload>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.game", "URLPayload");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<URLPayload>.NativeClassPtr);
			URLPayload.NativeFieldInfoPtr_GameSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<URLPayload>.NativeClassPtr, "GameSession");
			URLPayload.NativeFieldInfoPtr_PlatformToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<URLPayload>.NativeClassPtr, "PlatformToken");
			URLPayload.NativeFieldInfoPtr_Rejoin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<URLPayload>.NativeClassPtr, "Rejoin");
			URLPayload.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<URLPayload>.NativeClassPtr, 100663657);
			URLPayload.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<URLPayload>.NativeClassPtr, 100663658);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x000155D8 File Offset: 0x000137D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195316, XrefRangeEnd = 1195322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), URLPayload.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0001561C File Offset: 0x0001381C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe URLPayload()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<URLPayload>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(URLPayload.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x000059BC File Offset: 0x00003BBC
		public URLPayload(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00015658 File Offset: 0x00013858
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x000059C5 File Offset: 0x00003BC5
		public unsafe DWDGameSession GameSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(URLPayload.NativeFieldInfoPtr_GameSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DWDGameSession>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(URLPayload.NativeFieldInfoPtr_GameSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x00015688 File Offset: 0x00013888
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x000059E4 File Offset: 0x00003BE4
		public unsafe PlatformToken PlatformToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(URLPayload.NativeFieldInfoPtr_PlatformToken);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformToken>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(URLPayload.NativeFieldInfoPtr_PlatformToken), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x000156B8 File Offset: 0x000138B8
		// (set) Token: 0x060005D8 RID: 1496 RVA: 0x00005A03 File Offset: 0x00003C03
		public unsafe bool Rejoin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(URLPayload.NativeFieldInfoPtr_Rejoin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(URLPayload.NativeFieldInfoPtr_Rejoin)) = value;
			}
		}

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeFieldInfoPtr_GameSession;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeFieldInfoPtr_PlatformToken;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeFieldInfoPtr_Rejoin;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.networking
{
	// Token: 0x0200005F RID: 95
	public class GetLeaderboard : Object
	{
		// Token: 0x060003BB RID: 955 RVA: 0x00024C08 File Offset: 0x00022E08
		// Note: this type is marked as 'beforefieldinit'.
		static GetLeaderboard()
		{
			Il2CppClassPointerStore<GetLeaderboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking", "GetLeaderboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetLeaderboard>.NativeClassPtr);
			GetLeaderboard.NativeFieldInfoPtr_eventID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetLeaderboard>.NativeClassPtr, "eventID");
			GetLeaderboard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetLeaderboard>.NativeClassPtr, 100663916);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00024C60 File Offset: 0x00022E60
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetLeaderboard()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetLeaderboard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetLeaderboard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00003A26 File Offset: 0x00001C26
		public GetLeaderboard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00024C9C File Offset: 0x00022E9C
		// (set) Token: 0x060003BF RID: 959 RVA: 0x00003A2F File Offset: 0x00001C2F
		public unsafe EventID eventID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLeaderboard.NativeFieldInfoPtr_eventID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLeaderboard.NativeFieldInfoPtr_eventID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeFieldInfoPtr_eventID;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

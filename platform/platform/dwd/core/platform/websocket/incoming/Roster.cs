using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.platform.websocket.incoming
{
	// Token: 0x02000040 RID: 64
	public class Roster : TypedMessage
	{
		// Token: 0x0600022D RID: 557 RVA: 0x0000C1AC File Offset: 0x0000A3AC
		// Note: this type is marked as 'beforefieldinit'.
		static Roster()
		{
			Il2CppClassPointerStore<Roster>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.incoming", "Roster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Roster>.NativeClassPtr);
			Roster.NativeFieldInfoPtr_Friends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Roster>.NativeClassPtr, "Friends");
			Roster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roster>.NativeClassPtr, 100663626);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000C204 File Offset: 0x0000A404
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Roster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Roster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000031D9 File Offset: 0x000013D9
		public Roster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0000C240 File Offset: 0x0000A440
		// (set) Token: 0x06000231 RID: 561 RVA: 0x000031E2 File Offset: 0x000013E2
		public unsafe Il2CppReferenceArray<RosterEntry> Friends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Roster.NativeFieldInfoPtr_Friends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RosterEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Roster.NativeFieldInfoPtr_Friends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeFieldInfoPtr_Friends;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

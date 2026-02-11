using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.incoming
{
	// Token: 0x02000042 RID: 66
	public class RosterRemoval : TypedMessage
	{
		// Token: 0x06000253 RID: 595 RVA: 0x0000C884 File Offset: 0x0000AA84
		// Note: this type is marked as 'beforefieldinit'.
		static RosterRemoval()
		{
			Il2CppClassPointerStore<RosterRemoval>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.incoming", "RosterRemoval");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RosterRemoval>.NativeClassPtr);
			RosterRemoval.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RosterRemoval>.NativeClassPtr, "AccountID");
			RosterRemoval.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RosterRemoval>.NativeClassPtr, 100663638);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000C8DC File Offset: 0x0000AADC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RosterRemoval()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RosterRemoval>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RosterRemoval.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000332C File Offset: 0x0000152C
		public RosterRemoval(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0000C918 File Offset: 0x0000AB18
		// (set) Token: 0x06000257 RID: 599 RVA: 0x00003335 File Offset: 0x00001535
		public unsafe string AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RosterRemoval.NativeFieldInfoPtr_AccountID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RosterRemoval.NativeFieldInfoPtr_AccountID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

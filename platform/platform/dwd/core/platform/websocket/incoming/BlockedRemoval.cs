using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.incoming
{
	// Token: 0x02000037 RID: 55
	public class BlockedRemoval : TypedMessage
	{
		// Token: 0x060001D5 RID: 469 RVA: 0x0000B45C File Offset: 0x0000965C
		// Note: this type is marked as 'beforefieldinit'.
		static BlockedRemoval()
		{
			Il2CppClassPointerStore<BlockedRemoval>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.incoming", "BlockedRemoval");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlockedRemoval>.NativeClassPtr);
			BlockedRemoval.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockedRemoval>.NativeClassPtr, "AccountID");
			BlockedRemoval.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockedRemoval>.NativeClassPtr, 100663610);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000B4B4 File Offset: 0x000096B4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlockedRemoval()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlockedRemoval>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockedRemoval.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002E64 File Offset: 0x00001064
		public BlockedRemoval(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0000B4F0 File Offset: 0x000096F0
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00002E6D File Offset: 0x0000106D
		public unsafe string AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockedRemoval.NativeFieldInfoPtr_AccountID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockedRemoval.NativeFieldInfoPtr_AccountID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

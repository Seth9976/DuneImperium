using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.platform.websocket.incoming
{
	// Token: 0x02000036 RID: 54
	public class BlockedAccounts : TypedMessage
	{
		// Token: 0x060001D0 RID: 464 RVA: 0x0000B398 File Offset: 0x00009598
		// Note: this type is marked as 'beforefieldinit'.
		static BlockedAccounts()
		{
			Il2CppClassPointerStore<BlockedAccounts>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.incoming", "BlockedAccounts");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlockedAccounts>.NativeClassPtr);
			BlockedAccounts.NativeFieldInfoPtr_Blocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockedAccounts>.NativeClassPtr, "Blocked");
			BlockedAccounts.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockedAccounts>.NativeClassPtr, 100663609);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000B3F0 File Offset: 0x000095F0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlockedAccounts()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlockedAccounts>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockedAccounts.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002E3C File Offset: 0x0000103C
		public BlockedAccounts(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000B42C File Offset: 0x0000962C
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002E45 File Offset: 0x00001045
		public unsafe Il2CppReferenceArray<BlockedAccountEntry> Blocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockedAccounts.NativeFieldInfoPtr_Blocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BlockedAccountEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockedAccounts.NativeFieldInfoPtr_Blocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeFieldInfoPtr_Blocked;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

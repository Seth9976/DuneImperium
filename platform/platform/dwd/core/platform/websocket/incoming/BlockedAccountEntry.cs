using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.incoming
{
	// Token: 0x02000035 RID: 53
	public class BlockedAccountEntry : TypedMessage
	{
		// Token: 0x060001C6 RID: 454 RVA: 0x0000B200 File Offset: 0x00009400
		// Note: this type is marked as 'beforefieldinit'.
		static BlockedAccountEntry()
		{
			Il2CppClassPointerStore<BlockedAccountEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.incoming", "BlockedAccountEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlockedAccountEntry>.NativeClassPtr);
			BlockedAccountEntry.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockedAccountEntry>.NativeClassPtr, "AccountID");
			BlockedAccountEntry.NativeFieldInfoPtr_Username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockedAccountEntry>.NativeClassPtr, "Username");
			BlockedAccountEntry.NativeFieldInfoPtr_Created = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockedAccountEntry>.NativeClassPtr, "Created");
			BlockedAccountEntry.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_BlockedAccountEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockedAccountEntry>.NativeClassPtr, 100663607);
			BlockedAccountEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockedAccountEntry>.NativeClassPtr, 100663608);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000B294 File Offset: 0x00009494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167931, XrefRangeEnd = 1167933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int CompareTo(BlockedAccountEntry other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockedAccountEntry.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_BlockedAccountEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000B2E4 File Offset: 0x000094E4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlockedAccountEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlockedAccountEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockedAccountEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002DDA File Offset: 0x00000FDA
		public BlockedAccountEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0000B320 File Offset: 0x00009520
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00002DE3 File Offset: 0x00000FE3
		public unsafe string AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockedAccountEntry.NativeFieldInfoPtr_AccountID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockedAccountEntry.NativeFieldInfoPtr_AccountID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001CC RID: 460 RVA: 0x0000B348 File Offset: 0x00009548
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00002E02 File Offset: 0x00001002
		public unsafe string Username
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockedAccountEntry.NativeFieldInfoPtr_Username);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockedAccountEntry.NativeFieldInfoPtr_Username), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001CE RID: 462 RVA: 0x0000B370 File Offset: 0x00009570
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00002E21 File Offset: 0x00001021
		public unsafe long Created
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockedAccountEntry.NativeFieldInfoPtr_Created);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockedAccountEntry.NativeFieldInfoPtr_Created)) = value;
			}
		}

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeFieldInfoPtr_Username;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeFieldInfoPtr_Created;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_BlockedAccountEntry_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using dwd.core.platform.providers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.platform.websocket.incoming
{
	// Token: 0x0200003D RID: 61
	public class Profile : TypedMessage
	{
		// Token: 0x0600020D RID: 525 RVA: 0x0000BD18 File Offset: 0x00009F18
		// Note: this type is marked as 'beforefieldinit'.
		static Profile()
		{
			Il2CppClassPointerStore<Profile>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.incoming", "Profile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Profile>.NativeClassPtr);
			Profile.NativeFieldInfoPtr_Self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profile>.NativeClassPtr, "Self");
			Profile.NativeFieldInfoPtr_Friends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profile>.NativeClassPtr, "Friends");
			Profile.NativeFieldInfoPtr_Invitations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profile>.NativeClassPtr, "Invitations");
			Profile.NativeFieldInfoPtr_BlockedUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profile>.NativeClassPtr, "BlockedUsers");
			Profile.NativeFieldInfoPtr_MaxRosterLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profile>.NativeClassPtr, "MaxRosterLimit");
			Profile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profile>.NativeClassPtr, 100663622);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000BDC0 File Offset: 0x00009FC0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Profile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Profile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00003082 File Offset: 0x00001282
		public Profile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0000BDFC File Offset: 0x00009FFC
		// (set) Token: 0x06000211 RID: 529 RVA: 0x0000308B File Offset: 0x0000128B
		public unsafe static IUserEntry Self
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Profile.NativeFieldInfoPtr_Self, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IUserEntry>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Profile.NativeFieldInfoPtr_Self, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0000BE24 File Offset: 0x0000A024
		// (set) Token: 0x06000213 RID: 531 RVA: 0x0000309D File Offset: 0x0000129D
		public unsafe Il2CppReferenceArray<RosterEntry> Friends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Profile.NativeFieldInfoPtr_Friends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RosterEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Profile.NativeFieldInfoPtr_Friends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0000BE54 File Offset: 0x0000A054
		// (set) Token: 0x06000215 RID: 533 RVA: 0x000030BC File Offset: 0x000012BC
		public unsafe Invitations Invitations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Profile.NativeFieldInfoPtr_Invitations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Invitations>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Profile.NativeFieldInfoPtr_Invitations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000216 RID: 534 RVA: 0x0000BE84 File Offset: 0x0000A084
		// (set) Token: 0x06000217 RID: 535 RVA: 0x000030DB File Offset: 0x000012DB
		public unsafe Il2CppReferenceArray<BlockedAccountEntry> BlockedUsers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Profile.NativeFieldInfoPtr_BlockedUsers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BlockedAccountEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Profile.NativeFieldInfoPtr_BlockedUsers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000218 RID: 536 RVA: 0x0000BEB4 File Offset: 0x0000A0B4
		// (set) Token: 0x06000219 RID: 537 RVA: 0x000030FA File Offset: 0x000012FA
		public unsafe int MaxRosterLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Profile.NativeFieldInfoPtr_MaxRosterLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Profile.NativeFieldInfoPtr_MaxRosterLimit)) = value;
			}
		}

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeFieldInfoPtr_Self;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeFieldInfoPtr_Friends;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeFieldInfoPtr_Invitations;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr_BlockedUsers;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeFieldInfoPtr_MaxRosterLimit;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.matchMaking.commands
{
	// Token: 0x0200011A RID: 282
	public class ICanInviteUser : Il2CppObjectBase
	{
		// Token: 0x06000EB5 RID: 3765 RVA: 0x0003DB7C File Offset: 0x0003BD7C
		// Note: this type is marked as 'beforefieldinit'.
		static ICanInviteUser()
		{
			Il2CppClassPointerStore<ICanInviteUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.matchMaking.commands", "ICanInviteUser");
			ICanInviteUser.NativeMethodInfoPtr_get_IsAllowed_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICanInviteUser>.NativeClassPtr, 100665399);
			ICanInviteUser.NativeMethodInfoPtr_Create_Public_Static_ICanInviteUser_Boolean_IDictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICanInviteUser>.NativeClassPtr, 100665400);
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x0003DBCC File Offset: 0x0003BDCC
		public unsafe virtual bool IsAllowed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICanInviteUser.NativeMethodInfoPtr_get_IsAllowed_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0003DC14 File Offset: 0x0003BE14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 996742, RefRangeEnd = 996745, XrefRangeStart = 996726, XrefRangeEnd = 996742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ICanInviteUser Create(bool notifyUser, IDictionary<string, string> userToInvite)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref notifyUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userToInvite);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ICanInviteUser.NativeMethodInfoPtr_Create_Public_Static_ICanInviteUser_Boolean_IDictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICanInviteUser>(intPtr3) : null;
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00008E19 File Offset: 0x00007019
		public ICanInviteUser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAllowed_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ICanInviteUser_Boolean_IDictionary_2_String_String_0;
	}
}

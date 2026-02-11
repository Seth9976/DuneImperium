using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.platform.data
{
	// Token: 0x02000050 RID: 80
	public class UserStatus : Object
	{
		// Token: 0x06000338 RID: 824 RVA: 0x0000FF8C File Offset: 0x0000E18C
		// Note: this type is marked as 'beforefieldinit'.
		static UserStatus()
		{
			Il2CppClassPointerStore<UserStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.data", "UserStatus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserStatus>.NativeClassPtr);
			UserStatus.NativeFieldInfoPtr_Client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatus>.NativeClassPtr, "Client");
			UserStatus.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatus>.NativeClassPtr, "Status");
			UserStatus.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserStatus>.NativeClassPtr, 100663800);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000FFF8 File Offset: 0x0000E1F8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UserStatus()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserStatus>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserStatus.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00003807 File Offset: 0x00001A07
		public UserStatus(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600033B RID: 827 RVA: 0x00010034 File Offset: 0x0000E234
		// (set) Token: 0x0600033C RID: 828 RVA: 0x00003810 File Offset: 0x00001A10
		public unsafe string Client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserStatus.NativeFieldInfoPtr_Client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserStatus.NativeFieldInfoPtr_Client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600033D RID: 829 RVA: 0x0001005C File Offset: 0x0000E25C
		// (set) Token: 0x0600033E RID: 830 RVA: 0x0000382F File Offset: 0x00001A2F
		public unsafe string Status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserStatus.NativeFieldInfoPtr_Status);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserStatus.NativeFieldInfoPtr_Status), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeFieldInfoPtr_Client;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeFieldInfoPtr_Status;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x02000009 RID: 9
	public class LocalUser : UserProfile
	{
		// Token: 0x06000046 RID: 70 RVA: 0x0000337C File Offset: 0x0000157C
		// Note: this type is marked as 'beforefieldinit'.
		static LocalUser()
		{
			Il2CppClassPointerStore<LocalUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.GameCenterModule.dll", "UnityEngine.SocialPlatforms.Impl", "LocalUser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalUser>.NativeClassPtr);
			LocalUser.NativeFieldInfoPtr_m_Friends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalUser>.NativeClassPtr, "m_Friends");
			LocalUser.NativeFieldInfoPtr_m_Authenticated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalUser>.NativeClassPtr, "m_Authenticated");
			LocalUser.NativeFieldInfoPtr_m_Underage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalUser>.NativeClassPtr, "m_Underage");
			LocalUser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalUser>.NativeClassPtr, 100663313);
			LocalUser.NativeMethodInfoPtr_get_authenticated_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalUser>.NativeClassPtr, 100663314);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003410 File Offset: 0x00001610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270699, XrefRangeEnd = 1270720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalUser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalUser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalUser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000048 RID: 72 RVA: 0x0000344C File Offset: 0x0000164C
		public unsafe virtual bool authenticated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalUser.NativeMethodInfoPtr_get_authenticated_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000226F File Offset: 0x0000046F
		public LocalUser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00003488 File Offset: 0x00001688
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00002278 File Offset: 0x00000478
		public unsafe Il2CppReferenceArray<IUserProfile> m_Friends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalUser.NativeFieldInfoPtr_m_Friends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IUserProfile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalUser.NativeFieldInfoPtr_m_Friends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000034B8 File Offset: 0x000016B8
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00002297 File Offset: 0x00000497
		public unsafe bool m_Authenticated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalUser.NativeFieldInfoPtr_m_Authenticated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalUser.NativeFieldInfoPtr_m_Authenticated)) = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004E RID: 78 RVA: 0x000034E0 File Offset: 0x000016E0
		// (set) Token: 0x0600004F RID: 79 RVA: 0x000022B2 File Offset: 0x000004B2
		public unsafe bool m_Underage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalUser.NativeFieldInfoPtr_m_Underage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalUser.NativeFieldInfoPtr_m_Underage)) = value;
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000022CD File Offset: 0x000004CD
		public void Authenticate(Action<bool> callback)
		{
			ActivePlatform.Instance.Authenticate(this, callback);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000022DD File Offset: 0x000004DD
		public void Authenticate(Action<bool, string> callback)
		{
			ActivePlatform.Instance.Authenticate(this, callback);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000022ED File Offset: 0x000004ED
		public void LoadFriends(Action<bool> callback)
		{
			ActivePlatform.Instance.LoadFriends(this, callback);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000022FD File Offset: 0x000004FD
		public void SetFriends(Il2CppReferenceArray<IUserProfile> friends)
		{
			this.m_Friends = friends;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002307 File Offset: 0x00000507
		public void SetAuthenticated(bool value)
		{
			this.m_Authenticated = value;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002311 File Offset: 0x00000511
		public void SetUnderage(bool value)
		{
			this.m_Underage = value;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00003508 File Offset: 0x00001708
		public Il2CppReferenceArray<IUserProfile> friends
		{
			get
			{
				return this.m_Friends;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00003520 File Offset: 0x00001720
		public bool underage
		{
			get
			{
				return this.m_Underage;
			}
		}

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr_m_Friends;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr_m_Authenticated;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr_m_Underage;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_get_authenticated_Public_Virtual_Final_New_get_Boolean_0;
	}
}

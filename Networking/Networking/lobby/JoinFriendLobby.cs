using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Networking.lobby
{
	// Token: 0x02000096 RID: 150
	public class JoinFriendLobby : NetworkMessageEvent
	{
		// Token: 0x060004FB RID: 1275 RVA: 0x000136E0 File Offset: 0x000118E0
		// Note: this type is marked as 'beforefieldinit'.
		static JoinFriendLobby()
		{
			Il2CppClassPointerStore<JoinFriendLobby>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.lobby", "JoinFriendLobby");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinFriendLobby>.NativeClassPtr);
			JoinFriendLobby.NativeFieldInfoPtr_Password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinFriendLobby>.NativeClassPtr, "Password");
			JoinFriendLobby.NativeFieldInfoPtr_Metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinFriendLobby>.NativeClassPtr, "Metadata");
			JoinFriendLobby.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinFriendLobby>.NativeClassPtr, 100663625);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0001374C File Offset: 0x0001194C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JoinFriendLobby()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoinFriendLobby>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinFriendLobby.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0000509B File Offset: 0x0000329B
		public JoinFriendLobby(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x00013788 File Offset: 0x00011988
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x000050A4 File Offset: 0x000032A4
		public unsafe string Password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinFriendLobby.NativeFieldInfoPtr_Password);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinFriendLobby.NativeFieldInfoPtr_Password), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x000137B0 File Offset: 0x000119B0
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x000050C3 File Offset: 0x000032C3
		public unsafe Dictionary<string, string> Metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinFriendLobby.NativeFieldInfoPtr_Metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinFriendLobby.NativeFieldInfoPtr_Metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeFieldInfoPtr_Password;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeFieldInfoPtr_Metadata;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

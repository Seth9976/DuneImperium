using System;
using dwd.core.platform.providers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dbgclient.menus.behaviours
{
	// Token: 0x020000A3 RID: 163
	public class PendingFriendRequestRenderer : MonoBehaviour
	{
		// Token: 0x06000668 RID: 1640 RVA: 0x00031EF0 File Offset: 0x000300F0
		// Note: this type is marked as 'beforefieldinit'.
		static PendingFriendRequestRenderer()
		{
			Il2CppClassPointerStore<PendingFriendRequestRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.menus.behaviours", "PendingFriendRequestRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PendingFriendRequestRenderer>.NativeClassPtr);
			PendingFriendRequestRenderer.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingFriendRequestRenderer>.NativeClassPtr, "animator");
			PendingFriendRequestRenderer.NativeFieldInfoPtr_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingFriendRequestRenderer>.NativeClassPtr, "provider");
			PendingFriendRequestRenderer.NativeFieldInfoPtr_PendingRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingFriendRequestRenderer>.NativeClassPtr, "PendingRequests");
			PendingFriendRequestRenderer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingFriendRequestRenderer>.NativeClassPtr, 100664309);
			PendingFriendRequestRenderer.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingFriendRequestRenderer>.NativeClassPtr, 100664310);
			PendingFriendRequestRenderer.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingFriendRequestRenderer>.NativeClassPtr, 100664311);
			PendingFriendRequestRenderer.NativeMethodInfoPtr_invitationsUpdated_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingFriendRequestRenderer>.NativeClassPtr, 100664312);
			PendingFriendRequestRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingFriendRequestRenderer>.NativeClassPtr, 100664313);
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00031FC0 File Offset: 0x000301C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503295, XrefRangeEnd = 503313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingFriendRequestRenderer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00031FF4 File Offset: 0x000301F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503313, XrefRangeEnd = 503323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingFriendRequestRenderer.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00032028 File Offset: 0x00030228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503323, XrefRangeEnd = 503334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingFriendRequestRenderer.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0003205C File Offset: 0x0003025C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void invitationsUpdated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingFriendRequestRenderer.NativeMethodInfoPtr_invitationsUpdated_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00032090 File Offset: 0x00030290
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PendingFriendRequestRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PendingFriendRequestRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingFriendRequestRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00004E52 File Offset: 0x00003052
		public PendingFriendRequestRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x000320CC File Offset: 0x000302CC
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x00004E5B File Offset: 0x0000305B
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingFriendRequestRenderer.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingFriendRequestRenderer.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x000320FC File Offset: 0x000302FC
		// (set) Token: 0x06000672 RID: 1650 RVA: 0x00004E7A File Offset: 0x0000307A
		public unsafe PlatformProvider provider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingFriendRequestRenderer.NativeFieldInfoPtr_provider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingFriendRequestRenderer.NativeFieldInfoPtr_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x0003212C File Offset: 0x0003032C
		// (set) Token: 0x06000674 RID: 1652 RVA: 0x00004E99 File Offset: 0x00003099
		public unsafe static int PendingRequests
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PendingFriendRequestRenderer.NativeFieldInfoPtr_PendingRequests, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PendingFriendRequestRenderer.NativeFieldInfoPtr_PendingRequests, (void*)(&value));
			}
		}

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeFieldInfoPtr_provider;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeFieldInfoPtr_PendingRequests;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeMethodInfoPtr_invitationsUpdated_Private_Void_0;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

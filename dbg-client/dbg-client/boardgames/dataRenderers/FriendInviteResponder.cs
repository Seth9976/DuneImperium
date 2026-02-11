using System;
using Canis.utils.ids;
using dwd.core.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.dataRenderers
{
	// Token: 0x02000149 RID: 329
	public class FriendInviteResponder : Subscriber<IDComponent<AccountID>>
	{
		// Token: 0x06000EF8 RID: 3832 RVA: 0x0004D4F0 File Offset: 0x0004B6F0
		// Note: this type is marked as 'beforefieldinit'.
		static FriendInviteResponder()
		{
			Il2CppClassPointerStore<FriendInviteResponder>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "FriendInviteResponder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendInviteResponder>.NativeClassPtr);
			FriendInviteResponder.NativeFieldInfoPtr_responseButtonsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendInviteResponder>.NativeClassPtr, "responseButtonsParent");
			FriendInviteResponder.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendInviteResponder>.NativeClassPtr, 100665471);
			FriendInviteResponder.NativeMethodInfoPtr_Event_AcceptInvite_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendInviteResponder>.NativeClassPtr, 100665472);
			FriendInviteResponder.NativeMethodInfoPtr_Event_DeclineInvite_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendInviteResponder>.NativeClassPtr, 100665473);
			FriendInviteResponder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendInviteResponder>.NativeClassPtr, 100665474);
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x0004D584 File Offset: 0x0004B784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512794, XrefRangeEnd = 512802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendInviteResponder.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x0004D5C0 File Offset: 0x0004B7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512802, XrefRangeEnd = 512808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_AcceptInvite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendInviteResponder.NativeMethodInfoPtr_Event_AcceptInvite_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x0004D5F4 File Offset: 0x0004B7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512808, XrefRangeEnd = 512814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_DeclineInvite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendInviteResponder.NativeMethodInfoPtr_Event_DeclineInvite_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x0004D628 File Offset: 0x0004B828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512814, XrefRangeEnd = 512817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendInviteResponder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendInviteResponder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendInviteResponder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x0000932B File Offset: 0x0000752B
		public FriendInviteResponder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000EFE RID: 3838 RVA: 0x0004D664 File Offset: 0x0004B864
		// (set) Token: 0x06000EFF RID: 3839 RVA: 0x00009334 File Offset: 0x00007534
		public unsafe GameObject responseButtonsParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInviteResponder.NativeFieldInfoPtr_responseButtonsParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInviteResponder.NativeFieldInfoPtr_responseButtonsParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeFieldInfoPtr_responseButtonsParent;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeMethodInfoPtr_Event_AcceptInvite_Public_Void_0;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeMethodInfoPtr_Event_DeclineInvite_Public_Void_0;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Canis.utils.ids;
using dwd.core.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.dataRenderers
{
	// Token: 0x0200014A RID: 330
	public class FriendRequestResponder : Subscriber<IDComponent<AccountID>>
	{
		// Token: 0x06000F00 RID: 3840 RVA: 0x0004D694 File Offset: 0x0004B894
		// Note: this type is marked as 'beforefieldinit'.
		static FriendRequestResponder()
		{
			Il2CppClassPointerStore<FriendRequestResponder>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "FriendRequestResponder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendRequestResponder>.NativeClassPtr);
			FriendRequestResponder.NativeFieldInfoPtr_cancelRequestButtonParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendRequestResponder>.NativeClassPtr, "cancelRequestButtonParent");
			FriendRequestResponder.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendRequestResponder>.NativeClassPtr, 100665475);
			FriendRequestResponder.NativeMethodInfoPtr_Event_CancelRequest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendRequestResponder>.NativeClassPtr, 100665476);
			FriendRequestResponder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendRequestResponder>.NativeClassPtr, 100665477);
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x0004D714 File Offset: 0x0004B914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512817, XrefRangeEnd = 512825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendRequestResponder.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x0004D750 File Offset: 0x0004B950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512825, XrefRangeEnd = 512831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_CancelRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendRequestResponder.NativeMethodInfoPtr_Event_CancelRequest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x0004D784 File Offset: 0x0004B984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512831, XrefRangeEnd = 512834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendRequestResponder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendRequestResponder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendRequestResponder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00009353 File Offset: 0x00007553
		public FriendRequestResponder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000F05 RID: 3845 RVA: 0x0004D7C0 File Offset: 0x0004B9C0
		// (set) Token: 0x06000F06 RID: 3846 RVA: 0x0000935C File Offset: 0x0000755C
		public unsafe GameObject cancelRequestButtonParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendRequestResponder.NativeFieldInfoPtr_cancelRequestButtonParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendRequestResponder.NativeFieldInfoPtr_cancelRequestButtonParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeFieldInfoPtr_cancelRequestButtonParent;

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeMethodInfoPtr_Event_CancelRequest_Public_Void_0;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

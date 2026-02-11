using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.iap.steam.steam.messages
{
	// Token: 0x02000009 RID: 9
	public class FinalizeSteamPurchase : Object
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00003818 File Offset: 0x00001A18
		// Note: this type is marked as 'beforefieldinit'.
		static FinalizeSteamPurchase()
		{
			Il2CppClassPointerStore<FinalizeSteamPurchase>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing-Steam.dll", "dwd.iap.steam.steam.messages", "FinalizeSteamPurchase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalizeSteamPurchase>.NativeClassPtr);
			FinalizeSteamPurchase.NativeFieldInfoPtr_OrderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeSteamPurchase>.NativeClassPtr, "OrderID");
			FinalizeSteamPurchase.NativeFieldInfoPtr_AuthorizationState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeSteamPurchase>.NativeClassPtr, "AuthorizationState");
			FinalizeSteamPurchase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeSteamPurchase>.NativeClassPtr, 100663384);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003884 File Offset: 0x00001A84
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FinalizeSteamPurchase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalizeSteamPurchase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeSteamPurchase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000223F File Offset: 0x0000043F
		public FinalizeSteamPurchase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000038C0 File Offset: 0x00001AC0
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00002248 File Offset: 0x00000448
		public unsafe ulong OrderID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeSteamPurchase.NativeFieldInfoPtr_OrderID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeSteamPurchase.NativeFieldInfoPtr_OrderID)) = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004E RID: 78 RVA: 0x000038E8 File Offset: 0x00001AE8
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00002263 File Offset: 0x00000463
		public unsafe byte AuthorizationState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeSteamPurchase.NativeFieldInfoPtr_AuthorizationState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeSteamPurchase.NativeFieldInfoPtr_AuthorizationState)) = value;
			}
		}

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_OrderID;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_AuthorizationState;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace worm.match.components
{
	// Token: 0x02000219 RID: 537
	public class WormSubscriptionProviderPassthrough : Subscriber
	{
		// Token: 0x0600179F RID: 6047 RVA: 0x0005FC1C File Offset: 0x0005DE1C
		// Note: this type is marked as 'beforefieldinit'.
		static WormSubscriptionProviderPassthrough()
		{
			Il2CppClassPointerStore<WormSubscriptionProviderPassthrough>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormSubscriptionProviderPassthrough");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSubscriptionProviderPassthrough>.NativeClassPtr);
			WormSubscriptionProviderPassthrough.NativeFieldInfoPtr_passToProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSubscriptionProviderPassthrough>.NativeClassPtr, "passToProviders");
			WormSubscriptionProviderPassthrough.NativeMethodInfoPtr_dataChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSubscriptionProviderPassthrough>.NativeClassPtr, 100666582);
			WormSubscriptionProviderPassthrough.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSubscriptionProviderPassthrough>.NativeClassPtr, 100666583);
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x0005FC88 File Offset: 0x0005DE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717630, XrefRangeEnd = 717632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dataChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSubscriptionProviderPassthrough.NativeMethodInfoPtr_dataChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x0005FCC4 File Offset: 0x0005DEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717632, XrefRangeEnd = 717637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSubscriptionProviderPassthrough()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSubscriptionProviderPassthrough>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSubscriptionProviderPassthrough.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x0000E18D File Offset: 0x0000C38D
		public WormSubscriptionProviderPassthrough(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x0005FD00 File Offset: 0x0005DF00
		// (set) Token: 0x060017A4 RID: 6052 RVA: 0x0000E196 File Offset: 0x0000C396
		public unsafe Il2CppReferenceArray<SubscriptionProvider> passToProviders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSubscriptionProviderPassthrough.NativeFieldInfoPtr_passToProviders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SubscriptionProvider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSubscriptionProviderPassthrough.NativeFieldInfoPtr_passToProviders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeFieldInfoPtr_passToProviders;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeMethodInfoPtr_dataChanged_Protected_Virtual_Void_0;

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

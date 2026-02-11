using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.incoming
{
	// Token: 0x02000032 RID: 50
	public class AccountOffline : TypedMessage
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x0000AF88 File Offset: 0x00009188
		// Note: this type is marked as 'beforefieldinit'.
		static AccountOffline()
		{
			Il2CppClassPointerStore<AccountOffline>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.incoming", "AccountOffline");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountOffline>.NativeClassPtr);
			AccountOffline.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountOffline>.NativeClassPtr, "AccountID");
			AccountOffline.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountOffline>.NativeClassPtr, 100663604);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000AFE0 File Offset: 0x000091E0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccountOffline()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccountOffline>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountOffline.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002D43 File Offset: 0x00000F43
		public AccountOffline(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000B01C File Offset: 0x0000921C
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00002D4C File Offset: 0x00000F4C
		public unsafe string AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountOffline.NativeFieldInfoPtr_AccountID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountOffline.NativeFieldInfoPtr_AccountID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

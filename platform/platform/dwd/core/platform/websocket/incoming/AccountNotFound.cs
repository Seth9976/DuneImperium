using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.incoming
{
	// Token: 0x02000031 RID: 49
	public class AccountNotFound : TypedMessage
	{
		// Token: 0x060001B0 RID: 432 RVA: 0x0000AECC File Offset: 0x000090CC
		// Note: this type is marked as 'beforefieldinit'.
		static AccountNotFound()
		{
			Il2CppClassPointerStore<AccountNotFound>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.incoming", "AccountNotFound");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountNotFound>.NativeClassPtr);
			AccountNotFound.NativeFieldInfoPtr_Username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountNotFound>.NativeClassPtr, "Username");
			AccountNotFound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountNotFound>.NativeClassPtr, 100663603);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000AF24 File Offset: 0x00009124
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccountNotFound()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccountNotFound>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountNotFound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002D1B File Offset: 0x00000F1B
		public AccountNotFound(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0000AF60 File Offset: 0x00009160
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002D24 File Offset: 0x00000F24
		public unsafe string Username
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountNotFound.NativeFieldInfoPtr_Username);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountNotFound.NativeFieldInfoPtr_Username), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeFieldInfoPtr_Username;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

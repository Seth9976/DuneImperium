using System;
using dwd.core.account;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace lotus.data.account
{
	// Token: 0x020000FA RID: 250
	public class LotusAccountProvider : Object
	{
		// Token: 0x06000C0D RID: 3085 RVA: 0x000375D8 File Offset: 0x000357D8
		// Note: this type is marked as 'beforefieldinit'.
		static LotusAccountProvider()
		{
			Il2CppClassPointerStore<LotusAccountProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.data.account", "LotusAccountProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LotusAccountProvider>.NativeClassPtr);
			LotusAccountProvider.NativeMethodInfoPtr_dwd_core_account_IAccountFactory_Create_Private_Virtual_Final_New_AccountComponent_SerializableAccount_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LotusAccountProvider>.NativeClassPtr, 100665216);
			LotusAccountProvider.NativeMethodInfoPtr_Create_Public_Static_AccountComponent_SerializableAccount_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LotusAccountProvider>.NativeClassPtr, 100665217);
			LotusAccountProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LotusAccountProvider>.NativeClassPtr, 100665218);
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00037644 File Offset: 0x00035844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995225, XrefRangeEnd = 995226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AccountComponent dwd_core_account_IAccountFactory_Create(SerializableAccount account)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(account);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LotusAccountProvider.NativeMethodInfoPtr_dwd_core_account_IAccountFactory_Create_Private_Virtual_Final_New_AccountComponent_SerializableAccount_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountComponent>(intPtr3) : null;
			}
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x00037694 File Offset: 0x00035894
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 995253, RefRangeEnd = 995254, XrefRangeStart = 995226, XrefRangeEnd = 995253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AccountComponent Create(SerializableAccount account)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(account);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LotusAccountProvider.NativeMethodInfoPtr_Create_Public_Static_AccountComponent_SerializableAccount_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountComponent>(intPtr3) : null;
			}
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x000376D8 File Offset: 0x000358D8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LotusAccountProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LotusAccountProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LotusAccountProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x0000790B File Offset: 0x00005B0B
		public LotusAccountProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_account_IAccountFactory_Create_Private_Virtual_Final_New_AccountComponent_SerializableAccount_0;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AccountComponent_SerializableAccount_0;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

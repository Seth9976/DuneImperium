using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.iap.store
{
	// Token: 0x02000025 RID: 37
	public class StubGetProductOwnershipCommand : GetProductOwnershipCommand
	{
		// Token: 0x0600022F RID: 559 RVA: 0x00002ED8 File Offset: 0x000010D8
		// Note: this type is marked as 'beforefieldinit'.
		static StubGetProductOwnershipCommand()
		{
			Il2CppClassPointerStore<StubGetProductOwnershipCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.store", "StubGetProductOwnershipCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StubGetProductOwnershipCommand>.NativeClassPtr);
			StubGetProductOwnershipCommand.NativeMethodInfoPtr__ctor_Public_Void_IAPStoreModel_Action_1_HashSet_1_IAPProduct_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StubGetProductOwnershipCommand>.NativeClassPtr, 100663745);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000B9C4 File Offset: 0x00009BC4
		[CallerCount(128)]
		[CachedScanResults(RefRangeStart = 998618, RefRangeEnd = 998746, XrefRangeStart = 998618, XrefRangeEnd = 998746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StubGetProductOwnershipCommand(IAPStoreModel storeModel, Action<HashSet<IAPProduct>> onOwnedProducts, Action<string> onFailed)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StubGetProductOwnershipCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storeModel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onOwnedProducts);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFailed);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StubGetProductOwnershipCommand.NativeMethodInfoPtr__ctor_Public_Void_IAPStoreModel_Action_1_HashSet_1_IAPProduct_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002F11 File Offset: 0x00001111
		public StubGetProductOwnershipCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAPStoreModel_Action_1_HashSet_1_IAPProduct_Action_1_String_0;
	}
}

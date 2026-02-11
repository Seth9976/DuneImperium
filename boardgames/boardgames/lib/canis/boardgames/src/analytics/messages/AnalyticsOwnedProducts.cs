using System;
using boardgames.analytics;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace lib.canis.boardgames.src.analytics.messages
{
	// Token: 0x0200003E RID: 62
	public class AnalyticsOwnedProducts : ClientAnalyticsMessage
	{
		// Token: 0x06000281 RID: 641 RVA: 0x000030CB File Offset: 0x000012CB
		// Note: this type is marked as 'beforefieldinit'.
		static AnalyticsOwnedProducts()
		{
			Il2CppClassPointerStore<AnalyticsOwnedProducts>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lib.canis.boardgames.src.analytics.messages", "AnalyticsOwnedProducts");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsOwnedProducts>.NativeClassPtr);
			AnalyticsOwnedProducts.NativeMethodInfoPtr__ctor_Public_Void_AccountID_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsOwnedProducts>.NativeClassPtr, 100663764);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00019278 File Offset: 0x00017478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 985075, RefRangeEnd = 985076, XrefRangeStart = 985056, XrefRangeEnd = 985075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalyticsOwnedProducts(AccountID accountID, List<string> ownedProducts)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsOwnedProducts>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ownedProducts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsOwnedProducts.NativeMethodInfoPtr__ctor_Public_Void_AccountID_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00003104 File Offset: 0x00001304
		public AnalyticsOwnedProducts(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AccountID_List_1_String_0;
	}
}

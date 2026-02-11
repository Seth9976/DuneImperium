using System;
using boardgames.analytics;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace zen.analytics.messages
{
	// Token: 0x02000092 RID: 146
	public class AnalyticsMOTDTile : ClientAnalyticsMessage
	{
		// Token: 0x0600072D RID: 1837 RVA: 0x00005309 File Offset: 0x00003509
		// Note: this type is marked as 'beforefieldinit'.
		static AnalyticsMOTDTile()
		{
			Il2CppClassPointerStore<AnalyticsMOTDTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.analytics.messages", "AnalyticsMOTDTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsMOTDTile>.NativeClassPtr);
			AnalyticsMOTDTile.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsMOTDTile>.NativeClassPtr, 100664461);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0002790C File Offset: 0x00025B0C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 990358, RefRangeEnd = 990363, XrefRangeStart = 990215, XrefRangeEnd = 990358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalyticsMOTDTile(string eventType, string tileID, string tileTitle, string linkUrl, string tileType, string tileState, int displayPosition, string game)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsMOTDTile>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tileID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tileTitle);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(linkUrl);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tileType);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tileState);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref displayPosition;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(game);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsMOTDTile.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00005342 File Offset: 0x00003542
		public AnalyticsMOTDTile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_Int32_String_0;
	}
}

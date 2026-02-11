using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001F3 RID: 499
	[StructLayout(2)]
	public struct NetPingLocation
	{
		// Token: 0x06001923 RID: 6435 RVA: 0x0007A35C File Offset: 0x0007855C
		// Note: this type is marked as 'beforefieldinit'.
		static NetPingLocation()
		{
			Il2CppClassPointerStore<NetPingLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "NetPingLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetPingLocation>.NativeClassPtr);
			NetPingLocation.NativeMethodInfoPtr_TryParseFromString_Public_Static_Nullable_1_NetPingLocation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetPingLocation>.NativeClassPtr, 100667886);
			NetPingLocation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetPingLocation>.NativeClassPtr, 100667887);
			NetPingLocation.NativeMethodInfoPtr_EstimatePingTo_Public_Int32_NetPingLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetPingLocation>.NativeClassPtr, 100667888);
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x0007A3C8 File Offset: 0x000785C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951676, XrefRangeEnd = 951686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<NetPingLocation> TryParseFromString(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetPingLocation.NativeMethodInfoPtr_TryParseFromString_Public_Static_Nullable_1_NetPingLocation_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<NetPingLocation>(intPtr);
			}
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x0007A404 File Offset: 0x00078604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951686, XrefRangeEnd = 951691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetPingLocation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x0007A430 File Offset: 0x00078630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951691, XrefRangeEnd = 951696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EstimatePingTo(NetPingLocation target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetPingLocation.NativeMethodInfoPtr_EstimatePingTo_Public_Int32_NetPingLocation_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x0000826C File Offset: 0x0000646C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetPingLocation>.NativeClassPtr, ref this));
		}

		// Token: 0x04001E6B RID: 7787
		private static readonly IntPtr NativeMethodInfoPtr_TryParseFromString_Public_Static_Nullable_1_NetPingLocation_String_0;

		// Token: 0x04001E6C RID: 7788
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001E6D RID: 7789
		private static readonly IntPtr NativeMethodInfoPtr_EstimatePingTo_Public_Int32_NetPingLocation_0;
	}
}

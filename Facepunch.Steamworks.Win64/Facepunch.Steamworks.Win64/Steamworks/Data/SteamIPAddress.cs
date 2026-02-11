using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net;

namespace Steamworks.Data
{
	// Token: 0x020001B8 RID: 440
	[StructLayout(2)]
	public struct SteamIPAddress
	{
		// Token: 0x0600164D RID: 5709 RVA: 0x0006E60C File Offset: 0x0006C80C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamIPAddress()
		{
			Il2CppClassPointerStore<SteamIPAddress>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamIPAddress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamIPAddress>.NativeClassPtr);
			SteamIPAddress.NativeFieldInfoPtr_Ip4Address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamIPAddress>.NativeClassPtr, "Ip4Address");
			SteamIPAddress.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamIPAddress>.NativeClassPtr, "Type");
			SteamIPAddress.NativeMethodInfoPtr_InternalIsSet_Internal_Static_Boolean_byref_SteamIPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIPAddress>.NativeClassPtr, 100667409);
			SteamIPAddress.NativeMethodInfoPtr_op_Implicit_Public_Static_IPAddress_SteamIPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIPAddress>.NativeClassPtr, 100667410);
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x0006E68C File Offset: 0x0006C88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951157, XrefRangeEnd = 951159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalIsSet(ref SteamIPAddress self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIPAddress.NativeMethodInfoPtr_InternalIsSet_Internal_Static_Boolean_byref_SteamIPAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x0006E6CC File Offset: 0x0006C8CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951184, RefRangeEnd = 951185, XrefRangeStart = 951159, XrefRangeEnd = 951184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator IPAddress(SteamIPAddress value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIPAddress.NativeMethodInfoPtr_op_Implicit_Public_Static_IPAddress_SteamIPAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr3) : null;
			}
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x00007700 File Offset: 0x00005900
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamIPAddress>.NativeClassPtr, ref this));
		}

		// Token: 0x04001B8B RID: 7051
		private static readonly IntPtr NativeFieldInfoPtr_Ip4Address;

		// Token: 0x04001B8C RID: 7052
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x04001B8D RID: 7053
		private static readonly IntPtr NativeMethodInfoPtr_InternalIsSet_Internal_Static_Boolean_byref_SteamIPAddress_0;

		// Token: 0x04001B8E RID: 7054
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_IPAddress_SteamIPAddress_0;

		// Token: 0x04001B8F RID: 7055
		[FieldOffset(0)]
		public uint Ip4Address;

		// Token: 0x04001B90 RID: 7056
		[FieldOffset(16)]
		public SteamIPType Type;
	}
}

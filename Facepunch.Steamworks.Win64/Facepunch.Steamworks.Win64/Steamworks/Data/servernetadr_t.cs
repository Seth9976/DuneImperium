using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001B6 RID: 438
	[StructLayout(2)]
	public struct servernetadr_t
	{
		// Token: 0x06001634 RID: 5684 RVA: 0x0006DF78 File Offset: 0x0006C178
		// Note: this type is marked as 'beforefieldinit'.
		static servernetadr_t()
		{
			Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "servernetadr_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr);
			servernetadr_t.NativeFieldInfoPtr_ConnectionPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, "ConnectionPort");
			servernetadr_t.NativeFieldInfoPtr_QueryPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, "QueryPort");
			servernetadr_t.NativeFieldInfoPtr_IP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, "IP");
			servernetadr_t.NativeMethodInfoPtr_InternalConstruct_Internal_Static_Void_byref_servernetadr_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100667393);
			servernetadr_t.NativeMethodInfoPtr_InternalInit_Internal_Static_Void_byref_servernetadr_t_UInt32_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100667394);
			servernetadr_t.NativeMethodInfoPtr_InternalGetQueryPort_Internal_Static_UInt16_byref_servernetadr_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100667395);
			servernetadr_t.NativeMethodInfoPtr_InternalSetQueryPort_Internal_Static_Void_byref_servernetadr_t_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100667396);
			servernetadr_t.NativeMethodInfoPtr_InternalGetConnectionPort_Internal_Static_UInt16_byref_servernetadr_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100667397);
			servernetadr_t.NativeMethodInfoPtr_InternalSetConnectionPort_Internal_Static_Void_byref_servernetadr_t_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100667398);
			servernetadr_t.NativeMethodInfoPtr_InternalGetIP_Internal_Static_UInt32_byref_servernetadr_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100667399);
			servernetadr_t.NativeMethodInfoPtr_InternalSetIP_Internal_Static_Void_byref_servernetadr_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100667400);
			servernetadr_t.NativeMethodInfoPtr_InternalGetConnectionAddressString_Internal_Static_Utf8StringPointer_byref_servernetadr_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100667401);
			servernetadr_t.NativeMethodInfoPtr_InternalGetQueryAddressString_Internal_Static_Utf8StringPointer_byref_servernetadr_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100667402);
			servernetadr_t.NativeMethodInfoPtr_InternalIsLessThan_Internal_Static_Boolean_byref_servernetadr_t_byref_servernetadr_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100667403);
			servernetadr_t.NativeMethodInfoPtr_InternalAssign_Internal_Static_Void_byref_servernetadr_t_byref_servernetadr_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100667404);
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x0006E0D4 File Offset: 0x0006C2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951117, XrefRangeEnd = 951119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalConstruct(ref servernetadr_t self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_InternalConstruct_Internal_Static_Void_byref_servernetadr_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x0006E108 File Offset: 0x0006C308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951119, XrefRangeEnd = 951121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalInit(ref servernetadr_t self, uint ip, ushort usQueryPort, ushort usConnectionPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ip;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usQueryPort;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usConnectionPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_InternalInit_Internal_Static_Void_byref_servernetadr_t_UInt32_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x0006E164 File Offset: 0x0006C364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951121, XrefRangeEnd = 951123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort InternalGetQueryPort(ref servernetadr_t self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_InternalGetQueryPort_Internal_Static_UInt16_byref_servernetadr_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x0006E1A4 File Offset: 0x0006C3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951123, XrefRangeEnd = 951125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetQueryPort(ref servernetadr_t self, ushort usPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_InternalSetQueryPort_Internal_Static_Void_byref_servernetadr_t_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x0006E1E4 File Offset: 0x0006C3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951125, XrefRangeEnd = 951127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort InternalGetConnectionPort(ref servernetadr_t self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_InternalGetConnectionPort_Internal_Static_UInt16_byref_servernetadr_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x0006E224 File Offset: 0x0006C424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951127, XrefRangeEnd = 951129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetConnectionPort(ref servernetadr_t self, ushort usPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_InternalSetConnectionPort_Internal_Static_Void_byref_servernetadr_t_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x0006E264 File Offset: 0x0006C464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951129, XrefRangeEnd = 951131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint InternalGetIP(ref servernetadr_t self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_InternalGetIP_Internal_Static_UInt32_byref_servernetadr_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x0006E2A4 File Offset: 0x0006C4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951131, XrefRangeEnd = 951133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetIP(ref servernetadr_t self, uint unIP)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unIP;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_InternalSetIP_Internal_Static_Void_byref_servernetadr_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x0006E2E4 File Offset: 0x0006C4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951133, XrefRangeEnd = 951135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer InternalGetConnectionAddressString(ref servernetadr_t self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_InternalGetConnectionAddressString_Internal_Static_Utf8StringPointer_byref_servernetadr_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x0006E324 File Offset: 0x0006C524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951135, XrefRangeEnd = 951137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer InternalGetQueryAddressString(ref servernetadr_t self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_InternalGetQueryAddressString_Internal_Static_Utf8StringPointer_byref_servernetadr_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x0006E364 File Offset: 0x0006C564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951137, XrefRangeEnd = 951139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalIsLessThan(ref servernetadr_t self, ref servernetadr_t netadr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &netadr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_InternalIsLessThan_Internal_Static_Boolean_byref_servernetadr_t_byref_servernetadr_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x0006E3B0 File Offset: 0x0006C5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951139, XrefRangeEnd = 951141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalAssign(ref servernetadr_t self, ref servernetadr_t that)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &that;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_InternalAssign_Internal_Static_Void_byref_servernetadr_t_byref_servernetadr_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x00007699 File Offset: 0x00005899
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04001B73 RID: 7027
		private static readonly IntPtr NativeFieldInfoPtr_ConnectionPort;

		// Token: 0x04001B74 RID: 7028
		private static readonly IntPtr NativeFieldInfoPtr_QueryPort;

		// Token: 0x04001B75 RID: 7029
		private static readonly IntPtr NativeFieldInfoPtr_IP;

		// Token: 0x04001B76 RID: 7030
		private static readonly IntPtr NativeMethodInfoPtr_InternalConstruct_Internal_Static_Void_byref_servernetadr_t_0;

		// Token: 0x04001B77 RID: 7031
		private static readonly IntPtr NativeMethodInfoPtr_InternalInit_Internal_Static_Void_byref_servernetadr_t_UInt32_UInt16_UInt16_0;

		// Token: 0x04001B78 RID: 7032
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetQueryPort_Internal_Static_UInt16_byref_servernetadr_t_0;

		// Token: 0x04001B79 RID: 7033
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetQueryPort_Internal_Static_Void_byref_servernetadr_t_UInt16_0;

		// Token: 0x04001B7A RID: 7034
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetConnectionPort_Internal_Static_UInt16_byref_servernetadr_t_0;

		// Token: 0x04001B7B RID: 7035
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetConnectionPort_Internal_Static_Void_byref_servernetadr_t_UInt16_0;

		// Token: 0x04001B7C RID: 7036
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetIP_Internal_Static_UInt32_byref_servernetadr_t_0;

		// Token: 0x04001B7D RID: 7037
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetIP_Internal_Static_Void_byref_servernetadr_t_UInt32_0;

		// Token: 0x04001B7E RID: 7038
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetConnectionAddressString_Internal_Static_Utf8StringPointer_byref_servernetadr_t_0;

		// Token: 0x04001B7F RID: 7039
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetQueryAddressString_Internal_Static_Utf8StringPointer_byref_servernetadr_t_0;

		// Token: 0x04001B80 RID: 7040
		private static readonly IntPtr NativeMethodInfoPtr_InternalIsLessThan_Internal_Static_Boolean_byref_servernetadr_t_byref_servernetadr_t_0;

		// Token: 0x04001B81 RID: 7041
		private static readonly IntPtr NativeMethodInfoPtr_InternalAssign_Internal_Static_Void_byref_servernetadr_t_byref_servernetadr_t_0;

		// Token: 0x04001B82 RID: 7042
		[FieldOffset(0)]
		public ushort ConnectionPort;

		// Token: 0x04001B83 RID: 7043
		[FieldOffset(2)]
		public ushort QueryPort;

		// Token: 0x04001B84 RID: 7044
		[FieldOffset(4)]
		public uint IP;
	}
}

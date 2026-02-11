using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001F4 RID: 500
	[StructLayout(2)]
	public struct Socket
	{
		// Token: 0x06001928 RID: 6440 RVA: 0x0007A470 File Offset: 0x00078670
		// Note: this type is marked as 'beforefieldinit'.
		static Socket()
		{
			Il2CppClassPointerStore<Socket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "Socket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Socket>.NativeClassPtr);
			Socket.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Socket>.NativeClassPtr, "Id");
			Socket.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667889);
			Socket.NativeMethodInfoPtr_op_Implicit_Public_Static_Socket_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667890);
			Socket.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667891);
			Socket.NativeMethodInfoPtr_Close_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667892);
			Socket.NativeMethodInfoPtr_get_Manager_Public_get_SocketManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667893);
			Socket.NativeMethodInfoPtr_set_Manager_Public_set_Void_SocketManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Socket>.NativeClassPtr, 100667894);
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x0007A52C File Offset: 0x0007872C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 946095, RefRangeEnd = 946098, XrefRangeStart = 946095, XrefRangeEnd = 946098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x0007A558 File Offset: 0x00078758
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Socket(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_op_Implicit_Public_Static_Socket_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x0007A598 File Offset: 0x00078798
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator uint(Socket value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_Socket_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x0007A5D8 File Offset: 0x000787D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951702, RefRangeEnd = 951703, XrefRangeStart = 951696, XrefRangeEnd = 951702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Close()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_Close_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x0600192D RID: 6445 RVA: 0x0007A608 File Offset: 0x00078808
		// (set) Token: 0x0600192E RID: 6446 RVA: 0x0007A63C File Offset: 0x0007883C
		public unsafe SocketManager Manager
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951703, XrefRangeEnd = 951707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_get_Manager_Public_get_SocketManager_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SocketManager>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951707, XrefRangeEnd = 951723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Socket.NativeMethodInfoPtr_set_Manager_Public_set_Void_SocketManager_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x0000827E File Offset: 0x0000647E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Socket>.NativeClassPtr, ref this));
		}

		// Token: 0x04001E6E RID: 7790
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x04001E6F RID: 7791
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001E70 RID: 7792
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Socket_UInt32_0;

		// Token: 0x04001E71 RID: 7793
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_Socket_0;

		// Token: 0x04001E72 RID: 7794
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Boolean_0;

		// Token: 0x04001E73 RID: 7795
		private static readonly IntPtr NativeMethodInfoPtr_get_Manager_Public_get_SocketManager_0;

		// Token: 0x04001E74 RID: 7796
		private static readonly IntPtr NativeMethodInfoPtr_set_Manager_Public_set_Void_SocketManager_0;

		// Token: 0x04001E75 RID: 7797
		[FieldOffset(0)]
		public uint Id;
	}
}

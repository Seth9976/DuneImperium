using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Sockets;

namespace Il2CppSystem.Net
{
	// Token: 0x020001AB RID: 427
	[Serializable]
	public class EndPoint : Object
	{
		// Token: 0x06001AAB RID: 6827 RVA: 0x00084CC8 File Offset: 0x00082EC8
		// Note: this type is marked as 'beforefieldinit'.
		static EndPoint()
		{
			Il2CppClassPointerStore<EndPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "EndPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndPoint>.NativeClassPtr);
			EndPoint.NativeMethodInfoPtr_get_AddressFamily_Public_Virtual_New_get_AddressFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPoint>.NativeClassPtr, 100667447);
			EndPoint.NativeMethodInfoPtr_Serialize_Public_Virtual_New_SocketAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPoint>.NativeClassPtr, 100667448);
			EndPoint.NativeMethodInfoPtr_Create_Public_Virtual_New_EndPoint_SocketAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPoint>.NativeClassPtr, 100667449);
			EndPoint.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPoint>.NativeClassPtr, 100667450);
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06001AAC RID: 6828 RVA: 0x00084D48 File Offset: 0x00082F48
		public unsafe virtual AddressFamily AddressFamily
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474044, XrefRangeEnd = 474047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EndPoint.NativeMethodInfoPtr_get_AddressFamily_Public_Virtual_New_get_AddressFamily_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x00084D90 File Offset: 0x00082F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474047, XrefRangeEnd = 474050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SocketAddress Serialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EndPoint.NativeMethodInfoPtr_Serialize_Public_Virtual_New_SocketAddress_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SocketAddress>(intPtr3) : null;
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x00084DDC File Offset: 0x00082FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474050, XrefRangeEnd = 474053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EndPoint Create(SocketAddress socketAddress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(socketAddress);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EndPoint.NativeMethodInfoPtr_Create_Public_Virtual_New_EndPoint_SocketAddress_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EndPoint>(intPtr3) : null;
			}
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x00084E38 File Offset: 0x00083038
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EndPoint()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndPoint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndPoint.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x0000B6BC File Offset: 0x000098BC
		public EndPoint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001501 RID: 5377
		private static readonly IntPtr NativeMethodInfoPtr_get_AddressFamily_Public_Virtual_New_get_AddressFamily_0;

		// Token: 0x04001502 RID: 5378
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_New_SocketAddress_0;

		// Token: 0x04001503 RID: 5379
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_New_EndPoint_SocketAddress_0;

		// Token: 0x04001504 RID: 5380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

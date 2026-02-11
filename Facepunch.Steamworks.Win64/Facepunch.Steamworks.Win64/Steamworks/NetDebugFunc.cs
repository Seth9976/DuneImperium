using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000093 RID: 147
	public sealed class NetDebugFunc : MulticastDelegate
	{
		// Token: 0x06000825 RID: 2085 RVA: 0x00041690 File Offset: 0x0003F890
		// Note: this type is marked as 'beforefieldinit'.
		static NetDebugFunc()
		{
			Il2CppClassPointerStore<NetDebugFunc>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "NetDebugFunc");
			NetDebugFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetDebugFunc>.NativeClassPtr, 100665264);
			NetDebugFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_NetDebugOutput_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetDebugFunc>.NativeClassPtr, 100665265);
			NetDebugFunc.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NetDebugOutput_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetDebugFunc>.NativeClassPtr, 100665266);
			NetDebugFunc.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetDebugFunc>.NativeClassPtr, 100665267);
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00041708 File Offset: 0x0003F908
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 474619, RefRangeEnd = 474622, XrefRangeStart = 474619, XrefRangeEnd = 474622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetDebugFunc(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetDebugFunc>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetDebugFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00041764 File Offset: 0x0003F964
		[CallerCount(0)]
		public unsafe void Invoke([In] NetDebugOutput nType, [In] IntPtr pszMsg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pszMsg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetDebugFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_NetDebugOutput_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x000417B0 File Offset: 0x0003F9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936945, XrefRangeEnd = 936952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke([In] NetDebugOutput nType, [In] IntPtr pszMsg, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pszMsg;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetDebugFunc.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NetDebugOutput_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00041830 File Offset: 0x0003FA30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetDebugFunc.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00002568 File Offset: 0x00000768
		public NetDebugFunc(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00002571 File Offset: 0x00000771
		public static implicit operator NetDebugFunc(Action<NetDebugOutput, IntPtr> A_0)
		{
			return DelegateSupport.ConvertDelegate<NetDebugFunc>(A_0);
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00002579 File Offset: 0x00000779
		public static NetDebugFunc operator +(NetDebugFunc A_0, NetDebugFunc A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<NetDebugFunc>();
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00002587 File Offset: 0x00000787
		public static NetDebugFunc operator -(NetDebugFunc A_0, NetDebugFunc A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<NetDebugFunc>();
			}
			return delegate2;
		}

		// Token: 0x04000F6E RID: 3950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000F6F RID: 3951
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_NetDebugOutput_IntPtr_0;

		// Token: 0x04000F70 RID: 3952
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NetDebugOutput_IntPtr_AsyncCallback_Object_0;

		// Token: 0x04000F71 RID: 3953
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}

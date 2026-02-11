using System;
using Canis.attributes;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.selectionfilters
{
	// Token: 0x02000055 RID: 85
	public sealed class GetAttrsFunc : MulticastDelegate
	{
		// Token: 0x06000516 RID: 1302 RVA: 0x0002D2A0 File Offset: 0x0002B4A0
		// Note: this type is marked as 'beforefieldinit'.
		static GetAttrsFunc()
		{
			Il2CppClassPointerStore<GetAttrsFunc>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.selectionfilters", "GetAttrsFunc");
			GetAttrsFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetAttrsFunc>.NativeClassPtr, 100664344);
			GetAttrsFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerable_1_IAttribute_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetAttrsFunc>.NativeClassPtr, 100664345);
			GetAttrsFunc.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NetworkMessageEvent_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetAttrsFunc>.NativeClassPtr, 100664346);
			GetAttrsFunc.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerable_1_IAttribute_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetAttrsFunc>.NativeClassPtr, 100664347);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0002D318 File Offset: 0x0002B518
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 554431, RefRangeEnd = 554456, XrefRangeStart = 554422, XrefRangeEnd = 554431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetAttrsFunc(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetAttrsFunc>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetAttrsFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0002D374 File Offset: 0x0002B574
		[CallerCount(0)]
		public unsafe IEnumerable<IAttribute> Invoke(NetworkMessageEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetAttrsFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerable_1_IAttribute_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0002D3C4 File Offset: 0x0002B5C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 479320, RefRangeEnd = 479322, XrefRangeStart = 479320, XrefRangeEnd = 479322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(NetworkMessageEvent evt, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetAttrsFunc.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NetworkMessageEvent_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0002D438 File Offset: 0x0002B638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<IAttribute> EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetAttrsFunc.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerable_1_IAttribute_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x000043AB File Offset: 0x000025AB
		public GetAttrsFunc(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x000043B4 File Offset: 0x000025B4
		public static implicit operator GetAttrsFunc(Func<NetworkMessageEvent, IEnumerable<IAttribute>> A_0)
		{
			return DelegateSupport.ConvertDelegate<GetAttrsFunc>(A_0);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x000043BC File Offset: 0x000025BC
		public static GetAttrsFunc operator +(GetAttrsFunc A_0, GetAttrsFunc A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<GetAttrsFunc>();
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x000043CA File Offset: 0x000025CA
		public static GetAttrsFunc operator -(GetAttrsFunc A_0, GetAttrsFunc A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<GetAttrsFunc>();
			}
			return delegate2;
		}

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerable_1_IAttribute_NetworkMessageEvent_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NetworkMessageEvent_AsyncCallback_Object_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerable_1_IAttribute_IAsyncResult_0;
	}
}

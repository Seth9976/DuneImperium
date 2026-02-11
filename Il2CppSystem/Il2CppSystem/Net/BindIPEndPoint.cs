using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001EC RID: 492
	public sealed class BindIPEndPoint : MulticastDelegate
	{
		// Token: 0x06001E99 RID: 7833 RVA: 0x00092F14 File Offset: 0x00091114
		// Note: this type is marked as 'beforefieldinit'.
		static BindIPEndPoint()
		{
			Il2CppClassPointerStore<BindIPEndPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "BindIPEndPoint");
			BindIPEndPoint.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindIPEndPoint>.NativeClassPtr, 100667956);
			BindIPEndPoint.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IPEndPoint_ServicePoint_IPEndPoint_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindIPEndPoint>.NativeClassPtr, 100667957);
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x00092F64 File Offset: 0x00091164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478740, XrefRangeEnd = 478749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindIPEndPoint(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindIPEndPoint>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindIPEndPoint.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x00092FC0 File Offset: 0x000911C0
		[CallerCount(0)]
		public unsafe IPEndPoint Invoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(servicePoint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteEndPoint);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref retryCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindIPEndPoint.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IPEndPoint_ServicePoint_IPEndPoint_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr3) : null;
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x0000D023 File Offset: 0x0000B223
		public BindIPEndPoint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x0000D02C File Offset: 0x0000B22C
		public static implicit operator BindIPEndPoint(Func<ServicePoint, IPEndPoint, int, IPEndPoint> A_0)
		{
			return DelegateSupport.ConvertDelegate<BindIPEndPoint>(A_0);
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x0000D034 File Offset: 0x0000B234
		public static BindIPEndPoint operator +(BindIPEndPoint A_0, BindIPEndPoint A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<BindIPEndPoint>();
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x0000D042 File Offset: 0x0000B242
		public static BindIPEndPoint operator -(BindIPEndPoint A_0, BindIPEndPoint A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<BindIPEndPoint>();
			}
			return delegate2;
		}

		// Token: 0x04001831 RID: 6193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001832 RID: 6194
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IPEndPoint_ServicePoint_IPEndPoint_Int32_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Btls
{
	// Token: 0x02000032 RID: 50
	public sealed class MonoBtlsVerifyCallback : MulticastDelegate
	{
		// Token: 0x0600030E RID: 782 RVA: 0x0002731C File Offset: 0x0002551C
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsVerifyCallback()
		{
			Il2CppClassPointerStore<MonoBtlsVerifyCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsVerifyCallback");
			MonoBtlsVerifyCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsVerifyCallback>.NativeClassPtr, 100663842);
			MonoBtlsVerifyCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_MonoBtlsX509StoreCtx_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsVerifyCallback>.NativeClassPtr, 100663843);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0002736C File Offset: 0x0002556C
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 430614, RefRangeEnd = 430638, XrefRangeStart = 430605, XrefRangeEnd = 430614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsVerifyCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsVerifyCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsVerifyCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x000273C8 File Offset: 0x000255C8
		[CallerCount(0)]
		public unsafe int Invoke(MonoBtlsX509StoreCtx ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsVerifyCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_MonoBtlsX509StoreCtx_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000311 RID: 785 RVA: 0x000030BD File Offset: 0x000012BD
		public MonoBtlsVerifyCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000312 RID: 786 RVA: 0x000030C6 File Offset: 0x000012C6
		public static implicit operator MonoBtlsVerifyCallback(Func<MonoBtlsX509StoreCtx, int> A_0)
		{
			return DelegateSupport.ConvertDelegate<MonoBtlsVerifyCallback>(A_0);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x000030CE File Offset: 0x000012CE
		public static MonoBtlsVerifyCallback operator +(MonoBtlsVerifyCallback A_0, MonoBtlsVerifyCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<MonoBtlsVerifyCallback>();
		}

		// Token: 0x06000314 RID: 788 RVA: 0x000030DC File Offset: 0x000012DC
		public static MonoBtlsVerifyCallback operator -(MonoBtlsVerifyCallback A_0, MonoBtlsVerifyCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<MonoBtlsVerifyCallback>();
			}
			return delegate2;
		}

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_MonoBtlsX509StoreCtx_0;
	}
}

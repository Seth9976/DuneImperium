using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace JsonFx.CodeGen
{
	// Token: 0x02000037 RID: 55
	public sealed class ProxyDelegate : MulticastDelegate
	{
		// Token: 0x060002FF RID: 767 RVA: 0x0000EEBC File Offset: 0x0000D0BC
		// Note: this type is marked as 'beforefieldinit'.
		static ProxyDelegate()
		{
			Il2CppClassPointerStore<ProxyDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.CodeGen", "ProxyDelegate");
			ProxyDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyDelegate>.NativeClassPtr, 100663761);
			ProxyDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyDelegate>.NativeClassPtr, 100663762);
			ProxyDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Il2CppReferenceArray_1_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyDelegate>.NativeClassPtr, 100663763);
			ProxyDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Object_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyDelegate>.NativeClassPtr, 100663764);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000EF34 File Offset: 0x0000D134
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 744653, RefRangeEnd = 744684, XrefRangeStart = 744653, XrefRangeEnd = 744684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProxyDelegate(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProxyDelegate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000EF90 File Offset: 0x0000D190
		[CallerCount(0)]
		public unsafe Object Invoke(Object target, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000F000 File Offset: 0x0000D200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(Object target, Il2CppReferenceArray<Object> args, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Il2CppReferenceArray_1_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000F088 File Offset: 0x0000D288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Object_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x000031CF File Offset: 0x000013CF
		public ProxyDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000305 RID: 773 RVA: 0x000031D8 File Offset: 0x000013D8
		public static implicit operator ProxyDelegate(Func<Object, Il2CppReferenceArray<Object>, Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<ProxyDelegate>(A_0);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x000031E0 File Offset: 0x000013E0
		public static ProxyDelegate operator +(ProxyDelegate A_0, ProxyDelegate A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ProxyDelegate>();
		}

		// Token: 0x06000307 RID: 775 RVA: 0x000031EE File Offset: 0x000013EE
		public static ProxyDelegate operator -(ProxyDelegate A_0, ProxyDelegate A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ProxyDelegate>();
			}
			return delegate2;
		}

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Object_Il2CppReferenceArray_1_Object_AsyncCallback_Object_0;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Object_IAsyncResult_0;
	}
}

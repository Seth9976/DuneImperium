using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace ImaginationOverflow.UniversalDeepLinking
{
	// Token: 0x0200000A RID: 10
	public sealed class LinkActivationHandler : MulticastDelegate
	{
		// Token: 0x06000076 RID: 118 RVA: 0x000044CC File Offset: 0x000026CC
		// Note: this type is marked as 'beforefieldinit'.
		static LinkActivationHandler()
		{
			Il2CppClassPointerStore<LinkActivationHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UniversalDeepLinking.dll", "ImaginationOverflow.UniversalDeepLinking", "LinkActivationHandler");
			LinkActivationHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkActivationHandler>.NativeClassPtr, 100663396);
			LinkActivationHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LinkActivation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkActivationHandler>.NativeClassPtr, 100663397);
			LinkActivationHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LinkActivation_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkActivationHandler>.NativeClassPtr, 100663398);
			LinkActivationHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkActivationHandler>.NativeClassPtr, 100663399);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00004544 File Offset: 0x00002744
		[CallerCount(333)]
		[CachedScanResults(RefRangeStart = 312876, RefRangeEnd = 313209, XrefRangeStart = 312876, XrefRangeEnd = 313209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LinkActivationHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinkActivationHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkActivationHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000045A0 File Offset: 0x000027A0
		[CallerCount(0)]
		public unsafe void Invoke(LinkActivation s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkActivationHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LinkActivation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000045E4 File Offset: 0x000027E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 479320, RefRangeEnd = 479322, XrefRangeStart = 479320, XrefRangeEnd = 479322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(LinkActivation s, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkActivationHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LinkActivation_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00004658 File Offset: 0x00002858
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkActivationHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000022DE File Offset: 0x000004DE
		public LinkActivationHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000022E7 File Offset: 0x000004E7
		public static implicit operator LinkActivationHandler(Action<LinkActivation> A_0)
		{
			return DelegateSupport.ConvertDelegate<LinkActivationHandler>(A_0);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000022EF File Offset: 0x000004EF
		public static LinkActivationHandler operator +(LinkActivationHandler A_0, LinkActivationHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<LinkActivationHandler>();
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000022FD File Offset: 0x000004FD
		public static LinkActivationHandler operator -(LinkActivationHandler A_0, LinkActivationHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<LinkActivationHandler>();
			}
			return delegate2;
		}

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LinkActivation_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LinkActivation_AsyncCallback_Object_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}

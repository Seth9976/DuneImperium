using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000127 RID: 295
	public sealed class RefreshEventHandler : MulticastDelegate
	{
		// Token: 0x0600122A RID: 4650 RVA: 0x00061CB8 File Offset: 0x0005FEB8
		// Note: this type is marked as 'beforefieldinit'.
		static RefreshEventHandler()
		{
			Il2CppClassPointerStore<RefreshEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "RefreshEventHandler");
			RefreshEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefreshEventHandler>.NativeClassPtr, 100665945);
			RefreshEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RefreshEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefreshEventHandler>.NativeClassPtr, 100665946);
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x00061D08 File Offset: 0x0005FF08
		[CallerCount(333)]
		[CachedScanResults(RefRangeStart = 312876, RefRangeEnd = 313209, XrefRangeStart = 312876, XrefRangeEnd = 313209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RefreshEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RefreshEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefreshEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x00061D64 File Offset: 0x0005FF64
		[CallerCount(0)]
		public unsafe void Invoke(RefreshEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefreshEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RefreshEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x0000867E File Offset: 0x0000687E
		public RefreshEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x00008687 File Offset: 0x00006887
		public static implicit operator RefreshEventHandler(Action<RefreshEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<RefreshEventHandler>(A_0);
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x0000868F File Offset: 0x0000688F
		public static RefreshEventHandler operator +(RefreshEventHandler A_0, RefreshEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<RefreshEventHandler>();
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x0000869D File Offset: 0x0000689D
		public static RefreshEventHandler operator -(RefreshEventHandler A_0, RefreshEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<RefreshEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000E7F RID: 3711
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000E80 RID: 3712
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RefreshEventArgs_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x02000179 RID: 377
	public sealed class RenamedEventHandler : MulticastDelegate
	{
		// Token: 0x0600170C RID: 5900 RVA: 0x00076A30 File Offset: 0x00074C30
		// Note: this type is marked as 'beforefieldinit'.
		static RenamedEventHandler()
		{
			Il2CppClassPointerStore<RenamedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.IO", "RenamedEventHandler");
			RenamedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenamedEventHandler>.NativeClassPtr, 100666963);
			RenamedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_RenamedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenamedEventHandler>.NativeClassPtr, 100666964);
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x00076A80 File Offset: 0x00074C80
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenamedEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenamedEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenamedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x00076ADC File Offset: 0x00074CDC
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, RenamedEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenamedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_RenamedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x00009EE7 File Offset: 0x000080E7
		public RenamedEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x00009EF0 File Offset: 0x000080F0
		public static implicit operator RenamedEventHandler(Action<Object, RenamedEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<RenamedEventHandler>(A_0);
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x00009EF8 File Offset: 0x000080F8
		public static RenamedEventHandler operator +(RenamedEventHandler A_0, RenamedEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<RenamedEventHandler>();
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x00009F06 File Offset: 0x00008106
		public static RenamedEventHandler operator -(RenamedEventHandler A_0, RenamedEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<RenamedEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x040011FC RID: 4604
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040011FD RID: 4605
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_RenamedEventArgs_0;
	}
}

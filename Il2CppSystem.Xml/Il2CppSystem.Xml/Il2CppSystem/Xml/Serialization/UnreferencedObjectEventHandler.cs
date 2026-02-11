using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000BA RID: 186
	public sealed class UnreferencedObjectEventHandler : MulticastDelegate
	{
		// Token: 0x0600129A RID: 4762 RVA: 0x00067DD4 File Offset: 0x00065FD4
		// Note: this type is marked as 'beforefieldinit'.
		static UnreferencedObjectEventHandler()
		{
			Il2CppClassPointerStore<UnreferencedObjectEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "UnreferencedObjectEventHandler");
			UnreferencedObjectEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnreferencedObjectEventHandler>.NativeClassPtr, 100666347);
			UnreferencedObjectEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_UnreferencedObjectEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnreferencedObjectEventHandler>.NativeClassPtr, 100666348);
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x00067E24 File Offset: 0x00066024
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnreferencedObjectEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnreferencedObjectEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnreferencedObjectEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x00067E80 File Offset: 0x00066080
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, UnreferencedObjectEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnreferencedObjectEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_UnreferencedObjectEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x00007E50 File Offset: 0x00006050
		public UnreferencedObjectEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x00007E59 File Offset: 0x00006059
		public static implicit operator UnreferencedObjectEventHandler(Action<Object, UnreferencedObjectEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<UnreferencedObjectEventHandler>(A_0);
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00007E61 File Offset: 0x00006061
		public static UnreferencedObjectEventHandler operator +(UnreferencedObjectEventHandler A_0, UnreferencedObjectEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UnreferencedObjectEventHandler>();
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00007E6F File Offset: 0x0000606F
		public static UnreferencedObjectEventHandler operator -(UnreferencedObjectEventHandler A_0, UnreferencedObjectEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UnreferencedObjectEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000F28 RID: 3880
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000F29 RID: 3881
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_UnreferencedObjectEventArgs_0;
	}
}

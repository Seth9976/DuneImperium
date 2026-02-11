using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000112 RID: 274
	public sealed class ConsoleCancelEventHandler : MulticastDelegate
	{
		// Token: 0x06001251 RID: 4689 RVA: 0x0007E0BC File Offset: 0x0007C2BC
		// Note: this type is marked as 'beforefieldinit'.
		static ConsoleCancelEventHandler()
		{
			Il2CppClassPointerStore<ConsoleCancelEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ConsoleCancelEventHandler");
			ConsoleCancelEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCancelEventHandler>.NativeClassPtr, 100666490);
			ConsoleCancelEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_ConsoleCancelEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCancelEventHandler>.NativeClassPtr, 100666491);
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x0007E10C File Offset: 0x0007C30C
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConsoleCancelEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsoleCancelEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleCancelEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x0007E168 File Offset: 0x0007C368
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, ConsoleCancelEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleCancelEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_ConsoleCancelEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x000060F3 File Offset: 0x000042F3
		public ConsoleCancelEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x000060FC File Offset: 0x000042FC
		public static implicit operator ConsoleCancelEventHandler(Action<Object, ConsoleCancelEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<ConsoleCancelEventHandler>(A_0);
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x00006104 File Offset: 0x00004304
		public static ConsoleCancelEventHandler operator +(ConsoleCancelEventHandler A_0, ConsoleCancelEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ConsoleCancelEventHandler>();
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x00006112 File Offset: 0x00004312
		public static ConsoleCancelEventHandler operator -(ConsoleCancelEventHandler A_0, ConsoleCancelEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ConsoleCancelEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000EF7 RID: 3831
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000EF8 RID: 3832
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_ConsoleCancelEventArgs_0;
	}
}

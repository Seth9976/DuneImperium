using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x020000DE RID: 222
	public sealed class ResolveEventHandler : MulticastDelegate
	{
		// Token: 0x06000E57 RID: 3671 RVA: 0x00068C64 File Offset: 0x00066E64
		// Note: this type is marked as 'beforefieldinit'.
		static ResolveEventHandler()
		{
			Il2CppClassPointerStore<ResolveEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ResolveEventHandler");
			ResolveEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveEventHandler>.NativeClassPtr, 100665802);
			ResolveEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Assembly_Object_ResolveEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveEventHandler>.NativeClassPtr, 100665803);
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x00068CB4 File Offset: 0x00066EB4
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 744653, RefRangeEnd = 744684, XrefRangeStart = 744653, XrefRangeEnd = 744684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResolveEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x00068D10 File Offset: 0x00066F10
		[CallerCount(0)]
		public unsafe Assembly Invoke(Object sender, ResolveEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Assembly_Object_ResolveEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x000057D2 File Offset: 0x000039D2
		public ResolveEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x000057DB File Offset: 0x000039DB
		public static implicit operator ResolveEventHandler(Func<Object, ResolveEventArgs, Assembly> A_0)
		{
			return DelegateSupport.ConvertDelegate<ResolveEventHandler>(A_0);
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x000057E3 File Offset: 0x000039E3
		public static ResolveEventHandler operator +(ResolveEventHandler A_0, ResolveEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ResolveEventHandler>();
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x000057F1 File Offset: 0x000039F1
		public static ResolveEventHandler operator -(ResolveEventHandler A_0, ResolveEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ResolveEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Assembly_Object_ResolveEventArgs_0;
	}
}

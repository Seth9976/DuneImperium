using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020002BD RID: 701
	public sealed class CrossContextDelegate : MulticastDelegate
	{
		// Token: 0x06002CC8 RID: 11464 RVA: 0x000EA710 File Offset: 0x000E8910
		// Note: this type is marked as 'beforefieldinit'.
		static CrossContextDelegate()
		{
			Il2CppClassPointerStore<CrossContextDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "CrossContextDelegate");
			CrossContextDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextDelegate>.NativeClassPtr, 100670512);
			CrossContextDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextDelegate>.NativeClassPtr, 100670513);
		}

		// Token: 0x06002CC9 RID: 11465 RVA: 0x000EA760 File Offset: 0x000E8960
		[CallerCount(288)]
		[CachedScanResults(RefRangeStart = 320972, RefRangeEnd = 321260, XrefRangeStart = 320972, XrefRangeEnd = 321260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CrossContextDelegate(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossContextDelegate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossContextDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x000EA7BC File Offset: 0x000E89BC
		[CallerCount(0)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossContextDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x0000EF96 File Offset: 0x0000D196
		public CrossContextDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002CCC RID: 11468 RVA: 0x0000EF9F File Offset: 0x0000D19F
		public static implicit operator CrossContextDelegate(Action A_0)
		{
			return DelegateSupport.ConvertDelegate<CrossContextDelegate>(A_0);
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x0000EFA7 File Offset: 0x0000D1A7
		public static CrossContextDelegate operator +(CrossContextDelegate A_0, CrossContextDelegate A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<CrossContextDelegate>();
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x0000EFB5 File Offset: 0x0000D1B5
		public static CrossContextDelegate operator -(CrossContextDelegate A_0, CrossContextDelegate A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<CrossContextDelegate>();
			}
			return delegate2;
		}

		// Token: 0x040025BA RID: 9658
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040025BB RID: 9659
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000102 RID: 258
	[Serializable]
	public sealed class UnhandledExceptionEventHandler : MulticastDelegate
	{
		// Token: 0x0600112B RID: 4395 RVA: 0x00077024 File Offset: 0x00075224
		// Note: this type is marked as 'beforefieldinit'.
		static UnhandledExceptionEventHandler()
		{
			Il2CppClassPointerStore<UnhandledExceptionEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "UnhandledExceptionEventHandler");
			UnhandledExceptionEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionEventHandler>.NativeClassPtr, 100666319);
			UnhandledExceptionEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_UnhandledExceptionEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionEventHandler>.NativeClassPtr, 100666320);
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x00077074 File Offset: 0x00075274
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnhandledExceptionEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnhandledExceptionEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x000770D0 File Offset: 0x000752D0
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, UnhandledExceptionEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_UnhandledExceptionEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x00005EA1 File Offset: 0x000040A1
		public UnhandledExceptionEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x00005EAA File Offset: 0x000040AA
		public static implicit operator UnhandledExceptionEventHandler(Action<Object, UnhandledExceptionEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<UnhandledExceptionEventHandler>(A_0);
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00005EB2 File Offset: 0x000040B2
		public static UnhandledExceptionEventHandler operator +(UnhandledExceptionEventHandler A_0, UnhandledExceptionEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UnhandledExceptionEventHandler>();
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x00005EC0 File Offset: 0x000040C0
		public static UnhandledExceptionEventHandler operator -(UnhandledExceptionEventHandler A_0, UnhandledExceptionEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UnhandledExceptionEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_UnhandledExceptionEventArgs_0;
	}
}

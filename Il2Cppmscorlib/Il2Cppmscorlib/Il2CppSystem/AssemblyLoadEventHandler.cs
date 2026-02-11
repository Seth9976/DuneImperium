using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000078 RID: 120
	[Serializable]
	public sealed class AssemblyLoadEventHandler : MulticastDelegate
	{
		// Token: 0x060006A0 RID: 1696 RVA: 0x00043AA8 File Offset: 0x00041CA8
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyLoadEventHandler()
		{
			Il2CppClassPointerStore<AssemblyLoadEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AssemblyLoadEventHandler");
			AssemblyLoadEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyLoadEventHandler>.NativeClassPtr, 100664399);
			AssemblyLoadEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_AssemblyLoadEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyLoadEventHandler>.NativeClassPtr, 100664400);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00043AF8 File Offset: 0x00041CF8
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyLoadEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyLoadEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyLoadEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00043B54 File Offset: 0x00041D54
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, AssemblyLoadEventArgs args)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyLoadEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_AssemblyLoadEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00004043 File Offset: 0x00002243
		public AssemblyLoadEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0000404C File Offset: 0x0000224C
		public static implicit operator AssemblyLoadEventHandler(Action<Object, AssemblyLoadEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<AssemblyLoadEventHandler>(A_0);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00004054 File Offset: 0x00002254
		public static AssemblyLoadEventHandler operator +(AssemblyLoadEventHandler A_0, AssemblyLoadEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<AssemblyLoadEventHandler>();
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00004062 File Offset: 0x00002262
		public static AssemblyLoadEventHandler operator -(AssemblyLoadEventHandler A_0, AssemblyLoadEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<AssemblyLoadEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_AssemblyLoadEventArgs_0;
	}
}

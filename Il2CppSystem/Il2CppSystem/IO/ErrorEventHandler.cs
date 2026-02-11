using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x0200017F RID: 383
	public sealed class ErrorEventHandler : MulticastDelegate
	{
		// Token: 0x0600175E RID: 5982 RVA: 0x00077870 File Offset: 0x00075A70
		// Note: this type is marked as 'beforefieldinit'.
		static ErrorEventHandler()
		{
			Il2CppClassPointerStore<ErrorEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.IO", "ErrorEventHandler");
			ErrorEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorEventHandler>.NativeClassPtr, 100666985);
			ErrorEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_ErrorEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorEventHandler>.NativeClassPtr, 100666986);
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x000778C0 File Offset: 0x00075AC0
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ErrorEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ErrorEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x0007791C File Offset: 0x00075B1C
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, ErrorEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_ErrorEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x0000A1E0 File Offset: 0x000083E0
		public ErrorEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x0000A1E9 File Offset: 0x000083E9
		public static implicit operator ErrorEventHandler(Action<Object, ErrorEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<ErrorEventHandler>(A_0);
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x0000A1F1 File Offset: 0x000083F1
		public static ErrorEventHandler operator +(ErrorEventHandler A_0, ErrorEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ErrorEventHandler>();
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x0000A1FF File Offset: 0x000083FF
		public static ErrorEventHandler operator -(ErrorEventHandler A_0, ErrorEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ErrorEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04001227 RID: 4647
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001228 RID: 4648
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_ErrorEventArgs_0;
	}
}

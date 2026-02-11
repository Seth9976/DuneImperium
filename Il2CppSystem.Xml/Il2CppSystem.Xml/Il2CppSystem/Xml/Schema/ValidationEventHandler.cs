using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000190 RID: 400
	public sealed class ValidationEventHandler : MulticastDelegate
	{
		// Token: 0x0600220D RID: 8717 RVA: 0x000A3950 File Offset: 0x000A1B50
		// Note: this type is marked as 'beforefieldinit'.
		static ValidationEventHandler()
		{
			Il2CppClassPointerStore<ValidationEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "ValidationEventHandler");
			ValidationEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationEventHandler>.NativeClassPtr, 100668258);
			ValidationEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_ValidationEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationEventHandler>.NativeClassPtr, 100668259);
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x000A39A0 File Offset: 0x000A1BA0
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidationEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidationEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x000A39FC File Offset: 0x000A1BFC
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, ValidationEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_ValidationEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x0000E686 File Offset: 0x0000C886
		public ValidationEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x0000E68F File Offset: 0x0000C88F
		public static implicit operator ValidationEventHandler(Action<Object, ValidationEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<ValidationEventHandler>(A_0);
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x0000E697 File Offset: 0x0000C897
		public static ValidationEventHandler operator +(ValidationEventHandler A_0, ValidationEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ValidationEventHandler>();
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x0000E6A5 File Offset: 0x0000C8A5
		public static ValidationEventHandler operator -(ValidationEventHandler A_0, ValidationEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ValidationEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x040019C3 RID: 6595
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040019C4 RID: 6596
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_ValidationEventArgs_0;
	}
}

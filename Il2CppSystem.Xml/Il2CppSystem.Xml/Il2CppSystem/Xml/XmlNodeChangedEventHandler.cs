using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000075 RID: 117
	public sealed class XmlNodeChangedEventHandler : MulticastDelegate
	{
		// Token: 0x06000E30 RID: 3632 RVA: 0x00054214 File Offset: 0x00052414
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNodeChangedEventHandler()
		{
			Il2CppClassPointerStore<XmlNodeChangedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlNodeChangedEventHandler");
			XmlNodeChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeChangedEventHandler>.NativeClassPtr, 100665631);
			XmlNodeChangedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_XmlNodeChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeChangedEventHandler>.NativeClassPtr, 100665632);
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x00054264 File Offset: 0x00052464
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNodeChangedEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNodeChangedEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x000542C0 File Offset: 0x000524C0
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, XmlNodeChangedEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeChangedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_XmlNodeChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x00006AD5 File Offset: 0x00004CD5
		public XmlNodeChangedEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x00006ADE File Offset: 0x00004CDE
		public static implicit operator XmlNodeChangedEventHandler(Action<Object, XmlNodeChangedEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<XmlNodeChangedEventHandler>(A_0);
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x00006AE6 File Offset: 0x00004CE6
		public static XmlNodeChangedEventHandler operator +(XmlNodeChangedEventHandler A_0, XmlNodeChangedEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<XmlNodeChangedEventHandler>();
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x00006AF4 File Offset: 0x00004CF4
		public static XmlNodeChangedEventHandler operator -(XmlNodeChangedEventHandler A_0, XmlNodeChangedEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<XmlNodeChangedEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_XmlNodeChangedEventArgs_0;
	}
}

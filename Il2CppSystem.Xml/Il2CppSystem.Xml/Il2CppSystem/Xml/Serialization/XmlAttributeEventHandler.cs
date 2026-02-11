using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000B4 RID: 180
	public sealed class XmlAttributeEventHandler : MulticastDelegate
	{
		// Token: 0x06001260 RID: 4704 RVA: 0x000674F4 File Offset: 0x000656F4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAttributeEventHandler()
		{
			Il2CppClassPointerStore<XmlAttributeEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlAttributeEventHandler");
			XmlAttributeEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeEventHandler>.NativeClassPtr, 100666338);
			XmlAttributeEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_XmlAttributeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeEventHandler>.NativeClassPtr, 100666339);
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00067544 File Offset: 0x00065744
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttributeEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAttributeEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x000675A0 File Offset: 0x000657A0
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, XmlAttributeEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_XmlAttributeEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x00007C0B File Offset: 0x00005E0B
		public XmlAttributeEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00007C14 File Offset: 0x00005E14
		public static implicit operator XmlAttributeEventHandler(Action<Object, XmlAttributeEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<XmlAttributeEventHandler>(A_0);
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00007C1C File Offset: 0x00005E1C
		public static XmlAttributeEventHandler operator +(XmlAttributeEventHandler A_0, XmlAttributeEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<XmlAttributeEventHandler>();
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00007C2A File Offset: 0x00005E2A
		public static XmlAttributeEventHandler operator -(XmlAttributeEventHandler A_0, XmlAttributeEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<XmlAttributeEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000F11 RID: 3857
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000F12 RID: 3858
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_XmlAttributeEventArgs_0;
	}
}

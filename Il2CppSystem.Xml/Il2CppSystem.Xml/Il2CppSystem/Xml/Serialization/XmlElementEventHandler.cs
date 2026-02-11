using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000B6 RID: 182
	public sealed class XmlElementEventHandler : MulticastDelegate
	{
		// Token: 0x06001274 RID: 4724 RVA: 0x00067804 File Offset: 0x00065A04
		// Note: this type is marked as 'beforefieldinit'.
		static XmlElementEventHandler()
		{
			Il2CppClassPointerStore<XmlElementEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlElementEventHandler");
			XmlElementEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementEventHandler>.NativeClassPtr, 100666341);
			XmlElementEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_XmlElementEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementEventHandler>.NativeClassPtr, 100666342);
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x00067854 File Offset: 0x00065A54
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlElementEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlElementEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x000678B0 File Offset: 0x00065AB0
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, XmlElementEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_XmlElementEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x00007CD7 File Offset: 0x00005ED7
		public XmlElementEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x00007CE0 File Offset: 0x00005EE0
		public static implicit operator XmlElementEventHandler(Action<Object, XmlElementEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<XmlElementEventHandler>(A_0);
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x00007CE8 File Offset: 0x00005EE8
		public static XmlElementEventHandler operator +(XmlElementEventHandler A_0, XmlElementEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<XmlElementEventHandler>();
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x00007CF6 File Offset: 0x00005EF6
		public static XmlElementEventHandler operator -(XmlElementEventHandler A_0, XmlElementEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<XmlElementEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000F19 RID: 3865
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000F1A RID: 3866
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_XmlElementEventArgs_0;
	}
}

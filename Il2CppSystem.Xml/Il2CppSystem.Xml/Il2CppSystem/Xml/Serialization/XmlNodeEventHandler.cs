using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000B8 RID: 184
	public sealed class XmlNodeEventHandler : MulticastDelegate
	{
		// Token: 0x06001288 RID: 4744 RVA: 0x00067B14 File Offset: 0x00065D14
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNodeEventHandler()
		{
			Il2CppClassPointerStore<XmlNodeEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlNodeEventHandler");
			XmlNodeEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeEventHandler>.NativeClassPtr, 100666344);
			XmlNodeEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_XmlNodeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeEventHandler>.NativeClassPtr, 100666345);
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x00067B64 File Offset: 0x00065D64
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNodeEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNodeEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00067BC0 File Offset: 0x00065DC0
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, XmlNodeEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_XmlNodeEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x00007DA3 File Offset: 0x00005FA3
		public XmlNodeEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00007DAC File Offset: 0x00005FAC
		public static implicit operator XmlNodeEventHandler(Action<Object, XmlNodeEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<XmlNodeEventHandler>(A_0);
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00007DB4 File Offset: 0x00005FB4
		public static XmlNodeEventHandler operator +(XmlNodeEventHandler A_0, XmlNodeEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<XmlNodeEventHandler>();
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00007DC2 File Offset: 0x00005FC2
		public static XmlNodeEventHandler operator -(XmlNodeEventHandler A_0, XmlNodeEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<XmlNodeEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000F21 RID: 3873
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000F22 RID: 3874
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_XmlNodeEventArgs_0;
	}
}

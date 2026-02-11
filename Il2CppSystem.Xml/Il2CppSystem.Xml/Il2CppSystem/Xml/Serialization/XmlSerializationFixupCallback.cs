using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000E2 RID: 226
	public sealed class XmlSerializationFixupCallback : MulticastDelegate
	{
		// Token: 0x06001496 RID: 5270 RVA: 0x0006ED04 File Offset: 0x0006CF04
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSerializationFixupCallback()
		{
			Il2CppClassPointerStore<XmlSerializationFixupCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlSerializationFixupCallback");
			XmlSerializationFixupCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationFixupCallback>.NativeClassPtr, 100666567);
			XmlSerializationFixupCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationFixupCallback>.NativeClassPtr, 100666568);
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x0006ED54 File Offset: 0x0006CF54
		[CallerCount(144)]
		[CachedScanResults(RefRangeStart = 387041, RefRangeEnd = 387185, XrefRangeStart = 387032, XrefRangeEnd = 387041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializationFixupCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializationFixupCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationFixupCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x0006EDB0 File Offset: 0x0006CFB0
		[CallerCount(0)]
		public unsafe void Invoke(Object fixup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fixup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationFixupCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x00008D19 File Offset: 0x00006F19
		public XmlSerializationFixupCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x00008D22 File Offset: 0x00006F22
		public static implicit operator XmlSerializationFixupCallback(Action<Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<XmlSerializationFixupCallback>(A_0);
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x00008D2A File Offset: 0x00006F2A
		public static XmlSerializationFixupCallback operator +(XmlSerializationFixupCallback A_0, XmlSerializationFixupCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<XmlSerializationFixupCallback>();
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x00008D38 File Offset: 0x00006F38
		public static XmlSerializationFixupCallback operator -(XmlSerializationFixupCallback A_0, XmlSerializationFixupCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<XmlSerializationFixupCallback>();
			}
			return delegate2;
		}

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0;
	}
}

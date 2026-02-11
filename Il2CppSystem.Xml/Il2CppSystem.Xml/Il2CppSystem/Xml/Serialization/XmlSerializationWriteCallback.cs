using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000E7 RID: 231
	public sealed class XmlSerializationWriteCallback : MulticastDelegate
	{
		// Token: 0x0600153E RID: 5438 RVA: 0x00071BCC File Offset: 0x0006FDCC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSerializationWriteCallback()
		{
			Il2CppClassPointerStore<XmlSerializationWriteCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlSerializationWriteCallback");
			XmlSerializationWriteCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriteCallback>.NativeClassPtr, 100666681);
			XmlSerializationWriteCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriteCallback>.NativeClassPtr, 100666682);
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x00071C1C File Offset: 0x0006FE1C
		[CallerCount(144)]
		[CachedScanResults(RefRangeStart = 387041, RefRangeEnd = 387185, XrefRangeStart = 387041, XrefRangeEnd = 387185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializationWriteCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializationWriteCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriteCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x00071C78 File Offset: 0x0006FE78
		[CallerCount(0)]
		public unsafe void Invoke(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriteCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x00009126 File Offset: 0x00007326
		public XmlSerializationWriteCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x0000912F File Offset: 0x0000732F
		public static implicit operator XmlSerializationWriteCallback(Action<Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<XmlSerializationWriteCallback>(A_0);
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x00009137 File Offset: 0x00007337
		public static XmlSerializationWriteCallback operator +(XmlSerializationWriteCallback A_0, XmlSerializationWriteCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<XmlSerializationWriteCallback>();
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x00009145 File Offset: 0x00007345
		public static XmlSerializationWriteCallback operator -(XmlSerializationWriteCallback A_0, XmlSerializationWriteCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<XmlSerializationWriteCallback>();
			}
			return delegate2;
		}

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0;
	}
}

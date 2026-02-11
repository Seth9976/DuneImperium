using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000E1 RID: 225
	public sealed class XmlSerializationCollectionFixupCallback : MulticastDelegate
	{
		// Token: 0x0600148F RID: 5263 RVA: 0x0006EC04 File Offset: 0x0006CE04
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSerializationCollectionFixupCallback()
		{
			Il2CppClassPointerStore<XmlSerializationCollectionFixupCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlSerializationCollectionFixupCallback");
			XmlSerializationCollectionFixupCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationCollectionFixupCallback>.NativeClassPtr, 100666565);
			XmlSerializationCollectionFixupCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationCollectionFixupCallback>.NativeClassPtr, 100666566);
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x0006EC54 File Offset: 0x0006CE54
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializationCollectionFixupCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializationCollectionFixupCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationCollectionFixupCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x0006ECB0 File Offset: 0x0006CEB0
		[CallerCount(0)]
		public unsafe void Invoke(Object collection, Object collectionItems)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collectionItems);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationCollectionFixupCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x00008CE9 File Offset: 0x00006EE9
		public XmlSerializationCollectionFixupCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x00008CF2 File Offset: 0x00006EF2
		public static implicit operator XmlSerializationCollectionFixupCallback(Action<Object, Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<XmlSerializationCollectionFixupCallback>(A_0);
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x00008CFA File Offset: 0x00006EFA
		public static XmlSerializationCollectionFixupCallback operator +(XmlSerializationCollectionFixupCallback A_0, XmlSerializationCollectionFixupCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<XmlSerializationCollectionFixupCallback>();
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x00008D08 File Offset: 0x00006F08
		public static XmlSerializationCollectionFixupCallback operator -(XmlSerializationCollectionFixupCallback A_0, XmlSerializationCollectionFixupCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<XmlSerializationCollectionFixupCallback>();
			}
			return delegate2;
		}

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Object_0;
	}
}

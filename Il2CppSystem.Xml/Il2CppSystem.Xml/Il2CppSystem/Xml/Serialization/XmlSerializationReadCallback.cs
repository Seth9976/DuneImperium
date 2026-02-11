using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000E4 RID: 228
	public sealed class XmlSerializationReadCallback : MulticastDelegate
	{
		// Token: 0x060014A0 RID: 5280 RVA: 0x0006EE30 File Offset: 0x0006D030
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSerializationReadCallback()
		{
			Il2CppClassPointerStore<XmlSerializationReadCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlSerializationReadCallback");
			XmlSerializationReadCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReadCallback>.NativeClassPtr, 100666570);
			XmlSerializationReadCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationReadCallback>.NativeClassPtr, 100666571);
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x0006EE80 File Offset: 0x0006D080
		[CallerCount(210)]
		[CachedScanResults(RefRangeStart = 320759, RefRangeEnd = 320969, XrefRangeStart = 320759, XrefRangeEnd = 320969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializationReadCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializationReadCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReadCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x0006EEDC File Offset: 0x0006D0DC
		[CallerCount(0)]
		public unsafe Object Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationReadCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x00008D8B File Offset: 0x00006F8B
		public XmlSerializationReadCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x00008D94 File Offset: 0x00006F94
		public static implicit operator XmlSerializationReadCallback(Func<Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<XmlSerializationReadCallback>(A_0);
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x00008D9C File Offset: 0x00006F9C
		public static XmlSerializationReadCallback operator +(XmlSerializationReadCallback A_0, XmlSerializationReadCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<XmlSerializationReadCallback>();
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x00008DAA File Offset: 0x00006FAA
		public static XmlSerializationReadCallback operator -(XmlSerializationReadCallback A_0, XmlSerializationReadCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<XmlSerializationReadCallback>();
			}
			return delegate2;
		}

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_0;
	}
}

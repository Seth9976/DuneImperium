using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000139 RID: 313
	public sealed class PropertyChangedEventHandler : MulticastDelegate
	{
		// Token: 0x060012AD RID: 4781 RVA: 0x00063FF4 File Offset: 0x000621F4
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyChangedEventHandler()
		{
			Il2CppClassPointerStore<PropertyChangedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "PropertyChangedEventHandler");
			PropertyChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyChangedEventHandler>.NativeClassPtr, 100666018);
			PropertyChangedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_PropertyChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyChangedEventHandler>.NativeClassPtr, 100666019);
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x00064044 File Offset: 0x00062244
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyChangedEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyChangedEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x000640A0 File Offset: 0x000622A0
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, PropertyChangedEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyChangedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_PropertyChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x000088D6 File Offset: 0x00006AD6
		public PropertyChangedEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x000088DF File Offset: 0x00006ADF
		public static implicit operator PropertyChangedEventHandler(Action<Object, PropertyChangedEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<PropertyChangedEventHandler>(A_0);
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x000088E7 File Offset: 0x00006AE7
		public static PropertyChangedEventHandler operator +(PropertyChangedEventHandler A_0, PropertyChangedEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<PropertyChangedEventHandler>();
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x000088F5 File Offset: 0x00006AF5
		public static PropertyChangedEventHandler operator -(PropertyChangedEventHandler A_0, PropertyChangedEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<PropertyChangedEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000ED0 RID: 3792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000ED1 RID: 3793
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_PropertyChangedEventArgs_0;
	}
}

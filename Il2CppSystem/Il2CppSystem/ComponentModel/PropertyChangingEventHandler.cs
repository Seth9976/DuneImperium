using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200013B RID: 315
	public sealed class PropertyChangingEventHandler : MulticastDelegate
	{
		// Token: 0x060012B9 RID: 4793 RVA: 0x000641C0 File Offset: 0x000623C0
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyChangingEventHandler()
		{
			Il2CppClassPointerStore<PropertyChangingEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "PropertyChangingEventHandler");
			PropertyChangingEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyChangingEventHandler>.NativeClassPtr, 100666021);
			PropertyChangingEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_PropertyChangingEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyChangingEventHandler>.NativeClassPtr, 100666022);
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x00064210 File Offset: 0x00062410
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyChangingEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyChangingEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyChangingEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x0006426C File Offset: 0x0006246C
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, PropertyChangingEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyChangingEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_PropertyChangingEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x0000892E File Offset: 0x00006B2E
		public PropertyChangingEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x00008937 File Offset: 0x00006B37
		public static implicit operator PropertyChangingEventHandler(Action<Object, PropertyChangingEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<PropertyChangingEventHandler>(A_0);
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x0000893F File Offset: 0x00006B3F
		public static PropertyChangingEventHandler operator +(PropertyChangingEventHandler A_0, PropertyChangingEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<PropertyChangingEventHandler>();
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x0000894D File Offset: 0x00006B4D
		public static PropertyChangingEventHandler operator -(PropertyChangingEventHandler A_0, PropertyChangingEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<PropertyChangingEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000ED4 RID: 3796
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000ED5 RID: 3797
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_PropertyChangingEventArgs_0;
	}
}

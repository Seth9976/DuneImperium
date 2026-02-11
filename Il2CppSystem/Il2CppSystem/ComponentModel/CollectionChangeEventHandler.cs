using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x020000FE RID: 254
	public sealed class CollectionChangeEventHandler : MulticastDelegate
	{
		// Token: 0x0600100C RID: 4108 RVA: 0x00058950 File Offset: 0x00056B50
		// Note: this type is marked as 'beforefieldinit'.
		static CollectionChangeEventHandler()
		{
			Il2CppClassPointerStore<CollectionChangeEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "CollectionChangeEventHandler");
			CollectionChangeEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionChangeEventHandler>.NativeClassPtr, 100665606);
			CollectionChangeEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_CollectionChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionChangeEventHandler>.NativeClassPtr, 100665607);
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x000589A0 File Offset: 0x00056BA0
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CollectionChangeEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectionChangeEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionChangeEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x000589FC File Offset: 0x00056BFC
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, CollectionChangeEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionChangeEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_CollectionChangeEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x00007C3B File Offset: 0x00005E3B
		public CollectionChangeEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x00007C44 File Offset: 0x00005E44
		public static implicit operator CollectionChangeEventHandler(Action<Object, CollectionChangeEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<CollectionChangeEventHandler>(A_0);
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00007C4C File Offset: 0x00005E4C
		public static CollectionChangeEventHandler operator +(CollectionChangeEventHandler A_0, CollectionChangeEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<CollectionChangeEventHandler>();
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x00007C5A File Offset: 0x00005E5A
		public static CollectionChangeEventHandler operator -(CollectionChangeEventHandler A_0, CollectionChangeEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<CollectionChangeEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_CollectionChangeEventArgs_0;
	}
}

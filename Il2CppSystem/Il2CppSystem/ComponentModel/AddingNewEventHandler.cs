using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x020000F3 RID: 243
	public sealed class AddingNewEventHandler : MulticastDelegate
	{
		// Token: 0x06000FAB RID: 4011 RVA: 0x00056F9C File Offset: 0x0005519C
		// Note: this type is marked as 'beforefieldinit'.
		static AddingNewEventHandler()
		{
			Il2CppClassPointerStore<AddingNewEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "AddingNewEventHandler");
			AddingNewEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddingNewEventHandler>.NativeClassPtr, 100665553);
			AddingNewEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_AddingNewEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddingNewEventHandler>.NativeClassPtr, 100665554);
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x00056FEC File Offset: 0x000551EC
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddingNewEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddingNewEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddingNewEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x00057048 File Offset: 0x00055248
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, AddingNewEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddingNewEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_AddingNewEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x00007A74 File Offset: 0x00005C74
		public AddingNewEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x00007A7D File Offset: 0x00005C7D
		public static implicit operator AddingNewEventHandler(Action<Object, AddingNewEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<AddingNewEventHandler>(A_0);
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00007A85 File Offset: 0x00005C85
		public static AddingNewEventHandler operator +(AddingNewEventHandler A_0, AddingNewEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<AddingNewEventHandler>();
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00007A93 File Offset: 0x00005C93
		public static AddingNewEventHandler operator -(AddingNewEventHandler A_0, AddingNewEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<AddingNewEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_AddingNewEventArgs_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020000A4 RID: 164
	public sealed class DataReceivedEventHandler : MulticastDelegate
	{
		// Token: 0x06000C2A RID: 3114 RVA: 0x0004972C File Offset: 0x0004792C
		// Note: this type is marked as 'beforefieldinit'.
		static DataReceivedEventHandler()
		{
			Il2CppClassPointerStore<DataReceivedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "DataReceivedEventHandler");
			DataReceivedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataReceivedEventHandler>.NativeClassPtr, 100665042);
			DataReceivedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_DataReceivedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataReceivedEventHandler>.NativeClassPtr, 100665043);
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x0004977C File Offset: 0x0004797C
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataReceivedEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataReceivedEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataReceivedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x000497D8 File Offset: 0x000479D8
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, DataReceivedEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataReceivedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_DataReceivedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x0000687E File Offset: 0x00004A7E
		public DataReceivedEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x00006887 File Offset: 0x00004A87
		public static implicit operator DataReceivedEventHandler(Action<Object, DataReceivedEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<DataReceivedEventHandler>(A_0);
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x0000688F File Offset: 0x00004A8F
		public static DataReceivedEventHandler operator +(DataReceivedEventHandler A_0, DataReceivedEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<DataReceivedEventHandler>();
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x0000689D File Offset: 0x00004A9D
		public static DataReceivedEventHandler operator -(DataReceivedEventHandler A_0, DataReceivedEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<DataReceivedEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_DataReceivedEventArgs_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000043 RID: 67
	public sealed class DataTableNewRowEventHandler : MulticastDelegate
	{
		// Token: 0x0600073B RID: 1851 RVA: 0x0002830C File Offset: 0x0002650C
		// Note: this type is marked as 'beforefieldinit'.
		static DataTableNewRowEventHandler()
		{
			Il2CppClassPointerStore<DataTableNewRowEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataTableNewRowEventHandler");
			DataTableNewRowEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableNewRowEventHandler>.NativeClassPtr, 100664520);
			DataTableNewRowEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_DataTableNewRowEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableNewRowEventHandler>.NativeClassPtr, 100664521);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0002835C File Offset: 0x0002655C
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTableNewRowEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataTableNewRowEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableNewRowEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x000283B8 File Offset: 0x000265B8
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, DataTableNewRowEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableNewRowEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_DataTableNewRowEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x000041C6 File Offset: 0x000023C6
		public DataTableNewRowEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x000041CF File Offset: 0x000023CF
		public static implicit operator DataTableNewRowEventHandler(Action<Object, DataTableNewRowEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<DataTableNewRowEventHandler>(A_0);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x000041D7 File Offset: 0x000023D7
		public static DataTableNewRowEventHandler operator +(DataTableNewRowEventHandler A_0, DataTableNewRowEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<DataTableNewRowEventHandler>();
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x000041E5 File Offset: 0x000023E5
		public static DataTableNewRowEventHandler operator -(DataTableNewRowEventHandler A_0, DataTableNewRowEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<DataTableNewRowEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_DataTableNewRowEventArgs_0;
	}
}

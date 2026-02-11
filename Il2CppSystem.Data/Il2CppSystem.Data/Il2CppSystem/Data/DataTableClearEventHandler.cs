using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000040 RID: 64
	public sealed class DataTableClearEventHandler : MulticastDelegate
	{
		// Token: 0x060006FE RID: 1790 RVA: 0x000272F4 File Offset: 0x000254F4
		// Note: this type is marked as 'beforefieldinit'.
		static DataTableClearEventHandler()
		{
			Il2CppClassPointerStore<DataTableClearEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataTableClearEventHandler");
			DataTableClearEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableClearEventHandler>.NativeClassPtr, 100664486);
			DataTableClearEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_DataTableClearEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableClearEventHandler>.NativeClassPtr, 100664487);
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00027344 File Offset: 0x00025544
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTableClearEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataTableClearEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableClearEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x000273A0 File Offset: 0x000255A0
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, DataTableClearEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableClearEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_DataTableClearEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00004086 File Offset: 0x00002286
		public DataTableClearEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0000408F File Offset: 0x0000228F
		public static implicit operator DataTableClearEventHandler(Action<Object, DataTableClearEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<DataTableClearEventHandler>(A_0);
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00004097 File Offset: 0x00002297
		public static DataTableClearEventHandler operator +(DataTableClearEventHandler A_0, DataTableClearEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<DataTableClearEventHandler>();
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x000040A5 File Offset: 0x000022A5
		public static DataTableClearEventHandler operator -(DataTableClearEventHandler A_0, DataTableClearEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<DataTableClearEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_DataTableClearEventArgs_0;
	}
}

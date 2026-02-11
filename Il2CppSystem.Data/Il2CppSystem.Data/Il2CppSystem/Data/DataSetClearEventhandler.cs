using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000039 RID: 57
	public sealed class DataSetClearEventhandler : MulticastDelegate
	{
		// Token: 0x060006CB RID: 1739 RVA: 0x00026624 File Offset: 0x00024824
		// Note: this type is marked as 'beforefieldinit'.
		static DataSetClearEventhandler()
		{
			Il2CppClassPointerStore<DataSetClearEventhandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataSetClearEventhandler");
			DataSetClearEventhandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSetClearEventhandler>.NativeClassPtr, 100664455);
			DataSetClearEventhandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSetClearEventhandler>.NativeClassPtr, 100664456);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00026674 File Offset: 0x00024874
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataSetClearEventhandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataSetClearEventhandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSetClearEventhandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x000266D0 File Offset: 0x000248D0
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSetClearEventhandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00003F9B File Offset: 0x0000219B
		public DataSetClearEventhandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00003FA4 File Offset: 0x000021A4
		public static implicit operator DataSetClearEventhandler(Action<Object, DataTable> A_0)
		{
			return DelegateSupport.ConvertDelegate<DataSetClearEventhandler>(A_0);
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00003FAC File Offset: 0x000021AC
		public static DataSetClearEventhandler operator +(DataSetClearEventhandler A_0, DataSetClearEventhandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<DataSetClearEventhandler>();
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00003FBA File Offset: 0x000021BA
		public static DataSetClearEventhandler operator -(DataSetClearEventhandler A_0, DataSetClearEventhandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<DataSetClearEventhandler>();
			}
			return delegate2;
		}

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_DataTable_0;
	}
}

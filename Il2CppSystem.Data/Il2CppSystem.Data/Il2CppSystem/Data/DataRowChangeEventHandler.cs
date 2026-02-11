using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000036 RID: 54
	public sealed class DataRowChangeEventHandler : MulticastDelegate
	{
		// Token: 0x060006A6 RID: 1702 RVA: 0x00025E14 File Offset: 0x00024014
		// Note: this type is marked as 'beforefieldinit'.
		static DataRowChangeEventHandler()
		{
			Il2CppClassPointerStore<DataRowChangeEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataRowChangeEventHandler");
			DataRowChangeEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowChangeEventHandler>.NativeClassPtr, 100664434);
			DataRowChangeEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_DataRowChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowChangeEventHandler>.NativeClassPtr, 100664435);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00025E64 File Offset: 0x00024064
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRowChangeEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataRowChangeEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowChangeEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00025EC0 File Offset: 0x000240C0
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, DataRowChangeEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowChangeEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_DataRowChangeEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00003ECB File Offset: 0x000020CB
		public DataRowChangeEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00003ED4 File Offset: 0x000020D4
		public static implicit operator DataRowChangeEventHandler(Action<Object, DataRowChangeEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<DataRowChangeEventHandler>(A_0);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00003EDC File Offset: 0x000020DC
		public static DataRowChangeEventHandler operator +(DataRowChangeEventHandler A_0, DataRowChangeEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<DataRowChangeEventHandler>();
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00003EEA File Offset: 0x000020EA
		public static DataRowChangeEventHandler operator -(DataRowChangeEventHandler A_0, DataRowChangeEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<DataRowChangeEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_DataRowChangeEventArgs_0;
	}
}

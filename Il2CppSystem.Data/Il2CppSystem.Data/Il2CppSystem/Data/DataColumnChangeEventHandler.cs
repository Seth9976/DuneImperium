using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x0200002A RID: 42
	public sealed class DataColumnChangeEventHandler : MulticastDelegate
	{
		// Token: 0x0600052B RID: 1323 RVA: 0x0001F8BC File Offset: 0x0001DABC
		// Note: this type is marked as 'beforefieldinit'.
		static DataColumnChangeEventHandler()
		{
			Il2CppClassPointerStore<DataColumnChangeEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataColumnChangeEventHandler");
			DataColumnChangeEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnChangeEventHandler>.NativeClassPtr, 100664187);
			DataColumnChangeEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_DataColumnChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnChangeEventHandler>.NativeClassPtr, 100664188);
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0001F90C File Offset: 0x0001DB0C
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataColumnChangeEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataColumnChangeEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnChangeEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0001F968 File Offset: 0x0001DB68
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, DataColumnChangeEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnChangeEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_DataColumnChangeEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00003703 File Offset: 0x00001903
		public DataColumnChangeEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0000370C File Offset: 0x0000190C
		public static implicit operator DataColumnChangeEventHandler(Action<Object, DataColumnChangeEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<DataColumnChangeEventHandler>(A_0);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00003714 File Offset: 0x00001914
		public static DataColumnChangeEventHandler operator +(DataColumnChangeEventHandler A_0, DataColumnChangeEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<DataColumnChangeEventHandler>();
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00003722 File Offset: 0x00001922
		public static DataColumnChangeEventHandler operator -(DataColumnChangeEventHandler A_0, DataColumnChangeEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<DataColumnChangeEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_DataColumnChangeEventArgs_0;
	}
}

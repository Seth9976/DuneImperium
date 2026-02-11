using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000038 RID: 56
	public sealed class DataRowCreatedEventHandler : MulticastDelegate
	{
		// Token: 0x060006C4 RID: 1732 RVA: 0x00026524 File Offset: 0x00024724
		// Note: this type is marked as 'beforefieldinit'.
		static DataRowCreatedEventHandler()
		{
			Il2CppClassPointerStore<DataRowCreatedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataRowCreatedEventHandler");
			DataRowCreatedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowCreatedEventHandler>.NativeClassPtr, 100664453);
			DataRowCreatedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowCreatedEventHandler>.NativeClassPtr, 100664454);
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00026574 File Offset: 0x00024774
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRowCreatedEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataRowCreatedEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowCreatedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x000265D0 File Offset: 0x000247D0
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, DataRow r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(r);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowCreatedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00003F6B File Offset: 0x0000216B
		public DataRowCreatedEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00003F74 File Offset: 0x00002174
		public static implicit operator DataRowCreatedEventHandler(Action<Object, DataRow> A_0)
		{
			return DelegateSupport.ConvertDelegate<DataRowCreatedEventHandler>(A_0);
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00003F7C File Offset: 0x0000217C
		public static DataRowCreatedEventHandler operator +(DataRowCreatedEventHandler A_0, DataRowCreatedEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<DataRowCreatedEventHandler>();
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00003F8A File Offset: 0x0000218A
		public static DataRowCreatedEventHandler operator -(DataRowCreatedEventHandler A_0, DataRowCreatedEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<DataRowCreatedEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_DataRow_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;

namespace Il2CppSystem
{
	// Token: 0x02000103 RID: 259
	public class IValueTupleInternal : Il2CppObjectBase
	{
		// Token: 0x06001132 RID: 4402 RVA: 0x00077124 File Offset: 0x00075324
		// Note: this type is marked as 'beforefieldinit'.
		static IValueTupleInternal()
		{
			Il2CppClassPointerStore<IValueTupleInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IValueTupleInternal");
			IValueTupleInternal.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValueTupleInternal>.NativeClassPtr, 100666321);
			IValueTupleInternal.NativeMethodInfoPtr_ToStringEnd_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValueTupleInternal>.NativeClassPtr, 100666322);
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x00077174 File Offset: 0x00075374
		[CallerCount(0)]
		public unsafe virtual int GetHashCode(IEqualityComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IValueTupleInternal.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_IEqualityComparer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x000771CC File Offset: 0x000753CC
		[CallerCount(0)]
		public unsafe virtual string ToStringEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IValueTupleInternal.NativeMethodInfoPtr_ToStringEnd_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x00005ED1 File Offset: 0x000040D1
		public IValueTupleInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E26 RID: 3622
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_IEqualityComparer_0;

		// Token: 0x04000E27 RID: 3623
		private static readonly IntPtr NativeMethodInfoPtr_ToStringEnd_Public_Abstract_Virtual_New_String_0;
	}
}

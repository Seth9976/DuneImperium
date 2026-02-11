using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000295 RID: 661
	public class IRemotingTypeInfo : Il2CppObjectBase
	{
		// Token: 0x06002A37 RID: 10807 RVA: 0x000E0B30 File Offset: 0x000DED30
		// Note: this type is marked as 'beforefieldinit'.
		static IRemotingTypeInfo()
		{
			Il2CppClassPointerStore<IRemotingTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "IRemotingTypeInfo");
			IRemotingTypeInfo.NativeMethodInfoPtr_get_TypeName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRemotingTypeInfo>.NativeClassPtr, 100670175);
			IRemotingTypeInfo.NativeMethodInfoPtr_CanCastTo_Public_Abstract_Virtual_New_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRemotingTypeInfo>.NativeClassPtr, 100670176);
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06002A38 RID: 10808 RVA: 0x000E0B80 File Offset: 0x000DED80
		public unsafe virtual string TypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRemotingTypeInfo.NativeMethodInfoPtr_get_TypeName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x000E0BC4 File Offset: 0x000DEDC4
		[CallerCount(0)]
		public unsafe virtual bool CanCastTo(Type fromType, Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fromType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRemotingTypeInfo.NativeMethodInfoPtr_CanCastTo_Public_Abstract_Virtual_New_Boolean_Type_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x0000E07E File Offset: 0x0000C27E
		public IRemotingTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040023F0 RID: 9200
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040023F1 RID: 9201
		private static readonly IntPtr NativeMethodInfoPtr_CanCastTo_Public_Abstract_Virtual_New_Boolean_Type_Object_0;
	}
}

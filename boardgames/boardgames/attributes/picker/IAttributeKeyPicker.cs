using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace boardgames.attributes.picker
{
	// Token: 0x02000176 RID: 374
	public class IAttributeKeyPicker : Il2CppObjectBase
	{
		// Token: 0x060012D8 RID: 4824 RVA: 0x0004B2EC File Offset: 0x000494EC
		// Note: this type is marked as 'beforefieldinit'.
		static IAttributeKeyPicker()
		{
			Il2CppClassPointerStore<IAttributeKeyPicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes.picker", "IAttributeKeyPicker");
			IAttributeKeyPicker.NativeMethodInfoPtr_get_HasMatcher_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttributeKeyPicker>.NativeClassPtr, 100666063);
			IAttributeKeyPicker.NativeMethodInfoPtr_Matches_Public_Abstract_Virtual_New_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttributeKeyPicker>.NativeClassPtr, 100666064);
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x060012D9 RID: 4825 RVA: 0x0004B33C File Offset: 0x0004953C
		public unsafe virtual bool HasMatcher
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAttributeKeyPicker.NativeMethodInfoPtr_get_HasMatcher_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x0004B384 File Offset: 0x00049584
		[CallerCount(0)]
		public unsafe virtual bool Matches(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAttributeKeyPicker.NativeMethodInfoPtr_Matches_Public_Abstract_Virtual_New_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x0000AC33 File Offset: 0x00008E33
		public IAttributeKeyPicker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeMethodInfoPtr_get_HasMatcher_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Abstract_Virtual_New_Boolean_Type_0;
	}
}

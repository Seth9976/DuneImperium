using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem
{
	// Token: 0x0200016C RID: 364
	public class TypeIdentifier : Il2CppObjectBase
	{
		// Token: 0x060018C6 RID: 6342 RVA: 0x00007F1E File Offset: 0x0000611E
		// Note: this type is marked as 'beforefieldinit'.
		static TypeIdentifier()
		{
			Il2CppClassPointerStore<TypeIdentifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypeIdentifier");
			TypeIdentifier.NativeMethodInfoPtr_get_InternalName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeIdentifier>.NativeClassPtr, 100667580);
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x060018C7 RID: 6343 RVA: 0x0009AC14 File Offset: 0x00098E14
		public unsafe virtual string InternalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeIdentifier.NativeMethodInfoPtr_get_InternalName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x00007F4D File Offset: 0x0000614D
		public TypeIdentifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040016CB RID: 5835
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalName_Public_Abstract_Virtual_New_get_String_0;
	}
}

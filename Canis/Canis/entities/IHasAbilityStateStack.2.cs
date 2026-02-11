using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Canis.entities
{
	// Token: 0x020000F4 RID: 244
	public class IHasAbilityStateStack<TActiveAbility> : Il2CppObjectBase where TActiveAbility : ActiveAbility
	{
		// Token: 0x06000AD0 RID: 2768 RVA: 0x00047B68 File Offset: 0x00045D68
		// Note: this type is marked as 'beforefieldinit'.
		static IHasAbilityStateStack()
		{
			Il2CppClassPointerStore<IHasAbilityStateStack<TActiveAbility>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "IHasAbilityStateStack`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TActiveAbility>.NativeClassPtr)) })).TypeHandle.value);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00005EAB File Offset: 0x000040AB
		public IHasAbilityStateStack(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}

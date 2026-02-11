using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace canis.archetypes
{
	// Token: 0x02000012 RID: 18
	public class IHasArchetypes<TArchetypes> : Il2CppObjectBase where TArchetypes : Archetypes
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x0001BC7C File Offset: 0x00019E7C
		// Note: this type is marked as 'beforefieldinit'.
		static IHasArchetypes()
		{
			Il2CppClassPointerStore<IHasArchetypes<TArchetypes>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "canis.archetypes", "IHasArchetypes`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArchetypes>.NativeClassPtr)) })).TypeHandle.value);
			IHasArchetypes<TArchetypes>.NativeMethodInfoPtr_get_Archetypes_Public_Abstract_Virtual_New_get_TArchetypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasArchetypes<TArchetypes>>.NativeClassPtr, 100663359);
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0001BCF4 File Offset: 0x00019EF4
		public unsafe virtual TArchetypes Archetypes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasArchetypes<TArchetypes>.NativeMethodInfoPtr_get_Archetypes_Public_Abstract_Virtual_New_get_TArchetypes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TArchetypes>(intPtr, false, true);
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002556 File Offset: 0x00000756
		public IHasArchetypes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_get_Archetypes_Public_Abstract_Virtual_New_get_TArchetypes_0;
	}
}

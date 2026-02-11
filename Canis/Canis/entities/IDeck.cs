using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Canis.entities
{
	// Token: 0x020000DE RID: 222
	public class IDeck<TMember> : Il2CppObjectBase where TMember : Entity
	{
		// Token: 0x06000A34 RID: 2612 RVA: 0x00044BA4 File Offset: 0x00042DA4
		// Note: this type is marked as 'beforefieldinit'.
		static IDeck()
		{
			Il2CppClassPointerStore<IDeck<TMember>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "IDeck`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMember>.NativeClassPtr)) })).TypeHandle.value);
			IDeck<TMember>.NativeMethodInfoPtr_get_TopCard_Public_Abstract_Virtual_New_get_TMember_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDeck<TMember>>.NativeClassPtr, 100665450);
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x00044C1C File Offset: 0x00042E1C
		public unsafe virtual TMember TopCard
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDeck<TMember>.NativeMethodInfoPtr_get_TopCard_Public_Abstract_Virtual_New_get_TMember_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TMember>(intPtr, false, true);
			}
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00005C98 File Offset: 0x00003E98
		public IDeck(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeMethodInfoPtr_get_TopCard_Public_Abstract_Virtual_New_get_TMember_0;
	}
}

using System;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.entities
{
	// Token: 0x020000D5 RID: 213
	public class IEntityName : Il2CppObjectBase
	{
		// Token: 0x060009F4 RID: 2548 RVA: 0x00043BF4 File Offset: 0x00041DF4
		// Note: this type is marked as 'beforefieldinit'.
		static IEntityName()
		{
			Il2CppClassPointerStore<IEntityName>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "IEntityName");
			IEntityName.NativeMethodInfoPtr_DeserializeEntity_Public_Abstract_Virtual_New_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntityName>.NativeClassPtr, 100665404);
			IEntityName.NativeMethodInfoPtr_ParentEntity_Public_Abstract_Virtual_New_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntityName>.NativeClassPtr, 100665405);
			IEntityName.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntityName>.NativeClassPtr, 100665406);
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00043C58 File Offset: 0x00041E58
		[CallerCount(0)]
		public unsafe virtual Entity DeserializeEntity(SerializedEntity se, Match m, Entity parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEntityName.NativeMethodInfoPtr_DeserializeEntity_Public_Abstract_Virtual_New_Entity_SerializedEntity_Match_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00043CD8 File Offset: 0x00041ED8
		[CallerCount(0)]
		public unsafe virtual void ParentEntity(Entity child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEntityName.NativeMethodInfoPtr_ParentEntity_Public_Abstract_Virtual_New_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x00043D28 File Offset: 0x00041F28
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEntityName.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00005B09 File Offset: 0x00003D09
		public IEntityName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeEntity_Public_Abstract_Virtual_New_Entity_SerializedEntity_Match_Entity_0;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeMethodInfoPtr_ParentEntity_Public_Abstract_Virtual_New_Void_Entity_0;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;
	}
}

using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.attributes
{
	// Token: 0x02000013 RID: 19
	public class IEntity : Il2CppObjectBase
	{
		// Token: 0x06000156 RID: 342 RVA: 0x00006DA0 File Offset: 0x00004FA0
		// Note: this type is marked as 'beforefieldinit'.
		static IEntity()
		{
			Il2CppClassPointerStore<IEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes", "IEntity");
			IEntity.NativeMethodInfoPtr_get_EntityName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntity>.NativeClassPtr, 100663361);
			IEntity.NativeMethodInfoPtr_get_EntityID_Public_Abstract_Virtual_New_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntity>.NativeClassPtr, 100663362);
			IEntity.NativeMethodInfoPtr_get_OwningPlayerID_Public_Abstract_Virtual_New_get_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntity>.NativeClassPtr, 100663363);
			IEntity.NativeMethodInfoPtr_get_Children_Public_Abstract_Virtual_New_get_IEnumerable_1_IEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntity>.NativeClassPtr, 100663364);
			IEntity.NativeMethodInfoPtr_get_Parent_Public_Abstract_Virtual_New_get_IEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntity>.NativeClassPtr, 100663365);
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00006E2C File Offset: 0x0000502C
		public unsafe virtual string EntityName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEntity.NativeMethodInfoPtr_get_EntityName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00006E70 File Offset: 0x00005070
		public unsafe virtual EntityID EntityID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEntity.NativeMethodInfoPtr_get_EntityID_Public_Abstract_Virtual_New_get_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00006EBC File Offset: 0x000050BC
		public unsafe virtual AccountID OwningPlayerID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEntity.NativeMethodInfoPtr_get_OwningPlayerID_Public_Abstract_Virtual_New_get_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00006F08 File Offset: 0x00005108
		public unsafe virtual IEnumerable<IEntity> Children
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEntity.NativeMethodInfoPtr_get_Children_Public_Abstract_Virtual_New_get_IEnumerable_1_IEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00006F54 File Offset: 0x00005154
		public unsafe virtual IEntity Parent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEntity.NativeMethodInfoPtr_get_Parent_Public_Abstract_Virtual_New_get_IEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEntity>(intPtr3) : null;
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002A50 File Offset: 0x00000C50
		public IEntity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_get_EntityName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_get_EntityID_Public_Abstract_Virtual_New_get_EntityID_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_get_OwningPlayerID_Public_Abstract_Virtual_New_get_AccountID_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_get_Children_Public_Abstract_Virtual_New_get_IEnumerable_1_IEntity_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_Abstract_Virtual_New_get_IEntity_0;
	}
}

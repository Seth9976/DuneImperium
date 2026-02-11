using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.messages
{
	// Token: 0x02000022 RID: 34
	public class EntityOwnerChanged : GameMessage
	{
		// Token: 0x06000120 RID: 288 RVA: 0x00008ED4 File Offset: 0x000070D4
		// Note: this type is marked as 'beforefieldinit'.
		static EntityOwnerChanged()
		{
			Il2CppClassPointerStore<EntityOwnerChanged>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages", "EntityOwnerChanged");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityOwnerChanged>.NativeClassPtr);
			EntityOwnerChanged.NativeFieldInfoPtr_EntityIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOwnerChanged>.NativeClassPtr, "EntityIDs");
			EntityOwnerChanged.NativeFieldInfoPtr_NewOwnerAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOwnerChanged>.NativeClassPtr, "NewOwnerAccountID");
			EntityOwnerChanged.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwnerChanged>.NativeClassPtr, 100663354);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00008F40 File Offset: 0x00007140
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityOwnerChanged()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityOwnerChanged>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOwnerChanged.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002BF6 File Offset: 0x00000DF6
		public EntityOwnerChanged(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00008F7C File Offset: 0x0000717C
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00002BFF File Offset: 0x00000DFF
		public unsafe List<EntityID> EntityIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerChanged.NativeFieldInfoPtr_EntityIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerChanged.NativeFieldInfoPtr_EntityIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00008FAC File Offset: 0x000071AC
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00002C1E File Offset: 0x00000E1E
		public unsafe AccountID NewOwnerAccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerChanged.NativeFieldInfoPtr_NewOwnerAccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOwnerChanged.NativeFieldInfoPtr_NewOwnerAccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeFieldInfoPtr_EntityIDs;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeFieldInfoPtr_NewOwnerAccountID;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages
{
	// Token: 0x0200001D RID: 29
	public class EntityAdded : GameMessage
	{
		// Token: 0x060000EC RID: 236 RVA: 0x0000867C File Offset: 0x0000687C
		// Note: this type is marked as 'beforefieldinit'.
		static EntityAdded()
		{
			Il2CppClassPointerStore<EntityAdded>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages", "EntityAdded");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityAdded>.NativeClassPtr);
			EntityAdded.NativeFieldInfoPtr_EntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAdded>.NativeClassPtr, "EntityID");
			EntityAdded.NativeFieldInfoPtr_OwningPlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAdded>.NativeClassPtr, "OwningPlayerID");
			EntityAdded.NativeFieldInfoPtr_ParentEntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAdded>.NativeClassPtr, "ParentEntityID");
			EntityAdded.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAdded>.NativeClassPtr, 100663344);
			EntityAdded.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAdded>.NativeClassPtr, 100663345);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00008710 File Offset: 0x00006910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193560, XrefRangeEnd = 1193563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityAdded.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00008754 File Offset: 0x00006954
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityAdded()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityAdded>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityAdded.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000029E5 File Offset: 0x00000BE5
		public EntityAdded(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00008790 File Offset: 0x00006990
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x000029EE File Offset: 0x00000BEE
		public unsafe EntityID EntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAdded.NativeFieldInfoPtr_EntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAdded.NativeFieldInfoPtr_EntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x000087C0 File Offset: 0x000069C0
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002A0D File Offset: 0x00000C0D
		public unsafe AccountID OwningPlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAdded.NativeFieldInfoPtr_OwningPlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAdded.NativeFieldInfoPtr_OwningPlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x000087F0 File Offset: 0x000069F0
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002A2C File Offset: 0x00000C2C
		public unsafe EntityID ParentEntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAdded.NativeFieldInfoPtr_ParentEntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityAdded.NativeFieldInfoPtr_ParentEntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_EntityID;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_OwningPlayerID;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_ParentEntityID;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

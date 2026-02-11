using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages
{
	// Token: 0x02000020 RID: 32
	public class EntityMoved : GameMessage
	{
		// Token: 0x06000106 RID: 262 RVA: 0x00008AD8 File Offset: 0x00006CD8
		// Note: this type is marked as 'beforefieldinit'.
		static EntityMoved()
		{
			Il2CppClassPointerStore<EntityMoved>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages", "EntityMoved");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityMoved>.NativeClassPtr);
			EntityMoved.NativeFieldInfoPtr_EntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMoved>.NativeClassPtr, "EntityID");
			EntityMoved.NativeFieldInfoPtr_SourceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMoved>.NativeClassPtr, "SourceID");
			EntityMoved.NativeFieldInfoPtr_DestinationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMoved>.NativeClassPtr, "DestinationID");
			EntityMoved.NativeFieldInfoPtr_PositionInParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMoved>.NativeClassPtr, "PositionInParent");
			EntityMoved.NativeFieldInfoPtr_AnimDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMoved>.NativeClassPtr, "AnimDuration");
			EntityMoved.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityMoved>.NativeClassPtr, 100663350);
			EntityMoved.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityMoved>.NativeClassPtr, 100663351);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00008B94 File Offset: 0x00006D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193569, XrefRangeEnd = 1193572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityMoved.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00008BD8 File Offset: 0x00006DD8
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityMoved()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityMoved>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityMoved.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002AD9 File Offset: 0x00000CD9
		public EntityMoved(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00008C14 File Offset: 0x00006E14
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00002AE2 File Offset: 0x00000CE2
		public unsafe EntityID EntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMoved.NativeFieldInfoPtr_EntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMoved.NativeFieldInfoPtr_EntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00008C44 File Offset: 0x00006E44
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00002B01 File Offset: 0x00000D01
		public unsafe EntityID SourceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMoved.NativeFieldInfoPtr_SourceID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMoved.NativeFieldInfoPtr_SourceID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00008C74 File Offset: 0x00006E74
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00002B20 File Offset: 0x00000D20
		public unsafe EntityID DestinationID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMoved.NativeFieldInfoPtr_DestinationID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMoved.NativeFieldInfoPtr_DestinationID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00008CA4 File Offset: 0x00006EA4
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00002B3F File Offset: 0x00000D3F
		public unsafe int PositionInParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMoved.NativeFieldInfoPtr_PositionInParent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMoved.NativeFieldInfoPtr_PositionInParent)) = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00008CCC File Offset: 0x00006ECC
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00002B5A File Offset: 0x00000D5A
		public unsafe int AnimDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMoved.NativeFieldInfoPtr_AnimDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMoved.NativeFieldInfoPtr_AnimDuration)) = value;
			}
		}

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeFieldInfoPtr_EntityID;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr_SourceID;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr_DestinationID;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr_PositionInParent;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_AnimDuration;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages
{
	// Token: 0x02000021 RID: 33
	public class EntityMovedWithoutID : GameMessage
	{
		// Token: 0x06000114 RID: 276 RVA: 0x00008CF4 File Offset: 0x00006EF4
		// Note: this type is marked as 'beforefieldinit'.
		static EntityMovedWithoutID()
		{
			Il2CppClassPointerStore<EntityMovedWithoutID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages", "EntityMovedWithoutID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityMovedWithoutID>.NativeClassPtr);
			EntityMovedWithoutID.NativeFieldInfoPtr_SourceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMovedWithoutID>.NativeClassPtr, "SourceID");
			EntityMovedWithoutID.NativeFieldInfoPtr_DestinationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMovedWithoutID>.NativeClassPtr, "DestinationID");
			EntityMovedWithoutID.NativeFieldInfoPtr_PositionInParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMovedWithoutID>.NativeClassPtr, "PositionInParent");
			EntityMovedWithoutID.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityMovedWithoutID>.NativeClassPtr, "Attributes");
			EntityMovedWithoutID.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityMovedWithoutID>.NativeClassPtr, 100663352);
			EntityMovedWithoutID.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityMovedWithoutID>.NativeClassPtr, 100663353);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00008D9C File Offset: 0x00006F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193572, XrefRangeEnd = 1193575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityMovedWithoutID.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00008DE0 File Offset: 0x00006FE0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityMovedWithoutID()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityMovedWithoutID>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityMovedWithoutID.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002B75 File Offset: 0x00000D75
		public EntityMovedWithoutID(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00008E1C File Offset: 0x0000701C
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00002B7E File Offset: 0x00000D7E
		public unsafe EntityID SourceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedWithoutID.NativeFieldInfoPtr_SourceID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedWithoutID.NativeFieldInfoPtr_SourceID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00008E4C File Offset: 0x0000704C
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00002B9D File Offset: 0x00000D9D
		public unsafe EntityID DestinationID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedWithoutID.NativeFieldInfoPtr_DestinationID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedWithoutID.NativeFieldInfoPtr_DestinationID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00008E7C File Offset: 0x0000707C
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002BBC File Offset: 0x00000DBC
		public unsafe int PositionInParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedWithoutID.NativeFieldInfoPtr_PositionInParent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedWithoutID.NativeFieldInfoPtr_PositionInParent)) = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00008EA4 File Offset: 0x000070A4
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00002BD7 File Offset: 0x00000DD7
		public unsafe ReadOnlyAttributes Attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedWithoutID.NativeFieldInfoPtr_Attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityMovedWithoutID.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr_SourceID;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr_DestinationID;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeFieldInfoPtr_PositionInParent;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeFieldInfoPtr_Attributes;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

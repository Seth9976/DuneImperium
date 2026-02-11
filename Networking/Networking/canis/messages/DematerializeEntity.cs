using System;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages
{
	// Token: 0x0200001C RID: 28
	public class DematerializeEntity : GameMessage
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x00008494 File Offset: 0x00006694
		// Note: this type is marked as 'beforefieldinit'.
		static DematerializeEntity()
		{
			Il2CppClassPointerStore<DematerializeEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages", "DematerializeEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DematerializeEntity>.NativeClassPtr);
			DematerializeEntity.NativeFieldInfoPtr_EntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DematerializeEntity>.NativeClassPtr, "EntityID");
			DematerializeEntity.NativeFieldInfoPtr_SourceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DematerializeEntity>.NativeClassPtr, "SourceID");
			DematerializeEntity.NativeFieldInfoPtr_DestinationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DematerializeEntity>.NativeClassPtr, "DestinationID");
			DematerializeEntity.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DematerializeEntity>.NativeClassPtr, "Attributes");
			DematerializeEntity.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DematerializeEntity>.NativeClassPtr, 100663342);
			DematerializeEntity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DematerializeEntity>.NativeClassPtr, 100663343);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000853C File Offset: 0x0000673C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193557, XrefRangeEnd = 1193560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DematerializeEntity.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00008580 File Offset: 0x00006780
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DematerializeEntity()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DematerializeEntity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DematerializeEntity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002960 File Offset: 0x00000B60
		public DematerializeEntity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x000085BC File Offset: 0x000067BC
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x00002969 File Offset: 0x00000B69
		public unsafe EntityID EntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DematerializeEntity.NativeFieldInfoPtr_EntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DematerializeEntity.NativeFieldInfoPtr_EntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x000085EC File Offset: 0x000067EC
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00002988 File Offset: 0x00000B88
		public unsafe EntityID SourceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DematerializeEntity.NativeFieldInfoPtr_SourceID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DematerializeEntity.NativeFieldInfoPtr_SourceID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0000861C File Offset: 0x0000681C
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x000029A7 File Offset: 0x00000BA7
		public unsafe EntityID DestinationID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DematerializeEntity.NativeFieldInfoPtr_DestinationID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DematerializeEntity.NativeFieldInfoPtr_DestinationID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0000864C File Offset: 0x0000684C
		// (set) Token: 0x060000EB RID: 235 RVA: 0x000029C6 File Offset: 0x00000BC6
		public unsafe ReadOnlyAttributes Attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DematerializeEntity.NativeFieldInfoPtr_Attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DematerializeEntity.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_EntityID;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_SourceID;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_DestinationID;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_Attributes;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

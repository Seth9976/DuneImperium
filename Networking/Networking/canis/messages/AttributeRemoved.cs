using System;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages
{
	// Token: 0x0200001A RID: 26
	public class AttributeRemoved : GameMessage
	{
		// Token: 0x060000CC RID: 204 RVA: 0x00008168 File Offset: 0x00006368
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeRemoved()
		{
			Il2CppClassPointerStore<AttributeRemoved>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages", "AttributeRemoved");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeRemoved>.NativeClassPtr);
			AttributeRemoved.NativeFieldInfoPtr_EntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeRemoved>.NativeClassPtr, "EntityID");
			AttributeRemoved.NativeFieldInfoPtr_AttrDefKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeRemoved>.NativeClassPtr, "AttrDefKey");
			AttributeRemoved.NativeMethodInfoPtr_get_AttrDef_Public_get_IAttributeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeRemoved>.NativeClassPtr, 100663338);
			AttributeRemoved.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeRemoved>.NativeClassPtr, 100663339);
			AttributeRemoved.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeRemoved>.NativeClassPtr, 100663340);
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000CD RID: 205 RVA: 0x000081FC File Offset: 0x000063FC
		public unsafe IAttributeDefinition AttrDef
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193540, XrefRangeEnd = 1193544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeRemoved.NativeMethodInfoPtr_get_AttrDef_Public_get_IAttributeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttributeDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000823C File Offset: 0x0000643C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193544, XrefRangeEnd = 1193557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeRemoved.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00008280 File Offset: 0x00006480
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeRemoved()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeRemoved>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeRemoved.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000289C File Offset: 0x00000A9C
		public AttributeRemoved(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x000082BC File Offset: 0x000064BC
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x000028A5 File Offset: 0x00000AA5
		public unsafe EntityID EntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeRemoved.NativeFieldInfoPtr_EntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeRemoved.NativeFieldInfoPtr_EntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000082EC File Offset: 0x000064EC
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x000028C4 File Offset: 0x00000AC4
		public unsafe int AttrDefKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeRemoved.NativeFieldInfoPtr_AttrDefKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeRemoved.NativeFieldInfoPtr_AttrDefKey)) = value;
			}
		}

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr_EntityID;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_AttrDefKey;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_get_AttrDef_Public_get_IAttributeDefinition_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

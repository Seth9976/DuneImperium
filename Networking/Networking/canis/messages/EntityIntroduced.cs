using System;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages
{
	// Token: 0x0200001F RID: 31
	public class EntityIntroduced : GameMessage
	{
		// Token: 0x060000FC RID: 252 RVA: 0x0000893C File Offset: 0x00006B3C
		// Note: this type is marked as 'beforefieldinit'.
		static EntityIntroduced()
		{
			Il2CppClassPointerStore<EntityIntroduced>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages", "EntityIntroduced");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityIntroduced>.NativeClassPtr);
			EntityIntroduced.NativeFieldInfoPtr_AttributeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityIntroduced>.NativeClassPtr, "AttributeMap");
			EntityIntroduced.NativeFieldInfoPtr_EntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityIntroduced>.NativeClassPtr, "EntityID");
			EntityIntroduced.NativeFieldInfoPtr_EntityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityIntroduced>.NativeClassPtr, "EntityName");
			EntityIntroduced.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityIntroduced>.NativeClassPtr, 100663348);
			EntityIntroduced.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityIntroduced>.NativeClassPtr, 100663349);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000089D0 File Offset: 0x00006BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193566, XrefRangeEnd = 1193569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityIntroduced.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00008A14 File Offset: 0x00006C14
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityIntroduced()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityIntroduced>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityIntroduced.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002A73 File Offset: 0x00000C73
		public EntityIntroduced(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00008A50 File Offset: 0x00006C50
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00002A7C File Offset: 0x00000C7C
		public unsafe ReadOnlyAttributes AttributeMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityIntroduced.NativeFieldInfoPtr_AttributeMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityIntroduced.NativeFieldInfoPtr_AttributeMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00008A80 File Offset: 0x00006C80
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00002A9B File Offset: 0x00000C9B
		public unsafe EntityID EntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityIntroduced.NativeFieldInfoPtr_EntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityIntroduced.NativeFieldInfoPtr_EntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00008AB0 File Offset: 0x00006CB0
		// (set) Token: 0x06000105 RID: 261 RVA: 0x00002ABA File Offset: 0x00000CBA
		public unsafe string EntityName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityIntroduced.NativeFieldInfoPtr_EntityName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityIntroduced.NativeFieldInfoPtr_EntityName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_AttributeMap;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_EntityID;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr_EntityName;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

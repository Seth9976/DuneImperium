using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.utils.ids
{
	// Token: 0x02000019 RID: 25
	public sealed class EntityID : TypedID
	{
		// Token: 0x0600010D RID: 269 RVA: 0x00008AE4 File Offset: 0x00006CE4
		// Note: this type is marked as 'beforefieldinit'.
		static EntityID()
		{
			Il2CppClassPointerStore<EntityID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Canis.utils.ids", "EntityID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityID>.NativeClassPtr);
			EntityID.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityID>.NativeClassPtr, "Empty");
			EntityID.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityID>.NativeClassPtr, 100663467);
			EntityID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityID>.NativeClassPtr, 100663468);
			EntityID.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityID>.NativeClassPtr, 100663469);
			EntityID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityID>.NativeClassPtr, 100663470);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00008B78 File Offset: 0x00006D78
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1179832, RefRangeEnd = 1179837, XrefRangeStart = 1179827, XrefRangeEnd = 1179832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityID(string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityID.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00008BC4 File Offset: 0x00006DC4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1179841, RefRangeEnd = 1179850, XrefRangeStart = 1179837, XrefRangeEnd = 1179841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityID(Guid id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00008C0C File Offset: 0x00006E0C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1179855, RefRangeEnd = 1179860, XrefRangeStart = 1179850, XrefRangeEnd = 1179855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityID()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityID>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityID.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00008C48 File Offset: 0x00006E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179860, XrefRangeEnd = 1179868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypedID CreateID(string guid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypedID>(intPtr3) : null;
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002517 File Offset: 0x00000717
		public EntityID(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00008C8C File Offset: 0x00006E8C
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00002520 File Offset: 0x00000720
		public unsafe static EntityID Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityID.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityID.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0;
	}
}

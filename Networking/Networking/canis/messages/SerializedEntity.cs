using System;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.messages
{
	// Token: 0x0200002E RID: 46
	public class SerializedEntity : Object
	{
		// Token: 0x06000184 RID: 388 RVA: 0x00009DBC File Offset: 0x00007FBC
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedEntity()
		{
			Il2CppClassPointerStore<SerializedEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages", "SerializedEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedEntity>.NativeClassPtr);
			SerializedEntity.NativeFieldInfoPtr_EntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedEntity>.NativeClassPtr, "EntityID");
			SerializedEntity.NativeFieldInfoPtr_ParentID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedEntity>.NativeClassPtr, "ParentID");
			SerializedEntity.NativeFieldInfoPtr_OwningPlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedEntity>.NativeClassPtr, "OwningPlayerID");
			SerializedEntity.NativeFieldInfoPtr_EntityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedEntity>.NativeClassPtr, "EntityName");
			SerializedEntity.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedEntity>.NativeClassPtr, "Attributes");
			SerializedEntity.NativeFieldInfoPtr_Children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedEntity>.NativeClassPtr, "Children");
			SerializedEntity.NativeMethodInfoPtr_get_Introduced_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedEntity>.NativeClassPtr, 100663375);
			SerializedEntity.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedEntity>.NativeClassPtr, 100663376);
			SerializedEntity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedEntity>.NativeClassPtr, 100663377);
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00009EA0 File Offset: 0x000080A0
		public unsafe bool Introduced
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 480628, RefRangeEnd = 480631, XrefRangeStart = 480628, XrefRangeEnd = 480631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedEntity.NativeMethodInfoPtr_get_Introduced_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00009EDC File Offset: 0x000080DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193653, XrefRangeEnd = 1193657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedEntity.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00009F20 File Offset: 0x00008120
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedEntity()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedEntity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedEntity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00003070 File Offset: 0x00001270
		public SerializedEntity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00009F5C File Offset: 0x0000815C
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00003079 File Offset: 0x00001279
		public unsafe EntityID EntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEntity.NativeFieldInfoPtr_EntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEntity.NativeFieldInfoPtr_EntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00009F8C File Offset: 0x0000818C
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00003098 File Offset: 0x00001298
		public unsafe EntityID ParentID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEntity.NativeFieldInfoPtr_ParentID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEntity.NativeFieldInfoPtr_ParentID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00009FBC File Offset: 0x000081BC
		// (set) Token: 0x0600018E RID: 398 RVA: 0x000030B7 File Offset: 0x000012B7
		public unsafe AccountID OwningPlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEntity.NativeFieldInfoPtr_OwningPlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEntity.NativeFieldInfoPtr_OwningPlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00009FEC File Offset: 0x000081EC
		// (set) Token: 0x06000190 RID: 400 RVA: 0x000030D6 File Offset: 0x000012D6
		public unsafe string EntityName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEntity.NativeFieldInfoPtr_EntityName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEntity.NativeFieldInfoPtr_EntityName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000191 RID: 401 RVA: 0x0000A014 File Offset: 0x00008214
		// (set) Token: 0x06000192 RID: 402 RVA: 0x000030F5 File Offset: 0x000012F5
		public unsafe ReadOnlyAttributes Attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEntity.NativeFieldInfoPtr_Attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEntity.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000193 RID: 403 RVA: 0x0000A044 File Offset: 0x00008244
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00003114 File Offset: 0x00001314
		public unsafe Il2CppReferenceArray<SerializedEntity> Children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEntity.NativeFieldInfoPtr_Children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SerializedEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEntity.NativeFieldInfoPtr_Children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeFieldInfoPtr_EntityID;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeFieldInfoPtr_ParentID;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeFieldInfoPtr_OwningPlayerID;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeFieldInfoPtr_EntityName;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeFieldInfoPtr_Attributes;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeFieldInfoPtr_Children;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_get_Introduced_Public_get_Boolean_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

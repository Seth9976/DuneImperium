using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.canis.data.attributes.resource
{
	// Token: 0x020000E3 RID: 227
	public class ResourceMod : Object
	{
		// Token: 0x06000F91 RID: 3985 RVA: 0x0009A8B0 File Offset: 0x00098AB0
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceMod()
		{
			Il2CppClassPointerStore<ResourceMod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.attributes.resource", "ResourceMod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceMod>.NativeClassPtr);
			ResourceMod.NativeFieldInfoPtr_ResourceAttributeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMod>.NativeClassPtr, "ResourceAttributeKey");
			ResourceMod.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMod>.NativeClassPtr, "Amount");
			ResourceMod.NativeFieldInfoPtr_SourceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMod>.NativeClassPtr, "SourceID");
			ResourceMod.NativeFieldInfoPtr_Predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMod>.NativeClassPtr, "Predicate");
			ResourceMod.NativeFieldInfoPtr_Permanent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMod>.NativeClassPtr, "Permanent");
			ResourceMod.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ResourceMod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceMod>.NativeClassPtr, 100666028);
			ResourceMod.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceMod>.NativeClassPtr, 100666029);
			ResourceMod.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceMod>.NativeClassPtr, 100666030);
			ResourceMod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceMod>.NativeClassPtr, 100666031);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x0009A994 File Offset: 0x00098B94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77235, RefRangeEnd = 77236, XrefRangeStart = 77233, XrefRangeEnd = 77235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(ResourceMod other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceMod.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ResourceMod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x0009A9E4 File Offset: 0x00098BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77236, XrefRangeEnd = 77246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceMod.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x0009AA3C File Offset: 0x00098C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77246, XrefRangeEnd = 77252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceMod.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x0009AA84 File Offset: 0x00098C84
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceMod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceMod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceMod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x0000837A File Offset: 0x0000657A
		public ResourceMod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06000F97 RID: 3991 RVA: 0x0009AAC0 File Offset: 0x00098CC0
		// (set) Token: 0x06000F98 RID: 3992 RVA: 0x00008383 File Offset: 0x00006583
		public unsafe int ResourceAttributeKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceMod.NativeFieldInfoPtr_ResourceAttributeKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceMod.NativeFieldInfoPtr_ResourceAttributeKey)) = value;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06000F99 RID: 3993 RVA: 0x0009AAE8 File Offset: 0x00098CE8
		// (set) Token: 0x06000F9A RID: 3994 RVA: 0x0000839E File Offset: 0x0000659E
		public unsafe int Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceMod.NativeFieldInfoPtr_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceMod.NativeFieldInfoPtr_Amount)) = value;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06000F9B RID: 3995 RVA: 0x0009AB10 File Offset: 0x00098D10
		// (set) Token: 0x06000F9C RID: 3996 RVA: 0x000083B9 File Offset: 0x000065B9
		public unsafe EntityID SourceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceMod.NativeFieldInfoPtr_SourceID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceMod.NativeFieldInfoPtr_SourceID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x0009AB40 File Offset: 0x00098D40
		// (set) Token: 0x06000F9E RID: 3998 RVA: 0x000083D8 File Offset: 0x000065D8
		public unsafe ResourceModPredicate Predicate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceMod.NativeFieldInfoPtr_Predicate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceModPredicate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceMod.NativeFieldInfoPtr_Predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06000F9F RID: 3999 RVA: 0x0009AB70 File Offset: 0x00098D70
		// (set) Token: 0x06000FA0 RID: 4000 RVA: 0x000083F7 File Offset: 0x000065F7
		public unsafe bool Permanent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceMod.NativeFieldInfoPtr_Permanent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceMod.NativeFieldInfoPtr_Permanent)) = value;
			}
		}

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeFieldInfoPtr_ResourceAttributeKey;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeFieldInfoPtr_Amount;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeFieldInfoPtr_SourceID;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeFieldInfoPtr_Predicate;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeFieldInfoPtr_Permanent;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ResourceMod_0;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

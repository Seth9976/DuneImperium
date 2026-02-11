using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using worm.canis.entities;

namespace worm.canis.data.attributes.resource
{
	// Token: 0x020000E5 RID: 229
	public class ResourceModPredicate : Object
	{
		// Token: 0x06000FA4 RID: 4004 RVA: 0x0009AC30 File Offset: 0x00098E30
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceModPredicate()
		{
			Il2CppClassPointerStore<ResourceModPredicate>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.attributes.resource", "ResourceModPredicate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceModPredicate>.NativeClassPtr);
			ResourceModPredicate.NativeMethodInfoPtr_ShouldApply_Public_Abstract_Virtual_New_Boolean_WormPlayer_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceModPredicate>.NativeClassPtr, 100666033);
			ResourceModPredicate.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_ResourceModPredicate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceModPredicate>.NativeClassPtr, 100666034);
			ResourceModPredicate.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceModPredicate>.NativeClassPtr, 100666035);
			ResourceModPredicate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceModPredicate>.NativeClassPtr, 100666036);
			ResourceModPredicate.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceModPredicate>.NativeClassPtr, 100666037);
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x0009ACC4 File Offset: 0x00098EC4
		[CallerCount(0)]
		public unsafe virtual bool ShouldApply(WormPlayer player, WormPlayable origin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(origin);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceModPredicate.NativeMethodInfoPtr_ShouldApply_Public_Abstract_Virtual_New_Boolean_WormPlayer_WormPlayable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x0009AD30 File Offset: 0x00098F30
		[CallerCount(0)]
		public unsafe virtual bool Equals(ResourceModPredicate other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceModPredicate.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_ResourceModPredicate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x0009AD88 File Offset: 0x00098F88
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceModPredicate.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x0009ADD0 File Offset: 0x00098FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77278, XrefRangeEnd = 77286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceModPredicate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x0009AE28 File Offset: 0x00099028
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceModPredicate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceModPredicate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceModPredicate.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00008454 File Offset: 0x00006654
		public ResourceModPredicate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeMethodInfoPtr_ShouldApply_Public_Abstract_Virtual_New_Boolean_WormPlayer_WormPlayable_0;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_ResourceModPredicate_0;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_Int32_0;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

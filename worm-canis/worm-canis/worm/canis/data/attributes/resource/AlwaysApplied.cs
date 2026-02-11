using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using worm.canis.entities;

namespace worm.canis.data.attributes.resource
{
	// Token: 0x020000E1 RID: 225
	public class AlwaysApplied : ResourceModPredicate
	{
		// Token: 0x06000F85 RID: 3973 RVA: 0x0009A520 File Offset: 0x00098720
		// Note: this type is marked as 'beforefieldinit'.
		static AlwaysApplied()
		{
			Il2CppClassPointerStore<AlwaysApplied>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.attributes.resource", "AlwaysApplied");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlwaysApplied>.NativeClassPtr);
			AlwaysApplied.NativeMethodInfoPtr_ShouldApply_Public_Virtual_Boolean_WormPlayer_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlwaysApplied>.NativeClassPtr, 100666020);
			AlwaysApplied.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_ResourceModPredicate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlwaysApplied>.NativeClassPtr, 100666021);
			AlwaysApplied.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlwaysApplied>.NativeClassPtr, 100666022);
			AlwaysApplied.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlwaysApplied>.NativeClassPtr, 100666023);
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x0009A5A0 File Offset: 0x000987A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77212, XrefRangeEnd = 77213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldApply(WormPlayer player, WormPlayable origin)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AlwaysApplied.NativeMethodInfoPtr_ShouldApply_Public_Virtual_Boolean_WormPlayer_WormPlayable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x0009A60C File Offset: 0x0009880C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77213, XrefRangeEnd = 77214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(ResourceModPredicate other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AlwaysApplied.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_ResourceModPredicate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x0009A664 File Offset: 0x00098864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77214, XrefRangeEnd = 77217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AlwaysApplied.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x0009A6AC File Offset: 0x000988AC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AlwaysApplied()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AlwaysApplied>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AlwaysApplied.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00008368 File Offset: 0x00006568
		public AlwaysApplied(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeMethodInfoPtr_ShouldApply_Public_Virtual_Boolean_WormPlayer_WormPlayable_0;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_ResourceModPredicate_0;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

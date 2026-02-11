using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using worm.canis.entities;

namespace worm.canis.data.attributes.resource
{
	// Token: 0x020000E0 RID: 224
	public class AfterRevealStrengthApplied : ResourceModPredicate
	{
		// Token: 0x06000F7F RID: 3967 RVA: 0x0009A358 File Offset: 0x00098558
		// Note: this type is marked as 'beforefieldinit'.
		static AfterRevealStrengthApplied()
		{
			Il2CppClassPointerStore<AfterRevealStrengthApplied>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.attributes.resource", "AfterRevealStrengthApplied");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AfterRevealStrengthApplied>.NativeClassPtr);
			AfterRevealStrengthApplied.NativeMethodInfoPtr_ShouldApply_Public_Virtual_Boolean_WormPlayer_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AfterRevealStrengthApplied>.NativeClassPtr, 100666016);
			AfterRevealStrengthApplied.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_ResourceModPredicate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AfterRevealStrengthApplied>.NativeClassPtr, 100666017);
			AfterRevealStrengthApplied.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AfterRevealStrengthApplied>.NativeClassPtr, 100666018);
			AfterRevealStrengthApplied.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AfterRevealStrengthApplied>.NativeClassPtr, 100666019);
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x0009A3D8 File Offset: 0x000985D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77199, XrefRangeEnd = 77208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AfterRevealStrengthApplied.NativeMethodInfoPtr_ShouldApply_Public_Virtual_Boolean_WormPlayer_WormPlayable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x0009A444 File Offset: 0x00098644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77208, XrefRangeEnd = 77209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(ResourceModPredicate other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AfterRevealStrengthApplied.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_ResourceModPredicate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x0009A49C File Offset: 0x0009869C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77209, XrefRangeEnd = 77212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AfterRevealStrengthApplied.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x0009A4E4 File Offset: 0x000986E4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AfterRevealStrengthApplied()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AfterRevealStrengthApplied>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AfterRevealStrengthApplied.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x0000835F File Offset: 0x0000655F
		public AfterRevealStrengthApplied(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeMethodInfoPtr_ShouldApply_Public_Virtual_Boolean_WormPlayer_WormPlayable_0;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_ResourceModPredicate_0;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

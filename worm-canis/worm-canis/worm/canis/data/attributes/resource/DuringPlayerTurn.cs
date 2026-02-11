using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using worm.canis.entities;

namespace worm.canis.data.attributes.resource
{
	// Token: 0x020000E2 RID: 226
	public class DuringPlayerTurn : ResourceModPredicate
	{
		// Token: 0x06000F8B RID: 3979 RVA: 0x0009A6E8 File Offset: 0x000988E8
		// Note: this type is marked as 'beforefieldinit'.
		static DuringPlayerTurn()
		{
			Il2CppClassPointerStore<DuringPlayerTurn>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.attributes.resource", "DuringPlayerTurn");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DuringPlayerTurn>.NativeClassPtr);
			DuringPlayerTurn.NativeMethodInfoPtr_ShouldApply_Public_Virtual_Boolean_WormPlayer_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuringPlayerTurn>.NativeClassPtr, 100666024);
			DuringPlayerTurn.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_ResourceModPredicate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuringPlayerTurn>.NativeClassPtr, 100666025);
			DuringPlayerTurn.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuringPlayerTurn>.NativeClassPtr, 100666026);
			DuringPlayerTurn.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuringPlayerTurn>.NativeClassPtr, 100666027);
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x0009A768 File Offset: 0x00098968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77217, XrefRangeEnd = 77229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DuringPlayerTurn.NativeMethodInfoPtr_ShouldApply_Public_Virtual_Boolean_WormPlayer_WormPlayable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x0009A7D4 File Offset: 0x000989D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77229, XrefRangeEnd = 77230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(ResourceModPredicate other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DuringPlayerTurn.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_ResourceModPredicate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x0009A82C File Offset: 0x00098A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77230, XrefRangeEnd = 77233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DuringPlayerTurn.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x0009A874 File Offset: 0x00098A74
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DuringPlayerTurn()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DuringPlayerTurn>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DuringPlayerTurn.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00008371 File Offset: 0x00006571
		public DuringPlayerTurn(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeMethodInfoPtr_ShouldApply_Public_Virtual_Boolean_WormPlayer_WormPlayable_0;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_ResourceModPredicate_0;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

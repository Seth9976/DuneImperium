using System;
using Canis;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.obfuscation
{
	// Token: 0x02000012 RID: 18
	public class ParentOwnerFXLocation : FXLocationGenerator
	{
		// Token: 0x06000102 RID: 258 RVA: 0x0006E21C File Offset: 0x0006C41C
		// Note: this type is marked as 'beforefieldinit'.
		static ParentOwnerFXLocation()
		{
			Il2CppClassPointerStore<ParentOwnerFXLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.obfuscation", "ParentOwnerFXLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParentOwnerFXLocation>.NativeClassPtr);
			ParentOwnerFXLocation.NativeMethodInfoPtr_MakeLocation_Public_Virtual_EntityID_EntityMoved_EntityID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParentOwnerFXLocation>.NativeClassPtr, 100663744);
			ParentOwnerFXLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParentOwnerFXLocation>.NativeClassPtr, 100663745);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0006E274 File Offset: 0x0006C474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31143, XrefRangeEnd = 31144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EntityID MakeLocation(EntityMoved entityMoved, EntityID parentID, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityMoved);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParentOwnerFXLocation.NativeMethodInfoPtr_MakeLocation_Public_Virtual_EntityID_EntityMoved_EntityID_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0006E2F4 File Offset: 0x0006C4F4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParentOwnerFXLocation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParentOwnerFXLocation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParentOwnerFXLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000023FC File Offset: 0x000005FC
		public ParentOwnerFXLocation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_MakeLocation_Public_Virtual_EntityID_EntityMoved_EntityID_Match_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

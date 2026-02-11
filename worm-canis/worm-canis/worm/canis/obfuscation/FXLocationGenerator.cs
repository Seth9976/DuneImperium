using System;
using Canis;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.canis.obfuscation
{
	// Token: 0x02000011 RID: 17
	[Serializable]
	public class FXLocationGenerator : Object
	{
		// Token: 0x060000FE RID: 254 RVA: 0x0006E108 File Offset: 0x0006C308
		// Note: this type is marked as 'beforefieldinit'.
		static FXLocationGenerator()
		{
			Il2CppClassPointerStore<FXLocationGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.obfuscation", "FXLocationGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXLocationGenerator>.NativeClassPtr);
			FXLocationGenerator.NativeMethodInfoPtr_MakeLocation_Public_Abstract_Virtual_New_EntityID_EntityMoved_EntityID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXLocationGenerator>.NativeClassPtr, 100663742);
			FXLocationGenerator.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXLocationGenerator>.NativeClassPtr, 100663743);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0006E160 File Offset: 0x0006C360
		[CallerCount(0)]
		public unsafe virtual EntityID MakeLocation(EntityMoved entityMoved, EntityID parentID, Match match)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FXLocationGenerator.NativeMethodInfoPtr_MakeLocation_Public_Abstract_Virtual_New_EntityID_EntityMoved_EntityID_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0006E1E0 File Offset: 0x0006C3E0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FXLocationGenerator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXLocationGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXLocationGenerator.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000023F3 File Offset: 0x000005F3
		public FXLocationGenerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_MakeLocation_Public_Abstract_Virtual_New_EntityID_EntityMoved_EntityID_Match_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

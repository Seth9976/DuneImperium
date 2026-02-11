using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;

namespace worm
{
	// Token: 0x02000045 RID: 69
	public class WormBoxView : HiddenPile
	{
		// Token: 0x060002F0 RID: 752 RVA: 0x00021E00 File Offset: 0x00020000
		// Note: this type is marked as 'beforefieldinit'.
		static WormBoxView()
		{
			Il2CppClassPointerStore<WormBoxView>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormBoxView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormBoxView>.NativeClassPtr);
			WormBoxView.NativeMethodInfoPtr_createView_Protected_Virtual_UnitView_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoxView>.NativeClassPtr, 100663775);
			WormBoxView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBoxView>.NativeClassPtr, 100663776);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00021E58 File Offset: 0x00020058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690910, XrefRangeEnd = 690919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override UnitView createView(EntityComponent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormBoxView.NativeMethodInfoPtr_createView_Protected_Virtual_UnitView_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr3) : null;
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00021EB4 File Offset: 0x000200B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690919, XrefRangeEnd = 690920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormBoxView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormBoxView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBoxView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x000035B0 File Offset: 0x000017B0
		public WormBoxView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_createView_Protected_Virtual_UnitView_EntityComponent_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;

namespace worm
{
	// Token: 0x02000048 RID: 72
	public class WormPlayerUILoader : HiddenPile
	{
		// Token: 0x0600031D RID: 797 RVA: 0x00022730 File Offset: 0x00020930
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayerUILoader()
		{
			Il2CppClassPointerStore<WormPlayerUILoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormPlayerUILoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerUILoader>.NativeClassPtr);
			WormPlayerUILoader.NativeFieldInfoPtr_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerUILoader>.NativeClassPtr, "provider");
			WormPlayerUILoader.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerUILoader>.NativeClassPtr, 100663795);
			WormPlayerUILoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerUILoader>.NativeClassPtr, 100663796);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0002279C File Offset: 0x0002099C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691391, XrefRangeEnd = 691400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init(EntityComponent ec, EntityView p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerUILoader.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000227FC File Offset: 0x000209FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerUILoader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerUILoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerUILoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000373F File Offset: 0x0000193F
		public WormPlayerUILoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00022838 File Offset: 0x00020A38
		// (set) Token: 0x06000322 RID: 802 RVA: 0x00003748 File Offset: 0x00001948
		public unsafe SubscriptionProvider provider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerUILoader.NativeFieldInfoPtr_provider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerUILoader.NativeFieldInfoPtr_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeFieldInfoPtr_provider;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

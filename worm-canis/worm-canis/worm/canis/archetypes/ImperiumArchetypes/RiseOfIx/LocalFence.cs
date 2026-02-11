using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x02000189 RID: 393
	public class LocalFence : WormArchetype
	{
		// Token: 0x06001304 RID: 4868 RVA: 0x000A3724 File Offset: 0x000A1924
		// Note: this type is marked as 'beforefieldinit'.
		static LocalFence()
		{
			Il2CppClassPointerStore<LocalFence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "LocalFence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalFence>.NativeClassPtr);
			LocalFence.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalFence>.NativeClassPtr, "archID");
			LocalFence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalFence>.NativeClassPtr, 100666418);
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x000A377C File Offset: 0x000A197C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99661, XrefRangeEnd = 99824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalFence()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalFence>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalFence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x000095F9 File Offset: 0x000077F9
		public LocalFence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001307 RID: 4871 RVA: 0x000A37B8 File Offset: 0x000A19B8
		// (set) Token: 0x06001308 RID: 4872 RVA: 0x00009602 File Offset: 0x00007802
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalFence.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalFence.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

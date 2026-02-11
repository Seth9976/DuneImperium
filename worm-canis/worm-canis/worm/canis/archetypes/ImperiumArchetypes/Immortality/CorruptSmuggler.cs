using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x02000198 RID: 408
	public class CorruptSmuggler : WormArchetype
	{
		// Token: 0x0600134F RID: 4943 RVA: 0x000A4228 File Offset: 0x000A2428
		// Note: this type is marked as 'beforefieldinit'.
		static CorruptSmuggler()
		{
			Il2CppClassPointerStore<CorruptSmuggler>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "CorruptSmuggler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CorruptSmuggler>.NativeClassPtr);
			CorruptSmuggler.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CorruptSmuggler>.NativeClassPtr, "archID");
			CorruptSmuggler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CorruptSmuggler>.NativeClassPtr, 100666448);
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x000A4280 File Offset: 0x000A2480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102683, XrefRangeEnd = 102885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CorruptSmuggler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CorruptSmuggler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CorruptSmuggler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x0000978E File Offset: 0x0000798E
		public CorruptSmuggler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x000A42BC File Offset: 0x000A24BC
		// (set) Token: 0x06001353 RID: 4947 RVA: 0x00009797 File Offset: 0x00007997
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CorruptSmuggler.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CorruptSmuggler.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TechTileArchetypes.RiseOfIx
{
	// Token: 0x02000109 RID: 265
	public class Spaceport : WormArchetype
	{
		// Token: 0x06001084 RID: 4228 RVA: 0x0009D924 File Offset: 0x0009BB24
		// Note: this type is marked as 'beforefieldinit'.
		static Spaceport()
		{
			Il2CppClassPointerStore<Spaceport>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TechTileArchetypes.RiseOfIx", "Spaceport");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spaceport>.NativeClassPtr);
			Spaceport.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spaceport>.NativeClassPtr, "archID");
			Spaceport.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spaceport>.NativeClassPtr, 100666162);
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x0009D97C File Offset: 0x0009BB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83035, XrefRangeEnd = 83154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spaceport()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spaceport>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spaceport.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x00008879 File Offset: 0x00006A79
		public Spaceport(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001087 RID: 4231 RVA: 0x0009D9B8 File Offset: 0x0009BBB8
		// (set) Token: 0x06001088 RID: 4232 RVA: 0x00008882 File Offset: 0x00006A82
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Spaceport.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spaceport.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AA3 RID: 2723
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AA4 RID: 2724
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

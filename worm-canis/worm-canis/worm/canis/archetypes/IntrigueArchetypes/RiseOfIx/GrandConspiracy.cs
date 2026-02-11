using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.RiseOfIx
{
	// Token: 0x02000140 RID: 320
	public class GrandConspiracy : WormArchetype
	{
		// Token: 0x06001197 RID: 4503 RVA: 0x000A0188 File Offset: 0x0009E388
		// Note: this type is marked as 'beforefieldinit'.
		static GrandConspiracy()
		{
			Il2CppClassPointerStore<GrandConspiracy>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.RiseOfIx", "GrandConspiracy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrandConspiracy>.NativeClassPtr);
			GrandConspiracy.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrandConspiracy>.NativeClassPtr, "archID");
			GrandConspiracy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrandConspiracy>.NativeClassPtr, 100666272);
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x000A01E0 File Offset: 0x0009E3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89757, XrefRangeEnd = 89872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GrandConspiracy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrandConspiracy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrandConspiracy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x00008E46 File Offset: 0x00007046
		public GrandConspiracy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x000A021C File Offset: 0x0009E41C
		// (set) Token: 0x0600119B RID: 4507 RVA: 0x00008E4F File Offset: 0x0000704F
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GrandConspiracy.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GrandConspiracy.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x0200015A RID: 346
	public class Charisma : WormArchetype
	{
		// Token: 0x06001219 RID: 4633 RVA: 0x000A14A0 File Offset: 0x0009F6A0
		// Note: this type is marked as 'beforefieldinit'.
		static Charisma()
		{
			Il2CppClassPointerStore<Charisma>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "Charisma");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Charisma>.NativeClassPtr);
			Charisma.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Charisma>.NativeClassPtr, "archID");
			Charisma.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Charisma>.NativeClassPtr, 100666324);
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x000A14F8 File Offset: 0x0009F6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92786, XrefRangeEnd = 92901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Charisma()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Charisma>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Charisma.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x00009104 File Offset: 0x00007304
		public Charisma(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x0600121C RID: 4636 RVA: 0x000A1534 File Offset: 0x0009F734
		// (set) Token: 0x0600121D RID: 4637 RVA: 0x0000910D File Offset: 0x0000730D
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Charisma.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Charisma.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

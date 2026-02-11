using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001B1 RID: 433
	public class BeneGesseritInitiate : WormArchetype
	{
		// Token: 0x060013CC RID: 5068 RVA: 0x000A5484 File Offset: 0x000A3684
		// Note: this type is marked as 'beforefieldinit'.
		static BeneGesseritInitiate()
		{
			Il2CppClassPointerStore<BeneGesseritInitiate>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "BeneGesseritInitiate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeneGesseritInitiate>.NativeClassPtr);
			BeneGesseritInitiate.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeneGesseritInitiate>.NativeClassPtr, "archID");
			BeneGesseritInitiate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneGesseritInitiate>.NativeClassPtr, 100666498);
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x000A54DC File Offset: 0x000A36DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107674, XrefRangeEnd = 107867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BeneGesseritInitiate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeneGesseritInitiate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeneGesseritInitiate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x00009A31 File Offset: 0x00007C31
		public BeneGesseritInitiate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x000A5518 File Offset: 0x000A3718
		// (set) Token: 0x060013D0 RID: 5072 RVA: 0x00009A3A File Offset: 0x00007C3A
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BeneGesseritInitiate.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BeneGesseritInitiate.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BF3 RID: 3059
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

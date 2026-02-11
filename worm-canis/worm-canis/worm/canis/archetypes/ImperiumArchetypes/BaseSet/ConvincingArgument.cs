using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001B6 RID: 438
	public class ConvincingArgument : WormArchetype
	{
		// Token: 0x060013E5 RID: 5093 RVA: 0x000A5830 File Offset: 0x000A3A30
		// Note: this type is marked as 'beforefieldinit'.
		static ConvincingArgument()
		{
			Il2CppClassPointerStore<ConvincingArgument>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "ConvincingArgument");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConvincingArgument>.NativeClassPtr);
			ConvincingArgument.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvincingArgument>.NativeClassPtr, "archID");
			ConvincingArgument.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvincingArgument>.NativeClassPtr, 100666508);
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x000A5888 File Offset: 0x000A3A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108624, XrefRangeEnd = 108750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConvincingArgument()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConvincingArgument>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConvincingArgument.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x00009AB8 File Offset: 0x00007CB8
		public ConvincingArgument(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x000A58C4 File Offset: 0x000A3AC4
		// (set) Token: 0x060013E9 RID: 5097 RVA: 0x00009AC1 File Offset: 0x00007CC1
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConvincingArgument.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConvincingArgument.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

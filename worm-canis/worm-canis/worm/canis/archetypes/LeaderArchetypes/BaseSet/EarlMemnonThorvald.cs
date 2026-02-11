using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.LeaderArchetypes.BaseSet
{
	// Token: 0x02000134 RID: 308
	public class EarlMemnonThorvald : WormArchetype
	{
		// Token: 0x0600115B RID: 4443 RVA: 0x0009F8B8 File Offset: 0x0009DAB8
		// Note: this type is marked as 'beforefieldinit'.
		static EarlMemnonThorvald()
		{
			Il2CppClassPointerStore<EarlMemnonThorvald>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.LeaderArchetypes.BaseSet", "EarlMemnonThorvald");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlMemnonThorvald>.NativeClassPtr);
			EarlMemnonThorvald.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EarlMemnonThorvald>.NativeClassPtr, "archID");
			EarlMemnonThorvald.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EarlMemnonThorvald>.NativeClassPtr, 100666248);
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x0009F910 File Offset: 0x0009DB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88418, XrefRangeEnd = 88532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EarlMemnonThorvald()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EarlMemnonThorvald>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EarlMemnonThorvald.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00008D02 File Offset: 0x00006F02
		public EarlMemnonThorvald(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x0009F94C File Offset: 0x0009DB4C
		// (set) Token: 0x0600115F RID: 4447 RVA: 0x00008D0B File Offset: 0x00006F0B
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EarlMemnonThorvald.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EarlMemnonThorvald.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

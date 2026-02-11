using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.RiseOfIx
{
	// Token: 0x02000143 RID: 323
	public class QuidProQuo : WormArchetype
	{
		// Token: 0x060011A6 RID: 4518 RVA: 0x000A03BC File Offset: 0x0009E5BC
		// Note: this type is marked as 'beforefieldinit'.
		static QuidProQuo()
		{
			Il2CppClassPointerStore<QuidProQuo>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.RiseOfIx", "QuidProQuo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuidProQuo>.NativeClassPtr);
			QuidProQuo.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuidProQuo>.NativeClassPtr, "archID");
			QuidProQuo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuo>.NativeClassPtr, 100666278);
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x000A0414 File Offset: 0x0009E614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90127, XrefRangeEnd = 90233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuidProQuo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuidProQuo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x00008E97 File Offset: 0x00007097
		public QuidProQuo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x000A0450 File Offset: 0x0009E650
		// (set) Token: 0x060011AA RID: 4522 RVA: 0x00008EA0 File Offset: 0x000070A0
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(QuidProQuo.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(QuidProQuo.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

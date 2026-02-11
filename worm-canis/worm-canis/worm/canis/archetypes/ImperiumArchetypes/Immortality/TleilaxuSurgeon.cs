using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x020001AD RID: 429
	public class TleilaxuSurgeon : WormArchetype
	{
		// Token: 0x060013B8 RID: 5048 RVA: 0x000A5194 File Offset: 0x000A3394
		// Note: this type is marked as 'beforefieldinit'.
		static TleilaxuSurgeon()
		{
			Il2CppClassPointerStore<TleilaxuSurgeon>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "TleilaxuSurgeon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TleilaxuSurgeon>.NativeClassPtr);
			TleilaxuSurgeon.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TleilaxuSurgeon>.NativeClassPtr, "archID");
			TleilaxuSurgeon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuSurgeon>.NativeClassPtr, 100666490);
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x000A51EC File Offset: 0x000A33EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106956, XrefRangeEnd = 107150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TleilaxuSurgeon()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TleilaxuSurgeon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TleilaxuSurgeon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x000099C5 File Offset: 0x00007BC5
		public TleilaxuSurgeon(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x000A5228 File Offset: 0x000A3428
		// (set) Token: 0x060013BC RID: 5052 RVA: 0x000099CE File Offset: 0x00007BCE
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TleilaxuSurgeon.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TleilaxuSurgeon.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BEB RID: 3051
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BEC RID: 3052
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

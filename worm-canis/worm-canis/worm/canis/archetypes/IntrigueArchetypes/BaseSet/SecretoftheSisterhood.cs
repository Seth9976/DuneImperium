using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x0200016D RID: 365
	public class SecretoftheSisterhood : WormArchetype
	{
		// Token: 0x06001278 RID: 4728 RVA: 0x000A2294 File Offset: 0x000A0494
		// Note: this type is marked as 'beforefieldinit'.
		static SecretoftheSisterhood()
		{
			Il2CppClassPointerStore<SecretoftheSisterhood>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "SecretoftheSisterhood");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecretoftheSisterhood>.NativeClassPtr);
			SecretoftheSisterhood.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecretoftheSisterhood>.NativeClassPtr, "archID");
			SecretoftheSisterhood.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretoftheSisterhood>.NativeClassPtr, 100666362);
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x000A22EC File Offset: 0x000A04EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94848, XrefRangeEnd = 94967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecretoftheSisterhood()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecretoftheSisterhood>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecretoftheSisterhood.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x00009305 File Offset: 0x00007505
		public SecretoftheSisterhood(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x0600127B RID: 4731 RVA: 0x000A2328 File Offset: 0x000A0528
		// (set) Token: 0x0600127C RID: 4732 RVA: 0x0000930E File Offset: 0x0000750E
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SecretoftheSisterhood.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SecretoftheSisterhood.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

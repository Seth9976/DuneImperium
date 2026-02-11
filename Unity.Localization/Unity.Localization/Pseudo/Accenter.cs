using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.Pseudo
{
	// Token: 0x020000A6 RID: 166
	[Serializable]
	public class Accenter : CharacterSubstitutor
	{
		// Token: 0x06000839 RID: 2105 RVA: 0x00028FC4 File Offset: 0x000271C4
		// Note: this type is marked as 'beforefieldinit'.
		static Accenter()
		{
			Il2CppClassPointerStore<Accenter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Pseudo", "Accenter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Accenter>.NativeClassPtr);
			Accenter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Accenter>.NativeClassPtr, 100664764);
			Accenter.NativeMethodInfoPtr_AddDefaults_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Accenter>.NativeClassPtr, 100664765);
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x0002901C File Offset: 0x0002721C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1076261, RefRangeEnd = 1076262, XrefRangeStart = 1076259, XrefRangeEnd = 1076261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Accenter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Accenter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Accenter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00029058 File Offset: 0x00027258
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1076446, RefRangeEnd = 1076447, XrefRangeStart = 1076262, XrefRangeEnd = 1076446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDefaults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Accenter.NativeMethodInfoPtr_AddDefaults_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00005253 File Offset: 0x00003453
		public Accenter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_AddDefaults_Public_Void_0;
	}
}

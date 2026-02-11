using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020000AA RID: 170
	public sealed class Flare : Object
	{
		// Token: 0x06000E25 RID: 3621 RVA: 0x0004640C File Offset: 0x0004460C
		// Note: this type is marked as 'beforefieldinit'.
		static Flare()
		{
			Il2CppClassPointerStore<Flare>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Flare");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Flare>.NativeClassPtr);
			Flare.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flare>.NativeClassPtr, 100665052);
			Flare.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Flare_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flare>.NativeClassPtr, 100665053);
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x00046464 File Offset: 0x00044664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653293, XrefRangeEnd = 653299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Flare()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Flare>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flare.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x000464A0 File Offset: 0x000446A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653299, XrefRangeEnd = 653301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(Flare self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flare.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Flare_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x00007114 File Offset: 0x00005314
		public Flare(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Flare_0;
	}
}

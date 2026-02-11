using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.canis.actions
{
	// Token: 0x0200024B RID: 587
	public class GainStrength : GainResources
	{
		// Token: 0x06001979 RID: 6521 RVA: 0x0000AFD1 File Offset: 0x000091D1
		// Note: this type is marked as 'beforefieldinit'.
		static GainStrength()
		{
			Il2CppClassPointerStore<GainStrength>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "GainStrength");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainStrength>.NativeClassPtr);
			GainStrength.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainStrength>.NativeClassPtr, 100667907);
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x000BBE60 File Offset: 0x000BA060
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 136711, RefRangeEnd = 136724, XrefRangeStart = 136705, XrefRangeEnd = 136711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainStrength(int amt, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainStrength>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainStrength.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x0000B00A File Offset: 0x0000920A
		public GainStrength(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FBC RID: 4028
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0;
	}
}

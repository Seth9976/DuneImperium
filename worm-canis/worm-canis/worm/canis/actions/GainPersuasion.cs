using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.canis.actions
{
	// Token: 0x0200024A RID: 586
	public class GainPersuasion : GainResources
	{
		// Token: 0x06001976 RID: 6518 RVA: 0x0000AF8F File Offset: 0x0000918F
		// Note: this type is marked as 'beforefieldinit'.
		static GainPersuasion()
		{
			Il2CppClassPointerStore<GainPersuasion>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "GainPersuasion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainPersuasion>.NativeClassPtr);
			GainPersuasion.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainPersuasion>.NativeClassPtr, 100667906);
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x000BBE04 File Offset: 0x000BA004
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 136696, RefRangeEnd = 136705, XrefRangeStart = 136690, XrefRangeEnd = 136696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainPersuasion(int amt, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainPersuasion>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainPersuasion.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x0000AFC8 File Offset: 0x000091C8
		public GainPersuasion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FBB RID: 4027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0;
	}
}

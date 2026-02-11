using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000D8 RID: 216
	public static class HaltonSequence : Object
	{
		// Token: 0x06000FFF RID: 4095 RVA: 0x00008800 File Offset: 0x00006A00
		// Note: this type is marked as 'beforefieldinit'.
		static HaltonSequence()
		{
			Il2CppClassPointerStore<HaltonSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "HaltonSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HaltonSequence>.NativeClassPtr);
			HaltonSequence.NativeMethodInfoPtr_Get_Public_Static_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HaltonSequence>.NativeClassPtr, 100665672);
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x0004A36C File Offset: 0x0004856C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 977307, RefRangeEnd = 977313, XrefRangeStart = 977307, XrefRangeEnd = 977307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Get(int index, int radix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HaltonSequence.NativeMethodInfoPtr_Get_Public_Static_Single_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x00008839 File Offset: 0x00006A39
		public HaltonSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_Single_Int32_Int32_0;
	}
}

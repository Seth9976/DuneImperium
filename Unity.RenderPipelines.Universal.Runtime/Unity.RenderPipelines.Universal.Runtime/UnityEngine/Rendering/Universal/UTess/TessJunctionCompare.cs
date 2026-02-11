using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.UTess
{
	// Token: 0x0200013D RID: 317
	[StructLayout(2)]
	public struct TessJunctionCompare
	{
		// Token: 0x06001AAA RID: 6826 RVA: 0x0000F1EE File Offset: 0x0000D3EE
		// Note: this type is marked as 'beforefieldinit'.
		static TessJunctionCompare()
		{
			Il2CppClassPointerStore<TessJunctionCompare>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.UTess", "TessJunctionCompare");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TessJunctionCompare>.NativeClassPtr);
			TessJunctionCompare.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TessJunctionCompare>.NativeClassPtr, 100666419);
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x0006F964 File Offset: 0x0006DB64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 629875, RefRangeEnd = 629878, XrefRangeStart = 629875, XrefRangeEnd = 629878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Compare(int2 a, int2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TessJunctionCompare.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_int2_int2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x0000F227 File Offset: 0x0000D427
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TessJunctionCompare>.NativeClassPtr, ref this));
		}

		// Token: 0x04001349 RID: 4937
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_int2_int2_0;
	}
}

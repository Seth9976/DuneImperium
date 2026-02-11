using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal.UTess
{
	// Token: 0x0200013A RID: 314
	[StructLayout(2)]
	public struct TessEventCompare
	{
		// Token: 0x06001AA1 RID: 6817 RVA: 0x0000F10D File Offset: 0x0000D30D
		// Note: this type is marked as 'beforefieldinit'.
		static TessEventCompare()
		{
			Il2CppClassPointerStore<TessEventCompare>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.UTess", "TessEventCompare");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TessEventCompare>.NativeClassPtr);
			TessEventCompare.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_UEvent_UEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TessEventCompare>.NativeClassPtr, 100666416);
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x0006F880 File Offset: 0x0006DA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 629868, XrefRangeEnd = 629875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Compare(UEvent a, UEvent b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TessEventCompare.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_UEvent_UEvent_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x0000F146 File Offset: 0x0000D346
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TessEventCompare>.NativeClassPtr, ref this));
		}

		// Token: 0x04001346 RID: 4934
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_UEvent_UEvent_0;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal.UTess
{
	// Token: 0x02000138 RID: 312
	[StructLayout(2)]
	public struct XCompare
	{
		// Token: 0x06001A92 RID: 6802 RVA: 0x0000F015 File Offset: 0x0000D215
		// Note: this type is marked as 'beforefieldinit'.
		static XCompare()
		{
			Il2CppClassPointerStore<XCompare>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.UTess", "XCompare");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XCompare>.NativeClassPtr);
			XCompare.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XCompare>.NativeClassPtr, 100666414);
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x0006F694 File Offset: 0x0006D894
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629858, RefRangeEnd = 629859, XrefRangeStart = 629858, XrefRangeEnd = 629858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Compare(double a, double b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XCompare.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Double_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x0000F04E File Offset: 0x0000D24E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XCompare>.NativeClassPtr, ref this));
		}

		// Token: 0x04001340 RID: 4928
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Double_Double_0;
	}
}

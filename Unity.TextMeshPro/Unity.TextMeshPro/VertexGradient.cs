using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000015 RID: 21
	[Serializable]
	[StructLayout(2)]
	public struct VertexGradient
	{
		// Token: 0x06000237 RID: 567 RVA: 0x00011CA0 File Offset: 0x0000FEA0
		// Note: this type is marked as 'beforefieldinit'.
		static VertexGradient()
		{
			Il2CppClassPointerStore<VertexGradient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "VertexGradient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VertexGradient>.NativeClassPtr);
			VertexGradient.NativeFieldInfoPtr_topLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexGradient>.NativeClassPtr, "topLeft");
			VertexGradient.NativeFieldInfoPtr_topRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexGradient>.NativeClassPtr, "topRight");
			VertexGradient.NativeFieldInfoPtr_bottomLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexGradient>.NativeClassPtr, "bottomLeft");
			VertexGradient.NativeFieldInfoPtr_bottomRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexGradient>.NativeClassPtr, "bottomRight");
			VertexGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexGradient>.NativeClassPtr, 100663572);
			VertexGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexGradient>.NativeClassPtr, 100663573);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00011D48 File Offset: 0x0000FF48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1037922, RefRangeEnd = 1037923, XrefRangeStart = 1037922, XrefRangeEnd = 1037922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VertexGradient(Color color)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00011D7C File Offset: 0x0000FF7C
		[CallerCount(0)]
		public unsafe VertexGradient(Color color0, Color color1, Color color2, Color color3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_Color_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002D40 File Offset: 0x00000F40
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VertexGradient>.NativeClassPtr, ref this));
		}

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeFieldInfoPtr_topLeft;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeFieldInfoPtr_topRight;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeFieldInfoPtr_bottomLeft;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeFieldInfoPtr_bottomRight;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_Color_0;

		// Token: 0x040001A8 RID: 424
		[FieldOffset(0)]
		public Color topLeft;

		// Token: 0x040001A9 RID: 425
		[FieldOffset(16)]
		public Color topRight;

		// Token: 0x040001AA RID: 426
		[FieldOffset(32)]
		public Color bottomLeft;

		// Token: 0x040001AB RID: 427
		[FieldOffset(48)]
		public Color bottomRight;
	}
}

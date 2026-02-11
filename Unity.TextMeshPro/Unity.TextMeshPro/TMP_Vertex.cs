using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000021 RID: 33
	[StructLayout(2)]
	public struct TMP_Vertex
	{
		// Token: 0x06000306 RID: 774 RVA: 0x00013A40 File Offset: 0x00011C40
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Vertex()
		{
			Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Vertex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr);
			TMP_Vertex.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr, "position");
			TMP_Vertex.NativeFieldInfoPtr_uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr, "uv");
			TMP_Vertex.NativeFieldInfoPtr_uv2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr, "uv2");
			TMP_Vertex.NativeFieldInfoPtr_uv4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr, "uv4");
			TMP_Vertex.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr, "color");
			TMP_Vertex.NativeFieldInfoPtr_k_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr, "k_Zero");
			TMP_Vertex.NativeMethodInfoPtr_get_zero_Public_Static_get_TMP_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr, 100663589);
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00013AFC File Offset: 0x00011CFC
		public unsafe static TMP_Vertex zero
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038051, XrefRangeEnd = 1038055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Vertex.NativeMethodInfoPtr_get_zero_Public_Static_get_TMP_Vertex_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000308 RID: 776 RVA: 0x000037EA File Offset: 0x000019EA
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr, ref this));
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00013B2C File Offset: 0x00011D2C
		// (set) Token: 0x0600030A RID: 778 RVA: 0x000037FC File Offset: 0x000019FC
		public unsafe static TMP_Vertex k_Zero
		{
			get
			{
				TMP_Vertex tmp_Vertex;
				IL2CPP.il2cpp_field_static_get_value(TMP_Vertex.NativeFieldInfoPtr_k_Zero, (void*)(&tmp_Vertex));
				return tmp_Vertex;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Vertex.NativeFieldInfoPtr_k_Zero, (void*)(&value));
			}
		}

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeFieldInfoPtr_uv;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeFieldInfoPtr_uv2;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeFieldInfoPtr_uv4;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeFieldInfoPtr_k_Zero;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_TMP_Vertex_0;

		// Token: 0x0400023D RID: 573
		[FieldOffset(0)]
		public Vector3 position;

		// Token: 0x0400023E RID: 574
		[FieldOffset(12)]
		public Vector2 uv;

		// Token: 0x0400023F RID: 575
		[FieldOffset(20)]
		public Vector2 uv2;

		// Token: 0x04000240 RID: 576
		[FieldOffset(28)]
		public Vector2 uv4;

		// Token: 0x04000241 RID: 577
		[FieldOffset(36)]
		public Color32 color;
	}
}

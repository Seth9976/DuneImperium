using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200001B RID: 27
	[Serializable]
	[StructLayout(2)]
	public struct Mesh_Extents
	{
		// Token: 0x06000267 RID: 615 RVA: 0x00012498 File Offset: 0x00010698
		// Note: this type is marked as 'beforefieldinit'.
		static Mesh_Extents()
		{
			Il2CppClassPointerStore<Mesh_Extents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "Mesh_Extents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mesh_Extents>.NativeClassPtr);
			Mesh_Extents.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mesh_Extents>.NativeClassPtr, "min");
			Mesh_Extents.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mesh_Extents>.NativeClassPtr, "max");
			Mesh_Extents.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh_Extents>.NativeClassPtr, 100663581);
			Mesh_Extents.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh_Extents>.NativeClassPtr, 100663582);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00012518 File Offset: 0x00010718
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 636721, RefRangeEnd = 636742, XrefRangeStart = 636721, XrefRangeEnd = 636742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mesh_Extents(Vector2 min, Vector2 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh_Extents.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00012558 File Offset: 0x00010758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037989, XrefRangeEnd = 1038022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh_Extents.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002F0F File Offset: 0x0000110F
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Mesh_Extents>.NativeClassPtr, ref this));
		}

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040001D7 RID: 471
		[FieldOffset(0)]
		public Vector2 min;

		// Token: 0x040001D8 RID: 472
		[FieldOffset(8)]
		public Vector2 max;
	}
}

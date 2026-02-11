using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200000B RID: 11
	[StructLayout(2)]
	public struct Extents
	{
		// Token: 0x06000155 RID: 341 RVA: 0x0000AEC8 File Offset: 0x000090C8
		// Note: this type is marked as 'beforefieldinit'.
		static Extents()
		{
			Il2CppClassPointerStore<Extents>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "Extents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Extents>.NativeClassPtr);
			Extents.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extents>.NativeClassPtr, "min");
			Extents.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extents>.NativeClassPtr, "max");
			Extents.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extents>.NativeClassPtr, 100663443);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000AF34 File Offset: 0x00009134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100089, XrefRangeEnd = 1100122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extents.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002A4D File Offset: 0x00000C4D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Extents>.NativeClassPtr, ref this));
		}

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040000F0 RID: 240
		[FieldOffset(0)]
		public Vector2 min;

		// Token: 0x040000F1 RID: 241
		[FieldOffset(8)]
		public Vector2 max;
	}
}

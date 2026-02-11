using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal.LibTessDotNet
{
	// Token: 0x02000114 RID: 276
	public sealed class ContourVertex : ValueType
	{
		// Token: 0x0600170D RID: 5901 RVA: 0x00062A18 File Offset: 0x00060C18
		// Note: this type is marked as 'beforefieldinit'.
		static ContourVertex()
		{
			Il2CppClassPointerStore<ContourVertex>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.LibTessDotNet", "ContourVertex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContourVertex>.NativeClassPtr);
			ContourVertex.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContourVertex>.NativeClassPtr, "Position");
			ContourVertex.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContourVertex>.NativeClassPtr, "Data");
			ContourVertex.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContourVertex>.NativeClassPtr, 100666017);
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x00062A84 File Offset: 0x00060C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 624317, XrefRangeEnd = 624323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContourVertex.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x0000D3AD File Offset: 0x0000B5AD
		public ContourVertex(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x0000D3B6 File Offset: 0x0000B5B6
		public ContourVertex()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContourVertex>.NativeClassPtr))
		{
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06001711 RID: 5905 RVA: 0x00062AC0 File Offset: 0x00060CC0
		// (set) Token: 0x06001712 RID: 5906 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
		public unsafe Vec3 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContourVertex.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContourVertex.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06001713 RID: 5907 RVA: 0x00062AE8 File Offset: 0x00060CE8
		// (set) Token: 0x06001714 RID: 5908 RVA: 0x0000D3E3 File Offset: 0x0000B5E3
		public unsafe Object Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContourVertex.NativeFieldInfoPtr_Data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContourVertex.NativeFieldInfoPtr_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x040010D3 RID: 4307
		private static readonly IntPtr NativeFieldInfoPtr_Data;

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}

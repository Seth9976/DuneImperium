using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000DC RID: 220
	[Serializable]
	[StructLayout(2)]
	public struct BlendShape
	{
		// Token: 0x0600102A RID: 4138 RVA: 0x00051C20 File Offset: 0x0004FE20
		// Note: this type is marked as 'beforefieldinit'.
		static BlendShape()
		{
			Il2CppClassPointerStore<BlendShape>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "BlendShape");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlendShape>.NativeClassPtr);
			BlendShape.NativeFieldInfoPtr_m_FirstVertex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendShape>.NativeClassPtr, "m_FirstVertex");
			BlendShape.NativeFieldInfoPtr_m_VertexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendShape>.NativeClassPtr, "m_VertexCount");
			BlendShape.NativeFieldInfoPtr_m_HasNormals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendShape>.NativeClassPtr, "m_HasNormals");
			BlendShape.NativeFieldInfoPtr_m_HasTangents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendShape>.NativeClassPtr, "m_HasTangents");
			BlendShape.NativeMethodInfoPtr_get_firstVertex_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendShape>.NativeClassPtr, 100665526);
			BlendShape.NativeMethodInfoPtr_get_vertexCount_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendShape>.NativeClassPtr, 100665527);
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x0600102B RID: 4139 RVA: 0x00051CC8 File Offset: 0x0004FEC8
		// (set) Token: 0x0600102E RID: 4142 RVA: 0x000073E0 File Offset: 0x000055E0
		public unsafe uint firstVertex
		{
			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendShape.NativeMethodInfoPtr_get_firstVertex_Public_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_FirstVertex = value;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x00051CF8 File Offset: 0x0004FEF8
		// (set) Token: 0x0600102F RID: 4143 RVA: 0x000073EA File Offset: 0x000055EA
		public unsafe uint vertexCount
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 283125, RefRangeEnd = 283150, XrefRangeStart = 283125, XrefRangeEnd = 283150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendShape.NativeMethodInfoPtr_get_vertexCount_Public_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_VertexCount = value;
			}
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x000073CE File Offset: 0x000055CE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlendShape>.NativeClassPtr, ref this));
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001030 RID: 4144 RVA: 0x00051D28 File Offset: 0x0004FF28
		// (set) Token: 0x06001031 RID: 4145 RVA: 0x000073F4 File Offset: 0x000055F4
		public bool hasNormals
		{
			get
			{
				return this.m_HasNormals;
			}
			set
			{
				this.m_HasNormals = value;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x00051D40 File Offset: 0x0004FF40
		// (set) Token: 0x06001033 RID: 4147 RVA: 0x000073FE File Offset: 0x000055FE
		public bool hasTangents
		{
			get
			{
				return this.m_HasTangents;
			}
			set
			{
				this.m_HasTangents = value;
			}
		}

		// Token: 0x04000E4A RID: 3658
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstVertex;

		// Token: 0x04000E4B RID: 3659
		private static readonly IntPtr NativeFieldInfoPtr_m_VertexCount;

		// Token: 0x04000E4C RID: 3660
		private static readonly IntPtr NativeFieldInfoPtr_m_HasNormals;

		// Token: 0x04000E4D RID: 3661
		private static readonly IntPtr NativeFieldInfoPtr_m_HasTangents;

		// Token: 0x04000E4E RID: 3662
		private static readonly IntPtr NativeMethodInfoPtr_get_firstVertex_Public_get_UInt32_0;

		// Token: 0x04000E4F RID: 3663
		private static readonly IntPtr NativeMethodInfoPtr_get_vertexCount_Public_get_UInt32_0;

		// Token: 0x04000E50 RID: 3664
		[FieldOffset(0)]
		public uint m_FirstVertex;

		// Token: 0x04000E51 RID: 3665
		[FieldOffset(4)]
		public uint m_VertexCount;

		// Token: 0x04000E52 RID: 3666
		[FieldOffset(8)]
		[MarshalAs(4)]
		public bool m_HasNormals;

		// Token: 0x04000E53 RID: 3667
		[FieldOffset(9)]
		[MarshalAs(4)]
		public bool m_HasTangents;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200000C RID: 12
	public class PolyTree : PolyNode
	{
		// Token: 0x0600009A RID: 154 RVA: 0x0001755C File Offset: 0x0001575C
		// Note: this type is marked as 'beforefieldinit'.
		static PolyTree()
		{
			Il2CppClassPointerStore<PolyTree>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "PolyTree");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PolyTree>.NativeClassPtr);
			PolyTree.NativeFieldInfoPtr_m_AllPolys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolyTree>.NativeClassPtr, "m_AllPolys");
			PolyTree.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolyTree>.NativeClassPtr, 100663387);
			PolyTree.NativeMethodInfoPtr_GetFirst_Public_PolyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolyTree>.NativeClassPtr, 100663388);
			PolyTree.NativeMethodInfoPtr_get_Total_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolyTree>.NativeClassPtr, 100663389);
			PolyTree.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolyTree>.NativeClassPtr, 100663390);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000175F0 File Offset: 0x000157F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 596919, RefRangeEnd = 596921, XrefRangeStart = 596911, XrefRangeEnd = 596919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolyTree.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00017624 File Offset: 0x00015824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596921, XrefRangeEnd = 596923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PolyNode GetFirst()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolyTree.NativeMethodInfoPtr_GetFirst_Public_PolyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PolyNode>(intPtr3) : null;
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00017664 File Offset: 0x00015864
		public unsafe int Total
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 596929, RefRangeEnd = 596931, XrefRangeStart = 596923, XrefRangeEnd = 596929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolyTree.NativeMethodInfoPtr_get_Total_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000176A0 File Offset: 0x000158A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596931, XrefRangeEnd = 596939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PolyTree()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PolyTree>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolyTree.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002491 File Offset: 0x00000691
		public PolyTree(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000176DC File Offset: 0x000158DC
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000249A File Offset: 0x0000069A
		public unsafe List<PolyNode> m_AllPolys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolyTree.NativeFieldInfoPtr_m_AllPolys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PolyNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolyTree.NativeFieldInfoPtr_m_AllPolys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_m_AllPolys;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_GetFirst_Public_PolyNode_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_get_Total_Public_get_Int32_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

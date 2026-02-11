using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000019 RID: 25
	public class IntersectNode : Object
	{
		// Token: 0x06000103 RID: 259 RVA: 0x00018B58 File Offset: 0x00016D58
		// Note: this type is marked as 'beforefieldinit'.
		static IntersectNode()
		{
			Il2CppClassPointerStore<IntersectNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "IntersectNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntersectNode>.NativeClassPtr);
			IntersectNode.NativeFieldInfoPtr_Edge1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntersectNode>.NativeClassPtr, "Edge1");
			IntersectNode.NativeFieldInfoPtr_Edge2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntersectNode>.NativeClassPtr, "Edge2");
			IntersectNode.NativeFieldInfoPtr_Pt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntersectNode>.NativeClassPtr, "Pt");
			IntersectNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntersectNode>.NativeClassPtr, 100663428);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00018BD8 File Offset: 0x00016DD8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntersectNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntersectNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntersectNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000027CC File Offset: 0x000009CC
		public IntersectNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00018C14 File Offset: 0x00016E14
		// (set) Token: 0x06000107 RID: 263 RVA: 0x000027D5 File Offset: 0x000009D5
		public unsafe TEdge Edge1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntersectNode.NativeFieldInfoPtr_Edge1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TEdge>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntersectNode.NativeFieldInfoPtr_Edge1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00018C44 File Offset: 0x00016E44
		// (set) Token: 0x06000109 RID: 265 RVA: 0x000027F4 File Offset: 0x000009F4
		public unsafe TEdge Edge2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntersectNode.NativeFieldInfoPtr_Edge2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TEdge>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntersectNode.NativeFieldInfoPtr_Edge2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00018C74 File Offset: 0x00016E74
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00002813 File Offset: 0x00000A13
		public unsafe IntPoint Pt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntersectNode.NativeFieldInfoPtr_Pt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntersectNode.NativeFieldInfoPtr_Pt)) = value;
			}
		}

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeFieldInfoPtr_Edge1;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeFieldInfoPtr_Edge2;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeFieldInfoPtr_Pt;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

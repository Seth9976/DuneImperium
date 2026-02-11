using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000020 RID: 32
	public class Join : Object
	{
		// Token: 0x06000147 RID: 327 RVA: 0x00019520 File Offset: 0x00017720
		// Note: this type is marked as 'beforefieldinit'.
		static Join()
		{
			Il2CppClassPointerStore<Join>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "Join");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Join>.NativeClassPtr);
			Join.NativeFieldInfoPtr_OutPt1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Join>.NativeClassPtr, "OutPt1");
			Join.NativeFieldInfoPtr_OutPt2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Join>.NativeClassPtr, "OutPt2");
			Join.NativeFieldInfoPtr_OffPt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Join>.NativeClassPtr, "OffPt");
			Join.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Join>.NativeClassPtr, 100663436);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000195A0 File Offset: 0x000177A0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Join()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Join>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Join.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002AB0 File Offset: 0x00000CB0
		public Join(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600014A RID: 330 RVA: 0x000195DC File Offset: 0x000177DC
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00002AB9 File Offset: 0x00000CB9
		public unsafe OutPt OutPt1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Join.NativeFieldInfoPtr_OutPt1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OutPt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Join.NativeFieldInfoPtr_OutPt1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600014C RID: 332 RVA: 0x0001960C File Offset: 0x0001780C
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00002AD8 File Offset: 0x00000CD8
		public unsafe OutPt OutPt2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Join.NativeFieldInfoPtr_OutPt2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OutPt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Join.NativeFieldInfoPtr_OutPt2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600014E RID: 334 RVA: 0x0001963C File Offset: 0x0001783C
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00002AF7 File Offset: 0x00000CF7
		public unsafe IntPoint OffPt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Join.NativeFieldInfoPtr_OffPt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Join.NativeFieldInfoPtr_OffPt)) = value;
			}
		}

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeFieldInfoPtr_OutPt1;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr_OutPt2;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_OffPt;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
